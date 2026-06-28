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
                    Case "TextBox" : Default_TextBox(OBJ)
                    Case "NumericUpDown" : Default_NumericUpDown(OBJ)
                    Case "Label" : Default_Label(OBJ)
                    Case "ComboBox" : Default_ComboBox(OBJ)
                    Case "DataGridView" : Default_DataGridView(OBJ)
                End Select
            End With
        Next

    End Sub
    Private Sub Default_Fill()
        With ControlsListGesamt

#Region "TabPage_General"
            .Add(FRM.TabPage_General)
            .Add(FRM.GroupBox_General_XML)
            .Add(FRM.TableLayoutPanel_General_XML)
            .Add(FRM.Label_General_XML_Directory)
            .Add(FRM.TextBox_General_XML_Directory)
            .Add(FRM.Label_General_XML_Filname)
            .Add(FRM.TextBox_General_XML_Filename)
            .Add(FRM.GroupBox_General_Import)
            .Add(FRM.TableLayoutPanel_General_Import)
            .Add(FRM.Label_General_Import_Directory)
            .Add(FRM.TextBox_General_Import_Directory)
            .Add(FRM.Label_General_Import_Filname)
            .Add(FRM.TextBox_General_Import_Filename)
            .Add(FRM.GroupBox_General_Export)
            .Add(FRM.TableLayoutPanel_General_Export)
            .Add(FRM.Label_General_Export_Directory)
            .Add(FRM.TextBox_General_Export_Directory)
            .Add(FRM.Label_General_Export_Filname)
            .Add(FRM.TextBox_General_Export_Filename)
            .Add(FRM.Button_General_XML_Open)
            .Add(FRM.Button_General_Export)
            .Add(FRM.Button_General_Import)
#End Region
#Region "TabPage_Paper"
            .Add(FRM.TabPage_Paper)
            .Add(FRM.GroupBox_Paper_Shema)
            .Add(FRM.Label_Paper_Shema)
            .Add(FRM.TextBox_Paper_Shema)
            .Add(FRM.Label_Paper_DPI)
            .Add(FRM.Label_Paper_DIN)
            .Add(FRM.Label_Paper_Height)
            .Add(FRM.Label_Paper_Height_Unit)
            .Add(FRM.Label_Paper_Width)
            .Add(FRM.Label_Paper_Width_Unit)
            .Add(FRM.Label_Paper_Height_Value)
            .Add(FRM.Label_Paper_Width_Value)
            .Add(FRM.ComboBox_Paper_DIN)
            .Add(FRM.ComboBox_Paper_DPI)
            .Add(FRM.TableLayoutPanel_Paper_Shema)
            .Add(FRM.TableLayoutPanel_Paper)
            .Add(FRM.GroupBox_Separatoren)
            .Add(FRM.NumericUpDown_Separator_Row_Value)
            .Add(FRM.NumericUpDown_Separator_Row_Count)
            .Add(FRM.Label_Separator_Row)
            .Add(FRM.Label_Separator_Row_Unit)
            .Add(FRM.TableLayoutPanel_Separatoren)
            .Add(FRM.NumericUpDown_Separator_Column_Value)
            .Add(FRM.NumericUpDown_Separator_Column_Count)
            .Add(FRM.Label_Separator_Column_Count)
            .Add(FRM.Label_Separator_Column_Value)
            .Add(FRM.Label_Separator_Column_Unit)
#End Region
#Region "TabPage_Card"
            .Add(FRM.TabPage_Card)
            '.Add(FRM.TableLayoutPanel_Card_Size)
            '.Add(FRM.TableLayoutPanel_Card)
            .Add(FRM.Label_Card_Size_Hight)
            .Add(FRM.Label_Card_Size_Hight_Value)
            .Add(FRM.Label_Card_Size_Width)
            .Add(FRM.Label_Card_Size_Width_Value)
            '.Add(FRM.GroupBox_Card_Size)
            .Add(FRM.Label_Card_Size_Hight_Unit)
            .Add(FRM.Label_Card_Size_Width_Unit)
#End Region
#Region "CardRow"
            '.Add(FRM.TabPage_CardRow_List)
            '.Add(FRM.ListBox_CardRow)
            '.Add(FRM.Label_CardRow_LinePos)
            '.Add(FRM.Label_CardRow_LinePos_Value)
            '.Add(FRM.Label_CardRow_QRCode)
            '.Add(FRM.Label_CardRow_AutoFont)
            '.Add(FRM.Label_CardRow_DataColumn)
            '.Add(FRM.GroupBox_CardRow_Line)
            '.Add(FRM.GroupBox_CardRow_List)
            '.Add(FRM.CheckBox_CardRow_QRCode)
            '.Add(FRM.ComboBox_CardRow_DataColumn)
            '.Add(FRM.CheckBox_CardRow_AutoFont)
            '.Add(FRM.TableLayoutPanel_CardRow)
            '.Add(FRM.TableLayoutPanel_CardRow_Line)

#End Region
#Region "TabPage_Data"
            .Add(FRM.GroupBox_Data)
            .Add(FRM.TabPage_Data)
            .Add(FRM.TableLayoutPanel_Data)
            .Add(FRM.BindingNavigator_CSV)
            .Add(FRM.Button_Search_Refresh)
            .Add(FRM.Button_Search_Add)
            .Add(FRM.Button_Search_Delete)
            .Add(FRM.DGV_CSV)
            .Add(FRM.DGV_Search)
#End Region
#Region "TabPage_Table"
            .Add(FRM.TabPage_Table)
            .Add(FRM.DGV_Table)
            .Add(FRM.GroupBox_Table)
            .Add(FRM.TableLayoutPanel_Table)
#End Region

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
    Private Sub Default_Label(ByRef OBJ As Label)
        With OBJ

            .Dock = DockStyle.Fill
            .UseCompatibleTextRendering = True

            Select Case .Name
                Case FRM.Label_Paper_Height_Value.Name, FRM.Label_Paper_Width_Value.Name, FRM.Label_Card_Size_Hight_Value.Name, FRM.Label_Card_Size_Width_Value.Name
                    .TextAlign = ContentAlignment.MiddleRight
                Case Else
                    .TextAlign = ContentAlignment.MiddleLeft
            End Select

        End With
    End Sub
    Private Sub Default_ComboBox(ByRef OBJ As ComboBox)
        With OBJ
            .Margin = New Padding(3)
            .Padding = New Padding(0)

            Select Case .Name
                Case FRM.ComboBox_CardRow_DataColumn.Name
                    '.Dock = DockStyle.Fill
                Case Else
                    .Dock = DockStyle.Left
            End Select

            Select Case .Name
                Case FRM.ComboBox_Paper_DPI.Name
                    .Items.AddRange(New Object() {72, 96, 150, 300, 600})
                Case FRM.ComboBox_Paper_DIN.Name
                    .DataSource = New Class_DS().PaperDIN
                    .DisplayMember = "DIN"
                    .ValueMember = "DIN"
                    If DS.Tables("Shema").Rows.Count > 0 Then
                        .SelectedValue = DS.Tables("Shema").Rows(0).Item("DIN").ToString
                    End If
            End Select
        End With
    End Sub
    Private Sub Default_DataGridView(ByRef OBJ As DataGridView)
        With OBJ
            .BackgroundColor = Color.WhiteSmoke
            .AutoResizeColumnHeadersHeight()
            .DefaultCellStyle.Font = MyFont
            .MultiSelect = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = True
            .AllowUserToResizeColumns = True
            .AllowUserToResizeRows = True
            .Margin = New Padding(6)
            .Padding = New Padding(6)
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