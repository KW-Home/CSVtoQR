Public Class UserControl_Font

    Public Event Font_Changed(ByVal sender As Object, ByVal e As Font)
    Sub New(_Font As Font)
        InitializeComponent()
        GET_General_Fonts(_Font)
    End Sub
    Private Sub Button_Font_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Font.Click
        Dim FD As New FontDialog With {.Font = My.Settings.MyFont}
        If FD.ShowDialog = DialogResult.OK Then
            'MyFont = FD.Font
            GET_General_Fonts(FD.Font)
            RaiseEvent Font_Changed(Me, FD.Font)
        End If
    End Sub
    Private Sub GET_General_Fonts(_Font As Font)
        With _Font
            Label_Name_Value.Text = .Name
            Label_Size_Value.Text = .Size.ToString
            Label_Style_Value.Text = .Style.ToString
        End With
    End Sub

End Class
