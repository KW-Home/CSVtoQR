Public Class Class_Paint

    Private ReadOnly CL_DS As New Class_DS

    Public Sub Ivalidate_Paper(ByRef FRM As Form1, ByRef DS As DataSet)

        DS = CL_DS.Get_DS(DS)

        Dim PW As Single = DS.Tables("Shema").Rows(0).Item("PaperWidth")
        Dim PH As Single = DS.Tables("Shema").Rows(0).Item("PaperHeight")
        Dim DR_Card As DataRow = DS.Tables("Card").Rows(0)

        Dim PBL As Single = 0
        Dim PBT As Single = 0
        Dim PBR As Single = 0
        Dim PBB As Single = 0

        'PictureBox_Paper.Invalidate()
        Dim DR_Shema As DataRow = DS.Tables("Shema").Rows(0)
        PBL = DR_Shema("Left")
        PBT = DR_Shema("Top")
        PBR = DR_Shema("Right")
        PBB = DR_Shema("Bottom")

        Dim SSA As Integer = CInt(DR_Shema("SeparatorSpalteAnzahl"))
        Dim SSW As Single = CType(DR_Shema("SeparatorSpalteWert"), Single)
        Dim SZA As Integer = CInt(DR_Shema("SeparatorZeileAnzahl"))
        Dim SZW As Single = CType(DR_Shema("SeparatorZeileWert"), Single)

        With FRM
            Dim P(2) As Pen
            P(0) = New Pen(Color.Red, 1)
            P(1) = New Pen(Color.Green, 1)
            .PictureBox_Preview.Size = New Size(CInt(PW), CInt(PH))
            .PictureBox_Preview.Image = New Bitmap(CInt(PW), CInt(PH))
            PW -= PBL
            PW -= PBR
            PH -= PBT
            PH -= PBB

            Try
                Using g As Graphics = Graphics.FromImage(.PictureBox_Preview.Image)
                    g.Clear(Color.White)
                    g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                    g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    g.DrawRectangle(P(0), PBL, PBT, PW, PH)

                    Dim CW As Single
                    CW = (SSA - 1) * SSW
                    CW = PW - CW
                    CW /= SSA

                    Dim CH As Single
                    CH = (SZA - 1) * SZW
                    CH = PH - CH
                    CH /= SZA

                    DR_Card("CardSizeWidth") = CW
                    DR_Card("CardSizeHeight") = CH
                    FRM.Label_Card_Size_Hight_Value.Text = CType(DR_Card("CardSizeHeight"), Decimal)
                    FRM.Label_Card_Size_Width_Value.Text = CType(DR_Card("CardSizeWidth"), Decimal)

                    Dim CS As New SizeF(CW, CH)
                    Dim CP = New PointF(PBL, PBT)
                    For C = 1 To SZA Step 1
                        For R = 1 To SSA Step 1
                            g.DrawRectangle(P(1), CP.X, CP.Y, CS.Width, CS.Height)
                            CP.X = CP.X + CW + SSW
                        Next
                        CP.X = PBL
                        CP.Y = CP.Y + CS.Height + SZW
                    Next

                End Using

            Catch ex As Exception
                MessageBox.Show("Fehler beim Zeichnen: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End With

    End Sub

End Class
