Imports System.Configuration

Public Class Class_Paint

    Private ReadOnly CL_DS As New Class_DS

    Public Sub Ivalidate_Paper(ByRef FRM As Form1, ByRef DS As DataSet)

        DS = CL_DS.Get_DS(DS)

        Dim PW As Single = DS.Tables("Shema").Rows(0).Item("PaperWidth")
        Dim PH As Single = DS.Tables("Shema").Rows(0).Item("PaperHeight")
        Dim DR_Card As DataRow = DS.Tables("Card").Rows(0)

        Dim DR_Shema As DataRow = DS.Tables("Shema").Rows(0)
        Dim PBL As Single = DR_Shema("Left")
        Dim PBT As Single = DR_Shema("Top")
        Dim PBR As Single = DR_Shema("Right")
        Dim PBB As Single = DR_Shema("Bottom")

        'PictureBox_Paper.Invalidate()
        Dim SSA As Integer = CInt(DR_Shema("SeparatorSpalteAnzahl"))
        Dim SSW As Single = CType(DR_Shema("SeparatorSpalteWert"), Single)
        Dim SZA As Integer = CInt(DR_Shema("SeparatorZeileAnzahl"))
        Dim SZW As Single = CType(DR_Shema("SeparatorZeileWert"), Single)

        With FRM
            Dim P(2) As Pen
            P(0) = New Pen(Color.Red, 2)
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
                    'g.DrawRectangle(P(0), PBL - 1, PBT - 1, PW + 2, PH + 2)

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

    Public Sub Ivalidate_Card(ByRef FRM As Form1, ByRef DS As DataSet)

        DS = CL_DS.Get_DS(DS)

        Dim DR_Card As DataRow = DS.Tables("Card").Rows(0)
        Dim DPI As Single = CType(DS.Tables("Shema").Rows(0)("DPI"), Single)
        Dim DPIFactor As Single = DPI / 96.0F

        Dim PW As Single = DR_Card.Item("CardSizeWidth") * DPIFactor
        Dim PH As Single = DR_Card.Item("CardSizeHeight") * DPIFactor

        Dim PBL As Single = DR_Card.Item("Left") * DPIFactor
        Dim PBT As Single = DR_Card.Item("Top") * DPIFactor
        Dim PBR As Single = DR_Card.Item("Right") * DPIFactor
        Dim PBB As Single = DR_Card.Item("Bottom") * DPIFactor

        With FRM

            Dim P(2) As Pen
            P(0) = New Pen(Color.Red, 2)
            P(1) = New Pen(Color.Green, 1)

            .PictureBox_Preview.Size = New Size(CInt(PW), CInt(PH))
            .PictureBox_Preview.Image = New Bitmap(CInt(PW), CInt(PH))

            PW -= PBL
            PW -= PBR
            PW -= P(1).Width
            PH -= PBT
            PH -= PBB
            PH -= P(1).Width

            Dim PP As New Point(PBL, PBT)
            Dim PS As New Size(PW, PH)
            Dim Rec As New Rectangle(PP, PS)

            Try
                Using g As Graphics = Graphics.FromImage(.PictureBox_Preview.Image)
                    g.Clear(Color.White)
                    g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                    g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    g.DrawRectangle(P(1), Rec)

                End Using

            Catch ex As Exception
                MessageBox.Show("Fehler beim Zeichnen: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End With

    End Sub

    Public Sub Ivalidate_CardRow(ByRef FRM As Form1, ByRef DS As DataSet)

        DS = CL_DS.Get_DS(DS)

        Dim DR_Card As DataRow = DS.Tables("Card").Rows(0)
        Dim DPI As Single = CType(DS.Tables("Shema").Rows(0)("DPI"), Single)
        Dim DPIFactor As Single = DPI / 96.0F

        Dim PW As Single = DR_Card.Item("CardSizeWidth") * DPIFactor
        Dim PH As Single = DR_Card.Item("CardSizeHeight") * DPIFactor

        Dim PBL As Single = DR_Card.Item("Left") * DPIFactor
        Dim PBT As Single = DR_Card.Item("Top") * DPIFactor
        Dim PBR As Single = DR_Card.Item("Right") * DPIFactor
        Dim PBB As Single = DR_Card.Item("Bottom") * DPIFactor

        With FRM

            Dim P(2) As Pen
            P(0) = New Pen(Color.Red, 2)
            P(1) = New Pen(Color.Green, 1)

            .PictureBox_Preview.Size = New Size(CInt(PW), CInt(PH))
            .PictureBox_Preview.Image = New Bitmap(CInt(PW), CInt(PH))

            PW -= PBL
            PW -= PBR
            PW -= P(1).Width
            PH -= PBT
            PH -= PBB
            PH -= P(1).Width

            Dim PP As New Point(PBL, PBT)
            Dim PS As New Size(PW, PH)
            Dim Rec As New Rectangle(PP, PS)

            Try
                Using g As Graphics = Graphics.FromImage(.PictureBox_Preview.Image)
                    g.Clear(Color.White)
                    g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                    g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    g.DrawRectangle(P(0), Rec)

                    Dim nFont As Font
                    Dim nFontHeight As Integer
                    Dim CurrentTop As Integer = PBT

                    Dim RowBorderLeft As Integer = 0
                    Dim RowBorderTop As Integer = 0
                    Dim RowBorderRight As Integer = 0
                    Dim RowBorderBottom As Integer = 0

                    Dim Index As Integer = -1
                    If Form1.DGV_CSV.SelectedCells.Count > 0 Then

                        Index = Form1.DGV_CSV.SelectedCells(0).RowIndex

                        Dim DR_CardRow As DataRow = Form1.DT_CSV.Rows(Index)
                        Dim STR As String = ""

                        'Dim DV As New DataView(DS.Tables("CardRow"))
                        'DV.Sort("LinePos ASC")
                        Dim DT As DataTable = DS.Tables("CardRow")


                        DT.DefaultView.Sort = "LinePos ASC"

                        For Each DR As DataRow In DT.DefaultView.ToTable().Rows

                            STR = DR_CardRow(DR("DataColumn").ToString())

                            RowBorderLeft = DR("Left") * DPIFactor
                            RowBorderTop = DR("Top") * DPIFactor
                            RowBorderRight = DR("Right") * DPIFactor
                            RowBorderBottom = DR("Bottom") * DPIFactor

                            nFont = New Class_FontConverter().StringToFont(DR("Font"))
                            nFontHeight = g.MeasureString(STR, nFont).Height

                            Dim Loc As New Point(PBL + RowBorderLeft, CurrentTop)
                            Dim Siz As New Size(PW - (RowBorderLeft + RowBorderRight), nFontHeight + RowBorderTop + RowBorderBottom)
                            Dim _Rec As New Rectangle(Loc, Siz)

                            g.DrawRectangle(P(1), _Rec)



                            g.DrawString(STR, nFont, Brushes.Black, New Point(PBL + RowBorderLeft, CurrentTop + RowBorderTop))

                            CurrentTop += nFontHeight
                            CurrentTop += RowBorderTop
                            CurrentTop += RowBorderBottom

                        Next
                    End If

                End Using

            Catch ex As Exception
                MessageBox.Show("Fehler beim Zeichnen: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End With

    End Sub

End Class
