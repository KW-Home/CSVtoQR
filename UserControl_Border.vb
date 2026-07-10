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
                    TLP.RowCount += 1
                    TLP.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Case "UC_Border_CardRow"
                    .Label_Header.Text = "Border CardRow"
                    TLP.RowCount += 1
                    TLP.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            End Select
        End With

        TLP.Controls.Add(UC)

    End Sub

    Private Sub GET_BorderToUC(UC As UserControl_Border, B As Border)

        UC.NUD_Left.Value = B.Left
        UC.NUD_Top.Value = B.Top
        UC.NUD_Right.Value = B.Right
        UC.NUD_Bottom.Value = B.Bottom

    End Sub

    Private Sub NUD_Top_ValueChanged(sender As Object, e As EventArgs) Handles NUD_Top.ValueChanged,
        NUD_Bottom.ValueChanged, NUD_Right.ValueChanged, NUD_Left.ValueChanged

        Dim B As New Border With {
            .Left = NUD_Left.Value,
            .Top = NUD_Top.Value,
            .Right = NUD_Right.Value,
            .Bottom = NUD_Bottom.Value
        }

        RaiseEvent ChangeEvent(Me, B)

    End Sub

End Class
