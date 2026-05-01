Imports System.ComponentModel
Imports System.IO

Public Class Class_CSV

    Public Function GET_CSV(ByRef DS As DataSet, ByRef CL_DS As Class_DS, ByVal FilePath As String) As DataTable

        If File.Exists(FilePath) = True Then

            Dim lines() As String = IO.File.ReadAllLines(FilePath, System.Text.Encoding.GetEncoding("Windows-1252"))
            Dim DT As New DataTable

            If lines.Length > 0 Then

                ' Spalten aus erster Zeile (Überschriften)
                Dim headers() As String = lines(0).Split(";"c)

                ' ID-Spalte hinzufügen
                DT.Columns.Add("ID", GetType(Integer))
                For Each header In headers
                    DT.Columns.Add(header.Trim)
                Next

                ' Datenzeilen
                Try
                    For I As Integer = 1 To lines.Length - 1
                        Dim values() As String = ($"{I - 1};" & lines(I)).Split(";"c)
                        DT.Rows.Add(values)
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Load_CSV")
                End Try

                ' ID-Spalte als schreibgeschützt markieren
                DT.Columns("ID").ReadOnly = True

                ' Spaltennamen in die Tabelle der Suchspalten übernehmen
                CL_DS.Search_Columns_NEW(DS, DT)

            End If

            Return DT

        End If

        Return Nothing

    End Function

End Class
