Imports System.Resources.ResXFileRef
Imports System.Security.Cryptography
Imports System.Xml
Imports CSVtoQR.Class_DS

Public Class Class_DS

    Private ReadOnly CL_F As New Class_FontConverter

    'Public DT_Border As DataTable

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
            If .Contains("Border") = False Then .Add(DT_Border)
            If .Contains("Font") = False Then .Add(DT_Font)
            If .Contains("File") = False Then .Add(DT_File)

        End With

        Return DS

    End Function

    Private Function DT_Paper(ByRef DS As DataSet) As DataTable

        Dim DT As New DataTable With {.TableName = "Paper"}

        With DT

            .Columns.Add(New DataColumn With {.ColumnName = "ID", .DataType = GetType(Integer), .DefaultValue = 0})
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

            .PrimaryKey = New DataColumn() { .Columns("ID")}

        End With

        DT.Rows.Add(DT.NewRow)

        Return DT

    End Function

    Public Function DT_Card(ByRef DS As DataSet) As DataTable

        Dim DT As New DataTable With {.TableName = "Card"}

        With DT

            .Columns.Add(New DataColumn With {.ColumnName = "ID", .DataType = GetType(Integer), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "Left", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Top", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Right", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Bottom", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Font", .DataType = GetType(String), .DefaultValue = (New Class_FontConverter).FontToString(My.Settings.Main_Font)})
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

            .Columns.Add(New DataColumn With {.ColumnName = "ID", .AutoIncrement = True, .AutoIncrementSeed = 1, .AutoIncrementStep = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "LinePos", .DataType = GetType(Double), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "DataColumn", .DataType = GetType(String), .DefaultValue = "-------"})
            .Columns.Add(New DataColumn With {.ColumnName = "QRCode", .DataType = GetType(Boolean), .DefaultValue = False})
            .Columns.Add(New DataColumn With {.ColumnName = "FontColor", .DataType = GetType(String), .DefaultValue = Color.Black.ToArgb.ToString})
            .Columns.Add(New DataColumn With {.ColumnName = "AutoFont", .DataType = GetType(Boolean), .DefaultValue = False})
            .Columns.Add(New DataColumn With {.ColumnName = "Left", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Top", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Right", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Bottom", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Font", .DataType = GetType(String), .DefaultValue = (New Class_FontConverter).FontToString(My.Settings.Main_Font)})

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
        DR("Font") = CL_F.FontToString(My.Settings.Main_Font)

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

