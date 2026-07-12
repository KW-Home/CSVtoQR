Public Class Class_Default

    Private ReadOnly FRM As Form1
    'Private ReadOnly DS As DataSet

    Public Sub New(ByRef _FRM As Form1)

        FRM = _FRM

        With FRM.ComboBox_Paper_DPI
            .Items.AddRange(New Object() {72, 96, 150, 300, 600})
        End With

        With FRM.ComboBox_Paper_DIN
            .DataSource = New Class_DS().PaperDIN
            .DisplayMember = "DIN"
            .ValueMember = "DIN"
            If FRM.DS.Tables("Paper").Rows.Count > 0 Then
                .SelectedValue = FRM.DS.Tables("Paper").Rows(0).Item("DIN").ToString
            End If
        End With

    End Sub

    Public Sub Controlls_Read()

        With FRM

            .SuspendLayout()
            Application.DoEvents()
            .Enabled = False
            .Font = My.Settings.Main_Font

            For Each Con As Control In .Controls
                Controlls_Read_Sub(Con)
            Next

            Application.DoEvents()

            .Enabled = True
            .ResumeLayout()

        End With

    End Sub

    Private Sub Controlls_Read_Sub(_Con As Control)

        For Each Con As Control In _Con.Controls

            Con.SuspendLayout()
            Application.DoEvents()
            Con.Font = My.Settings.Main_Font

            Select Case Con.GetType
                Case GetType(Label)
                    Con.Font = New Font(My.Settings.Main_Font.FontFamily, My.Settings.Main_Font.Size, FontStyle.Bold)
                Case GetType(PictureBox)
                    Controll_PictureBox_Load(Con)
                Case GetType(TableLayoutPanel)
                    Dim TLP As TableLayoutPanel = Con
                    TLP.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            End Select
            Con.ResumeLayout()

            If Con.Controls.Count > 0 Then Controlls_Read_Sub(Con)

        Next

    End Sub

    Private Sub Controll_PictureBox_Load(_PB As PictureBox)

        With _PB
            .Dock = DockStyle.Fill
            .Location = New Point(0, 0)
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With

    End Sub
End Class