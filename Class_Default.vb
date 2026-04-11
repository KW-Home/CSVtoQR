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
            .Add(FRM.Label_DPI)
            .Add(FRM.Label_DIN)
            .Add(FRM.Label_Paper_Height)
            .Add(FRM.Label_Paper_Height_Unit)
            .Add(FRM.Label_Paper_Width)
            .Add(FRM.Label_Paper_Width_Unit)
            .Add(FRM.Label_Separator_Row_Count)
            .Add(FRM.Label_Separator_Row_Value)
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
            .Add(FRM.Label6)
            .Add(FRM.Label8)
            .Add(FRM.Label9)
            .Add(FRM.Label10)
            .Add(FRM.Label11)
            .Add(FRM.Label12)
            .Add(FRM.Label13)
            .Add(FRM.Label14)

            .Add(FRM.Label_Paper_Height_Value)
            .Add(FRM.Label_Paper_Width_Value)

            .Add(FRM.ComboBox_DIN)
            .Add(FRM.ComboBox_DPI)
            .Add(FRM.ComboBox_DataColumn)

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
            .Add(FRM.PictureBox_Paper)

            .Add(FRM.Panel_Search)
            .Add(FRM.Panel_Daten_CSV)
            .Add(FRM.Panel_Paper)

            .Add(FRM.DGV_CSV)
            .Add(FRM.DGV_Search)
            .Add(FRM.DGV_Table)

            .Add(FRM.GroupBox_Shema)
            .Add(FRM.GroupBox_Separator_Row)
            .Add(FRM.GroupBox_Separator_Column)
            .Add(FRM.GroupBox_Paper_Border)
            .Add(FRM.GroupBox_Row_Border)
            .Add(FRM.GroupBox_Row_Line)
            .Add(FRM.GroupBox_Card)

            .Add(FRM.CheckBox_QRCode)
            .Add(FRM.CheckBox_AutoFont)

            .Add(FRM.TableLayoutPanel_Shema)
            .Add(FRM.TableLayoutPanel_Paper)
            .Add(FRM.TableLayoutPanel_Paper_Border)
            .Add(FRM.TableLayoutPanel_Separator)
            .Add(FRM.TableLayoutPanel_Files)
            .Add(FRM.TableLayoutPanel_Card)
            .Add(FRM.TableLayoutPanel_Row)
            .Add(FRM.TableLayoutPanel_Row_Line)
            .Add(FRM.TableLayoutPanel_Row_Border)

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
                            Case "NumericUpDown_Separator_Column_Count", "NumericUpDown_Separator_Row_Count"
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
                            Case "Label_Paper_Height_Unit", "Label_Paper_Width_Unit", "Label_Paper_Border_Right_Unit",
                                     "Label_Paper_Border_Top_Unit", "Label_Paper_Border_Bottom_Unit", "Label_Paper_Border_Left_Unit"
                                .TextAlign = ContentAlignment.MiddleLeft
                            Case "Label_Separator_Row_Count", "Label_Separator_Row_Value"
                                .TextAlign = ContentAlignment.BottomCenter
                            Case "Label_Paper_Height_Value", "Label_Paper_Width_Value"
                                .Dock = DockStyle.Fill
                                .TextAlign = ContentAlignment.MiddleRight
                            Case Else
                                .TextAlign = ContentAlignment.MiddleRight
                        End Select

                    Case "ComboBox"
                        .Dock = DockStyle.Left
                        .Margin = New Padding(3)
                        .Padding = New Padding(0)
                        Select Case .Name
                            Case "ComboBox_DPI"
                                .Items.AddRange(New Object() {72, 96, 150, 300, 600})
                            Case "ComboBox_DIN"
                                .DataSource = DS.Tables("PaperDIN")
                                .DisplayMember = "DIN"
                                .ValueMember = "DIN"
                                If DS.Tables("Shema").Rows.Count > 0 Then
                                    .SelectedValue = DS.Tables("Shema").Rows(0).Item("DIN").ToString
                                End If
                            Case "ComboBox_DataColumn"
                                .dock = DockStyle.Fill
                        End Select

                    Case "TabPage"
                        .BackColor = Color.Transparent
                        Select Case .name
                            Case "TabPage_Files"
                                .AutoScroll = False
                            Case Else
                                .AutoScroll = True
                        End Select

'noch nicht benutzt
                    Case "ToolStripStatusLabel"
                        .BackColor = Color.Yellow

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
                        .Dock = DockStyle.Top
                        .RenderMode = ToolStripRenderMode.System

                    Case "ListBox"
                        .BackColor = SystemColors.Control
                        .Dock = DockStyle.Left

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
                        .BackgroundColor = Color.Yellow
                        Select Case CON.Name
                            Case "DGV_CSV"
                                .Dock = DockStyle.Fill
                            Case Else
                                .Dock = DockStyle.Fill
                        End Select
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

                    Case "GroupBox"
                        .Dock = DockStyle.Top
                        .Margin = New Padding(3, 3, 21, 3)
                        .Padding = New Padding(3)

                    Case "CheckBox"
                        .Dock = DockStyle.Left
                        .Appearance = Appearance.Normal
                        .Text = ""
                        .Margin = New Padding(0)
                        .Padding = New Padding(0)

                    Case "TableLayoutPanel"
                        .Dock = DockStyle.Fill
                        .AutoSizeMode = AutoSizeMode.GrowAndShrink
                        .BorderStyle = BorderStyle.None
                        .CellBorderStyle = TableLayoutPanelCellBorderStyle.None
                        .Margin = New Padding(0)
                        .Padding = New Padding(0)
                        .Location = New Point(20, 20)
                        Select Case .name
                            Case "TableLayoutPanel_Files"
                                .backcolor = Color.Red
                                .SetColumnSpan(FRM.Panel_Search, 2)
                                .SetColumnSpan(FRM.Panel_Daten_CSV, 2)
                        End Select

                    Case Else
                        MessageBox.Show("Der Objecttyp ist nicht gepflegt.", "Konfig fehlt!" & .GetType.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Select
            End With
        Next

    End Sub

End Class
