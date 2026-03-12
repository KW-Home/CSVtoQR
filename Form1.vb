Imports System.Reflection
Imports System.Security.Cryptography

Public Class Form1

    Private DS As New DataSet

    Private CLcsv As New Class_ImportCSV
    Private DTcsv As DataTable
    Private DVcsv As DataView

    Private IsModified_Value As Boolean
    Public Property IsModified() As Boolean
        Get
            Return IsModified_Value
        End Get
        Set(ByVal value As Boolean)
            IsModified_Value = value
            If value = True Then
                TSSL_IsModified.BackColor = Color.Red
            Else
                TSSL_IsModified.BackColor = Color.Green
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
        DataSetRead()
        LoadTable()

        TSSL_IsModified.BackColor = Color.Green

        If DS.Tables("Shema").Rows.Count = 0 Then
            Dim DR As DataRow = DS.Tables("Shema").NewRow
            DR.Item("Shema") = "Standard"
            DR.Item("DPI") = 96
            DR.Item("DIN") = "A4"
            DR.Item("PaperHeight") = 297
            DR.Item("PaperWidth") = 210
            DS.Tables("Shema").Rows.Add(DR)
            DataSetRead()
            IsModified = True
        Else
            ImportFile = DS.Tables("Shema").Rows(0).Item("Import").ToString
        End If

        DefaultControls()

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

        TextBox_Import.Text = Value

    End Sub

    Private Sub DefaultControls()

        Dim MyFont = My.Settings.MyFont
        TSSL_IsModified.BackColor = Color.Green
        DGV_Search.AutoSize = True
        StatusStrip_Main.Font = MyFont

        Dim ConList_DGV As New List(Of DataGridView) From {DGVcsv, DGV_Search, DGV_Table}
        For Each CON As DataGridView In ConList_DGV
            With CON
                .DefaultCellStyle.Font = MyFont
                .MultiSelect = False
                .AllowUserToAddRows = False
                .Margin = New Padding(3, 3, 3, 3)
                .Padding = New Padding(0)
            End With
        Next

        Dim ConList_GroupBox As New List(Of GroupBox) From {GroupBox_Shema, GroupBox_Paper, GroupBox_Border, GroupBox_Separator, GroupBox_Files}
        For Each CON As GroupBox In ConList_GroupBox
            With CON
                .Font = MyFont
                .Dock = DockStyle.Top
                .AutoSize = True
                .Margin = New Padding(3, 3, 21, 3)
                .Padding = New Padding(0)
            End With
        Next

        Dim ConList_TableLayoutPanel As New List(Of TableLayoutPanel) From {
            TLP_Shema, TLP_Paper, TLP_Border, TLP_Separator, TLP_Files}
        For Each CON As TableLayoutPanel In ConList_TableLayoutPanel
            With CON
                .Font = MyFont
                .Dock = DockStyle.Fill
                .AutoSize = True
                .BorderStyle = BorderStyle.Fixed3D
                .Margin = New Padding(0)
                .Padding = New Padding(0)
            End With
        Next

        Dim ConList_TextBox As New List(Of TextBox) From {
            TextBox_Shema, TextBox_Import, TextBox_Export, TextBox_DPI, TextBox_PaperHeight, TextBox_PaperWidth,
            TextBox_SeparatorSpalteAnzahl, TextBox_SeparatorSpalteWert, TextBox_SeparatorZeileAnzahl, TextBox_SeparatorZeileWert,
            TextBox_PaperBorderLeft, TextBox_PaperBorderTop, TextBox_PaperBorderRight, TextBox_PaperBorderBottom,
            TextBox_CardBorderLeft, TextBox_CardBorderTop, TextBox_CardBorderRight, TextBox_CardBorderBottom}
        For Each CON As TextBox In ConList_TextBox
            With CON
                .Font = MyFont
                .BorderStyle = BorderStyle.FixedSingle
                .Dock = DockStyle.Top
                .AutoSize = True
                .Margin = New Padding(0)
                .Padding = New Padding(0)
                .TextAlign = HorizontalAlignment.Left
            End With
            AddHandler CON.Enter, AddressOf TextBox_SelectAll
        Next

        Dim ConList_LabelSpalten As New List(Of Label) From {
            Label_SeparatorAnzahl, Label_SeparatorWert,
            Label_BorderCard, Label_BorderPaper}
        For Each CON As Label In ConList_LabelSpalten
            With CON
                .Font = MyFont
                .Dock = DockStyle.Top
                .AutoSize = True
                .Margin = New Padding(0)
                .Padding = New Padding(0)
                .TextAlign = ContentAlignment.BottomCenter
            End With
        Next

        Dim ConList_LabelZeilen As New List(Of Label) From {
            Label_Shema, Label_Import, Label_Export, Label_DPI, Label_DIN,
            Label_PaperHeight, Label_PaperHeightEinheit, Label_PaperWidth, Label_PaperWidthEinheit,
            Label_SeparatorZeile, Label_SeparatorSpalte,
            Label_Left, Label_Top, Label_Right, Label_Bottom,
            Label_Left, Label_Top, Label_Right, Label_Bottom}
        For Each CON As Label In ConList_LabelZeilen
            With CON
                .Font = MyFont
                .Dock = DockStyle.Top
                .AutoSize = True
                .Margin = New Padding(0)
                .Padding = New Padding(0)
                .TextAlign = ContentAlignment.MiddleLeft
            End With
        Next


        Dim ConList_ToolStrip As New List(Of ToolStrip) From {MS_Main}
        For Each CON As ToolStrip In ConList_ToolStrip
            With CON
                .Font = MyFont
                .Dock = DockStyle.Top
                .AutoSize = True
                .Margin = New Padding(0)
                .Padding = New Padding(0)
            End With
        Next

        With ComboBox_DIN
            .Font = MyFont
            .Dock = DockStyle.Left
            .Margin = New Padding(0)
            .Padding = New Padding(0)

            .DataSource = DS.Tables("PaperDIN")
            .DisplayMember = "DIN"
            .ValueMember = "DIN"
            .SelectedValue = DS.Tables("Shema").Rows(0).Item("DIN").ToString

        End With

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

    Private Sub NeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuToolStripMenuItem.Click

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

    Private Sub SpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernToolStripMenuItem.Click

        DataSetWrite()

        Dim Path As String = My.Settings.MySavePath

        If System.IO.File.Exists(Path) Then
            DS.WriteXml(Path, XmlWriteMode.WriteSchema)
        Else

            Dim SFD As New SaveFileDialog With {
                .Title = "Die Datei " & Path & " existiert nicht.",
                .InitialDirectory = System.IO.Path.GetDirectoryName(Path),
                .Filter = "XML-Dateien (*.xml)|*.xml|Alle Dateien (*.*)|*.*"
            }

            If SFD.ShowDialog = DialogResult.OK Then
                DS.WriteXml(SFD.FileName, XmlWriteMode.WriteSchema)
                My.Settings.MySavePath = SFD.FileName
                My.Settings.Save()
            End If
        End If

        IsModified = False

    End Sub

    Private Sub SpeichernunterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernunterToolStripMenuItem.Click

        Dim Path As String = My.Settings.MySavePath
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
            IsModified = False
        End If

    End Sub

    Private Sub LoadTable()

        ListBox_Tabellen.Items.Clear()
        ListBox_Tabellen.Items.AddRange(DS.Tables.Cast(Of DataTable).Select(Function(t) t.TableName).ToArray())

    End Sub

    Private Sub ListBox_Tabellen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Tabellen.SelectedIndexChanged

        DGV_Table.DataSource = DS.Tables(ListBox_Tabellen.SelectedItem.ToString)

    End Sub

    Private Sub DataSetRead()

        If IsNothing(DS) Then Exit Sub
        If IsNothing(DS.Tables("Shema")) Then Exit Sub

        With DS.Tables("Shema")
            If .Rows.Count = 0 Then Exit Sub
            With .Rows(0)
                TextBox_Shema.Text = .Item("Shema").ToString
                TextBox_Import.Text = .Item("Import").ToString
                TextBox_Export.Text = .Item("Export").ToString
                TextBox_DPI.Text = .Item("DPI").ToString
                ComboBox_DIN.Text = .Item("DIN").ToString
                TextBox_PaperHeight.Text = .Item("PaperHeight").ToString
                TextBox_PaperWidth.Text = .Item("PaperWidth").ToString
                TextBox_PaperBorderLeft.Text = .Item("PaperBorderLeft").ToString
                TextBox_PaperBorderTop.Text = .Item("PaperBorderTop").ToString
                TextBox_PaperBorderRight.Text = .Item("PaperBorderRight").ToString
                TextBox_PaperBorderBottom.Text = .Item("PaperBorderBottom").ToString
                TextBox_SeparatorSpalteAnzahl.Text = .Item("SeparatorSpalteAnzahl").ToString
                TextBox_SeparatorSpalteWert.Text = .Item("SeparatorSpalteWert").ToString
                TextBox_SeparatorZeileAnzahl.Text = .Item("SeparatorZeileAnzahl").ToString
                TextBox_SeparatorZeileWert.Text = .Item("SeparatorZeileWert").ToString
                TextBox_CardBorderLeft.Text = .Item("CardBorderLeft").ToString
                TextBox_CardBorderTop.Text = .Item("CardBorderTop").ToString
                TextBox_CardBorderRight.Text = .Item("CardBorderRight").ToString
                TextBox_CardBorderBottom.Text = .Item("CardBorderBottom").ToString
            End With
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
                .Item("DIN") = ComboBox_DIN.Text
                If IsNumeric(TextBox_DPI.Text) = True Then .Item("DPI") = TextBox_DPI.Text
                If IsNumeric(TextBox_PaperHeight.Text) = True Then .Item("PaperHeight") = TextBox_PaperHeight.Text
                If IsNumeric(TextBox_PaperWidth.Text) = True Then .Item("PaperWidth") = TextBox_PaperWidth.Text
                If IsNumeric(TextBox_PaperBorderLeft.Text) = True Then .Item("PaperBorderLeft") = TextBox_PaperBorderLeft.Text
                If IsNumeric(TextBox_PaperBorderTop.Text) = True Then .Item("PaperBorderTop") = TextBox_PaperBorderTop.Text
                If IsNumeric(TextBox_PaperBorderRight.Text) = True Then .Item("PaperBorderRight") = TextBox_PaperBorderRight.Text
                If IsNumeric(TextBox_PaperBorderBottom.Text) = True Then .Item("PaperBorderBottom") = TextBox_PaperBorderBottom.Text
                If IsNumeric(TextBox_SeparatorSpalteAnzahl.Text) = True Then .Item("SeparatorSpalteAnzahl") = TextBox_SeparatorSpalteAnzahl.Text
                If IsNumeric(TextBox_SeparatorSpalteWert.Text) = True Then .Item("SeparatorSpalteWert") = TextBox_SeparatorSpalteWert.Text
                If IsNumeric(TextBox_SeparatorZeileAnzahl.Text) = True Then .Item("SeparatorZeileAnzahl") = TextBox_SeparatorZeileAnzahl.Text
                If IsNumeric(TextBox_SeparatorZeileWert.Text) = True Then .Item("SeparatorZeileWert") = TextBox_SeparatorZeileWert.Text
                If IsNumeric(TextBox_CardBorderLeft.Text) = True Then .Item("CardBorderLeft") = TextBox_CardBorderLeft.Text
                If IsNumeric(TextBox_CardBorderTop.Text) = True Then .Item("CardBorderTop") = TextBox_CardBorderTop.Text
                If IsNumeric(TextBox_CardBorderRight.Text) = True Then .Item("CardBorderRight") = TextBox_CardBorderRight.Text
                If IsNumeric(TextBox_CardBorderBottom.Text) = True Then .Item("CardBorderBottom") = TextBox_CardBorderBottom.Text
            End With

            If .Rows.Count > 0 Then .Rows.Clear()
            .Rows.Add(DR)

        End With

    End Sub

    Private Sub Button_Import_Click(sender As Object, e As EventArgs) Handles Button_Import.Click

        Dim Path As String = TextBox_Import.Text
        Dim OFD As New OpenFileDialog With {.Title = "Import CSV-Datei", .Filter = "CSV-Dateien (*.CSV)|*.CSV|Alle Dateien (*.*)|*.*"}

        If System.IO.Directory.Exists(Path) = False AndAlso Path.Length > 0 Then OFD.InitialDirectory = System.IO.Path.GetDirectoryName(Path)
        If OFD.ShowDialog = DialogResult.OK Then ImportFile = OFD.FileName

    End Sub

    Private Sub Button_Export_Click(sender As Object, e As EventArgs) Handles Button_Export.Click

        Dim SFD As New SaveFileDialog With {.Title = "Export PDF-Datei", .Filter = "PDF-Dateien (*.PDF)|*.PDF|Alle Dateien (*.*)|*.*"}
        If SFD.ShowDialog = DialogResult.OK Then
            TextBox_Export.Text = SFD.FileName
        End If

    End Sub

    Private Sub DateiToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles DateiToolStripMenuItem.DropDownOpening

        SpeichernToolStripMenuItem.Enabled = IsModified

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If IsModified = True Then
            If MessageBox.Show("Wollen Sie ohne Speichern schließen?", "Achtung Datenverlust !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                e.Cancel = True
            End If
        End If

        MySettings_Save()

    End Sub
    Private Sub TextBox_Paper_Changed(sender As Object, e As EventArgs) Handles TextBox_PaperWidth.TextChanged, TextBox_PaperHeight.TextChanged

        If sender.CanSelect = False Then Return
        IsModified = True

        If sender.Tag = "Integer" Then
            If IsNumeric(sender.Text) = False Then
                MessageBox.Show("Es sind nur Zahlen möglich!")
                sender.Undo()
            End If
        End If

        If IsNumeric(TextBox_PaperWidth.Text) = False Then Return
        DS.Tables("Shema").Rows(0).Item("PaperWidth") = TextBox_PaperWidth.Text

        If IsNumeric(TextBox_PaperHeight.Text) = False Then Return
        DS.Tables("Shema").Rows(0).Item("PaperHeight") = TextBox_PaperHeight.Text

        PaperPaint()

    End Sub

    Private Sub TextBox_Shema_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Shema.TextChanged, TextBox_SeparatorZeileWert.TextChanged, TextBox_SeparatorZeileAnzahl.TextChanged,
        TextBox_SeparatorSpalteWert.TextChanged, TextBox_SeparatorSpalteAnzahl.TextChanged, TextBox_PaperBorderTop.TextChanged,
        TextBox_PaperBorderRight.TextChanged, TextBox_PaperBorderLeft.TextChanged, TextBox_PaperBorderBottom.TextChanged,
        TextBox_DPI.TextChanged, TextBox_CardBorderTop.TextChanged, TextBox_CardBorderRight.TextChanged, TextBox_CardBorderLeft.TextChanged, TextBox_CardBorderBottom.TextChanged

        If sender.canselect = False Then Return
        IsModified = True

        If sender.tag = "Integer" Then
            If IsNumeric(sender.text) = False Then
                MessageBox.Show("Es sind nur Zahlen möglich!")
                sender.Undo()
            Else
                'ToDo : Werte in DS schreiben
                Dim ObjName As String = sender.Name
                ObjName = ObjName.Replace("TextBox_", "")
                DS.Tables("Shema").Rows(0).Item(ObjName) = sender.Text
            End If
        End If

        PaperPaint()

    End Sub

    Private Sub CSVSearch()

        DGV_Search.EndEdit()

        Dim FilterString As String = String.Empty

        For Each Wert As DataGridViewRow In DGV_Search.Rows

            If Wert.IsNewRow Then Continue For

            Dim FilterColumn As String = Wert.Cells("FilterColumn").Value
            Dim FilterValue As String = Wert.Cells("FilterValue").Value
            Dim FilterOperator As String = Wert.Cells("FilterOperator").Value

            If FilterColumn Is Nothing OrElse FilterColumn.ToString.Trim.Length = 0 Then Continue For
            If FilterOperator Is Nothing OrElse FilterOperator.ToString.Trim.Length = 0 Then Continue For

            If FilterString.Length > 0 Then FilterString &= " AND "

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

        Dim DR As DataGridViewRow
        DR = DGV_Search.Rows(DGV_Search.Rows.Add())
        With DGVcsv
            If .SelectedCells(0) Is Nothing Then Return
            If .SelectedCells(0).ColumnIndex = 0 Then Return
            DR.Cells("FilterColumn").Value = .Columns(.CurrentCell.ColumnIndex).HeaderText
            DR.Cells("FilterOperator").Value = "Gleich"
            DR.Cells("FilterValue").Value = .CurrentCell.Value
        End With

        CSVSearch()

    End Sub

    Private Sub Button_SearchDelete_Click(sender As Object, e As EventArgs) Handles Button_SearchDelete.Click

        If DGV_Search.SelectedCells.Count = 0 Then Return

        DGV_Search.Rows(DGV_Search.SelectedCells(0).RowIndex).Selected = True
        For Each DR As DataGridViewRow In DGV_Search.SelectedRows
            If DR.IsNewRow Then Continue For
            DGV_Search.Rows.Remove(DR)
        Next

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

        Dim PW As Integer = DS.Tables("Shema").Rows(0).Item("PaperWidth")
        Dim PH As Integer = DS.Tables("Shema").Rows(0).Item("PaperHeight")
        Dim PBL As Integer = DS.Tables("Shema").Rows(0).Item("PaperBorderLeft")
        Dim PBT As Integer = DS.Tables("Shema").Rows(0).Item("PaperBorderTop")
        Dim PBR As Integer = DS.Tables("Shema").Rows(0).Item("PaperBorderRight")
        Dim PBB As Integer = DS.Tables("Shema").Rows(0).Item("PaperBorderBottom")

        Dim P(2) As Pen
        P(0) = New Pen(Color.Red, 2)
        P(1) = New Pen(Color.Green, 2)
        PictureBox_Paper.Size = New Size(PW, PH)
        PictureBox_Paper.Image = New Bitmap(PW, PH)

        PBL += P(0).Width / 2
        PBT += P(0).Width / 2
        PBR += P(0).Width / 2
        PBB += P(0).Width / 2
        PW -= PBL
        PW -= PBR
        PH -= PBT
        PH -= PBB

        Try
            Using g As Graphics = Graphics.FromImage(PictureBox_Paper.Image)
                g.Clear(Color.White)
                g.DrawRectangle(P(0), PBL, PBT, PW, PH)

                Dim SSA As Integer = DS.Tables("Shema").Rows(0).Item("SeparatorSpalteAnzahl")
                Dim SSW As Integer = DS.Tables("Shema").Rows(0).Item("SeparatorSpalteWert")
                Dim CW As Integer = (PW - ((SSA - 1) * SSW)) / SSA

                Dim SZA As Integer = DS.Tables("Shema").Rows(0).Item("SeparatorZeileAnzahl")
                Dim SZW As Integer = DS.Tables("Shema").Rows(0).Item("SeparatorZeileWert")
                Dim CH As Integer = (PH - ((SZA - 1) * SZW)) / SZA

                Dim CP As Point
                Dim CS As New Size(CW, CH)
                Dim R As Integer

                'ToDo : Trennlinien zeichnen

                For C = PBL To PW Step CS.Width + SZW - P(1).Width
                    For R = PBT To PH Step CS.Height + SSW - P(1).Width
                        CP = New Point(C, R)
                        g.DrawRectangle(P(1), CP.X, CP.Y, CS.Width, CS.Height)
                    Next
                    R = PBT
                Next

            End Using

        Catch ex As Exception

        End Try



    End Sub

    Private Sub ComboBox_DIN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_DIN.SelectedIndexChanged

        If ComboBox_DIN.SelectedIndex = -1 Then Return
        If ComboBox_DIN.CanFocus = False Then Return

        DS.Tables("Shema").Rows(0)("PaperHeight") = CType(ComboBox_DIN.SelectedItem("PaperHeight"), Integer)
        TextBox_PaperHeight.Text = ComboBox_DIN.SelectedItem("PaperHeight").ToString

        DS.Tables("Shema").Rows(0)("PaperWidth") = CType(ComboBox_DIN.SelectedItem("PaperWidth"), Integer)
        TextBox_PaperWidth.Text = ComboBox_DIN.SelectedItem("PaperWidth").ToString

        PaperPaint()

    End Sub

End Class
