
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing.Text
Imports System.Net.WebRequestMethods
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports CSVtoQR.Class_DS
Imports CSVtoQR.My
Imports CSVtoQR.UserControl_Border

Imports ZXing
Imports ZXing.Common

Public Class Form1

    Public DS As New DataSet

    Public WithEvents CL_XML As New Class_XML

    Private WithEvents UC_File_XML As New UserControl_File With {.Name = "UC_File_XML"}
    Private WithEvents UC_File_CSV As New UserControl_File With {.Name = "UC_File_CSV"}
    Private WithEvents UC_File_PDF As New UserControl_File With {.Name = "UC_File_PDF"}

    Private WithEvents UC_Font_General As New UserControl_Font With {.Name = "UC_Font_General"}
    Private WithEvents UC_Font_Card As New UserControl_Font With {.Name = "UC_Font_Card"}
    Private WithEvents UC_Font_CardRow As New UserControl_Font With {.Name = "UC_Font_CardRow"}

    Private WithEvents UC_Border_Paper As New UserControl_Border With {.Name = "UC_Border_Paper"}
    Private WithEvents UC_Border_Card As New UserControl_Border With {.Name = "UC_Border_Card"}
    Private WithEvents UC_Border_CardRow As New UserControl_Border With {.Name = "UC_Border_CardRow"}

    Private CL_CSV As New Class_CSV
    Private CL_Default As Class_Default
    Private CL_DS As New Class_DS
    Private CL_Paint As New Class_Paint

    Public DT_CSV As DataTable
    Private DV_CSV As DataView


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

    Private File_XML_Value As String
    Public Property File_XML() As String
        Get
            Return File_XML_Value
        End Get
        Set(ByVal value As String)
            If File_XML_Value <> value Then
                File_XML_Value = value
                XMLChange()
            End If
        End Set
    End Property

    Private Sub XMLChange()

        Dim DirStr As String = System.IO.Path.GetDirectoryName(File_XML_Value)
        If System.IO.Directory.Exists(DirStr) Then

            ToolStripStatusLabel_SaveFile.Text = File_XML_Value
            My.Settings.LastDirectory = DirStr


            If System.IO.File.Exists(File_XML_Value) = True Then

                Dim FileName As String = System.IO.Path.GetFileName(File_XML_Value)
                With UC_File_XML
                    .TextBox_Directory.Text = DirStr
                    .TextBox_Filename.Text = FileName
                End With
                My.Settings.LastFile = FileName

                DS = CL_DS.Get_DS(DS)
                CL_XML.DataSetFile = File_XML_Value
                CL_XML.ReadXML(DS)

                DataSetRead()

                GET_ColumnTabele()

                ToolStripMenuItem_Save.Enabled = True

            End If

            My.Settings.Save()

        Else

            With UC_File_XML
                .TextBox_Directory.Text = String.Empty
                .TextBox_Filename.Text = String.Empty
            End With

            ToolStripStatusLabel_SaveFile.Text = String.Empty

        End If

    End Sub

    Private File_CSV_Value As String
    Public Property File_CSV() As String
        Get
            Return File_CSV_Value
        End Get
        Set(ByVal value As String)

            File_CSV_Value = value

            DS = CL_DS.Get_DS(DS)
            DS.Tables("Paper").Rows(0).Item("Import") = value
            Load_CSV(value)

            Set_CardRow_DataBinding()

            If IsNothing(File_CSV_Value) = True Then Return
            If System.IO.File.Exists(File_CSV_Value) = False Then Return


            With UC_File_CSV
                .TextBox_Directory.Text = Path.GetDirectoryName(File_CSV_Value)
                .TextBox_Filename.Text = Path.GetFileName(File_CSV_Value)
            End With

        End Set
    End Property

    Private File_PDF_Value As String
    Property File_PDF() As String
        Get
            Return File_PDF_Value
        End Get
        Set(ByVal value As String)
            Dim finalPath As String = If(value, String.Empty)

            If String.IsNullOrWhiteSpace(finalPath) Then
                File_PDF_Value = String.Empty
            Else
                If finalPath.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase) = False Then
                    Try
                        finalPath = System.IO.Path.ChangeExtension(finalPath, ".pdf")
                    Catch
                        finalPath &= ".pdf"
                    End Try
                End If

                File_PDF_Value = finalPath
            End If

            DS.Tables("Paper").Rows(0).Item("Export") = File_PDF_Value

            SET_Changetext_PDF(File_PDF_Value)

        End Set
    End Property

    Public Sub New()

        InitializeComponent()
        DS = CL_DS.Get_DS(DS)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Border As New UserControl_Border.Border With {.Left = 0, .Top = 0, .Right = 0, .Bottom = 0}

        UC_Font_General.UC_Load(Me, UC_Font_General, TableLayoutPanel_General)

        UC_File_XML.UC_Load(Me, UC_File_XML, TableLayoutPanel_General)
        UC_File_CSV.UC_Load(Me, UC_File_CSV, TableLayoutPanel_General)
        UC_File_PDF.UC_Load(Me, UC_File_PDF, TableLayoutPanel_General)

        UC_Border_Paper.UC_Load(Me, UC_Border_Paper, TableLayoutPanel_Paper)
        With TableLayoutPanel_Paper

            .SetRow(PictureBox_Paper, 0)
            .SetRowSpan(PictureBox_Paper, 10)
            .SetColumn(PictureBox_Paper, 4)
            .SetColumnSpan(PictureBox_Paper, 1)

            .SetRow(UC_Border_Paper, 9)
            .SetRowSpan(UC_Border_Paper, 1)
            .SetColumn(UC_Border_Paper, 0)
            .SetColumnSpan(UC_Border_Paper, 3)

        End With

        UC_Font_Card.UC_Load(Me, UC_Font_Card, TableLayoutPanel_Card)
        UC_Border_Card.UC_Load(Me, UC_Border_Card, TableLayoutPanel_Card)

        With TableLayoutPanel_Card

            .SetRow(UC_Font_Card, 2)
            .SetRowSpan(UC_Font_Card, 1)
            .SetColumn(UC_Font_Card, 0)
            .SetColumnSpan(UC_Font_Card, 3)

            .SetRow(UC_Border_Card, 3)
            .SetRowSpan(UC_Border_Card, 1)
            .SetColumn(UC_Border_Card, 0)
            .SetColumnSpan(UC_Border_Card, 3)

            .SetRow(PictureBox_Card, 0)
            .SetRowSpan(PictureBox_Card, 4)
            .SetColumn(PictureBox_Card, 4)
            .SetColumnSpan(PictureBox_Card, 1)

        End With

        UC_Font_CardRow.UC_Load(Me, UC_Font_CardRow, TableLayoutPanel_CardRow)
        UC_Border_CardRow.UC_Load(Me, UC_Border_CardRow, TableLayoutPanel_CardRow)

        With TableLayoutPanel_CardRow

            .SetRow(UC_Font_CardRow, 2)
            .SetRowSpan(UC_Font_CardRow, 1)
            .SetColumn(UC_Font_CardRow, 0)
            .SetColumnSpan(UC_Font_CardRow, 1)

            .SetRow(UC_Border_CardRow, 3)
            .SetRowSpan(UC_Border_CardRow, 1)
            .SetColumn(UC_Border_CardRow, 0)
            .SetColumnSpan(UC_Border_CardRow, 1)

            .SetRow(PictureBox_CardRow, 0)
            .SetRowSpan(PictureBox_CardRow, 8)
            .SetColumn(PictureBox_CardRow, 1)
            .SetColumnSpan(PictureBox_CardRow, 1)

        End With

        CL_Default = New Class_Default(Me)

        MySettings_Load()
        CL_Default.Controlls_Read()


        CL_DS.DT_Border(DS.Tables("Border"))
        CL_DS.DT_Font(DS.Tables("Font"))

        Dim XMLBool As Boolean = CL_XML.ReadXML_Exists()

        ToolStripMenuItem_Save.Enabled = XMLBool
        TabControl_Main.Enabled = XMLBool

    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        PaperPaint(Nothing, Nothing)

    End Sub
    Private Sub MySettings_Load()

        With My.Settings

            Me.Font = .Main_Font
            UC_Font_General.GET_FontToUC(.Main_Font)
            Me.Size = .MySize

            If System.IO.File.Exists(.LastFile) = True Then
                File_XML = .LastFile
            Else
                File_XML = String.Empty
            End If

            If System.IO.File.Exists(CL_XML.DataSetFile) = True Then
                DS = CL_DS.Get_DS(DS)
                CL_XML.ReadXML(DS)
                Dim DT As DataTable = DS.Tables("Paper")
                If DT.Rows.Count > 0 Then
                    File_CSV = DT(0)("Import").ToString()
                    File_PDF = DT(0)("Export").ToString()
                Else
                    DS = CL_DS.Get_DS(DS)
                End If
            Else
                DS = CL_DS.Get_DS(DS)
                UC_File_XML.TextBox_Directory.Text = String.Empty
                UC_File_XML.TextBox_Filename.Text = String.Empty
                ToolStripStatusLabel_SaveFile.Text = String.Empty
            End If

        End With

    End Sub
    Private Sub MySettings_Save()

        Me.WindowState = FormWindowState.Normal
        Dim sizeToSave As Size

        ' Verwende RestoreBounds, falls das Formular nicht im Normalzustand ist.
        If Me.WindowState = FormWindowState.Normal Then
            sizeToSave = Me.Size
        Else
            sizeToSave = Me.RestoreBounds.Size
        End If

        With My.Settings
            .MySize = sizeToSave
            .LastFile = File_XML_Value
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
                .DataSource = DS.Tables("Search_Columns")
                .DisplayMember = "Column"
                .ValueMember = "Column"
            End With
        End If

        Dim I As Integer = 0
        Dim Ix As Integer = 0
        For Each DR As DataRow In DS.Tables("Search_Columns").Rows
            If IsNothing(DR) = False Then
                Dim ST As String = DR("Column")
                Ix = TextRenderer.MeasureText(ST, My.Settings.Main_Font).Width
                Debug.Print(Ix)
                If I < Ix Then I = Ix
            End If
        Next

        ComboBox_CardRow_DataColumn.DropDownWidth = I + 30
        ComboBox_CardRow_DataColumn.Width = I + 30
        ComboBox_CardRow_DataColumn.Invalidate()

        DurchlaufCSV()

    End Sub

    Private Sub DurchlaufCSV()

        Dim OldIndex As Integer = 0

        For Each WertC As DataRow In DS.Tables("Search_Columns").Rows
            For Each Wert As DataRow In DT_CSV.Rows
                Dim I As Integer = TextRenderer.MeasureText(WertC("Column").ToString, My.Settings.Main_Font).Width
                If OldIndex < I Then OldIndex = I
            Next
            WertC("MaxSize") = OldIndex
            OldIndex = 0
        Next

    End Sub

    Private Sub ListBox_Tabellen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Tabellen.SelectedIndexChanged

        If ListBox_Tabellen.SelectedIndex = -1 Then Return
        DGV_Table.DataSource = DS.Tables(ListBox_Tabellen.Items(ListBox_Tabellen.SelectedIndex).ToString)

    End Sub

    Private Sub DataSetRead()

        If IsNothing(DS) Then DS = CL_DS.Get_DS(DS)
        If CL_XML.ReadXML_Exists() = False Then Return

        Dim DR As DataRow
        Dim nFont As Font
        Dim Border As UserControl_Border.Border

        'Paper auslesen und in die entsprechenden Steuerelemente einfügen
        DR = DS.Tables("Paper").Rows(0)
        TextBox_Paper_Paper.Text = DR("Paper").ToString
        File_CSV = DR("Import").ToString
        File_PDF = DR("Export").ToString
        ComboBox_Paper_DPI.Text = DR("DPI")
        ComboBox_Paper_DIN.Text = DR("DIN").ToString

        UC_Border_Paper.UC_Load(Me, UC_Border_Paper, TableLayoutPanel_Paper)
        Border = New UserControl_Border.Border
        With Border
            .Left = CType(DR("Left"), Decimal)
            .Top = CType(DR("Top"), Decimal)
            .Right = CType(DR("Right"), Decimal)
            .Bottom = CType(DR("Bottom"), Decimal)
        End With
        UC_Border_Paper.GET_BorderToUC(UC_Border_Paper, Border)

        Label_Paper_Height_Value.Text = DR("PaperHeight").ToString
        Label_Paper_Width_Value.Text = DR("PaperWidth").ToString
        NumericUpDown_Separator_Column_Count.Value = CType(DR("SeparatorSpalteAnzahl"), Decimal)
        NumericUpDown_Separator_Column_Value.Value = CType(DR("SeparatorSpalteWert"), Decimal)
        NumericUpDown_Separator_Row_Count.Value = CType(DR("SeparatorZeileAnzahl"), Decimal)
        NumericUpDown_Separator_Row_Value.Value = CType(DR("SeparatorZeileWert"), Decimal)

        'Card auslesen und in die entsprechenden Steuerelemente einfügen
        DR = DS.Tables("Card").Rows(0)

        nFont = New Class_FontConverter().StringToFont(DR("Font").ToString)
        UC_Font_Card.GET_FontToUC(nFont)

        Border = New UserControl_Border.Border
        With Border
            .Left = CType(DR("Left"), Decimal)
            .Top = CType(DR("Top"), Decimal)
            .Right = CType(DR("Right"), Decimal)
            .Bottom = CType(DR("Bottom"), Decimal)
        End With
        UC_Border_Card.UC_Load(Me, UC_Border_Card, TableLayoutPanel_Card)

        Label_Card_Size_Hight_Value.Text = CType(DR("CardSizeHeight"), Decimal)
        Label_Card_Size_Width_Value.Text = CType(DR("CardSizeWidth"), Decimal)

        'CardRow auslesen und in die entsprechenden Steuerelemente einfügen
        If ListBox_CardRow.SelectedIndex = -1 Then
            Border = New UserControl_Border.Border
            With Border
                .Left = 0
                .Top = 0
                .Right = 0
                .Bottom = 0
            End With
            UC_Border_CardRow.UC_Load(Me, UC_Border_CardRow, TableLayoutPanel_CardRow)
        Else

            Dim ID As Integer = ListBox_CardRow.Items(ListBox_CardRow.SelectedIndex)("ID")

            DR = CL_DS.GET_CardRow(DS, ID)

            nFont = New Class_FontConverter().StringToFont(DR("Font").ToString)
            UC_Font_CardRow.GET_FontToUC(nFont)

            Border = New UserControl_Border.Border
            With Border
                .Left = CType(DR("Left"), Decimal)
                .Top = CType(DR("Top"), Decimal)
                .Right = CType(DR("Right"), Decimal)
                .Bottom = CType(DR("Bottom"), Decimal)
            End With
            UC_Border_CardRow.UC_Load(Me, UC_Border_CardRow, TableLayoutPanel_CardRow)

            CheckBox_CardRow_QRCode.Checked = CType(DR("QRCode"), Boolean)
            CheckBox_CardRow_AutoFont.Checked = CType(DR("AutoFont"), Boolean)
            Button_CardRow_FontColor.BackColor = Color.FromArgb(CInt(DR("FontColor")))
            Label_CardRow_LinePos_Value.Text = DR("LinePos").ToString
            ComboBox_CardRow_DataColumn.Text = DR("DataColumn").ToString

        End If

        DGV_Search.DataSource = Nothing
        If Not IsNothing(DS.Tables("Search")) Then
            With DS.Tables("Search")
                If .Rows.Count = 0 Then Exit Sub
                DGV_Search.DataSource = DS.Tables("Search")
            End With
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
                Case DialogResult.No
                    ' Do nothing
                Case DialogResult.Cancel
                    e.Cancel = True
            End Select
        Else
            e.Cancel = False
        End If

        MySettings_Save()

    End Sub

    Public Sub NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Separator_Row_Value.ValueChanged,
        NumericUpDown_Separator_Row_Count.ValueChanged, NumericUpDown_Separator_Column_Value.ValueChanged,
        NumericUpDown_Separator_Column_Count.ValueChanged

        If sender.canselect = False Then Return
        If sender.canfocus = False Then Return
        IsModified = True

        Dim ObjName As String = sender.tag
        DS.Tables("Paper").Rows(0).Item(ObjName) = sender.value

        PaperPaint(Nothing, Nothing)

    End Sub

    Private Sub TextBox_Paper_Paper_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Paper_Paper.TextChanged

        If sender.canselect = False Then Return
        If sender.canfocus = False Then Return
        DS = CL_DS.Get_DS(DS)
        DS.Tables("Paper").Rows(0).Item("Paper") = TextBox_Paper_Paper.Text
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

    Private Sub PaperPaint(Sender As Object, e As EventArgs) Handles _
        NumericUpDown_Separator_Column_Count.ValueChanged,
        NumericUpDown_Separator_Column_Value.ValueChanged,
        NumericUpDown_Separator_Row_Count.ValueChanged,
        NumericUpDown_Separator_Row_Value.ValueChanged

        CL_Paint.Ivalidate_Paper(Me, DS)

    End Sub
    Private Sub PaperPaint_Paper(Sender As Object, e As Border) Handles UC_Border_Paper.ChangeEvent

        'Save_Paper()
        CL_Paint.Ivalidate_Paper(Me, DS)

    End Sub
    Private Sub PaperPaint_Card(Sender As Object, e As Border) Handles UC_Border_Card.ChangeEvent

        'CL_Paint.Ivalidate_Card(Me, DS)

    End Sub
    Private Sub PaperPaint_CardRow(Sender As Object, e As Border) Handles UC_Border_CardRow.ChangeEvent

        'CL_Paint.Ivalidate_CSV(DS, PictureBox_CardRow)

    End Sub


    Public Sub CB_DIN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Paper_DIN.SelectedIndexChanged

        If ComboBox_Paper_DIN.SelectedIndex = -1 Then Return
        If ComboBox_Paper_DIN.CanFocus = False Then Return

        Dim DR As DataRow = DS.Tables("Paper").Rows(0)

        DR("DIN") = CType(ComboBox_Paper_DIN.Text, String)
        DR("PaperHeight") = CType(ComboBox_Paper_DIN.SelectedItem("PaperHeight"), Integer)
        DR("PaperWidth") = CType(ComboBox_Paper_DIN.SelectedItem("PaperWidth"), Integer)

        Label_Paper_Height_Value.Text = DR("PaperHeight")
        Label_Paper_Width_Value.Text = DR("PaperWidth")

        PaperPaint(Nothing, Nothing)

        IsModified = True

    End Sub

    Public Sub CB_DPI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Paper_DPI.SelectedIndexChanged
        DS.Tables("Paper").Rows(0)("DPI") = CType(ComboBox_Paper_DPI.Text, Integer)

        PaperPaint(Nothing, Nothing)

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

        If sender.canselect = False Then Return

        Select Case TabControl_Main.TabPages(TabControl_Main.SelectedIndex).Name
            Case "TabPage_Paper"

                CL_Paint.Ivalidate_Paper(Me, DS)

            Case "TabPage_Card"

                'CL_Paint.Ivalidate_Card(Me, DS)

            Case "TabPage_CardRow"

                'CL_Paint.Ivalidate_CSV(DS, PictureBox_CardRow)

            Case "TabPage_CSV"

                'CL_Paint.Ivalidate_CSV(DS, PictureBox_CSV)

        End Select

    End Sub

    Private Sub ToolStripMenuItem_XML_New_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        SaveFileDialog_XML()
        GET_ColumnTabele()

    End Sub

    Private Sub ToolStripMenuItem_Save_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Save.Click

        If CL_XML.ReadXML_Exists = True Then

            Save_General()
            'Save_Paper()
            Save_CardRow()

            If System.IO.File.Exists(CL_XML.DataSetFile) = True Then
                CL_XML.SaveXML(DS)
                IsModified = False
            Else
                SaveFileDialog_XML()
            End If

            GET_ColumnTabele()

        End If

    End Sub
    Private Sub ToolStripMenuItem_XML_Save(sender As Object, e As EventArgs) Handles ToolStripMenuItem_XML_SaveAs.Click

        SaveFileDialog_XML()
        GET_ColumnTabele()
        IsModified = False

    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Beenden.Click

        Me.Close()

    End Sub

    Private Function SaveFileDialog_XML() As DialogResult

        Dim SFD As New SaveFileDialog
        With SFD
            .CheckPathExists = True
            .Title = "Die Datei Speichern (" & CL_XML.DataSetFile & ")"
            .InitialDirectory = System.IO.Path.GetDirectoryName(CL_XML.DataSetFile)
            .FileName = TextBox_Paper_Paper.Text
            .Filter = "XML-Dateien (*.xml)|*.xml|Alle Dateien (*.*)|*.*"
        End With

        If SFD.ShowDialog = DialogResult.OK Then

            DS = CL_DS.Get_DS(DS)
            CL_XML.DataSetFile = SFD.FileName
            CL_XML.SaveXML(DS)
            IsModified = False

            DataSetRead()
            ToolStripMenuItem_Save.Enabled = True

        End If

        Return DialogResult

    End Function

    Private Sub GET_ColumnTabele()

        Dim Los As New List(Of String)

        With ListBox_Tabellen

            'erst alles entfernen, damit die Datenbindung neu aufgebaut werden kann, ohne dass es zu Fehlern kommt
            .DataSource = Nothing
            For Each Table As DataTable In DS.Tables
                Los.Add(Table.TableName)
            Next
            'befüllen die ListBox mit den Tabellennamen aus dem DataSet
            .DataSource = Los
        End With

    End Sub

    Private Sub CL_XML_Changetext(sender As Object, e As Object) Handles CL_XML.Changetext

        SET_Changetext_XML(sender, e)

    End Sub

    Private Sub SET_Changetext_XML(sender As Object, e As Object)

        Dim FI As New FileInfo(e)

        With FI
            UC_File_XML.TextBox_Directory.Text = .Directory.ToString
            UC_File_XML.TextBox_Filename.Text = .Name.ToString
            ToolStripStatusLabel_SaveFile.Text = .FullName
        End With

        IsModified = False

    End Sub

    Private Sub SET_Changetext_PDF(File As String)

        'ToDo Ordner Überprüfen und erstellen fals nicht vorhanden
        If System.IO.File.Exists(File) = True Then MessageBox.Show("Die Datei wurde nicht gefunden.", "Export in PDF")
        If File.Length = 0 Then Return

        Dim FI As New FileInfo(File)
        UC_File_PDF.TextBox_Directory.Text = FI.Directory.ToString
        UC_File_PDF.TextBox_Filename.Text = FI.Name.ToString

        IsModified = False

    End Sub

    Private Sub Button_CardRow_Add_Click(sender As Object, e As EventArgs) Handles Button_CardRow_Add.Click

        CL_DS.GET_CardRow(DS, -1)
        Set_CardRow_DataBinding()
        DataSetRead()

        CL_DS.DT_Border(DS.Tables("Border"), 1, "CardRow", 1, 1, 1, 1)
        CL_DS.DT_Font(DS.Tables("Border"), 1, "CardRow", My.Settings.Main_Font)

        'CL_Paint.Ivalidate_CSV(DS, PictureBox_CardRow)

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

    End Sub

    Private Sub Button_CardRow_List_Delete_Click(sender As Object, e As EventArgs) Handles Button_CardRow_Delete.Click

        With ListBox_CardRow
            If .SelectedItems.Count = 0 Then Return

            Dim ID As Integer = .Items(.SelectedIndex)("ID") '.SelectedItem("ID")
            DS.Tables("CardRow").Rows.Find(ID)?.Delete()
        End With

        Set_CardRow_DataBinding()

        'CL_Paint.Ivalidate_CSV(DS, PictureBox_CardRow)

    End Sub

    Private Sub ListBox_CardRow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_CardRow.SelectedIndexChanged

        If sender.CanSelect = False Then Return

        CardRow_View()

    End Sub

    Private Function CardRow_Check() As Boolean

        Dim Check As Boolean = True

        With ListBox_CardRow
            If .CanSelect = False Then Check = False
            If .CanFocus = False Then Check = False
            If IsNothing(.SelectedItem) = True Then Check = False
            If .SelectedItems.Count = 0 Then Check = False
            If .SelectedIndex = -1 Then Check = False
            If ComboBox_CardRow_DataColumn.Items.Count = 0 Then Check = False
            If DS.Tables("CardRow").Rows.Count = 0 Then Check = False

            CheckBox_CardRow_QRCode.Enabled = Check
            ComboBox_CardRow_DataColumn.Enabled = Check
            Label_CardRow_LinePos_Value.Enabled = Check
            CheckBox_CardRow_AutoFont.Enabled = Check
            Button_CardRow_FontColor.Enabled = Check

            Button_CardRow_Delete.Enabled = Check
            Button_CardRow_Edit.Enabled = Check
            Button_CardRow_Add.Enabled = True

            If Check = False Or .SelectedIndex = 0 Then
                Button_CardRow_Up.Enabled = False
            Else
                Button_CardRow_Up.Enabled = True
            End If

            If Check = False Or .SelectedIndex = .Items.Count - 1 Then
                Button_CardRow_Down.Enabled = False
            Else
                Button_CardRow_Down.Enabled = True
            End If

        End With

        UC_Border_CardRow.Enabled = Check
        UC_Font_CardRow.Enabled = Check

        Return Check

    End Function
    Private Sub CardRow_View()

        Dim Check As Boolean = CardRow_Check()

        With ListBox_CardRow

            If Check = True Then

                Dim ID As Integer = .Items(.SelectedIndex)("ID") ' .SelectedItem("ID")
                Dim DR As DataRow = CL_DS.GET_CardRow(DS, ID)

                CheckBox_CardRow_QRCode.Checked = CType(DR("QRCode"), Boolean)
                ComboBox_CardRow_DataColumn.Text = DR("DataColumn").ToString
                Label_CardRow_LinePos_Value.Text = CDbl(DR("LinePos")).ToString
                CheckBox_CardRow_AutoFont.Checked = CType(DR("AutoFont"), Boolean)

                With UC_Border_CardRow
                    .NumericUpDown_Left.Value = Convert.ToDecimal(DR("Left"))
                    .NumericUpDown_Top.Value = Convert.ToDecimal(DR("Top"))
                    .NumericUpDown_Right.Value = Convert.ToDecimal(DR("Right"))
                    .NumericUpDown_Bottom.Value = Convert.ToDecimal(DR("Bottom"))
                End With

                If IsNumeric(DR("FontColor")) = True Then
                    Button_CardRow_FontColor.BackColor = Color.FromArgb(DR("FontColor"))
                Else
                    Button_CardRow_FontColor.BackColor = Color.Black
                End If

                Dim nFont As Font = New Class_FontConverter().StringToFont(DR("Font").ToString)
                If nFont Is Nothing Then nFont = New Font("Arial", 12, FontStyle.Regular)

                With UC_Font_CardRow
                    .Label_Name_Value.Text = nFont.Name
                    .Label_Size_Value.Text = nFont.Size.ToString
                    .Label_Style_Value.Text = nFont.Style.ToString
                End With

            End If

        End With

    End Sub

    Private Sub Button_CardRow_Click(sender As Object, e As EventArgs) Handles Button_CardRow_Up.Click, Button_CardRow_Down.Click

        If sender.CanSelect = False Then Return

        CardRow_Sort(sender, e)
        'CL_Paint.Ivalidate_CSV(DS, PictureBox_CardRow)

    End Sub
    Private Sub CardRow_Sort(sender As Object, e As EventArgs)

        If ListBox_CardRow.Items.Count = 0 Then Return

        Dim ID As Integer
        ID = ListBox_CardRow.Items(ListBox_CardRow.SelectedIndex)("ID")

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
                CardRow_View()
            End If
        Next

    End Sub

    Private Sub Save_General()

        Dim DR As DataRow = DS.Tables("Paper").Rows(0)
        DR("Import") = File_CSV
        DR("Export") = File_PDF

    End Sub

    'Private Sub Save_Paper()

    '    Dim DR_Paper As DataRow = DS.Tables("Paper").Rows(0)

    '    DR_Paper("Paper") = TextBox_Paper_Paper.Text
    '    DR_Paper("DPI") = ComboBox_Paper_DPI.Text
    '    DR_Paper("DIN") = ComboBox_Paper_DIN.Text

    '    If ComboBox_Paper_DIN.CanSelect = True Then
    '        Dim DR_DIN As DataRow = DS.Tables("PaperDIN").Select($"[DIN]='{ComboBox_Paper_DIN.Text}'")(0)
    '        DR_Paper("PaperHeight") = DR_DIN("Height")
    '        DR_Paper("PaperWidth") = DR_DIN("Width")
    '    End If

    '    DR_Paper("Left") = UC_Border_Paper.NumericUpDown_Left.Value
    '    DR_Paper("Top") = UC_Border_Paper.NumericUpDown_Top.Value
    '    DR_Paper("Right") = UC_Border_Paper.NumericUpDown_Right.Value
    '    DR_Paper("Bottom") = UC_Border_Paper.NumericUpDown_Bottom.Value

    '    IsModified = True

    'End Sub

    Private Sub Save_CardRow()

        With ListBox_CardRow
            If .SelectedIndex > -1 Then

                Dim ID As Integer = ListBox_CardRow.Items(.SelectedIndex)("ID")
                Dim DR As DataRow = CL_DS.GET_CardRow(DS, ID)
                If DR Is Nothing Then Return

                DR("LinePos") = Label_CardRow_LinePos_Value.Text
                DR("QRCode") = CheckBox_CardRow_QRCode.Checked
                DR("AutoFont") = CheckBox_CardRow_AutoFont.Checked
                DR("FontColor") = Button_CardRow_FontColor.BackColor.ToArgb
                DR("DataColumn") = ComboBox_CardRow_DataColumn.SelectedValue
                DR("Font") = New Class_FontConverter().FontToString(UC_Font_CardRow.UC_Font)
                DR("Left") = UC_Border_CardRow.NumericUpDown_Left.Value
                DR("Top") = UC_Border_CardRow.NumericUpDown_Top.Value
                DR("Right") = UC_Border_CardRow.NumericUpDown_Right.Value
                DR("Bottom") = UC_Border_CardRow.NumericUpDown_Bottom.Value

                IsModified = True

            End If

        End With

    End Sub
    Private Sub Button_CardRow_Edit_Click(sender As Object, e As EventArgs) Handles Button_CardRow_Edit.Click

        If sender.canselect = False Then Return

        Save_CardRow()
        Set_CardRow_DataBinding()

    End Sub
    Private Sub Button_CardRow_FontColor_Click(sender As Object, e As EventArgs) Handles Button_CardRow_FontColor.Click

        Dim ID As Integer = ListBox_CardRow.Items(ListBox_CardRow.SelectedIndex)("ID")
        Dim Farbe As Color = Color.Black
        If ID > 0 Then Farbe = Color.FromArgb(DS.Tables("CardRow").Rows.Find(ID)("FontColor"))
        Dim CD As New ColorDialog With {.Color = Farbe}
        If CD.ShowDialog = DialogResult.OK Then
            Button_CardRow_FontColor.BackColor = CD.Color
        End If

    End Sub

    Private Sub DGV_CSV_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_CSV.SelectionChanged

        If sender.CanSelect = False Then Return

        'CL_Paint.Ivalidate_CSV(DS, PictureBox_CSV)

    End Sub

    Private Sub SetBorderValue(ByVal Table As String, ByVal e As UserControl_Border.Border, Optional ID As Integer = 0)

        Dim DR As DataRow = DS.Tables(Table).Rows.Find(ID)

        If IsNothing(DR) Then Return

        DR("Left") = e.Left
        DR("Top") = e.Top
        DR("Right") = e.Right
        DR("Bottom") = e.Bottom

    End Sub

    Private Sub ToolStripMenuItem_Open_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Open.Click

        UC_ChangeEvent_File(UC_File_XML, CL_XML.DataSetFile)

        Dim XMLBool As Boolean = CL_XML.ReadXML_Exists()
        ToolStripMenuItem_Save.Enabled = XMLBool
        TabControl_Main.Enabled = XMLBool

    End Sub

    Public Function GeneriereQR(url As String, size As Integer) As Bitmap

        Dim writer As New BarcodeWriter With {
            .Format = BarcodeFormat.QR_CODE,
            .Options = New EncodingOptions With {
                .Width = size,
                .Height = size,
                .Margin = 1,
                .PureBarcode = True
            }
        }

        ' Rückgabe des Bildes

        Return DirectCast(writer.Write(url), Bitmap)

    End Function

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click

        'Dim qrGen As New QRCodeGenerator
        'Dim zielURL As String = "https://www.miraphone.de/bb-trumpet-rotary-valves-19.html"
        'Dim qrBild As Bitmap = qrGen.ErstelleQR(zielURL, 960)

        'Me.PictureBox_CSV.Image = qrBild
        'CL_XML.ReadXML_Exists()

        CL_Default.Controlls_Read()

    End Sub


    Private Sub DGV_CSV_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGV_CSV.DataError

        e.Cancel = True

    End Sub

