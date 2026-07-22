Imports System.Runtime.Remoting.Channels

Public Class UserControl_Border

    Public Structure Border
        'Dim Border As New UserControl_Border.Border With {.Left = 0, .Top = 0, .Right = 0, .Bottom = 0}
        Dim Left As Decimal
        Dim Top As Decimal
        Dim Right As Decimal
        Dim Bottom As Decimal
    End Structure

    'Public Structure UC_Pos
    '    'Dim Pos As New UserControl_Border.UC_Pos With {.Row = 0, .RowSpan = 0, .Column = 0, .ColumnSpan = 0}
    '    Dim Row As Integer
    '    Dim RowSpan As Integer
    '    Dim Column As Integer
    '    Dim ColumnSpan As Integer
    'End Structure

    Public Event ChangeEvent(ByVal sender As Object, ByVal e As Border)

    Private Sub NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles _
        NumericUpDown_Top.ValueChanged,
        NumericUpDown_Bottom.ValueChanged,
        NumericUpDown_Right.ValueChanged,
        NumericUpDown_Left.ValueChanged

        Dim B As New Border With {.Left = NumericUpDown_Left.Value, .Top = NumericUpDown_Top.Value, .Right = NumericUpDown_Right.Value, .Bottom = NumericUpDown_Bottom.Value}
        RaiseEvent ChangeEvent(Me, B)

    End Sub

    Public Sub UC_Load(FRM As Form1, ByRef UC As UserControl_Border, ByRef TLP As TableLayoutPanel, ByVal NewRow As Boolean, ByVal Pos As Form1.UC_Pos)

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
        End With

        With TLP

            If NewRow = True Then
                .RowCount += 1
                .RowStyles.Add(New RowStyle(SizeType.AutoSize))
            End If

            .Controls.Add(UC)

            .SetRow(UC, Pos.Row)
            .SetRowSpan(UC, Pos.RowSpan)
            .SetColumn(UC, Pos.Column)
            .SetColumnSpan(UC, Pos.ColumnSpan)

        End With

    End Sub

    Public Sub SetToUC(B As Border)

        NumericUpDown_Left.Value = B.Left
        NumericUpDown_Top.Value = B.Top
        NumericUpDown_Right.Value = B.Right
        NumericUpDown_Bottom.Value = B.Bottom

    End Sub

End Class
