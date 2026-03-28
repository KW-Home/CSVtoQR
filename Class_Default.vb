Public Class Class_Default

    Private MyFont As Font

    Public Sub DefaultControls(ByRef FRM As Form1, ByRef DS As DataSet)

        With FRM

            MyFont = .Font

            .Main_SplitContainer.Dock = DockStyle.Fill
            .Main_MenuStrip.Font = MyFont
            .ToolStripStatusLabel_IsModified.BackColor = Color.Green

            With .Main_StatusStrip
                .Font = MyFont
                .Dock = DockStyle.Bottom
                .AutoSize = True
                .Margin = New Padding(0)
                .Padding = New Padding(0)
            End With

            With .Main_TabControl
                .Font = MyFont
                .Dock = DockStyle.Fill
                .AutoSize = True
                .Margin = New Padding(0)
            End With

            With .Main_BindingNavigator_CSV
                .Font = MyFont
                .Dock = DockStyle.Top
                .AutoSize = True
                .Margin = New Padding(0)
                .Padding = New Padding(0)
            End With

            With .ListBox_Tabellen
                .Font = MyFont
                .Dock = DockStyle.Left
                .AutoSize = True
                .Margin = New Padding(0)
                .Padding = New Padding(0)
            End With

            Dim ConList_Panel As New List(Of Panel) From {
        .Panel_Daten_CSV,
        .Panel_Paper}
            ' Die Panel_Paper soll sich über 3 Zeilen und 2 Spalten erstrecken, damit sie genügend Platz für die Papierdarstellung bietet.
            '.TableLayoutPanel_Paper.SetRowSpan(.Panel_Paper, 3)
            '.TableLayoutPanel_Paper.SetColumnSpan(.Panel_Paper, 2)

            For Each CON As Panel In ConList_Panel
                With CON
                    .BorderStyle = BorderStyle.FixedSingle
                    .Dock = DockStyle.Fill
                    .Margin = New Padding(3)
                    .Padding = New Padding(3)
                    .BackColor = Color.AliceBlue
                End With
            Next

            With .PictureBox_Paper
                .BorderStyle = BorderStyle.FixedSingle
                .Dock = DockStyle.None
                .Location = New Point(0, 0)
                .SizeMode = PictureBoxSizeMode.AutoSize
                .Margin = New Padding(3)
                .Padding = New Padding(3)
                .BackColor = Color.WhiteSmoke
            End With

            Dim ConList_DataGridView As New List(Of DataGridView) From {
        .DGV_CSV,
        .DGV_Search,
        .DGV_Table}
            For Each CON As DataGridView In ConList_DataGridView
                With CON
                    .Dock = DockStyle.Fill
                    .Font = MyFont
                    .AutoResizeColumnHeadersHeight()
                    .DefaultCellStyle.Font = MyFont
                    .MultiSelect = False
                    .AllowUserToAddRows = False
                    .AllowUserToDeleteRows = False
                    .AllowUserToOrderColumns = True
                    .AllowUserToResizeColumns = True
                    .AllowUserToResizeRows = True
                    .Margin = New Padding(3, 3, 3, 3)
                    .Padding = New Padding(0)
                    .DefaultCellStyle.BackColor = Color.White
                    .ScrollBars = ScrollBars.Both
                    .AutoSize = True

                    .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                    .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite
                End With
            Next

            Dim ConList_GroupBox As New List(Of GroupBox) From {
        .GroupBox_Shema,
        .GroupBox_Separator_Row,
        .GroupBox_Separator_Column,
        .GroupBox_Paper_Border,
        .GroupBox_Row_Border,
        .GroupBox_Row_Line,
        .GroupBox_Card}
            For Each CON As GroupBox In ConList_GroupBox
                With CON
                    .Font = MyFont
                    .Dock = DockStyle.Fill
                    .AutoSize = True
                    .Margin = New Padding(3, 3, 21, 3)
                    .Padding = New Padding(3)
                End With
            Next

            Dim ConList_CheckBox As New List(Of CheckBox) From {
                .CheckBox_QRCode,
                .CheckBox_AutoFont}
            For Each CON As CheckBox In ConList_CheckBox
                With CON
                    .Font = MyFont
                    .Dock = DockStyle.Left
                    .Appearance = Appearance.Normal
                    .Text = ""
                    .AutoSize = True
                    .Margin = New Padding(0)
                    .Padding = New Padding(0)
                End With
            Next

            Dim ConList_TableLayoutPanel As New List(Of TableLayoutPanel) From {
        .TableLayoutPanel_Shema,
        .TableLayoutPanel_Paper,
        .TableLayoutPanel_Paper_Border,
        .TableLayoutPanel_Separator,
        .TableLayoutPanel_Files,
        .TableLayoutPanel_Card,
        .TableLayoutPanel_Row,
        .TableLayoutPanel_Row_Line,
        .TableLayoutPanel_Row_Border}
            For Each CON As TableLayoutPanel In ConList_TableLayoutPanel
                With CON
                    .Font = MyFont
                    .Dock = DockStyle.Fill
                    .AutoSize = True
                    .AutoSizeMode = AutoSizeMode.GrowAndShrink
                    .BorderStyle = BorderStyle.None
                    .CellBorderStyle = TableLayoutPanelCellBorderStyle.None
                    .Margin = New Padding(0)
                    .Padding = New Padding(0)
                    .Location = New Point(20, 20)
                End With
            Next

            Dim ConList_TextBox As New List(Of TextBox) From {
        .TextBox_Shema,
        .TextBox_Import,
        .TextBox_Export}
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
            Next

            Dim ConList_NumericUpDown_Decimal As New List(Of NumericUpDown) From {
        .NumericUpDown_Separator_Spalte_Wert,
        .NumericUpDown_Separator_Zeile_Wert,
        .NumericUpDown_Paper_Border_Left,
        .NumericUpDown_Paper_Border_Top,
        .NumericUpDown_Paper_Border_Right,
        .NumericUpDown_Paper_Border_Bottom,
        .NumericUpDown_Card_Border_Left,
        .NumericUpDown_Card_Border_Top,
        .NumericUpDown_Card_Border_Right,
        .NumericUpDown_Card_Border_Bottom}
            For Each CON As NumericUpDown In ConList_NumericUpDown_Decimal
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
                End With
            Next

            Dim ConList_NumericUpDown_Anzahl As New List(Of NumericUpDown) From {
        .NumericUpDown_Separator_Column_Count,
        .NumericUpDown_Separator_Row_Anzahl}
            For Each CON As NumericUpDown In ConList_NumericUpDown_Anzahl
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
                End With
            Next

            Dim ConList_Label_Spalten As New List(Of Label) From {
        .Label_Separator_Row_Count,
        .Label_Separator_Row_Value}
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

            Dim ConList_Label_Zeilen As New List(Of Label) From {
        .Label_Shema,
        .Label_Import,
        .Label_Export,
        .Label_DPI,
        .Label_DIN,
        .Label_Paper_Height,
        .Label_Paper_Height_Unit,
        .Label_Paper_Width,
        .Label_Paper_Width_Unit,
        .Label_Separator_Row_Count,
        .Label_Separator_Row_Value,
        .Label_Separator_Column_Count,
        .Label_Separator_Column_Value,
        .Label_Paper_Border_Left,
        .Label_Paper_Border_Top,
        .Label_Paper_Border_Right,
        .Label_Paper_Border_Bottom,
        .Label_Paper_Border_Right_Unit, .Label_Paper_Border_Top_Unit, .Label_Paper_Border_Bottom_Unit,
        .Label_Paper_Border_Left_Unit, .Label12, .Label13, .Label14, .Label6,
        .Label8, .Label9, .Label10, .Label11}
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

            Dim ConList_Label_Value As New List(Of Label) From {
        .Label_Paper_Height_Value,
        .Label_Paper_Width_Value}
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

            Dim ConList_ComboBox As New List(Of ComboBox) From {
                .ComboBox_DIN,
                .ComboBox_DPI,
                .ComboBox_DataColumn}
            For Each CON As ComboBox In ConList_ComboBox
                With CON
                    .Font = MyFont
                    .Dock = DockStyle.Left
                    .Margin = New Padding(3)
                    .Padding = New Padding(0)
                    Select Case CON.Name
                        Case "CB_DPI"
                            .Items.AddRange(New Object() {72, 96, 150, 300, 600})
                        Case "CB_DIN"
                            .DataSource = DS.Tables("PaperDIN")
                            .DisplayMember = "DIN"
                            .ValueMember = "DIN"
                            If DS.Tables("Shema").Rows.Count > 0 Then
                                .SelectedValue = DS.Tables("Shema").Rows(0).Item("DIN").ToString
                            End If
                    End Select
                End With
            Next

            Dim ConList_TabPage As New List(Of TabPage) From {
        .TabPage_Card,
        .TabPage_Files,
        .TabPage_Paper,
        .TabPage_Table}
            For Each CON As TabPage In ConList_TabPage
                With CON
                    .Font = MyFont
                    .BackColor = Color.Transparent
                End With
            Next

            .Main_TabControl.ResumeLayout()

        End With

    End Sub

End Class
