Public Class Class_Form_Card

    Public Function DT_Card() As DataTable

        Dim DT As New DataTable With {.TableName = "Card"}
        With DT

            .Columns.Add(New DataColumn With {.ColumnName = "ID", .AutoIncrement = True, .AutoIncrementSeed = 1, .AutoIncrementStep = 1})
            .Columns.Add(New DataColumn With {.ColumnName = "Left", .DataType = GetType(Double)})
            .Columns.Add(New DataColumn With {.ColumnName = "Top", .DataType = GetType(Double)})
            .Columns.Add(New DataColumn With {.ColumnName = "Right", .DataType = GetType(Double)})
            .Columns.Add(New DataColumn With {.ColumnName = "Bottom", .DataType = GetType(Double)})
            .Columns.Add(New DataColumn With {.ColumnName = "Font", .DataType = GetType(String)})
            .Columns.Add(New DataColumn With {.ColumnName = "CardSizeWidth", .DataType = GetType(Integer)})
            .Columns.Add(New DataColumn With {.ColumnName = "CardSizeHeight", .DataType = GetType(Integer)})

            .PrimaryKey = New DataColumn() { .Columns("ID")}

        End With

        Return DT

    End Function

    Public Sub GET_Card(ByRef DS As DataSet)

        If DS.Tables.Contains("Card") = False Then
            DS.Tables.Add(DT_Card)
        End If

        Dim DT As DataTable = DS.Tables("Card")
        If DT.Rows.Count = 0 Then
            Dim DR As DataRow = DT.NewRow
            DR("Left") = 0.0
            DR("Top") = 0.0
            DR("Right") = 0.0
            DR("Bottom") = 0.0
            Dim CL_F As New Class_FontConverter
            DR("Font") = CL_F.FontToString(Nothing)
            DR("CardSizeWidth") = 0
            DR("CardSizeHeight") = 0
            DS.Tables("Card").Rows.Add(DR)
        End If

    End Sub

End Class
