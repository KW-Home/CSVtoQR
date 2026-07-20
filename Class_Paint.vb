Imports System.Configuration

Public Class Class_Paint

    Private ReadOnly CL_DS As New Class_DS

    Private ReadOnly Pen1 As New Pen(Color.Red, 1)
    Private ReadOnly Pen2 As New Pen(Color.Green, 1)

    Private DPI As Single = 96.0F 'Paper DPI
    Private DPIFactor As Single = 0

    Private PW As Single = 0 'Paper Width
    Private PH As Single = 0 'Paper Height
    Private PBL As Single = 0 'Paper Border Left
    Private PBT As Single = 0 'Paper Border Top
    Private PBR As Single = 0 'Paper Border Right
    Private PBB As Single = 0 'Paper Border Bottom
    Private PSSA As Integer = 1 'Paper Separator Spalte Anzahl
    Private PSSW As Single = 0 'Paper Separator Spalte Wert
    Private PSZA As Integer = 1 'Paper Separator Zeile Anzahl
    Private PSZW As Single = 0 'Paper Separator Zeile Wert

    Private CW As Single = 0 'Card Width
    Private CH As Single = 0 'Card Height
    Private BCL As Single = 0 'Card Border Left
    Private BCT As Single = 0 'Card Border Top
    Private BCR As Single = 0 'Card Border Right
    Private BCB As Single = 0 'Card Border Bottom

    Private Sub Fill_Parameter(ByRef DS As DataSet)

        DS = CL_DS.Get_DS(DS)

        With DS.Tables("Paper").Rows(0)

            DPI = CType(.Item("DPI"), Single)
            DPIFactor = DPI / 96.0F

            PW = .Item("PaperWidth")
            PH = .Item("PaperHeight")

            PBL = CDbl(.Item("Left"))
            PBT = CDbl(.Item("Top"))
            PBR = CDbl(.Item("Right"))
            PBB = CDbl(.Item("Bottom"))
            PSSA = CInt(.Item("SeparatorSpalteAnzahl"))
            PSSW = CDbl(.Item("SeparatorSpalteWert"))
            PSZA = CInt(.Item("SeparatorZeileAnzahl"))
            PSZW = CDbl(.Item("SeparatorZeileWert"))

        End With

        With DS.Tables("Card").Rows(0)

            BCL = CDbl(.Item("Left"))
            BCT = CDbl(.Item("Top"))
            BCR = CDbl(.Item("Right"))
            BCB = CDbl(.Item("Bottom"))

            CW = (((PW - (PBL + PBR)) - ((PSSA - 1) * PSSW)) / PSSA)
            CH = (((PH - (PBT + PBB)) - ((PSZA - 1) * PSZW)) / PSZA)

            .Item("CardSizeWidth") = CW
            .Item("CardSizeHeight") = CH

        End With

    End Sub

    Public Sub Ivalidate_Paper(ByRef FRM As Form1, ByRef DS As DataSet)

        Fill_Parameter(DS)

        With FRM
            Dim P(2) As Pen
            P(0) = New Pen(Color.Red, 2)
            P(1) = New Pen(Color.Green, 1)
            .PictureBox_Paper.Size = New Size(CInt(PW), CInt(PH))
            .PictureBox_Paper.Image = New Bitmap(CInt(PW), CInt(PH))
            PW -= PBL + PBR
            PH -= PBT + PBB

            Try
                Using g As Graphics = Graphics.FromImage(.PictureBox_Paper.Image)

                    g.Clear(Color.White)
                    g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                    g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

                    Dim CS As New SizeF(CW, CH)
                    Dim CP = New PointF(PBL, PBT)
                    For C = 1 To PSZA Step 1
                        For R = 1 To PSSA Step 1
                            g.DrawRectangle(P(1), CP.X, CP.Y, CS.Width, CS.Height)
                            CP.X = CP.X + CW + PSSW
                        Next
                        CP.X = PBL
                        CP.Y = CP.Y + CS.Height + PSZW
                    Next

                    g.DrawRectangle(P(0), PBL, PBT, PW, PH)

                End Using

            Catch ex As Exception

                MessageBox.Show("Ivalidate_Paper: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End With

    End Sub

    Public Sub Ivalidate_Card(ByRef FRM As Form1, ByRef DS As DataSet)

        Fill_Parameter(DS)

        Dim DR_Card As DataRow = DS.Tables("Card").Rows(0)
        'Dim DPI As Single = CType(DS.Tables("Paper").Rows(0)("DPI"), Single)
        'Dim DPIFactor As Single = DPI / 96.0F

        'Dim PW As Single = DR_Card.Item("CardSizeWidth") * DPIFactor
        'Dim PH As Single = DR_Card.Item("CardSizeHeight") * DPIFactor

        'Dim PBL As Single = DR_Card.Item("Left") * DPIFactor
        'Dim PBT As Single = DR_Card.Item("Top") * DPIFactor
        'Dim PBR As Single = DR_Card.Item("Right") * DPIFactor
        'Dim PBB As Single = DR_Card.Item("Bottom") * DPIFactor

        With FRM


            .PictureBox_Card.Size = New Size(CInt(CW), CInt(CH))
            .PictureBox_Card.Image = New Bitmap(CInt(CW), CInt(CH))


            Dim PP As New Point(PBL, PBT)
            Dim PS As New Size(CW, CH)
            Dim Rec As New Rectangle(PP, PS)

            Try
                Using g As Graphics = Graphics.FromImage(.PictureBox_Card.Image)
                    g.Clear(Color.White)
                    g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                    g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    g.DrawRectangle(Pen1, Rec)

                End Using

            Catch ex As Exception

                MessageBox.Show("Fehler beim Zeichnen: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End With

    End Sub


    Public Function Ivalidate_CSV(ByRef DS As DataSet, PictureBox As PictureBox) As Image

        DS = CL_DS.Get_DS(DS)

        Dim DR_Card As DataRow = DS.Tables("Card").Rows(0)
        Dim DPI As Single = CType(DS.Tables("Paper").Rows(0)("DPI"), Single)
        Dim DPIFactor As Single = DPI / 96.0F

        Dim PW As Single = DR_Card.Item("CardSizeWidth") * DPIFactor
        Dim PH As Single = DR_Card.Item("CardSizeHeight") * DPIFactor

        Dim PBL As Single = DR_Card.Item("Left") * DPIFactor
        Dim PBT As Single = DR_Card.Item("Top") * DPIFactor
        Dim PBR As Single = DR_Card.Item("Right") * DPIFactor
        Dim PBB As Single = DR_Card.Item("Bottom") * DPIFactor


        PictureBox.Size = New Size(CInt(PW), CInt(PH))
        PictureBox.Image = New Bitmap(CInt(PW), CInt(PH))

        PW -= PBL
        PW -= PBR
        PW -= Pen1.Width
        PH -= PBT
        PH -= PBB
        PH -= Pen1.Width

        Dim PP As New Point(PBL, PBT)
        Dim PS As New Size(PW, PH)
        Dim Rec As New Rectangle(PP, PS)

        Try
            Using g As Graphics = Graphics.FromImage(PictureBox.Image)
                g.Clear(Color.White)
                g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

                Dim nFont As Font
                Dim nFontHeight As Integer
                Dim CurrentTop As Integer = PBT

                Dim RowBorderLeft As Integer = 0
                Dim RowBorderTop As Integer = 0
                Dim RowBorderRight As Integer = 0
                Dim RowBorderBottom As Integer = 0

                Dim Index As Integer = -1

                If Form1.DGV_CSV.SelectedCells.Count > 0 Then

                    With Form1.DGV_CSV
                        If .SelectedCells.Count > 0 Then
                            Index = .SelectedCells(0).RowIndex
                            Index = .Item("ID", Index).Value
                        End If
                    End With

                    'Index = Form1.DGV_CSV.SelectedCells(0).RowIndex

                    Dim DR_CardRow As DataRow = Form1.DT_CSV.Select($"[ID] = {Index}")(0)
                    Dim STR As String = ""

                    'Dim DV As New DataView(DS.Tables("CardRow"))
                    'DV.Sort("LinePos ASC")
                    Dim DT As DataTable = DS.Tables("CardRow")

                    DT.DefaultView.Sort = "LinePos ASC"

                    Dim QRSize As Size = QRMaxSize(g, DT, Rec, DPIFactor)

                    For Each DR As DataRow In DT.DefaultView.ToTable().Rows

                        RowBorderLeft = DR("Left") * DPIFactor
                        RowBorderTop = DR("Top") * DPIFactor
                        RowBorderRight = DR("Right") * DPIFactor
                        RowBorderBottom = DR("Bottom") * DPIFactor

                        nFont = New Class_FontConverter().StringToFont(DR("Font"))
                        STR = DR_CardRow(DR("DataColumn").ToString())
                        nFontHeight = g.MeasureString(STR, nFont).Height

                        Dim Loc As New Point(PBL + RowBorderLeft, CurrentTop)
                        Dim Siz As New Size(PW - (RowBorderLeft + RowBorderRight), nFontHeight + RowBorderTop + RowBorderBottom)
                        Dim _Rec As New Rectangle(Loc, Siz)

                        If CType(DR("QRCode"), Boolean) = True Then

                            Dim QR As Image = QRCodePicture(STR)
                            Dim ImageNew As Image = ResizeImage(QR, QRSize.Height, QRSize.Height)

                            _Rec = New Rectangle(Loc, ImageNew.Size)

                            g.DrawRectangle(Pen1, _Rec)
                            g.DrawImage(ImageNew, New Point(PBL + RowBorderLeft, CurrentTop + RowBorderTop))

                            CurrentTop += ImageNew.Size.Height

                            ImageNew.Dispose()

                        Else
                            g.DrawRectangle(Pen1, _Rec)
                            g.DrawString(STR, nFont, Brushes.Black, New Point(PBL + RowBorderLeft, CurrentTop + RowBorderTop))
                            CurrentTop += nFontHeight
                        End If

                        CurrentTop += RowBorderTop
                        CurrentTop += RowBorderBottom

                    Next
                End If

                g.DrawRectangle(Pen2, Rec)

            End Using

        Catch ex As Exception

            MessageBox.Show("Fehler beim Zeichnen: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return PictureBox.Image

    End Function

    ' Hilfsfunktion: skaliert ein Image auf die gewünschte Pixel-Größe (hochwertig)
    Private Function ResizeImage(src As Image, width As Integer, height As Integer) As Image
        Dim dest As New Bitmap(width, height)
        dest.SetResolution(src.HorizontalResolution, src.VerticalResolution)

        Using GR As Graphics = Graphics.FromImage(dest)
            GR.CompositingMode = Drawing2D.CompositingMode.SourceCopy
            GR.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            GR.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            GR.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

            Using ia As New System.Drawing.Imaging.ImageAttributes()
                ia.SetWrapMode(Drawing2D.WrapMode.TileFlipXY)
                GR.DrawImage(src, New Rectangle(0, 0, width, height), 0, 0, src.Width, src.Height, GraphicsUnit.Pixel, ia)
            End Using
        End Using

        Return dest

    End Function

    Private Function QRMaxSize(g As Graphics, DT As DataTable, Rec As Rectangle, DPIFactor As Integer) As Size

        Dim nFont As Font
        Dim nFontHeight As Integer
        'Dim CurrentTop As Integer = PBT

        Dim CardHeight As Integer = Rec.Height
        Dim CardWidth As Integer = Rec.Width

        For Each DR As DataRow In DT.Rows

            Dim RowBorderLeft As Integer = DR("Left") * DPIFactor
            Dim RowBorderTop As Integer = DR("Top") * DPIFactor
            Dim RowBorderRight As Integer = DR("Right") * DPIFactor
            Dim RowBorderBottom As Integer = DR("Bottom") * DPIFactor

            If DR("QRCode") = False Then
                nFont = New Class_FontConverter().StringToFont(DR("Font"))
                nFontHeight = g.MeasureString("XXXXXX", nFont).Height + RowBorderTop + RowBorderBottom
            Else
                nFontHeight = RowBorderTop + RowBorderBottom
            End If
            CardHeight -= nFontHeight

        Next

        Return New Size(CardWidth, CardHeight)

    End Function
    Public Function QRCodePicture(URL As String) As Image

        'Dim qrGen As New QRCodeGenerator
        Return New QRCodeGenerator().ErstelleQR(URL, 960)

    End Function

End Class