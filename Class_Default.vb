Public Class Class_Default

    Private ReadOnly FRM As Form1

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

        Dim _Font As Font = My.Settings.Main_Font

        With FRM

            .SuspendLayout()
            .Enabled = False

            For Each Con As Control In .Controls
                Controlls_Read_Sub(Con, _Font, False)
                Application.DoEvents()
            Next

            For Each Con As Control In .Controls
                Controlls_Read_Sub(Con, _Font, True)
                Application.DoEvents()
            Next

            .Enabled = True
            .ResumeLayout()

        End With

    End Sub

    Private Sub Controlls_Read_Sub(_Con As Control, _Font As Font, ByVal OnOff As Boolean)

        For Each Con As Control In _Con.Controls
            If OnOff = False Then
                Con.SuspendLayout()
                Select Case Con.GetType
                    Case GetType(Label)
                        Con.Font = New Font(_Font.FontFamily, _Font.Size, FontStyle.Bold)
                    Case GetType(PictureBox)
                        Controll_PictureBox_Load(Con)
                    Case GetType(TableLayoutPanel)
                        Dim TLP As TableLayoutPanel = Con
                        TLP.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
                    Case GetType(TabPage)
                        Con.Font = New Font(_Font.FontFamily, _Font.Size + 2, FontStyle.Bold And FontStyle.Underline And FontStyle.Italic)
                    Case GetType(DataGridView)
                        Dim DGV As DataGridView = Con
                        DGV.Font = _Font
                        DGV.ColumnHeadersDefaultCellStyle.Font = New Font(_Font.FontFamily, _Font.Size, FontStyle.Bold)
                        DGV.RowHeadersDefaultCellStyle.Font = New Font(_Font.FontFamily, _Font.Size, FontStyle.Bold)
                        DGV.DefaultCellStyle.Font = _Font
                        DGV.BackgroundColor = Color.WhiteSmoke
                        DGV.AlternatingRowsDefaultCellStyle = New DataGridViewCellStyle With {.BackColor = Color.FromArgb(255, 192, 255, 255)}
                    Case Else
                        Con.Font = _Font
                End Select
            Else
                Con.ResumeLayout()
            End If
            If Con.Controls.Count > 0 Then Controlls_Read_Sub(Con, _Font, OnOff)
        Next

    End Sub

    Private Sub Controll_PictureBox_Load(_PB As PictureBox)

        With _PB
            .Dock = DockStyle.Fill
            .Location = New Point(3, 3)
            .SizeMode = PictureBoxSizeMode.Normal
            .BackColor = Color.WhiteSmoke
        End With

    End Sub

End Class