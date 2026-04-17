Public Class Class_Default

    Private ReadOnly MyFont As Font = My.Settings.MyFont
    Private ReadOnly FRM As Form1
    Private ReadOnly DS As DataSet
    Private ReadOnly ControlsListGesamt As New List(Of Control)

    Public Sub New(ByRef _FRM As Form1, ByRef _DS As DataSet)

        FRM = _FRM
        DS = _DS

        With ControlsListGesamt
            .Add(FRM.SplitContainer_Main)

            .Add(FRM.TextBox_Shema)
            .Add(FRM.TextBox_Import)
            .Add(FRM.TextBox_Export)

            .Add(FRM.NumericUpDown_Paper_Border_Left)
            .Add(FRM.NumericUpDown_Paper_Border_Top)
            .Add(FRM.NumericUpDown_Paper_Border_Right)
            .Add(FRM.NumericUpDown_Paper_Border_Bottom)
            .Add(FRM.NumericUpDown_Card_Border_Left)
            .Add(FRM.NumericUpDown_Card_Border_Top)
            .Add(FRM.NumericUpDown_Card_Border_Right)
            .Add(FRM.NumericUpDown_Card_Border_Bottom)
            .Add(FRM.NumericUpDown_CardRow_Border_Bottom)
            .Add(FRM.NumericUpDown_CardRow_Border_Left)
            .Add(FRM.NumericUpDown_CardRow_Border_Right)
            .Add(FRM.NumericUpDown_CardRow_Border_Top)
            .Add(FRM.NumericUpDown_Separator_Column_Value)
            .Add(FRM.NumericUpDown_Separator_Column_Count)
            .Add(FRM.NumericUpDown_Separator_Row_Value)
            .Add(FRM.NumericUpDown_Separator_Row_Count)

            .Add(FRM.Label_Separator_Row_Count)
            .Add(FRM.Label_Separator_Row_Value)

            .Add(FRM.Label_Shema)
            .Add(FRM.Label_Import)
            .Add(FRM.Label_Export)
            .Add(FRM.Label_Paper_DPI)
            .Add(FRM.Label_Paper_DIN)
            .Add(FRM.Label_Paper_Height)
            .Add(FRM.Label_Paper_Height_Unit)
            .Add(FRM.Label_Paper_Width)
            .Add(FRM.Label_Paper_Width_Unit)
            .Add(FRM.Label_Separator_Row_Count)
            .Add(FRM.Label_Paper_Height_Value)
            .Add(FRM.Label_Paper_Width_Value)
            .Add(FRM.Label_Separator_Row_Value)
            .Add(FRM.Label_Separator_Row_Value_Unit)
            .Add(FRM.Label_Separator_Column_Count)
            .Add(FRM.Label_Separator_Column_Value)
            .Add(FRM.Label_Paper_Border_Left)
            .Add(FRM.Label_Paper_Border_Top)
            .Add(FRM.Label_Paper_Border_Right)
            .Add(FRM.Label_Paper_Border_Bottom)
            .Add(FRM.Label_Paper_Border_Right_Unit)
            .Add(FRM.Label_Paper_Border_Top_Unit)
            .Add(FRM.Label_Paper_Border_Bottom_Unit)
            .Add(FRM.Label_Paper_Border_Left_Unit)

            .Add(FRM.Label_Separator_Column_Value_Unit)
            .Add(FRM.Label_Separator_Row_Value_Unit)

            .Add(FRM.Label_Card_Font)
            .Add(FRM.Label_Card_Font_Value)
            .Add(FRM.Label_Card_FontColor)
            .Add(FRM.Label_Card_FontColor_Value)
            .Add(FRM.Label_Card_Size_Hight)
            .Add(FRM.Label_Card_Size_Hight_Value)
            .Add(FRM.Label_Card_Size_Width)
            .Add(FRM.Label_Card_Size_Width_Value)

            .Add(FRM.Label_CardRow_Border_Left)
            .Add(FRM.Label_CardRow_Border_Left_Unit)
            .Add(FRM.Label_CardRow_Border_Bottom)
            .Add(FRM.Label_CardRow_Border_Bottom_Unit)
            .Add(FRM.Label_CardRow_Border_Top)
            .Add(FRM.Label_CardRow_Border_Top_Unit)
            .Add(FRM.Label_CardRow_Border_Right)
            .Add(FRM.Label_CardRow_Border_Right_Unit)
            .Add(FRM.Label_CardRow_DataColumn)
            .Add(FRM.Label_CardRow_LinePos)
            .Add(FRM.Label_CardRow_QRCode)
            .Add(FRM.Label_CardRow_AutoFont)

            .Add(FRM.ComboBox_Paper_DIN)
            .Add(FRM.ComboBox_Paper_DPI)
            .Add(FRM.ComboBox_CardRow_DataColumn)

            .Add(FRM.TabPage_Card)
            .Add(FRM.TabPage_Paper)
            .Add(FRM.TabPage_Row)
            .Add(FRM.TabPage_Files)
            .Add(FRM.TabPage_Table)

            .Add(FRM.StatusStrip_Main)
            .Add(FRM.MenuStrip_Main)

            .Add(FRM.TabControl_Main)
            .Add(FRM.BindingNavigator_CSV)
            .Add(FRM.ListBox_Tabellen)
            .Add(FRM.ListBox_CardRow_List)

            .Add(FRM.PictureBox_Preview)

            .Add(FRM.Panel_Preview)

            .Add(FRM.DGV_CSV)
            .Add(FRM.DGV_Search)
            .Add(FRM.DGV_Table)

            .Add(FRM.GroupBox_Shema)
            .Add(FRM.GroupBox_Separator_Row)
            .Add(FRM.GroupBox_Separator_Column)
            .Add(FRM.GroupBox_Paper_Border)

            .Add(FRM.GroupBox_Card_Font)
            .Add(FRM.GroupBox_Card_Border)
            .Add(FRM.GroupBox_Card_Size)

            .Add(FRM.GroupBox_CardRow_Border)
            .Add(FRM.GroupBox_CardRow_Line)
            .Add(FRM.GroupBox_CardRow_List)

            .Add(FRM.CheckBox_CardRow_QRCode)
            .Add(FRM.CheckBox_CardRow_AutoFont)

            .Add(FRM.TableLayoutPanel_Shema)
            .Add(FRM.TableLayoutPanel_Paper)
            .Add(FRM.TableLayoutPanel_Paper_Border)
            .Add(FRM.TableLayoutPanel_Separator)
            .Add(FRM.TableLayoutPanel_Files)
            .Add(FRM.TableLayoutPanel_Card_Font)
            .Add(FRM.TableLayoutPanel_Card_Border)
            .Add(FRM.TableLayoutPanel_CardRow)
            .Add(FRM.TableLayoutPanel_Row_Line)
            .Add(FRM.TableLayoutPanel_Row_Border)

            .Add(FRM.TableLayoutPanel_Card_Size)
            .Add(FRM.TableLayoutPanel_Separator_Column)
            .Add(FRM.TableLayoutPanel_CardRow_List)
            .Add(FRM.TableLayoutPanel_Card)

            .Add(FRM.Button_CardRow_List_Add)
            .Add(FRM.Button_CardRow_List_Delete)
            .Add(FRM.Button_Search_Refresh)
            .Add(FRM.Button_Search_Add)
            .Add(FRM.Button_Search_Delete)

        End With

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
                '.Padding = New Padding(0)

                Select Case .GetType.Name

                    Case "TextBox"

                        .BorderStyle = BorderStyle.FixedSingle
                        .Dock = DockStyle.Top
                        .Margin = New Padding(3)
                        .Padding = New Padding(3)
                        .TextAlign = HorizontalAlignment.Left

                    Case "SplitContainer"

                        .BackColor = Color.AliceBlue
                        .Dock = DockStyle.Fill
                        .Margin = New Padding(3)
                        .Padding = New Padding(3)
                        .SplitterWidth = 12

                    Case "NumericUpDown"

                        .BorderStyle = BorderStyle.FixedSingle
                        .Dock = DockStyle.Top
                        .Margin = New Padding(3)
                        .Padding = New Padding(3)
                        .TextAlign = HorizontalAlignment.Right

                        Select Case OBJ.name

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

                    Case "Label"
                        .Dock = DockStyle.Top
                        Select Case OBJ.name

                            Case FRM.Label_Paper_Height_Unit.Name,
                                 FRM.Label_Paper_Width_Unit.Name,
                                 FRM.Label_Paper_Border_Right_Unit.Name,
                                 FRM.Label_Paper_Border_Top_Unit.Name,
                                 FRM.Label_Paper_Border_Bottom_Unit.Name,
                                 FRM.Label_Paper_Border_Left_Unit.Name,
                                 FRM.Label_Separator_Row_Value_Unit.Name,
                                 FRM.Label_Separator_Column_Value_Unit.Name,
                                 FRM.Label_CardRow_Border_Left_Unit.Name,
                                 FRM.Label_CardRow_Border_Right_Unit.Name,
                                 FRM.Label_CardRow_Border_Top_Unit.Name,
                                 FRM.Label_CardRow_Border_Bottom_Unit.Name

                                .TextAlign = ContentAlignment.MiddleLeft

                            Case FRM.Label_Separator_Row_Count.Name, FRM.Label_Separator_Row_Value.Name

                                .TextAlign = ContentAlignment.BottomCenter

                            Case FRM.Label_Paper_Height_Value.Name, FRM.Label_Paper_Width_Value.Name

                                .Dock = DockStyle.Fill
                                .TextAlign = ContentAlignment.MiddleRight

                            Case Else

                                .Dock = DockStyle.Fill
                                .TextAlign = ContentAlignment.MiddleCenter

                        End Select

                    Case "ComboBox"

                        .Dock = DockStyle.Left
                        .Margin = New Padding(3)
                        .Padding = New Padding(0)

                        Select Case .Name

                            Case FRM.ComboBox_Paper_DPI.Name

                                .Items.AddRange(New Object() {72, 96, 150, 300, 600})

                            Case FRM.ComboBox_Paper_DIN.Name

                                .DataSource = DS.Tables("PaperDIN")
                                .DisplayMember = "DIN"
                                .ValueMember = "DIN"
                                If DS.Tables("Shema").Rows.Count > 0 Then
                                    .SelectedValue = DS.Tables("Shema").Rows(0).Item("DIN").ToString
                                End If

                            Case FRM.ComboBox_CardRow_DataColumn.Name

                                .Dock = DockStyle.Fill

                        End Select

                    Case "TabPage"

                        .BackColor = Color.Transparent
                        Select Case .name

                            Case FRM.TabPage_Files.Name

                                .AutoScroll = False

                            Case Else

                                .AutoScroll = True

                        End Select

