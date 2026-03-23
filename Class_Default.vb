Public Class Class_Default

    Public Sub DefaultControls(FRM As Form1, MyFont As Font)

        FRM.TSSL_IsModified.BackColor = Color.Green

        With FRM.Main_StatusStrip
            .Font = MyFont
            .Dock = DockStyle.Bottom
            .AutoSize = True
            .Margin = New Padding(0)
            .Padding = New Padding(0)
        End With

        With FRM.Main_TabControl
            .Font = MyFont
            .Dock = DockStyle.Fill
            .AutoSize = True
            .Margin = New Padding(0)
        End With

        With FRM.Main_BindingNavigator_CSV
            .Font = MyFont
            .Dock = DockStyle.Top
            .AutoSize = True
            .Margin = New Padding(0)
            .Padding = New Padding(0)
        End With

        With FRM.ListBox_Tabellen
            .Font = MyFont
            .Dock = DockStyle.Left
            .AutoSize = True
            .Margin = New Padding(0)
            .Padding = New Padding(0)
        End With

        Dim ConList_Panel As New List(Of Panel) From {
                FRM.Panel_Daten_CSV,
                FRM.Panel_Paper}
        ' Die Panel_Paper soll sich über 3 Zeilen und 2 Spalten erstrecken, damit sie genügend Platz für die Papierdarstellung bietet.
        FRM.TableLayoutPanel_Paper.SetRowSpan(FRM.Panel_Paper, 3)
        FRM.TableLayoutPanel_Paper.SetColumnSpan(FRM.Panel_Paper, 2)

        For Each CON As Panel In ConList_Panel
            With CON
                .BorderStyle = BorderStyle.FixedSingle
                .Dock = DockStyle.Fill
                .Margin = New Padding(3)
                .Padding = New Padding(3)
                .BackColor = Color.AliceBlue
            End With
        Next

        With FRM.PictureBox_Paper
            .BorderStyle = BorderStyle.FixedSingle
            .Dock = DockStyle.None
            .Location = New Point(0, 0)
            .SizeMode = PictureBoxSizeMode.AutoSize
            .Margin = New Padding(3)
            .Padding = New Padding(3)
            .BackColor = Color.WhiteSmoke
        End With

        Dim ConList_DataGridView As New List(Of DataGridView) From {
                FRM.DGV_CSV,
                FRM.DGV_Search,
                FRM.DGV_Table}
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
                .AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite
                .AutoSize = True
            End With
        Next

        Dim ConList_GroupBox As New List(Of GroupBox) From {
                FRM.GroupBox_Shema,
                FRM.GroupBox_Separator,
                FRM.GroupBox_Paper_Border}
        For Each CON As GroupBox In ConList_GroupBox
            With CON
                .Font = MyFont
                .Dock = DockStyle.Left
                .AutoSize = True
                .Margin = New Padding(3, 3, 21, 3)
                .Padding = New Padding(3)
            End With
        Next

        Dim ConList_TableLayoutPanel As New List(Of TableLayoutPanel) From {
                FRM.TableLayoutPanel_Shema,
                FRM.TableLayoutPanel_Paper,
                FRM.TableLayoutPanel_Paper_Border,
                FRM.TableLayoutPanel_Separator,
                FRM.TableLayoutPanel_Files,
                FRM.TableLayoutPanel_Card}
        For Each CON As TableLayoutPanel In ConList_TableLayoutPanel
            With CON
                .Font = MyFont
                .Dock = DockStyle.Fill
                .AutoSize = True
                .BorderStyle = BorderStyle.Fixed3D
                .Margin = New Padding(0)
                .Padding = New Padding(0)
                .Location = New Point(0, 0)
            End With
        Next

        Dim ConList_TextBox As New List(Of TextBox) From {
                FRM.TextBox_Shema,
                FRM.TextBox_Import,
                FRM.TextBox_Export}
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
                FRM.NUD_Separator_Spalte_Wert,
                FRM.NUD_Separator_Zeile_Wert,
                FRM.NUD_Paper_Border_Left,
                FRM.NUD_Paper_Border_Top,
                FRM.NUD_Paper_Border_Right,
                FRM.NUD_Paper_Border_Bottom,
                FRM.NUD_CardBorderLeft,
                FRM.NUD_CardBorderTop,
                FRM.NUD_CardBorderRight,
                FRM.NUD_CardBorderBottom}
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
        FRM.NUD_Separator_Spalte_Anzahl,
        FRM.NUD_Separator_Zeile_Anzahl}
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
        FRM.Label_Separator_Anzahl,
       FRM.Label_Separator_Wert}
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
            FRM.Label_Shema,
        FRM.Label_Import,
        FRM.Label_Export,
        FRM.Label_DPI,
        FRM.Label_DIN,
        FRM.Label_Paper_Height,
        FRM.Label_Paper_Einheit_Height,
        FRM.Label_Paper_Width,
        FRM.Label_Paper_Einheit_Width,
        FRM.Label_Separator_Zeile,
        FRM.Label_Separator_Spalte,
        FRM.Label_Left,
        FRM.Label_Top,
        FRM.Label_Right,
        FRM.Label_Bottom}
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
        FRM.Label_Paper_Value_Height,
        FRM.Label_Paper_Value_Width}
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
       FRM.CB_DIN,
        FRM.CB_DPI}
        For Each CON As ComboBox In ConList_ComboBox
            With CON
                .Font = MyFont
                .Dock = DockStyle.Left
                .Margin = New Padding(0)
                .Padding = New Padding(0)
                Select Case CON.Name
                    Case "CB_DPI"
                        .Items.AddRange(New Object() {72, 96, 150, 300, 600})
                    Case "CB_DIN"
                        .DataSource = FRM.DS.Tables("PaperDIN")
                        .DisplayMember = "DIN"
                        .ValueMember = "DIN"
                        If FRM.DS.Tables("Shema").Rows.Count > 0 Then
                            .SelectedValue = FRM.DS.Tables("Shema").Rows(0).Item("DIN").ToString
                        End If
                End Select
            End With
        Next

        Dim ConList_TabPage As New List(Of TabPage) From {
       FRM.TabPage_Card,
       FRM.TabPage_Files,
       FRM.TabPage_Paper,
       FRM.TabPage_Table}
        For Each CON As TabPage In ConList_TabPage
            With CON
                .Font = MyFont
                .BackColor = Color.Transparent
            End With
        Next

        FRM.Main_TabControl.ResumeLayout()

    End Sub

End Class