#Region "UC ChangeEvent"

    Private Sub UC_ChangeEvent_Font(sender As Object, e As Font) Handles _
        UC_Font_General.ChangeEvent,
        UC_Font_Card.ChangeEvent,
        UC_Font_CardRow.ChangeEvent

        Dim FRMSize As Size = Me.Size
        Select Case sender.Name
            Case "UC_Font_General"

                My.Settings.Main_Font = e
                My.Settings.Save()
                Me.Font = e

                CL_Default.Controlls_Read()

                Me.Size = FRMSize

            Case "UC_Font_Card"

            Case "UC_Font_CardRow"

        End Select

    End Sub

    Public Sub UC_ChangeEvent_Border(ByVal sender As Object, ByVal e As UserControl_Border.Border) Handles _
        UC_Border_Paper.ChangeEvent,
        UC_Border_Card.ChangeEvent,
        UC_Border_CardRow.ChangeEvent

        If sender.CanSelect = False Then Return

        Select Case sender.Name
            Case UC_Border_Paper.Name

                SetBorderValue("Paper", e)

                'CL_Paint.Ivalidate_Paper(Me, DS)

            Case UC_Border_Card.Name

                SetBorderValue("Card", e)

                'CL_Paint.Ivalidate_Card(Me, DS)

            Case UC_Border_CardRow.Name

                If ListBox_CardRow.SelectedIndex = -1 Then Return

                Dim ID As Integer = ListBox_CardRow.Items(ListBox_CardRow.SelectedIndex)("ID")
                SetBorderValue("CardRow", e, ID)

                'CL_Paint.Ivalidate_CSV(DS, PictureBox_CardRow)

        End Select

    End Sub

    Public Sub UC_ChangeEvent_File(sender As Object, e As String) Handles _
        UC_File_XML.ChangeEvent,
        UC_File_PDF.ChangeEvent,
        UC_File_CSV.ChangeEvent

        Select Case sender.Name
            Case "UC_File_XML"
                CL_XML.OpenFileDialog_XML(DS)
                DataSetRead()
                GET_ColumnTabele()
            Case "UC_File_PDF"
                Dim FBD As New FolderBrowserDialog
                If FBD.ShowDialog = DialogResult.OK Then
                    File_PDF = FBD.SelectedPath
                End If
            Case "UC_File_CSV"
                Dim Path As String = CL_XML.DataSetFile
                Dim OFD As New OpenFileDialog With {.Title = "Import CSV-Datei", .Filter = "CSV-Dateien (*.CSV)|*.CSV|Alle Dateien (*.*)|*.*"}
                If IsNothing(Path) = False Then
                    If System.IO.Directory.Exists(Path) = False AndAlso Path.Length > 0 Then
                        OFD.InitialDirectory = System.IO.Path.GetDirectoryName(Path)
                        OFD.FileName = System.IO.Path.GetFileName(Path)
                    End If
                End If
                If OFD.ShowDialog = DialogResult.OK Then File_CSV = OFD.FileName
        End Select

    End Sub

#End Region

End Class
