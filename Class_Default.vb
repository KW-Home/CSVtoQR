Public Class Class_Default

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

    Public Sub Controlls_Read()

        FRM.SuspendLayout()

        For Each Con As Control In FRM.Controls

            Con.Visible = False
            Con.Enabled = False

            Con.SuspendLayout()

            Application.DoEvents()

            Con.Font = My.Settings.Main_Font
            Controlls_Read_Sub(Con)
            Con.ResumeLayout()

        Next

        For Each Con As Control In FRM.Controls
            Con.Visible = True
            Con.Enabled = True
            Con.ResumeLayout()
        Next

        FRM.ResumeLayout()

    End Sub

    Private Sub Controlls_Read_Sub(_Con As Control)

        For Each Con As Control In _Con.Controls
            Con.Font = My.Settings.Main_Font
            If Con.Controls.Count > 0 Then
                Controlls_Read_Sub(Con)
            End If
        Next

    End Sub

End Class