#Region "Border"

    ''' <summary>
    ''' Erstellt eine DataTable für die Border-Informationen. 
    ''' Diese Tabelle enthält die Spalten "ID", "RowID", "Relation", "Left", "Top", "Right" und "Bottom". 
    ''' Die Spalte "ID" wird als Primärschlüssel festgelegt, um eindeutige Einträge zu gewährleisten.
    ''' </summary>

    Private Function DT_Border() As DataTable

        Dim DT As New DataTable With {.TableName = "Border"}
        With DT
            .TableName = "Border"
            .Columns.Add(New DataColumn With {.ColumnName = "ID", .AutoIncrement = True, .AutoIncrementSeed = 1, .AutoIncrementStep = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "RowID", .DataType = GetType(Integer), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "Relation", .DataType = GetType(String), .DefaultValue = "Paper"})
            .Columns.Add(New DataColumn With {.ColumnName = "Left", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Top", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Right", .DataType = GetType(Double), .DefaultValue = 0.0})
            .Columns.Add(New DataColumn With {.ColumnName = "Bottom", .DataType = GetType(Double), .DefaultValue = 0.0})
            .PrimaryKey = New DataColumn() { .Columns("ID")}
        End With

        DT_Border = DT

    End Function

    ''' <summary>
    ''' Fügt Standard-Border-Einträge für die Relationen "Paper", "Card" und "CardRow" in die angegebene DataTable ein. 
    ''' Die Border-Werte (Left, Top, Right, Bottom) werden auf 0.0 gesetzt.
    ''' </summary>
    ''' <param name="_DT"></param>
    Public Sub DT_Border(ByRef _DT As DataTable)

        Dim LoRelation As New List(Of String) From {"Paper", "Card", "CardRow"}
        For Each Relation As String In LoRelation
            DT_Border(_DT, 0, Relation, 0.0, 0.0, 0.0, 0.0)
        Next

    End Sub

    ''' <summary>
    ''' Fügt einen Border-Eintrag für die angegebene Relation und RowID in die angegebene DataTable ein oder aktualisiert ihn, falls bereits vorhanden. 
    ''' Die Border-Werte (Left, Top, Right, Bottom) werden entsprechend den übergebenen Parametern gesetzt.     
    ''' </summary>
    ''' <param name="_DT"></param>
    ''' <param name="RowID"></param>
    ''' <param name="Relation"></param>
    ''' <param name="Left"></param>
    ''' <param name="Top"></param>
    ''' <param name="Right"></param>
    ''' <param name="Bottom"></param>
    Public Sub DT_Border(ByRef _DT As DataTable, RowID As Integer, Relation As String, Left As Double, Top As Double, Right As Double, Bottom As Double)

        Dim DR() As DataRow = _DT.Select($"Relation = '{Relation}' AND RowID = {RowID}")

        If DR.Count = 0 Then
            Dim _DR As DataRow = _DT.NewRow()
            _DR("RowID") = RowID
            _DR("Relation") = Relation
            _DR("Left") = Left
            _DR("Top") = Top
            _DR("Right") = Right
            _DR("Bottom") = Bottom
            _DT.Rows.Add(_DR)
        Else
            DR(0)("Left") = Left
            DR(0)("Top") = Top
            DR(0)("Right") = Right
            DR(0)("Bottom") = Bottom
        End If

    End Sub

#End Region


#Region "Font"

    ''' <summary>
    ''' Erstellt eine DataTable für die Font-Informationen. 
    ''' Diese Tabelle enthält die Spalten "ID", "RowID", "Relation", "Left", "Top", "Right" und "Bottom". 
    ''' Die Spalte "ID" wird als Primärschlüssel festgelegt, um eindeutige Einträge zu gewährleisten.
    ''' </summary>

    Private Function DT_Font() As DataTable

        Dim DT As New DataTable With {.TableName = "Font"}
        With DT
            .TableName = "Font"
            .Columns.Add(New DataColumn With {.ColumnName = "ID", .AutoIncrement = True, .AutoIncrementSeed = 1, .AutoIncrementStep = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "RowID", .DataType = GetType(Integer), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "Relation", .DataType = GetType(String), .DefaultValue = "General"})
            .Columns.Add(New DataColumn With {.ColumnName = "Font", .DataType = GetType(String), .DefaultValue = (New Class_FontConverter).FontToString(My.Settings.Main_Font)})
            .PrimaryKey = New DataColumn() { .Columns("ID")}
        End With

        DT_Font = DT

    End Function

    ''' <summary>
    ''' Fügt Standard-Font-Einträge für die Relationen "Paper", "Card" und "CardRow" in die angegebene DataTable ein. 
    ''' Die Font-Werte (Left, Top, Right, Bottom) werden auf 0.0 gesetzt.
    ''' </summary>
    ''' <param name="_DT"></param>
    Public Sub DT_Font(ByRef _DT As DataTable)
        Dim LoRelation As New List(Of String) From {"General", "Card", "CardRow"}
        For Each Relation As String In LoRelation
            DT_Font(_DT, 0, Relation, My.Settings.Main_Font)
        Next

    End Sub

    ''' <summary>
    ''' Fügt einen Border-Eintrag für die angegebene Relation und RowID in die angegebene DataTable ein oder aktualisiert ihn, falls bereits vorhanden. 
    ''' Die Border-Werte (Left, Top, Right, Bottom) werden entsprechend den übergebenen Parametern gesetzt.     
    ''' </summary>
    ''' <param name="_DT"></param>
    ''' <param name="RowID"></param>
    ''' <param name="Relation"></param>
    ''' <param name="_Font"></param>
    Public Sub DT_Font(ByRef _DT As DataTable, RowID As Integer, Relation As String, _Font As Font)

        Dim DR() As DataRow = _DT.Select($"Relation = '{Relation}' AND RowID = {RowID}")

        If DR.Count = 0 Then
            Dim _DR As DataRow = _DT.NewRow()
            _DR("RowID") = RowID
            _DR("Relation") = Relation
            _DR("Font") = (New Class_FontConverter).FontToString(_Font)
            _DT.Rows.Add(_DR)
        Else
            DR(0)("Font") = (New Class_FontConverter).FontToString(_Font)
        End If

    End Sub

#End Region

#Region "Files"


    Private Function DT_File() As DataTable

        Dim DT As New DataTable With {.TableName = "File"}
        With DT
            .TableName = "File"
            .Columns.Add(New DataColumn With {.ColumnName = "ID", .AutoIncrement = True, .AutoIncrementSeed = 1, .AutoIncrementStep = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "RowID", .DataType = GetType(Integer), .DefaultValue = 0})
            .Columns.Add(New DataColumn With {.ColumnName = "Relation", .DataType = GetType(String), .DefaultValue = "XML"})
            .Columns.Add(New DataColumn With {.ColumnName = "File", .DataType = GetType(String), .DefaultValue = ""})
            .PrimaryKey = New DataColumn() { .Columns("ID")}
        End With

        DT_File = DT

    End Function

    Public Sub DT_File(ByRef _DT As DataTable)

        Dim LoRelation As New List(Of String) From {"XML", "CSV", "PDF"}
        For Each Relation As String In LoRelation
            DT_File(_DT, 0, Relation, "")
        Next

    End Sub

    Public Sub DT_File(ByRef _DT As DataTable, RowID As Integer, Relation As String, _File As String)

        Dim DR() As DataRow = _DT.Select($"Relation = '{Relation}' AND RowID = {RowID}")

        If DR.Count = 0 Then
            Dim _DR As DataRow = _DT.NewRow()
            _DR("RowID") = RowID
            _DR("Relation") = Relation
            _DR("File") = _File
            _DT.Rows.Add(_DR)
        Else
            DR(0)("File") = _File
        End If

    End Sub

#End Region

End Class