<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim MySettings1 As CSVtoQR.My.MySettings = New CSVtoQR.My.MySettings()
        Me.Label_Separator_Row = New System.Windows.Forms.Label()
        Me.TableLayoutPanel_Separatoren = New System.Windows.Forms.TableLayoutPanel()
        Me.NumericUpDown_Separator_Column_Count = New System.Windows.Forms.NumericUpDown()
        Me.Label_Separator_Column_Count = New System.Windows.Forms.Label()
        Me.Label_Separator_Row_Unit = New System.Windows.Forms.Label()
        Me.NumericUpDown_Separator_Row_Value = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Separator_Row_Count = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Separator_Column_Value = New System.Windows.Forms.NumericUpDown()
        Me.Label_Separator_Column_Value = New System.Windows.Forms.Label()
        Me.Label_Separator_Column_Unit = New System.Windows.Forms.Label()
        Me.Label_Separator_Column = New System.Windows.Forms.Label()
        Me.GroupBox_Separatoren = New System.Windows.Forms.GroupBox()
        Me.Label_Paper_Width = New System.Windows.Forms.Label()
        Me.Label_Paper_Height = New System.Windows.Forms.Label()
        Me.Label_Paper_DPI = New System.Windows.Forms.Label()
        Me.Label_Paper_DIN = New System.Windows.Forms.Label()
        Me.TextBox_General_Import_Directory = New System.Windows.Forms.TextBox()
        Me.Label_General_Export_Directory = New System.Windows.Forms.Label()
        Me.TextBox_General_Export_Directory = New System.Windows.Forms.TextBox()
        Me.ImageList_Main = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel_Data = New System.Windows.Forms.TableLayoutPanel()
        Me.Button_Search_Delete = New System.Windows.Forms.Button()
        Me.DGV_Search = New System.Windows.Forms.DataGridView()
        Me.Button_Search_Add = New System.Windows.Forms.Button()
        Me.DGV_CSV = New System.Windows.Forms.DataGridView()
        Me.BindingNavigator_CSV = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button_Search_Refresh = New System.Windows.Forms.Button()
        Me.TabPage_Data = New System.Windows.Forms.TabPage()
        Me.GroupBox_Data = New System.Windows.Forms.GroupBox()
        Me.TabControl_Main = New System.Windows.Forms.TabControl()
        Me.TabPage_General = New System.Windows.Forms.TabPage()
        Me.GroupBox_General_XML = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_General_XML = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox_General_XML_Filename = New System.Windows.Forms.TextBox()
        Me.Label_General_XML_Filname = New System.Windows.Forms.Label()
        Me.Button_General_XML_Open = New System.Windows.Forms.Button()
        Me.TextBox_General_XML_Directory = New System.Windows.Forms.TextBox()
        Me.Label_General_XML_Directory = New System.Windows.Forms.Label()
        Me.GroupBox_General_Import = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_General_Import = New System.Windows.Forms.TableLayoutPanel()
        Me.Button_General_Import = New System.Windows.Forms.Button()
        Me.Label_General_Import_Directory = New System.Windows.Forms.Label()
        Me.Label_General_Import_Filname = New System.Windows.Forms.Label()
        Me.TextBox_General_Import_Filename = New System.Windows.Forms.TextBox()
        Me.GroupBox_General_Export = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_General_Export = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox_General_Export_Filename = New System.Windows.Forms.TextBox()
        Me.Label_General_Export_Filname = New System.Windows.Forms.Label()
        Me.Button_General_Export = New System.Windows.Forms.Button()
        Me.TabPage_Paper = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel_Paper = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox_Paper_Shema = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Paper_Shema = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Paper_Width_Unit = New System.Windows.Forms.Label()
        Me.Label_Paper_Height_Unit = New System.Windows.Forms.Label()
        Me.Label_Paper_Width_Value = New System.Windows.Forms.Label()
        Me.Label_Paper_Shema = New System.Windows.Forms.Label()
        Me.Label_Paper_Height_Value = New System.Windows.Forms.Label()
        Me.ComboBox_Paper_DPI = New System.Windows.Forms.ComboBox()
        Me.TextBox_Paper_Shema = New System.Windows.Forms.TextBox()
        Me.ComboBox_Paper_DIN = New System.Windows.Forms.ComboBox()
        Me.TabPage_Card = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel_Card = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox_Card_Size = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Card_Size = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Card_Size_Width_Unit = New System.Windows.Forms.Label()
        Me.Label_Card_Size_Hight_Unit = New System.Windows.Forms.Label()
        Me.Label_Card_Size_Hight = New System.Windows.Forms.Label()
        Me.Label_Card_Size_Hight_Value = New System.Windows.Forms.Label()
        Me.Label_Card_Size_Width = New System.Windows.Forms.Label()
        Me.Label_Card_Size_Width_Value = New System.Windows.Forms.Label()
        Me.TabPage_CardRow = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel_CardRow = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox_CardRow_Line = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_CardRow_Line = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_CardRow_LinePos_Value = New System.Windows.Forms.Label()
        Me.Label_CardRow_DataColumn = New System.Windows.Forms.Label()
        Me.ComboBox_CardRow_DataColumn = New System.Windows.Forms.ComboBox()
        Me.Label_CardRow_AutoFont = New System.Windows.Forms.Label()
        Me.CheckBox_CardRow_AutoFont = New System.Windows.Forms.CheckBox()
        Me.Label_CardRow_QRCode = New System.Windows.Forms.Label()
        Me.CheckBox_CardRow_QRCode = New System.Windows.Forms.CheckBox()
        Me.Label_CardRow_LinePos = New System.Windows.Forms.Label()
        Me.Label_CardRow_FontColor = New System.Windows.Forms.Label()
        Me.Button_CardRow_FontColor = New System.Windows.Forms.Button()
        Me.GroupBox_CardRow_List = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_CardRow_ListBox = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBox_CardRow = New System.Windows.Forms.ListBox()
        Me.FlowLayoutPanel_CardRow_TopDown = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_CardRow_Up = New System.Windows.Forms.Button()
        Me.Button_CardRow_Down = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel_CardRow_Row = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_CardRow_Save = New System.Windows.Forms.Button()
        Me.Button_CardRow_Add = New System.Windows.Forms.Button()
        Me.Button_CardRow_Delete = New System.Windows.Forms.Button()
        Me.TabPage_Table = New System.Windows.Forms.TabPage()
        Me.GroupBox_Table = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Table = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBox_Tabellen = New System.Windows.Forms.ListBox()
        Me.DGV_Table = New System.Windows.Forms.DataGridView()
        Me.Panel_Preview = New System.Windows.Forms.Panel()
        Me.PictureBox_Preview = New System.Windows.Forms.PictureBox()
        Me.AlleauswählenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator05 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator04 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_Wiederholen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Rückgängig = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Beenden = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator03 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator02 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_XML_SaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator01 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_Datei = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_XML_New = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_XML_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_XML_Safe = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Print = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Seitenansicht = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Bearbeiten = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Main = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem_Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripStatusLabel_SaveFile = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_SaveInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_IsModified = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip_Main = New System.Windows.Forms.StatusStrip()
        Me.SplitContainer_Main = New System.Windows.Forms.SplitContainer()
        Me.BindingSource_CSV = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel__General = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel_Separatoren.SuspendLayout()
        CType(Me.NumericUpDown_Separator_Column_Count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Separator_Row_Value, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Separator_Row_Count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Separator_Column_Value, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Separatoren.SuspendLayout()
        Me.TableLayoutPanel_Data.SuspendLayout()
        CType(Me.DGV_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_CSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator_CSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator_CSV.SuspendLayout()
        Me.TabPage_Data.SuspendLayout()
        Me.GroupBox_Data.SuspendLayout()
        Me.TabControl_Main.SuspendLayout()
        Me.TabPage_General.SuspendLayout()
        Me.GroupBox_General_XML.SuspendLayout()
        Me.TableLayoutPanel_General_XML.SuspendLayout()
        Me.GroupBox_General_Import.SuspendLayout()
        Me.TableLayoutPanel_General_Import.SuspendLayout()
        Me.GroupBox_General_Export.SuspendLayout()
        Me.TableLayoutPanel_General_Export.SuspendLayout()
        Me.TabPage_Paper.SuspendLayout()
        Me.TableLayoutPanel_Paper.SuspendLayout()
        Me.GroupBox_Paper_Shema.SuspendLayout()
        Me.TableLayoutPanel_Paper_Shema.SuspendLayout()
        Me.TabPage_Card.SuspendLayout()
        Me.TableLayoutPanel_Card.SuspendLayout()
        Me.GroupBox_Card_Size.SuspendLayout()
        Me.TableLayoutPanel_Card_Size.SuspendLayout()
        Me.TabPage_CardRow.SuspendLayout()
        Me.TableLayoutPanel_CardRow.SuspendLayout()
        Me.GroupBox_CardRow_Line.SuspendLayout()
        Me.TableLayoutPanel_CardRow_Line.SuspendLayout()
        Me.GroupBox_CardRow_List.SuspendLayout()
        Me.TableLayoutPanel_CardRow_ListBox.SuspendLayout()
        Me.FlowLayoutPanel_CardRow_TopDown.SuspendLayout()
        Me.FlowLayoutPanel_CardRow_Row.SuspendLayout()
        Me.TabPage_Table.SuspendLayout()
        Me.GroupBox_Table.SuspendLayout()
        Me.TableLayoutPanel_Table.SuspendLayout()
        CType(Me.DGV_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Preview.SuspendLayout()
        CType(Me.PictureBox_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip_Main.SuspendLayout()
        Me.StatusStrip_Main.SuspendLayout()
        CType(Me.SplitContainer_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Main.Panel1.SuspendLayout()
        Me.SplitContainer_Main.Panel2.SuspendLayout()
        Me.SplitContainer_Main.SuspendLayout()
        CType(Me.BindingSource_CSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel__General.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Separator_Row
        '
        Me.Label_Separator_Row.AutoSize = True
        Me.Label_Separator_Row.Location = New System.Drawing.Point(3, 43)
        Me.Label_Separator_Row.Name = "Label_Separator_Row"
        Me.Label_Separator_Row.Size = New System.Drawing.Size(29, 17)
        Me.Label_Separator_Row.TabIndex = 1
        Me.Label_Separator_Row.Text = "Zeile"
        Me.Label_Separator_Row.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Separator_Row.UseCompatibleTextRendering = True
        '
        'TableLayoutPanel_Separatoren
        '
        Me.TableLayoutPanel_Separatoren.AutoSize = True
        Me.TableLayoutPanel_Separatoren.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel_Separatoren.ColumnCount = 4
        Me.TableLayoutPanel_Separatoren.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Separatoren.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Separatoren.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Separatoren.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Separatoren.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Separatoren.Controls.Add(Me.NumericUpDown_Separator_Column_Count, 1, 1)
        Me.TableLayoutPanel_Separatoren.Controls.Add(Me.Label_Separator_Row, 0, 2)
        Me.TableLayoutPanel_Separatoren.Controls.Add(Me.Label_Separator_Column_Count, 1, 0)
        Me.TableLayoutPanel_Separatoren.Controls.Add(Me.Label_Separator_Row_Unit, 3, 2)
        Me.TableLayoutPanel_Separatoren.Controls.Add(Me.NumericUpDown_Separator_Row_Value, 2, 2)
        Me.TableLayoutPanel_Separatoren.Controls.Add(Me.NumericUpDown_Separator_Row_Count, 1, 2)
        Me.TableLayoutPanel_Separatoren.Controls.Add(Me.NumericUpDown_Separator_Column_Value, 2, 1)
        Me.TableLayoutPanel_Separatoren.Controls.Add(Me.Label_Separator_Column_Value, 2, 0)
        Me.TableLayoutPanel_Separatoren.Controls.Add(Me.Label_Separator_Column_Unit, 3, 1)
        Me.TableLayoutPanel_Separatoren.Controls.Add(Me.Label_Separator_Column, 0, 1)
        Me.TableLayoutPanel_Separatoren.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel_Separatoren.Name = "TableLayoutPanel_Separatoren"
        Me.TableLayoutPanel_Separatoren.RowCount = 3
        Me.TableLayoutPanel_Separatoren.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Separatoren.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Separatoren.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Separatoren.Size = New System.Drawing.Size(232, 69)
        Me.TableLayoutPanel_Separatoren.TabIndex = 0
        Me.TableLayoutPanel_Separatoren.Tag = "Decimal"
        '
        'NumericUpDown_Separator_Column_Count
        '
        Me.NumericUpDown_Separator_Column_Count.Location = New System.Drawing.Point(45, 20)
        Me.NumericUpDown_Separator_Column_Count.Name = "NumericUpDown_Separator_Column_Count"
        Me.NumericUpDown_Separator_Column_Count.Size = New System.Drawing.Size(74, 20)
        Me.NumericUpDown_Separator_Column_Count.TabIndex = 0
        Me.NumericUpDown_Separator_Column_Count.Tag = "SeparatorSpalteAnzahl"
        '
        'Label_Separator_Column_Count
        '
        Me.Label_Separator_Column_Count.AutoSize = True
        Me.Label_Separator_Column_Count.Location = New System.Drawing.Point(45, 0)
        Me.Label_Separator_Column_Count.Name = "Label_Separator_Column_Count"
        Me.Label_Separator_Column_Count.Size = New System.Drawing.Size(39, 17)
        Me.Label_Separator_Column_Count.TabIndex = 29
        Me.Label_Separator_Column_Count.Text = "Anzahl"
        Me.Label_Separator_Column_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Separator_Column_Count.UseCompatibleTextRendering = True
        '
        'Label_Separator_Row_Unit
        '
        Me.Label_Separator_Row_Unit.AutoSize = True
        Me.Label_Separator_Row_Unit.Location = New System.Drawing.Point(206, 43)
        Me.Label_Separator_Row_Unit.Name = "Label_Separator_Row_Unit"
        Me.Label_Separator_Row_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Separator_Row_Unit.TabIndex = 48
        Me.Label_Separator_Row_Unit.Text = "mm"
        Me.Label_Separator_Row_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Separator_Row_Unit.UseCompatibleTextRendering = True
        '
        'NumericUpDown_Separator_Row_Value
        '
        Me.NumericUpDown_Separator_Row_Value.Location = New System.Drawing.Point(125, 46)
        Me.NumericUpDown_Separator_Row_Value.Name = "NumericUpDown_Separator_Row_Value"
        Me.NumericUpDown_Separator_Row_Value.Size = New System.Drawing.Size(75, 20)
        Me.NumericUpDown_Separator_Row_Value.TabIndex = 3
        Me.NumericUpDown_Separator_Row_Value.Tag = "SeparatorZeileWert"
        '
        'NumericUpDown_Separator_Row_Count
        '
        Me.NumericUpDown_Separator_Row_Count.Location = New System.Drawing.Point(45, 46)
        Me.NumericUpDown_Separator_Row_Count.Name = "NumericUpDown_Separator_Row_Count"
        Me.NumericUpDown_Separator_Row_Count.Size = New System.Drawing.Size(74, 20)
        Me.NumericUpDown_Separator_Row_Count.TabIndex = 2
        Me.NumericUpDown_Separator_Row_Count.Tag = "SeparatorZeileAnzahl"
        '
        'NumericUpDown_Separator_Column_Value
        '
        Me.NumericUpDown_Separator_Column_Value.Location = New System.Drawing.Point(125, 20)
        Me.NumericUpDown_Separator_Column_Value.Name = "NumericUpDown_Separator_Column_Value"
        Me.NumericUpDown_Separator_Column_Value.Size = New System.Drawing.Size(75, 20)
        Me.NumericUpDown_Separator_Column_Value.TabIndex = 1
        Me.NumericUpDown_Separator_Column_Value.Tag = "SeparatorSpalteWert"
        '
        'Label_Separator_Column_Value
        '
        Me.Label_Separator_Column_Value.AutoSize = True
        Me.Label_Separator_Column_Value.Location = New System.Drawing.Point(125, 0)
        Me.Label_Separator_Column_Value.Name = "Label_Separator_Column_Value"
        Me.Label_Separator_Column_Value.Size = New System.Drawing.Size(28, 17)
        Me.Label_Separator_Column_Value.TabIndex = 30
        Me.Label_Separator_Column_Value.Text = "Wert"
        Me.Label_Separator_Column_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Separator_Column_Value.UseCompatibleTextRendering = True
        '
        'Label_Separator_Column_Unit
        '
        Me.Label_Separator_Column_Unit.AutoSize = True
        Me.Label_Separator_Column_Unit.Location = New System.Drawing.Point(206, 17)
        Me.Label_Separator_Column_Unit.Name = "Label_Separator_Column_Unit"
        Me.Label_Separator_Column_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Separator_Column_Unit.TabIndex = 49
        Me.Label_Separator_Column_Unit.Text = "mm"
        Me.Label_Separator_Column_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Separator_Column_Unit.UseCompatibleTextRendering = True
        '
        'Label_Separator_Column
        '
        Me.Label_Separator_Column.AutoSize = True
        Me.Label_Separator_Column.Location = New System.Drawing.Point(3, 17)
        Me.Label_Separator_Column.Name = "Label_Separator_Column"
        Me.Label_Separator_Column.Size = New System.Drawing.Size(36, 17)
        Me.Label_Separator_Column.TabIndex = 50
        Me.Label_Separator_Column.Text = "Spalte"
        Me.Label_Separator_Column.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Separator_Column.UseCompatibleTextRendering = True
        '
        'GroupBox_Separatoren
        '
        Me.GroupBox_Separatoren.AutoSize = True
        Me.GroupBox_Separatoren.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox_Separatoren.Controls.Add(Me.TableLayoutPanel_Separatoren)
        Me.GroupBox_Separatoren.Location = New System.Drawing.Point(3, 142)
        Me.GroupBox_Separatoren.Name = "GroupBox_Separatoren"
        Me.GroupBox_Separatoren.Size = New System.Drawing.Size(241, 104)
        Me.GroupBox_Separatoren.TabIndex = 3
        Me.GroupBox_Separatoren.TabStop = False
        Me.GroupBox_Separatoren.Text = "Separatoren Spalte"
        Me.GroupBox_Separatoren.UseCompatibleTextRendering = True
        '
        'Label_Paper_Width
        '
        Me.Label_Paper_Width.AutoSize = True
        Me.Label_Paper_Width.Location = New System.Drawing.Point(3, 97)
        Me.Label_Paper_Width.Name = "Label_Paper_Width"
        Me.Label_Paper_Width.Size = New System.Drawing.Size(34, 17)
        Me.Label_Paper_Width.TabIndex = 6
        Me.Label_Paper_Width.Text = "Breite"
        Me.Label_Paper_Width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Width.UseCompatibleTextRendering = True
        '
        'Label_Paper_Height
        '
        Me.Label_Paper_Height.AutoSize = True
        Me.Label_Paper_Height.Location = New System.Drawing.Point(3, 80)
        Me.Label_Paper_Height.Name = "Label_Paper_Height"
        Me.Label_Paper_Height.Size = New System.Drawing.Size(31, 17)
        Me.Label_Paper_Height.TabIndex = 4
        Me.Label_Paper_Height.Text = "Höhe"
        Me.Label_Paper_Height.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Height.UseCompatibleTextRendering = True
        '
        'Label_Paper_DPI
        '
        Me.Label_Paper_DPI.AutoSize = True
        Me.Label_Paper_DPI.Location = New System.Drawing.Point(3, 26)
        Me.Label_Paper_DPI.Name = "Label_Paper_DPI"
        Me.Label_Paper_DPI.Size = New System.Drawing.Size(23, 17)
        Me.Label_Paper_DPI.TabIndex = 0
        Me.Label_Paper_DPI.Text = "DPI"
        Me.Label_Paper_DPI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_DPI.UseCompatibleTextRendering = True
        '
        'Label_Paper_DIN
        '
        Me.Label_Paper_DIN.AutoSize = True
        Me.Label_Paper_DIN.Location = New System.Drawing.Point(3, 53)
        Me.Label_Paper_DIN.Name = "Label_Paper_DIN"
        Me.Label_Paper_DIN.Size = New System.Drawing.Size(24, 17)
        Me.Label_Paper_DIN.TabIndex = 2
        Me.Label_Paper_DIN.Text = "DIN"
        Me.Label_Paper_DIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_DIN.UseCompatibleTextRendering = True
        '
        'TextBox_General_Import_Directory
        '
        Me.TextBox_General_Import_Directory.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox_General_Import_Directory.Enabled = False
        Me.TextBox_General_Import_Directory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_General_Import_Directory.Location = New System.Drawing.Point(59, 0)
        Me.TextBox_General_Import_Directory.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox_General_Import_Directory.Name = "TextBox_General_Import_Directory"
        Me.TextBox_General_Import_Directory.Size = New System.Drawing.Size(59, 20)
        Me.TextBox_General_Import_Directory.TabIndex = 0
        Me.TextBox_General_Import_Directory.Tag = "Import"
        '
        'Label_General_Export_Directory
        '
        Me.Label_General_Export_Directory.AutoSize = True
        Me.Label_General_Export_Directory.Location = New System.Drawing.Point(0, 0)
        Me.Label_General_Export_Directory.Margin = New System.Windows.Forms.Padding(0)
        Me.Label_General_Export_Directory.Name = "Label_General_Export_Directory"
        Me.Label_General_Export_Directory.Size = New System.Drawing.Size(39, 17)
        Me.Label_General_Export_Directory.TabIndex = 5
        Me.Label_General_Export_Directory.Text = "Ordner"
        Me.Label_General_Export_Directory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_General_Export_Directory.UseCompatibleTextRendering = True
        '
        'TextBox_General_Export_Directory
        '
        Me.TextBox_General_Export_Directory.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox_General_Export_Directory.Enabled = False
        Me.TextBox_General_Export_Directory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_General_Export_Directory.Location = New System.Drawing.Point(59, 0)
        Me.TextBox_General_Export_Directory.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox_General_Export_Directory.Name = "TextBox_General_Export_Directory"
        Me.TextBox_General_Export_Directory.Size = New System.Drawing.Size(59, 20)
        Me.TextBox_General_Export_Directory.TabIndex = 1
        Me.TextBox_General_Export_Directory.Tag = "Export"
        '
        'ImageList_Main
        '
        Me.ImageList_Main.ImageStream = CType(resources.GetObject("ImageList_Main.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Main.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ImageList_Main.Images.SetKeyName(0, "File_Printer")
        Me.ImageList_Main.Images.SetKeyName(1, "Import")
        Me.ImageList_Main.Images.SetKeyName(2, "ZoomIn")
        Me.ImageList_Main.Images.SetKeyName(3, "ZoomOut")
        Me.ImageList_Main.Images.SetKeyName(4, "Refresh_Arrow_Green")
        Me.ImageList_Main.Images.SetKeyName(5, "DatabaseSchema")
        Me.ImageList_Main.Images.SetKeyName(6, "Font")
        Me.ImageList_Main.Images.SetKeyName(7, "Arrow_Green_Up")
        Me.ImageList_Main.Images.SetKeyName(8, "Arrow_Green_Down")
        Me.ImageList_Main.Images.SetKeyName(9, "Save")
        Me.ImageList_Main.Images.SetKeyName(10, "Delete_Cross")
        Me.ImageList_Main.Images.SetKeyName(11, "Plus")
        Me.ImageList_Main.Images.SetKeyName(12, "Edit")
        '
        'TableLayoutPanel_Data
        '
        Me.TableLayoutPanel_Data.AutoSize = True
        Me.TableLayoutPanel_Data.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel_Data.ColumnCount = 3
        Me.TableLayoutPanel_Data.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Data.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Data.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Data.Controls.Add(Me.Button_Search_Delete, 2, 0)
        Me.TableLayoutPanel_Data.Controls.Add(Me.DGV_Search, 0, 0)
        Me.TableLayoutPanel_Data.Controls.Add(Me.Button_Search_Add, 2, 2)
        Me.TableLayoutPanel_Data.Controls.Add(Me.DGV_CSV, 0, 2)
        Me.TableLayoutPanel_Data.Controls.Add(Me.BindingNavigator_CSV, 0, 1)
        Me.TableLayoutPanel_Data.Controls.Add(Me.Button_Search_Refresh, 2, 1)
        Me.TableLayoutPanel_Data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_Data.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel_Data.Name = "TableLayoutPanel_Data"
        Me.TableLayoutPanel_Data.RowCount = 3
        Me.TableLayoutPanel_Data.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Data.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Data.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Data.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Data.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Data.Size = New System.Drawing.Size(359, 323)
        Me.TableLayoutPanel_Data.TabIndex = 0
        '
        'Button_Search_Delete
        '
        Me.Button_Search_Delete.AutoSize = True
        Me.Button_Search_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Search_Delete.ImageKey = "ZoomOut"
        Me.Button_Search_Delete.ImageList = Me.ImageList_Main
        Me.Button_Search_Delete.Location = New System.Drawing.Point(318, 3)
        Me.Button_Search_Delete.Name = "Button_Search_Delete"
        Me.Button_Search_Delete.Size = New System.Drawing.Size(38, 38)
        Me.Button_Search_Delete.TabIndex = 46
        Me.Button_Search_Delete.UseVisualStyleBackColor = True
        '
        'DGV_Search
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Search.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Search.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Search.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DGV_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel_Data.SetColumnSpan(Me.DGV_Search, 2)
        Me.DGV_Search.EnableHeadersVisualStyles = False
        Me.DGV_Search.GridColor = System.Drawing.Color.DarkGray
        Me.DGV_Search.Location = New System.Drawing.Point(3, 3)
        Me.DGV_Search.Name = "DGV_Search"
        Me.DGV_Search.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGV_Search.Size = New System.Drawing.Size(208, 29)
        Me.DGV_Search.TabIndex = 0
        '
        'Button_Search_Add
        '
        Me.Button_Search_Add.AutoSize = True
        Me.Button_Search_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Search_Add.ImageKey = "ZoomIn"
        Me.Button_Search_Add.ImageList = Me.ImageList_Main
        Me.Button_Search_Add.Location = New System.Drawing.Point(318, 91)
        Me.Button_Search_Add.Name = "Button_Search_Add"
        Me.Button_Search_Add.Size = New System.Drawing.Size(38, 38)
        Me.Button_Search_Add.TabIndex = 47
        Me.Button_Search_Add.UseVisualStyleBackColor = True
        '
        'DGV_CSV
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_CSV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_CSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGV_CSV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DGV_CSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel_Data.SetColumnSpan(Me.DGV_CSV, 2)
        Me.DGV_CSV.GridColor = System.Drawing.Color.DarkGray
        Me.DGV_CSV.Location = New System.Drawing.Point(3, 91)
        Me.DGV_CSV.MultiSelect = False
        Me.DGV_CSV.Name = "DGV_CSV"
        Me.DGV_CSV.RowHeadersWidth = 62
        Me.DGV_CSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGV_CSV.Size = New System.Drawing.Size(153, 39)
        Me.DGV_CSV.TabIndex = 44
        '
        'BindingNavigator_CSV
        '
        Me.BindingNavigator_CSV.AddNewItem = Nothing
        Me.BindingNavigator_CSV.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel_Data.SetColumnSpan(Me.BindingNavigator_CSV, 2)
        Me.BindingNavigator_CSV.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator_CSV.DeleteItem = Nothing
        Me.BindingNavigator_CSV.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator_CSV.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigator_CSV.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator_CSV.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BindingNavigator_CSV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator_CSV.Location = New System.Drawing.Point(0, 44)
        Me.BindingNavigator_CSV.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator_CSV.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator_CSV.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator_CSV.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator_CSV.Name = "BindingNavigator_CSV"
        Me.BindingNavigator_CSV.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator_CSV.Size = New System.Drawing.Size(244, 31)
        Me.BindingNavigator_CSV.TabIndex = 45
        Me.BindingNavigator_CSV.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(59, 28)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Erste verschieben"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Aktuelle Position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'Button_Search_Refresh
        '
        Me.Button_Search_Refresh.AutoSize = True
        Me.Button_Search_Refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Search_Refresh.ImageKey = "Refresh_Arrow_Green"
        Me.Button_Search_Refresh.ImageList = Me.ImageList_Main
        Me.Button_Search_Refresh.Location = New System.Drawing.Point(318, 47)
        Me.Button_Search_Refresh.Name = "Button_Search_Refresh"
        Me.Button_Search_Refresh.Size = New System.Drawing.Size(38, 38)
        Me.Button_Search_Refresh.TabIndex = 48
        Me.Button_Search_Refresh.UseVisualStyleBackColor = True
        '
        'TabPage_Data
        '
        Me.TabPage_Data.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_Data.Controls.Add(Me.GroupBox_Data)
        Me.TabPage_Data.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Data.Name = "TabPage_Data"
        Me.TabPage_Data.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Data.Size = New System.Drawing.Size(371, 348)
        Me.TabPage_Data.TabIndex = 5
        Me.TabPage_Data.Text = "Daten"
        '
        'GroupBox_Data
        '
        Me.GroupBox_Data.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox_Data.Controls.Add(Me.TableLayoutPanel_Data)
        Me.GroupBox_Data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox_Data.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox_Data.Name = "GroupBox_Data"
        Me.GroupBox_Data.Size = New System.Drawing.Size(365, 342)
        Me.GroupBox_Data.TabIndex = 1
        Me.GroupBox_Data.TabStop = False
        Me.GroupBox_Data.Text = "Daten aus dem Import"
        '
        'TabControl_Main
        '
        Me.TabControl_Main.Controls.Add(Me.TabPage_General)
        Me.TabControl_Main.Controls.Add(Me.TabPage_Paper)
        Me.TabControl_Main.Controls.Add(Me.TabPage_Card)
        Me.TabControl_Main.Controls.Add(Me.TabPage_CardRow)
        Me.TabControl_Main.Controls.Add(Me.TabPage_Data)
        Me.TabControl_Main.Controls.Add(Me.TabPage_Table)
        Me.TabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_Main.Location = New System.Drawing.Point(0, 0)
        Me.TabControl_Main.Margin = New System.Windows.Forms.Padding(29)
        Me.TabControl_Main.Multiline = True
        Me.TabControl_Main.Name = "TabControl_Main"
        Me.TabControl_Main.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl_Main.SelectedIndex = 0
        Me.TabControl_Main.Size = New System.Drawing.Size(283, 374)
        Me.TabControl_Main.TabIndex = 5
        '
        'TabPage_General
        '
        Me.TabPage_General.AutoScroll = True
        Me.TabPage_General.Controls.Add(Me.TableLayoutPanel__General)
        Me.TabPage_General.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_General.Name = "TabPage_General"
        Me.TabPage_General.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_General.Size = New System.Drawing.Size(275, 348)
        Me.TabPage_General.TabIndex = 8
        Me.TabPage_General.Text = "Allgemein"
        Me.TabPage_General.UseVisualStyleBackColor = True
        '
        'GroupBox_General_XML
        '
        Me.GroupBox_General_XML.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox_General_XML.Controls.Add(Me.TableLayoutPanel_General_XML)
        Me.GroupBox_General_XML.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_General_XML.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox_General_XML.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox_General_XML.Name = "GroupBox_General_XML"
        Me.GroupBox_General_XML.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox_General_XML.Size = New System.Drawing.Size(156, 53)
        Me.GroupBox_General_XML.TabIndex = 1
        Me.GroupBox_General_XML.TabStop = False
        Me.GroupBox_General_XML.Text = "Datenpfade"
        Me.GroupBox_General_XML.UseCompatibleTextRendering = True
        '
        'TableLayoutPanel_General_XML
        '
        Me.TableLayoutPanel_General_XML.AutoSize = True
        Me.TableLayoutPanel_General_XML.ColumnCount = 3
        Me.TableLayoutPanel_General_XML.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_General_XML.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_General_XML.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_General_XML.Controls.Add(Me.TextBox_General_XML_Filename, 1, 1)
        Me.TableLayoutPanel_General_XML.Controls.Add(Me.Label_General_XML_Filname, 0, 1)
        Me.TableLayoutPanel_General_XML.Controls.Add(Me.Button_General_XML_Open, 2, 0)
        Me.TableLayoutPanel_General_XML.Controls.Add(Me.TextBox_General_XML_Directory, 1, 0)
        Me.TableLayoutPanel_General_XML.Controls.Add(Me.Label_General_XML_Directory, 0, 0)
        Me.TableLayoutPanel_General_XML.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel_General_XML.Location = New System.Drawing.Point(0, 13)
        Me.TableLayoutPanel_General_XML.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel_General_XML.Name = "TableLayoutPanel_General_XML"
        Me.TableLayoutPanel_General_XML.RowCount = 2
        Me.TableLayoutPanel_General_XML.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_General_XML.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_General_XML.Size = New System.Drawing.Size(156, 40)
        Me.TableLayoutPanel_General_XML.TabIndex = 0
        '
        'TextBox_General_XML_Filename
        '
        Me.TextBox_General_XML_Filename.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox_General_XML_Filename.Enabled = False
        Me.TextBox_General_XML_Filename.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_General_XML_Filename.Location = New System.Drawing.Point(61, 20)
        Me.TextBox_General_XML_Filename.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox_General_XML_Filename.Name = "TextBox_General_XML_Filename"
        Me.TextBox_General_XML_Filename.Size = New System.Drawing.Size(57, 20)
        Me.TextBox_General_XML_Filename.TabIndex = 12
        '
        'Label_General_XML_Filname
        '
        Me.Label_General_XML_Filname.AutoSize = True
        Me.Label_General_XML_Filname.Location = New System.Drawing.Point(0, 20)
        Me.Label_General_XML_Filname.Margin = New System.Windows.Forms.Padding(0)
        Me.Label_General_XML_Filname.Name = "Label_General_XML_Filname"
        Me.Label_General_XML_Filname.Size = New System.Drawing.Size(61, 17)
        Me.Label_General_XML_Filname.TabIndex = 11
        Me.Label_General_XML_Filname.Text = "Dateiname"
        Me.Label_General_XML_Filname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_General_XML_Filname.UseCompatibleTextRendering = True
        '
        'Button_General_XML_Open
        '
        Me.Button_General_XML_Open.AutoSize = True
        Me.Button_General_XML_Open.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_General_XML_Open.ImageKey = "DatabaseSchema"
        Me.Button_General_XML_Open.ImageList = Me.ImageList_Main
        Me.Button_General_XML_Open.Location = New System.Drawing.Point(118, 0)
        Me.Button_General_XML_Open.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_General_XML_Open.Name = "Button_General_XML_Open"
        Me.TableLayoutPanel_General_XML.SetRowSpan(Me.Button_General_XML_Open, 2)
        Me.Button_General_XML_Open.Size = New System.Drawing.Size(38, 38)
        Me.Button_General_XML_Open.TabIndex = 10
        Me.Button_General_XML_Open.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button_General_XML_Open.UseCompatibleTextRendering = True
        Me.Button_General_XML_Open.UseVisualStyleBackColor = True
        '
        'TextBox_General_XML_Directory
        '
        Me.TextBox_General_XML_Directory.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox_General_XML_Directory.Enabled = False
        Me.TextBox_General_XML_Directory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_General_XML_Directory.Location = New System.Drawing.Point(61, 0)
        Me.TextBox_General_XML_Directory.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox_General_XML_Directory.Name = "TextBox_General_XML_Directory"
        Me.TextBox_General_XML_Directory.Size = New System.Drawing.Size(57, 20)
        Me.TextBox_General_XML_Directory.TabIndex = 9
        Me.TextBox_General_XML_Directory.Tag = "Export"
        '
        'Label_General_XML_Directory
        '
        Me.Label_General_XML_Directory.AutoSize = True
        Me.Label_General_XML_Directory.Location = New System.Drawing.Point(0, 0)
        Me.Label_General_XML_Directory.Margin = New System.Windows.Forms.Padding(0)
        Me.Label_General_XML_Directory.Name = "Label_General_XML_Directory"
        Me.Label_General_XML_Directory.Size = New System.Drawing.Size(47, 17)
        Me.Label_General_XML_Directory.TabIndex = 8
        Me.Label_General_XML_Directory.Text = "DataSet"
        Me.Label_General_XML_Directory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_General_XML_Directory.UseCompatibleTextRendering = True
        '
        'GroupBox_General_Import
        '
        Me.GroupBox_General_Import.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox_General_Import.Controls.Add(Me.TableLayoutPanel_General_Import)
        Me.GroupBox_General_Import.Location = New System.Drawing.Point(0, 53)
        Me.GroupBox_General_Import.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox_General_Import.Name = "GroupBox_General_Import"
        Me.GroupBox_General_Import.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox_General_Import.Size = New System.Drawing.Size(156, 53)
        Me.GroupBox_General_Import.TabIndex = 2
        Me.GroupBox_General_Import.TabStop = False
        Me.GroupBox_General_Import.Text = "CSV Import"
        Me.GroupBox_General_Import.UseCompatibleTextRendering = True
        '
        'TableLayoutPanel_General_Import
        '
        Me.TableLayoutPanel_General_Import.AutoSize = True
        Me.TableLayoutPanel_General_Import.ColumnCount = 3
        Me.TableLayoutPanel_General_Import.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_General_Import.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_General_Import.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_General_Import.Controls.Add(Me.Button_General_Import, 2, 0)
        Me.TableLayoutPanel_General_Import.Controls.Add(Me.TextBox_General_Import_Directory, 1, 0)
        Me.TableLayoutPanel_General_Import.Controls.Add(Me.Label_General_Import_Directory, 0, 0)
        Me.TableLayoutPanel_General_Import.Controls.Add(Me.Label_General_Import_Filname, 0, 1)
        Me.TableLayoutPanel_General_Import.Controls.Add(Me.TextBox_General_Import_Filename, 1, 1)
        Me.TableLayoutPanel_General_Import.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel_General_Import.Location = New System.Drawing.Point(0, 13)
        Me.TableLayoutPanel_General_Import.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel_General_Import.Name = "TableLayoutPanel_General_Import"
        Me.TableLayoutPanel_General_Import.RowCount = 2
        Me.TableLayoutPanel_General_Import.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_General_Import.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_General_Import.Size = New System.Drawing.Size(156, 40)
        Me.TableLayoutPanel_General_Import.TabIndex = 0
        '
        'Button_General_Import
        '
        Me.Button_General_Import.AutoSize = True
        Me.Button_General_Import.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_General_Import.ImageKey = "Import"
        Me.Button_General_Import.ImageList = Me.ImageList_Main
        Me.Button_General_Import.Location = New System.Drawing.Point(118, 0)
        Me.Button_General_Import.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_General_Import.Name = "Button_General_Import"
        Me.TableLayoutPanel_General_Import.SetRowSpan(Me.Button_General_Import, 2)
        Me.Button_General_Import.Size = New System.Drawing.Size(38, 38)
        Me.Button_General_Import.TabIndex = 6
        Me.Button_General_Import.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button_General_Import.UseCompatibleTextRendering = True
        Me.Button_General_Import.UseVisualStyleBackColor = True
        '
        'Label_General_Import_Directory
        '
        Me.Label_General_Import_Directory.AutoSize = True
        Me.Label_General_Import_Directory.Location = New System.Drawing.Point(0, 0)
        Me.Label_General_Import_Directory.Margin = New System.Windows.Forms.Padding(0)
        Me.Label_General_Import_Directory.Name = "Label_General_Import_Directory"
        Me.Label_General_Import_Directory.Size = New System.Drawing.Size(39, 17)
        Me.Label_General_Import_Directory.TabIndex = 3
        Me.Label_General_Import_Directory.Text = "Ordner"
        Me.Label_General_Import_Directory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_General_Import_Directory.UseCompatibleTextRendering = True
        '
        'Label_General_Import_Filname
        '
        Me.Label_General_Import_Filname.AutoSize = True
        Me.Label_General_Import_Filname.Location = New System.Drawing.Point(0, 20)
        Me.Label_General_Import_Filname.Margin = New System.Windows.Forms.Padding(0)
        Me.Label_General_Import_Filname.Name = "Label_General_Import_Filname"
        Me.Label_General_Import_Filname.Size = New System.Drawing.Size(59, 17)
        Me.Label_General_Import_Filname.TabIndex = 8
        Me.Label_General_Import_Filname.Text = "Dateiname"
        Me.Label_General_Import_Filname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_General_Import_Filname.UseCompatibleTextRendering = True
        '
        'TextBox_General_Import_Filename
        '
        Me.TextBox_General_Import_Filename.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox_General_Import_Filename.Enabled = False
        Me.TextBox_General_Import_Filename.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_General_Import_Filename.Location = New System.Drawing.Point(59, 20)
        Me.TextBox_General_Import_Filename.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox_General_Import_Filename.Name = "TextBox_General_Import_Filename"
        Me.TextBox_General_Import_Filename.Size = New System.Drawing.Size(59, 20)
        Me.TextBox_General_Import_Filename.TabIndex = 7
        '
        'GroupBox_General_Export
        '
        Me.GroupBox_General_Export.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox_General_Export.Controls.Add(Me.TableLayoutPanel_General_Export)
        Me.GroupBox_General_Export.Location = New System.Drawing.Point(0, 106)
        Me.GroupBox_General_Export.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox_General_Export.Name = "GroupBox_General_Export"
        Me.GroupBox_General_Export.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox_General_Export.Size = New System.Drawing.Size(156, 53)
        Me.GroupBox_General_Export.TabIndex = 3
        Me.GroupBox_General_Export.TabStop = False
        Me.GroupBox_General_Export.Text = "Export"
        Me.GroupBox_General_Export.UseCompatibleTextRendering = True
        '
        'TableLayoutPanel_General_Export
        '
        Me.TableLayoutPanel_General_Export.AutoSize = True
        Me.TableLayoutPanel_General_Export.ColumnCount = 3
        Me.TableLayoutPanel_General_Export.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_General_Export.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_General_Export.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_General_Export.Controls.Add(Me.TextBox_General_Export_Filename, 1, 1)
        Me.TableLayoutPanel_General_Export.Controls.Add(Me.Label_General_Export_Filname, 0, 1)
        Me.TableLayoutPanel_General_Export.Controls.Add(Me.Label_General_Export_Directory, 0, 0)
        Me.TableLayoutPanel_General_Export.Controls.Add(Me.TextBox_General_Export_Directory, 1, 0)
        Me.TableLayoutPanel_General_Export.Controls.Add(Me.Button_General_Export, 2, 0)
        Me.TableLayoutPanel_General_Export.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel_General_Export.Location = New System.Drawing.Point(0, 13)
        Me.TableLayoutPanel_General_Export.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel_General_Export.Name = "TableLayoutPanel_General_Export"
        Me.TableLayoutPanel_General_Export.RowCount = 2
        Me.TableLayoutPanel_General_Export.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_General_Export.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_General_Export.Size = New System.Drawing.Size(156, 40)
        Me.TableLayoutPanel_General_Export.TabIndex = 0
        '
        'TextBox_General_Export_Filename
        '
        Me.TextBox_General_Export_Filename.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox_General_Export_Filename.Enabled = False
        Me.TextBox_General_Export_Filename.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_General_Export_Filename.Location = New System.Drawing.Point(59, 20)
        Me.TextBox_General_Export_Filename.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox_General_Export_Filename.Name = "TextBox_General_Export_Filename"
        Me.TextBox_General_Export_Filename.Size = New System.Drawing.Size(59, 20)
        Me.TextBox_General_Export_Filename.TabIndex = 13
        '
        'Label_General_Export_Filname
        '
        Me.Label_General_Export_Filname.AutoSize = True
        Me.Label_General_Export_Filname.Location = New System.Drawing.Point(0, 20)
        Me.Label_General_Export_Filname.Margin = New System.Windows.Forms.Padding(0)
        Me.Label_General_Export_Filname.Name = "Label_General_Export_Filname"
        Me.Label_General_Export_Filname.Size = New System.Drawing.Size(59, 17)
        Me.Label_General_Export_Filname.TabIndex = 12
        Me.Label_General_Export_Filname.Text = "Dateiname"
        Me.Label_General_Export_Filname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_General_Export_Filname.UseCompatibleTextRendering = True
        '
        'Button_General_Export
        '
        Me.Button_General_Export.AutoSize = True
        Me.Button_General_Export.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_General_Export.ImageKey = "File_Printer"
        Me.Button_General_Export.ImageList = Me.ImageList_Main
        Me.Button_General_Export.Location = New System.Drawing.Point(118, 0)
        Me.Button_General_Export.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_General_Export.Name = "Button_General_Export"
        Me.TableLayoutPanel_General_Export.SetRowSpan(Me.Button_General_Export, 2)
        Me.Button_General_Export.Size = New System.Drawing.Size(38, 38)
        Me.Button_General_Export.TabIndex = 7
        Me.Button_General_Export.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button_General_Export.UseCompatibleTextRendering = True
        Me.Button_General_Export.UseVisualStyleBackColor = True
        '
        'TabPage_Paper
        '
        Me.TabPage_Paper.AutoScroll = True
        Me.TabPage_Paper.Controls.Add(Me.TableLayoutPanel_Paper)
        Me.TabPage_Paper.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Paper.Name = "TabPage_Paper"
        Me.TabPage_Paper.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Paper.Size = New System.Drawing.Size(275, 348)
        Me.TabPage_Paper.TabIndex = 0
        Me.TabPage_Paper.Text = "Papier"
        Me.TabPage_Paper.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_Paper
        '
        Me.TableLayoutPanel_Paper.AutoScroll = True
        Me.TableLayoutPanel_Paper.ColumnCount = 1
        Me.TableLayoutPanel_Paper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Paper.Controls.Add(Me.GroupBox_Paper_Shema, 0, 0)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.GroupBox_Separatoren, 0, 2)
        Me.TableLayoutPanel_Paper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_Paper.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel_Paper.Name = "TableLayoutPanel_Paper"
        Me.TableLayoutPanel_Paper.RowCount = 5
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.Size = New System.Drawing.Size(269, 342)
        Me.TableLayoutPanel_Paper.TabIndex = 45
        '
        'GroupBox_Paper_Shema
        '
        Me.GroupBox_Paper_Shema.AutoSize = True
        Me.GroupBox_Paper_Shema.Controls.Add(Me.TableLayoutPanel_Paper_Shema)
        Me.GroupBox_Paper_Shema.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox_Paper_Shema.Name = "GroupBox_Paper_Shema"
        Me.GroupBox_Paper_Shema.Size = New System.Drawing.Size(161, 133)
        Me.GroupBox_Paper_Shema.TabIndex = 0
        Me.GroupBox_Paper_Shema.TabStop = False
        Me.GroupBox_Paper_Shema.Text = "Shema"
        '
        'TableLayoutPanel_Paper_Shema
        '
        Me.TableLayoutPanel_Paper_Shema.AutoSize = True
        Me.TableLayoutPanel_Paper_Shema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel_Paper_Shema.ColumnCount = 3
        Me.TableLayoutPanel_Paper_Shema.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Paper_Shema.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Paper_Shema.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Paper_Shema.Controls.Add(Me.Label_Paper_Width_Unit, 2, 4)
        Me.TableLayoutPanel_Paper_Shema.Controls.Add(Me.Label_Paper_Height_Unit, 2, 3)
        Me.TableLayoutPanel_Paper_Shema.Controls.Add(Me.Label_Paper_Width_Value, 1, 4)
        Me.TableLayoutPanel_Paper_Shema.Controls.Add(Me.Label_Paper_Shema, 0, 0)
        Me.TableLayoutPanel_Paper_Shema.Controls.Add(Me.Label_Paper_Height_Value, 1, 3)
        Me.TableLayoutPanel_Paper_Shema.Controls.Add(Me.ComboBox_Paper_DPI, 1, 1)
        Me.TableLayoutPanel_Paper_Shema.Controls.Add(Me.Label_Paper_Width, 0, 4)
        Me.TableLayoutPanel_Paper_Shema.Controls.Add(Me.TextBox_Paper_Shema, 1, 0)
        Me.TableLayoutPanel_Paper_Shema.Controls.Add(Me.Label_Paper_Height, 0, 3)
        Me.TableLayoutPanel_Paper_Shema.Controls.Add(Me.Label_Paper_DPI, 0, 1)
        Me.TableLayoutPanel_Paper_Shema.Controls.Add(Me.Label_Paper_DIN, 0, 2)
        Me.TableLayoutPanel_Paper_Shema.Controls.Add(Me.ComboBox_Paper_DIN, 1, 2)
        Me.TableLayoutPanel_Paper_Shema.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_Paper_Shema.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel_Paper_Shema.Name = "TableLayoutPanel_Paper_Shema"
        Me.TableLayoutPanel_Paper_Shema.RowCount = 5
        Me.TableLayoutPanel_Paper_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Paper_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Paper_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Paper_Shema.Size = New System.Drawing.Size(155, 114)
        Me.TableLayoutPanel_Paper_Shema.TabIndex = 0
        '
        'Label_Paper_Width_Unit
        '
        Me.Label_Paper_Width_Unit.AutoSize = True
        Me.Label_Paper_Width_Unit.Location = New System.Drawing.Point(106, 97)
        Me.Label_Paper_Width_Unit.Name = "Label_Paper_Width_Unit"
        Me.Label_Paper_Width_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Paper_Width_Unit.TabIndex = 9
        Me.Label_Paper_Width_Unit.Text = "mm"
        Me.Label_Paper_Width_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Width_Unit.UseCompatibleTextRendering = True
        '
        'Label_Paper_Height_Unit
        '
        Me.Label_Paper_Height_Unit.AutoSize = True
        Me.Label_Paper_Height_Unit.Location = New System.Drawing.Point(106, 80)
        Me.Label_Paper_Height_Unit.Name = "Label_Paper_Height_Unit"
        Me.Label_Paper_Height_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Paper_Height_Unit.TabIndex = 8
        Me.Label_Paper_Height_Unit.Text = "mm"
        Me.Label_Paper_Height_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Height_Unit.UseCompatibleTextRendering = True
        '
        'Label_Paper_Width_Value
        '
        Me.Label_Paper_Width_Value.AutoSize = True
        Me.Label_Paper_Width_Value.Location = New System.Drawing.Point(43, 97)
        Me.Label_Paper_Width_Value.Name = "Label_Paper_Width_Value"
        Me.Label_Paper_Width_Value.Size = New System.Drawing.Size(25, 13)
        Me.Label_Paper_Width_Value.TabIndex = 47
        Me.Label_Paper_Width_Value.Text = "PW"
        '
        'Label_Paper_Shema
        '
        Me.Label_Paper_Shema.AutoSize = True
        Me.Label_Paper_Shema.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Paper_Shema.Location = New System.Drawing.Point(3, 0)
        Me.Label_Paper_Shema.Name = "Label_Paper_Shema"
        Me.Label_Paper_Shema.Size = New System.Drawing.Size(34, 17)
        Me.Label_Paper_Shema.TabIndex = 0
        Me.Label_Paper_Shema.Text = "Name"
        Me.Label_Paper_Shema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Shema.UseCompatibleTextRendering = True
        '
        'Label_Paper_Height_Value
        '
        Me.Label_Paper_Height_Value.AutoSize = True
        Me.Label_Paper_Height_Value.Location = New System.Drawing.Point(43, 80)
        Me.Label_Paper_Height_Value.Name = "Label_Paper_Height_Value"
        Me.Label_Paper_Height_Value.Size = New System.Drawing.Size(22, 13)
        Me.Label_Paper_Height_Value.TabIndex = 46
        Me.Label_Paper_Height_Value.Text = "PH"
        '
        'ComboBox_Paper_DPI
        '
        Me.ComboBox_Paper_DPI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_Paper_DPI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_Paper_DPI.FormattingEnabled = True
        Me.ComboBox_Paper_DPI.Location = New System.Drawing.Point(43, 29)
        Me.ComboBox_Paper_DPI.Name = "ComboBox_Paper_DPI"
        Me.ComboBox_Paper_DPI.Size = New System.Drawing.Size(57, 21)
        Me.ComboBox_Paper_DPI.TabIndex = 0
        Me.ComboBox_Paper_DPI.Tag = "DPI"
        '
        'TextBox_Paper_Shema
        '
        Me.TextBox_Paper_Shema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel_Paper_Shema.SetColumnSpan(Me.TextBox_Paper_Shema, 2)
        Me.TextBox_Paper_Shema.Location = New System.Drawing.Point(43, 3)
        Me.TextBox_Paper_Shema.Name = "TextBox_Paper_Shema"
        Me.TextBox_Paper_Shema.Size = New System.Drawing.Size(109, 20)
        Me.TextBox_Paper_Shema.TabIndex = 0
        Me.TextBox_Paper_Shema.Tag = "Shema"
        '
        'ComboBox_Paper_DIN
        '
        Me.ComboBox_Paper_DIN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_Paper_DIN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_Paper_DIN.DropDownWidth = 200
        Me.ComboBox_Paper_DIN.FormattingEnabled = True
        Me.ComboBox_Paper_DIN.Location = New System.Drawing.Point(43, 56)
        Me.ComboBox_Paper_DIN.Name = "ComboBox_Paper_DIN"
        Me.ComboBox_Paper_DIN.Size = New System.Drawing.Size(57, 21)
        Me.ComboBox_Paper_DIN.TabIndex = 1
        Me.ComboBox_Paper_DIN.Tag = "DIN"
        '
        'TabPage_Card
        '
        Me.TabPage_Card.AutoScroll = True
        Me.TabPage_Card.Controls.Add(Me.TableLayoutPanel_Card)
        Me.TabPage_Card.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Card.Name = "TabPage_Card"
        Me.TabPage_Card.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Card.Size = New System.Drawing.Size(275, 348)
        Me.TabPage_Card.TabIndex = 6
        Me.TabPage_Card.Text = "Karte"
        Me.TabPage_Card.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_Card
        '
        Me.TableLayoutPanel_Card.ColumnCount = 1
        Me.TableLayoutPanel_Card.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card.Controls.Add(Me.GroupBox_Card_Size, 0, 2)
        Me.TableLayoutPanel_Card.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_Card.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel_Card.Name = "TableLayoutPanel_Card"
        Me.TableLayoutPanel_Card.RowCount = 3
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card.Size = New System.Drawing.Size(269, 342)
        Me.TableLayoutPanel_Card.TabIndex = 3
        '
        'GroupBox_Card_Size
        '
        Me.GroupBox_Card_Size.Controls.Add(Me.TableLayoutPanel_Card_Size)
        Me.GroupBox_Card_Size.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox_Card_Size.Name = "GroupBox_Card_Size"
        Me.GroupBox_Card_Size.Size = New System.Drawing.Size(103, 70)
        Me.GroupBox_Card_Size.TabIndex = 4
        Me.GroupBox_Card_Size.TabStop = False
        Me.GroupBox_Card_Size.Text = "Größe"
        '
        'TableLayoutPanel_Card_Size
        '
        Me.TableLayoutPanel_Card_Size.ColumnCount = 3
        Me.TableLayoutPanel_Card_Size.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card_Size.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card_Size.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card_Size.Controls.Add(Me.Label_Card_Size_Width_Unit, 2, 1)
        Me.TableLayoutPanel_Card_Size.Controls.Add(Me.Label_Card_Size_Hight_Unit, 2, 0)
        Me.TableLayoutPanel_Card_Size.Controls.Add(Me.Label_Card_Size_Hight, 0, 0)
        Me.TableLayoutPanel_Card_Size.Controls.Add(Me.Label_Card_Size_Hight_Value, 1, 0)
        Me.TableLayoutPanel_Card_Size.Controls.Add(Me.Label_Card_Size_Width, 0, 1)
        Me.TableLayoutPanel_Card_Size.Controls.Add(Me.Label_Card_Size_Width_Value, 1, 1)
        Me.TableLayoutPanel_Card_Size.Location = New System.Drawing.Point(0, 19)
        Me.TableLayoutPanel_Card_Size.Name = "TableLayoutPanel_Card_Size"
        Me.TableLayoutPanel_Card_Size.RowCount = 2
        Me.TableLayoutPanel_Card_Size.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card_Size.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card_Size.Size = New System.Drawing.Size(95, 43)
        Me.TableLayoutPanel_Card_Size.TabIndex = 0
        '
        'Label_Card_Size_Width_Unit
        '
        Me.Label_Card_Size_Width_Unit.AutoSize = True
        Me.Label_Card_Size_Width_Unit.Location = New System.Drawing.Point(59, 17)
        Me.Label_Card_Size_Width_Unit.Name = "Label_Card_Size_Width_Unit"
        Me.Label_Card_Size_Width_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Card_Size_Width_Unit.TabIndex = 51
        Me.Label_Card_Size_Width_Unit.Text = "mm"
        Me.Label_Card_Size_Width_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Size_Width_Unit.UseCompatibleTextRendering = True
        '
        'Label_Card_Size_Hight_Unit
        '
        Me.Label_Card_Size_Hight_Unit.AutoSize = True
        Me.Label_Card_Size_Hight_Unit.Location = New System.Drawing.Point(59, 0)
        Me.Label_Card_Size_Hight_Unit.Name = "Label_Card_Size_Hight_Unit"
        Me.Label_Card_Size_Hight_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Card_Size_Hight_Unit.TabIndex = 52
        Me.Label_Card_Size_Hight_Unit.Text = "mm"
        Me.Label_Card_Size_Hight_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Size_Hight_Unit.UseCompatibleTextRendering = True
        '
        'Label_Card_Size_Hight
        '
        Me.Label_Card_Size_Hight.AutoSize = True
        Me.Label_Card_Size_Hight.Location = New System.Drawing.Point(3, 0)
        Me.Label_Card_Size_Hight.Name = "Label_Card_Size_Hight"
        Me.Label_Card_Size_Hight.Size = New System.Drawing.Size(31, 17)
        Me.Label_Card_Size_Hight.TabIndex = 28
        Me.Label_Card_Size_Hight.Text = "Höhe"
        Me.Label_Card_Size_Hight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Size_Hight.UseCompatibleTextRendering = True
        '
        'Label_Card_Size_Hight_Value
        '
        Me.Label_Card_Size_Hight_Value.AutoSize = True
        Me.Label_Card_Size_Hight_Value.Location = New System.Drawing.Point(43, 0)
        Me.Label_Card_Size_Hight_Value.Name = "Label_Card_Size_Hight_Value"
        Me.Label_Card_Size_Hight_Value.Size = New System.Drawing.Size(10, 17)
        Me.Label_Card_Size_Hight_Value.TabIndex = 29
        Me.Label_Card_Size_Hight_Value.Text = "0"
        Me.Label_Card_Size_Hight_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Size_Hight_Value.UseCompatibleTextRendering = True
        '
        'Label_Card_Size_Width
        '
        Me.Label_Card_Size_Width.AutoSize = True
        Me.Label_Card_Size_Width.Location = New System.Drawing.Point(3, 17)
        Me.Label_Card_Size_Width.Name = "Label_Card_Size_Width"
        Me.Label_Card_Size_Width.Size = New System.Drawing.Size(34, 17)
        Me.Label_Card_Size_Width.TabIndex = 29
        Me.Label_Card_Size_Width.Text = "Breite"
        Me.Label_Card_Size_Width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Size_Width.UseCompatibleTextRendering = True
        '
        'Label_Card_Size_Width_Value
        '
        Me.Label_Card_Size_Width_Value.AutoSize = True
        Me.Label_Card_Size_Width_Value.Location = New System.Drawing.Point(43, 17)
        Me.Label_Card_Size_Width_Value.Name = "Label_Card_Size_Width_Value"
        Me.Label_Card_Size_Width_Value.Size = New System.Drawing.Size(10, 17)
        Me.Label_Card_Size_Width_Value.TabIndex = 30
        Me.Label_Card_Size_Width_Value.Text = "0"
        Me.Label_Card_Size_Width_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Size_Width_Value.UseCompatibleTextRendering = True
        '
        'TabPage_CardRow
        '
        Me.TabPage_CardRow.AutoScroll = True
        Me.TabPage_CardRow.Controls.Add(Me.TableLayoutPanel_CardRow)
        Me.TabPage_CardRow.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_CardRow.Name = "TabPage_CardRow"
        Me.TabPage_CardRow.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_CardRow.Size = New System.Drawing.Size(371, 348)
        Me.TabPage_CardRow.TabIndex = 7
        Me.TabPage_CardRow.Text = "Zeile"
        Me.TabPage_CardRow.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_CardRow
        '
        Me.TableLayoutPanel_CardRow.AutoScroll = True
        Me.TableLayoutPanel_CardRow.AutoSize = True
        Me.TableLayoutPanel_CardRow.ColumnCount = 1
        Me.TableLayoutPanel_CardRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_CardRow.Controls.Add(Me.GroupBox_CardRow_Line, 0, 1)
        Me.TableLayoutPanel_CardRow.Controls.Add(Me.GroupBox_CardRow_List, 0, 0)
        Me.TableLayoutPanel_CardRow.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel_CardRow.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel_CardRow.Name = "TableLayoutPanel_CardRow"
        Me.TableLayoutPanel_CardRow.RowCount = 4
        Me.TableLayoutPanel_CardRow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_CardRow.Size = New System.Drawing.Size(272, 308)
        Me.TableLayoutPanel_CardRow.TabIndex = 5
        '
        'GroupBox_CardRow_Line
        '
        Me.GroupBox_CardRow_Line.AutoSize = True
        Me.GroupBox_CardRow_Line.Controls.Add(Me.TableLayoutPanel_CardRow_Line)
        Me.GroupBox_CardRow_Line.Location = New System.Drawing.Point(3, 104)
        Me.GroupBox_CardRow_Line.Name = "GroupBox_CardRow_Line"
        Me.GroupBox_CardRow_Line.Size = New System.Drawing.Size(230, 159)
        Me.GroupBox_CardRow_Line.TabIndex = 0
        Me.GroupBox_CardRow_Line.TabStop = False
        Me.GroupBox_CardRow_Line.Text = "Lines"
        Me.GroupBox_CardRow_Line.UseCompatibleTextRendering = True
        '
        'TableLayoutPanel_CardRow_Line
        '
        Me.TableLayoutPanel_CardRow_Line.AutoSize = True
        Me.TableLayoutPanel_CardRow_Line.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel_CardRow_Line.ColumnCount = 3
        Me.TableLayoutPanel_CardRow_Line.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_CardRow_Line.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_CardRow_Line.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_CardRow_Line.Controls.Add(Me.Label_CardRow_LinePos_Value, 1, 1)
        Me.TableLayoutPanel_CardRow_Line.Controls.Add(Me.Label_CardRow_DataColumn, 0, 4)
        Me.TableLayoutPanel_CardRow_Line.Controls.Add(Me.ComboBox_CardRow_DataColumn, 1, 4)
        Me.TableLayoutPanel_CardRow_Line.Controls.Add(Me.Label_CardRow_AutoFont, 0, 3)
        Me.TableLayoutPanel_CardRow_Line.Controls.Add(Me.CheckBox_CardRow_AutoFont, 1, 3)
        Me.TableLayoutPanel_CardRow_Line.Controls.Add(Me.Label_CardRow_QRCode, 0, 2)
        Me.TableLayoutPanel_CardRow_Line.Controls.Add(Me.CheckBox_CardRow_QRCode, 1, 2)
        Me.TableLayoutPanel_CardRow_Line.Controls.Add(Me.Label_CardRow_LinePos, 0, 1)
        Me.TableLayoutPanel_CardRow_Line.Controls.Add(Me.Label_CardRow_FontColor, 0, 5)
        Me.TableLayoutPanel_CardRow_Line.Controls.Add(Me.Button_CardRow_FontColor, 1, 5)
        Me.TableLayoutPanel_CardRow_Line.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel_CardRow_Line.Name = "TableLayoutPanel_CardRow_Line"
        Me.TableLayoutPanel_CardRow_Line.RowCount = 6
        Me.TableLayoutPanel_CardRow_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow_Line.Size = New System.Drawing.Size(218, 121)
        Me.TableLayoutPanel_CardRow_Line.TabIndex = 28
        '
        'Label_CardRow_LinePos_Value
        '
        Me.Label_CardRow_LinePos_Value.AutoSize = True
        Me.Label_CardRow_LinePos_Value.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_CardRow_LinePos_Value.Location = New System.Drawing.Point(78, 2)
        Me.Label_CardRow_LinePos_Value.Name = "Label_CardRow_LinePos_Value"
        Me.Label_CardRow_LinePos_Value.Size = New System.Drawing.Size(135, 17)
        Me.Label_CardRow_LinePos_Value.TabIndex = 11
        Me.Label_CardRow_LinePos_Value.Text = "0"
        Me.Label_CardRow_LinePos_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_CardRow_DataColumn
        '
        Me.Label_CardRow_DataColumn.AutoSize = True
        Me.Label_CardRow_DataColumn.Location = New System.Drawing.Point(4, 62)
        Me.Label_CardRow_DataColumn.Name = "Label_CardRow_DataColumn"
        Me.Label_CardRow_DataColumn.Size = New System.Drawing.Size(67, 17)
        Me.Label_CardRow_DataColumn.TabIndex = 18
        Me.Label_CardRow_DataColumn.Text = "DataColumn"
        Me.Label_CardRow_DataColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_DataColumn.UseCompatibleTextRendering = True
        '
        'ComboBox_CardRow_DataColumn
        '
        Me.ComboBox_CardRow_DataColumn.FormattingEnabled = True
        Me.ComboBox_CardRow_DataColumn.Location = New System.Drawing.Point(78, 65)
        Me.ComboBox_CardRow_DataColumn.Name = "ComboBox_CardRow_DataColumn"
        Me.ComboBox_CardRow_DataColumn.Size = New System.Drawing.Size(91, 21)
        Me.ComboBox_CardRow_DataColumn.TabIndex = 27
        '
        'Label_CardRow_AutoFont
        '
        Me.Label_CardRow_AutoFont.AutoSize = True
        Me.Label_CardRow_AutoFont.Location = New System.Drawing.Point(4, 41)
        Me.Label_CardRow_AutoFont.Name = "Label_CardRow_AutoFont"
        Me.Label_CardRow_AutoFont.Size = New System.Drawing.Size(50, 17)
        Me.Label_CardRow_AutoFont.TabIndex = 26
        Me.Label_CardRow_AutoFont.Text = "AutoFont"
        Me.Label_CardRow_AutoFont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_AutoFont.UseCompatibleTextRendering = True
        '
        'CheckBox_CardRow_AutoFont
        '
        Me.CheckBox_CardRow_AutoFont.AutoSize = True
        Me.CheckBox_CardRow_AutoFont.Location = New System.Drawing.Point(78, 44)
        Me.CheckBox_CardRow_AutoFont.Name = "CheckBox_CardRow_AutoFont"
        Me.CheckBox_CardRow_AutoFont.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox_CardRow_AutoFont.TabIndex = 25
        Me.CheckBox_CardRow_AutoFont.UseVisualStyleBackColor = True
        '
        'Label_CardRow_QRCode
        '
        Me.Label_CardRow_QRCode.AutoSize = True
        Me.Label_CardRow_QRCode.Location = New System.Drawing.Point(4, 20)
        Me.Label_CardRow_QRCode.Name = "Label_CardRow_QRCode"
        Me.Label_CardRow_QRCode.Size = New System.Drawing.Size(48, 17)
        Me.Label_CardRow_QRCode.TabIndex = 19
        Me.Label_CardRow_QRCode.Text = "QRCode"
        Me.Label_CardRow_QRCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_QRCode.UseCompatibleTextRendering = True
        '
        'CheckBox_CardRow_QRCode
        '
        Me.CheckBox_CardRow_QRCode.AutoSize = True
        Me.CheckBox_CardRow_QRCode.Location = New System.Drawing.Point(78, 23)
        Me.CheckBox_CardRow_QRCode.Name = "CheckBox_CardRow_QRCode"
        Me.CheckBox_CardRow_QRCode.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox_CardRow_QRCode.TabIndex = 24
        Me.CheckBox_CardRow_QRCode.UseVisualStyleBackColor = True
        '
        'Label_CardRow_LinePos
        '
        Me.Label_CardRow_LinePos.AutoSize = True
        Me.Label_CardRow_LinePos.Location = New System.Drawing.Point(4, 2)
        Me.Label_CardRow_LinePos.Name = "Label_CardRow_LinePos"
        Me.Label_CardRow_LinePos.Size = New System.Drawing.Size(45, 17)
        Me.Label_CardRow_LinePos.TabIndex = 23
        Me.Label_CardRow_LinePos.Text = "LinePos"
        Me.Label_CardRow_LinePos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_LinePos.UseCompatibleTextRendering = True
        '
        'Label_CardRow_FontColor
        '
        Me.Label_CardRow_FontColor.AutoSize = True
        Me.Label_CardRow_FontColor.Location = New System.Drawing.Point(4, 90)
        Me.Label_CardRow_FontColor.Name = "Label_CardRow_FontColor"
        Me.Label_CardRow_FontColor.Size = New System.Drawing.Size(62, 17)
        Me.Label_CardRow_FontColor.TabIndex = 28
        Me.Label_CardRow_FontColor.Text = "Schriftfarbe"
        Me.Label_CardRow_FontColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_FontColor.UseCompatibleTextRendering = True
        '
        'Button_CardRow_FontColor
        '
        Me.Button_CardRow_FontColor.AutoSize = True
        Me.Button_CardRow_FontColor.ForeColor = System.Drawing.Color.Black
        Me.Button_CardRow_FontColor.Location = New System.Drawing.Point(75, 90)
        Me.Button_CardRow_FontColor.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_CardRow_FontColor.Name = "Button_CardRow_FontColor"
        Me.Button_CardRow_FontColor.Size = New System.Drawing.Size(95, 30)
        Me.Button_CardRow_FontColor.TabIndex = 29
        Me.Button_CardRow_FontColor.Text = "Schriftfarbe"
        Me.Button_CardRow_FontColor.UseVisualStyleBackColor = True
        '
        'GroupBox_CardRow_List
        '
        Me.GroupBox_CardRow_List.AutoSize = True
        Me.GroupBox_CardRow_List.Controls.Add(Me.TableLayoutPanel_CardRow_ListBox)
        Me.GroupBox_CardRow_List.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox_CardRow_List.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox_CardRow_List.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox_CardRow_List.Name = "GroupBox_CardRow_List"
        Me.GroupBox_CardRow_List.Size = New System.Drawing.Size(272, 101)
        Me.GroupBox_CardRow_List.TabIndex = 5
        Me.GroupBox_CardRow_List.TabStop = False
        Me.GroupBox_CardRow_List.Text = "Zeilen"
        '
        'TableLayoutPanel_CardRow_ListBox
        '
        Me.TableLayoutPanel_CardRow_ListBox.AutoSize = True
        Me.TableLayoutPanel_CardRow_ListBox.ColumnCount = 2
        Me.TableLayoutPanel_CardRow_ListBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_CardRow_ListBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_CardRow_ListBox.Controls.Add(Me.ListBox_CardRow, 0, 0)
        Me.TableLayoutPanel_CardRow_ListBox.Controls.Add(Me.FlowLayoutPanel_CardRow_TopDown, 1, 0)
        Me.TableLayoutPanel_CardRow_ListBox.Controls.Add(Me.FlowLayoutPanel_CardRow_Row, 0, 1)
        Me.TableLayoutPanel_CardRow_ListBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel_CardRow_ListBox.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel_CardRow_ListBox.Name = "TableLayoutPanel_CardRow_ListBox"
        Me.TableLayoutPanel_CardRow_ListBox.RowCount = 2
        Me.TableLayoutPanel_CardRow_ListBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_CardRow_ListBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow_ListBox.Size = New System.Drawing.Size(266, 82)
        Me.TableLayoutPanel_CardRow_ListBox.TabIndex = 6
        '
        'ListBox_CardRow
        '
        Me.ListBox_CardRow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox_CardRow.FormattingEnabled = True
        Me.ListBox_CardRow.Location = New System.Drawing.Point(3, 3)
        Me.ListBox_CardRow.Name = "ListBox_CardRow"
        Me.ListBox_CardRow.Size = New System.Drawing.Size(216, 38)
        Me.ListBox_CardRow.TabIndex = 1
        '
        'FlowLayoutPanel_CardRow_TopDown
        '
        Me.FlowLayoutPanel_CardRow_TopDown.AutoSize = True
        Me.FlowLayoutPanel_CardRow_TopDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel_CardRow_TopDown.Controls.Add(Me.Button_CardRow_Up)
        Me.FlowLayoutPanel_CardRow_TopDown.Controls.Add(Me.Button_CardRow_Down)
        Me.FlowLayoutPanel_CardRow_TopDown.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel_CardRow_TopDown.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel_CardRow_TopDown.Location = New System.Drawing.Point(225, 3)
        Me.FlowLayoutPanel_CardRow_TopDown.Name = "FlowLayoutPanel_CardRow_TopDown"
        Me.TableLayoutPanel_CardRow_ListBox.SetRowSpan(Me.FlowLayoutPanel_CardRow_TopDown, 2)
        Me.FlowLayoutPanel_CardRow_TopDown.Size = New System.Drawing.Size(38, 76)
        Me.FlowLayoutPanel_CardRow_TopDown.TabIndex = 5
        Me.FlowLayoutPanel_CardRow_TopDown.WrapContents = False
        '
        'Button_CardRow_Up
        '
        Me.Button_CardRow_Up.AutoSize = True
        Me.Button_CardRow_Up.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button_CardRow_Up.Enabled = False
        Me.Button_CardRow_Up.ImageKey = "Arrow_Green_Up"
        Me.Button_CardRow_Up.ImageList = Me.ImageList_Main
        Me.Button_CardRow_Up.Location = New System.Drawing.Point(0, 0)
        Me.Button_CardRow_Up.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_CardRow_Up.Name = "Button_CardRow_Up"
        Me.Button_CardRow_Up.Size = New System.Drawing.Size(38, 38)
        Me.Button_CardRow_Up.TabIndex = 0
        Me.Button_CardRow_Up.UseCompatibleTextRendering = True
        Me.Button_CardRow_Up.UseVisualStyleBackColor = False
        '
        'Button_CardRow_Down
        '
        Me.Button_CardRow_Down.AutoSize = True
        Me.Button_CardRow_Down.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button_CardRow_Down.Enabled = False
        Me.Button_CardRow_Down.ImageKey = "Arrow_Green_Down"
        Me.Button_CardRow_Down.ImageList = Me.ImageList_Main
        Me.Button_CardRow_Down.Location = New System.Drawing.Point(0, 38)
        Me.Button_CardRow_Down.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_CardRow_Down.Name = "Button_CardRow_Down"
        Me.Button_CardRow_Down.Size = New System.Drawing.Size(38, 38)
        Me.Button_CardRow_Down.TabIndex = 1
        Me.Button_CardRow_Down.UseCompatibleTextRendering = True
        Me.Button_CardRow_Down.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel_CardRow_Row
        '
        Me.FlowLayoutPanel_CardRow_Row.AutoScroll = True
        Me.FlowLayoutPanel_CardRow_Row.AutoSize = True
        Me.FlowLayoutPanel_CardRow_Row.Controls.Add(Me.Button_CardRow_Save)
        Me.FlowLayoutPanel_CardRow_Row.Controls.Add(Me.Button_CardRow_Add)
        Me.FlowLayoutPanel_CardRow_Row.Controls.Add(Me.Button_CardRow_Delete)
        Me.FlowLayoutPanel_CardRow_Row.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel_CardRow_Row.Location = New System.Drawing.Point(0, 44)
        Me.FlowLayoutPanel_CardRow_Row.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel_CardRow_Row.Name = "FlowLayoutPanel_CardRow_Row"
        Me.FlowLayoutPanel_CardRow_Row.Size = New System.Drawing.Size(146, 38)
        Me.FlowLayoutPanel_CardRow_Row.TabIndex = 4
        Me.FlowLayoutPanel_CardRow_Row.WrapContents = False
        '
        'Button_CardRow_Save
        '
        Me.Button_CardRow_Save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button_CardRow_Save.AutoSize = True
        Me.Button_CardRow_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button_CardRow_Save.Enabled = False
        Me.Button_CardRow_Save.ImageKey = "Edit"
        Me.Button_CardRow_Save.ImageList = Me.ImageList_Main
        Me.Button_CardRow_Save.Location = New System.Drawing.Point(0, 0)
        Me.Button_CardRow_Save.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_CardRow_Save.Name = "Button_CardRow_Save"
        Me.Button_CardRow_Save.Size = New System.Drawing.Size(38, 38)
        Me.Button_CardRow_Save.TabIndex = 5
        Me.Button_CardRow_Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_CardRow_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_CardRow_Save.UseCompatibleTextRendering = True
        Me.Button_CardRow_Save.UseVisualStyleBackColor = False
        '
        'Button_CardRow_Add
        '
        Me.Button_CardRow_Add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button_CardRow_Add.AutoSize = True
        Me.Button_CardRow_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button_CardRow_Add.Enabled = False
        Me.Button_CardRow_Add.ImageKey = "Plus"
        Me.Button_CardRow_Add.ImageList = Me.ImageList_Main
        Me.Button_CardRow_Add.Location = New System.Drawing.Point(54, 0)
        Me.Button_CardRow_Add.Margin = New System.Windows.Forms.Padding(16, 0, 16, 0)
        Me.Button_CardRow_Add.Name = "Button_CardRow_Add"
        Me.Button_CardRow_Add.Size = New System.Drawing.Size(38, 38)
        Me.Button_CardRow_Add.TabIndex = 2
        Me.Button_CardRow_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_CardRow_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_CardRow_Add.UseCompatibleTextRendering = True
        Me.Button_CardRow_Add.UseVisualStyleBackColor = False
        '
        'Button_CardRow_Delete
        '
        Me.Button_CardRow_Delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button_CardRow_Delete.AutoSize = True
        Me.Button_CardRow_Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button_CardRow_Delete.Enabled = False
        Me.Button_CardRow_Delete.ImageKey = "Delete_Cross"
        Me.Button_CardRow_Delete.ImageList = Me.ImageList_Main
        Me.Button_CardRow_Delete.Location = New System.Drawing.Point(108, 0)
        Me.Button_CardRow_Delete.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_CardRow_Delete.Name = "Button_CardRow_Delete"
        Me.Button_CardRow_Delete.Size = New System.Drawing.Size(38, 38)
        Me.Button_CardRow_Delete.TabIndex = 3
        Me.Button_CardRow_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_CardRow_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_CardRow_Delete.UseCompatibleTextRendering = True
        Me.Button_CardRow_Delete.UseVisualStyleBackColor = False
        '
        'TabPage_Table
        '
        Me.TabPage_Table.Controls.Add(Me.GroupBox_Table)
        Me.TabPage_Table.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Table.Name = "TabPage_Table"
        Me.TabPage_Table.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Table.Size = New System.Drawing.Size(371, 348)
        Me.TabPage_Table.TabIndex = 4
        Me.TabPage_Table.Text = "Tabellen"
        Me.TabPage_Table.UseVisualStyleBackColor = True
        '
        'GroupBox_Table
        '
        Me.GroupBox_Table.Controls.Add(Me.TableLayoutPanel_Table)
        Me.GroupBox_Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox_Table.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox_Table.Name = "GroupBox_Table"
        Me.GroupBox_Table.Size = New System.Drawing.Size(365, 342)
        Me.GroupBox_Table.TabIndex = 4
        Me.GroupBox_Table.TabStop = False
        Me.GroupBox_Table.Text = "System Tabellen"
        '
        'TableLayoutPanel_Table
        '
        Me.TableLayoutPanel_Table.ColumnCount = 2
        Me.TableLayoutPanel_Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Table.Controls.Add(Me.ListBox_Tabellen, 0, 0)
        Me.TableLayoutPanel_Table.Controls.Add(Me.DGV_Table, 1, 0)
        Me.TableLayoutPanel_Table.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.CSVtoQR.My.MySettings.Default, "MyFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TableLayoutPanel_Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_Table.Font = Global.CSVtoQR.My.MySettings.Default.MyFont
        Me.TableLayoutPanel_Table.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel_Table.Name = "TableLayoutPanel_Table"
        Me.TableLayoutPanel_Table.RowCount = 1
        Me.TableLayoutPanel_Table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Table.Size = New System.Drawing.Size(359, 323)
        Me.TableLayoutPanel_Table.TabIndex = 3
        '
        'ListBox_Tabellen
        '
        Me.ListBox_Tabellen.BackColor = System.Drawing.SystemColors.Control
        Me.ListBox_Tabellen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_Tabellen.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.CSVtoQR.My.MySettings.Default, "MyFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ListBox_Tabellen.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListBox_Tabellen.Font = Global.CSVtoQR.My.MySettings.Default.MyFont
        Me.ListBox_Tabellen.FormattingEnabled = True
        Me.ListBox_Tabellen.Location = New System.Drawing.Point(3, 3)
        Me.ListBox_Tabellen.Name = "ListBox_Tabellen"
        Me.ListBox_Tabellen.Size = New System.Drawing.Size(131, 465)
        Me.ListBox_Tabellen.TabIndex = 2
        '
        'DGV_Table
        '
        Me.DGV_Table.AllowUserToAddRows = False
        Me.DGV_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Table.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.CSVtoQR.My.MySettings.Default, "MyFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DGV_Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Table.Font = Global.CSVtoQR.My.MySettings.Default.MyFont
        Me.DGV_Table.Location = New System.Drawing.Point(140, 3)
        Me.DGV_Table.Name = "DGV_Table"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Table.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Table.RowHeadersWidth = 62
        Me.DGV_Table.Size = New System.Drawing.Size(216, 465)
        Me.DGV_Table.TabIndex = 0
        '
        'Panel_Preview
        '
        Me.Panel_Preview.AutoScroll = True
        Me.Panel_Preview.Controls.Add(Me.PictureBox_Preview)
        Me.Panel_Preview.Location = New System.Drawing.Point(27, 12)
        Me.Panel_Preview.Name = "Panel_Preview"
        Me.Panel_Preview.Size = New System.Drawing.Size(114, 115)
        Me.Panel_Preview.TabIndex = 0
        '
        'PictureBox_Preview
        '
        Me.PictureBox_Preview.BackColor = System.Drawing.Color.FloralWhite
        Me.PictureBox_Preview.Location = New System.Drawing.Point(22, 16)
        Me.PictureBox_Preview.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox_Preview.Name = "PictureBox_Preview"
        Me.PictureBox_Preview.Size = New System.Drawing.Size(68, 53)
        Me.PictureBox_Preview.TabIndex = 45
        Me.PictureBox_Preview.TabStop = False
        '
        'AlleauswählenToolStripMenuItem
        '
        Me.AlleauswählenToolStripMenuItem.Name = "AlleauswählenToolStripMenuItem"
        Me.AlleauswählenToolStripMenuItem.Size = New System.Drawing.Size(199, 30)
        Me.AlleauswählenToolStripMenuItem.Text = "&Alle auswählen"
        '
        'ToolStripSeparator05
        '
        Me.ToolStripSeparator05.Name = "ToolStripSeparator05"
        Me.ToolStripSeparator05.Size = New System.Drawing.Size(196, 6)
        '
        'ToolStripSeparator04
        '
        Me.ToolStripSeparator04.Name = "ToolStripSeparator04"
        Me.ToolStripSeparator04.Size = New System.Drawing.Size(196, 6)
        '
        'ToolStripMenuItem_Wiederholen
        '
        Me.ToolStripMenuItem_Wiederholen.Name = "ToolStripMenuItem_Wiederholen"
        Me.ToolStripMenuItem_Wiederholen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_Wiederholen.Size = New System.Drawing.Size(199, 30)
        Me.ToolStripMenuItem_Wiederholen.Text = "Wiede&rholen"
        '
        'ToolStripMenuItem_Rückgängig
        '
        Me.ToolStripMenuItem_Rückgängig.Name = "ToolStripMenuItem_Rückgängig"
        Me.ToolStripMenuItem_Rückgängig.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_Rückgängig.Size = New System.Drawing.Size(199, 30)
        Me.ToolStripMenuItem_Rückgängig.Text = "&Rückgängig"
        '
        'ToolStripMenuItem_Beenden
        '
        Me.ToolStripMenuItem_Beenden.Name = "ToolStripMenuItem_Beenden"
        Me.ToolStripMenuItem_Beenden.Size = New System.Drawing.Size(176, 30)
        Me.ToolStripMenuItem_Beenden.Text = "&Beenden"
        '
        'ToolStripSeparator03
        '
        Me.ToolStripSeparator03.Name = "ToolStripSeparator03"
        Me.ToolStripSeparator03.Size = New System.Drawing.Size(173, 6)
        '
        'ToolStripSeparator02
        '
        Me.ToolStripSeparator02.Name = "ToolStripSeparator02"
        Me.ToolStripSeparator02.Size = New System.Drawing.Size(173, 6)
        '
        'ToolStripMenuItem_XML_SaveAs
        '
        Me.ToolStripMenuItem_XML_SaveAs.Name = "ToolStripMenuItem_XML_SaveAs"
        Me.ToolStripMenuItem_XML_SaveAs.Size = New System.Drawing.Size(176, 30)
        Me.ToolStripMenuItem_XML_SaveAs.Text = "Speichern &unter"
        '
        'ToolStripSeparator01
        '
        Me.ToolStripSeparator01.Name = "ToolStripSeparator01"
        Me.ToolStripSeparator01.Size = New System.Drawing.Size(173, 6)
        '
        'ToolStripMenuItem_Datei
        '
        Me.ToolStripMenuItem_Datei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_XML_New, Me.ToolStripMenuItem_XML_Open, Me.ToolStripSeparator01, Me.ToolStripMenuItem_XML_Safe, Me.ToolStripMenuItem_XML_SaveAs, Me.ToolStripSeparator02, Me.ToolStripMenuItem_Print, Me.ToolStripMenuItem_Seitenansicht, Me.ToolStripSeparator03, Me.ToolStripMenuItem_Beenden})
        Me.ToolStripMenuItem_Datei.Name = "ToolStripMenuItem_Datei"
        Me.ToolStripMenuItem_Datei.Size = New System.Drawing.Size(46, 28)
        Me.ToolStripMenuItem_Datei.Text = "&Datei"
        '
        'ToolStripMenuItem_XML_New
        '
        Me.ToolStripMenuItem_XML_New.Image = CType(resources.GetObject("ToolStripMenuItem_XML_New.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem_XML_New.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem_XML_New.Name = "ToolStripMenuItem_XML_New"
        Me.ToolStripMenuItem_XML_New.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_XML_New.Size = New System.Drawing.Size(176, 30)
        Me.ToolStripMenuItem_XML_New.Text = "&Neu"
        '
        'ToolStripMenuItem_XML_Open
        '
        Me.ToolStripMenuItem_XML_Open.Image = CType(resources.GetObject("ToolStripMenuItem_XML_Open.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem_XML_Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem_XML_Open.Name = "ToolStripMenuItem_XML_Open"
        Me.ToolStripMenuItem_XML_Open.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_XML_Open.Size = New System.Drawing.Size(176, 30)
        Me.ToolStripMenuItem_XML_Open.Text = "Ö&ffnen"
        '
        'ToolStripMenuItem_XML_Safe
        '
        Me.ToolStripMenuItem_XML_Safe.Image = CType(resources.GetObject("ToolStripMenuItem_XML_Safe.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem_XML_Safe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem_XML_Safe.Name = "ToolStripMenuItem_XML_Safe"
        Me.ToolStripMenuItem_XML_Safe.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_XML_Safe.Size = New System.Drawing.Size(176, 30)
        Me.ToolStripMenuItem_XML_Safe.Text = "&Speichern"
        '
        'ToolStripMenuItem_Print
        '
        Me.ToolStripMenuItem_Print.Image = CType(resources.GetObject("ToolStripMenuItem_Print.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem_Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem_Print.Name = "ToolStripMenuItem_Print"
        Me.ToolStripMenuItem_Print.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_Print.Size = New System.Drawing.Size(176, 30)
        Me.ToolStripMenuItem_Print.Text = "&Drucken"
        '
        'ToolStripMenuItem_Seitenansicht
        '
        Me.ToolStripMenuItem_Seitenansicht.Image = CType(resources.GetObject("ToolStripMenuItem_Seitenansicht.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem_Seitenansicht.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem_Seitenansicht.Name = "ToolStripMenuItem_Seitenansicht"
        Me.ToolStripMenuItem_Seitenansicht.Size = New System.Drawing.Size(176, 30)
        Me.ToolStripMenuItem_Seitenansicht.Text = "&Seitenansicht"
        '
        'ToolStripMenuItem_Bearbeiten
        '
        Me.ToolStripMenuItem_Bearbeiten.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Rückgängig, Me.ToolStripMenuItem_Wiederholen, Me.ToolStripSeparator04, Me.AusschneidenToolStripMenuItem, Me.KopierenToolStripMenuItem, Me.EinfügenToolStripMenuItem, Me.ToolStripSeparator05, Me.AlleauswählenToolStripMenuItem})
        Me.ToolStripMenuItem_Bearbeiten.Name = "ToolStripMenuItem_Bearbeiten"
        Me.ToolStripMenuItem_Bearbeiten.Size = New System.Drawing.Size(75, 28)
        Me.ToolStripMenuItem_Bearbeiten.Text = "&Bearbeiten"
        '
        'AusschneidenToolStripMenuItem
        '
        Me.AusschneidenToolStripMenuItem.Image = CType(resources.GetObject("AusschneidenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AusschneidenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AusschneidenToolStripMenuItem.Name = "AusschneidenToolStripMenuItem"
        Me.AusschneidenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.AusschneidenToolStripMenuItem.Size = New System.Drawing.Size(199, 30)
        Me.AusschneidenToolStripMenuItem.Text = "&Ausschneiden"
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.Image = CType(resources.GetObject("KopierenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KopierenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        Me.KopierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(199, 30)
        Me.KopierenToolStripMenuItem.Text = "&Kopieren"
        '
        'EinfügenToolStripMenuItem
        '
        Me.EinfügenToolStripMenuItem.Image = CType(resources.GetObject("EinfügenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EinfügenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
        Me.EinfügenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.EinfügenToolStripMenuItem.Size = New System.Drawing.Size(199, 30)
        Me.EinfügenToolStripMenuItem.Text = "&Einfügen"
        '
        'MenuStrip_Main
        '
        Me.MenuStrip_Main.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip_Main.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Datei, Me.ToolStripMenuItem_Bearbeiten, Me.ToolStripMenuItem_Save, Me.ToolStripTextBox1, Me.ToolStripComboBox1})
        Me.MenuStrip_Main.Location = New System.Drawing.Point(6, 6)
        Me.MenuStrip_Main.Name = "MenuStrip_Main"
        Me.MenuStrip_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip_Main.Size = New System.Drawing.Size(779, 32)
        Me.MenuStrip_Main.TabIndex = 4
        Me.MenuStrip_Main.Text = "MenuStrip1"
        '
        'ToolStripMenuItem_Save
        '
        Me.ToolStripMenuItem_Save.Image = Global.CSVtoQR.My.Resources.Resources.Save
        Me.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save"
        Me.ToolStripMenuItem_Save.Size = New System.Drawing.Size(95, 28)
        Me.ToolStripMenuItem_Save.Text = "Speichern"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator
        Me.ToolStripTextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(60, 28)
        Me.ToolStripTextBox1.Text = "Schema:"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 28)
        '
        'ToolStripStatusLabel_SaveFile
        '
        Me.ToolStripStatusLabel_SaveFile.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripStatusLabel_SaveFile.Name = "ToolStripStatusLabel_SaveFile"
        Me.ToolStripStatusLabel_SaveFile.Size = New System.Drawing.Size(37, 30)
        Me.ToolStripStatusLabel_SaveFile.Text = "Bereit"
        '
        'ToolStripStatusLabel_SaveInfo
        '
        Me.ToolStripStatusLabel_SaveInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel_SaveInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripStatusLabel_SaveInfo.Name = "ToolStripStatusLabel_SaveInfo"
        Me.ToolStripStatusLabel_SaveInfo.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.ToolStripStatusLabel_SaveInfo.Size = New System.Drawing.Size(110, 30)
        Me.ToolStripStatusLabel_SaveInfo.Text = "Gespeichert in: "
        '
        'ToolStripStatusLabel_IsModified
        '
        Me.ToolStripStatusLabel_IsModified.AutoSize = False
        Me.ToolStripStatusLabel_IsModified.BackColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel_IsModified.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel_IsModified.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripStatusLabel_IsModified.Name = "ToolStripStatusLabel_IsModified"
        Me.ToolStripStatusLabel_IsModified.Size = New System.Drawing.Size(22, 30)
        '
        'StatusStrip_Main
        '
        Me.StatusStrip_Main.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_IsModified, Me.ToolStripStatusLabel_SaveInfo, Me.ToolStripStatusLabel_SaveFile})
        Me.StatusStrip_Main.Location = New System.Drawing.Point(6, 412)
        Me.StatusStrip_Main.Name = "StatusStrip_Main"
        Me.StatusStrip_Main.Size = New System.Drawing.Size(779, 30)
        Me.StatusStrip_Main.SizingGrip = False
        Me.StatusStrip_Main.TabIndex = 5
        Me.StatusStrip_Main.Text = "StatusStrip1"
        '
        'SplitContainer_Main
        '
        Me.SplitContainer_Main.BackColor = System.Drawing.SystemColors.ActiveCaption
        MySettings1.LastDataSet = "C:\"
        MySettings1.MyFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        MySettings1.MyLocation = New System.Drawing.Point(100, 100)
        MySettings1.MySize = New System.Drawing.Size(600, 600)
        MySettings1.MySpliter = 504
        MySettings1.SettingsKey = ""
        Me.SplitContainer_Main.DataBindings.Add(New System.Windows.Forms.Binding("SplitterDistance", MySettings1, "MySpliter", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SplitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer_Main.Location = New System.Drawing.Point(6, 38)
        Me.SplitContainer_Main.Name = "SplitContainer_Main"
        '
        'SplitContainer_Main.Panel1
        '
        Me.SplitContainer_Main.Panel1.Controls.Add(Me.TabControl_Main)
        Me.SplitContainer_Main.Panel1MinSize = 240
        '
        'SplitContainer_Main.Panel2
        '
        Me.SplitContainer_Main.Panel2.Controls.Add(Me.Panel_Preview)
        Me.SplitContainer_Main.Size = New System.Drawing.Size(779, 374)
        Me.SplitContainer_Main.SplitterDistance = 283
        Me.SplitContainer_Main.SplitterWidth = 9
        Me.SplitContainer_Main.TabIndex = 28
        '
        'TableLayoutPanel__General
        '
        Me.TableLayoutPanel__General.ColumnCount = 1
        Me.TableLayoutPanel__General.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel__General.Controls.Add(Me.GroupBox_General_Export, 0, 2)
        Me.TableLayoutPanel__General.Controls.Add(Me.GroupBox_General_Import, 0, 1)
        Me.TableLayoutPanel__General.Controls.Add(Me.GroupBox_General_XML, 0, 0)
        Me.TableLayoutPanel__General.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel__General.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel__General.Name = "TableLayoutPanel__General"
        Me.TableLayoutPanel__General.RowCount = 5
        Me.TableLayoutPanel__General.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel__General.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel__General.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel__General.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel__General.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel__General.Size = New System.Drawing.Size(269, 342)
        Me.TableLayoutPanel__General.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(791, 448)
        Me.Controls.Add(Me.SplitContainer_Main)
        Me.Controls.Add(Me.StatusStrip_Main)
        Me.Controls.Add(Me.MenuStrip_Main)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", MySettings1, "MyFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ClientSize", MySettings1, "MySize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.CSVtoQR.My.MySettings.Default, "MyLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Location = Global.CSVtoQR.My.MySettings.Default.MyLocation
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.Text = "Form1"
        Me.TableLayoutPanel_Separatoren.ResumeLayout(False)
        Me.TableLayoutPanel_Separatoren.PerformLayout()
        CType(Me.NumericUpDown_Separator_Column_Count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Separator_Row_Value, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Separator_Row_Count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Separator_Column_Value, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Separatoren.ResumeLayout(False)
        Me.GroupBox_Separatoren.PerformLayout()
        Me.TableLayoutPanel_Data.ResumeLayout(False)
        Me.TableLayoutPanel_Data.PerformLayout()
        CType(Me.DGV_Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_CSV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator_CSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator_CSV.ResumeLayout(False)
        Me.BindingNavigator_CSV.PerformLayout()
        Me.TabPage_Data.ResumeLayout(False)
        Me.GroupBox_Data.ResumeLayout(False)
        Me.GroupBox_Data.PerformLayout()
        Me.TabControl_Main.ResumeLayout(False)
        Me.TabPage_General.ResumeLayout(False)
        Me.GroupBox_General_XML.ResumeLayout(False)
        Me.GroupBox_General_XML.PerformLayout()
        Me.TableLayoutPanel_General_XML.ResumeLayout(False)
        Me.TableLayoutPanel_General_XML.PerformLayout()
        Me.GroupBox_General_Import.ResumeLayout(False)
        Me.GroupBox_General_Import.PerformLayout()
        Me.TableLayoutPanel_General_Import.ResumeLayout(False)
        Me.TableLayoutPanel_General_Import.PerformLayout()
        Me.GroupBox_General_Export.ResumeLayout(False)
        Me.GroupBox_General_Export.PerformLayout()
        Me.TableLayoutPanel_General_Export.ResumeLayout(False)
        Me.TableLayoutPanel_General_Export.PerformLayout()
        Me.TabPage_Paper.ResumeLayout(False)
        Me.TableLayoutPanel_Paper.ResumeLayout(False)
        Me.TableLayoutPanel_Paper.PerformLayout()
        Me.GroupBox_Paper_Shema.ResumeLayout(False)
        Me.GroupBox_Paper_Shema.PerformLayout()
        Me.TableLayoutPanel_Paper_Shema.ResumeLayout(False)
        Me.TableLayoutPanel_Paper_Shema.PerformLayout()
        Me.TabPage_Card.ResumeLayout(False)
        Me.TableLayoutPanel_Card.ResumeLayout(False)
        Me.GroupBox_Card_Size.ResumeLayout(False)
        Me.TableLayoutPanel_Card_Size.ResumeLayout(False)
        Me.TableLayoutPanel_Card_Size.PerformLayout()
        Me.TabPage_CardRow.ResumeLayout(False)
        Me.TabPage_CardRow.PerformLayout()
        Me.TableLayoutPanel_CardRow.ResumeLayout(False)
        Me.TableLayoutPanel_CardRow.PerformLayout()
        Me.GroupBox_CardRow_Line.ResumeLayout(False)
        Me.GroupBox_CardRow_Line.PerformLayout()
        Me.TableLayoutPanel_CardRow_Line.ResumeLayout(False)
        Me.TableLayoutPanel_CardRow_Line.PerformLayout()
        Me.GroupBox_CardRow_List.ResumeLayout(False)
        Me.GroupBox_CardRow_List.PerformLayout()
        Me.TableLayoutPanel_CardRow_ListBox.ResumeLayout(False)
        Me.TableLayoutPanel_CardRow_ListBox.PerformLayout()
        Me.FlowLayoutPanel_CardRow_TopDown.ResumeLayout(False)
        Me.FlowLayoutPanel_CardRow_TopDown.PerformLayout()
        Me.FlowLayoutPanel_CardRow_Row.ResumeLayout(False)
        Me.FlowLayoutPanel_CardRow_Row.PerformLayout()
        Me.TabPage_Table.ResumeLayout(False)
        Me.GroupBox_Table.ResumeLayout(False)
        Me.TableLayoutPanel_Table.ResumeLayout(False)
        CType(Me.DGV_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Preview.ResumeLayout(False)
        CType(Me.PictureBox_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip_Main.ResumeLayout(False)
        Me.MenuStrip_Main.PerformLayout()
        Me.StatusStrip_Main.ResumeLayout(False)
        Me.StatusStrip_Main.PerformLayout()
        Me.SplitContainer_Main.Panel1.ResumeLayout(False)
        Me.SplitContainer_Main.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Main.ResumeLayout(False)
        CType(Me.BindingSource_CSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel__General.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Separator_Row As Label
    Friend WithEvents TableLayoutPanel_Separatoren As TableLayoutPanel
    Friend WithEvents GroupBox_Separatoren As GroupBox
    Friend WithEvents GroupBox_Paper_Shema As GroupBox
    Friend WithEvents TableLayoutPanel_Paper_Shema As TableLayoutPanel
    Friend WithEvents Label_Paper_Shema As Label
    Friend WithEvents TextBox_Paper_Shema As TextBox
    Friend WithEvents Label_Paper_Width As Label
    Friend WithEvents Label_Paper_Height As Label
    Friend WithEvents Label_Paper_DPI As Label
    Friend WithEvents Label_Paper_DIN As Label
    Friend WithEvents ComboBox_Paper_DIN As ComboBox
    Friend WithEvents Label_Paper_Height_Unit As Label
    Friend WithEvents Label_Paper_Width_Unit As Label
    Friend WithEvents TextBox_General_Import_Directory As TextBox
    Friend WithEvents Label_General_Export_Directory As Label
    Friend WithEvents TextBox_General_Export_Directory As TextBox
    Friend WithEvents Button_General_Import As Button
    Friend WithEvents ImageList_Main As ImageList
    Friend WithEvents Button_General_Export As Button
    Friend WithEvents TableLayoutPanel_Data As TableLayoutPanel
    Friend WithEvents Button_Search_Add As Button
    Friend WithEvents Button_Search_Delete As Button
    Friend WithEvents DGV_Search As DataGridView
    Friend WithEvents TabPage_Data As TabPage
    Friend WithEvents TabControl_Main As TabControl
    Friend WithEvents TabPage_Paper As TabPage
    Friend WithEvents Panel_Preview As Panel
    Friend WithEvents PictureBox_Preview As PictureBox
    Friend WithEvents TabPage_Table As TabPage
    Friend WithEvents DGV_Table As DataGridView
    Friend WithEvents ListBox_Tabellen As ListBox
    Friend WithEvents AlleauswählenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator05 As ToolStripSeparator
    Friend WithEvents EinfügenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KopierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AusschneidenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator04 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem_Wiederholen As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Rückgängig As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Beenden As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator03 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem_Seitenansicht As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Print As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator02 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem_XML_SaveAs As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_XML_Safe As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator01 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem_XML_Open As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_XML_New As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Datei As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Bearbeiten As ToolStripMenuItem
    Friend WithEvents MenuStrip_Main As MenuStrip
    Friend WithEvents BindingSource_CSV As BindingSource
    Friend WithEvents ToolStripStatusLabel_SaveFile As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_SaveInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_IsModified As ToolStripStatusLabel
    Friend WithEvents StatusStrip_Main As StatusStrip
    Friend WithEvents NumericUpDown_Separator_Column_Count As NumericUpDown
    Friend WithEvents NumericUpDown_Separator_Row_Count As NumericUpDown
    Friend WithEvents NumericUpDown_Separator_Column_Value As NumericUpDown
    Friend WithEvents NumericUpDown_Separator_Row_Value As NumericUpDown
    Friend WithEvents ComboBox_Paper_DPI As ComboBox
    Friend WithEvents Label_Paper_Width_Value As Label
    Friend WithEvents Label_Paper_Height_Value As Label
    Friend WithEvents TableLayoutPanel_Paper As TableLayoutPanel
    Friend WithEvents Button_Search_Refresh As Button
    Friend WithEvents TabPage_Card As TabPage
    Friend WithEvents Label_CardRow_DataColumn As Label
    Friend WithEvents Label_CardRow_LinePos As Label
    Friend WithEvents Label_CardRow_QRCode As Label
    Friend WithEvents CheckBox_CardRow_AutoFont As CheckBox
    Friend WithEvents CheckBox_CardRow_QRCode As CheckBox
    Friend WithEvents Label_CardRow_AutoFont As Label
    Friend WithEvents ComboBox_CardRow_DataColumn As ComboBox
    Friend WithEvents ListBox_CardRow As ListBox
    Friend WithEvents TabPage_CardRow As TabPage
    Friend WithEvents SplitContainer_Main As SplitContainer
    Friend WithEvents GroupBox_CardRow_Line As GroupBox
    Friend WithEvents TableLayoutPanel_CardRow As TableLayoutPanel
    Friend WithEvents TableLayoutPanel_CardRow_Line As TableLayoutPanel
    Friend WithEvents Label_Separator_Column_Count As Label
    Friend WithEvents Label_Separator_Column_Value As Label
    Friend WithEvents Label_Separator_Column_Unit As Label
    Friend WithEvents Label_Separator_Row_Unit As Label
    Friend WithEvents DGV_CSV As DataGridView
    Friend WithEvents BindingNavigator_CSV As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TableLayoutPanel_Card As TableLayoutPanel
    Friend WithEvents GroupBox_Card_Size As GroupBox
    Friend WithEvents TableLayoutPanel_Card_Size As TableLayoutPanel
    Friend WithEvents Label_Card_Size_Hight As Label
    Friend WithEvents Label_Card_Size_Hight_Value As Label
    Friend WithEvents Label_Card_Size_Width As Label
    Friend WithEvents Label_Card_Size_Width_Value As Label
    Friend WithEvents GroupBox_CardRow_List As GroupBox
    Friend WithEvents Button_CardRow_Add As Button
    Friend WithEvents Button_CardRow_Delete As Button
    Friend WithEvents TabPage_General As TabPage
    Friend WithEvents TableLayoutPanel_General_XML As TableLayoutPanel
    Friend WithEvents Button_General_XML_Open As Button
    Friend WithEvents TextBox_General_XML_Directory As TextBox
    Friend WithEvents Label_General_XML_Directory As Label
    Friend WithEvents Label_Card_Size_Width_Unit As Label
    Friend WithEvents Label_Card_Size_Hight_Unit As Label
    Friend WithEvents GroupBox_General_XML As GroupBox
    Friend WithEvents GroupBox_General_Export As GroupBox
    Friend WithEvents TableLayoutPanel_General_Export As TableLayoutPanel
    Friend WithEvents GroupBox_General_Import As GroupBox
    Friend WithEvents TableLayoutPanel_General_Import As TableLayoutPanel
    Friend WithEvents TextBox_General_Import_Filename As TextBox
    Friend WithEvents Label_General_Import_Directory As Label
    Friend WithEvents Label_General_Import_Filname As Label
    Friend WithEvents GroupBox_Table As GroupBox
    Friend WithEvents TableLayoutPanel_Table As TableLayoutPanel
    Friend WithEvents TextBox_General_XML_Filename As TextBox
    Friend WithEvents Label_General_XML_Filname As Label
    Friend WithEvents Label_General_Export_Filname As Label
    Friend WithEvents TextBox_General_Export_Filename As TextBox
    Friend WithEvents GroupBox_Data As GroupBox
    Friend WithEvents ToolStripMenuItem_Save As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel_CardRow_Row As FlowLayoutPanel
    Friend WithEvents Button_CardRow_Up As Button
    Friend WithEvents Button_CardRow_Down As Button
    Friend WithEvents Label_CardRow_LinePos_Value As Label
    Friend WithEvents Button_CardRow_Save As Button
    Friend WithEvents Label_CardRow_FontColor As Label
    Friend WithEvents Button_CardRow_FontColor As Button
    Friend WithEvents FlowLayoutPanel_CardRow_TopDown As FlowLayoutPanel
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents Label_Separator_Column As Label
    Friend WithEvents TableLayoutPanel_CardRow_ListBox As TableLayoutPanel
    Friend WithEvents TableLayoutPanel__General As TableLayoutPanel
End Class
