Imports System.IO
Imports CSVtoQR.UserControl_Border

Public Class UserControl_File

    Public Event ChangeEvent(ByVal sender As Object, ByVal e As String)

    Private Sub Button_File_Click(sender As Object, e As EventArgs) Handles Button_File.Click

        RaiseEvent ChangeEvent(Me, "File_Clicked")

    End Sub

    Public Sub SetToUC(File As FileInfo)

        If File.Exists = False Then
            TextBox_Directory.Text = String.Empty
            TextBox_Filename.Text = String.Empty
        Else
            TextBox_Directory.Text = File.DirectoryName
            TextBox_Filename.Text = File.Name
        End If

    End Sub

    Public Sub UC_Load(FRM As Form1, UC As UserControl_File, TLP As TableLayoutPanel, ByVal NewRow As Boolean, ByVal Pos As Form1.UC_Pos)

        With UC
            .Dock = DockStyle.Top
            .Font = My.Settings.Main_Font
            Select Case .Name
                Case "UC_File_XML"
                    .Label_Header.Text = "XML File"
                    .Button_File.ImageKey = "File_XML"
                Case "UC_File_CSV"
                    .Label_Header.Text = "CSV File"
                    .Button_File.ImageKey = "File_CSV"
                Case "UC_File_PDF"
                    .Label_Header.Text = "PDF File"
                    .Button_File.ImageKey = "File_PDF"
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

End Class
