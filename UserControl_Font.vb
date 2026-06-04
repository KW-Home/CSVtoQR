Public Class UserControl_Font

    Public Event Font_Changed(ByVal sender As Object, ByVal e As Font)

    'Sub New(_Font As Font)

    '    InitializeComponent()

    'End Sub

    Private Sub Button_Font_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Font.Click

        Dim FD As New FontDialog With {.Font = My.Settings.MyFont}
        If FD.ShowDialog = DialogResult.OK Then
            RaiseEvent Font_Changed(Me, FD.Font)
        End If

    End Sub
    Public Sub GET_FontToUC(ByRef _Font As Font)

        Label_Name_Value.Text = _Font.Name.ToString
        Label_Style_Value.Text = _Font.Style.ToString
        Label_Size_Value.Text = _Font.Size.ToString

    End Sub

End Class
