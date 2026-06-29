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
                    Case "TabPage" : Default_TabPage(OBJ)
                    Case "TextBox" : Default_TextBox(OBJ)
                    Case "NumericUpDown" : Default_NumericUpDown(OBJ)
                    Case "ComboBox" : Default_ComboBox(OBJ)
                    Case "DataGridView" : Default_DataGridView(OBJ)
                End Select
            End With
        Next

    End Sub
    Private Sub Default_Fill()

        With ControlsListGesamt

            .Add(FRM.TabPage_General)
            .Add(FRM.TabPage_Paper)
            .Add(FRM.TabPage_Card)
            .Add(FRM.TabPage_CardRow)
            .Add(FRM.TabPage_DataSet)

            .Add(FRM.TextBox_XML_Directory)
            .Add(FRM.TextBox_XML_Filename)
            .Add(FRM.TextBox_Import_Directory)
            .Add(FRM.TextBox_Import_Filename)
            .Add(FRM.TextBox_General_Export_Directory)
            .Add(FRM.TextBox_General_Export_Filename)
            .Add(FRM.TextBox_Paper_Shema)

            .Add(FRM.Button_XML)
            .Add(FRM.Button_Export)
            .Add(FRM.Button_Import)
            .Add(FRM.Button_Search_Refresh)
            .Add(FRM.Button_Search_Add)
            .Add(FRM.Button_Search_Delete)

            .Add(FRM.ComboBox_Paper_DIN)
            .Add(FRM.ComboBox_Paper_DPI)

            .Add(FRM.NumericUpDown_Separator_Row_Value)
            .Add(FRM.NumericUpDown_Separator_Row_Count)
            .Add(FRM.NumericUpDown_Separator_Column_Value)
            .Add(FRM.NumericUpDown_Separator_Column_Count)

            .Add(FRM.DGV_CSV)
            .Add(FRM.DGV_Search)
            .Add(FRM.DGV_Table)

        End With

    End Sub

    Private Sub Default_TabPage(ByRef OBJ As TabPage)

        With OBJ
            .UseVisualStyleBackColor = True
        End With

    End Sub

    Public Sub Default_ListBox(ByRef OBJ As ListBox)

        With OBJ

            .AutoSize = False
            .IntegralHeight = True

            Dim C As Integer = .Items.Count
            If C < 3 Then C = 3
            If C > 9 Then C = 9
            .Height = CType(MyFont.Height * (C + 1), Integer)

        End With

    End Sub
    Private Sub Default_TextBox(ByRef OBJ As TextBox)
        With OBJ
            .Dock = DockStyle.Top
            .TextAlign = HorizontalAlignment.Left
            .BorderStyle = BorderStyle.FixedSingle
            .Margin = New Padding(3)
            .Padding = New Padding(3)
        End With
    End Sub
    Private Sub Default_NumericUpDown(ByRef OBJ As NumericUpDown)
        With OBJ
            .BorderStyle = BorderStyle.FixedSingle
            .Margin = New Padding(3)
            .Padding = New Padding(3)
            .TextAlign = HorizontalAlignment.Right
            .Dock = DockStyle.Top

            Select Case .Name
                Case FRM.NumericUpDown_Separator_Column_Count.Name, FRM.NumericUpDown_Separator_Row_Count.Name
                    .Minimum = 1
                    .Increment = 1
                    .DecimalPlaces = 0
                    .Maximum = 12
                Case Else
                    .Minimum = 0
                    .Increment = 0.1
                    .DecimalPlaces = 1
                    .Maximum = 9999
            End Select

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
    Private Sub Default_DataGridView(ByRef OBJ As DataGridView)

        With OBJ
            .BackgroundColor = Color.WhiteSmoke
            .AutoResizeColumnHeadersHeight()
            .DefaultCellStyle.Font = MyFont
            .MultiSelect = False
            .DefaultCellStyle.BackColor = Color.White
            .ScrollBars = ScrollBars.Both
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .BorderStyle = BorderStyle.Fixed3D
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite
            .AutoSize = False

            Select Case .Name
                Case FRM.DGV_CSV.Name, FRM.DGV_Table.Name
                    .Dock = DockStyle.Fill
                Case Else
                    .Dock = DockStyle.Top
                    .Height = FRM.DGV_Search.ColumnHeadersHeight * 4
            End Select

        End With
    End Sub

End Class