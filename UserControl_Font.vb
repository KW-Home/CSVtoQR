Public Class UserControl_Font

    Public Event Font_Changed(ByVal sender As Object, ByVal e As Font)

    Private Sub Button_Font_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Font.Click

        Dim FD As New FontDialog With {.Font = My.Settings.MyFont}
        If FD.ShowDialog = DialogResult.OK Then

            RaiseEvent Font_Changed(Me, FD.Font)

        End If

    End Sub

    Public Sub GET_FontToUC(Font As Font)

        Label_Name_Value.Text = Font.Name.ToString
        Label_Style_Value.Text = Font.Style.ToString
        Label_Size_Value.Text = Font.Size.ToString

    End Sub

    Public Sub GET_FontToUC(FontString As String)

        Dim F As Font = New Class_FontConverter().StringToFont(FontString)

        Label_Name_Value.Text = F.Name.ToString
        Label_Style_Value.Text = F.Style.ToString
        Label_Size_Value.Text = F.Size.ToString

    End Sub

End Class
