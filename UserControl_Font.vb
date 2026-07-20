Imports CSVtoQR.UserControl_Border

Public Class UserControl_Font

    Public UC_Font As Font = My.Settings.Main_Font

    Public Event ChangeEvent(ByVal sender As Object, ByVal e As Font)

    Private Sub Button_Font_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Font.Click

        Dim FD As New FontDialog With {.Font = My.Settings.Main_Font}
        If FD.ShowDialog = DialogResult.OK Then
            UC_Font = FD.Font
            RaiseEvent ChangeEvent(Me, FD.Font)
            GET_FontToUC(FD.Font)
        End If

    End Sub

    Public Sub GET_FontToUC(FontString As String)

        Dim _Font As Font = New Class_FontConverter().StringToFont(FontString)
        GET_FontToUC(_Font)

    End Sub

    Public Sub GET_FontToUC(_Font As Font)

        Label_Name_Value.Text = _Font.Name.ToString
        Label_Style_Value.Text = _Font.Style.ToString
        Label_Size_Value.Text = _Font.Size.ToString

    End Sub

    Public Sub UC_Load(ByRef FRM As Form1, ByRef UC As UserControl_Font, ByRef TLP As TableLayoutPanel)

        If TLP.Contains(UC) = False Then
            With UC
                .Dock = DockStyle.Top
                Select Case .Name
                    Case "UC_Font_General"
                        .Label_Header.Text = "Font General"
                    Case "UC_Font_Card"
                        .Label_Header.Text = "Font Kate"
                    Case "UC_Font_CardRow"
                        .Label_Header.Text = "Font Zeile"
                End Select
            End With
            TLP.RowCount += 1
            TLP.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            TLP.Controls.Add(UC)
        End If

    End Sub

End Class
