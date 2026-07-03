Imports CSVtoQR.UserControl_Border

Public Class UserControl_File

    Public Event ChangeEvent(ByVal sender As Object, ByVal e As String)

    Public Sub UC_Load(FRM As Form1, UC_Name As UserControl_File, TLP As TableLayoutPanel)

        With UC_Name

            .Dock = DockStyle.Top
            .Font = My.Settings.MyFont

            Select Case .Name
                Case "UC_File_XML"

                    .Label_Header.Text = "XML Files"
                    .Button_File.ImageKey = "File_XML"

                Case "UC_File_CSV"

                    .Label_Header.Text = "CSV Files"
                    .Button_File.ImageKey = "File_CSV"

                Case "UC_File_PDF"

                    .Label_Header.Text = "PDF Files"
                    .Button_File.ImageKey = "File_PDF"

            End Select
        End With

        TLP.RowCount += 1
        TLP.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        TLP.Controls.Add(UC_Name)

    End Sub

    Private Sub Button_File_Click(sender As Object, e As EventArgs) Handles Button_File.Click

        RaiseEvent ChangeEvent(Me, "File_Clicked")

    End Sub

End Class
