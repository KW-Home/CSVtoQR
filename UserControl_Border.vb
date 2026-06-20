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

    Public Sub UC_Load(UC_Name As String, B As Border)

        Dim TLP As TableLayoutPanel = Nothing
        Select Case UC_Name
            Case "UC_Border_Paper"
                TLP = FRM.TableLayoutPanel_Paper
            Case "UC_Border_Card"
                TLP = FRM.TableLayoutPanel_Card
            Case "UC_Border_CardRow"
                TLP = FRM.TableLayoutPanel_CardRow
        End Select

        Dim UC As UserControl_Border
        If TLP Is Nothing Then Exit Sub

        If TLP.Controls.ContainsKey(UC_Name) = False Then

            UC = New UserControl_Border(FRM) With {.Name = UC_Name}
            With UC
                .Dock = DockStyle.Top
                .Font = My.Settings.MyFont
            End With

            TLP.Controls.Add(UC)

            With TLP
                .RowCount += 1
                Select Case UC_Name
                    Case "UC_Border_Paper"
                        .SetRow(UC, 3)
                        .SetRowSpan(UC, 1)
                        .SetColumn(UC, 0)
                        .SetColumnSpan(UC, 1)
                    Case "UC_Border_Card"
                        .SetRow(UC, 4)
                        .SetRowSpan(UC, 1)
                        .SetColumn(UC, 0)
                        .SetColumnSpan(UC, 3)
                    Case "UC_Border_CardRow"
                        .SetRow(UC, 3)
                        .SetRowSpan(UC, 1)
                        .SetColumn(UC, 0)
                        .SetColumnSpan(UC, 1)
                End Select
            End With

            AddHandler UC.LeaveEvent, AddressOf FRM.UC_Border_LeaveEvent

        Else

            UC = CType(TLP.Controls(UC_Name), UserControl_Border)

        End If

        GET_BorderToUC(B)

    End Sub
    Private Sub GET_BorderToUC(B As Border)

        NUD_Left.Value = B.Left
        NUD_Top.Value = B.Top
        NUD_Right.Value = B.Right
        NUD_Bottom.Value = B.Bottom

    End Sub

    Private Sub LeaveSender() Handles NUD_Top.Leave, NUD_Bottom.Leave, NUD_Right.Leave, NUD_Left.Leave

        Dim B As Border
        B.Left = NUD_Left.Value
        B.Top = NUD_Top.Value
        B.Right = NUD_Right.Value
        B.Bottom = NUD_Bottom.Value

        GET_BorderToUC(B)
        RaiseEvent LeaveEvent(Me, B)

    End Sub

End Class
