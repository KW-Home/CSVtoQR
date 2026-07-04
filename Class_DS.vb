Imports System.Resources.ResXFileRef
Imports System.Security.Cryptography
Imports System.Xml
Imports CSVtoQR.Class_DS

Public Class Class_DS

    Private ReadOnly CL_F As New Class_FontConverter

    Public Enum Auto_Font
        None
        AutoFontSize
        AutoWordWrap
    End Enum

    Public Function Get_DS(DS As DataSet) As DataSet

        If DS Is Nothing Then DS = New DataSet With {.DataSetName = "DataSetSystem"}

        With DS.Tables

            If .Contains("Paper") = False Then .Add(DT_Paper(DS))
            If .Contains("Card") = False Then .Add(DT_Card(DS))
            If .Contains("CardRow") = False Then .Add(DT_CardRow)
            If .Contains("Search") = False Then .Add(DT_Search)
            If .Contains("Search_Columns") = False Then .Add(DT_Search_Columns)

        End With

        Return DS

    End Function

    Private Function DT_Paper(ByRef DS As DataSet) As DataTable

        Dim DT As New DataTable With {.TableName = "Paper"}

        With DT

            .Columns.Add(New DataColumn With {.ColumnName = "Paper", .Unique = False, .DataType = GetType(String), .DefaultValue = "Default"})
            .Columns.Add(New DataColumn With {.ColumnName = "Import", .DataType = GetType(String), .DefaultValue = ""})
            .Columns.Add(New DataColumn With {.ColumnName = "Export", .DataType = GetType(String), .DefaultValue = ""})
            .Columns.Add(New DataColumn With {.ColumnName = "DPI", .DataType = GetType(Integer), .DefaultValue = 96})
            .Columns.Add(New DataColumn With {.ColumnName = "DIN", .DataType = GetType(String), .DefaultValue = "A4"})
            .Columns.Add(New DataColumn With {.ColumnName = "Left", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Top", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Right", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Bottom", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "SeparatorZeileAnzahl", .DataType = GetType(Integer), .DefaultValue = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "SeparatorZeileWert", .DataType = GetType(Double), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "SeparatorSpalteAnzahl", .DataType = GetType(Integer), .DefaultValue = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "SeparatorSpalteWert", .DataType = GetType(Double), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "PaperHeight", .DataType = GetType(Double), .DefaultValue = 297})
            .Columns.Add(New DataColumn With {.ColumnName = "PaperWidth", .DataType = GetType(Double), .DefaultValue = 210})

            .PrimaryKey = New DataColumn() { .Columns("Paper")}

        End With

        DT.Rows.Add(DT.NewRow)

        Return DT

    End Function

    Public Function DT_Card(ByRef DS As DataSet) As DataTable

        Dim DT As New DataTable With {.TableName = "Card"}

        With DT

            .Columns.Add(New DataColumn With {.ColumnName = "ID", .AutoIncrement = True, .AutoIncrementSeed = 1, .AutoIncrementStep = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "Left", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Top", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Right", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Bottom", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Font", .DataType = GetType(String), .DefaultValue = (New Class_FontConverter).FontToString(My.Settings.Font_Main)})
            .Columns.Add(New DataColumn With {.ColumnName = "CardSizeWidth", .DataType = GetType(Integer), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "CardSizeHeight", .DataType = GetType(Integer), .DefaultValue = 0})

            .PrimaryKey = New DataColumn() { .Columns("ID")}

        End With

        DT.Rows.Add(DT.NewRow)

        Return DT

    End Function

    Private Function DT_CardRow() As DataTable

        Dim DT As New DataTable With {.TableName = "CardRow"}
        With DT

            .Columns.Add(New DataColumn With {.ColumnName = "LinePos", .DataType = GetType(Double), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "ID", .AutoIncrement = True, .AutoIncrementSeed = 1, .AutoIncrementStep = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "DataColumn", .DataType = GetType(String), .DefaultValue = "-------"})
            .Columns.Add(New DataColumn With {.ColumnName = "QRCode", .DataType = GetType(Boolean), .DefaultValue = False})
            .Columns.Add(New DataColumn With {.ColumnName = "FontColor", .DataType = GetType(String), .DefaultValue = Color.Black.ToArgb.ToString})
            .Columns.Add(New DataColumn With {.ColumnName = "AutoFont", .DataType = GetType(Boolean), .DefaultValue = False})
            .Columns.Add(New DataColumn With {.ColumnName = "Left", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Top", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Right", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Bottom", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Font", .DataType = GetType(String), .DefaultValue = (New Class_FontConverter).FontToString(My.Settings.Font_Main)})

            .PrimaryKey = New DataColumn() { .Columns("ID")}

            'Die Zeilen werden standardmäßig nach der Position auf der Karte sortiert, damit sie in der richtigen Reihenfolge angezeigt werden.
            .DefaultView.Sort = "LinePos ASC, ID ASC"

        End With

        DT.Rows.Add(DT.NewRow)

        Return DT

    End Function

    Public Function GET_CardRow(ByRef DS As DataSet, ID As Integer) As DataRow

        Dim DT As DataTable = DS.Tables("CardRow")
        Dim DR As DataRow = DT.Rows.Find(ID)

        If IsNothing(DR) = False Then Return DR

        DR = DS.Tables("CardRow").NewRow
        DR("DataColumn") = Form1.ComboBox_CardRow_DataColumn.Text
        DR("LinePos") = 0.0
        DR("QRCode") = False
        DR("AutoFont") = False
        DR("Left") = 0.0
        DR("Top") = 0.0
        DR("Right") = 0.0
        DR("Bottom") = 0.0
        DR("FontColor") = Color.Black.ToArgb.ToString
        DR("Font") = CL_F.FontToString(My.Settings.Font_Main)

        DT.Rows.Add(DR)

        Return DR

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
            .Columns.Add(New DataColumn With {.ColumnName = "MaxSize", .DataType = GetType(Integer)})
            .PrimaryKey = New DataColumn() { .Columns("Column")}
        End With

        Return DT

    End Function
    Public Function DT_Search_Operator() As DataTable

        Dim DT As New DataTable With {.TableName = "Search_Operator"}
        With DT
            .Columns.Add(New DataColumn With {.ColumnName = "Operator", .DataType = GetType(String), .Unique = True, .AllowDBNull = False})
            .Columns.Add(New DataColumn With {.ColumnName = "Operator_Left", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "Operator_Right", .DataType = GetType(String)})
            .PrimaryKey = New DataColumn() { .Columns("Operator")}

            If .Rows.Count = 0 Then
                .Rows.Add("Enthält", "LIKE '*", "*'")
                .Rows.Add("Gleich", "= '", "'")
                .Rows.Add("Ungleich", "<> '*", "*'")
                .Rows.Add("Beginnt mit", "LIKE '", "*'")
                .Rows.Add("Endet mit", "LIKE '*", "'")
            End If
        End With

        Return DT
        'Return DS

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