'noch nicht benutzt
                    Case "ToolStripStatusLabel"

                        .BackColor = Color.WhiteSmoke

                    Case "MenuStrip"

                        .BackColor = Color.Transparent
                        .RenderMode = ToolStripRenderMode.System

                    Case "StatusStrip"

                        .BackColor = Color.Transparent
                        .Dock = DockStyle.Bottom
                        .Margin = New Padding(0)
                        .Padding = New Padding(0)
                        .RenderMode = ToolStripRenderMode.System

                    Case "TabControl"

                        .BackColor = Color.Transparent
                        .Dock = DockStyle.Fill

                    Case "BindingNavigator"

                        .BackColor = Color.Transparent
                        .Dock = DockStyle.Bottom
                        .RenderMode = ToolStripRenderMode.System

                    Case "ListBox"

                        .BackColor = SystemColors.Control
                        .IntegralHeight = False
                        Select Case CON.Name

                            Case FRM.ListBox_Tabellen.Name

                                .Dock = DockStyle.Left

                            Case FRM.ListBox_CardRow_List.Name

                                .Dock = DockStyle.Fill
                                .AutoSize = False
                                .Height = MyFont.Size * 12

                        End Select

                    Case "PictureBox"

                        .BorderStyle = BorderStyle.FixedSingle
                        .Dock = DockStyle.None
                        .Location = New Point(0, 0)
                        .SizeMode = PictureBoxSizeMode.AutoSize
                        .Margin = New Padding(3)
                        .Padding = New Padding(3)
                        .BackColor = Color.WhiteSmoke

                    Case "Panel"

                        .BackColor = Color.AliceBlue
                        .BorderStyle = BorderStyle.FixedSingle
                        .Dock = DockStyle.Fill
                        .Margin = New Padding(3)
                        .Padding = New Padding(3)

                    Case "DataGridView"

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

                        Select Case CON.Name
                            Case FRM.DGV_CSV.Name, FRM.DGV_Table.Name
                                .Dock = DockStyle.Fill
                            Case Else
                                .Dock = DockStyle.Top
                                .AutoSize = False
                                .height = FRM.DGV_Search.ColumnHeadersHeight * 6
                        End Select

                    Case "GroupBox"

                        .Dock = DockStyle.Top
                        .Margin = New Padding(3, 3, 21, 3)
                        .Padding = New Padding(3)

                    Case "CheckBox"

                        .Dock = DockStyle.Left
                        .Appearance = Appearance.Normal
                        .Text = ""
                        .Margin = New Padding(3)
                        .Padding = New Padding(3)

                    Case "TableLayoutPanel"

                        .Dock = DockStyle.Fill
                        .AutoSizeMode = AutoSizeMode.GrowAndShrink
                        .BorderStyle = BorderStyle.None
                        .CellBorderStyle = TableLayoutPanelCellBorderStyle.None
                        .Margin = New Padding(0)
                        .Padding = New Padding(0)
                        .Location = New Point(20, 20)
                        Select Case .Name

                            Case FRM.TableLayoutPanel_Files.Name

                                .backcolor = SystemColors.Control
                                .SetColumnSpan(FRM.DGV_Search, 2)
                                .SetColumnSpan(FRM.BindingNavigator_CSV, 2)
                                .SetColumnSpan(FRM.DGV_CSV, 2)

                            Case FRM.TableLayoutPanel_CardRow_List.Name

                                .SetColumnSpan(FRM.ListBox_CardRow_List, 3)

                        End Select

                    Case "Button"

                        .Dock = DockStyle.Top
                        .AutoSizeMode = AutoSizeMode.GrowAndShrink
                        .Margin = New Padding(0)
                        .Padding = New Padding(0)
                        .Location = New Point(0, 0)

                    Case Else

                        MessageBox.Show("Der Objecttyp ist nicht gepflegt.", "Konfig fehlt!" & .GetType.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Select
            End With
        Next

    End Sub

End Class
