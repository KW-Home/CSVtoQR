Imports System.Security.Cryptography

Public Class Class_DS

    'Private ReadOnly CLCF As New Class_ConvertFont

    Public Enum Auto_Font
        None
        AutoFontSize
        AutoWordWrap
    End Enum

    Public Function Get_DS() As DataSet

        Dim DS As New DataSet With {.DataSetName = "DataSetSystem"}
        With DS.Tables
            .Add(DT_Shema)
            .Add(DT_CardZeile)
            .Add(DT_PaperDIN)
            .Add(DT_Filter)
        End With

        Return DS

    End Function

    Private Function DT_Shema() As DataTable

        Dim DT As New DataTable
        With DT
            .TableName = "Shema"
            .Columns.Add(New DataColumn With {.ColumnName = "Shema", .Unique = False, .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "Import", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "Export", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "DPI", .DataType = GetType(Integer), .DefaultValue = 96})
            .Columns.Add(New DataColumn With {.ColumnName = "DIN", .DataType = GetType(String), .DefaultValue = "A4"})
            .Columns.Add(New DataColumn With {.ColumnName = "PaperHeight", .DataType = GetType(Double), .DefaultValue = 297})
            .Columns.Add(New DataColumn With {.ColumnName = "PaperWidth", .DataType = GetType(Double), .DefaultValue = 210})
            .Columns.Add(New DataColumn With {.ColumnName = "PaperBorderLeft", .DataType = GetType(Double), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "PaperBorderRight", .DataType = GetType(Double), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "PaperBorderTop", .DataType = GetType(Double), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "PaperBorderBottom", .DataType = GetType(Double), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "CardBorderLeft", .DataType = GetType(Double), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "CardBorderRight", .DataType = GetType(Double), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "CardBorderTop", .DataType = GetType(Double), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "CardBorderBottom", .DataType = GetType(Double), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "SeparatorZeileAnzahl", .DataType = GetType(Integer), .DefaultValue = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "SeparatorZeileWert", .DataType = GetType(Double), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "SeparatorSpalteAnzahl", .DataType = GetType(Integer), .DefaultValue = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "SeparatorSpalteWert", .DataType = GetType(Double), .DefaultValue = 0})
            .PrimaryKey = New DataColumn() { .Columns("Shema")}
        End With

        Return DT

    End Function

    Private Function DT_CardZeile() As DataTable

        Dim DT As New DataTable
        With DT
            .TableName = "CardZeile"
            .Columns.Add(New DataColumn With {.ColumnName = "ID", .AutoIncrement = True, .AutoIncrementSeed = 1, .AutoIncrementStep = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "QRCode", .DataType = GetType(Boolean)})
            .Columns.Add(New DataColumn With {.ColumnName = "BorderLeft", .DataType = GetType(Double)})
            .Columns.Add(New DataColumn With {.ColumnName = "BorderRight", .DataType = GetType(Double)})
            .Columns.Add(New DataColumn With {.ColumnName = "BorderTop", .DataType = GetType(Double)})
            .Columns.Add(New DataColumn With {.ColumnName = "BorderBottom", .DataType = GetType(Double)})
            .Columns.Add(New DataColumn With {.ColumnName = "ObjectSizeWidth", .DataType = GetType(Integer)})
            .Columns.Add(New DataColumn With {.ColumnName = "ObjectSizeHeight", .DataType = GetType(Integer)})
            .Columns.Add(New DataColumn With {.ColumnName = "DataColumn", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "LinePos", .DataType = GetType(Integer)})
            .Columns.Add(New DataColumn With {.ColumnName = "Font", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "FontColor", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "AutoFont", .DataType = GetType(Integer)})
            .PrimaryKey = New DataColumn() { .Columns("ID")}
        End With

        Return DT

    End Function

    Private Function DT_Filter() As DataTable

        Dim DT As New DataTable
        With DT
            .TableName = "Filter"
            .Columns.Add(New DataColumn With {.ColumnName = "ID", .AutoIncrement = True, .AutoIncrementSeed = 1, .AutoIncrementStep = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "FilterColumn", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "FilterOperator", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "FilterValue", .DataType = GetType(String)})
            .PrimaryKey = New DataColumn() { .Columns("ID")}
        End With

        Return DT

    End Function

    Private Function DT_Operante() As DataTable

        Dim DT As New DataTable
        With DT
            .TableName = "Operante"
            .Columns.Add(New DataColumn With {.ColumnName = "Operant", .DataType = GetType(String), .Unique = True, .AllowDBNull = False})
            .Columns.Add(New DataColumn With {.ColumnName = "OperantLeft", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "OperantRight", .DataType = GetType(String)})
            .PrimaryKey = New DataColumn() { .Columns("Operant")}
        End With
        '"Enthält", "Gleich", "Ungleich", "Beginnt mit", "Endet mit", "Länger als", "Kürzer als"
        DT.Rows.Add("Enthält", "LIKE", "LIKE")
        DT.Rows.Add("Gleich", "=", "=")
        DT.Rows.Add("Ungleich", "<>", "<>")
        DT.Rows.Add("Beginnt mit", "LIKE", "LIKE")
        DT.Rows.Add("Endet mit", "LIKE", "LIKE")
        DT.Rows.Add("Länger als", ">", ">")
        DT.Rows.Add("Kürzer als", "<", "<")


        Return DT

    End Function

    ''' <summary>
    ''' Gibt eine Liste mit den DIN Papierformaten zurück
    ''' </summary>
    ''' <returns>
    ''' Liste mit den DIN Papierformaten
    ''' </returns>
    Public Function Get_PaperDIN_ListOf() As List(Of String)

        Dim LoS As New List(Of String)

        Dim DT As DataTable = DT_PaperDIN()
        For Each DR As DataRow In DT.Rows
            LoS.Add(DR("DIN").ToString())
        Next

        Return LoS

    End Function

    Public Function DT_PaperDIN() As DataTable

        Dim DT As New DataTable
        With DT

            .TableName = "PaperDIN"

            .Columns.Add("DIN", GetType(String))
            .Columns.Add("PaperWidth", GetType(Double))
            .Columns.Add("PaperHeight", GetType(Double))

            .PrimaryKey = New DataColumn() { .Columns("DIN")}

            .Rows.Add("A0", 841, 1189)
            .Rows.Add("A1", 594, 841)
            .Rows.Add("A2", 420, 594)
            .Rows.Add("A3", 297, 420)
            .Rows.Add("A4", 210, 297)
            .Rows.Add("A5", 148, 210)
            .Rows.Add("B0", 1000, 1414)
            .Rows.Add("B1", 707, 1000)
            .Rows.Add("B2", 500, 707)
            .Rows.Add("B3", 353, 500)
            .Rows.Add("B4", 250, 353)
            .Rows.Add("B5", 176, 250)
            .Rows.Add("Crown", 381, 508)
            .Rows.Add("Demy", 445, 572)
            .Rows.Add("DoubleDemy", 572, 889)
            .Rows.Add("Elephant", 584, 711)
            .Rows.Add("Executive", 184, 267)
            .Rows.Add("Folio", 210, 330)
            .Rows.Add("Foolscap", 203, 330)
            .Rows.Add("GovernmentLetter", 203, 267)
            .Rows.Add("LargePost", 419, 533)
            .Rows.Add("Ledger", 432, 279)
            .Rows.Add("Legal", 216, 356)
            .Rows.Add("Letter", 216, 279)
            .Rows.Add("Medium", 457, 584)
            .Rows.Add("Post", 394, 489)
            .Rows.Add("QuadDemy", 889, 1143)
            .Rows.Add("Quarto", 203, 254)
            .Rows.Add("RA0", 860, 1220)
            .Rows.Add("RA1", 610, 860)
            .Rows.Add("RA2", 430, 610)
            .Rows.Add("RA3", 305, 430)
            .Rows.Add("RA4", 215, 305)
            .Rows.Add("RA5", 152, 215)
            .Rows.Add("Royal", 508, 635)
            .Rows.Add("Size10x14", 254, 356)
            .Rows.Add("Statement", 140, 216)
            .Rows.Add("STMT", 140, 216)
            .Rows.Add("Tabloid", 279, 432)

        End With

        Return DT

    End Function

End Class