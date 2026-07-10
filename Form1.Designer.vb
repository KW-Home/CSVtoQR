Imports CSVtoQR.My

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
        Me.NumericUpDown_Separator_Column_Count = New System.Windows.Forms.NumericUpDown()
        Me.Label_Separator_Column_Count = New System.Windows.Forms.Label()
        Me.Label_Separator_Row_Unit = New System.Windows.Forms.Label()
        Me.NumericUpDown_Separator_Row_Value = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Separator_Row_Count = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Separator_Column_Value = New System.Windows.Forms.NumericUpDown()
        Me.Label_Separator_Column_Value = New System.Windows.Forms.Label()
        Me.Label_Separator_Column_Unit = New System.Windows.Forms.Label()
        Me.Label_Separator_Column = New System.Windows.Forms.Label()
        Me.Label_Paper_Width = New System.Windows.Forms.Label()
        Me.Label_Paper_Height = New System.Windows.Forms.Label()
        Me.Label_Paper_DPI = New System.Windows.Forms.Label()
        Me.Label_Paper_DIN = New System.Windows.Forms.Label()
        Me.ImageList_Main = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel_CSV = New System.Windows.Forms.TableLayoutPanel()
        Me.DGV_Search = New System.Windows.Forms.DataGridView()
        Me.DGV_CSV = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_Search_Delete = New System.Windows.Forms.Button()
        Me.Button_Search_Add = New System.Windows.Forms.Button()
        Me.Button_Search_Refresh = New System.Windows.Forms.Button()
        Me.PictureBox_CSV = New System.Windows.Forms.PictureBox()
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
        Me.TabPage_CSV = New System.Windows.Forms.TabPage()
        Me.TabControl_Main = New System.Windows.Forms.TabControl()
        Me.TabPage_General = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel_General = New System.Windows.Forms.TableLayoutPanel()
        Me.TabPage_Paper = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel_Paper = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Header = New System.Windows.Forms.Label()
        Me.Label_Paper_Width_Unit = New System.Windows.Forms.Label()
        Me.Label_Paper_Width_Value = New System.Windows.Forms.Label()
        Me.Label_Paper_Height_Unit = New System.Windows.Forms.Label()
        Me.Label_Paper_Height_Value = New System.Windows.Forms.Label()
        Me.Label_Paper_Paper = New System.Windows.Forms.Label()
        Me.ComboBox_Paper_DPI = New System.Windows.Forms.ComboBox()
        Me.TextBox_Paper_Paper = New System.Windows.Forms.TextBox()
        Me.ComboBox_Paper_DIN = New System.Windows.Forms.ComboBox()
        Me.PictureBox_Paper = New System.Windows.Forms.PictureBox()
        Me.TabPage_Card = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel_Card = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Card_Size_Hight = New System.Windows.Forms.Label()
        Me.Label_Card_Size_Width = New System.Windows.Forms.Label()
        Me.Label_Card_Size_Width_Unit = New System.Windows.Forms.Label()
        Me.Label_Card_Size_Hight_Value = New System.Windows.Forms.Label()
        Me.Label_Card_Size_Hight_Unit = New System.Windows.Forms.Label()
        Me.Label_Card_Size_Width_Value = New System.Windows.Forms.Label()
        Me.PictureBox_Card = New System.Windows.Forms.PictureBox()
        Me.TabPage_CardRow = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel_CardRow = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox_CardRow = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel_CardRow_ListBox = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBox_CardRow = New System.Windows.Forms.ListBox()
        Me.Button_CardRow_FontColor = New System.Windows.Forms.Button()
        Me.Label_CardRow_DataColumn = New System.Windows.Forms.Label()
        Me.ComboBox_CardRow_DataColumn = New System.Windows.Forms.ComboBox()
        Me.Label_CardRow_QRCode = New System.Windows.Forms.Label()
        Me.Label_CardRow_AutoFont = New System.Windows.Forms.Label()
        Me.Label_CardRow_FontColor = New System.Windows.Forms.Label()
        Me.CheckBox_CardRow_AutoFont = New System.Windows.Forms.CheckBox()
        Me.CheckBox_CardRow_QRCode = New System.Windows.Forms.CheckBox()
        Me.Label_CardRow_LinePos = New System.Windows.Forms.Label()
        Me.Label_CardRow_LinePos_Value = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_CardRow_Up = New System.Windows.Forms.Button()
        Me.Button_CardRow_Down = New System.Windows.Forms.Button()
        Me.Button_CardRow_Edit = New System.Windows.Forms.Button()
        Me.Button_CardRow_Add = New System.Windows.Forms.Button()
        Me.Button_CardRow_Delete = New System.Windows.Forms.Button()
        Me.TabPage_DataSet = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel_DataSet = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBox_Tabellen = New System.Windows.Forms.ListBox()
        Me.DGV_Table = New System.Windows.Forms.DataGridView()
        Me.ToolStripMenuItem_Beenden = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator03 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator02 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_XML_SaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator01 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_Datei = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Print = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Seitenansicht = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Main = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripStatusLabel_SaveFile = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_SaveInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_IsModified = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip_Main = New System.Windows.Forms.StatusStrip()
        Me.BindingSource_CSV = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.NumericUpDown_Separator_Column_Count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Separator_Row_Value, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Separator_Row_Count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Separator_Column_Value, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel_CSV.SuspendLayout()
        CType(Me.DGV_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_CSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox_CSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator_CSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator_CSV.SuspendLayout()
        Me.TabPage_CSV.SuspendLayout()
        Me.TabControl_Main.SuspendLayout()
        Me.TabPage_General.SuspendLayout()
        Me.TabPage_Paper.SuspendLayout()
        Me.TableLayoutPanel_Paper.SuspendLayout()
        CType(Me.PictureBox_Paper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Card.SuspendLayout()
        Me.TableLayoutPanel_Card.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox_Card, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_CardRow.SuspendLayout()
        Me.TableLayoutPanel_CardRow.SuspendLayout()
        CType(Me.PictureBox_CardRow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel_CardRow_ListBox.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TabPage_DataSet.SuspendLayout()
        Me.TableLayoutPanel_DataSet.SuspendLayout()
        CType(Me.DGV_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip_Main.SuspendLayout()
        Me.StatusStrip_Main.SuspendLayout()
        CType(Me.BindingSource_CSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Separator_Row
        '
        Me.Label_Separator_Row.AutoSize = True
        Me.Label_Separator_Row.Location = New System.Drawing.Point(3, 201)
        Me.Label_Separator_Row.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Separator_Row.Name = "Label_Separator_Row"
        Me.Label_Separator_Row.Size = New System.Drawing.Size(29, 17)
        Me.Label_Separator_Row.TabIndex = 1
        Me.Label_Separator_Row.Text = "Zeile"
        Me.Label_Separator_Row.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Separator_Row.UseCompatibleTextRendering = True
        '
        'NumericUpDown_Separator_Column_Count
        '
        Me.NumericUpDown_Separator_Column_Count.Location = New System.Drawing.Point(45, 175)
        Me.NumericUpDown_Separator_Column_Count.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NumericUpDown_Separator_Column_Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Separator_Column_Count.Name = "NumericUpDown_Separator_Column_Count"
        Me.NumericUpDown_Separator_Column_Count.Size = New System.Drawing.Size(57, 20)
        Me.NumericUpDown_Separator_Column_Count.TabIndex = 0
        Me.NumericUpDown_Separator_Column_Count.Tag = "SeparatorSpalteAnzahl"
        Me.NumericUpDown_Separator_Column_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_Separator_Column_Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label_Separator_Column_Count
        '
        Me.Label_Separator_Column_Count.AutoSize = True
        Me.Label_Separator_Column_Count.Location = New System.Drawing.Point(45, 152)
        Me.Label_Separator_Column_Count.Margin = New System.Windows.Forms.Padding(3)
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
        Me.Label_Separator_Row_Unit.Location = New System.Drawing.Point(171, 201)
        Me.Label_Separator_Row_Unit.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Separator_Row_Unit.Name = "Label_Separator_Row_Unit"
        Me.Label_Separator_Row_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Separator_Row_Unit.TabIndex = 48
        Me.Label_Separator_Row_Unit.Text = "mm"
        Me.Label_Separator_Row_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Separator_Row_Unit.UseCompatibleTextRendering = True
        '
        'NumericUpDown_Separator_Row_Value
        '
        Me.NumericUpDown_Separator_Row_Value.DecimalPlaces = 1
        Me.NumericUpDown_Separator_Row_Value.Location = New System.Drawing.Point(108, 201)
        Me.NumericUpDown_Separator_Row_Value.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NumericUpDown_Separator_Row_Value.Name = "NumericUpDown_Separator_Row_Value"
        Me.NumericUpDown_Separator_Row_Value.Size = New System.Drawing.Size(57, 20)
        Me.NumericUpDown_Separator_Row_Value.TabIndex = 3
        Me.NumericUpDown_Separator_Row_Value.Tag = "SeparatorZeileWert"
        Me.NumericUpDown_Separator_Row_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumericUpDown_Separator_Row_Count
        '
        Me.NumericUpDown_Separator_Row_Count.Location = New System.Drawing.Point(45, 201)
        Me.NumericUpDown_Separator_Row_Count.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NumericUpDown_Separator_Row_Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Separator_Row_Count.Name = "NumericUpDown_Separator_Row_Count"
        Me.NumericUpDown_Separator_Row_Count.Size = New System.Drawing.Size(57, 20)
        Me.NumericUpDown_Separator_Row_Count.TabIndex = 2
        Me.NumericUpDown_Separator_Row_Count.Tag = "SeparatorZeileAnzahl"
        Me.NumericUpDown_Separator_Row_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_Separator_Row_Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDown_Separator_Column_Value
        '
        Me.NumericUpDown_Separator_Column_Value.DecimalPlaces = 1
        Me.NumericUpDown_Separator_Column_Value.Location = New System.Drawing.Point(108, 175)
        Me.NumericUpDown_Separator_Column_Value.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NumericUpDown_Separator_Column_Value.Name = "NumericUpDown_Separator_Column_Value"
        Me.NumericUpDown_Separator_Column_Value.Size = New System.Drawing.Size(57, 20)
        Me.NumericUpDown_Separator_Column_Value.TabIndex = 1
        Me.NumericUpDown_Separator_Column_Value.Tag = "SeparatorSpalteWert"
        Me.NumericUpDown_Separator_Column_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_Separator_Column_Value
        '
        Me.Label_Separator_Column_Value.AutoSize = True
        Me.Label_Separator_Column_Value.Location = New System.Drawing.Point(108, 152)
        Me.Label_Separator_Column_Value.Margin = New System.Windows.Forms.Padding(3)
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
        Me.Label_Separator_Column_Unit.Location = New System.Drawing.Point(171, 175)
        Me.Label_Separator_Column_Unit.Margin = New System.Windows.Forms.Padding(3)
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
        Me.Label_Separator_Column.Location = New System.Drawing.Point(3, 175)
        Me.Label_Separator_Column.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Separator_Column.Name = "Label_Separator_Column"
        Me.Label_Separator_Column.Size = New System.Drawing.Size(36, 17)
        Me.Label_Separator_Column.TabIndex = 50
        Me.Label_Separator_Column.Text = "Spalte"
        Me.Label_Separator_Column.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Separator_Column.UseCompatibleTextRendering = True
        '
        'Label_Paper_Width
        '
        Me.Label_Paper_Width.AutoSize = True
        Me.Label_Paper_Width.Location = New System.Drawing.Point(3, 106)
        Me.Label_Paper_Width.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Paper_Width.Name = "Label_Paper_Width"
        Me.Label_Paper_Width.Size = New System.Drawing.Size(34, 14)
        Me.Label_Paper_Width.TabIndex = 6
        Me.Label_Paper_Width.Text = "Breite"
        Me.Label_Paper_Width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Width.UseCompatibleTextRendering = True
        '
        'Label_Paper_Height
        '
        Me.Label_Paper_Height.AutoSize = True
        Me.Label_Paper_Height.Location = New System.Drawing.Point(3, 83)
        Me.Label_Paper_Height.Margin = New System.Windows.Forms.Padding(3)
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
        Me.Label_Paper_DPI.Location = New System.Drawing.Point(3, 29)
        Me.Label_Paper_DPI.Margin = New System.Windows.Forms.Padding(3)
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
        Me.Label_Paper_DIN.Location = New System.Drawing.Point(3, 56)
        Me.Label_Paper_DIN.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Paper_DIN.Name = "Label_Paper_DIN"
        Me.Label_Paper_DIN.Size = New System.Drawing.Size(24, 17)
        Me.Label_Paper_DIN.TabIndex = 2
        Me.Label_Paper_DIN.Text = "DIN"
        Me.Label_Paper_DIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_DIN.UseCompatibleTextRendering = True
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
        'TableLayoutPanel_CSV
        '
        Me.TableLayoutPanel_CSV.AutoSize = True
        Me.TableLayoutPanel_CSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel_CSV.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel_CSV.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel_CSV.ColumnCount = 2
        Me.TableLayoutPanel_CSV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_CSV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_CSV.Controls.Add(Me.DGV_Search, 0, 0)
        Me.TableLayoutPanel_CSV.Controls.Add(Me.DGV_CSV, 0, 2)
        Me.TableLayoutPanel_CSV.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel_CSV.Controls.Add(Me.PictureBox_CSV, 1, 0)
        Me.TableLayoutPanel_CSV.Controls.Add(Me.BindingNavigator_CSV, 0, 3)
        Me.TableLayoutPanel_CSV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_CSV.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_CSV.Name = "TableLayoutPanel_CSV"
        Me.TableLayoutPanel_CSV.RowCount = 4
        Me.TableLayoutPanel_CSV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel_CSV.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CSV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel_CSV.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CSV.Size = New System.Drawing.Size(628, 519)
        Me.TableLayoutPanel_CSV.TabIndex = 0
        '
        'DGV_Search
        '
        Me.DGV_Search.AllowUserToAddRows = False
        Me.DGV_Search.AllowUserToDeleteRows = False
        Me.DGV_Search.AllowUserToOrderColumns = True
        Me.DGV_Search.AllowUserToResizeColumns = False
        Me.DGV_Search.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Search.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Search.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Search.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_Search.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DGV_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Search.EnableHeadersVisualStyles = False
        Me.DGV_Search.GridColor = System.Drawing.Color.DarkGray
        Me.DGV_Search.Location = New System.Drawing.Point(4, 4)
        Me.DGV_Search.MinimumSize = New System.Drawing.Size(200, 64)
        Me.DGV_Search.Name = "DGV_Search"
        Me.DGV_Search.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGV_Search.Size = New System.Drawing.Size(595, 138)
        Me.DGV_Search.TabIndex = 0
        '
        'DGV_CSV
        '
        Me.DGV_CSV.AllowUserToAddRows = False
        Me.DGV_CSV.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_CSV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_CSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_CSV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DGV_CSV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_CSV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_CSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel_CSV.SetColumnSpan(Me.DGV_CSV, 2)
        Me.DGV_CSV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_CSV.GridColor = System.Drawing.Color.DarkGray
        Me.DGV_CSV.Location = New System.Drawing.Point(4, 200)
        Me.DGV_CSV.MultiSelect = False
        Me.DGV_CSV.Name = "DGV_CSV"
        Me.DGV_CSV.RowHeadersWidth = 62
        Me.DGV_CSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGV_CSV.Size = New System.Drawing.Size(620, 282)
        Me.DGV_CSV.TabIndex = 44
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_Search_Delete)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_Search_Add)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_Search_Refresh)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(4, 149)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(132, 44)
        Me.FlowLayoutPanel1.TabIndex = 49
        '
        'Button_Search_Delete
        '
        Me.Button_Search_Delete.AutoSize = True
        Me.Button_Search_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Search_Delete.ImageKey = "ZoomOut"
        Me.Button_Search_Delete.ImageList = Me.ImageList_Main
        Me.Button_Search_Delete.Location = New System.Drawing.Point(3, 3)
        Me.Button_Search_Delete.Name = "Button_Search_Delete"
        Me.Button_Search_Delete.Size = New System.Drawing.Size(38, 38)
        Me.Button_Search_Delete.TabIndex = 46
        Me.Button_Search_Delete.UseVisualStyleBackColor = True
        '
        'Button_Search_Add
        '
        Me.Button_Search_Add.AutoSize = True
        Me.Button_Search_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Search_Add.ImageKey = "ZoomIn"
        Me.Button_Search_Add.ImageList = Me.ImageList_Main
        Me.Button_Search_Add.Location = New System.Drawing.Point(47, 3)
        Me.Button_Search_Add.Name = "Button_Search_Add"
        Me.Button_Search_Add.Size = New System.Drawing.Size(38, 38)
        Me.Button_Search_Add.TabIndex = 47
        Me.Button_Search_Add.UseVisualStyleBackColor = True
        '
        'Button_Search_Refresh
        '
        Me.Button_Search_Refresh.AutoSize = True
        Me.Button_Search_Refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Search_Refresh.ImageKey = "Refresh_Arrow_Green"
        Me.Button_Search_Refresh.ImageList = Me.ImageList_Main
        Me.Button_Search_Refresh.Location = New System.Drawing.Point(91, 3)
        Me.Button_Search_Refresh.Name = "Button_Search_Refresh"
        Me.Button_Search_Refresh.Size = New System.Drawing.Size(38, 38)
        Me.Button_Search_Refresh.TabIndex = 48
        Me.Button_Search_Refresh.UseVisualStyleBackColor = True
        '
        'PictureBox_CSV
        '
        Me.PictureBox_CSV.BackColor = System.Drawing.Color.Firebrick
        Me.PictureBox_CSV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox_CSV.Location = New System.Drawing.Point(603, 1)
        Me.PictureBox_CSV.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox_CSV.Name = "PictureBox_CSV"
        Me.TableLayoutPanel_CSV.SetRowSpan(Me.PictureBox_CSV, 2)
        Me.PictureBox_CSV.Size = New System.Drawing.Size(24, 195)
        Me.PictureBox_CSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_CSV.TabIndex = 47
        Me.PictureBox_CSV.TabStop = False
        '
        'BindingNavigator_CSV
        '
        Me.BindingNavigator_CSV.AddNewItem = Nothing
        Me.BindingNavigator_CSV.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel_CSV.SetColumnSpan(Me.BindingNavigator_CSV, 2)
        Me.BindingNavigator_CSV.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator_CSV.DeleteItem = Nothing
        Me.BindingNavigator_CSV.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigator_CSV.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator_CSV.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BindingNavigator_CSV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator_CSV.Location = New System.Drawing.Point(1, 486)
        Me.BindingNavigator_CSV.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator_CSV.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator_CSV.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator_CSV.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator_CSV.Name = "BindingNavigator_CSV"
        Me.BindingNavigator_CSV.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator_CSV.Size = New System.Drawing.Size(626, 31)
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
        'TabPage_CSV
        '
        Me.TabPage_CSV.AutoScroll = True
        Me.TabPage_CSV.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_CSV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage_CSV.Controls.Add(Me.TableLayoutPanel_CSV)
        Me.TabPage_CSV.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_CSV.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage_CSV.Name = "TabPage_CSV"
        Me.TabPage_CSV.Size = New System.Drawing.Size(632, 523)
        Me.TabPage_CSV.TabIndex = 5
        Me.TabPage_CSV.Text = "CSV"
        '
        'TabControl_Main
        '
        Me.TabControl_Main.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl_Main.Controls.Add(Me.TabPage_General)
        Me.TabControl_Main.Controls.Add(Me.TabPage_Paper)
        Me.TabControl_Main.Controls.Add(Me.TabPage_Card)
        Me.TabControl_Main.Controls.Add(Me.TabPage_CardRow)
        Me.TabControl_Main.Controls.Add(Me.TabPage_CSV)
        Me.TabControl_Main.Controls.Add(Me.TabPage_DataSet)
        Me.TabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_Main.Location = New System.Drawing.Point(3, 35)
        Me.TabControl_Main.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl_Main.Multiline = True
        Me.TabControl_Main.Name = "TabControl_Main"
        Me.TabControl_Main.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl_Main.SelectedIndex = 0
        Me.TabControl_Main.Size = New System.Drawing.Size(640, 552)
        Me.TabControl_Main.TabIndex = 5
        '
        'TabPage_General
        '
        Me.TabPage_General.AutoScroll = True
        Me.TabPage_General.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_General.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage_General.Controls.Add(Me.TableLayoutPanel_General)
        Me.TabPage_General.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_General.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage_General.Name = "TabPage_General"
        Me.TabPage_General.Size = New System.Drawing.Size(632, 523)
        Me.TabPage_General.TabIndex = 8
        Me.TabPage_General.Text = "Allgemein"
        '
        'TableLayoutPanel_General
        '
        Me.TableLayoutPanel_General.AutoSize = True
        Me.TableLayoutPanel_General.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel_General.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel_General.ColumnCount = 1
        Me.TableLayoutPanel_General.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_General.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel_General.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_General.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel_General.MinimumSize = New System.Drawing.Size(200, 0)
        Me.TableLayoutPanel_General.Name = "TableLayoutPanel_General"
        Me.TableLayoutPanel_General.Padding = New System.Windows.Forms.Padding(9)
        Me.TableLayoutPanel_General.RowCount = 1
        Me.TableLayoutPanel_General.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_General.Size = New System.Drawing.Size(628, 20)
        Me.TableLayoutPanel_General.TabIndex = 5
        '
        'TabPage_Paper
        '
        Me.TabPage_Paper.AutoScroll = True
        Me.TabPage_Paper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage_Paper.Controls.Add(Me.TableLayoutPanel_Paper)
        Me.TabPage_Paper.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_Paper.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage_Paper.Name = "TabPage_Paper"
        Me.TabPage_Paper.Size = New System.Drawing.Size(632, 523)
        Me.TabPage_Paper.TabIndex = 0
        Me.TabPage_Paper.Text = "Papier"
        Me.TabPage_Paper.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_Paper
        '
        Me.TableLayoutPanel_Paper.AutoSize = True
        Me.TableLayoutPanel_Paper.ColumnCount = 5
        Me.TableLayoutPanel_Paper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Paper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Paper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Paper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Paper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Separator_Row_Unit, 3, 9)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.NumericUpDown_Separator_Column_Count, 1, 8)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Separator_Column_Unit, 3, 8)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.NumericUpDown_Separator_Row_Value, 2, 9)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Header, 0, 6)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.NumericUpDown_Separator_Column_Value, 2, 8)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.NumericUpDown_Separator_Row_Count, 1, 9)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Separator_Row, 0, 9)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Paper_Height_Unit, 2, 3)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Paper_Height_Value, 1, 3)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Paper_Paper, 0, 0)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Separator_Column, 0, 8)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.ComboBox_Paper_DPI, 1, 1)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Paper_Height, 0, 3)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.TextBox_Paper_Paper, 1, 0)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.ComboBox_Paper_DIN, 1, 2)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Paper_DIN, 0, 2)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Paper_DPI, 0, 1)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.PictureBox_Paper, 4, 0)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Separator_Column_Count, 1, 7)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Separator_Column_Value, 2, 7)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Paper_Width, 0, 4)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Paper_Width_Value, 1, 4)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Label_Paper_Width_Unit, 2, 4)
        Me.TableLayoutPanel_Paper.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_Paper.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel_Paper.Name = "TableLayoutPanel_Paper"
        Me.TableLayoutPanel_Paper.RowCount = 10
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.Size = New System.Drawing.Size(233, 251)
        Me.TableLayoutPanel_Paper.TabIndex = 45
        '
        'Label_Header
        '
        Me.Label_Header.AutoSize = True
        Me.Label_Header.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TableLayoutPanel_Paper.SetColumnSpan(Me.Label_Header, 3)
        Me.Label_Header.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label_Header.Location = New System.Drawing.Point(3, 126)
        Me.Label_Header.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Header.Name = "Label_Header"
        Me.Label_Header.Size = New System.Drawing.Size(162, 20)
        Me.Label_Header.TabIndex = 46
        Me.Label_Header.Text = "Separatoren Spalte"
        Me.Label_Header.UseCompatibleTextRendering = True
        '
        'Label_Paper_Width_Unit
        '
        Me.Label_Paper_Width_Unit.AutoSize = True
        Me.Label_Paper_Width_Unit.Location = New System.Drawing.Point(108, 106)
        Me.Label_Paper_Width_Unit.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Paper_Width_Unit.Name = "Label_Paper_Width_Unit"
        Me.Label_Paper_Width_Unit.Size = New System.Drawing.Size(23, 14)
        Me.Label_Paper_Width_Unit.TabIndex = 9
        Me.Label_Paper_Width_Unit.Text = "mm"
        Me.Label_Paper_Width_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Width_Unit.UseCompatibleTextRendering = True
        '
        'Label_Paper_Width_Value
        '
        Me.Label_Paper_Width_Value.AutoSize = True
        Me.Label_Paper_Width_Value.Location = New System.Drawing.Point(45, 106)
        Me.Label_Paper_Width_Value.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Paper_Width_Value.Name = "Label_Paper_Width_Value"
        Me.Label_Paper_Width_Value.Size = New System.Drawing.Size(25, 13)
        Me.Label_Paper_Width_Value.TabIndex = 47
        Me.Label_Paper_Width_Value.Text = "PW"
        '
        'Label_Paper_Height_Unit
        '
        Me.Label_Paper_Height_Unit.AutoSize = True
        Me.Label_Paper_Height_Unit.Location = New System.Drawing.Point(108, 83)
        Me.Label_Paper_Height_Unit.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Paper_Height_Unit.Name = "Label_Paper_Height_Unit"
        Me.Label_Paper_Height_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Paper_Height_Unit.TabIndex = 8
        Me.Label_Paper_Height_Unit.Text = "mm"
        Me.Label_Paper_Height_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Height_Unit.UseCompatibleTextRendering = True
        '
        'Label_Paper_Height_Value
        '
        Me.Label_Paper_Height_Value.AutoSize = True
        Me.Label_Paper_Height_Value.Location = New System.Drawing.Point(45, 83)
        Me.Label_Paper_Height_Value.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Paper_Height_Value.Name = "Label_Paper_Height_Value"
        Me.Label_Paper_Height_Value.Size = New System.Drawing.Size(22, 13)
        Me.Label_Paper_Height_Value.TabIndex = 46
        Me.Label_Paper_Height_Value.Text = "PH"
        '
        'Label_Paper_Paper
        '
        Me.Label_Paper_Paper.AutoSize = True
        Me.Label_Paper_Paper.Location = New System.Drawing.Point(3, 3)
        Me.Label_Paper_Paper.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Paper_Paper.Name = "Label_Paper_Paper"
        Me.Label_Paper_Paper.Size = New System.Drawing.Size(34, 17)
        Me.Label_Paper_Paper.TabIndex = 0
        Me.Label_Paper_Paper.Text = "Name"
        Me.Label_Paper_Paper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Paper.UseCompatibleTextRendering = True
        '
        'ComboBox_Paper_DPI
        '
        Me.ComboBox_Paper_DPI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_Paper_DPI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_Paper_DPI.FormattingEnabled = True
        Me.ComboBox_Paper_DPI.Location = New System.Drawing.Point(45, 29)
        Me.ComboBox_Paper_DPI.Name = "ComboBox_Paper_DPI"
        Me.ComboBox_Paper_DPI.Size = New System.Drawing.Size(57, 21)
        Me.ComboBox_Paper_DPI.TabIndex = 0
        Me.ComboBox_Paper_DPI.Tag = "DPI"
        '
        'TextBox_Paper_Paper
        '
        Me.TextBox_Paper_Paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel_Paper.SetColumnSpan(Me.TextBox_Paper_Paper, 3)
        Me.TextBox_Paper_Paper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Paper_Paper.Location = New System.Drawing.Point(45, 3)
        Me.TextBox_Paper_Paper.Name = "TextBox_Paper_Paper"
        Me.TextBox_Paper_Paper.Size = New System.Drawing.Size(153, 20)
        Me.TextBox_Paper_Paper.TabIndex = 0
        Me.TextBox_Paper_Paper.Tag = "Paper"
        '
        'ComboBox_Paper_DIN
        '
        Me.ComboBox_Paper_DIN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_Paper_DIN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_Paper_DIN.DropDownWidth = 200
        Me.ComboBox_Paper_DIN.FormattingEnabled = True
        Me.ComboBox_Paper_DIN.Location = New System.Drawing.Point(45, 56)
        Me.ComboBox_Paper_DIN.Name = "ComboBox_Paper_DIN"
        Me.ComboBox_Paper_DIN.Size = New System.Drawing.Size(57, 21)
        Me.ComboBox_Paper_DIN.TabIndex = 1
        Me.ComboBox_Paper_DIN.Tag = "DIN"
        '
        'PictureBox_Paper
        '
        Me.PictureBox_Paper.BackColor = System.Drawing.Color.FloralWhite
        Me.PictureBox_Paper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_Paper.Location = New System.Drawing.Point(201, 0)
        Me.PictureBox_Paper.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox_Paper.Name = "PictureBox_Paper"
        Me.PictureBox_Paper.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox_Paper.TabIndex = 46
        Me.PictureBox_Paper.TabStop = False
        '
        'TabPage_Card
        '
        Me.TabPage_Card.AutoScroll = True
        Me.TabPage_Card.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage_Card.Controls.Add(Me.TableLayoutPanel_Card)
        Me.TabPage_Card.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_Card.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage_Card.Name = "TabPage_Card"
        Me.TabPage_Card.Size = New System.Drawing.Size(632, 523)
        Me.TabPage_Card.TabIndex = 6
        Me.TabPage_Card.Text = "Karte"
        Me.TabPage_Card.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_Card
        '
        Me.TableLayoutPanel_Card.AutoScroll = True
        Me.TableLayoutPanel_Card.AutoSize = True
        Me.TableLayoutPanel_Card.ColumnCount = 2
        Me.TableLayoutPanel_Card.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel_Card.Controls.Add(Me.PictureBox_Card, 1, 0)
        Me.TableLayoutPanel_Card.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_Card.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_Card.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel_Card.Name = "TableLayoutPanel_Card"
        Me.TableLayoutPanel_Card.RowCount = 1
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card.Size = New System.Drawing.Size(628, 519)
        Me.TableLayoutPanel_Card.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Card_Size_Hight, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Card_Size_Width, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Card_Size_Width_Unit, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Card_Size_Hight_Value, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Card_Size_Hight_Unit, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Card_Size_Width_Value, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(85, 46)
        Me.TableLayoutPanel1.TabIndex = 53
        '
        'Label_Card_Size_Hight
        '
        Me.Label_Card_Size_Hight.AutoSize = True
        Me.Label_Card_Size_Hight.Location = New System.Drawing.Point(3, 3)
        Me.Label_Card_Size_Hight.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Card_Size_Hight.Name = "Label_Card_Size_Hight"
        Me.Label_Card_Size_Hight.Size = New System.Drawing.Size(31, 17)
        Me.Label_Card_Size_Hight.TabIndex = 28
        Me.Label_Card_Size_Hight.Text = "Höhe"
        Me.Label_Card_Size_Hight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Size_Hight.UseCompatibleTextRendering = True
        '
        'Label_Card_Size_Width
        '
        Me.Label_Card_Size_Width.AutoSize = True
        Me.Label_Card_Size_Width.Location = New System.Drawing.Point(3, 26)
        Me.Label_Card_Size_Width.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Card_Size_Width.Name = "Label_Card_Size_Width"
        Me.Label_Card_Size_Width.Size = New System.Drawing.Size(34, 17)
        Me.Label_Card_Size_Width.TabIndex = 29
        Me.Label_Card_Size_Width.Text = "Breite"
        Me.Label_Card_Size_Width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Size_Width.UseCompatibleTextRendering = True
        '
        'Label_Card_Size_Width_Unit
        '
        Me.Label_Card_Size_Width_Unit.AutoSize = True
        Me.Label_Card_Size_Width_Unit.Location = New System.Drawing.Point(59, 26)
        Me.Label_Card_Size_Width_Unit.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Card_Size_Width_Unit.Name = "Label_Card_Size_Width_Unit"
        Me.Label_Card_Size_Width_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Card_Size_Width_Unit.TabIndex = 51
        Me.Label_Card_Size_Width_Unit.Text = "mm"
        Me.Label_Card_Size_Width_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Size_Width_Unit.UseCompatibleTextRendering = True
        '
        'Label_Card_Size_Hight_Value
        '
        Me.Label_Card_Size_Hight_Value.AutoSize = True
        Me.Label_Card_Size_Hight_Value.Location = New System.Drawing.Point(43, 3)
        Me.Label_Card_Size_Hight_Value.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Card_Size_Hight_Value.Name = "Label_Card_Size_Hight_Value"
        Me.Label_Card_Size_Hight_Value.Size = New System.Drawing.Size(10, 17)
        Me.Label_Card_Size_Hight_Value.TabIndex = 29
        Me.Label_Card_Size_Hight_Value.Text = "0"
        Me.Label_Card_Size_Hight_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Size_Hight_Value.UseCompatibleTextRendering = True
        '
        'Label_Card_Size_Hight_Unit
        '
        Me.Label_Card_Size_Hight_Unit.AutoSize = True
        Me.Label_Card_Size_Hight_Unit.Location = New System.Drawing.Point(59, 3)
        Me.Label_Card_Size_Hight_Unit.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Card_Size_Hight_Unit.Name = "Label_Card_Size_Hight_Unit"
        Me.Label_Card_Size_Hight_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Card_Size_Hight_Unit.TabIndex = 52
        Me.Label_Card_Size_Hight_Unit.Text = "mm"
        Me.Label_Card_Size_Hight_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Size_Hight_Unit.UseCompatibleTextRendering = True
        '
        'Label_Card_Size_Width_Value
        '
        Me.Label_Card_Size_Width_Value.AutoSize = True
        Me.Label_Card_Size_Width_Value.Location = New System.Drawing.Point(43, 26)
        Me.Label_Card_Size_Width_Value.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Card_Size_Width_Value.Name = "Label_Card_Size_Width_Value"
        Me.Label_Card_Size_Width_Value.Size = New System.Drawing.Size(10, 17)
        Me.Label_Card_Size_Width_Value.TabIndex = 30
        Me.Label_Card_Size_Width_Value.Text = "0"
        Me.Label_Card_Size_Width_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Size_Width_Value.UseCompatibleTextRendering = True
        '
        'PictureBox_Card
        '
        Me.PictureBox_Card.BackColor = System.Drawing.Color.FloralWhite
        Me.PictureBox_Card.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_Card.Location = New System.Drawing.Point(94, 3)
        Me.PictureBox_Card.Name = "PictureBox_Card"
        Me.PictureBox_Card.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox_Card.TabIndex = 46
        Me.PictureBox_Card.TabStop = False
        '
        'TabPage_CardRow
        '
        Me.TabPage_CardRow.AutoScroll = True
        Me.TabPage_CardRow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage_CardRow.Controls.Add(Me.TableLayoutPanel_CardRow)
        Me.TabPage_CardRow.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_CardRow.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage_CardRow.Name = "TabPage_CardRow"
        Me.TabPage_CardRow.Size = New System.Drawing.Size(632, 523)
        Me.TabPage_CardRow.TabIndex = 7
        Me.TabPage_CardRow.Text = "Zeile"
        Me.TabPage_CardRow.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_CardRow
        '
        Me.TableLayoutPanel_CardRow.AutoSize = True
        Me.TableLayoutPanel_CardRow.ColumnCount = 2
        Me.TableLayoutPanel_CardRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_CardRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_CardRow.Controls.Add(Me.PictureBox_CardRow, 1, 0)
        Me.TableLayoutPanel_CardRow.Controls.Add(Me.TableLayoutPanel_CardRow_ListBox, 0, 0)
        Me.TableLayoutPanel_CardRow.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel_CardRow.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_CardRow.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel_CardRow.Name = "TableLayoutPanel_CardRow"
        Me.TableLayoutPanel_CardRow.RowCount = 2
        Me.TableLayoutPanel_CardRow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow.Size = New System.Drawing.Size(628, 226)
        Me.TableLayoutPanel_CardRow.TabIndex = 0
        '
        'PictureBox_CardRow
        '
        Me.PictureBox_CardRow.BackColor = System.Drawing.Color.FloralWhite
        Me.PictureBox_CardRow.Location = New System.Drawing.Point(214, 0)
        Me.PictureBox_CardRow.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox_CardRow.Name = "PictureBox_CardRow"
        Me.PictureBox_CardRow.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox_CardRow.TabIndex = 46
        Me.PictureBox_CardRow.TabStop = False
        '
        'TableLayoutPanel_CardRow_ListBox
        '
        Me.TableLayoutPanel_CardRow_ListBox.AutoSize = True
        Me.TableLayoutPanel_CardRow_ListBox.ColumnCount = 5
        Me.TableLayoutPanel_CardRow_ListBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_CardRow_ListBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_CardRow_ListBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_CardRow_ListBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_CardRow_ListBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_CardRow_ListBox.Controls.Add(Me.ListBox_CardRow, 0, 0)
        Me.TableLayoutPanel_CardRow_ListBox.Controls.Add(Me.Button_CardRow_FontColor, 2, 5)
        Me.TableLayoutPanel_CardRow_ListBox.Controls.Add(Me.Label_CardRow_DataColumn, 0, 2)
        Me.TableLayoutPanel_CardRow_ListBox.Controls.Add(Me.ComboBox_CardRow_DataColumn, 1, 2)
        Me.TableLayoutPanel_CardRow_ListBox.Controls.Add(Me.Label_CardRow_QRCode, 0, 3)
        Me.TableLayoutPanel_CardRow_ListBox.Controls.Add(Me.Label_CardRow_AutoFont, 0, 4)
        Me.TableLayoutPanel_CardRow_ListBox.Controls.Add(Me.Label_CardRow_FontColor, 0, 5)
        Me.TableLayoutPanel_CardRow_ListBox.Controls.Add(Me.CheckBox_CardRow_AutoFont, 2, 4)
        Me.TableLayoutPanel_CardRow_ListBox.Controls.Add(Me.CheckBox_CardRow_QRCode, 2, 3)
        Me.TableLayoutPanel_CardRow_ListBox.Controls.Add(Me.Label_CardRow_LinePos, 0, 1)
        Me.TableLayoutPanel_CardRow_ListBox.Controls.Add(Me.Label_CardRow_LinePos_Value, 1, 1)
        Me.TableLayoutPanel_CardRow_ListBox.Controls.Add(Me.FlowLayoutPanel2, 4, 0)
        Me.TableLayoutPanel_CardRow_ListBox.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_CardRow_ListBox.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel_CardRow_ListBox.Name = "TableLayoutPanel_CardRow_ListBox"
        Me.TableLayoutPanel_CardRow_ListBox.RowCount = 6
        Me.TableLayoutPanel_CardRow_ListBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_CardRow_ListBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow_ListBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow_ListBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow_ListBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow_ListBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow_ListBox.Size = New System.Drawing.Size(214, 226)
        Me.TableLayoutPanel_CardRow_ListBox.TabIndex = 47
        '
        'ListBox_CardRow
        '
        Me.TableLayoutPanel_CardRow_ListBox.SetColumnSpan(Me.ListBox_CardRow, 4)
        Me.ListBox_CardRow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox_CardRow.FormattingEnabled = True
        Me.ListBox_CardRow.IntegralHeight = False
        Me.ListBox_CardRow.Location = New System.Drawing.Point(3, 3)
        Me.ListBox_CardRow.Name = "ListBox_CardRow"
        Me.ListBox_CardRow.Size = New System.Drawing.Size(158, 97)
        Me.ListBox_CardRow.TabIndex = 1
        '
        'Button_CardRow_FontColor
        '
        Me.Button_CardRow_FontColor.Enabled = False
        Me.Button_CardRow_FontColor.ForeColor = System.Drawing.Color.Black
        Me.Button_CardRow_FontColor.Location = New System.Drawing.Point(71, 202)
        Me.Button_CardRow_FontColor.Name = "Button_CardRow_FontColor"
        Me.Button_CardRow_FontColor.Size = New System.Drawing.Size(21, 21)
        Me.Button_CardRow_FontColor.TabIndex = 29
        Me.Button_CardRow_FontColor.UseVisualStyleBackColor = True
        '
        'Label_CardRow_DataColumn
        '
        Me.Label_CardRow_DataColumn.AutoSize = True
        Me.Label_CardRow_DataColumn.Location = New System.Drawing.Point(3, 129)
        Me.Label_CardRow_DataColumn.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_CardRow_DataColumn.Name = "Label_CardRow_DataColumn"
        Me.Label_CardRow_DataColumn.Size = New System.Drawing.Size(36, 17)
        Me.Label_CardRow_DataColumn.TabIndex = 18
        Me.Label_CardRow_DataColumn.Text = "Spalte"
        Me.Label_CardRow_DataColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_DataColumn.UseCompatibleTextRendering = True
        '
        'ComboBox_CardRow_DataColumn
        '
        Me.TableLayoutPanel_CardRow_ListBox.SetColumnSpan(Me.ComboBox_CardRow_DataColumn, 3)
        Me.ComboBox_CardRow_DataColumn.FormattingEnabled = True
        Me.ComboBox_CardRow_DataColumn.Location = New System.Drawing.Point(45, 129)
        Me.ComboBox_CardRow_DataColumn.Name = "ComboBox_CardRow_DataColumn"
        Me.ComboBox_CardRow_DataColumn.Size = New System.Drawing.Size(116, 21)
        Me.ComboBox_CardRow_DataColumn.TabIndex = 27
        '
        'Label_CardRow_QRCode
        '
        Me.Label_CardRow_QRCode.AutoSize = True
        Me.TableLayoutPanel_CardRow_ListBox.SetColumnSpan(Me.Label_CardRow_QRCode, 2)
        Me.Label_CardRow_QRCode.Location = New System.Drawing.Point(3, 156)
        Me.Label_CardRow_QRCode.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_CardRow_QRCode.Name = "Label_CardRow_QRCode"
        Me.Label_CardRow_QRCode.Size = New System.Drawing.Size(52, 17)
        Me.Label_CardRow_QRCode.TabIndex = 19
        Me.Label_CardRow_QRCode.Text = "QR-Code"
        Me.Label_CardRow_QRCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_QRCode.UseCompatibleTextRendering = True
        '
        'Label_CardRow_AutoFont
        '
        Me.Label_CardRow_AutoFont.AutoSize = True
        Me.TableLayoutPanel_CardRow_ListBox.SetColumnSpan(Me.Label_CardRow_AutoFont, 2)
        Me.Label_CardRow_AutoFont.Location = New System.Drawing.Point(3, 179)
        Me.Label_CardRow_AutoFont.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_CardRow_AutoFont.Name = "Label_CardRow_AutoFont"
        Me.Label_CardRow_AutoFont.Size = New System.Drawing.Size(54, 17)
        Me.Label_CardRow_AutoFont.TabIndex = 26
        Me.Label_CardRow_AutoFont.Text = "Auto-Font"
        Me.Label_CardRow_AutoFont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_AutoFont.UseCompatibleTextRendering = True
        '
        'Label_CardRow_FontColor
        '
        Me.Label_CardRow_FontColor.AutoSize = True
        Me.TableLayoutPanel_CardRow_ListBox.SetColumnSpan(Me.Label_CardRow_FontColor, 2)
        Me.Label_CardRow_FontColor.Location = New System.Drawing.Point(3, 202)
        Me.Label_CardRow_FontColor.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_CardRow_FontColor.Name = "Label_CardRow_FontColor"
        Me.Label_CardRow_FontColor.Size = New System.Drawing.Size(62, 17)
        Me.Label_CardRow_FontColor.TabIndex = 28
        Me.Label_CardRow_FontColor.Text = "Schriftfarbe"
        Me.Label_CardRow_FontColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_FontColor.UseCompatibleTextRendering = True
        '
        'CheckBox_CardRow_AutoFont
        '
        Me.CheckBox_CardRow_AutoFont.AutoSize = True
        Me.CheckBox_CardRow_AutoFont.Location = New System.Drawing.Point(71, 179)
        Me.CheckBox_CardRow_AutoFont.Name = "CheckBox_CardRow_AutoFont"
        Me.CheckBox_CardRow_AutoFont.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox_CardRow_AutoFont.TabIndex = 25
        Me.CheckBox_CardRow_AutoFont.UseVisualStyleBackColor = True
        '
        'CheckBox_CardRow_QRCode
        '
        Me.CheckBox_CardRow_QRCode.AutoSize = True
        Me.CheckBox_CardRow_QRCode.Location = New System.Drawing.Point(71, 156)
        Me.CheckBox_CardRow_QRCode.Name = "CheckBox_CardRow_QRCode"
        Me.CheckBox_CardRow_QRCode.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox_CardRow_QRCode.TabIndex = 24
        Me.CheckBox_CardRow_QRCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_CardRow_QRCode.UseVisualStyleBackColor = True
        '
        'Label_CardRow_LinePos
        '
        Me.Label_CardRow_LinePos.AutoSize = True
        Me.Label_CardRow_LinePos.Location = New System.Drawing.Point(3, 106)
        Me.Label_CardRow_LinePos.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_CardRow_LinePos.Name = "Label_CardRow_LinePos"
        Me.Label_CardRow_LinePos.Size = New System.Drawing.Size(29, 17)
        Me.Label_CardRow_LinePos.TabIndex = 23
        Me.Label_CardRow_LinePos.Text = "Zeile"
        Me.Label_CardRow_LinePos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label_CardRow_LinePos.UseCompatibleTextRendering = True
        '
        'Label_CardRow_LinePos_Value
        '
        Me.Label_CardRow_LinePos_Value.AutoSize = True
        Me.Label_CardRow_LinePos_Value.Location = New System.Drawing.Point(45, 106)
        Me.Label_CardRow_LinePos_Value.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_CardRow_LinePos_Value.Name = "Label_CardRow_LinePos_Value"
        Me.Label_CardRow_LinePos_Value.Size = New System.Drawing.Size(13, 13)
        Me.Label_CardRow_LinePos_Value.TabIndex = 11
        Me.Label_CardRow_LinePos_Value.Text = "0"
        Me.Label_CardRow_LinePos_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.Button_CardRow_Up)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button_CardRow_Down)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button_CardRow_Edit)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button_CardRow_Add)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button_CardRow_Delete)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(167, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.TableLayoutPanel_CardRow_ListBox.SetRowSpan(Me.FlowLayoutPanel2, 6)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(44, 220)
        Me.FlowLayoutPanel2.TabIndex = 30
        '
        'Button_CardRow_Up
        '
        Me.Button_CardRow_Up.AutoSize = True
        Me.Button_CardRow_Up.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button_CardRow_Up.Enabled = False
        Me.Button_CardRow_Up.ImageKey = "Arrow_Green_Up"
        Me.Button_CardRow_Up.ImageList = Me.ImageList_Main
        Me.Button_CardRow_Up.Location = New System.Drawing.Point(3, 3)
        Me.Button_CardRow_Up.Name = "Button_CardRow_Up"
        Me.Button_CardRow_Up.Size = New System.Drawing.Size(38, 38)
        Me.Button_CardRow_Up.TabIndex = 0
        Me.Button_CardRow_Up.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        Me.Button_CardRow_Down.Location = New System.Drawing.Point(3, 47)
        Me.Button_CardRow_Down.Name = "Button_CardRow_Down"
        Me.Button_CardRow_Down.Size = New System.Drawing.Size(38, 38)
        Me.Button_CardRow_Down.TabIndex = 1
        Me.Button_CardRow_Down.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_CardRow_Down.UseCompatibleTextRendering = True
        Me.Button_CardRow_Down.UseVisualStyleBackColor = False
        '
        'Button_CardRow_Edit
        '
        Me.Button_CardRow_Edit.AutoSize = True
        Me.Button_CardRow_Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button_CardRow_Edit.Enabled = False
        Me.Button_CardRow_Edit.ImageKey = "Edit"
        Me.Button_CardRow_Edit.ImageList = Me.ImageList_Main
        Me.Button_CardRow_Edit.Location = New System.Drawing.Point(3, 91)
        Me.Button_CardRow_Edit.Name = "Button_CardRow_Edit"
        Me.Button_CardRow_Edit.Size = New System.Drawing.Size(38, 38)
        Me.Button_CardRow_Edit.TabIndex = 5
        Me.Button_CardRow_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_CardRow_Edit.UseCompatibleTextRendering = True
        Me.Button_CardRow_Edit.UseVisualStyleBackColor = False
        '
        'Button_CardRow_Add
        '
        Me.Button_CardRow_Add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button_CardRow_Add.AutoSize = True
        Me.Button_CardRow_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button_CardRow_Add.ImageKey = "Plus"
        Me.Button_CardRow_Add.ImageList = Me.ImageList_Main
        Me.Button_CardRow_Add.Location = New System.Drawing.Point(3, 135)
        Me.Button_CardRow_Add.Name = "Button_CardRow_Add"
        Me.Button_CardRow_Add.Size = New System.Drawing.Size(38, 38)
        Me.Button_CardRow_Add.TabIndex = 2
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
        Me.Button_CardRow_Delete.Location = New System.Drawing.Point(3, 179)
        Me.Button_CardRow_Delete.Name = "Button_CardRow_Delete"
        Me.Button_CardRow_Delete.Size = New System.Drawing.Size(38, 38)
        Me.Button_CardRow_Delete.TabIndex = 3
        Me.Button_CardRow_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_CardRow_Delete.UseCompatibleTextRendering = True
        Me.Button_CardRow_Delete.UseVisualStyleBackColor = False
        '
        'TabPage_DataSet
        '
        Me.TabPage_DataSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage_DataSet.Controls.Add(Me.TableLayoutPanel_DataSet)
        Me.TabPage_DataSet.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_DataSet.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage_DataSet.Name = "TabPage_DataSet"
        Me.TabPage_DataSet.Size = New System.Drawing.Size(632, 523)
        Me.TabPage_DataSet.TabIndex = 4
        Me.TabPage_DataSet.Text = "DataSet"
        Me.TabPage_DataSet.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_DataSet
        '
        Me.TableLayoutPanel_DataSet.AutoSize = True
        Me.TableLayoutPanel_DataSet.ColumnCount = 2
        Me.TableLayoutPanel_DataSet.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_DataSet.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_DataSet.Controls.Add(Me.ListBox_Tabellen, 0, 0)
        Me.TableLayoutPanel_DataSet.Controls.Add(Me.DGV_Table, 1, 0)
        Me.TableLayoutPanel_DataSet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_DataSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TableLayoutPanel_DataSet.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_DataSet.Name = "TableLayoutPanel_DataSet"
        Me.TableLayoutPanel_DataSet.RowCount = 1
        Me.TableLayoutPanel_DataSet.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_DataSet.Size = New System.Drawing.Size(628, 519)
        Me.TableLayoutPanel_DataSet.TabIndex = 3
        '
        'ListBox_Tabellen
        '
        Me.ListBox_Tabellen.BackColor = System.Drawing.SystemColors.Control
        Me.ListBox_Tabellen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_Tabellen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox_Tabellen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ListBox_Tabellen.FormattingEnabled = True
        Me.ListBox_Tabellen.Location = New System.Drawing.Point(3, 3)
        Me.ListBox_Tabellen.Name = "ListBox_Tabellen"
        Me.ListBox_Tabellen.Size = New System.Drawing.Size(131, 513)
        Me.ListBox_Tabellen.TabIndex = 2
        '
        'DGV_Table
        '
        Me.DGV_Table.AllowUserToAddRows = False
        Me.DGV_Table.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Table.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        Me.DGV_Table.Size = New System.Drawing.Size(485, 513)
        Me.DGV_Table.TabIndex = 0
        '
        'ToolStripMenuItem_Beenden
        '
        Me.ToolStripMenuItem_Beenden.Name = "ToolStripMenuItem_Beenden"
        Me.ToolStripMenuItem_Beenden.Size = New System.Drawing.Size(169, 30)
        Me.ToolStripMenuItem_Beenden.Text = "&Beenden"
        '
        'ToolStripSeparator03
        '
        Me.ToolStripSeparator03.Name = "ToolStripSeparator03"
        Me.ToolStripSeparator03.Size = New System.Drawing.Size(166, 6)
        '
        'ToolStripSeparator02
        '
        Me.ToolStripSeparator02.Name = "ToolStripSeparator02"
        Me.ToolStripSeparator02.Size = New System.Drawing.Size(166, 6)
        '
        'ToolStripMenuItem_XML_SaveAs
        '
        Me.ToolStripMenuItem_XML_SaveAs.Name = "ToolStripMenuItem_XML_SaveAs"
        Me.ToolStripMenuItem_XML_SaveAs.Size = New System.Drawing.Size(169, 30)
        Me.ToolStripMenuItem_XML_SaveAs.Text = "Speichern &unter"
        '
        'ToolStripSeparator01
        '
        Me.ToolStripSeparator01.Name = "ToolStripSeparator01"
        Me.ToolStripSeparator01.Size = New System.Drawing.Size(166, 6)
        '
        'ToolStripMenuItem_Datei
        '
        Me.ToolStripMenuItem_Datei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator01, Me.ToolStripMenuItem_XML_SaveAs, Me.ToolStripSeparator02, Me.ToolStripMenuItem_Print, Me.ToolStripMenuItem_Seitenansicht, Me.ToolStripSeparator03, Me.ToolStripMenuItem_Beenden})
        Me.ToolStripMenuItem_Datei.Name = "ToolStripMenuItem_Datei"
        Me.ToolStripMenuItem_Datei.Size = New System.Drawing.Size(46, 28)
        Me.ToolStripMenuItem_Datei.Text = "&Datei"
        '
        'ToolStripMenuItem_Print
        '
        Me.ToolStripMenuItem_Print.Image = CType(resources.GetObject("ToolStripMenuItem_Print.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem_Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem_Print.Name = "ToolStripMenuItem_Print"
        Me.ToolStripMenuItem_Print.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_Print.Size = New System.Drawing.Size(169, 30)
        Me.ToolStripMenuItem_Print.Text = "&Drucken"
        '
        'ToolStripMenuItem_Seitenansicht
        '
        Me.ToolStripMenuItem_Seitenansicht.Image = CType(resources.GetObject("ToolStripMenuItem_Seitenansicht.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem_Seitenansicht.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem_Seitenansicht.Name = "ToolStripMenuItem_Seitenansicht"
        Me.ToolStripMenuItem_Seitenansicht.Size = New System.Drawing.Size(169, 30)
        Me.ToolStripMenuItem_Seitenansicht.Text = "&Seitenansicht"
        '
        'MenuStrip_Main
        '
        Me.MenuStrip_Main.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip_Main.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Datei, Me.ToolStripMenuItem1, Me.ToolStripMenuItem_Open, Me.ToolStripMenuItem_Save, Me.TestToolStripMenuItem})
        Me.MenuStrip_Main.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip_Main.Name = "MenuStrip_Main"
        Me.MenuStrip_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip_Main.Size = New System.Drawing.Size(640, 32)
        Me.MenuStrip_Main.TabIndex = 4
        Me.MenuStrip_Main.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(65, 28)
        Me.ToolStripMenuItem1.Text = "&Neu"
        '
        'ToolStripMenuItem_Open
        '
        Me.ToolStripMenuItem_Open.Image = CType(resources.GetObject("ToolStripMenuItem_Open.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem_Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem_Open.Name = "ToolStripMenuItem_Open"
        Me.ToolStripMenuItem_Open.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_Open.Size = New System.Drawing.Size(80, 28)
        Me.ToolStripMenuItem_Open.Text = "Ö&ffnen"
        '
        'ToolStripMenuItem_Save
        '
        Me.ToolStripMenuItem_Save.Enabled = False
        Me.ToolStripMenuItem_Save.Image = Global.CSVtoQR.My.Resources.Resources.Save
        Me.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save"
        Me.ToolStripMenuItem_Save.Size = New System.Drawing.Size(95, 28)
        Me.ToolStripMenuItem_Save.Text = "Speichern"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(40, 28)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'ToolStripStatusLabel_SaveFile
        '
        Me.ToolStripStatusLabel_SaveFile.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripStatusLabel_SaveFile.Name = "ToolStripStatusLabel_SaveFile"
        Me.ToolStripStatusLabel_SaveFile.Size = New System.Drawing.Size(37, 24)
        Me.ToolStripStatusLabel_SaveFile.Text = "Bereit"
        '
        'ToolStripStatusLabel_SaveInfo
        '
        Me.ToolStripStatusLabel_SaveInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel_SaveInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripStatusLabel_SaveInfo.Name = "ToolStripStatusLabel_SaveInfo"
        Me.ToolStripStatusLabel_SaveInfo.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.ToolStripStatusLabel_SaveInfo.Size = New System.Drawing.Size(110, 24)
        Me.ToolStripStatusLabel_SaveInfo.Text = "Gespeichert in: "
        '
        'ToolStripStatusLabel_IsModified
        '
        Me.ToolStripStatusLabel_IsModified.BackColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel_IsModified.Image = Global.CSVtoQR.My.Resources.Resources.Edit
        Me.ToolStripStatusLabel_IsModified.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripStatusLabel_IsModified.Name = "ToolStripStatusLabel_IsModified"
        Me.ToolStripStatusLabel_IsModified.Size = New System.Drawing.Size(24, 24)
        '
        'StatusStrip_Main
        '
        Me.StatusStrip_Main.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_IsModified, Me.ToolStripStatusLabel_SaveInfo, Me.ToolStripStatusLabel_SaveFile})
        Me.StatusStrip_Main.Location = New System.Drawing.Point(3, 587)
        Me.StatusStrip_Main.Name = "StatusStrip_Main"
        Me.StatusStrip_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip_Main.Size = New System.Drawing.Size(640, 24)
        Me.StatusStrip_Main.SizingGrip = False
        Me.StatusStrip_Main.TabIndex = 5
        Me.StatusStrip_Main.Text = "StatusStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(646, 614)
        Me.Controls.Add(Me.TabControl_Main)
        Me.Controls.Add(Me.StatusStrip_Main)
        Me.Controls.Add(Me.MenuStrip_Main)
        MySettings1.LastDirectory = "C:\"
        MySettings1.LastFile = "C:\"
        MySettings1.Main_Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        MySettings1.MyLocation = New System.Drawing.Point(100, 100)
        MySettings1.MySize = New System.Drawing.Size(600, 600)
        MySettings1.SettingsKey = ""
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ClientSize", MySettings1, "MySize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.CSVtoQR.My.MySettings.Default, "MyLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Location = Global.CSVtoQR.My.MySettings.Default.MyLocation
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Text = "Form1"
        CType(Me.NumericUpDown_Separator_Column_Count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Separator_Row_Value, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Separator_Row_Count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Separator_Column_Value, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel_CSV.ResumeLayout(False)
        Me.TableLayoutPanel_CSV.PerformLayout()
        CType(Me.DGV_Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_CSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.PictureBox_CSV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator_CSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator_CSV.ResumeLayout(False)
        Me.BindingNavigator_CSV.PerformLayout()
        Me.TabPage_CSV.ResumeLayout(False)
        Me.TabPage_CSV.PerformLayout()
        Me.TabControl_Main.ResumeLayout(False)
        Me.TabPage_General.ResumeLayout(False)
        Me.TabPage_General.PerformLayout()
        Me.TabPage_Paper.ResumeLayout(False)
        Me.TabPage_Paper.PerformLayout()
        Me.TableLayoutPanel_Paper.ResumeLayout(False)
        Me.TableLayoutPanel_Paper.PerformLayout()
        CType(Me.PictureBox_Paper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Card.ResumeLayout(False)
        Me.TabPage_Card.PerformLayout()
        Me.TableLayoutPanel_Card.ResumeLayout(False)
        Me.TableLayoutPanel_Card.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox_Card, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_CardRow.ResumeLayout(False)
        Me.TabPage_CardRow.PerformLayout()
        Me.TableLayoutPanel_CardRow.ResumeLayout(False)
        Me.TableLayoutPanel_CardRow.PerformLayout()
        CType(Me.PictureBox_CardRow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel_CardRow_ListBox.ResumeLayout(False)
        Me.TableLayoutPanel_CardRow_ListBox.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.TabPage_DataSet.ResumeLayout(False)
        Me.TabPage_DataSet.PerformLayout()
        Me.TableLayoutPanel_DataSet.ResumeLayout(False)
        CType(Me.DGV_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip_Main.ResumeLayout(False)
        Me.MenuStrip_Main.PerformLayout()
        Me.StatusStrip_Main.ResumeLayout(False)
        Me.StatusStrip_Main.PerformLayout()
        CType(Me.BindingSource_CSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Separator_Row As Label
    Friend WithEvents Label_Paper_Paper As Label
    Friend WithEvents TextBox_Paper_Paper As TextBox
    Friend WithEvents Label_Paper_Width As Label
    Friend WithEvents Label_Paper_Height As Label
    Friend WithEvents Label_Paper_DPI As Label
    Friend WithEvents Label_Paper_DIN As Label
    Friend WithEvents ComboBox_Paper_DIN As ComboBox
    Friend WithEvents Label_Paper_Height_Unit As Label
    Friend WithEvents Label_Paper_Width_Unit As Label
    Friend WithEvents ImageList_Main As ImageList
    Friend WithEvents TableLayoutPanel_CSV As TableLayoutPanel
    Friend WithEvents Button_Search_Add As Button
    Friend WithEvents Button_Search_Delete As Button
    Friend WithEvents DGV_Search As DataGridView
    Friend WithEvents TabPage_CSV As TabPage
    Friend WithEvents TabControl_Main As TabControl
    Friend WithEvents TabPage_Paper As TabPage
    Friend WithEvents TabPage_DataSet As TabPage
    Friend WithEvents DGV_Table As DataGridView
    Friend WithEvents ListBox_Tabellen As ListBox
    Friend WithEvents ToolStripMenuItem_Beenden As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator03 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem_Seitenansicht As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Print As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator02 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem_XML_SaveAs As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator01 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem_Datei As ToolStripMenuItem
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
    Friend WithEvents Button_CardRow_Add As Button
    Friend WithEvents Button_CardRow_Delete As Button
    Friend WithEvents TabPage_General As TabPage
    Friend WithEvents TableLayoutPanel_DataSet As TableLayoutPanel
    Friend WithEvents ToolStripMenuItem_Save As ToolStripMenuItem
    Friend WithEvents Button_CardRow_Up As Button
    Friend WithEvents Button_CardRow_Down As Button
    Friend WithEvents Label_CardRow_LinePos_Value As Label
    Friend WithEvents Button_CardRow_Edit As Button
    Friend WithEvents Label_CardRow_FontColor As Label
    Friend WithEvents Button_CardRow_FontColor As Button
    Friend WithEvents Label_Separator_Column As Label
    Friend WithEvents TableLayoutPanel_General As TableLayoutPanel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TableLayoutPanel_CardRow As TableLayoutPanel
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Open As ToolStripMenuItem
    Friend WithEvents PictureBox_Paper As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label_Card_Size_Hight As Label
    Friend WithEvents Label_Card_Size_Width As Label
    Friend WithEvents Label_Card_Size_Width_Unit As Label
    Friend WithEvents Label_Card_Size_Hight_Value As Label
    Friend WithEvents Label_Card_Size_Hight_Unit As Label
    Friend WithEvents Label_Card_Size_Width_Value As Label
    Friend WithEvents PictureBox_Card As PictureBox
    Friend WithEvents PictureBox_CardRow As PictureBox
    Friend WithEvents PictureBox_CSV As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel_CardRow_ListBox As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label_Header As Label
End Class
