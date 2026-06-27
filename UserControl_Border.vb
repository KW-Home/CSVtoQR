Imports System.Runtime.Remoting.Channels

Public Class UserControl_Border

    Private ReadOnly FRM As Form1

    Public Event ChangeEvent(ByVal sender As Object, ByVal e As Border)

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

                        AddHandler UC.ChangeEvent, AddressOf Save_Data
                        AddHandler UC.ChangeEvent, AddressOf FRM.UC_Border_Paper_ChangeEvent

                    Case "UC_Border_Card"
                        .SetRow(UC, 4)
                        .SetRowSpan(UC, 1)
                        .SetColumn(UC, 0)
                        .SetColumnSpan(UC, 3)

                        AddHandler UC.ChangeEvent, AddressOf Save_Data
                        AddHandler UC.ChangeEvent, AddressOf FRM.UC_Border_Card_ChangeEvent

                    Case "UC_Border_CardRow"
                        .SetRow(UC, 3)
                        .SetRowSpan(UC, 1)
                        .SetColumn(UC, 0)
                        .SetColumnSpan(UC, 1)

                End Select
            End With

        Else

            UC = CType(TLP.Controls(UC_Name), UserControl_Border)

        End If

        GET_BorderToUC(UC, B)

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

    Private Sub Save_Data(Sender As Object, B As Border)

        Dim DR As DataRow = Nothing

        Select Case Sender.Name
            Case "UC_Border_Paper"
                DR = FRM.DS.Tables("Shema").Rows(0)
            Case "UC_Border_Card"
                DR = FRM.DS.Tables("Card").Rows(0)
            Case "UC_Border_CardRow"
                DR = FRM.DS.Tables("CardRow").Rows(0)
        End Select

        If IsNothing(DR) = False Then

            DR("Left") = B.Left
            DR("Top") = B.Top
            DR("Right") = B.Right
            DR("Bottom") = B.Bottom

            FRM.IsModified = True

        End If

    End Sub

End Class
