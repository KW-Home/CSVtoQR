Imports System.Drawing.Text
Imports System.IO
Imports System.Net.WebRequestMethods
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports CSVtoQR.Class_DS

Public Class Form1

    Private DS As New DataSet

    Private MyFont As Font
    Private WithEvents UC_Font As UserControl_Font

    Private CL_CSV As New Class_CSV
    Private CL_Default As Class_Default
    Private CL_DS As New Class_DS
    Private CL_P As New Class_Paint
    Private CL_FF As New Class_Form1_Funktionen

    Private DT_CSV As DataTable
    Private DV_CSV As DataView

    Private WithEvents CL_XML As New Class_XML

    Private IsModified_Value As Boolean
    Public Property IsModified() As Boolean
        Get
            Return IsModified_Value
        End Get
        Set(ByVal value As Boolean)
            IsModified_Value = value
            If value = True Then
                ToolStripStatusLabel_IsModified.BackColor = Color.Red
            Else
                ToolStripStatusLabel_IsModified.BackColor = Color.Green
            End If
        End Set
    End Property

    Private ImportFile_Value As String
    Public Property ImportFile() As String
        Get
            Return ImportFile_Value
        End Get
        Set(ByVal value As String)
            ImportFile_Value = value
            DS = CL_DS.Get_DS(DS)
            DS.Tables("Shema").Rows(0).Item("Import") = value
            Load_CSV(value)
            SET_Changetext_CSV(value)

            Set_CardRow_DataBinding()

        End Set
    End Property

    Private ExportFile_Value As String
    Property ExportFile() As String
        Get
            Return ExportFile_Value
        End Get
        Set(ByVal value As String)
            Dim finalPath As String = If(value, String.Empty)

            If String.IsNullOrWhiteSpace(finalPath) Then
                ExportFile_Value = String.Empty
            Else
                If finalPath.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase) = False Then
                    Try
                        finalPath = System.IO.Path.ChangeExtension(finalPath, ".pdf")
                    Catch
                        finalPath &= ".pdf"
                    End Try
                End If

                ExportFile_Value = finalPath
            End If

            'If IsNothing(DS.Tables("Shema")) = False Then CL_DS.Get_DS(DS)
            'If DS.Tables("Shema").Rows.Count = 0 Then CL_DS.GET_Shema(DS)

            DS.Tables("Shema").Rows(0).Item("Export") = ExportFile_Value

            SET_Changetext_PDF(ExportFile_Value)

            'MessageBox.Show($"ExportFile {vbNewLine}{CL_FF.Check_Path(ExportFile_Value)}", "ExportFile")


        End Set
    End Property

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        MySettings_Load()
        DS = CL_DS.Get_DS(DS)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'lädt die Einstellungen, die im Designer unter "My.Settings" definiert wurden   

        'Initialisiert die Standardwerte und -einstellungen für die Anwendung
        UserControl_Font_General_Load()
        UserControl_Font_Card_Load()
        UserControl_Font_CardRow_Load()

        CL_Default = New Class_Default(Me, DS)


        'lädt die Daten aus dem DataSet in die Steuerelemente
        DataSetRead()

        'zeichnet die Papiervorschau basierend auf den aktuellen Einstellungen
        PaperPaint(Nothing, Nothing)

    End Sub
    Private Sub MySettings_Load()



        With My.Settings

            MyFont = .MyFont

            Me.Font = MyFont
            Me.Size = .MySize

            If System.IO.File.Exists(CL_XML.DataSetFile) = True Then

                DS = CL_DS.Get_DS(DS)
                'CL_DS.GET_Shema(DS)

                CL_XML.DataSetFile = CL_XML.DataSetFile
                CL_XML.ReadXML(DS)

                'ToDo: Fehler nach Pull 
                'System.NullReferenceException: "Der Objektverweis wurde nicht auf eine Objektinstanz festgelegt."

                Dim DT As DataTable = DS.Tables("Shema")
                If DT.Rows.Count > 0 Then
                    ImportFile = DT(0)("Import").ToString()
                    ExportFile = DT(0)("Export").ToString()
                Else
                    DS = CL_DS.Get_DS(DS)
                End If

            Else
                DS = CL_DS.Get_DS(DS)
                TextBox_General_XML_Directory.Text = "Kein gültiger Pfad."
                TextBox_General_XML_Filename.Text = "Kein gültiger Name."
                ToolStripStatusLabel_SaveFile.Text = "Kein gültiger Pfad."
            End If

        End With

    End Sub
    Private Sub MySettings_Save()

        Me.WindowState = FormWindowState.Normal

        With My.Settings

            .MySize = Me.Size
            .MyFont = MyFont
            .MySpliter = SplitContainer_Main.SplitterDistance

            .Save()

        End With

    End Sub

    Private Sub Load_CSV(ByVal Value As String)

        DT_CSV = CL_CSV.GET_CSV(DS, CL_DS, Value)
        DV_CSV = New DataView(DT_CSV)

        BindingSource_CSV.DataSource = DV_CSV
        BindingNavigator_CSV.BindingSource = BindingSource_CSV
        DGV_CSV.DataSource = BindingSource_CSV

        DGV_Search_Formatting()

        If DT_CSV IsNot Nothing Then
            With ComboBox_CardRow_DataColumn
                .DataSource = Nothing
                .DataSource = DT_CSV.Columns.Cast(Of DataColumn)().Select(Function(c) c.ColumnName).ToList()
            End With
        End If

    End Sub

    Private Sub ListBox_Tabellen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Tabellen.SelectedIndexChanged

        If ListBox_Tabellen.SelectedIndex < 0 Then Return
        DGV_Table.DataSource = DS.Tables(ListBox_Tabellen.SelectedItem.ToString)

    End Sub

    Private Sub DataSetRead()

        If IsNothing(DS) Then DS = CL_DS.Get_DS(DS)

        Dim DR As DataRow

        'Shema auslesen und in die entsprechenden Steuerelemente einfügen

        DR = DS.Tables("Shema").Rows(0)
        TextBox_Paper_Shema.Text = DR("Shema").ToString
        ImportFile = DR("Import").ToString
        ExportFile = DR("Export").ToString
        ComboBox_Paper_DPI.Text = DR("DPI")
        ComboBox_Paper_DIN.Text = DR("DIN").ToString
        NumericUpDown_Paper_Border_Left.Value = DR("Left")
        NumericUpDown_Paper_Border_Top.Value = DR("Top")
        NumericUpDown_Paper_Border_Right.Value = DR("Right")
        NumericUpDown_Paper_Border_Bottom.Value = DR("Bottom")
        Label_Paper_Height_Value.Text = DR("PaperHeight").ToString
        Label_Paper_Width_Value.Text = DR("PaperWidth")
        NumericUpDown_Separator_Column_Count.Value = DR("SeparatorSpalteAnzahl")
        NumericUpDown_Separator_Column_Value.Value = DR("SeparatorSpalteWert")
        NumericUpDown_Separator_Row_Count.Value = DR("SeparatorZeileAnzahl")
        NumericUpDown_Separator_Row_Value.Value = DR("SeparatorZeileWert")

        'Card auslesen und in die entsprechenden Steuerelemente einfügen
        'If DS.Tables("Card").Rows.Count = 0 Then CL_DS.GET_Card(DS)
        DR = DS.Tables("Card").Rows(0)
        NumericUpDown_Card_Border_Left.Value = If(IsDBNull(DR("Left")), 0, CType(DR("Left"), Decimal))
        NumericUpDown_Card_Border_Top.Value = If(IsDBNull(DR("Top")), 0, CType(DR("Top"), Decimal))
        NumericUpDown_Card_Border_Right.Value = If(IsDBNull(DR("Right")), 0, CType(DR("Right"), Decimal))
        NumericUpDown_Card_Border_Bottom.Value = If(IsDBNull(DR("Bottom")), 0, CType(DR("Bottom"), Decimal))
        Label_Card_Size_Hight_Value.Text = 0
        Label_Card_Size_Width_Value.Text = 0


        'CardRow auslesen und in die entsprechenden Steuerelemente einfügen
        If ListBox_CardRow.SelectedIndex = -1 Then
            NumericUpDown_CardRow_Border_Left.Value = 0
            NumericUpDown_CardRow_Border_Top.Value = 0
            NumericUpDown_CardRow_Border_Right.Value = 0
            NumericUpDown_CardRow_Border_Bottom.Value = 0
        Else

            Dim ID As Integer = ListBox_CardRow.SelectedItem("ID")
            If DS.Tables("CardRow").Rows.Count = 0 Then
                CL_DS.GET_CardRow(DS, ID)
            End If
            DR = DS.Tables("CardRow").Select($"[ID]={ID}")(0)

            NumericUpDown_CardRow_Border_Left.Value = If(IsDBNull(DR("Left")), 0, CType(DR("Left"), Decimal))
            NumericUpDown_CardRow_Border_Top.Value = If(IsDBNull(DR("Top")), 0, CType(DR("Top"), Decimal))
            NumericUpDown_CardRow_Border_Right.Value = If(IsDBNull(DR("Right")), 0, CType(DR("Right"), Decimal))
            NumericUpDown_CardRow_Border_Bottom.Value = If(IsDBNull(DR("Bottom")), 0, CType(DR("Bottom"), Decimal))
        End If

        DGV_Search.DataSource = Nothing
        If Not IsNothing(DS.Tables("Search")) Then
            With DS.Tables("Search")
                If .Rows.Count = 0 Then Exit Sub
                DGV_Search.DataSource = DS.Tables("Search")
            End With
        End If

    End Sub
    Private Sub Button_Import_Click(sender As Object, e As EventArgs) Handles Button_General_Import.Click

        Dim Path As String = CL_XML.DataSetFile
        Dim OFD As New OpenFileDialog With {.Title = "Import CSV-Datei", .Filter = "CSV-Dateien (*.CSV)|*.CSV|Alle Dateien (*.*)|*.*"}

        If IsNothing(Path) = False Then

            If System.IO.Directory.Exists(Path) = False AndAlso Path.Length > 0 Then
                OFD.InitialDirectory = System.IO.Path.GetDirectoryName(Path)
                OFD.FileName = System.IO.Path.GetFileName(Path)
            End If

        End If
        If OFD.ShowDialog = DialogResult.OK Then
            ImportFile = OFD.FileName
        End If

    End Sub
    Private Sub Button_Export_Click(sender As Object, e As EventArgs) Handles Button_General_Export.Click

        Dim FBD As New FolderBrowserDialog
        'With { .Title = "Export PDF-Datei", .Filter = "PDF-Dateien (*.PDF)|*.PDF|Alle Dateien (*.*)|*.*"}

        If FBD.ShowDialog = DialogResult.OK Then
            ExportFile = FBD.SelectedPath
        End If

    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If IsModified = True Then
            Dim Result As DialogResult = MessageBox.Show("Wollen Sie Speichern ?", "Achtung Datenverlust !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            Select Case Result
                Case DialogResult.Yes

                    If IsNothing(CL_XML.DataSetFile) = True Then
                        If SaveFileDialog_XML() = DialogResult.Cancel Then
                            e.Cancel = True
                            Return
                        End If
                    End If

                    CL_XML.SaveXML(DS)
                    MySettings_Save()

                Case DialogResult.No
                    ' Do nothing
                Case DialogResult.Cancel
                    e.Cancel = True
            End Select
        Else
            e.Cancel = False
        End If

    End Sub
    Public Sub NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Separator_Row_Value.ValueChanged,
        NumericUpDown_Separator_Row_Count.ValueChanged, NumericUpDown_Separator_Column_Value.ValueChanged,
        NumericUpDown_Separator_Column_Count.ValueChanged

        If sender.canselect = False Then Return
        If sender.canfocus = False Then Return
        IsModified = True

        Dim ObjName As String = sender.tag
        DS.Tables("Shema").Rows(0).Item(ObjName) = sender.value

        PaperPaint(Nothing, Nothing)

    End Sub
    Public Sub NumericUpDown_Border_Paper_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Paper_Border_Top.ValueChanged,
        NumericUpDown_Paper_Border_Right.ValueChanged, NumericUpDown_Paper_Border_Left.ValueChanged, NumericUpDown_Paper_Border_Bottom.ValueChanged

        If sender.canselect = False Then Return
        DS.Tables("Shema")(0)(sender.tag) = If(IsNumeric(sender.value) = True, CDbl(sender.value), 0)
        IsModified = True

        PaperPaint(Nothing, Nothing)

    End Sub
    Private Sub NumericUpDown_Border_Card_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Card_Border_Top.ValueChanged, NumericUpDown_Card_Border_Right.ValueChanged, NumericUpDown_Card_Border_Left.ValueChanged, NumericUpDown_Card_Border_Bottom.ValueChanged

        If sender.canselect = False Then Return
        DS.Tables("Card")(0)(sender.tag) = If(IsNumeric(sender.value) = True, CDbl(sender.value), 0)
        IsModified = True

    End Sub
    Private Sub TextBox_Paper_Shema_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Paper_Shema.TextChanged

        If sender.canselect = False Then Return
        If sender.canfocus = False Then Return
        DS = CL_DS.Get_DS(DS)
        DS.Tables("Shema").Rows(0).Item("Shema") = TextBox_Paper_Shema.Text
        IsModified = True

    End Sub
    Private Sub TextBox_General_Import_TextChanged(sender As Object, e As EventArgs) Handles TextBox_General_Import_Directory.TextChanged, TextBox_General_Import_Filename.TextChanged

        If sender.canselect = False Then Return
        If sender.canfocus = False Then Return

        Dim File As String
        File = TextBox_General_Import_Directory.Text
        If My.Computer.FileSystem.DirectoryExists(File) = False Then Return
        File &= "\" & TextBox_General_Import_Filename.Text
        If My.Computer.FileSystem.FileExists(File) = False Then Return

        DS = CL_DS.Get_DS(DS)
        IsModified = CType(DS.Tables("Shema").Rows(0).Item("Import") = File, Boolean)
        DS.Tables("Shema").Rows(0).Item("Import") = File

    End Sub
    Private Sub TextBox_General_Export_TextChanged(sender As Object, e As EventArgs) Handles TextBox_General_Export_Directory.TextChanged, TextBox_General_Export_Filename.TextChanged

        If sender.canselect = False Then Return
        If sender.canfocus = False Then Return

        Dim File As String
        File = TextBox_General_Export_Directory.Text
        If My.Computer.FileSystem.DirectoryExists(File) = False Then Return
        File &= "\" & TextBox_General_Export_Filename.Text

        DS = CL_DS.Get_DS(DS)
        IsModified = CType(DS.Tables("Shema").Rows(0).Item("Export") = File, Boolean)
        DS.Tables("Shema").Rows(0).Item("Export") = File

    End Sub
    Private Sub CSVSearch()

        DGV_Search.EndEdit()

        Dim FilterString As String = String.Empty
        If DGV_Search.Columns.Count = 0 Then
            DV_CSV.RowFilter = String.Empty
            Return
        End If

        Dim FilterColumn As String
        Dim FilterOperator As String
        Dim FilterValue As String

        Dim DT As DataTable
        Dim DR() As DataRow

        For Each Wert As DataRow In DS.Tables("Search").Rows

            If Wert("Search_Column") Is DBNull.Value Then Continue For

            FilterColumn = Wert("Search_Column").ToString()
            FilterOperator = Wert("Search_Operator").ToString()
            FilterValue = Wert("Search_Value").ToString()

            DT = DS.Tables("Search_Operator")
            DT = CL_DS.DT_Search_Operator

            DR = DT.Select($"[Operator] = '{FilterOperator}' ")

            If FilterColumn Is Nothing OrElse FilterColumn.ToString.Trim.Length = 0 Then Continue For
            If FilterOperator Is Nothing OrElse FilterOperator.ToString.Trim.Length = 0 Then Continue For
            If FilterString.Length > 0 Then FilterString &= " And "
            FilterString &= $"[{FilterColumn}] {DR(0)("Operator_Left")}{FilterValue}{DR(0)("Operator_Right")}"

        Next

        Try
            DV_CSV.RowFilter = FilterString
        Catch ex As Exception
        End Try

    End Sub
    Private Sub Button_SearchAdd_Click(sender As Object, e As EventArgs) Handles Button_Search_Add.Click

        If DGV_CSV.Columns(DGV_CSV.CurrentCell.ColumnIndex).Name = "ID" Then Return

        Dim DT As DataTable = DS.Tables("Search")
        Dim DR As DataRow = DT.NewRow
        With DR
            .Item("Search_Column") = DGV_CSV.Columns(DGV_CSV.CurrentCell.ColumnIndex).HeaderText
            .Item("Search_Operator") = "Gleich"
            .Item("Search_Value") = DGV_CSV.CurrentCell.Value.ToString
        End With
        DT.Rows.Add(DR)

        DGV_Search.DataSource = DT
        DGV_Search.Update()

        CSVSearch()

    End Sub

    Private Sub DGV_Search_Formatting()

        'ToDo: Überprüfen, ob die Spalten bereits existieren, um Duplikate zu vermeiden.
        'Aktuell wird immer eine neue Spalte hinzugefügt, was zu mehreren "Search_Column" und "Search_Operator" Spalten führen kann.

        DGV_Search.Columns.Clear()

        '0. Erstelle die TextBox-Spalte für die ID
        Dim Search_ID As New DataGridViewTextBoxColumn() With {
            .Name = "ID",
            .HeaderText = "ID",
            .DataPropertyName = "ID",
            .ValueType = GetType(Integer),
            .ReadOnly = True,
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells}
        If DGV_Search.Columns.ToString.Contains("ID") Then DGV_Search.Columns.Remove("ID")
        DGV_Search.Columns.Insert(0, Search_ID)

        '1. Erstelle die ComboBox-Spalte für die Spaltennamen
        Dim Search_Column As New DataGridViewComboBoxColumn() With {
            .Name = "Search_Column",
            .HeaderText = "Spalte",
            .DataPropertyName = "Search_Column",
            .DataSource = DS.Tables("Search_Columns"),
            .DisplayMember = "Column",
            .ValueMember = "Column",
            .ValueType = GetType(String),
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
            .FlatStyle = FlatStyle.Flat}
        If DGV_Search.Columns.ToString.Contains("Search_Column") Then DGV_Search.Columns.Remove("Search_Column")
        DGV_Search.Columns.Insert(1, Search_Column)

        '2. Erstelle die ComboBox-Spalte für die Operatoren
        Dim Search_Operator As New DataGridViewComboBoxColumn() With {
            .Name = "Search_Operator",
            .HeaderText = "Operator",
            .DataPropertyName = "Search_Operator",
            .DataSource = CL_DS.DT_Search_Operator,
            .DisplayMember = "Operator",
            .ValueMember = "Operator",
            .ValueType = GetType(String),
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
            .FlatStyle = FlatStyle.Flat}
        If DGV_Search.Columns.ToString.Contains("Search_Operator") Then DGV_Search.Columns.Remove("Search_Operator")
        DGV_Search.Columns.Insert(2, Search_Operator)

        '3. Erstelle die TextBox-Spalte für die Werte
        Dim Search_Value As New DataGridViewTextBoxColumn() With {
            .Name = "Search_Value",
            .HeaderText = "Suche",
            .DataPropertyName = "Search_Value",
            .ValueType = GetType(String),
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells}
        If DGV_Search.Columns.ToString.Contains("Search_Value") Then DGV_Search.Columns.Remove("Search_Value")
        DGV_Search.Columns.Insert(3, Search_Value)

    End Sub

    Private Sub Button_SearchDelete_Click(sender As Object, e As EventArgs) Handles Button_Search_Delete.Click

        If DGV_Search.SelectedCells.Count = 0 Then Return

        DGV_Search.Rows(DGV_Search.SelectedCells(0).RowIndex).Selected = True
        For Each DR As DataGridViewRow In DGV_Search.SelectedRows
            If DR.IsNewRow Then Continue For
            DGV_Search.Rows.Remove(DR)
        Next
        IsModified = True
        CSVSearch()

    End Sub

    Private Sub PaperPaint(Sender As Object, e As EventArgs) Handles NumericUpDown_Separator_Column_Count.ValueChanged, NumericUpDown_Separator_Column_Value.ValueChanged,
        NumericUpDown_Separator_Row_Count.ValueChanged, NumericUpDown_Separator_Row_Value.ValueChanged,
        NumericUpDown_Paper_Border_Left.ValueChanged, NumericUpDown_Paper_Border_Top.ValueChanged, NumericUpDown_Paper_Border_Right.ValueChanged, NumericUpDown_Paper_Border_Bottom.ValueChanged

        'CL_DS.GET_Shema(DS)
        CL_P.Ivalidate_Paper(Me, DS)

    End Sub

    Public Sub CB_DIN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Paper_DIN.SelectedIndexChanged

        If ComboBox_Paper_DIN.SelectedIndex = -1 Then Return
        If ComboBox_Paper_DIN.CanFocus = False Then Return

        DS.Tables("Shema").Rows(0)("DIN") = CType(ComboBox_Paper_DIN.Text, String)

        DS.Tables("Shema").Rows(0)("PaperHeight") = CType(ComboBox_Paper_DIN.SelectedItem("PaperHeight"), Integer)
        Label_Paper_Height_Value.Text = ComboBox_Paper_DIN.SelectedItem("PaperHeight").ToString

        DS.Tables("Shema").Rows(0)("PaperWidth") = CType(ComboBox_Paper_DIN.SelectedItem("PaperWidth"), Integer)
        Label_Paper_Width_Value.Text = ComboBox_Paper_DIN.SelectedItem("PaperWidth").ToString

        IsModified = True

    End Sub

    Public Sub CB_DPI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Paper_DPI.SelectedIndexChanged
        DS.Tables("Shema").Rows(0)("DPI") = CType(ComboBox_Paper_DPI.Text, Integer)
    End Sub

    Private Sub DGV_Search_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGV_Search.DataError
        e.Cancel = True
    End Sub

    Private Sub DGV_Search_DataSourceChanged(sender As Object, e As EventArgs) Handles DGV_Search.DataSourceChanged

        CSVSearch()

    End Sub

    Private Sub Button_Search_Refresh_Click(sender As Object, e As EventArgs) Handles Button_Search_Refresh.Click

        CSVSearch()

    End Sub

    Private Sub Main_TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl_Main.SelectedIndexChanged

        Select Case TabControl_Main.TabPages(TabControl_Main.SelectedIndex).Name
            Case "TabPage_Files", "TabPage_Data", "TabPage_Table"
                SplitContainer_Main.Panel2Collapsed = True
            Case Else
                SplitContainer_Main.Panel2Collapsed = False
        End Select

    End Sub

#Region "ToolStripMenu"

    Private Sub ToolStripMenuItem_XML_New_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_XML_New.Click

        SaveFileDialog_XML()

    End Sub

    Private Sub ToolStripMenuItem_XML_Save(sender As Object, e As EventArgs) Handles ToolStripMenuItem_XML_SaveAs.Click, ToolStripMenuItem_XML_Safe.Click

        Select Case sender.name
            Case ToolStripMenuItem_XML_Safe.Name
                If System.IO.File.Exists(CL_XML.DataSetFile) Then
                    CL_XML.SaveXML(DS)
                    IsModified = False
                Else
                    SaveFileDialog_XML()
                End If
            Case ToolStripMenuItem_XML_SaveAs.Name
                SaveFileDialog_XML()
        End Select

    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Beenden.Click

        Me.Close()

    End Sub

#End Region
#Region "Save XML"
    Private Function SaveFileDialog_XML() As DialogResult

        Dim SFD As New SaveFileDialog
        With SFD
            .CheckPathExists = True
            .Title = "Die Datei Speichern (" & CL_XML.DataSetFile & ")"
            .InitialDirectory = System.IO.Path.GetDirectoryName(CL_XML.DataSetFile)
            .FileName = TextBox_Paper_Shema.Text
            .Filter = "XML-Dateien (*.xml)|*.xml|Alle Dateien (*.*)|*.*"
        End With

        If SFD.ShowDialog = DialogResult.OK Then
            DS = CL_DS.Get_DS(Nothing)

            CL_XML.DataSetFile = SFD.FileName
            CL_XML.SaveXML(DS)

            DataSetRead()
            IsModified = False

        End If

        Return DialogResult

    End Function
    Private Sub XML_Open_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_XML_Open.Click, Button_General_XML_Open.Click

        CL_XML.OpenFileDialog_XML(DS)
        DataSetRead()

        ListBox_Tabellen.Items.Clear()
        ListBox_Tabellen.Items.AddRange(DS.Tables.Cast(Of DataTable).Select(Function(t) t.TableName).ToArray())

    End Sub
    Private Sub CL_XML_Changetext(sender As Object, e As Object) Handles CL_XML.Changetext

        SET_Changetext_XML(sender, e)

    End Sub
    Private Sub SET_Changetext_XML(sender As Object, e As Object)

        Dim FI As New FileInfo(e)

        With FI
            TextBox_General_XML_Directory.Text = .Directory.ToString
            TextBox_General_XML_Filename.Text = .Name.ToString
            ToolStripStatusLabel_SaveFile.Text = .FullName
        End With

        IsModified = False

    End Sub
    Private Sub SET_Changetext_CSV(File As String)

        If My.Computer.FileSystem.FileExists(File) = False Then Return

        Dim FI As New FileInfo(File)
        With FI
            TextBox_General_Import_Directory.Text = .Directory.ToString
            TextBox_General_Import_Filename.Text = .Name.ToString
        End With

        IsModified = False

    End Sub
    Private Sub SET_Changetext_PDF(File As String)

        'ToDo Ordner Überprüfen und erstellen fals nicht vorhanden
        If System.IO.File.Exists(File) = True Then MessageBox.Show("Die Datei wurde nicht gefunden.", "Export in PDF")
        If File.Length = 0 Then Return

        Dim FI As New FileInfo(File)
        TextBox_General_Export_Directory.Text = FI.Directory.ToString
        TextBox_General_Export_Filename.Text = FI.Name.ToString

        IsModified = False

    End Sub

    Private Sub Button_CardRow_Add_Click(sender As Object, e As EventArgs) Handles Button_CardRow_Add.Click

        Save_CardRow(-1)
        Set_CardRow_DataBinding()

        'Dim DR As DataRow = DS.Tables("CardRow").NewRow
        'With DR
        '    .Item("QRCode") = CheckBox_CardRow_QRCode.Checked
        '    .Item("DataColumn") = ComboBox_CardRow_DataColumn.SelectedItem.ToString
        '    .Item("LinePos") = Label_CardRow_LinePos_Value.Text

        '    'ToDo: Überprüfen, ob die Font-Informationen korrekt in das DataRow-Objekt eingefügt werden. Aktuell wird eine neue Font mit festen Werten erstellt, was möglicherweise nicht den Erwartungen entspricht.
        '    .Item("Font") = New Class_FontConverter().FontToString(New Font("Arial", 12, FontStyle.Regular))

        '    'ToDo: Überprüfen, ob die FontColor-Informationen korrekt in das DataRow-Objekt eingefügt werden. Aktuell wird ein leerer String verwendet, was möglicherweise nicht den Erwartungen entspricht.
        '    .Item("FontColor") = String.Empty

        '    .Item("AutoFont") = False

        'End With
        'DS.Tables("CardRow").Rows.Add(DR)

        'CardRow_Sort(sender, e)

    End Sub
    Private Sub Set_CardRow_DataBinding()

        ListBox_CardRow.DataSource = Nothing

        Dim DR() As DataRow = DS.Tables("CardRow").Select("", "LinePos ASC")

        If DR.Length = 0 Then Return

        Dim DT As DataTable = DS.Tables("CardRow").Clone
        For I = 0 To DR.Length - 1 Step 1
            DT.ImportRow(DR(I))
            DR(I)("LinePos") = I + 1
        Next

        With ListBox_CardRow
            .DataSource = DT
            .DisplayMember = "DataColumn"
            .ValueMember = "ID"
        End With

        ListBox_CardRow.ClearSelected()

    End Sub

    Private Sub Button_CardRow_List_Delete_Click(sender As Object, e As EventArgs) Handles Button_CardRow_Delete.Click

        With ListBox_CardRow
            If .SelectedItems.Count = 0 Then Return
            Dim ID As Integer = .SelectedItem("ID")
            DS.Tables("CardRow").Rows.Find(ID)?.Delete()
        End With

        Set_CardRow_DataBinding()

    End Sub
    'Private Sub ListBox_CardRow_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox_CardRow.SelectedValueChanged
    '    CardRow_ListBox_SelectedValueChanged()
    'End Sub
    Private Sub ListBox_CardRow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_CardRow.SelectedIndexChanged
        CardRow_ListBox_SelectedValueChanged()
    End Sub
    Private Sub CardRow_ListBox_SelectedValueChanged()

        Dim Check As Boolean = True

        With ListBox_CardRow
            If .CanSelect = False Then Return
            If .CanFocus = False Then Return

            If IsNothing(.SelectedItem) = True Then Check = False
            If .SelectedItems.Count = 0 Then Check = False
            If .SelectedIndex = -1 Then Check = False

            Dim ID As Integer = If(Check = True, .SelectedItem("ID"), Check = False)
            Dim DR As DataRow
            Dim UC As UserControl_Font

            If Check = True Then

                DR = DS.Tables("CardRow").Rows.Find(ID)

                CheckBox_CardRow_QRCode.Checked = CType(DR("QRCode"), Boolean)
                ComboBox_CardRow_DataColumn.Text = DR("DataColumn").ToString
                Label_CardRow_LinePos_Value.Text = CDbl(DR("LinePos")).ToString
                CheckBox_CardRow_AutoFont.Checked = CType(DR("AutoFont"), Boolean)
                NumericUpDown_CardRow_Border_Left.Value = If(IsDBNull(DR("Top")), 0, CDbl(DR("Left")))
                NumericUpDown_CardRow_Border_Top.Value = If(IsDBNull(DR("Top")), 0, CDbl(DR("Top")))
                NumericUpDown_CardRow_Border_Right.Value = If(IsDBNull(DR("Top")), 0, CDbl(DR("Right")))
                NumericUpDown_CardRow_Border_Bottom.Value = If(IsDBNull(DR("Top")), 0, CDbl(DR("Bottom")))


                Dim FontString As String = DR("Font").ToString
                Dim FontConverter As New Class_FontConverter
                Dim nFont As Font = FontConverter.StringToFont(FontString)

                If nFont Is Nothing Then nFont = New Font("Arial", 12, FontStyle.Regular)

                UC = CType(TableLayoutPanel_CardRow.Controls("UC_Font_CardRow"), UserControl_Font)
                UC.GET_Fonts(nFont)
                UC.Enabled = Check

            End If

            CheckBox_CardRow_QRCode.Enabled = Check
            ComboBox_CardRow_DataColumn.Enabled = Check
            Label_CardRow_LinePos_Value.Enabled = Check
            CheckBox_CardRow_AutoFont.Enabled = Check
            NumericUpDown_CardRow_Border_Left.Enabled = Check
            NumericUpDown_CardRow_Border_Top.Enabled = Check
            NumericUpDown_CardRow_Border_Right.Enabled = Check
            NumericUpDown_CardRow_Border_Bottom.Enabled = Check

            Button_CardRow_Delete.Enabled = Check
            Button_CardRow_Up.Enabled = CType(.SelectedIndex > 0, Boolean)
            Button_CardRow_Down.Enabled = CType(.SelectedIndex < .Items.Count - 1, Boolean)

        End With

        'With TableLayoutPanel_CardRow

        '    If .Controls.ContainsKey("UC_Font_CardRow") = False Then Return

        '    If Check = True Then

        '        Dim SIF As String = dr("Font")
        '        Dim FC As New FontConverter
        '        Dim NF As Font = FC.ConvertFromString(SIF)
        '        Dim UC As UserControl_Font = CType(.Controls("UC_Font_CardRow"), UserControl_Font)

        '        UC.Enabled = Check
        '        UC.GET_Fonts(NF)

        '    End If

        'End With

    End Sub

    Private Sub Button_CardRow_Click(sender As Object, e As EventArgs) Handles Button_CardRow_Up.Click, Button_CardRow_Down.Click

        CardRow_Sort(sender, e)

    End Sub
    Private Sub CardRow_Sort(sender As Object, e As EventArgs)

        If ListBox_CardRow.SelectedItems.Count = 0 Then Return

        Dim ID As Integer
        ID = ListBox_CardRow.SelectedItems(0)("ID")

        Dim DT = DS.Tables("CardRow")
        Dim DR As DataRow = DS.Tables("CardRow").Rows.Find(ID)

        Select Case sender.Name
            Case Button_CardRow_Up.Name
                DR("LinePos") = CType(DR("LinePos") - 1.5, Double)
            Case Button_CardRow_Down.Name
                DR("LinePos") = CType(DR("LinePos") + 1.5, Double)
        End Select

        Set_CardRow_DataBinding()

        For Each Row As DataRow In DS.Tables("CardRow").Rows
            If ID = Row("ID") Then
                ListBox_CardRow.SelectedValue = Row("ID")
                CardRow_ListBox_SelectedValueChanged()
            End If
        Next

    End Sub


    Private Sub ComboBox_CardRow_DataColumn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_CardRow_DataColumn.SelectedIndexChanged

        Button_CardRow_Add.Enabled = ComboBox_CardRow_DataColumn.SelectedIndex > -1

    End Sub


    Private Sub UserControl_Font_General_Load()

        If TabPage_General.Controls.ContainsKey("UC_Font_General") = True Then Return
        Dim UCF = New UserControl_Font(MyFont)
        With UCF
            .Name = "UC_Font_General"
            .Dock = DockStyle.Top
            .Font = My.Settings.MyFont
            AddHandler .Font_Changed, AddressOf UC_Font_Changed
        End With
        TabPage_General.Controls.Add(UCF)

    End Sub
    Private Sub UserControl_Font_Card_Load()

        If TabPage_General.Controls.ContainsKey("UC_Font_Card") = True Then Return
        Dim UCF = New UserControl_Font(MyFont)
        With UCF
            .Name = "UC_Font_Card"
            .Dock = DockStyle.Fill
            .Font = My.Settings.MyFont
            AddHandler .Font_Changed, AddressOf UC_Font_Changed
        End With
        TableLayoutPanel_Card.Controls.Add(UCF)

    End Sub
    Private Sub UserControl_Font_CardRow_Load()

        If TabPage_General.Controls.ContainsKey("UC_Font_CardRow") = True Then Return
        Dim UCF = New UserControl_Font(MyFont)
        With UCF
            .Name = "UC_Font_CardRow"
            .Dock = DockStyle.Fill
            .Font = My.Settings.MyFont
            .Enabled = False
            AddHandler .Font_Changed, AddressOf UC_Font_Changed
        End With
        TableLayoutPanel_CardRow.Controls.Add(UCF)

    End Sub
    Private Sub UC_Font_Changed(Sender As Object, e As Font) Handles UC_Font.Font_Changed

        If Sender.canselect = False Then Return
        If Sender.canfocus = False Then Return

        Sender.GET_Fonts(e)

        Select Case Sender.Name
            Case "UC_Font_General"
                My.Settings.MyFont = e
                My.Settings.Save()
                CL_Default = New Class_Default(Me, DS)
            Case "UC_Font_Card"
                DS.Tables("Card").Rows(0)("Font") = New Class_FontConverter().FontToString(e)
            Case "UC_Font_CardRow"
                DS.Tables("CardRow").Rows.Find(ListBox_CardRow.SelectedValue)("Font") = New Class_FontConverter().FontToString(e)
            Case Else
                Debug.Print(Sender.name & vbTab & e.ToString)
                Beep()
        End Select

    End Sub
    Private Sub Save_CardRow(ID As Integer)

        Dim DR As DataRow

        If ID > -1 Then
            DR = DS.Tables("CardRow").Rows.Find(ID)
        Else
            DR = DS.Tables("CardRow").NewRow
            DS.Tables("CardRow").Rows.Add(DR)
        End If

        DR("Left") = NumericUpDown_CardRow_Border_Left.Value
        DR("Top") = NumericUpDown_CardRow_Border_Top.Value
        DR("Right") = NumericUpDown_CardRow_Border_Right.Value
        DR("Bottom") = NumericUpDown_CardRow_Border_Bottom.Value
        DR("QRCode") = CheckBox_CardRow_QRCode.Checked
        DR("DataColumn") = ComboBox_CardRow_DataColumn.Text
        DR("LinePos") = Label_CardRow_LinePos_Value.Text
        DR("Font") = New Class_FontConverter().FontToString(CType(TableLayoutPanel_CardRow.Controls("UC_Font_CardRow"), UserControl_Font).Font)
        DR("FontColor") = String.Empty
        DR("AutoFont") = CheckBox_CardRow_AutoFont.Checked

    End Sub
    Private Sub Button_CardRow_Save_Click(sender As Object, e As EventArgs) Handles Button_CardRow_Save.Click

        If sender.canselect = False Then Return

        If ListBox_CardRow.SelectedIndex > -1 Then
            Dim ID As Integer = ListBox_CardRow.SelectedItem("ID")
            Save_CardRow(ID)
        Else
            Save_CardRow(-1)
        End If

        Set_CardRow_DataBinding()

        IsModified = True

    End Sub
    Private Sub Button_CardRow_FontColor_Click(sender As Object, e As EventArgs) Handles Button_CardRow_FontColor.Click

        Dim CD As New ColorDialog With {.Color = sender.ForeColor}
        If CD.ShowDialog = DialogResult.OK Then
            sender.ForeColor = CD.Color
        End If

    End Sub

#End Region

End Class
