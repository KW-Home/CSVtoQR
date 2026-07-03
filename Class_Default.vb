Public Class Class_Default

    Private ReadOnly MyFont As Font = My.Settings.MyFont
    Private ReadOnly FRM As Form1
    Private ReadOnly DS As DataSet
    Private ReadOnly ControlsListGesamt As New List(Of Control)

    Public Sub New(ByRef _FRM As Form1, ByRef _DS As DataSet)

        FRM = _FRM
        DS = _DS

        Default_Fill()
        SetDefault()

    End Sub
    Private Sub SetDefault()

        Dim OBJ As Object
        For Each CON As Control In ControlsListGesamt
            OBJ = CON
            With OBJ
                .Font = MyFont
                .AutoSize = True
                .Margin = New Padding(0)
                Select Case .GetType.Name
                    Case "ComboBox" : Default_ComboBox(OBJ)
                End Select
            End With
        Next

    End Sub
    Private Sub Default_Fill()

        With ControlsListGesamt

            .Add(FRM.ComboBox_Paper_DIN)
            .Add(FRM.ComboBox_Paper_DPI)

            .Add(FRM.NumericUpDown_Separator_Row_Value)
            .Add(FRM.NumericUpDown_Separator_Row_Count)
            .Add(FRM.NumericUpDown_Separator_Column_Value)
            .Add(FRM.NumericUpDown_Separator_Column_Count)

        End With

    End Sub

    Private Sub Default_ComboBox(ByRef OBJ As ComboBox)

        Select Case OBJ.Name
            Case FRM.ComboBox_Paper_DPI.Name
                OBJ.Items.AddRange(New Object() {72, 96, 150, 300, 600})
            Case FRM.ComboBox_Paper_DIN.Name
                OBJ.DataSource = New Class_DS().PaperDIN
                OBJ.DisplayMember = "DIN"
                OBJ.ValueMember = "DIN"
                If DS.Tables("Shema").Rows.Count > 0 Then
                    OBJ.SelectedValue = DS.Tables("Shema").Rows(0).Item("DIN").ToString
                End If
        End Select

    End Sub

End Class