Public Class Class_Paint

    Private ReadOnly CL_DS As Class_DS

    Public Sub Ivalidate_Paper(ByRef FRM As Form1, ByRef DS As DataSet)

        If IsNothing(DS) Then DS = CL_DS.Get_DS()

        Dim PW As Single = DS.Tables("Shema").Rows(0).Item("PaperWidth")
        Dim PH As Single = DS.Tables("Shema").Rows(0).Item("PaperHeight")

        Dim PBL As Single = 0
        Dim PBT As Single = 0
        Dim PBR As Single = 0
        Dim PBB As Single = 0
        'PictureBox_Paper.Invalidate()
        For Each DR As DataRow In DS.Tables("Border").Select("[Area] Like 'Paper'")
            Select Case DR("Border")
                Case "Left" : PBL = DR("Value")
                Case "Top" : PBT = DR("Value")
                Case "Right" : PBR = DR("Value")
                Case "Bottom" : PBB = DR("Value")
            End Select
        Next

        With FRM
            Dim P(2) As Pen
            P(0) = New Pen(Color.Red, 1)
            P(1) = New Pen(Color.Green, 1)
            .PictureBox_Paper.Size = New Size(CInt(PW), CInt(PH))
            .PictureBox_Paper.Image = New Bitmap(CInt(PW), CInt(PH))
            PW -= PBL
            PW -= PBR
            PH -= PBT
            PH -= PBB

            Try
                Using g As Graphics = Graphics.FromImage(.PictureBox_Paper.Image)
                    g.Clear(Color.White)
                    g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                    g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    g.DrawRectangle(P(0), PBL, PBT, PW, PH)

                    Dim SSA As Integer = DS.Tables("Shema").Rows(0).Item("SeparatorSpalteAnzahl")
                    Dim SSW As Single = DS.Tables("Shema").Rows(0).Item("SeparatorSpalteWert")
                    Dim CW As Single
                    CW = (SSA - 1) * SSW
                    CW = PW - CW
                    CW /= SSA

                    Dim SZA As Integer = DS.Tables("Shema").Rows(0).Item("SeparatorZeileAnzahl")
                    Dim SZW As Single = DS.Tables("Shema").Rows(0).Item("SeparatorZeileWert")
                    Dim CH As Single
                    CH = (SZA - 1) * SZW
                    CH = PH - CH
                    CH /= SZA

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
