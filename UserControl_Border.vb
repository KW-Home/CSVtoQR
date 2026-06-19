Public Class UserControl_Border

    Private ReadOnly FRM As Form1

    Public Event LeaveEvent(ByVal sender As Object, ByVal e As Border)

    Public Sub New(ByRef _FRM As Form1)
        InitializeComponent()
        FRM = _FRM
    End Sub

    Public Structure Border
        Dim Left As Decimal
        Dim Top As Decimal
        Dim Right As Decimal
        Dim Bottom As Decimal
    End Structure

    Public Sub UC_Load(TLP As TableLayoutPanel, UC_Name As String, B As Border)

        Dim UC As UserControl_Border
        If TLP.Controls.ContainsKey(UC_Name) = False Then

            UC = New UserControl_Border(FRM) With {.Name = UC_Name}
            With UC
                .Dock = DockStyle.Top
                .Font = My.Settings.MyFont
            End With

            TLP.Controls.Add(UC)
            AddHandler UC.LeaveEvent, AddressOf FRM.UC_Border_LeaveEvent

        Else

            UC = CType(TLP.Controls(UC_Name), UserControl_Border)

        End If

        With UC
            .NUD_Left.Value = B.Left
            .NUD_Top.Value = B.Top
            .NUD_Right.Value = B.Right
            .NUD_Bottom.Value = B.Bottom
        End With

    End Sub

    Private Sub LeaveSender() Handles NUD_Top.Leave, NUD_Bottom.Leave, NUD_Right.Leave, NUD_Left.Leave

        Dim B As Border
        B.Left = NUD_Left.Value
        B.Top = NUD_Top.Value
        B.Right = NUD_Right.Value
        B.Bottom = NUD_Bottom.Value

        RaiseEvent LeaveEvent(Me, B)

    End Sub

End Class
