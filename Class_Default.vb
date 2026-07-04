Public Class Class_Default

    Private ReadOnly FontMain As Font = My.Settings.Font_Main
    Private ReadOnly FRM As Form1
    'Private ReadOnly DS As DataSet

    Public Sub New(ByRef _FRM As Form1)

        FRM = _FRM

        Default_ComboBox(FRM.ComboBox_Paper_DIN)
        Default_ComboBox(FRM.ComboBox_Paper_DPI)

    End Sub

    Private Sub Default_ComboBox(ByRef OBJ As ComboBox)

        With OBJ
            Select Case .Name
                Case FRM.ComboBox_Paper_DPI.Name
                    OBJ.Items.AddRange(New Object() {72, 96, 150, 300, 600})
                Case FRM.ComboBox_Paper_DIN.Name
                    .DataSource = New Class_DS().PaperDIN
                    .DisplayMember = "DIN"
                    .ValueMember = "DIN"
                    If FRM.DS.Tables("Paper").Rows.Count > 0 Then
                        .SelectedValue = FRM.DS.Tables("Paper").Rows(0).Item("DIN").ToString
                    End If
            End Select
        End With

    End Sub

End Class