Imports System.IO
Imports System.Reflection
Imports System.Security.Cryptography

Public Class Form1

    Public DS As New DataSet
    Private MyFont As Font = My.Settings.MyFont
    Private CL_CSV As New Class_ImportCSV
    Private CL_Default As New Class_Default
    Private CL_DS As New Class_DS
    Private CL_P As New Class_Paint

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
                ToolStripMenuItem_Safe.Enabled = True
            Else
                ToolStripStatusLabel_IsModified.BackColor = Color.Green
                ToolStripMenuItem_Safe.Enabled = False
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
            Load_CSV(value)
        End Set
    End Property

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        MySettings_Load()
        DataSetRead()
        PaperPaint(Nothing, Nothing)

        CL_Default.DefaultControls(Me, DS)

    End Sub
    Private Sub MySettings_Load()

        With My.Settings

            Me.Size = .MySize
            Me.Font = .MyFont
            MyFont = .MyFont

            If System.IO.File.Exists(.MySavePath) Then
                DS = New DataSet
                DS.ReadXml(.MySavePath)
            Else
                DS = New Class_DS().Get_DS
            End If

            ListBox_Tabellen.Items.Clear()
            ListBox_Tabellen.Items.AddRange(DS.Tables.Cast(Of DataTable).Select(Function(t) t.TableName).ToArray())

            ToolStripStatusLabel_SaveFile.Text = .MySavePath

        End With

    End Sub
    Private Sub MySettings_Save()

        Me.WindowState = FormWindowState.Normal

        With My.Settings
            .MySize = Me.Size
            .MyFont = Me.Font
            .MySavePath = ToolStripStatusLabel_SaveFile.Text
            .Save()
        End With

    End Sub

    Private Sub Load_CSV(ByVal Value As String)

        DT_CSV = CL_CSV.Load_CSV(DS, CL_DS, Value)
        DV_CSV = New DataView(DT_CSV)

        Main_BindingSource_CSV.DataSource = DV_CSV
        Main_BindingNavigator_CSV.BindingSource = Main_BindingSource_CSV
        DGV_CSV.DataSource = Main_BindingSource_CSV

        DGV_Search_Formatting()

        TextBox_Import.Text = Value
        IsModified = True

    End Sub

    ' Hilfsmethode: selektiert gesamten Text einer TextBox beim Fokussieren (Enter-Ereignis)
    Private Sub TextBox_SelectAll(sender As Object, e As EventArgs) Handles TextBox_Shema.Enter, TextBox_Import.Enter, TextBox_Export.Enter

        Dim tb As TextBox = TryCast(sender, TextBox)
        If tb Is Nothing Then Return
        If tb.CanSelect Then
            tb.SelectAll()
        End If

    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Beenden.Click

        Me.Close()

    End Sub

    Private Sub TSMI_XML_New_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_XML_New.Click

        DS = New Class_DS().Get_DS

        Dim Path As String = My.Settings.MySavePath

        If System.IO.File.Exists(Path) = False Then
            Path = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DS.xml"
        End If

        Dim SFD As New SaveFileDialog With {
            .Title = "Die Datei " & Path & " existiert nicht.",
            .InitialDirectory = System.IO.Path.GetDirectoryName(Path),
            .Filter = "XML-Dateien (*.xml)|*.xml|Alle Dateien (*.*)|*.*"
        }

        If SFD.ShowDialog = DialogResult.OK Then
            DS.WriteXml(SFD.FileName, XmlWriteMode.WriteSchema)
            My.Settings.MySavePath = SFD.FileName
            My.Settings.Save()
            ToolStripStatusLabel_SaveFile.Text = My.Settings.MySavePath
            CL_Default.DefaultControls(Me, DS)
        End If

    End Sub

    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Öffnen.Click

        Dim Path As String = "C:\Temp\DS.xml"

        If System.IO.File.Exists(Path) Then
            DS = New DataSet
            DS.ReadXml(Path)

        Else

            Dim OFD As New OpenFileDialog With {
                .Title = "Die Datei " & Path & " existiert nicht.",
                .InitialDirectory = "C:\Temp",
                .Filter = "XML-Dateien (*.xml)|*.xml|Alle Dateien (*.*)|*.*"
            }

            If OFD.ShowDialog = DialogResult.OK Then
                DS = New DataSet
                DS.ReadXml(OFD.FileName)
                My.Settings.MySavePath = OFD.FileName
                My.Settings.Save()
                DataSetRead()
                ToolStripStatusLabel_SaveFile.Text = My.Settings.MySavePath
            End If

        End If

    End Sub

    Private Sub TSMI_Save(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Safe.Click, ToolStripMenuItem_XML_SaveAs.Click

        Dim Path As String = My.Settings.MySavePath
        Select Case sender.name
            Case "ToolStripMenuItem_Safe"
                If System.IO.File.Exists(Path) Then
                    DS.WriteXml(Path, XmlWriteMode.WriteSchema)
                    IsModified = False
                Else
                    SaveXML(Path)
                    IsModified = False
                End If
            Case ToolStripMenuItem_XML_SaveAs.Name
                SaveXML(Path)
                IsModified = False
        End Select

    End Sub

    Private Sub SaveXML(Path As String)

        Dim SFD As New SaveFileDialog With {
            .CheckPathExists = True,
            .Title = "Die Datei " & Path & " existiert nicht.",
            .InitialDirectory = System.IO.Path.GetDirectoryName(Path),
            .FileName = TextBox_Shema.Text,
            .Filter = "XML-Dateien (*.xml)|*.xml|Alle Dateien (*.*)|*.*"
        }

        If SFD.ShowDialog = DialogResult.OK Then
            DS.WriteXml(SFD.FileName, XmlWriteMode.WriteSchema)
            ToolStripStatusLabel_SaveFile.Text = SFD.FileName
            ImportFile = SFD.FileName
            IsModified = False
            My.Settings.MySavePath = SFD.FileName
            My.Settings.Save()
        End If

    End Sub

    Private Sub ListBox_Tabellen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Tabellen.SelectedIndexChanged

        If ListBox_Tabellen.SelectedIndex < 0 Then Return
        DGV_Table.DataSource = DS.Tables(ListBox_Tabellen.SelectedItem.ToString)

    End Sub

    Private Sub DataSetRead()

        If IsNothing(DS) Then DS = CL_DS.Get_DS()

        With DS.Tables("Shema")
            If .Rows.Count = 0 Then
                CL_DS.Shema_NewRow(DS)
                IsModified = True
            Else
                ImportFile = .Rows(0).Item("Import").ToString
            End If

            With .Rows(0)
                TextBox_Shema.Text = .Item("Shema").ToString
                TextBox_Import.Text = ImportFile
                TextBox_Export.Text = .Item("Export").ToString
                ComboBox_DPI.Text = .Item("DPI")
                ComboBox_DIN.Text = .Item("DIN").ToString
                Label_Paper_Height_Value.Text = .Item("PaperHeight").ToString
                Label_Paper_Width_Value.Text = .Item("PaperWidth")
                NumericUpDown_Separator_Column_Count.Value = .Item("SeparatorSpalteAnzahl")
                NumericUpDown_Separator_Spalte_Wert.Value = .Item("SeparatorSpalteWert")
                NumericUpDown_Separator_Row_Anzahl.Value = .Item("SeparatorZeileAnzahl")
                NumericUpDown_Separator_Zeile_Wert.Value = .Item("SeparatorZeileWert")
            End With
        End With

        ReadToNumericUpDown_BorderPaper()
        ReadToNumericUpDown_BorderCard()

        If Not IsNothing(DS.Tables("Search")) Then
            With DS.Tables("Search")
                If .Rows.Count = 0 Then Exit Sub
                DGV_Search.DataSource = DS.Tables("Search")
            End With
        End If

    End Sub
    Private Sub ReadToNumericUpDown_BorderPaper()

        For Each DR As DataRow In DS.Tables("Border").Select("[Area] Like 'Paper'")
            Select Case DR("Border")
                Case "Left" : NumericUpDown_Paper_Border_Left.Value = DR("Value")
                Case "Top" : NumericUpDown_Paper_Border_Top.Value = DR("Value")
                Case "Right" : NumericUpDown_Paper_Border_Right.Value = DR("Value")
                Case "Bottom" : NumericUpDown_Paper_Border_Bottom.Value = DR("Value")
            End Select
        Next

    End Sub
    Private Sub ReadToNumericUpDown_BorderCard()

        For Each DR As DataRow In DS.Tables("Border").Select("[Area] Like 'Card'")
            Select Case DR("Border")
                Case "Left" : NumericUpDown_Card_Border_Left.Value = DR("Value")
                Case "Top" : NumericUpDown_Card_Border_Top.Value = DR("Value")
                Case "Right" : NumericUpDown_Card_Border_Right.Value = DR("Value")
                Case "Bottom" : NumericUpDown_Card_Border_Bottom.Value = DR("Value")
            End Select
        Next

    End Sub
    Private Sub DataSetWrite()

        If IsNothing(DS) Then DS = CL_DS.Get_DS()
        If DS.Tables("Shema").Rows.Count = 0 Then CL_DS.Shema_NewRow(DS)

        Dim DT As DataTable = DS.Tables("Shema")
        Dim DR As DataRow = DT.NewRow
        With DT
            With DR

                .Item("Shema") = TextBox_Shema.Text
                .Item("Import") = TextBox_Import.Text
                .Item("Export") = TextBox_Export.Text
                .Item("DIN") = ComboBox_DIN.Text
                .Item("DPI") = ComboBox_DPI.Text

                If IsNumeric(Label_Paper_Height_Value.Text) = True Then .Item("PaperHeight") = Label_Paper_Height_Value.Text
                If IsNumeric(Label_Paper_Width_Value.Text) = True Then .Item("PaperWidth") = Label_Paper_Width_Value.Text

                If IsNumeric(NumericUpDown_Paper_Border_Left.Value) = True Then .Item("BorderLeft") = NumericUpDown_Paper_Border_Left.Value
                If IsNumeric(NumericUpDown_Paper_Border_Top.Value) = True Then .Item("BorderTop") = NumericUpDown_Paper_Border_Top.Value
                If IsNumeric(NumericUpDown_Paper_Border_Right.Value) = True Then .Item("BorderRight") = NumericUpDown_Paper_Border_Right.Value
                If IsNumeric(NumericUpDown_Paper_Border_Bottom.Value) = True Then .Item("BorderBottom") = NumericUpDown_Paper_Border_Bottom.Value

                If IsNumeric(NumericUpDown_Separator_Column_Count.Value) = True Then .Item("SeparatorSpalteAnzahl") = NumericUpDown_Separator_Column_Count.Value
                If IsNumeric(NumericUpDown_Separator_Spalte_Wert.Value) = True Then .Item("SeparatorSpalteWert") = NumericUpDown_Separator_Spalte_Wert.Value
                If IsNumeric(NumericUpDown_Separator_Row_Anzahl.Value) = True Then .Item("SeparatorZeileAnzahl") = NumericUpDown_Separator_Row_Anzahl.Value
                If IsNumeric(NumericUpDown_Separator_Zeile_Wert.Value) = True Then .Item("SeparatorZeileWert") = NumericUpDown_Separator_Zeile_Wert.Value

            End With

            If .Rows.Count > 0 Then .Rows.Clear()
            .Rows.Add(DR)

        End With

        IsModified = True

    End Sub

    Private Sub Button_Import_Click(sender As Object, e As EventArgs) Handles Button_Import.Click

        Dim Path As String = TextBox_Import.Text
        Dim OFD As New OpenFileDialog With {.Title = "Import CSV-Datei", .Filter = "CSV-Dateien (*.CSV)|*.CSV|Alle Dateien (*.*)|*.*"}

        If System.IO.Directory.Exists(Path) = False AndAlso Path.Length > 0 Then OFD.InitialDirectory = System.IO.Path.GetDirectoryName(Path)
        If OFD.ShowDialog = DialogResult.OK Then
            ImportFile = OFD.FileName
        End If

    End Sub

    Private Sub Button_Export_Click(sender As Object, e As EventArgs) Handles Button_Export.Click

        Dim SFD As New SaveFileDialog With {.Title = "Export PDF-Datei", .Filter = "PDF-Dateien (*.PDF)|*.PDF|Alle Dateien (*.*)|*.*"}
        If SFD.ShowDialog = DialogResult.OK Then
            TextBox_Export.Text = SFD.FileName
            My.Settings.MySavePath = SFD.FileName
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If IsModified = True Then
            Dim Result As DialogResult = MessageBox.Show("Wollen Sie Speichern ?", "Achtung Datenverlust !",
                                                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            Select Case Result
                Case DialogResult.Yes
                    MySettings_Save()
                    On Error Resume Next
                    DS.WriteXml(My.Settings.MySavePath, XmlWriteMode.WriteSchema)
                Case DialogResult.No
                    ' Do nothing
                Case DialogResult.Cancel
                    e.Cancel = True
            End Select
        Else
            e.Cancel = False
        End If

    End Sub


    Public Sub NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Separator_Column_Count.ValueChanged, NumericUpDown_Separator_Spalte_Wert.ValueChanged, NumericUpDown_Separator_Row_Anzahl.ValueChanged, NumericUpDown_Separator_Zeile_Wert.ValueChanged
        If sender.canselect = False Then Return
        IsModified = True

        Dim ObjName As String = sender.tag
        DS.Tables("Shema").Rows(0).Item(ObjName) = sender.value

        PaperPaint(Nothing, Nothing)

    End Sub

    Public Sub NumericUpDown_Border_Paper_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Paper_Border_Left.ValueChanged, NumericUpDown_Paper_Border_Top.ValueChanged, NumericUpDown_Paper_Border_Right.ValueChanged, NumericUpDown_Paper_Border_Bottom.ValueChanged

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

        'PaperPaint(Nothing, Nothing)

    End Sub


    Private Sub TextBox_Shema_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Shema.TextChanged,
        TextBox_Import.TextChanged, TextBox_Export.TextChanged

        If sender.canselect = False Then Return
        IsModified = True

        Dim ObjName As String = sender.Name
        ObjName = ObjName.Replace("TextBox_", "")
        DS.Tables("Shema").Rows(0).Item(ObjName) = sender.Text

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
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells}
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
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells}
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
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill}
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

        Debug.Print(DS.Tables("Search").Rows.Count)

        IsModified = True
        CSVSearch()

    End Sub

    Private Sub TSMI_Font_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Font.Click

        Dim FD As New FontDialog With {.Font = My.Settings.MyFont}
        If FD.ShowDialog = DialogResult.OK Then

            My.Settings.MyFont = FD.Font
            My.Settings.Save()

            Me.Font = FD.Font
            MyFont = FD.Font

            CL_Default.DefaultControls(Me, DS)

        End If

    End Sub

    Private Sub PaperPaint(Sender As Object, e As EventArgs) Handles NumericUpDown_Separator_Column_Count.ValueChanged, NumericUpDown_Separator_Spalte_Wert.ValueChanged,
        NumericUpDown_Separator_Row_Anzahl.ValueChanged, NumericUpDown_Separator_Zeile_Wert.ValueChanged,
        NumericUpDown_Paper_Border_Left.ValueChanged, NumericUpDown_Paper_Border_Top.ValueChanged, NumericUpDown_Paper_Border_Right.ValueChanged, NumericUpDown_Paper_Border_Bottom.ValueChanged

        If DS Is Nothing Then CL_DS.Get_DS()
        If DS.Tables("Shema").Rows.Count = 0 Then CL_DS.Shema_NewRow(DS)

        CL_P.Ivalidate_Paper(Me, DS)

    End Sub

    Public Sub CB_DIN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_DIN.SelectedIndexChanged

        If ComboBox_DIN.SelectedIndex = -1 Then Return
        If ComboBox_DIN.CanFocus = False Then Return

        DS.Tables("Shema").Rows(0)("DIN") = CType(ComboBox_DIN.Text, String)

        DS.Tables("Shema").Rows(0)("PaperHeight") = CType(ComboBox_DIN.SelectedItem("PaperHeight"), Integer)
        Label_Paper_Height_Value.Text = ComboBox_DIN.SelectedItem("PaperHeight").ToString

        DS.Tables("Shema").Rows(0)("PaperWidth") = CType(ComboBox_DIN.SelectedItem("PaperWidth"), Integer)
        Label_Paper_Width_Value.Text = ComboBox_DIN.SelectedItem("PaperWidth").ToString

        IsModified = True

    End Sub

    Public Sub CB_DPI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_DPI.SelectedIndexChanged
        DS.Tables("Shema").Rows(0)("DPI") = CType(ComboBox_DPI.Text, Integer)
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

    Private Sub Main_TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Main_TabControl.SelectedIndexChanged

        Select Case Main_TabControl.TabPages(Main_TabControl.SelectedIndex).Name
            Case "TabPage_Files", "TabPage_Table"
                Main_SplitContainer.Panel2Collapsed = True
            Case Else
                Main_SplitContainer.Panel2Collapsed = False
        End Select

    End Sub

End Class
