Imports System.IO
Imports System.Reflection
Imports System.Security.Cryptography

Public Class Form1

    Private DS As New DataSet
    Private CLcsv As New Class_ImportCSV
    Private DTcsv As DataTable
    Private DVcsv As DataView
    Private WithEvents DTSearch As DataTable

    Private IsModified_Value As Boolean
    Public Property IsModified() As Boolean
        Get
            Return IsModified_Value
        End Get
        Set(ByVal value As Boolean)
            IsModified_Value = value
            If value = True Then
                TSSL_IsModified.BackColor = Color.Red
                TSMI_Safe.Enabled = True
            Else
                TSSL_IsModified.BackColor = Color.Green
                TSMI_Safe.Enabled = False
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
            CSVLoad(value)
        End Set
    End Property

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        MySettings_Load()
        DefaultControls()
        DataSetRead()
        PaperPaint()

    End Sub
    Private Sub MySettings_Load()

        With My.Settings
            Me.Size = .MySize
            Me.Font = .MyFont
            If System.IO.File.Exists(.MySavePath) Then
                DS = New DataSet
                DS.ReadXml(.MySavePath)
            Else
                DS = New Class_DS().Get_DS
            End If
            TSSL_SaveFile.Text = .MySavePath
        End With

    End Sub
    Private Sub MySettings_Save()

        Me.WindowState = FormWindowState.Normal

        With My.Settings
            .MySize = Me.Size
            .MyFont = Me.Font
            .MySavePath = TSSL_SaveFile.Text
            .Save()
        End With

    End Sub

    Private Sub CSVLoad(Value As String)

        DTcsv = CLcsv.Load_CSV(Value)
        DVcsv = New DataView(DTcsv)

        BScsv.DataSource = DVcsv
        BNcsv.BindingSource = BScsv
        DGVcsv.DataSource = BScsv

        Dim cbCol As DataGridViewComboBoxColumn = TryCast(DGV_Search.Columns("FilterColumn"), DataGridViewComboBoxColumn)
        If cbCol IsNot Nothing Then
            cbCol.DataSource = CLcsv.DataColumnList
        End If

        DGV_Sarch_Formatting()
        TextBox_Import.Text = Value

    End Sub

    Private Sub DefaultControls()

        TSSL_IsModified.BackColor = Color.Green

        Dim MyFont = My.Settings.MyFont
        Main_MenuStrip.Font = MyFont
        Main_StatusStrip.Font = MyFont
        Main_TabControl.Font = MyFont

        With Main_MenuStrip
            .Font = MyFont
            .Dock = DockStyle.Top
            .AutoSize = True
            .Margin = New Padding(0)
            .Padding = New Padding(0)
        End With

        With PictureBox_Paper
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.AutoSize
            .Margin = New Padding(3)
            .Padding = New Padding(3)
            .BackColor = Color.WhiteSmoke
        End With

        Dim ConList_DGV As New List(Of DataGridView) From {DGVcsv, DGV_Search, DGV_Table}
        For Each CON As DataGridView In ConList_DGV
            With CON
                .AutoSize = True
                .DefaultCellStyle.Font = MyFont
                .MultiSelect = False
                .AllowUserToAddRows = False
                .Margin = New Padding(3, 3, 3, 3)
                .Padding = New Padding(0)
                .DefaultCellStyle.BackColor = Color.White
            End With
        Next

        Dim ConList_GroupBox As New List(Of GroupBox) From {GroupBox_Shema, GroupBox_Paper, GroupBox_Border, GroupBox_Separator, GroupBox_Files}
        For Each CON As GroupBox In ConList_GroupBox
            With CON
                .Font = MyFont
                .Dock = DockStyle.Top
                .AutoSize = True
                .Margin = New Padding(3, 3, 21, 3)
                .Padding = New Padding(3)
            End With
        Next

        Dim ConList_TableLayoutPanel As New List(Of TableLayoutPanel) From {TLP_Shema, TLP_Paper, TLP_Border, TLP_Separator, TLP_Files}
        For Each CON As TableLayoutPanel In ConList_TableLayoutPanel
            With CON
                .Font = MyFont
                .Dock = DockStyle.Fill
                .AutoSize = True
                .BorderStyle = BorderStyle.Fixed3D
                .Margin = New Padding(3)
                .Padding = New Padding(3)
            End With
        Next

        Dim ConList_TextBox As New List(Of TextBox) From {TextBox_Shema, TextBox_Import, TextBox_Export}
        For Each CON As TextBox In ConList_TextBox
            With CON
                .Font = MyFont
                .BorderStyle = BorderStyle.FixedSingle
                .Dock = DockStyle.Top
                .AutoSize = True
                .Margin = New Padding(3)
                .Padding = New Padding(3)
                .TextAlign = HorizontalAlignment.Left
            End With
            AddHandler CON.TextChanged, AddressOf TextBox_Shema_TextChanged
            AddHandler CON.Enter, AddressOf TextBox_SelectAll
        Next

        Dim ConList_NUD_Decimal As New List(Of NumericUpDown) From {
        NUD_SeparatorSpalteAnzahl, NUD_SeparatorSpalteWert, NUD_SeparatorZeileAnzahl, NUD_SeparatorZeileWert,
        NUD_PaperBorderLeft, NUD_PaperBorderTop, NUD_PaperBorderRight, NUD_PaperBorderBottom,
        NUD_CardBorderLeft, NUD_CardBorderTop, NUD_CardBorderRight, NUD_CardBorderBottom}
        For Each CON As NumericUpDown In ConList_NUD_Decimal
            With CON
                .Font = MyFont
                .BorderStyle = BorderStyle.FixedSingle
                .Dock = DockStyle.Top
                .AutoSize = True
                .Margin = New Padding(3)
                .Padding = New Padding(3)
                .TextAlign = HorizontalAlignment.Right
                .Minimum = 0
                .Maximum = 9999
                .Increment = 0.1
                .DecimalPlaces = 1
                AddHandler .ValueChanged, AddressOf NUD_ValueChanged
                AddHandler .ValueChanged, AddressOf PaperPaint
            End With
        Next

        Dim ConList_NUD_Anzahl As New List(Of NumericUpDown) From {NUD_SeparatorSpalteAnzahl, NUD_SeparatorZeileAnzahl}
        For Each CON As NumericUpDown In ConList_NUD_Anzahl
            With CON
                .Font = MyFont
                .BorderStyle = BorderStyle.FixedSingle
                .Dock = DockStyle.Top
                .AutoSize = True
                .Margin = New Padding(3)
                .Padding = New Padding(3)
                .TextAlign = HorizontalAlignment.Right
                .Minimum = 1
                .Increment = 1
                .Maximum = 12
                .DecimalPlaces = 0
                AddHandler .ValueChanged, AddressOf NUD_ValueChanged
                AddHandler .ValueChanged, AddressOf PaperPaint
            End With
        Next

        Dim ConList_Label_Spalten As New List(Of Label) From {Label_SeparatorAnzahl, Label_SeparatorWert, Label_BorderCard, Label_BorderPaper}
        For Each CON As Label In ConList_Label_Spalten
            With CON
                .Font = MyFont
                .Dock = DockStyle.Top
                .AutoSize = True
                .Margin = New Padding(0)
                .Padding = New Padding(0)
                .TextAlign = ContentAlignment.BottomCenter
            End With
        Next

        Dim ConList_Label_Zeilen As New List(Of Label) From {Label_Shema, Label_Import, Label_Export, Label_DPI, Label_DIN,
        Label_PaperHeight, Label_PaperHeightEinheit, Label_PaperWidth, Label_PaperWidthEinheit,
        Label_SeparatorZeile, Label_SeparatorSpalte, Label_Left, Label_Top, Label_Right, Label_Bottom}
        For Each CON As Label In ConList_Label_Zeilen
            With CON
                .Font = MyFont
                .Dock = DockStyle.Top
                .AutoSize = True
                .Margin = New Padding(0, 3, 0, 3)
                .Padding = New Padding(0)
                .TextAlign = ContentAlignment.MiddleLeft
            End With
        Next

        Dim ConList_Label_Value As New List(Of Label) From {Label_PaperHeight_Value, Label_PaperWidth_Value}
        For Each CON As Label In ConList_Label_Value
            With CON
                .Font = MyFont
                .Dock = DockStyle.Fill
                .AutoSize = True
                .Margin = New Padding(0, 3, 0, 3)
                .Padding = New Padding(0)
                .TextAlign = ContentAlignment.MiddleRight
            End With
        Next

        Dim ConList_ComboBox As New List(Of ComboBox) From {CB_DIN, CB_DPI}
        For Each CON As ComboBox In ConList_ComboBox
            With CON
                .Font = MyFont
                .Dock = DockStyle.Left
                .Margin = New Padding(0)
                .Padding = New Padding(0)
                Select Case CON.Name
                    Case "CB_DPI"
                        .Items.AddRange(New Object() {72, 96, 150, 300, 600})
                        AddHandler CON.SelectedIndexChanged, AddressOf CB_DPI_SelectedIndexChanged
                    Case "CB_DIN"
                        .DataSource = DS.Tables("PaperDIN")
                        .DisplayMember = "DIN"
                        .ValueMember = "DIN"
                        If DS.Tables("Shema").Rows.Count > 0 Then .SelectedValue = DS.Tables("Shema").Rows(0).Item("DIN").ToString
                        AddHandler CON.SelectedIndexChanged, AddressOf ComboBox_DIN_SelectedIndexChanged
                End Select
                AddHandler CON.SelectedValueChanged, AddressOf PaperPaint
            End With
        Next

    End Sub

    ' Hilfsmethode: selektiert gesamten Text einer TextBox beim Fokussieren (Enter-Ereignis)
    Private Sub TextBox_SelectAll(sender As Object, e As EventArgs)
        Dim tb As TextBox = TryCast(sender, TextBox)
        If tb Is Nothing Then Return
        If tb.CanSelect Then
            tb.SelectAll()
        End If
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub TSMI_XML_New_Click(sender As Object, e As EventArgs) Handles TSMI_XML_New.Click

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
            TSSL_SaveFile.Text = My.Settings.MySavePath
        End If

    End Sub

    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click

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
                TSSL_SaveFile.Text = My.Settings.MySavePath
            End If

        End If

    End Sub

    Private Sub TSMI_Save(sender As Object, e As EventArgs) Handles TSMI_Safe.Click, TSMI_XML_SaveAs.Click

        Dim Path As String = My.Settings.MySavePath
        Select Case sender.name
            Case "TSMI_Safe"
                If System.IO.File.Exists(Path) Then
                    DS.WriteXml(Path, XmlWriteMode.WriteSchema)
                    IsModified = False
                Else
                    SaveXML(Path)
                    IsModified = False
                End If
            Case "TSMI_XML_SaveAs"
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
            TSSL_SaveFile.Text = SFD.FileName
            ImportFile = SFD.FileName
            IsModified = False
            My.Settings.MySavePath = SFD.FileName
            My.Settings.Save()
        End If

    End Sub

    Private Sub ListBox_Tabellen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Tabellen.SelectedIndexChanged

        DGV_Table.DataSource = DS.Tables(ListBox_Tabellen.SelectedItem.ToString)

    End Sub

    Private Sub DataSetRead()

        If IsNothing(DS) Then Exit Sub
        If IsNothing(DS.Tables("Shema")) Then Exit Sub

        ListBox_Tabellen.Items.Clear()
        ListBox_Tabellen.Items.AddRange(DS.Tables.Cast(Of DataTable).Select(Function(t) t.TableName).ToArray())

        With DS.Tables("Shema")
            If .Rows.Count = 0 Then
                Dim DR As DataRow = .NewRow
                DR.Item("Shema") = "Standard"
                DR.Item("DPI") = 96
                DR.Item("DIN") = "A4"
                DR.Item("PaperHeight") = 297
                DR.Item("PaperWidth") = 210
                DR.Item("PaperBorderLeft") = 0
                DR.Item("PaperBorderTop") = 0
                DR.Item("PaperBorderRight") = 0
                DR.Item("PaperBorderBottom") = 0
                DR.Item("SeparatorSpalteAnzahl") = 1
                DR.Item("SeparatorSpalteWert") = 0
                DR.Item("SeparatorZeileAnzahl") = 1
                DR.Item("SeparatorZeileWert") = 0
                DR.Item("CardBorderLeft") = 0
                DR.Item("CardBorderTop") = 0
                DR.Item("CardBorderRight") = 0
                DR.Item("CardBorderBottom") = 0
                .Rows.Add(DR)
                IsModified = True
            Else
                ImportFile = .Rows(0).Item("Import").ToString
            End If

            With .Rows(0)
                TextBox_Shema.Text = .Item("Shema").ToString
                TextBox_Import.Text = ImportFile
                TextBox_Export.Text = .Item("Export").ToString
                CB_DPI.Text = .Item("DPI")
                CB_DIN.Text = .Item("DIN").ToString
                Label_PaperHeight_Value.Text = .Item("PaperHeight").ToString
                Label_PaperWidth_Value.Text = .Item("PaperWidth")
                NUD_PaperBorderLeft.Value = .Item("PaperBorderLeft")
                NUD_PaperBorderTop.Value = .Item("PaperBorderTop")
                NUD_PaperBorderRight.Value = .Item("PaperBorderRight")
                NUD_PaperBorderBottom.Value = .Item("PaperBorderBottom")
                NUD_SeparatorSpalteAnzahl.Value = .Item("SeparatorSpalteAnzahl")
                NUD_SeparatorSpalteWert.Value = .Item("SeparatorSpalteWert")
                NUD_SeparatorZeileAnzahl.Value = .Item("SeparatorZeileAnzahl")
                NUD_SeparatorZeileWert.Value = .Item("SeparatorZeileWert")
                NUD_CardBorderLeft.Value = .Item("CardBorderLeft")
                NUD_CardBorderTop.Value = .Item("CardBorderTop")
                NUD_CardBorderRight.Value = .Item("CardBorderRight")
                NUD_CardBorderBottom.Value = .Item("CardBorderBottom")
            End With
        End With

        With DS.Tables("Filter")
            If .Rows.Count = 0 Then Exit Sub
            DGV_Search.DataSource = DS.Tables("Filter")
        End With

    End Sub
    Private Sub DataSetWrite()

        If IsNothing(DS) Then Exit Sub
        If IsNothing(DS.Tables("Shema")) Then Exit Sub

        Dim DR As DataRow = DS.Tables("Shema").NewRow
        With DS.Tables("Shema")
            With DR
                .Item("Shema") = TextBox_Shema.Text
                .Item("Import") = TextBox_Import.Text
                .Item("Export") = TextBox_Export.Text
                .Item("DIN") = CB_DIN.Text
                .Item("DPI") = CB_DPI.Text
                If IsNumeric(Label_PaperHeight_Value.Text) = True Then .Item("PaperHeight") = Label_PaperHeight_Value.Text
                If IsNumeric(Label_PaperWidth_Value.Text) = True Then .Item("PaperWidth") = Label_PaperWidth_Value.Text
                If IsNumeric(NUD_PaperBorderLeft.Value) = True Then .Item("PaperBorderLeft") = NUD_PaperBorderLeft.Value
                If IsNumeric(NUD_PaperBorderTop.Value) = True Then .Item("PaperBorderTop") = NUD_PaperBorderTop.Value
                If IsNumeric(NUD_PaperBorderRight.Value) = True Then .Item("PaperBorderRight") = NUD_PaperBorderRight.Value
                If IsNumeric(NUD_PaperBorderBottom.Value) = True Then .Item("PaperBorderBottom") = NUD_PaperBorderBottom.Value
                If IsNumeric(NUD_SeparatorSpalteAnzahl.Value) = True Then .Item("SeparatorSpalteAnzahl") = NUD_SeparatorSpalteAnzahl.Value
                If IsNumeric(NUD_SeparatorSpalteWert.Value) = True Then .Item("SeparatorSpalteWert") = NUD_SeparatorSpalteWert.Value
                If IsNumeric(NUD_SeparatorZeileAnzahl.Value) = True Then .Item("SeparatorZeileAnzahl") = NUD_SeparatorZeileAnzahl.Value
                If IsNumeric(NUD_SeparatorZeileWert.Value) = True Then .Item("SeparatorZeileWert") = NUD_SeparatorZeileWert.Value
                If IsNumeric(NUD_CardBorderLeft.Value) = True Then .Item("CardBorderLeft") = NUD_CardBorderLeft.Value
                If IsNumeric(NUD_CardBorderTop.Value) = True Then .Item("CardBorderTop") = NUD_CardBorderTop.Value
                If IsNumeric(NUD_CardBorderRight.Value) = True Then .Item("CardBorderRight") = NUD_CardBorderRight.Value
                If IsNumeric(NUD_CardBorderBottom.Value) = True Then .Item("CardBorderBottom") = NUD_CardBorderBottom.Value
            End With

            If .Rows.Count > 0 Then .Rows.Clear()
            .Rows.Add(DR)

        End With

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
                    DS.WriteXml(My.Settings.MySavePath, XmlWriteMode.WriteSchema)
                Case DialogResult.No
                    ' Do nothing
                Case DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If

    End Sub

    Private Sub NUD_ValueChanged(sender As Object, e As EventArgs)

        If sender.canselect = False Then Return
        IsModified = True

        Dim ObjName As String = sender.Name
        ObjName = ObjName.Replace("NUD_", "")
        DS.Tables("Shema").Rows(0).Item(ObjName) = sender.value

    End Sub

    Private Sub TextBox_Shema_TextChanged(sender As Object, e As EventArgs)

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
            DVcsv.RowFilter = String.Empty
            Return
        End If

        DGV_Search.EndEdit()

        DTSearch = TryCast(DGV_Search.DataSource, DataTable)
        For Each Wert As DataRow In DTSearch.Rows

            Dim FilterColumn As String = Wert("FilterColumn").ToString()
            Dim FilterOperator As String = Wert("FilterOperator").ToString()
            Dim FilterValue As String = Wert("FilterValue").ToString()

            If FilterColumn Is Nothing OrElse FilterColumn.ToString.Trim.Length = 0 Then Continue For
            If FilterOperator Is Nothing OrElse FilterOperator.ToString.Trim.Length = 0 Then Continue For

            If FilterString.Length > 0 Then FilterString &= " And "

            'Enthält, Gleich, Ungleich, Beginnt mit, Endet mit, Länger als, Kürzer als
            Select Case FilterOperator
                Case "Enthält"
                    FilterString &= $"([{FilterColumn}] Like '%{FilterValue}%')"
                Case "Gleich"
                    FilterString &= $"([{FilterColumn}] = '{FilterValue}')"
                Case "Ungleich"
                    FilterString &= $"([{FilterColumn}] <> '{FilterValue}')"
                Case "Beginnt mit"
                    FilterString &= $"([{FilterColumn}] Like '{FilterValue}%')"
                Case "Endet mit"
                    FilterString &= $"([{FilterColumn}] Like '%{FilterValue}')"
                Case "Länger als"
                    FilterString &= $"(Len([{FilterColumn}]) > {FilterValue})"
                Case "Kürzer als"
                    FilterString &= $"(Len([{FilterColumn}]) < {FilterValue})"
            End Select
        Next

        Try
            DVcsv.RowFilter = FilterString
        Catch ex As Exception
        End Try

    End Sub

    Private Sub DGV_Search_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Search.CellLeave

        CSVSearch()

    End Sub

    Private Sub Button_SearchAdd_Click(sender As Object, e As EventArgs) Handles Button_SearchAdd.Click

        DGV_Sarch_Formatting()

        Dim DT As DataTable = DS.Tables("Filter")
        Dim DR As DataRow = DT.NewRow
        With DR
            .Item("FilterColumn") = DGVcsv.Columns(DGVcsv.CurrentCell.ColumnIndex).HeaderText
            .Item("FilterOperator") = "Gleich"
            .Item("FilterValue") = DGVcsv.CurrentCell.Value.ToString
        End With
        DT.Rows.Add(DR)

        DGV_Search.DataSource = DT
        DGV_Search.Update()


    End Sub
    Private Sub DGV_Sarch_Formatting()

        Try

            Dim lookupFilter As List(Of String) = CLcsv.DataColumnList
            Dim FilterColumn As New DataGridViewComboBoxColumn() With {.Name = "FilterColumn", .HeaderText = "FilterColumn", .DataPropertyName = "FilterColumn", .DataSource = lookupFilter, .ValueType = GetType(String)}
            If DGV_Search.Columns.Contains("FilterColumn") Then
                Dim idx = DGV_Search.Columns("FilterColumn").Index
                DGV_Search.Columns.Remove("FilterColumn")
                DGV_Search.Columns.Insert(idx, FilterColumn)
            Else
                DGV_Search.Columns.Insert(1, FilterColumn)
            End If

            Dim lookupOperator As New List(Of String) From {"Enthält", "Gleich", "Ungleich", "Beginnt mit", "Endet mit", "Länger als", "Kürzer als"}
            Dim FilterOperator As New DataGridViewComboBoxColumn() With {.Name = "FilterOperator", .HeaderText = "FilterOperator", .DataPropertyName = "FilterOperator", .DataSource = lookupOperator, .ValueType = GetType(String)}
            If DGV_Search.Columns.Contains("FilterOperator") Then
                Dim idx = DGV_Search.Columns("FilterOperator").Index
                DGV_Search.Columns.Remove("FilterOperator")
                DGV_Search.Columns.Insert(idx, FilterOperator)
            Else
                DGV_Search.Columns.Insert(1, FilterOperator)
            End If

        Catch ex As Exception
            Beep()
        End Try

    End Sub

    Private Sub Button_SearchDelete_Click(sender As Object, e As EventArgs) Handles Button_SearchDelete.Click

        If DGV_Search.SelectedCells.Count = 0 Then Return

        DGV_Search.Rows(DGV_Search.SelectedCells(0).RowIndex).Selected = True
        For Each DR As DataGridViewRow In DGV_Search.SelectedRows
            If DR.IsNewRow Then Continue For
            DGV_Search.Rows.Remove(DR)
        Next

        IsModified = True
        CSVSearch()

    End Sub

    Private Sub TSMI_Font_Click(sender As Object, e As EventArgs) Handles TSMI_Font.Click

        Dim FD As New FontDialog With {.Font = My.Settings.MyFont}
        If FD.ShowDialog = DialogResult.OK Then
            Me.Font = FD.Font
            My.Settings.MyFont = FD.Font
            DefaultControls()
        End If


    End Sub

    Private Sub PaperPaint()

        If DS Is Nothing Then Return
        If DS.Tables.Contains("Shema") = False Then Return
        If DS.Tables("Shema").Rows.Count = 0 Then Return

        'PictureBox_Paper.Invalidate()
        Dim PW As Single = DS.Tables("Shema").Rows(0).Item("PaperWidth")
        Dim PH As Single = DS.Tables("Shema").Rows(0).Item("PaperHeight")
        Dim PBL As Single = DS.Tables("Shema").Rows(0).Item("PaperBorderLeft")
        Dim PBT As Single = DS.Tables("Shema").Rows(0).Item("PaperBorderTop")
        Dim PBR As Single = DS.Tables("Shema").Rows(0).Item("PaperBorderRight")
        Dim PBB As Single = DS.Tables("Shema").Rows(0).Item("PaperBorderBottom")

        Dim P(2) As Pen
        P(0) = New Pen(Color.Red, 1)
        P(1) = New Pen(Color.Green, 1)
        PictureBox_Paper.Size = New Size(CInt(PW), CInt(PH))
        PictureBox_Paper.Image = New Bitmap(CInt(PW), CInt(PH))
        PW -= PBL
        PW -= PBR
        PH -= PBT
        PH -= PBB

        Try
            Using g As Graphics = Graphics.FromImage(PictureBox_Paper.Image)
                g.Clear(Color.White)
                g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                g.DrawRectangle(P(0), PBL, PBT, PW, PH)

                Dim SSA As Integer = DS.Tables("Shema").Rows(0).Item("SeparatorSpalteAnzahl")
                Dim SSW As Single = DS.Tables("Shema").Rows(0).Item("SeparatorSpalteWert")
                Dim CW As Single
                CW = (SSA - 1) * SSW
                CW = PW - CW
                CW /= SSA

                Dim SZA As Integer = DS.Tables("Shema").Rows(0).Item("SeparatorZeileAnzahl")
                Dim SZW As Single = DS.Tables("Shema").Rows(0).Item("SeparatorZeileWert")
                Dim CH As Single
                CH = (SZA - 1) * SZW
                CH = PH - CH
                CH /= SZA

                Dim CS As New SizeF(CW, CH)
                Dim CP = New PointF(PBL, PBT)
                For C = 1 To SZA Step 1
                    For R = 1 To SSA Step 1
                        g.DrawRectangle(P(1), CP.X, CP.Y, CS.Width, CS.Height)
                        CP.X = CP.X + CW + SSW
                    Next
                    CP.X = PBL
                    CP.Y = CP.Y + CS.Height + SZW
                Next

            End Using

        Catch ex As Exception
            MessageBox.Show("Fehler beim Zeichnen: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ComboBox_DIN_SelectedIndexChanged(sender As Object, e As EventArgs)

        If CB_DIN.SelectedIndex = -1 Then Return
        If CB_DIN.CanFocus = False Then Return

        DS.Tables("Shema").Rows(0)("DIN") = CType(CB_DIN.Text, String)

        DS.Tables("Shema").Rows(0)("PaperHeight") = CType(CB_DIN.SelectedItem("PaperHeight"), Integer)
        Label_PaperHeight_Value.Text = CB_DIN.SelectedItem("PaperHeight").ToString

        DS.Tables("Shema").Rows(0)("PaperWidth") = CType(CB_DIN.SelectedItem("PaperWidth"), Integer)
        Label_PaperWidth_Value.Text = CB_DIN.SelectedItem("PaperWidth").ToString

        IsModified = True

    End Sub

    Private Sub CB_DPI_SelectedIndexChanged(sender As Object, e As EventArgs)

        DS.Tables("Shema").Rows(0)("DPI") = CType(CB_DPI.Text, Integer)

    End Sub

    Private Sub DGV_Search_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGV_Search.DataError
        e.Cancel = True
    End Sub

    Private Sub DGV_Search_DataSourceChanged(sender As Object, e As EventArgs) Handles DGV_Search.DataSourceChanged

        CSVSearch()

    End Sub

End Class
