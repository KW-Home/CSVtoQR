Imports System.IO
Imports System.Reflection
Imports System.Security.Cryptography
Imports CSVtoQR.Class_DS

Public Class Form1

    Private DS As New DataSet

    Private MyFont As Font
    'Private MySavePath As String

    Private CL_CSV As New Class_ImportCSV
    Private CL_Default As Class_Default
    Private CL_DS As New Class_DS
    Private CL_P As New Class_Paint
    Private CL_XML As New Class_XML

    Private DT_CSV As DataTable
    Private DV_CSV As DataView
    Private WithEvents DTSearch As DataTable

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
            TextBox_Import.Text = value
        End Set
    End Property

    Private ExportFile_Value As String
    Property ExportFile() As String
        Get
            Return ExportFile_Value
        End Get
        Set(ByVal value As String)
            ExportFile_Value = value
            If IsNothing(DS.Tables("Shema")) = False Then CL_DS.Get_DS(DS)
            If DS.Tables("Shema").Rows.Count = 0 Then DS = CL_DS.NewRow_Shema(DS)
            DS.Tables("Shema").Rows(0).Item("Export") = value
            TextBox_Export.Text = value
        End Set
    End Property

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        MySettings_Load()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'lädt die Einstellungen, die im Designer unter "My.Settings" definiert wurden   

        'Initialisiert die Standardwerte und -einstellungen für die Anwendung
        CL_Default = New Class_Default(Me, DS)


        'lädt die Daten aus dem DataSet in die Steuerelemente
        DataSetRead()

        'zeichnet die Papiervorschau basierend auf den aktuellen Einstellungen
        PaperPaint(Nothing, Nothing)

    End Sub
    Private Sub MySettings_Load()

        With My.Settings

            Me.Size = .MySize
            Me.Font = .MyFont
            MyFont = .MyFont


            If System.IO.File.Exists(.MySavePath) = True Then

                If IsNothing(DS) = True Then CL_DS.Get_DS(DS)
                DS = CL_DS.NewRow_Shema(DS)
                'DS = New DataSet
                CL_XML.DataSetFile = .MySavePath
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

                ListBox_Tabellen.Items.Clear()
                ListBox_Tabellen.Items.AddRange(DS.Tables.Cast(Of DataTable).Select(Function(t) t.TableName).ToArray())
                ToolStripStatusLabel_SaveFile.Text = .MySavePath

            End If

        End With

    End Sub
    Private Sub MySettings_Save()

        Me.WindowState = FormWindowState.Normal

        With My.Settings
            .MySize = Me.Size
            .MyFont = MyFont
            .MySavePath = CL_XML.DataSetFile
            .Save()
        End With

    End Sub

    Private Sub Load_CSV(ByVal Value As String)

        DT_CSV = CL_CSV.Load_CSV(DS, CL_DS, Value)
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

    ' Hilfsmethode: selektiert gesamten Text einer TextBox beim Fokussieren (Enter-Ereignis)
    Private Sub TextBox_SelectAll(sender As Object, e As EventArgs) Handles TextBox_Shema.Enter, TextBox_Import.Enter, TextBox_Export.Enter

        Dim tb As TextBox = TryCast(sender, TextBox)
        If tb Is Nothing Then Return
        If tb.CanSelect Then
            tb.SelectAll()
        End If

    End Sub

    Private Sub ListBox_Tabellen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Tabellen.SelectedIndexChanged

        If ListBox_Tabellen.SelectedIndex < 0 Then Return
        DGV_Table.DataSource = DS.Tables(ListBox_Tabellen.SelectedItem.ToString)

    End Sub

    Private Sub DataSetRead()

        If IsNothing(DS) Then DS = CL_DS.Get_DS(DS)

        With DS.Tables("Shema")
            If .Rows.Count = 0 Then
                DS = CL_DS.NewRow_Shema(DS)
                IsModified = True
            Else
                ImportFile = .Rows(0).Item("Import").ToString
            End If

            With .Rows(0)
                TextBox_Shema.Text = .Item("Shema").ToString
                ImportFile = .Item("Import").ToString
                ExportFile = .Item("Export").ToString
                ComboBox_Paper_DPI.Text = .Item("DPI")
                ComboBox_Paper_DIN.Text = .Item("DIN").ToString
                Label_Paper_Height_Value.Text = .Item("PaperHeight").ToString
                Label_Paper_Width_Value.Text = .Item("PaperWidth")
                NumericUpDown_Separator_Column_Count.Value = .Item("SeparatorSpalteAnzahl")
                NumericUpDown_Separator_Column_Value.Value = .Item("SeparatorSpalteWert")
                NumericUpDown_Separator_Row_Count.Value = .Item("SeparatorZeileAnzahl")
                NumericUpDown_Separator_Row_Value.Value = .Item("SeparatorZeileWert")
            End With
        End With

        With DS.Tables("Card")
            With .Rows(0)
                'Label_CardSizeHeight.Text = .Item("PaperHeight").ToString
                'Label_CardSizeWidth.Text = .Item("PaperWidth")
            End With
        End With

        With DS.Tables("CardRow")
            With .Rows(0)
                'ID, QRCode, DataColumn, LinePos, Font, FontColor, AutoFont

                'Label_CardSizeHeight.Text = .Item("PaperHeight").ToString
                'Label_CardSizeWidth.Text = .Item("PaperWidth")
            End With
        End With

        For Each DR As DataRow In DS.Tables("Border").Select("[Area] Like 'Paper'")
            Select Case DR("Border")
                Case "Left" : NumericUpDown_Paper_Border_Left.Value = DR("Value")
                Case "Top" : NumericUpDown_Paper_Border_Top.Value = DR("Value")
                Case "Right" : NumericUpDown_Paper_Border_Right.Value = DR("Value")
                Case "Bottom" : NumericUpDown_Paper_Border_Bottom.Value = DR("Value")
            End Select
        Next

        For Each DR As DataRow In DS.Tables("Border").Select("[Area] Like 'Card'")
            Select Case DR("Border")
                Case "Left" : NumericUpDown_Card_Border_Left.Value = DR("Value")
                Case "Top" : NumericUpDown_Card_Border_Top.Value = DR("Value")
                Case "Right" : NumericUpDown_Card_Border_Right.Value = DR("Value")
                Case "Bottom" : NumericUpDown_Card_Border_Bottom.Value = DR("Value")
            End Select
        Next

        Dim ID As Integer = 0
        For Each DR As DataRow In DS.Tables("Border").Select($"[ID] = {ID} AND [Area] Like 'CardRow'")
            Select Case DR("Border")
                Case "Left" : NumericUpDown_CardRow_Border_Left.Value = DR("Value")
                Case "Top" : NumericUpDown_CardRow_Border_Top.Value = DR("Value")
                Case "Right" : NumericUpDown_CardRow_Border_Right.Value = DR("Value")
                Case "Bottom" : NumericUpDown_CardRow_Border_Bottom.Value = DR("Value")
            End Select
        Next

        DGV_Search.DataSource = Nothing
        If Not IsNothing(DS.Tables("Search")) Then
            With DS.Tables("Search")
                If .Rows.Count = 0 Then Exit Sub
                DGV_Search.DataSource = DS.Tables("Search")
            End With
        End If

    End Sub
    Private Sub Button_Import_Click(sender As Object, e As EventArgs) Handles Button_Import.Click

        Dim Path As String = CL_XML.DataSetFile
        Dim OFD As New OpenFileDialog With {.Title = "Import CSV-Datei", .Filter = "CSV-Dateien (*.CSV)|*.CSV|Alle Dateien (*.*)|*.*"}

        If System.IO.Directory.Exists(Path) = False AndAlso Path.Length > 0 Then
            OFD.InitialDirectory = System.IO.Path.GetDirectoryName(Path)
            OFD.FileName = System.IO.Path.GetFileName(Path)
        End If
        If OFD.ShowDialog = DialogResult.OK Then
            ImportFile = OFD.FileName
        End If

    End Sub
    Private Sub Button_Export_Click(sender As Object, e As EventArgs) Handles Button_Export.Click

        Dim SFD As New SaveFileDialog With {.Title = "Export PDF-Datei", .Filter = "PDF-Dateien (*.PDF)|*.PDF|Alle Dateien (*.*)|*.*"}
        If SFD.ShowDialog = DialogResult.OK Then
            SFD.FileName = System.IO.Path.ChangeExtension(SFD.FileName, "pdf")
            SFD.InitialDirectory = System.IO.Path.GetDirectoryName(SFD.FileName)
            ExportFile = SFD.FileName
        End If

    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If IsModified = True Then
            Dim Result As DialogResult = MessageBox.Show("Wollen Sie Speichern ?", "Achtung Datenverlust !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            Select Case Result
                Case DialogResult.Yes
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
    Public Sub NumericUpDown_Border_Paper_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Paper_Border_Top.ValueChanged, NumericUpDown_Paper_Border_Right.ValueChanged, NumericUpDown_Paper_Border_Left.ValueChanged, NumericUpDown_Paper_Border_Bottom.ValueChanged

        If sender.canselect = False Then Return
        IsModified = True

        Dim SP() As String = Split(sender.tag, ";", -1, CompareMethod.Text)
        Dim DT As DataTable = DS.Tables("Border")
        Dim DR() As DataRow = DT.Select($"[Area] Like '{SP(0)}' AND [Border] Like '{SP(1)}'")
        DR(0)("Value") = sender.value

        PaperPaint(Nothing, Nothing)

    End Sub
    Private Sub NumericUpDown_Border_Card_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Card_Border_Top.ValueChanged, NumericUpDown_Card_Border_Right.ValueChanged, NumericUpDown_Card_Border_Left.ValueChanged, NumericUpDown_Card_Border_Bottom.ValueChanged

        If sender.canselect = False Then Return
        IsModified = True

        Dim SP() As String = Split(sender.tag, ";", -1, CompareMethod.Text)
        Dim DT As DataTable = DS.Tables("Border")
        Dim DR() As DataRow = DT.Select($"[Area] Like '{SP(0)}' AND [Border] Like '{SP(1)}'")
        DR(0)("Value") = sender.value

    End Sub

    Private Sub NumericUpDown_Border_CardRow_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_CardRow_Border_Top.ValueChanged, NumericUpDown_CardRow_Border_Right.ValueChanged, NumericUpDown_CardRow_Border_Left.ValueChanged, NumericUpDown_CardRow_Border_Bottom.ValueChanged

        If sender.canselect = False Then Return
        IsModified = True

        Dim SP() As String = Split(sender.tag, ";", -1, CompareMethod.Text)
        Dim DR() As DataRow = DS.Tables("Border").Select($"[ID] = 0 AND [Area] Like '{SP(0)}' AND [Border] Like '{SP(1)}'")

        DR(0)("Value") = sender.value

    End Sub
    Private Sub TextBox_Shema_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Shema.TextChanged,
        TextBox_Import.TextChanged, TextBox_Export.TextChanged

        If sender.canselect = False Then Return
        If sender.canfocus = False Then Return

        DS = CL_DS.Get_DS(DS)

        Dim ObjName As String = sender.tag
        DS.Tables("Shema").Rows(0).Item(ObjName) = sender.Text

        IsModified = True

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
        If DGV_Search.Columns.ToString.Contains("ID") Then
            DGV_Search.Columns.Remove("ID")
        End If
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

        If DGV_Search.Columns.ToString.Contains("Search_Column") Then
            DGV_Search.Columns.Remove("Search_Column")
        End If
        DGV_Search.Columns.Insert(1, Search_Column)

        '2. Erstelle die ComboBox-Spalte für die Operatoren
        Dim Search_Operator As New DataGridViewComboBoxColumn() With {
            .Name = "Search_Operator",
            .HeaderText = "Operator",
            .DataPropertyName = "Search_Operator",
            .DataSource = DS.Tables("Search_Operator"),
            .DisplayMember = "Operator",
            .ValueMember = "Operator",
            .ValueType = GetType(String),
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
            .FlatStyle = FlatStyle.Flat}
        If DGV_Search.Columns.ToString.Contains("Search_Operator") Then
            DGV_Search.Columns.Remove("Search_Operator")
        End If
        DGV_Search.Columns.Insert(2, Search_Operator)

        '3. Erstelle die TextBox-Spalte für die Werte
        Dim Search_Value As New DataGridViewTextBoxColumn() With {
            .Name = "Search_Value",
            .HeaderText = "Suche",
            .DataPropertyName = "Search_Value",
            .ValueType = GetType(String),
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells}
        If DGV_Search.Columns.ToString.Contains("Search_Value") Then
            DGV_Search.Columns.Remove("Search_Value")
        End If
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

        DS = CL_DS.NewRow_Shema(DS)
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
            Case "TabPage_Files", "TabPage_Table"
                SplitContainer_Main.Panel2Collapsed = True
            Case Else
                SplitContainer_Main.Panel2Collapsed = False
        End Select

    End Sub

#Region "ToolStripMenu"

    Private Sub ToolStripMenuItem_Font_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Font.Click

        Dim FD As New FontDialog With {.Font = My.Settings.MyFont}
        If FD.ShowDialog = DialogResult.OK Then
            MyFont = FD.Font
            My.Settings.MyFont = MyFont
            My.Settings.Save()
            CL_Default = New Class_Default(Me, DS)
        End If

    End Sub
    Private Sub ToolStripMenuItem_XML_New_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_XML_New.Click

        'DS = CL_DS.Get_DS(Nothing)

        SaveFileDialog_XML()

        'Dim SFD As New SaveFileDialog With {
        '    .Title = "Die Datei " & CL_XML.DataSetFile & " existiert nicht.",
        '    .InitialDirectory = System.IO.Path.GetDirectoryName(CL_XML.DataSetFile),
        '    .Filter = "XML-Dateien (*.xml)|*.xml|Alle Dateien (*.*)|*.*"
        '}

        'If SFD.ShowDialog = DialogResult.OK Then
        '    CL_XML.DataSetFile = SFD.FileName
        '    CL_XML.SaveXML(DS)
        'End If

    End Sub

    Private Sub ToolStripMenuItem_XML_Save(sender As Object, e As EventArgs) Handles ToolStripMenuItem_XML_SaveAs.Click, ToolStripMenuItem_XML_Safe.Click

        Select Case sender.name
            Case ToolStripMenuItem_XML_Safe.Name
                If System.IO.File.Exists(CL_XML.DataSetFile) Then
                    CL_XML.SaveXML(DS)
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
    Private Sub SaveFileDialog_XML()

        Dim SFD As New SaveFileDialog
        With SFD
            .CheckPathExists = True
            .Title = "Die Datei Speichern (" & CL_XML.DataSetFile & ")"
            .InitialDirectory = System.IO.Path.GetDirectoryName(CL_XML.DataSetFile)
            .FileName = TextBox_Shema.Text
            .Filter = "XML-Dateien (*.xml)|*.xml|Alle Dateien (*.*)|*.*"
        End With

        If SFD.ShowDialog = DialogResult.OK Then
            DS = CL_DS.Get_DS(Nothing)

            CL_XML.DataSetFile = SFD.FileName
            CL_XML.SaveXML(DS)

            DataSetRead()

        End If

    End Sub
    Private Sub ToolStripMenuItem_XML_Open_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_XML_Open.Click

        CL_XML.OpenFileDialog_XML(DS)
        DataSetRead()

    End Sub

#End Region

End Class
