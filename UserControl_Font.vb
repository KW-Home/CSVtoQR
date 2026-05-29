Public Class UserControl_Font

    Public Event Font_Changed(ByVal sender As Object, ByVal e As Font)

    Sub New(_Font As Font)

        InitializeComponent()
        'Label_Name_Value.Text = _Font.Name
        'Label_Size_Value.Text = _Font.Size.ToString
        'Label_Style_Value.Text = _Font.Style.ToString

    End Sub

    Private Sub Button_Font_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Font.Click

        Dim FD As New FontDialog With {.Font = My.Settings.MyFont}
        If FD.ShowDialog = DialogResult.OK Then RaiseEvent Font_Changed(Me, FD.Font)

    End Sub

End Class
