Imports System.Security.Cryptography
Imports CSVtoQR.Class_DS

Public Class Class_DS

    'Private ReadOnly CLCF As New Class_ConvertFont

    Public Enum Auto_Font
        None
        AutoFontSize
        AutoWordWrap
    End Enum

    Public Function Get_DS(DS As DataSet) As DataSet

        If DS Is Nothing Then DS = New DataSet With {.DataSetName = "DataSetSystem"}

        With DS.Tables

            DS = NewRow_Shema(DS)
            DS = NewRow_Card(DS)
            DS = NewRow_CardRow(DS)
            DS = NewRow_Search_Operator(DS)
            DS = NewRow_Border(0, "Paper", DS)
            DS = NewRow_Border(0, "Card", DS)
            DS = NewRow_Border(0, "CardRow", DS)

            If .Contains("Search") = False Then .Add(DT_Search)
            If .Contains("Search_Columns") = False Then .Add(DT_Search_Columns)

        End With

        Return DS

    End Function

    Private Function DT_Shema() As DataTable

        Dim DT As New DataTable With {.TableName = "Shema"}
        With DT
            .Columns.Add(New DataColumn With {.ColumnName = "Shema", .Unique = False, .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "Import", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "Export", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "DPI", .DataType = GetType(Integer), .DefaultValue = 96})
            .Columns.Add(New DataColumn With {.ColumnName = "DIN", .DataType = GetType(String), .DefaultValue = "A4"})
            .Columns.Add(New DataColumn With {.ColumnName = "PaperHeight", .DataType = GetType(Double), .DefaultValue = 297})
            .Columns.Add(New DataColumn With {.ColumnName = "PaperWidth", .DataType = GetType(Double), .DefaultValue = 210})
            .Columns.Add(New DataColumn With {.ColumnName = "SeparatorZeileAnzahl", .DataType = GetType(Integer), .DefaultValue = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "SeparatorZeileWert", .DataType = GetType(Double), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "SeparatorSpalteAnzahl", .DataType = GetType(Integer), .DefaultValue = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "SeparatorSpalteWert", .DataType = GetType(Double), .DefaultValue = 0})
            .PrimaryKey = New DataColumn() { .Columns("Shema")}
        End With

        Return DT

    End Function

    ''' <summary>
    ''' Fügt eine neue Zeile mit Standardwerten in die "Shema"-Tabelle ein, wenn diese leer ist.
    ''' </summary>
    Public Function NewRow_Shema(ByRef DS As DataSet) As DataSet

        If DS.Tables.Contains("Shema") = False Then DS.Tables.Add(DT_Shema)

        Dim DT As DataTable = DS.Tables("Shema")
        If DT.Rows.Count = 0 Then
            Dim DR As DataRow = DT.NewRow
            With DR
                .Item("Shema") = "Standard"
                .Item("Import") = String.Empty
                .Item("Export") = String.Empty
                .Item("DIN") = "A4"
                .Item("DPI") = 96
                .Item("PaperHeight") = 297
                .Item("PaperWidth") = 210
                .Item("SeparatorSpalteAnzahl") = 1
                .Item("SeparatorSpalteWert") = 0
                .Item("SeparatorZeileAnzahl") = 1
                .Item("SeparatorZeileWert") = 0
            End With
            DS.Tables("Shema").Rows.Add(DR)
        End If

        Return DS

    End Function

    Private Function DT_Card() As DataTable

        Dim DT As New DataTable With {.TableName = "Card"}
        With DT
            .Columns.Add(New DataColumn With {.ColumnName = "ID", .AutoIncrement = True, .AutoIncrementSeed = 1, .AutoIncrementStep = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "CardSizeWidth", .DataType = GetType(Integer)})
            .Columns.Add(New DataColumn With {.ColumnName = "CardSizeHeight", .DataType = GetType(Integer)})
            .PrimaryKey = New DataColumn() { .Columns("ID")}
        End With

        Return DT

    End Function

    Public Function NewRow_Card(ByRef DS As DataSet) As DataSet

        If DS.Tables.Contains("Card") = False Then DS.Tables.Add(DT_Card)

        Dim DT As DataTable = DS.Tables("Card")
        If DT.Rows.Count = 0 Then
            Dim DR As DataRow = DT.NewRow
            With DR
                .Item("CardSizeWidth") = 0
                .Item("CardSizeHeight") = 0
            End With
            DS.Tables("Card").Rows.Add(DR)
        End If

        Return DS

    End Function
    Private Function DT_CardRow() As DataTable

        Dim DT As New DataTable With {.TableName = "CardRow"}
        With DT
            .Columns.Add(New DataColumn With {.ColumnName = "ID", .AutoIncrement = True, .AutoIncrementSeed = 1, .AutoIncrementStep = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "QRCode", .DataType = GetType(Boolean)})
            .Columns.Add(New DataColumn With {.ColumnName = "DataColumn", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "LinePos", .DataType = GetType(Integer)})
            .Columns.Add(New DataColumn With {.ColumnName = "Font", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "FontColor", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "AutoFont", .DataType = GetType(Integer)})
            .PrimaryKey = New DataColumn() { .Columns("ID")}
        End With

        Return DT

    End Function

    Public Function NewRow_CardRow(ByRef DS As DataSet) As DataSet

        If DS.Tables.Contains("CardRow") = False Then DS.Tables.Add(DT_CardRow)

        Dim DT As DataTable = DS.Tables("CardRow")
        If DT.Rows.Count = 0 Then
            Dim DR As DataRow = DT.NewRow
            With DR
                .Item("QRCode") = False
                .Item("DataColumn") = String.Empty
                .Item("LinePos") = 0
                .Item("Font") = String.Empty
                .Item("FontColor") = String.Empty
                .Item("AutoFont") = False
            End With
            DS.Tables("CardRow").Rows.Add(DR)
        End If

        Return DS

    End Function
    Private Function DT_Border() As DataTable

        Dim DT As New DataTable With {.TableName = "Border"}
        With DT
            .Columns.Add(New DataColumn With {.ColumnName = "ID", .AutoIncrement = True, .AutoIncrementSeed = 1, .AutoIncrementStep = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "Area", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "Border", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "Value", .DataType = GetType(Double)})
            .PrimaryKey = New DataColumn() { .Columns("ID"), .Columns("Area"), .Columns("Border")}
        End With
        Return DT

    End Function
    ''' <summary>
    ''' Fügt eine neue Zeile mit Standardwerten in die "Shema"-Tabelle ein, wenn diese leer ist.
    ''' </summary>
    Public Function NewRow_Border(ID As String, Area As String, ByRef DS As DataSet) As DataSet

        If IsNothing(DS.Tables("Border")) = True Then
            DS.Tables.Add(DT_Border)
        End If

        Dim DT As DataTable = DS.Tables("Border")
        Dim DR() As DataRow = DT.Select($"ID={ID} AND Area Like '{Area}'")

        If DR.Count = 0 Then
            'ID, Area, Border, Value
            DT.Rows.Add(ID, Area, "Bottom", 0)
            DT.Rows.Add(ID, Area, "Left", 0)
            DT.Rows.Add(ID, Area, "Right", 0)
            DT.Rows.Add(ID, Area, "Top", 0)
        End If

        Return DS

    End Function
    Private Function DT_Search() As DataTable

        Dim DT As New DataTable With {.TableName = "Search"}
        With DT
            .Columns.Add(New DataColumn With {.ColumnName = "ID", .AutoIncrement = True, .AutoIncrementSeed = 1, .AutoIncrementStep = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "Search_Column", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "Search_Operator", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "Search_Value", .DataType = GetType(String)})
            .PrimaryKey = New DataColumn() { .Columns("ID")}
        End With

        Return DT

    End Function

    Public Sub Search_Columns_NEW(ByRef DS As DataSet, DT As DataTable)

        DS.Tables("Search_Columns").Rows.Clear()
        For Each Col As DataColumn In DT.Columns
            With DS.Tables("Search_Columns")
                If .Rows.Find(Col.ColumnName) Is Nothing Then
                    .Rows.Add(Col.ColumnName)
                End If
            End With
        Next

    End Sub

    Private Function DT_Search_Columns() As DataTable

        Dim DT As New DataTable With {.TableName = "Search_Columns"}
        With DT
            .Columns.Add(New DataColumn With {.ColumnName = "Column", .DataType = GetType(String), .Unique = True, .AllowDBNull = False})
            .PrimaryKey = New DataColumn() { .Columns("Column")}
        End With

        Return DT

    End Function
    Private Function DT_Search_Operator() As DataTable

        Dim DT As New DataTable With {.TableName = "Search_Operator"}
        With DT
            .Columns.Add(New DataColumn With {.ColumnName = "Operator", .DataType = GetType(String), .Unique = True, .AllowDBNull = False})
            .Columns.Add(New DataColumn With {.ColumnName = "Operator_Left", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "Operator_Right", .DataType = GetType(String)})
            .PrimaryKey = New DataColumn() { .Columns("Operator")}
        End With
        Return DT

    End Function
    Public Function NewRow_Search_Operator(ByRef DS As DataSet) As DataSet

        If DS.Tables.Contains("Search_Operator") = False Then DS.Tables.Add(DT_Search_Operator)

        Dim DT As DataTable = DS.Tables("Search_Operator")
        With DT
            If .Rows.Count = 0 Then
                .Rows.Add("Enthält", "LIKE '*", "*'")
                .Rows.Add("Gleich", "= '", "'")
                .Rows.Add("Ungleich", "<> '*", "*'")
                .Rows.Add("Beginnt mit", "LIKE '", "*'")
                .Rows.Add("Endet mit", "LIKE '*", "'")
            End If
        End With

        Return DS

    End Function
    Private Function DT_PaperDIN() As DataTable

        Dim DT As New DataTable With {.TableName = "PaperDIN"}
        With DT
            .Columns.Add("DIN", GetType(String))
            .Columns.Add("PaperWidth", GetType(Double))
            .Columns.Add("PaperHeight", GetType(Double))
            .PrimaryKey = New DataColumn() { .Columns("DIN")}
        End With

        Return DT

    End Function

    Public Function PaperDIN() As DataTable

        Dim DT As DataTable = DT_PaperDIN()
        If DT.Rows.Count = 0 Then
            With DT
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
        End If

        Return DT

    End Function

End Class