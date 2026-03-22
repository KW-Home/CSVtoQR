Imports System.ComponentModel
Imports System.IO

Public Class Class_ImportCSV

    Private DataColumnList_Value As New List(Of String)
    <[Browsable](False), [ReadOnly](True), [Category](" System"), [DisplayName]("Spalten")>
    Public Property DataColumnList() As List(Of String)
        Get
            Return DataColumnList_Value
        End Get
        Set(ByVal value As List(Of String))
            DataColumnList_Value = value
        End Set
    End Property

    Public Function Load_CSV(ByRef DS As DataSet, ByRef CLDS As Class_DS, ByVal FilePath As String) As DataTable

        If File.Exists(FilePath) = True Then

            'Dim CL_DS As New Class_DS
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
                For I As Integer = 1 To lines.Length - 1
                    Dim values() As String = ($"{I - 1};" & lines(I)).Split(";"c)
                    DT.Rows.Add(values)
                Next

                ' ID-Spalte als schreibgeschützt markieren
                DT.Columns("ID").ReadOnly = True

                ' Spaltennamen in die Liste übernehmen
                DataColumnList.Clear()
                For Each Col In DT.Columns
                    DataColumnList.Add(Col.ColumnName)
                    CLDS.NEW_Search_Columns(DS, Col.ColumnName)
                Next

            End If

            Return DT

        End If

        Return Nothing

    End Function

End Class
