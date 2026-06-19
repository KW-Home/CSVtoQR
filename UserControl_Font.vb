Public Class UserControl_Font

    Public Event Font_Change(ByVal sender As Object, ByVal e As Font)

    Private ReadOnly FRM As Form1
    Private UCF As UserControl_Font

    Public Sub New(ByRef _FRM As Form1)

        InitializeComponent()
        FRM = _FRM

    End Sub

    Private Sub Button_Font_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Font.Click
        Dim FD As New FontDialog With {.Font = My.Settings.MyFont}
        If FD.ShowDialog = DialogResult.OK Then
            RaiseEvent Font_Change(Me, FD.Font)
        End If
    End Sub

    Private Sub GET_FontToUC(Font As Font)
        Label_Name_Value.Text = Font.Name.ToString
        Label_Style_Value.Text = Font.Style.ToString
        Label_Size_Value.Text = Font.Size.ToString
    End Sub

    Private Sub GET_FontToUC(FontString As String)
        Dim F As Font = New Class_FontConverter().StringToFont(FontString)
        GET_FontToUC(F)
    End Sub

    Public Sub UC_Load(TLP As TableLayoutPanel, UC_Name As String, _Font As Font)

        If TLP.Controls.ContainsKey(UC_Name) = False Then
            UCF = New UserControl_Font(FRM) With {.Name = UC_Name}
            With UCF
                .Dock = DockStyle.Top
                .Font = My.Settings.MyFont
            End With
            TLP.Controls.Add(UCF)
            AddHandler UCF.Font_Change, AddressOf FRM.UC_Font_Changed
        Else
            UCF = CType(TLP.Controls(UC_Name), UserControl_Font)
        End If

        UCF.GET_FontToUC(_Font)

    End Sub

End Class
