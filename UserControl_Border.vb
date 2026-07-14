Imports System.Runtime.Remoting.Channels

Public Class UserControl_Border

    Public Event ChangeEvent(ByVal sender As Object, ByVal e As Border)

    Public Structure Border
        Dim Left As Decimal
        Dim Top As Decimal
        Dim Right As Decimal
        Dim Bottom As Decimal
    End Structure

    Public Sub UC_Load(FRM As Form1, ByRef UC As UserControl_Border, ByRef TLP As TableLayoutPanel)

        With UC
            .Dock = DockStyle.Top
            Select Case .Name
                Case "UC_Border_Paper"
                    .Label_Header.Text = "Border Paper"
                Case "UC_Border_Card"
                    .Label_Header.Text = "Border Card"
                Case "UC_Border_CardRow"
                    .Label_Header.Text = "Border CardRow"
                Case Else
                    Exit Select
            End Select
            TLP.RowCount += 1
            TLP.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        End With

        TLP.Controls.Add(UC)

    End Sub

    Public Sub GET_BorderToUC(UC As UserControl_Border, B As Border)

        UC.NumericUpDown_Left.Value = B.Left
        UC.NumericUpDown_Top.Value = B.Top
        UC.NumericUpDown_Right.Value = B.Right
        UC.NumericUpDown_Bottom.Value = B.Bottom

    End Sub

    Private Sub NUD_Top_ValueChanged(sender As Object, e As EventArgs) Handles _
        NumericUpDown_Top.ValueChanged,
        NumericUpDown_Bottom.ValueChanged,
        NumericUpDown_Right.ValueChanged,
        NumericUpDown_Left.ValueChanged

        Dim B As New Border With {
            .Left = NumericUpDown_Left.Value,
            .Top = NumericUpDown_Top.Value,
            .Right = NumericUpDown_Right.Value,
            .Bottom = NumericUpDown_Bottom.Value
        }

        RaiseEvent ChangeEvent(Me, B)

    End Sub

End Class
