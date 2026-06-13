Public Class UserControl_Border
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Structure Border
        Dim Left As Decimal
        Dim Top As Decimal
        Dim Right As Decimal
        Dim Bottom As Decimal
    End Structure

    Public Event Border_Changed(ByVal sender As Object, ByVal e As Border)

    Public Sub GET_BorderToUC(_Border As Border)
        NumericUpDown_Left.Value = _Border.Left
        NumericUpDown_Top.Value = _Border.Top
        NumericUpDown_Right.Value = _Border.Right
        NumericUpDown_Bottom.Value = _Border.Bottom
    End Sub

    Private Sub NumericUpDown_Top_Leave(sender As Object, e As EventArgs) Handles NumericUpDown_Top.Leave, NumericUpDown_Bottom.Leave, NumericUpDown_Right.Leave, NumericUpDown_Left.Leave
        RaiseEvent Border_Changed(Me, New Border With {
                                  .Left = NumericUpDown_Left.Value,
                                  .Top = NumericUpDown_Top.Value,
                                  .Right = NumericUpDown_Right.Value,
                                  .Bottom = NumericUpDown_Bottom.Value})
    End Sub
End Class
