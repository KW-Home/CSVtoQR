Imports CSVtoQR.UserControl_Border

Public Class UserControl_Font

    Public Event Font_Change(ByVal sender As Object, ByVal e As Font)
    Public UC_Font As Font = My.Settings.Main_Font

    Private ReadOnly FRM As Form1
    Private UC As UserControl_Font

    Public Sub New(ByRef _FRM As Form1)

        InitializeComponent()
        FRM = _FRM

    End Sub

    Private Sub Button_Font_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Font.Click

        Dim FD As New FontDialog With {.Font = My.Settings.Main_Font}
        If FD.ShowDialog = DialogResult.OK Then
            UC_Font = FD.Font
            RaiseEvent Font_Change(Me, FD.Font)
            GET_FontToUC(FD.Font)
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

    Public Sub UC_Load(UC_Name As String, _Font As Font)

        Dim TLP As TableLayoutPanel = Nothing
        Select Case UC_Name
            Case "UC_Font_General"
                TLP = FRM.TableLayoutPanel_General
            Case "UC_Font_Card"
                TLP = FRM.TableLayoutPanel_Card
            Case "UC_Font_CardRow"
                TLP = FRM.TableLayoutPanel_CardRow
        End Select

        If TLP.Controls.ContainsKey(UC_Name) = False Then
            UC = New UserControl_Font(FRM) With {.Name = UC_Name}
            With UC
                .Dock = DockStyle.Fill
                .Font = My.Settings.Main_Font
            End With

            TLP.Controls.Add(UC)

            With TLP

                .RowCount += 1
                .RowStyles.Add(New RowStyle(SizeType.AutoSize))

                Select Case UC_Name
                    Case "UC_Font_General"
                        AddHandler UC.Font_Change, AddressOf FRM.UC_Font_Font_Change
                    Case "UC_Font_Card"
                    Case "UC_Font_CardRow"
                End Select
            End With

        Else

            UC = CType(TLP.Controls(UC_Name), UserControl_Font)

        End If

        UC.GET_FontToUC(_Font)

    End Sub

End Class
