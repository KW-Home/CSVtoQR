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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label_Separator_Row_Count = New System.Windows.Forms.Label()
        Me.Label_Separator_Row_Value = New System.Windows.Forms.Label()
        Me.TableLayoutPanel_Separator = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Separator_Column_Value_Unit = New System.Windows.Forms.Label()
        Me.Label_Separator_Column_Count = New System.Windows.Forms.Label()
        Me.Label_Separator_Column_Value = New System.Windows.Forms.Label()
        Me.NumericUpDown_Separator_Column_Count = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Separator_Column_Value = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Separator_Row_Count = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Separator_Row_Value = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox_Separator_Row = New System.Windows.Forms.GroupBox()
        Me.Label_Paper_Border_Left = New System.Windows.Forms.Label()
        Me.Label_Paper_Border_Bottom = New System.Windows.Forms.Label()
        Me.Label_Paper_Border_Top = New System.Windows.Forms.Label()
        Me.Label_Paper_Border_Right = New System.Windows.Forms.Label()
        Me.Label_Paper_Width = New System.Windows.Forms.Label()
        Me.Label_Paper_Height = New System.Windows.Forms.Label()
        Me.Label_Paper_DPI = New System.Windows.Forms.Label()
        Me.Label_Paper_DIN = New System.Windows.Forms.Label()
        Me.NumericUpDown_Paper_Border_Top = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Paper_Border_Bottom = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Paper_Border_Left = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Paper_Border_Right = New System.Windows.Forms.NumericUpDown()
        Me.FontDialog_Main = New System.Windows.Forms.FontDialog()
        Me.Label_Import = New System.Windows.Forms.Label()
        Me.TextBox_Import = New System.Windows.Forms.TextBox()
        Me.Label_Export = New System.Windows.Forms.Label()
        Me.TextBox_Export = New System.Windows.Forms.TextBox()
        Me.ImageList_Main = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel_Files = New System.Windows.Forms.TableLayoutPanel()
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
        Me.Button_Import = New System.Windows.Forms.Button()
        Me.Button_Export = New System.Windows.Forms.Button()
        Me.Button_Search_Refresh = New System.Windows.Forms.Button()
        Me.TabPage_Files = New System.Windows.Forms.TabPage()
        Me.TabControl_Main = New System.Windows.Forms.TabControl()
        Me.TabPage_Paper = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel_Paper = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox_Separator_Column = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Separator_Column = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Separator_Row_Value_Unit = New System.Windows.Forms.Label()
        Me.GroupBox_Paper_Border = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Paper_Border = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Paper_Border_Right_Unit = New System.Windows.Forms.Label()
        Me.Label_Paper_Border_Top_Unit = New System.Windows.Forms.Label()
        Me.Label_Paper_Border_Bottom_Unit = New System.Windows.Forms.Label()
        Me.Label_Paper_Border_Left_Unit = New System.Windows.Forms.Label()
        Me.GroupBox_Shema = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Shema = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Paper_Width_Unit = New System.Windows.Forms.Label()
        Me.Label_Paper_Height_Unit = New System.Windows.Forms.Label()
        Me.Label_Paper_Width_Value = New System.Windows.Forms.Label()
        Me.Label_Shema = New System.Windows.Forms.Label()
        Me.Label_Paper_Height_Value = New System.Windows.Forms.Label()
        Me.ComboBox_Paper_DPI = New System.Windows.Forms.ComboBox()
        Me.TextBox_Shema = New System.Windows.Forms.TextBox()
        Me.ComboBox_Paper_DIN = New System.Windows.Forms.ComboBox()
        Me.TabPage_Card = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel_Card = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox_Card_Size = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Card_Size = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Card_Size_Hight = New System.Windows.Forms.Label()
        Me.Label_Card_Size_Hight_Value = New System.Windows.Forms.Label()
        Me.Label_Card_Size_Width = New System.Windows.Forms.Label()
        Me.Label_Card_Size_Width_Value = New System.Windows.Forms.Label()
        Me.GroupBox_Card_Border = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Card_Border = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Card_Border_Bottom_Unit = New System.Windows.Forms.Label()
        Me.Label_Card_Border_Bottom = New System.Windows.Forms.Label()
        Me.Label_Card_Border_Top_Unit = New System.Windows.Forms.Label()
        Me.NumericUpDown_Card_Border_Left = New System.Windows.Forms.NumericUpDown()
        Me.Label_Card_Border_Right_Unit = New System.Windows.Forms.Label()
        Me.Label_Card_Border_Top = New System.Windows.Forms.Label()
        Me.Label_Card_Border_Left_Unit = New System.Windows.Forms.Label()
        Me.NumericUpDown_Card_Border_Right = New System.Windows.Forms.NumericUpDown()
        Me.Label_Card_Border_Right = New System.Windows.Forms.Label()
        Me.NumericUpDown_Card_Border_Top = New System.Windows.Forms.NumericUpDown()
        Me.Label_Card_Border_Left = New System.Windows.Forms.Label()
        Me.NumericUpDown_Card_Border_Bottom = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox_Card_Font = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Card_Font = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Card_Font = New System.Windows.Forms.Label()
        Me.Label_Card_Font_Value = New System.Windows.Forms.Label()
        Me.Label_Card_FontColor = New System.Windows.Forms.Label()
        Me.Label_Card_FontColor_Value = New System.Windows.Forms.Label()
        Me.TabPage_Row = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel_CardRow = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox_CardRow_Border = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Row_Border = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_CardRow_Border_Bottom_Unit = New System.Windows.Forms.Label()
        Me.Label_CardRow_Border_Left = New System.Windows.Forms.Label()
        Me.Label_CardRow_Border_Top_Unit = New System.Windows.Forms.Label()
        Me.Label_CardRow_Border_Right_Unit = New System.Windows.Forms.Label()
        Me.NumericUpDown_CardRow_Border_Left = New System.Windows.Forms.NumericUpDown()
        Me.Label_CardRow_Border_Right = New System.Windows.Forms.Label()
        Me.Label_CardRow_Border_Left_Unit = New System.Windows.Forms.Label()
        Me.Label_CardRow_Border_Bottom = New System.Windows.Forms.Label()
        Me.NumericUpDown_CardRow_Border_Right = New System.Windows.Forms.NumericUpDown()
        Me.Label_CardRow_Border_Top = New System.Windows.Forms.Label()
        Me.NumericUpDown_CardRow_Border_Top = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_CardRow_Border_Bottom = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox_CardRow_Line = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Row_Line = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_CardRow_DataColumn = New System.Windows.Forms.Label()
        Me.ComboBox_CardRow_DataColumn = New System.Windows.Forms.ComboBox()
        Me.Label_CardRow_AutoFont = New System.Windows.Forms.Label()
        Me.CheckBox_CardRow_AutoFont = New System.Windows.Forms.CheckBox()
        Me.Label_CardRow_QRCode = New System.Windows.Forms.Label()
        Me.CheckBox_CardRow_QRCode = New System.Windows.Forms.CheckBox()
        Me.Label_CardRow_LinePos = New System.Windows.Forms.Label()
        Me.NumericUpDown_CardRow_LinePos = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox_CardRow_List = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_CardRow_List = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBox_CardRow_List = New System.Windows.Forms.ListBox()
        Me.Button_CardRow_List_Add = New System.Windows.Forms.Button()
        Me.Button_CardRow_List_Delete = New System.Windows.Forms.Button()
        Me.TabPage_Table = New System.Windows.Forms.TabPage()
        Me.DGV_Table = New System.Windows.Forms.DataGridView()
        Me.ListBox_Tabellen = New System.Windows.Forms.ListBox()
        Me.Panel_Preview = New System.Windows.Forms.Panel()
        Me.PictureBox_Preview = New System.Windows.Forms.PictureBox()
        Me.ToolStripMenuItem_Optionen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Font = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Anpassen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Extras = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ToolStripStatusLabel_SaveFile = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_SaveInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_IsModified = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip_Main = New System.Windows.Forms.StatusStrip()
        Me.BindingSource_CSV = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer_Main = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel_Separator.SuspendLayout()
        CType(Me.NumericUpDown_Separator_Column_Count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Separator_Column_Value, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Separator_Row_Count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Separator_Row_Value, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Separator_Row.SuspendLayout()
        CType(Me.NumericUpDown_Paper_Border_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Paper_Border_Bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Paper_Border_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Paper_Border_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel_Files.SuspendLayout()
        CType(Me.DGV_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_CSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator_CSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator_CSV.SuspendLayout()
        Me.TabPage_Files.SuspendLayout()
        Me.TabControl_Main.SuspendLayout()
        Me.TabPage_Paper.SuspendLayout()
        Me.TableLayoutPanel_Paper.SuspendLayout()
        Me.GroupBox_Separator_Column.SuspendLayout()
        Me.TableLayoutPanel_Separator_Column.SuspendLayout()
        Me.GroupBox_Paper_Border.SuspendLayout()
        Me.TableLayoutPanel_Paper_Border.SuspendLayout()
        Me.GroupBox_Shema.SuspendLayout()
        Me.TableLayoutPanel_Shema.SuspendLayout()
        Me.TabPage_Card.SuspendLayout()
        Me.TableLayoutPanel_Card.SuspendLayout()
        Me.GroupBox_Card_Size.SuspendLayout()
        Me.TableLayoutPanel_Card_Size.SuspendLayout()
        Me.GroupBox_Card_Border.SuspendLayout()
        Me.TableLayoutPanel_Card_Border.SuspendLayout()
        CType(Me.NumericUpDown_Card_Border_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Card_Border_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Card_Border_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Card_Border_Bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Card_Font.SuspendLayout()
        Me.TableLayoutPanel_Card_Font.SuspendLayout()
        Me.TabPage_Row.SuspendLayout()
        Me.TableLayoutPanel_CardRow.SuspendLayout()
        Me.GroupBox_CardRow_Border.SuspendLayout()
        Me.TableLayoutPanel_Row_Border.SuspendLayout()
        CType(Me.NumericUpDown_CardRow_Border_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_CardRow_Border_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_CardRow_Border_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_CardRow_Border_Bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_CardRow_Line.SuspendLayout()
        Me.TableLayoutPanel_Row_Line.SuspendLayout()
        CType(Me.NumericUpDown_CardRow_LinePos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_CardRow_List.SuspendLayout()
        Me.TableLayoutPanel_CardRow_List.SuspendLayout()
        Me.TabPage_Table.SuspendLayout()
        CType(Me.DGV_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Preview.SuspendLayout()
        CType(Me.PictureBox_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip_Main.SuspendLayout()
        Me.StatusStrip_Main.SuspendLayout()
        CType(Me.BindingSource_CSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Main.Panel1.SuspendLayout()
        Me.SplitContainer_Main.Panel2.SuspendLayout()
        Me.SplitContainer_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Separator_Row_Count
        '
        Me.Label_Separator_Row_Count.AutoSize = True
        Me.Label_Separator_Row_Count.Location = New System.Drawing.Point(3, 0)
        Me.Label_Separator_Row_Count.Name = "Label_Separator_Row_Count"
        Me.Label_Separator_Row_Count.Size = New System.Drawing.Size(39, 17)
        Me.Label_Separator_Row_Count.TabIndex = 0
        Me.Label_Separator_Row_Count.Text = "Anzahl"
        Me.Label_Separator_Row_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Separator_Row_Count.UseCompatibleTextRendering = True
        '
        'Label_Separator_Row_Value
        '
        Me.Label_Separator_Row_Value.AutoSize = True
        Me.Label_Separator_Row_Value.Location = New System.Drawing.Point(3, 26)
        Me.Label_Separator_Row_Value.Name = "Label_Separator_Row_Value"
        Me.Label_Separator_Row_Value.Size = New System.Drawing.Size(28, 17)
        Me.Label_Separator_Row_Value.TabIndex = 1
        Me.Label_Separator_Row_Value.Text = "Wert"
        Me.Label_Separator_Row_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Separator_Row_Value.UseCompatibleTextRendering = True
        '
        'TableLayoutPanel_Separator
        '
        Me.TableLayoutPanel_Separator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel_Separator.ColumnCount = 3
        Me.TableLayoutPanel_Separator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Separator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Separator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Separator.Controls.Add(Me.Label_Separator_Column_Value_Unit, 2, 1)
        Me.TableLayoutPanel_Separator.Controls.Add(Me.Label_Separator_Column_Count, 0, 0)
        Me.TableLayoutPanel_Separator.Controls.Add(Me.Label_Separator_Column_Value, 0, 1)
        Me.TableLayoutPanel_Separator.Controls.Add(Me.NumericUpDown_Separator_Column_Count, 1, 0)
        Me.TableLayoutPanel_Separator.Controls.Add(Me.NumericUpDown_Separator_Column_Value, 1, 1)
        Me.TableLayoutPanel_Separator.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel_Separator.Name = "TableLayoutPanel_Separator"
        Me.TableLayoutPanel_Separator.RowCount = 2
        Me.TableLayoutPanel_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Separator.Size = New System.Drawing.Size(176, 62)
        Me.TableLayoutPanel_Separator.TabIndex = 0
        Me.TableLayoutPanel_Separator.Tag = "Decimal"
        '
        'Label_Separator_Column_Value_Unit
        '
        Me.Label_Separator_Column_Value_Unit.AutoSize = True
        Me.Label_Separator_Column_Value_Unit.Location = New System.Drawing.Point(129, 26)
        Me.Label_Separator_Column_Value_Unit.Name = "Label_Separator_Column_Value_Unit"
        Me.Label_Separator_Column_Value_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Separator_Column_Value_Unit.TabIndex = 49
        Me.Label_Separator_Column_Value_Unit.Text = "mm"
        Me.Label_Separator_Column_Value_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Separator_Column_Value_Unit.UseCompatibleTextRendering = True
        '
        'Label_Separator_Column_Count
        '
        Me.Label_Separator_Column_Count.AutoSize = True
        Me.Label_Separator_Column_Count.Location = New System.Drawing.Point(3, 0)
        Me.Label_Separator_Column_Count.Name = "Label_Separator_Column_Count"
        Me.Label_Separator_Column_Count.Size = New System.Drawing.Size(39, 17)
        Me.Label_Separator_Column_Count.TabIndex = 29
        Me.Label_Separator_Column_Count.Text = "Anzahl"
        Me.Label_Separator_Column_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Separator_Column_Count.UseCompatibleTextRendering = True
        '
        'Label_Separator_Column_Value
        '
        Me.Label_Separator_Column_Value.AutoSize = True
        Me.Label_Separator_Column_Value.Location = New System.Drawing.Point(3, 26)
        Me.Label_Separator_Column_Value.Name = "Label_Separator_Column_Value"
        Me.Label_Separator_Column_Value.Size = New System.Drawing.Size(28, 17)
        Me.Label_Separator_Column_Value.TabIndex = 30
        Me.Label_Separator_Column_Value.Text = "Wert"
        Me.Label_Separator_Column_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Separator_Column_Value.UseCompatibleTextRendering = True
        '
        'NumericUpDown_Separator_Column_Count
        '
        Me.NumericUpDown_Separator_Column_Count.Location = New System.Drawing.Point(48, 3)
        Me.NumericUpDown_Separator_Column_Count.Name = "NumericUpDown_Separator_Column_Count"
        Me.NumericUpDown_Separator_Column_Count.Size = New System.Drawing.Size(74, 20)
        Me.NumericUpDown_Separator_Column_Count.TabIndex = 0
        Me.NumericUpDown_Separator_Column_Count.Tag = "SeparatorSpalteAnzahl"
        '
        'NumericUpDown_Separator_Column_Value
        '
        Me.NumericUpDown_Separator_Column_Value.Location = New System.Drawing.Point(48, 29)
        Me.NumericUpDown_Separator_Column_Value.Name = "NumericUpDown_Separator_Column_Value"
        Me.NumericUpDown_Separator_Column_Value.Size = New System.Drawing.Size(75, 20)
        Me.NumericUpDown_Separator_Column_Value.TabIndex = 1
        Me.NumericUpDown_Separator_Column_Value.Tag = "SeparatorSpalteWert"
        '
        'NumericUpDown_Separator_Row_Count
        '
        Me.NumericUpDown_Separator_Row_Count.Location = New System.Drawing.Point(48, 3)
        Me.NumericUpDown_Separator_Row_Count.Name = "NumericUpDown_Separator_Row_Count"
        Me.NumericUpDown_Separator_Row_Count.Size = New System.Drawing.Size(74, 20)
        Me.NumericUpDown_Separator_Row_Count.TabIndex = 2
        Me.NumericUpDown_Separator_Row_Count.Tag = "SeparatorZeileAnzahl"
        '
        'NumericUpDown_Separator_Row_Value
        '
        Me.NumericUpDown_Separator_Row_Value.Location = New System.Drawing.Point(48, 29)
        Me.NumericUpDown_Separator_Row_Value.Name = "NumericUpDown_Separator_Row_Value"
        Me.NumericUpDown_Separator_Row_Value.Size = New System.Drawing.Size(75, 20)
        Me.NumericUpDown_Separator_Row_Value.TabIndex = 3
        Me.NumericUpDown_Separator_Row_Value.Tag = "SeparatorZeileWert"
        '
        'GroupBox_Separator_Row
        '
        Me.GroupBox_Separator_Row.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox_Separator_Row.Controls.Add(Me.TableLayoutPanel_Separator)
        Me.GroupBox_Separator_Row.Location = New System.Drawing.Point(3, 400)
        Me.GroupBox_Separator_Row.Name = "GroupBox_Separator_Row"
        Me.GroupBox_Separator_Row.Size = New System.Drawing.Size(201, 93)
        Me.GroupBox_Separator_Row.TabIndex = 3
        Me.GroupBox_Separator_Row.TabStop = False
        Me.GroupBox_Separator_Row.Text = "Separatoren Spalte"
        Me.GroupBox_Separator_Row.UseCompatibleTextRendering = True
        '
        'Label_Paper_Border_Left
        '
        Me.Label_Paper_Border_Left.AutoSize = True
        Me.Label_Paper_Border_Left.Location = New System.Drawing.Point(3, 0)
        Me.Label_Paper_Border_Left.Name = "Label_Paper_Border_Left"
        Me.Label_Paper_Border_Left.Size = New System.Drawing.Size(31, 17)
        Me.Label_Paper_Border_Left.TabIndex = 1
        Me.Label_Paper_Border_Left.Text = "Links"
        Me.Label_Paper_Border_Left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Border_Left.UseCompatibleTextRendering = True
        '
        'Label_Paper_Border_Bottom
        '
        Me.Label_Paper_Border_Bottom.AutoSize = True
        Me.Label_Paper_Border_Bottom.Location = New System.Drawing.Point(3, 78)
        Me.Label_Paper_Border_Bottom.Name = "Label_Paper_Border_Bottom"
        Me.Label_Paper_Border_Bottom.Size = New System.Drawing.Size(34, 17)
        Me.Label_Paper_Border_Bottom.TabIndex = 7
        Me.Label_Paper_Border_Bottom.Text = "Unten"
        Me.Label_Paper_Border_Bottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Border_Bottom.UseCompatibleTextRendering = True
        '
        'Label_Paper_Border_Top
        '
        Me.Label_Paper_Border_Top.AutoSize = True
        Me.Label_Paper_Border_Top.Location = New System.Drawing.Point(3, 52)
        Me.Label_Paper_Border_Top.Name = "Label_Paper_Border_Top"
        Me.Label_Paper_Border_Top.Size = New System.Drawing.Size(32, 17)
        Me.Label_Paper_Border_Top.TabIndex = 5
        Me.Label_Paper_Border_Top.Text = "Oben"
        Me.Label_Paper_Border_Top.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Border_Top.UseCompatibleTextRendering = True
        '
        'Label_Paper_Border_Right
        '
        Me.Label_Paper_Border_Right.AutoSize = True
        Me.Label_Paper_Border_Right.Location = New System.Drawing.Point(3, 26)
        Me.Label_Paper_Border_Right.Name = "Label_Paper_Border_Right"
        Me.Label_Paper_Border_Right.Size = New System.Drawing.Size(39, 17)
        Me.Label_Paper_Border_Right.TabIndex = 3
        Me.Label_Paper_Border_Right.Text = "Rechts"
        Me.Label_Paper_Border_Right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Border_Right.UseCompatibleTextRendering = True
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
        'NumericUpDown_Paper_Border_Top
        '
        Me.NumericUpDown_Paper_Border_Top.Location = New System.Drawing.Point(48, 55)
        Me.NumericUpDown_Paper_Border_Top.Name = "NumericUpDown_Paper_Border_Top"
        Me.NumericUpDown_Paper_Border_Top.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_Paper_Border_Top.TabIndex = 3
        Me.NumericUpDown_Paper_Border_Top.Tag = "Paper;Top"
        '
        'NumericUpDown_Paper_Border_Bottom
        '
        Me.NumericUpDown_Paper_Border_Bottom.Location = New System.Drawing.Point(48, 81)
        Me.NumericUpDown_Paper_Border_Bottom.Name = "NumericUpDown_Paper_Border_Bottom"
        Me.NumericUpDown_Paper_Border_Bottom.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_Paper_Border_Bottom.TabIndex = 4
        Me.NumericUpDown_Paper_Border_Bottom.Tag = "Paper;Bottom"
        '
        'NumericUpDown_Paper_Border_Left
        '
        Me.NumericUpDown_Paper_Border_Left.Location = New System.Drawing.Point(48, 3)
        Me.NumericUpDown_Paper_Border_Left.Name = "NumericUpDown_Paper_Border_Left"
        Me.NumericUpDown_Paper_Border_Left.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_Paper_Border_Left.TabIndex = 1
        Me.NumericUpDown_Paper_Border_Left.Tag = "Paper;Left"
        '
        'NumericUpDown_Paper_Border_Right
        '
        Me.NumericUpDown_Paper_Border_Right.Location = New System.Drawing.Point(48, 29)
        Me.NumericUpDown_Paper_Border_Right.Name = "NumericUpDown_Paper_Border_Right"
        Me.NumericUpDown_Paper_Border_Right.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_Paper_Border_Right.TabIndex = 2
        Me.NumericUpDown_Paper_Border_Right.Tag = "Paper;Right"
        '
        'Label_Import
        '
        Me.Label_Import.AutoSize = True
        Me.Label_Import.Location = New System.Drawing.Point(3, 9)
        Me.Label_Import.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.Label_Import.Name = "Label_Import"
        Me.Label_Import.Size = New System.Drawing.Size(36, 17)
        Me.Label_Import.TabIndex = 3
        Me.Label_Import.Text = "Import"
        Me.Label_Import.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Import.UseCompatibleTextRendering = True
        '
        'TextBox_Import
        '
        Me.TextBox_Import.Location = New System.Drawing.Point(227, 9)
        Me.TextBox_Import.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.TextBox_Import.Name = "TextBox_Import"
        Me.TextBox_Import.Size = New System.Drawing.Size(234, 20)
        Me.TextBox_Import.TabIndex = 0
        Me.TextBox_Import.Tag = "Import"
        '
        'Label_Export
        '
        Me.Label_Export.AutoSize = True
        Me.Label_Export.Location = New System.Drawing.Point(3, 53)
        Me.Label_Export.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.Label_Export.Name = "Label_Export"
        Me.Label_Export.Size = New System.Drawing.Size(37, 17)
        Me.Label_Export.TabIndex = 5
        Me.Label_Export.Text = "Export"
        Me.Label_Export.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Export.UseCompatibleTextRendering = True
        '
        'TextBox_Export
        '
        Me.TextBox_Export.Location = New System.Drawing.Point(227, 53)
        Me.TextBox_Export.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.TextBox_Export.Name = "TextBox_Export"
        Me.TextBox_Export.Size = New System.Drawing.Size(234, 20)
        Me.TextBox_Export.TabIndex = 1
        Me.TextBox_Export.Tag = "Export"
        '
        'ImageList_Main
        '
        Me.ImageList_Main.ImageStream = CType(resources.GetObject("ImageList_Main.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Main.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ImageList_Main.Images.SetKeyName(0, "File_Printer.png")
        Me.ImageList_Main.Images.SetKeyName(1, "Import.png")
        Me.ImageList_Main.Images.SetKeyName(2, "ZoomIn.png")
        Me.ImageList_Main.Images.SetKeyName(3, "ZoomOut.png")
        Me.ImageList_Main.Images.SetKeyName(4, "Refresh_Arrow_Green")
        '
        'TableLayoutPanel_Files
        '
        Me.TableLayoutPanel_Files.AutoSize = True
        Me.TableLayoutPanel_Files.ColumnCount = 3
        Me.TableLayoutPanel_Files.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Files.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Files.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Files.Controls.Add(Me.Button_Search_Delete, 2, 2)
        Me.TableLayoutPanel_Files.Controls.Add(Me.Label_Import, 0, 0)
        Me.TableLayoutPanel_Files.Controls.Add(Me.TextBox_Import, 1, 0)
        Me.TableLayoutPanel_Files.Controls.Add(Me.Label_Export, 0, 1)
        Me.TableLayoutPanel_Files.Controls.Add(Me.TextBox_Export, 1, 1)
        Me.TableLayoutPanel_Files.Controls.Add(Me.DGV_Search, 0, 2)
        Me.TableLayoutPanel_Files.Controls.Add(Me.Button_Search_Add, 2, 4)
        Me.TableLayoutPanel_Files.Controls.Add(Me.DGV_CSV, 0, 4)
        Me.TableLayoutPanel_Files.Controls.Add(Me.BindingNavigator_CSV, 0, 3)
        Me.TableLayoutPanel_Files.Controls.Add(Me.Button_Import, 2, 0)
        Me.TableLayoutPanel_Files.Controls.Add(Me.Button_Export, 2, 1)
        Me.TableLayoutPanel_Files.Controls.Add(Me.Button_Search_Refresh, 2, 3)
        Me.TableLayoutPanel_Files.Location = New System.Drawing.Point(21, 21)
        Me.TableLayoutPanel_Files.Name = "TableLayoutPanel_Files"
        Me.TableLayoutPanel_Files.RowCount = 5
        Me.TableLayoutPanel_Files.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Files.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Files.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Files.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Files.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Files.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Files.Size = New System.Drawing.Size(508, 306)
        Me.TableLayoutPanel_Files.TabIndex = 0
        '
        'Button_Search_Delete
        '
        Me.Button_Search_Delete.AutoSize = True
        Me.Button_Search_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Search_Delete.ImageKey = "ZoomOut.png"
        Me.Button_Search_Delete.ImageList = Me.ImageList_Main
        Me.Button_Search_Delete.Location = New System.Drawing.Point(467, 91)
        Me.Button_Search_Delete.Name = "Button_Search_Delete"
        Me.Button_Search_Delete.Size = New System.Drawing.Size(38, 38)
        Me.Button_Search_Delete.TabIndex = 46
        Me.Button_Search_Delete.UseVisualStyleBackColor = True
        '
        'DGV_Search
        '
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Search.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.DGV_Search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Search.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Search.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DGV_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Search.EnableHeadersVisualStyles = False
        Me.DGV_Search.GridColor = System.Drawing.Color.DarkGray
        Me.DGV_Search.Location = New System.Drawing.Point(3, 91)
        Me.DGV_Search.Name = "DGV_Search"
        Me.DGV_Search.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGV_Search.Size = New System.Drawing.Size(208, 29)
        Me.DGV_Search.TabIndex = 0
        '
        'Button_Search_Add
        '
        Me.Button_Search_Add.AutoSize = True
        Me.Button_Search_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Search_Add.ImageKey = "ZoomIn.png"
        Me.Button_Search_Add.ImageList = Me.ImageList_Main
        Me.Button_Search_Add.Location = New System.Drawing.Point(467, 179)
        Me.Button_Search_Add.Name = "Button_Search_Add"
        Me.Button_Search_Add.Size = New System.Drawing.Size(38, 38)
        Me.Button_Search_Add.TabIndex = 47
        Me.Button_Search_Add.UseVisualStyleBackColor = True
        '
        'DGV_CSV
        '
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_CSV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle18
        Me.DGV_CSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGV_CSV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DGV_CSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CSV.GridColor = System.Drawing.Color.DarkGray
        Me.DGV_CSV.Location = New System.Drawing.Point(3, 179)
        Me.DGV_CSV.MultiSelect = False
        Me.DGV_CSV.Name = "DGV_CSV"
        Me.DGV_CSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGV_CSV.Size = New System.Drawing.Size(153, 39)
        Me.DGV_CSV.TabIndex = 44
        '
        'BindingNavigator_CSV
        '
        Me.BindingNavigator_CSV.AddNewItem = Nothing
        Me.BindingNavigator_CSV.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator_CSV.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator_CSV.DeleteItem = Nothing
        Me.BindingNavigator_CSV.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator_CSV.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigator_CSV.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator_CSV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator_CSV.Location = New System.Drawing.Point(0, 132)
        Me.BindingNavigator_CSV.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator_CSV.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator_CSV.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator_CSV.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator_CSV.Name = "BindingNavigator_CSV"
        Me.BindingNavigator_CSV.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator_CSV.Size = New System.Drawing.Size(224, 25)
        Me.BindingNavigator_CSV.TabIndex = 45
        Me.BindingNavigator_CSV.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(59, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Erste verschieben"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Button_Import
        '
        Me.Button_Import.AutoSize = True
        Me.Button_Import.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Import.ImageKey = "Import.png"
        Me.Button_Import.ImageList = Me.ImageList_Main
        Me.Button_Import.Location = New System.Drawing.Point(467, 3)
        Me.Button_Import.Name = "Button_Import"
        Me.Button_Import.Size = New System.Drawing.Size(38, 38)
        Me.Button_Import.TabIndex = 6
        Me.Button_Import.Text = "..."
        Me.Button_Import.UseVisualStyleBackColor = True
        '
        'Button_Export
        '
        Me.Button_Export.AutoSize = True
        Me.Button_Export.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Export.ImageKey = "File_Printer.png"
        Me.Button_Export.ImageList = Me.ImageList_Main
        Me.Button_Export.Location = New System.Drawing.Point(467, 47)
        Me.Button_Export.Name = "Button_Export"
        Me.Button_Export.Size = New System.Drawing.Size(38, 38)
        Me.Button_Export.TabIndex = 7
        Me.Button_Export.Text = "..."
        Me.Button_Export.UseVisualStyleBackColor = True
        '
        'Button_Search_Refresh
        '
        Me.Button_Search_Refresh.AutoSize = True
        Me.Button_Search_Refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Search_Refresh.ImageKey = "Refresh_Arrow_Green"
        Me.Button_Search_Refresh.ImageList = Me.ImageList_Main
        Me.Button_Search_Refresh.Location = New System.Drawing.Point(467, 135)
        Me.Button_Search_Refresh.Name = "Button_Search_Refresh"
        Me.Button_Search_Refresh.Size = New System.Drawing.Size(38, 38)
        Me.Button_Search_Refresh.TabIndex = 48
        Me.Button_Search_Refresh.UseVisualStyleBackColor = True
        '
        'TabPage_Files
        '
        Me.TabPage_Files.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_Files.Controls.Add(Me.TableLayoutPanel_Files)
        Me.TabPage_Files.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_Files.Name = "TabPage_Files"
        Me.TabPage_Files.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Files.Size = New System.Drawing.Size(232, 247)
        Me.TabPage_Files.TabIndex = 5
        Me.TabPage_Files.Text = "Daten"
        '
        'TabControl_Main
        '
        Me.TabControl_Main.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl_Main.Controls.Add(Me.TabPage_Paper)
        Me.TabControl_Main.Controls.Add(Me.TabPage_Card)
        Me.TabControl_Main.Controls.Add(Me.TabPage_Row)
        Me.TabControl_Main.Controls.Add(Me.TabPage_Files)
        Me.TabControl_Main.Controls.Add(Me.TabPage_Table)
        Me.TabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_Main.Location = New System.Drawing.Point(0, 0)
        Me.TabControl_Main.Multiline = True
        Me.TabControl_Main.Name = "TabControl_Main"
        Me.TabControl_Main.SelectedIndex = 0
        Me.TabControl_Main.Size = New System.Drawing.Size(240, 276)
        Me.TabControl_Main.TabIndex = 6
        '
        'TabPage_Paper
        '
        Me.TabPage_Paper.Controls.Add(Me.TableLayoutPanel_Paper)
        Me.TabPage_Paper.Location = New System.Drawing.Point(4, 49)
        Me.TabPage_Paper.Name = "TabPage_Paper"
        Me.TabPage_Paper.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Paper.Size = New System.Drawing.Size(232, 223)
        Me.TabPage_Paper.TabIndex = 0
        Me.TabPage_Paper.Text = "Papier"
        Me.TabPage_Paper.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_Paper
        '
        Me.TableLayoutPanel_Paper.ColumnCount = 1
        Me.TableLayoutPanel_Paper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Paper.Controls.Add(Me.GroupBox_Separator_Column, 0, 2)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.GroupBox_Paper_Border, 0, 1)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.GroupBox_Separator_Row, 0, 3)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.GroupBox_Shema, 0, 0)
        Me.TableLayoutPanel_Paper.Location = New System.Drawing.Point(8, 6)
        Me.TableLayoutPanel_Paper.Name = "TableLayoutPanel_Paper"
        Me.TableLayoutPanel_Paper.RowCount = 4
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Paper.Size = New System.Drawing.Size(191, 520)
        Me.TableLayoutPanel_Paper.TabIndex = 45
        '
        'GroupBox_Separator_Column
        '
        Me.GroupBox_Separator_Column.Controls.Add(Me.TableLayoutPanel_Separator_Column)
        Me.GroupBox_Separator_Column.Location = New System.Drawing.Point(3, 298)
        Me.GroupBox_Separator_Column.Name = "GroupBox_Separator_Column"
        Me.GroupBox_Separator_Column.Size = New System.Drawing.Size(179, 96)
        Me.GroupBox_Separator_Column.TabIndex = 29
        Me.GroupBox_Separator_Column.TabStop = False
        Me.GroupBox_Separator_Column.Text = "Separator Zeile"
        '
        'TableLayoutPanel_Separator_Column
        '
        Me.TableLayoutPanel_Separator_Column.ColumnCount = 3
        Me.TableLayoutPanel_Separator_Column.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Separator_Column.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Separator_Column.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Separator_Column.Controls.Add(Me.Label_Separator_Row_Count, 0, 0)
        Me.TableLayoutPanel_Separator_Column.Controls.Add(Me.Label_Separator_Row_Value, 0, 1)
        Me.TableLayoutPanel_Separator_Column.Controls.Add(Me.NumericUpDown_Separator_Row_Count, 1, 0)
        Me.TableLayoutPanel_Separator_Column.Controls.Add(Me.NumericUpDown_Separator_Row_Value, 1, 1)
        Me.TableLayoutPanel_Separator_Column.Controls.Add(Me.Label_Separator_Row_Value_Unit, 2, 1)
        Me.TableLayoutPanel_Separator_Column.Location = New System.Drawing.Point(9, 19)
        Me.TableLayoutPanel_Separator_Column.Name = "TableLayoutPanel_Separator_Column"
        Me.TableLayoutPanel_Separator_Column.RowCount = 2
        Me.TableLayoutPanel_Separator_Column.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Separator_Column.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Separator_Column.Size = New System.Drawing.Size(164, 62)
        Me.TableLayoutPanel_Separator_Column.TabIndex = 0
        '
        'Label_Separator_Row_Value_Unit
        '
        Me.Label_Separator_Row_Value_Unit.AutoSize = True
        Me.Label_Separator_Row_Value_Unit.Location = New System.Drawing.Point(129, 26)
        Me.Label_Separator_Row_Value_Unit.Name = "Label_Separator_Row_Value_Unit"
        Me.Label_Separator_Row_Value_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Separator_Row_Value_Unit.TabIndex = 48
        Me.Label_Separator_Row_Value_Unit.Text = "mm"
        Me.Label_Separator_Row_Value_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Separator_Row_Value_Unit.UseCompatibleTextRendering = True
        '
        'GroupBox_Paper_Border
        '
        Me.GroupBox_Paper_Border.Controls.Add(Me.TableLayoutPanel_Paper_Border)
        Me.GroupBox_Paper_Border.Location = New System.Drawing.Point(3, 161)
        Me.GroupBox_Paper_Border.Name = "GroupBox_Paper_Border"
        Me.GroupBox_Paper_Border.Size = New System.Drawing.Size(178, 131)
        Me.GroupBox_Paper_Border.TabIndex = 47
        Me.GroupBox_Paper_Border.TabStop = False
        Me.GroupBox_Paper_Border.Text = "Rahmen"
        '
        'TableLayoutPanel_Paper_Border
        '
        Me.TableLayoutPanel_Paper_Border.AutoSize = True
        Me.TableLayoutPanel_Paper_Border.ColumnCount = 3
        Me.TableLayoutPanel_Paper_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Paper_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Paper_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label_Paper_Border_Right_Unit, 2, 1)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label_Paper_Border_Top_Unit, 2, 2)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label_Paper_Border_Bottom_Unit, 2, 3)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label_Paper_Border_Left, 0, 0)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label_Paper_Border_Right, 0, 1)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label_Paper_Border_Top, 0, 2)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.NumericUpDown_Paper_Border_Left, 1, 0)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.NumericUpDown_Paper_Border_Right, 1, 1)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.NumericUpDown_Paper_Border_Top, 1, 2)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.NumericUpDown_Paper_Border_Bottom, 1, 3)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label_Paper_Border_Bottom, 0, 3)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label_Paper_Border_Left_Unit, 2, 0)
        Me.TableLayoutPanel_Paper_Border.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel_Paper_Border.Name = "TableLayoutPanel_Paper_Border"
        Me.TableLayoutPanel_Paper_Border.RowCount = 4
        Me.TableLayoutPanel_Paper_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper_Border.Size = New System.Drawing.Size(157, 104)
        Me.TableLayoutPanel_Paper_Border.TabIndex = 46
        '
        'Label_Paper_Border_Right_Unit
        '
        Me.Label_Paper_Border_Right_Unit.Location = New System.Drawing.Point(127, 26)
        Me.Label_Paper_Border_Right_Unit.Name = "Label_Paper_Border_Right_Unit"
        Me.Label_Paper_Border_Right_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Paper_Border_Right_Unit.TabIndex = 46
        Me.Label_Paper_Border_Right_Unit.Text = "mm"
        Me.Label_Paper_Border_Right_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Border_Right_Unit.UseCompatibleTextRendering = True
        '
        'Label_Paper_Border_Top_Unit
        '
        Me.Label_Paper_Border_Top_Unit.AutoSize = True
        Me.Label_Paper_Border_Top_Unit.Location = New System.Drawing.Point(127, 52)
        Me.Label_Paper_Border_Top_Unit.Name = "Label_Paper_Border_Top_Unit"
        Me.Label_Paper_Border_Top_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Paper_Border_Top_Unit.TabIndex = 46
        Me.Label_Paper_Border_Top_Unit.Text = "mm"
        Me.Label_Paper_Border_Top_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Border_Top_Unit.UseCompatibleTextRendering = True
        '
        'Label_Paper_Border_Bottom_Unit
        '
        Me.Label_Paper_Border_Bottom_Unit.AutoSize = True
        Me.Label_Paper_Border_Bottom_Unit.Location = New System.Drawing.Point(127, 78)
        Me.Label_Paper_Border_Bottom_Unit.Name = "Label_Paper_Border_Bottom_Unit"
        Me.Label_Paper_Border_Bottom_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Paper_Border_Bottom_Unit.TabIndex = 46
        Me.Label_Paper_Border_Bottom_Unit.Text = "mm"
        Me.Label_Paper_Border_Bottom_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Border_Bottom_Unit.UseCompatibleTextRendering = True
        '
        'Label_Paper_Border_Left_Unit
        '
        Me.Label_Paper_Border_Left_Unit.AutoSize = True
        Me.Label_Paper_Border_Left_Unit.Location = New System.Drawing.Point(127, 0)
        Me.Label_Paper_Border_Left_Unit.Name = "Label_Paper_Border_Left_Unit"
        Me.Label_Paper_Border_Left_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Paper_Border_Left_Unit.TabIndex = 46
        Me.Label_Paper_Border_Left_Unit.Text = "mm"
        Me.Label_Paper_Border_Left_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Border_Left_Unit.UseCompatibleTextRendering = True
        '
        'GroupBox_Shema
        '
        Me.GroupBox_Shema.AutoSize = True
        Me.GroupBox_Shema.Controls.Add(Me.TableLayoutPanel_Shema)
        Me.GroupBox_Shema.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox_Shema.Name = "GroupBox_Shema"
        Me.GroupBox_Shema.Size = New System.Drawing.Size(163, 152)
        Me.GroupBox_Shema.TabIndex = 0
        Me.GroupBox_Shema.TabStop = False
        Me.GroupBox_Shema.Text = "Shema"
        '
        'TableLayoutPanel_Shema
        '
        Me.TableLayoutPanel_Shema.AutoSize = True
        Me.TableLayoutPanel_Shema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel_Shema.ColumnCount = 3
        Me.TableLayoutPanel_Shema.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Shema.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Shema.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_Width_Unit, 2, 4)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_Height_Unit, 2, 3)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_Width_Value, 1, 4)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Shema, 0, 0)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_Height_Value, 1, 3)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.ComboBox_Paper_DPI, 1, 1)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_Width, 0, 4)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.TextBox_Shema, 1, 0)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_Height, 0, 3)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_DPI, 0, 1)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_DIN, 0, 2)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.ComboBox_Paper_DIN, 1, 2)
        Me.TableLayoutPanel_Shema.Location = New System.Drawing.Point(9, 19)
        Me.TableLayoutPanel_Shema.Name = "TableLayoutPanel_Shema"
        Me.TableLayoutPanel_Shema.RowCount = 5
        Me.TableLayoutPanel_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Shema.Size = New System.Drawing.Size(148, 114)
        Me.TableLayoutPanel_Shema.TabIndex = 0
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
        'Label_Shema
        '
        Me.Label_Shema.AutoSize = True
        Me.Label_Shema.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Shema.Location = New System.Drawing.Point(3, 0)
        Me.Label_Shema.Name = "Label_Shema"
        Me.Label_Shema.Size = New System.Drawing.Size(34, 17)
        Me.Label_Shema.TabIndex = 0
        Me.Label_Shema.Text = "Name"
        Me.Label_Shema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Shema.UseCompatibleTextRendering = True
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
        'TextBox_Shema
        '
        Me.TextBox_Shema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel_Shema.SetColumnSpan(Me.TextBox_Shema, 2)
        Me.TextBox_Shema.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox_Shema.Location = New System.Drawing.Point(43, 3)
        Me.TextBox_Shema.Name = "TextBox_Shema"
        Me.TextBox_Shema.Size = New System.Drawing.Size(102, 20)
        Me.TextBox_Shema.TabIndex = 0
        Me.TextBox_Shema.Tag = "Shema"
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
        Me.TabPage_Card.Controls.Add(Me.TableLayoutPanel_Card)
        Me.TabPage_Card.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_Card.Name = "TabPage_Card"
        Me.TabPage_Card.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Card.Size = New System.Drawing.Size(232, 247)
        Me.TabPage_Card.TabIndex = 6
        Me.TabPage_Card.Text = "Karte"
        Me.TabPage_Card.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_Card
        '
        Me.TableLayoutPanel_Card.ColumnCount = 1
        Me.TableLayoutPanel_Card.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card.Controls.Add(Me.GroupBox_Card_Size, 0, 2)
        Me.TableLayoutPanel_Card.Controls.Add(Me.GroupBox_Card_Border, 0, 1)
        Me.TableLayoutPanel_Card.Controls.Add(Me.GroupBox_Card_Font, 0, 0)
        Me.TableLayoutPanel_Card.Location = New System.Drawing.Point(23, 37)
        Me.TableLayoutPanel_Card.Name = "TableLayoutPanel_Card"
        Me.TableLayoutPanel_Card.RowCount = 3
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Card.Size = New System.Drawing.Size(202, 369)
        Me.TableLayoutPanel_Card.TabIndex = 3
        '
        'GroupBox_Card_Size
        '
        Me.GroupBox_Card_Size.Controls.Add(Me.TableLayoutPanel_Card_Size)
        Me.GroupBox_Card_Size.Location = New System.Drawing.Point(3, 222)
        Me.GroupBox_Card_Size.Name = "GroupBox_Card_Size"
        Me.GroupBox_Card_Size.Size = New System.Drawing.Size(189, 79)
        Me.GroupBox_Card_Size.TabIndex = 4
        Me.GroupBox_Card_Size.TabStop = False
        Me.GroupBox_Card_Size.Text = "Größe"
        '
        'TableLayoutPanel_Card_Size
        '
        Me.TableLayoutPanel_Card_Size.ColumnCount = 2
        Me.TableLayoutPanel_Card_Size.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card_Size.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card_Size.Controls.Add(Me.Label_Card_Size_Hight, 0, 0)
        Me.TableLayoutPanel_Card_Size.Controls.Add(Me.Label_Card_Size_Hight_Value, 1, 0)
        Me.TableLayoutPanel_Card_Size.Controls.Add(Me.Label_Card_Size_Width, 0, 1)
        Me.TableLayoutPanel_Card_Size.Controls.Add(Me.Label_Card_Size_Width_Value, 1, 1)
        Me.TableLayoutPanel_Card_Size.Location = New System.Drawing.Point(0, 19)
        Me.TableLayoutPanel_Card_Size.Name = "TableLayoutPanel_Card_Size"
        Me.TableLayoutPanel_Card_Size.RowCount = 2
        Me.TableLayoutPanel_Card_Size.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card_Size.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card_Size.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Card_Size.Size = New System.Drawing.Size(156, 43)
        Me.TableLayoutPanel_Card_Size.TabIndex = 0
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
        'GroupBox_Card_Border
        '
        Me.GroupBox_Card_Border.Controls.Add(Me.TableLayoutPanel_Card_Border)
        Me.GroupBox_Card_Border.Location = New System.Drawing.Point(3, 88)
        Me.GroupBox_Card_Border.Name = "GroupBox_Card_Border"
        Me.GroupBox_Card_Border.Size = New System.Drawing.Size(163, 128)
        Me.GroupBox_Card_Border.TabIndex = 1
        Me.GroupBox_Card_Border.TabStop = False
        Me.GroupBox_Card_Border.Text = "Rahmen"
        '
        'TableLayoutPanel_Card_Border
        '
        Me.TableLayoutPanel_Card_Border.AutoSize = True
        Me.TableLayoutPanel_Card_Border.ColumnCount = 3
        Me.TableLayoutPanel_Card_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card_Border.Controls.Add(Me.Label_Card_Border_Bottom_Unit, 2, 3)
        Me.TableLayoutPanel_Card_Border.Controls.Add(Me.Label_Card_Border_Bottom, 0, 3)
        Me.TableLayoutPanel_Card_Border.Controls.Add(Me.Label_Card_Border_Top_Unit, 2, 2)
        Me.TableLayoutPanel_Card_Border.Controls.Add(Me.NumericUpDown_Card_Border_Left, 1, 0)
        Me.TableLayoutPanel_Card_Border.Controls.Add(Me.Label_Card_Border_Right_Unit, 2, 1)
        Me.TableLayoutPanel_Card_Border.Controls.Add(Me.Label_Card_Border_Top, 0, 2)
        Me.TableLayoutPanel_Card_Border.Controls.Add(Me.Label_Card_Border_Left_Unit, 2, 0)
        Me.TableLayoutPanel_Card_Border.Controls.Add(Me.NumericUpDown_Card_Border_Right, 1, 1)
        Me.TableLayoutPanel_Card_Border.Controls.Add(Me.Label_Card_Border_Right, 0, 1)
        Me.TableLayoutPanel_Card_Border.Controls.Add(Me.NumericUpDown_Card_Border_Top, 1, 2)
        Me.TableLayoutPanel_Card_Border.Controls.Add(Me.Label_Card_Border_Left, 0, 0)
        Me.TableLayoutPanel_Card_Border.Controls.Add(Me.NumericUpDown_Card_Border_Bottom, 1, 3)
        Me.TableLayoutPanel_Card_Border.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel_Card_Border.Name = "TableLayoutPanel_Card_Border"
        Me.TableLayoutPanel_Card_Border.RowCount = 4
        Me.TableLayoutPanel_Card_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card_Border.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Card_Border.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Card_Border.Size = New System.Drawing.Size(153, 104)
        Me.TableLayoutPanel_Card_Border.TabIndex = 0
        '
        'Label_Card_Border_Bottom_Unit
        '
        Me.Label_Card_Border_Bottom_Unit.AutoSize = True
        Me.Label_Card_Border_Bottom_Unit.Location = New System.Drawing.Point(127, 78)
        Me.Label_Card_Border_Bottom_Unit.Name = "Label_Card_Border_Bottom_Unit"
        Me.Label_Card_Border_Bottom_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Card_Border_Bottom_Unit.TabIndex = 50
        Me.Label_Card_Border_Bottom_Unit.Text = "mm"
        Me.Label_Card_Border_Bottom_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Border_Bottom_Unit.UseCompatibleTextRendering = True
        '
        'Label_Card_Border_Bottom
        '
        Me.Label_Card_Border_Bottom.AutoSize = True
        Me.Label_Card_Border_Bottom.Location = New System.Drawing.Point(3, 78)
        Me.Label_Card_Border_Bottom.Name = "Label_Card_Border_Bottom"
        Me.Label_Card_Border_Bottom.Size = New System.Drawing.Size(34, 17)
        Me.Label_Card_Border_Bottom.TabIndex = 16
        Me.Label_Card_Border_Bottom.Text = "Unten"
        Me.Label_Card_Border_Bottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Border_Bottom.UseCompatibleTextRendering = True
        '
        'Label_Card_Border_Top_Unit
        '
        Me.Label_Card_Border_Top_Unit.AutoSize = True
        Me.Label_Card_Border_Top_Unit.Location = New System.Drawing.Point(127, 52)
        Me.Label_Card_Border_Top_Unit.Name = "Label_Card_Border_Top_Unit"
        Me.Label_Card_Border_Top_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Card_Border_Top_Unit.TabIndex = 49
        Me.Label_Card_Border_Top_Unit.Text = "mm"
        Me.Label_Card_Border_Top_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Border_Top_Unit.UseCompatibleTextRendering = True
        '
        'NumericUpDown_Card_Border_Left
        '
        Me.NumericUpDown_Card_Border_Left.Location = New System.Drawing.Point(48, 3)
        Me.NumericUpDown_Card_Border_Left.Name = "NumericUpDown_Card_Border_Left"
        Me.NumericUpDown_Card_Border_Left.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_Card_Border_Left.TabIndex = 7
        Me.NumericUpDown_Card_Border_Left.Tag = "Card;Left"
        '
        'Label_Card_Border_Right_Unit
        '
        Me.Label_Card_Border_Right_Unit.AutoSize = True
        Me.Label_Card_Border_Right_Unit.Location = New System.Drawing.Point(127, 26)
        Me.Label_Card_Border_Right_Unit.Name = "Label_Card_Border_Right_Unit"
        Me.Label_Card_Border_Right_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Card_Border_Right_Unit.TabIndex = 48
        Me.Label_Card_Border_Right_Unit.Text = "mm"
        Me.Label_Card_Border_Right_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Border_Right_Unit.UseCompatibleTextRendering = True
        '
        'Label_Card_Border_Top
        '
        Me.Label_Card_Border_Top.AutoSize = True
        Me.Label_Card_Border_Top.Location = New System.Drawing.Point(3, 52)
        Me.Label_Card_Border_Top.Name = "Label_Card_Border_Top"
        Me.Label_Card_Border_Top.Size = New System.Drawing.Size(32, 17)
        Me.Label_Card_Border_Top.TabIndex = 15
        Me.Label_Card_Border_Top.Text = "Oben"
        Me.Label_Card_Border_Top.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Border_Top.UseCompatibleTextRendering = True
        '
        'Label_Card_Border_Left_Unit
        '
        Me.Label_Card_Border_Left_Unit.AutoSize = True
        Me.Label_Card_Border_Left_Unit.Location = New System.Drawing.Point(127, 0)
        Me.Label_Card_Border_Left_Unit.Name = "Label_Card_Border_Left_Unit"
        Me.Label_Card_Border_Left_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Card_Border_Left_Unit.TabIndex = 47
        Me.Label_Card_Border_Left_Unit.Text = "mm"
        Me.Label_Card_Border_Left_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Border_Left_Unit.UseCompatibleTextRendering = True
        '
        'NumericUpDown_Card_Border_Right
        '
        Me.NumericUpDown_Card_Border_Right.Location = New System.Drawing.Point(48, 29)
        Me.NumericUpDown_Card_Border_Right.Name = "NumericUpDown_Card_Border_Right"
        Me.NumericUpDown_Card_Border_Right.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_Card_Border_Right.TabIndex = 9
        Me.NumericUpDown_Card_Border_Right.Tag = "Card;Right"
        '
        'Label_Card_Border_Right
        '
        Me.Label_Card_Border_Right.AutoSize = True
        Me.Label_Card_Border_Right.Location = New System.Drawing.Point(3, 26)
        Me.Label_Card_Border_Right.Name = "Label_Card_Border_Right"
        Me.Label_Card_Border_Right.Size = New System.Drawing.Size(39, 17)
        Me.Label_Card_Border_Right.TabIndex = 14
        Me.Label_Card_Border_Right.Text = "Rechts"
        Me.Label_Card_Border_Right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Border_Right.UseCompatibleTextRendering = True
        '
        'NumericUpDown_Card_Border_Top
        '
        Me.NumericUpDown_Card_Border_Top.Location = New System.Drawing.Point(48, 55)
        Me.NumericUpDown_Card_Border_Top.Name = "NumericUpDown_Card_Border_Top"
        Me.NumericUpDown_Card_Border_Top.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_Card_Border_Top.TabIndex = 10
        Me.NumericUpDown_Card_Border_Top.Tag = "Card;Top"
        '
        'Label_Card_Border_Left
        '
        Me.Label_Card_Border_Left.AutoSize = True
        Me.Label_Card_Border_Left.Location = New System.Drawing.Point(3, 0)
        Me.Label_Card_Border_Left.Name = "Label_Card_Border_Left"
        Me.Label_Card_Border_Left.Size = New System.Drawing.Size(31, 17)
        Me.Label_Card_Border_Left.TabIndex = 13
        Me.Label_Card_Border_Left.Text = "Links"
        Me.Label_Card_Border_Left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Border_Left.UseCompatibleTextRendering = True
        '
        'NumericUpDown_Card_Border_Bottom
        '
        Me.NumericUpDown_Card_Border_Bottom.Location = New System.Drawing.Point(48, 81)
        Me.NumericUpDown_Card_Border_Bottom.Name = "NumericUpDown_Card_Border_Bottom"
        Me.NumericUpDown_Card_Border_Bottom.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_Card_Border_Bottom.TabIndex = 11
        Me.NumericUpDown_Card_Border_Bottom.Tag = "Card;Bottom"
        '
        'GroupBox_Card_Font
        '
        Me.GroupBox_Card_Font.Controls.Add(Me.TableLayoutPanel_Card_Font)
        Me.GroupBox_Card_Font.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox_Card_Font.Name = "GroupBox_Card_Font"
        Me.GroupBox_Card_Font.Size = New System.Drawing.Size(189, 79)
        Me.GroupBox_Card_Font.TabIndex = 2
        Me.GroupBox_Card_Font.TabStop = False
        Me.GroupBox_Card_Font.Text = "Schriftart"
        '
        'TableLayoutPanel_Card_Font
        '
        Me.TableLayoutPanel_Card_Font.ColumnCount = 2
        Me.TableLayoutPanel_Card_Font.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card_Font.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card_Font.Controls.Add(Me.Label_Card_Font, 0, 0)
        Me.TableLayoutPanel_Card_Font.Controls.Add(Me.Label_Card_Font_Value, 1, 0)
        Me.TableLayoutPanel_Card_Font.Controls.Add(Me.Label_Card_FontColor, 0, 1)
        Me.TableLayoutPanel_Card_Font.Controls.Add(Me.Label_Card_FontColor_Value, 1, 1)
        Me.TableLayoutPanel_Card_Font.Location = New System.Drawing.Point(0, 19)
        Me.TableLayoutPanel_Card_Font.Name = "TableLayoutPanel_Card_Font"
        Me.TableLayoutPanel_Card_Font.RowCount = 2
        Me.TableLayoutPanel_Card_Font.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card_Font.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card_Font.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Card_Font.Size = New System.Drawing.Size(156, 43)
        Me.TableLayoutPanel_Card_Font.TabIndex = 0
        '
        'Label_Card_Font
        '
        Me.Label_Card_Font.AutoSize = True
        Me.Label_Card_Font.Location = New System.Drawing.Point(3, 0)
        Me.Label_Card_Font.Name = "Label_Card_Font"
        Me.Label_Card_Font.Size = New System.Drawing.Size(27, 17)
        Me.Label_Card_Font.TabIndex = 28
        Me.Label_Card_Font.Text = "Font"
        Me.Label_Card_Font.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Font.UseCompatibleTextRendering = True
        '
        'Label_Card_Font_Value
        '
        Me.Label_Card_Font_Value.AutoSize = True
        Me.Label_Card_Font_Value.Location = New System.Drawing.Point(63, 0)
        Me.Label_Card_Font_Value.Name = "Label_Card_Font_Value"
        Me.Label_Card_Font_Value.Size = New System.Drawing.Size(72, 17)
        Me.Label_Card_Font_Value.TabIndex = 29
        Me.Label_Card_Font_Value.Text = "nicht definiert"
        Me.Label_Card_Font_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Font_Value.UseCompatibleTextRendering = True
        '
        'Label_Card_FontColor
        '
        Me.Label_Card_FontColor.AutoSize = True
        Me.Label_Card_FontColor.Location = New System.Drawing.Point(3, 17)
        Me.Label_Card_FontColor.Name = "Label_Card_FontColor"
        Me.Label_Card_FontColor.Size = New System.Drawing.Size(54, 17)
        Me.Label_Card_FontColor.TabIndex = 29
        Me.Label_Card_FontColor.Text = "FontColor"
        Me.Label_Card_FontColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_FontColor.UseCompatibleTextRendering = True
        '
        'Label_Card_FontColor_Value
        '
        Me.Label_Card_FontColor_Value.AutoSize = True
        Me.Label_Card_FontColor_Value.Location = New System.Drawing.Point(63, 17)
        Me.Label_Card_FontColor_Value.Name = "Label_Card_FontColor_Value"
        Me.Label_Card_FontColor_Value.Size = New System.Drawing.Size(72, 17)
        Me.Label_Card_FontColor_Value.TabIndex = 30
        Me.Label_Card_FontColor_Value.Text = "nicht definiert"
        Me.Label_Card_FontColor_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_FontColor_Value.UseCompatibleTextRendering = True
        '
        'TabPage_Row
        '
        Me.TabPage_Row.Controls.Add(Me.TableLayoutPanel_CardRow)
        Me.TabPage_Row.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_Row.Name = "TabPage_Row"
        Me.TabPage_Row.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Row.Size = New System.Drawing.Size(232, 247)
        Me.TabPage_Row.TabIndex = 7
        Me.TabPage_Row.Text = "Zeile"
        Me.TabPage_Row.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_CardRow
        '
        Me.TableLayoutPanel_CardRow.ColumnCount = 1
        Me.TableLayoutPanel_CardRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_CardRow.Controls.Add(Me.GroupBox_CardRow_Border, 0, 2)
        Me.TableLayoutPanel_CardRow.Controls.Add(Me.GroupBox_CardRow_Line, 0, 1)
        Me.TableLayoutPanel_CardRow.Controls.Add(Me.GroupBox_CardRow_List, 0, 0)
        Me.TableLayoutPanel_CardRow.Location = New System.Drawing.Point(41, 15)
        Me.TableLayoutPanel_CardRow.Name = "TableLayoutPanel_CardRow"
        Me.TableLayoutPanel_CardRow.RowCount = 3
        Me.TableLayoutPanel_CardRow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow.Size = New System.Drawing.Size(265, 495)
        Me.TableLayoutPanel_CardRow.TabIndex = 5
        '
        'GroupBox_CardRow_Border
        '
        Me.GroupBox_CardRow_Border.Controls.Add(Me.TableLayoutPanel_Row_Border)
        Me.GroupBox_CardRow_Border.Location = New System.Drawing.Point(3, 256)
        Me.GroupBox_CardRow_Border.Name = "GroupBox_CardRow_Border"
        Me.GroupBox_CardRow_Border.Size = New System.Drawing.Size(209, 131)
        Me.GroupBox_CardRow_Border.TabIndex = 4
        Me.GroupBox_CardRow_Border.TabStop = False
        Me.GroupBox_CardRow_Border.Text = "Rahmen"
        '
        'TableLayoutPanel_Row_Border
        '
        Me.TableLayoutPanel_Row_Border.AutoSize = True
        Me.TableLayoutPanel_Row_Border.ColumnCount = 3
        Me.TableLayoutPanel_Row_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Row_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Row_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label_CardRow_Border_Bottom_Unit, 2, 3)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label_CardRow_Border_Left, 0, 0)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label_CardRow_Border_Top_Unit, 2, 2)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label_CardRow_Border_Right_Unit, 2, 1)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.NumericUpDown_CardRow_Border_Left, 1, 0)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label_CardRow_Border_Right, 0, 1)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label_CardRow_Border_Left_Unit, 2, 0)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label_CardRow_Border_Bottom, 0, 3)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.NumericUpDown_CardRow_Border_Right, 1, 1)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label_CardRow_Border_Top, 0, 2)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.NumericUpDown_CardRow_Border_Top, 1, 2)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.NumericUpDown_CardRow_Border_Bottom, 1, 3)
        Me.TableLayoutPanel_Row_Border.Location = New System.Drawing.Point(10, 19)
        Me.TableLayoutPanel_Row_Border.Name = "TableLayoutPanel_Row_Border"
        Me.TableLayoutPanel_Row_Border.RowCount = 4
        Me.TableLayoutPanel_Row_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Border.Size = New System.Drawing.Size(184, 104)
        Me.TableLayoutPanel_Row_Border.TabIndex = 3
        '
        'Label_CardRow_Border_Bottom_Unit
        '
        Me.Label_CardRow_Border_Bottom_Unit.AutoSize = True
        Me.Label_CardRow_Border_Bottom_Unit.Location = New System.Drawing.Point(127, 78)
        Me.Label_CardRow_Border_Bottom_Unit.Name = "Label_CardRow_Border_Bottom_Unit"
        Me.Label_CardRow_Border_Bottom_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_CardRow_Border_Bottom_Unit.TabIndex = 51
        Me.Label_CardRow_Border_Bottom_Unit.Text = "mm"
        Me.Label_CardRow_Border_Bottom_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_Border_Bottom_Unit.UseCompatibleTextRendering = True
        '
        'Label_CardRow_Border_Left
        '
        Me.Label_CardRow_Border_Left.AutoSize = True
        Me.Label_CardRow_Border_Left.Location = New System.Drawing.Point(3, 0)
        Me.Label_CardRow_Border_Left.Name = "Label_CardRow_Border_Left"
        Me.Label_CardRow_Border_Left.Size = New System.Drawing.Size(31, 17)
        Me.Label_CardRow_Border_Left.TabIndex = 19
        Me.Label_CardRow_Border_Left.Text = "Links"
        Me.Label_CardRow_Border_Left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_Border_Left.UseCompatibleTextRendering = True
        '
        'Label_CardRow_Border_Top_Unit
        '
        Me.Label_CardRow_Border_Top_Unit.AutoSize = True
        Me.Label_CardRow_Border_Top_Unit.Location = New System.Drawing.Point(127, 52)
        Me.Label_CardRow_Border_Top_Unit.Name = "Label_CardRow_Border_Top_Unit"
        Me.Label_CardRow_Border_Top_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_CardRow_Border_Top_Unit.TabIndex = 49
        Me.Label_CardRow_Border_Top_Unit.Text = "mm"
        Me.Label_CardRow_Border_Top_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_Border_Top_Unit.UseCompatibleTextRendering = True
        '
        'Label_CardRow_Border_Right_Unit
        '
        Me.Label_CardRow_Border_Right_Unit.AutoSize = True
        Me.Label_CardRow_Border_Right_Unit.Location = New System.Drawing.Point(127, 26)
        Me.Label_CardRow_Border_Right_Unit.Name = "Label_CardRow_Border_Right_Unit"
        Me.Label_CardRow_Border_Right_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_CardRow_Border_Right_Unit.TabIndex = 50
        Me.Label_CardRow_Border_Right_Unit.Text = "mm"
        Me.Label_CardRow_Border_Right_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_Border_Right_Unit.UseCompatibleTextRendering = True
        '
        'NumericUpDown_CardRow_Border_Left
        '
        Me.NumericUpDown_CardRow_Border_Left.Location = New System.Drawing.Point(48, 3)
        Me.NumericUpDown_CardRow_Border_Left.Name = "NumericUpDown_CardRow_Border_Left"
        Me.NumericUpDown_CardRow_Border_Left.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_CardRow_Border_Left.TabIndex = 14
        Me.NumericUpDown_CardRow_Border_Left.Tag = "CardRow;Left"
        '
        'Label_CardRow_Border_Right
        '
        Me.Label_CardRow_Border_Right.AutoSize = True
        Me.Label_CardRow_Border_Right.Location = New System.Drawing.Point(3, 26)
        Me.Label_CardRow_Border_Right.Name = "Label_CardRow_Border_Right"
        Me.Label_CardRow_Border_Right.Size = New System.Drawing.Size(39, 17)
        Me.Label_CardRow_Border_Right.TabIndex = 20
        Me.Label_CardRow_Border_Right.Text = "Rechts"
        Me.Label_CardRow_Border_Right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_Border_Right.UseCompatibleTextRendering = True
        '
        'Label_CardRow_Border_Left_Unit
        '
        Me.Label_CardRow_Border_Left_Unit.AutoSize = True
        Me.Label_CardRow_Border_Left_Unit.Location = New System.Drawing.Point(127, 0)
        Me.Label_CardRow_Border_Left_Unit.Name = "Label_CardRow_Border_Left_Unit"
        Me.Label_CardRow_Border_Left_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_CardRow_Border_Left_Unit.TabIndex = 48
        Me.Label_CardRow_Border_Left_Unit.Text = "mm"
        Me.Label_CardRow_Border_Left_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_Border_Left_Unit.UseCompatibleTextRendering = True
        '
        'Label_CardRow_Border_Bottom
        '
        Me.Label_CardRow_Border_Bottom.AutoSize = True
        Me.Label_CardRow_Border_Bottom.Location = New System.Drawing.Point(3, 78)
        Me.Label_CardRow_Border_Bottom.Name = "Label_CardRow_Border_Bottom"
        Me.Label_CardRow_Border_Bottom.Size = New System.Drawing.Size(34, 17)
        Me.Label_CardRow_Border_Bottom.TabIndex = 22
        Me.Label_CardRow_Border_Bottom.Text = "Unten"
        Me.Label_CardRow_Border_Bottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_Border_Bottom.UseCompatibleTextRendering = True
        '
        'NumericUpDown_CardRow_Border_Right
        '
        Me.NumericUpDown_CardRow_Border_Right.Location = New System.Drawing.Point(48, 29)
        Me.NumericUpDown_CardRow_Border_Right.Name = "NumericUpDown_CardRow_Border_Right"
        Me.NumericUpDown_CardRow_Border_Right.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_CardRow_Border_Right.TabIndex = 13
        Me.NumericUpDown_CardRow_Border_Right.Tag = "CardRow;Right"
        '
        'Label_CardRow_Border_Top
        '
        Me.Label_CardRow_Border_Top.AutoSize = True
        Me.Label_CardRow_Border_Top.Location = New System.Drawing.Point(3, 52)
        Me.Label_CardRow_Border_Top.Name = "Label_CardRow_Border_Top"
        Me.Label_CardRow_Border_Top.Size = New System.Drawing.Size(32, 17)
        Me.Label_CardRow_Border_Top.TabIndex = 21
        Me.Label_CardRow_Border_Top.Text = "Oben"
        Me.Label_CardRow_Border_Top.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_Border_Top.UseCompatibleTextRendering = True
        '
        'NumericUpDown_CardRow_Border_Top
        '
        Me.NumericUpDown_CardRow_Border_Top.Location = New System.Drawing.Point(48, 55)
        Me.NumericUpDown_CardRow_Border_Top.Name = "NumericUpDown_CardRow_Border_Top"
        Me.NumericUpDown_CardRow_Border_Top.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_CardRow_Border_Top.TabIndex = 12
        Me.NumericUpDown_CardRow_Border_Top.Tag = "CardRow;Top"
        '
        'NumericUpDown_CardRow_Border_Bottom
        '
        Me.NumericUpDown_CardRow_Border_Bottom.Location = New System.Drawing.Point(48, 81)
        Me.NumericUpDown_CardRow_Border_Bottom.Name = "NumericUpDown_CardRow_Border_Bottom"
        Me.NumericUpDown_CardRow_Border_Bottom.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_CardRow_Border_Bottom.TabIndex = 11
        Me.NumericUpDown_CardRow_Border_Bottom.Tag = "CardRow;Bottom"
        '
        'GroupBox_CardRow_Line
        '
        Me.GroupBox_CardRow_Line.Controls.Add(Me.TableLayoutPanel_Row_Line)
        Me.GroupBox_CardRow_Line.Location = New System.Drawing.Point(3, 102)
        Me.GroupBox_CardRow_Line.Name = "GroupBox_CardRow_Line"
        Me.GroupBox_CardRow_Line.Size = New System.Drawing.Size(247, 148)
        Me.GroupBox_CardRow_Line.TabIndex = 0
        Me.GroupBox_CardRow_Line.TabStop = False
        Me.GroupBox_CardRow_Line.Text = "Lines"
        '
        'TableLayoutPanel_Row_Line
        '
        Me.TableLayoutPanel_Row_Line.AutoSize = True
        Me.TableLayoutPanel_Row_Line.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel_Row_Line.ColumnCount = 2
        Me.TableLayoutPanel_Row_Line.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Row_Line.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Row_Line.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.Label_CardRow_DataColumn, 0, 4)
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.ComboBox_CardRow_DataColumn, 1, 4)
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.Label_CardRow_AutoFont, 0, 3)
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.CheckBox_CardRow_AutoFont, 1, 3)
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.Label_CardRow_QRCode, 0, 2)
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.CheckBox_CardRow_QRCode, 1, 2)
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.Label_CardRow_LinePos, 0, 1)
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.NumericUpDown_CardRow_LinePos, 1, 1)
        Me.TableLayoutPanel_Row_Line.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel_Row_Line.Name = "TableLayoutPanel_Row_Line"
        Me.TableLayoutPanel_Row_Line.RowCount = 5
        Me.TableLayoutPanel_Row_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Line.Size = New System.Drawing.Size(223, 118)
        Me.TableLayoutPanel_Row_Line.TabIndex = 28
        '
        'Label_CardRow_DataColumn
        '
        Me.Label_CardRow_DataColumn.AutoSize = True
        Me.Label_CardRow_DataColumn.Location = New System.Drawing.Point(4, 80)
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
        Me.ComboBox_CardRow_DataColumn.Location = New System.Drawing.Point(78, 83)
        Me.ComboBox_CardRow_DataColumn.Name = "ComboBox_CardRow_DataColumn"
        Me.ComboBox_CardRow_DataColumn.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_CardRow_DataColumn.TabIndex = 27
        '
        'Label_CardRow_AutoFont
        '
        Me.Label_CardRow_AutoFont.AutoSize = True
        Me.Label_CardRow_AutoFont.Location = New System.Drawing.Point(4, 59)
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
        Me.CheckBox_CardRow_AutoFont.Location = New System.Drawing.Point(78, 62)
        Me.CheckBox_CardRow_AutoFont.Name = "CheckBox_CardRow_AutoFont"
        Me.CheckBox_CardRow_AutoFont.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox_CardRow_AutoFont.TabIndex = 25
        Me.CheckBox_CardRow_AutoFont.UseVisualStyleBackColor = True
        '
        'Label_CardRow_QRCode
        '
        Me.Label_CardRow_QRCode.AutoSize = True
        Me.Label_CardRow_QRCode.Location = New System.Drawing.Point(4, 29)
        Me.Label_CardRow_QRCode.Name = "Label_CardRow_QRCode"
        Me.Label_CardRow_QRCode.Size = New System.Drawing.Size(48, 17)
        Me.Label_CardRow_QRCode.TabIndex = 19
        Me.Label_CardRow_QRCode.Text = "QRCode"
        Me.Label_CardRow_QRCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_CardRow_QRCode.UseCompatibleTextRendering = True
        '
        'CheckBox_CardRow_QRCode
        '
        Me.CheckBox_CardRow_QRCode.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_CardRow_QRCode.AutoSize = True
        Me.CheckBox_CardRow_QRCode.Location = New System.Drawing.Point(78, 32)
        Me.CheckBox_CardRow_QRCode.Name = "CheckBox_CardRow_QRCode"
        Me.CheckBox_CardRow_QRCode.Size = New System.Drawing.Size(72, 23)
        Me.CheckBox_CardRow_QRCode.TabIndex = 24
        Me.CheckBox_CardRow_QRCode.Text = "CheckBox1"
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
        'NumericUpDown_CardRow_LinePos
        '
        Me.NumericUpDown_CardRow_LinePos.Location = New System.Drawing.Point(78, 5)
        Me.NumericUpDown_CardRow_LinePos.Name = "NumericUpDown_CardRow_LinePos"
        Me.NumericUpDown_CardRow_LinePos.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_CardRow_LinePos.TabIndex = 10
        Me.NumericUpDown_CardRow_LinePos.Tag = "Decimal"
        '
        'GroupBox_CardRow_List
        '
        Me.GroupBox_CardRow_List.Controls.Add(Me.TableLayoutPanel_CardRow_List)
        Me.GroupBox_CardRow_List.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox_CardRow_List.Name = "GroupBox_CardRow_List"
        Me.GroupBox_CardRow_List.Size = New System.Drawing.Size(247, 93)
        Me.GroupBox_CardRow_List.TabIndex = 5
        Me.GroupBox_CardRow_List.TabStop = False
        Me.GroupBox_CardRow_List.Text = "Zeilen"
        '
        'TableLayoutPanel_CardRow_List
        '
        Me.TableLayoutPanel_CardRow_List.ColumnCount = 3
        Me.TableLayoutPanel_CardRow_List.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_CardRow_List.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_CardRow_List.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_CardRow_List.Controls.Add(Me.ListBox_CardRow_List, 0, 0)
        Me.TableLayoutPanel_CardRow_List.Controls.Add(Me.Button_CardRow_List_Add, 0, 1)
        Me.TableLayoutPanel_CardRow_List.Controls.Add(Me.Button_CardRow_List_Delete, 2, 1)
        Me.TableLayoutPanel_CardRow_List.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel_CardRow_List.Name = "TableLayoutPanel_CardRow_List"
        Me.TableLayoutPanel_CardRow_List.RowCount = 2
        Me.TableLayoutPanel_CardRow_List.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow_List.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_CardRow_List.Size = New System.Drawing.Size(172, 61)
        Me.TableLayoutPanel_CardRow_List.TabIndex = 2
        '
        'ListBox_CardRow_List
        '
        Me.ListBox_CardRow_List.FormattingEnabled = True
        Me.ListBox_CardRow_List.Location = New System.Drawing.Point(3, 3)
        Me.ListBox_CardRow_List.Name = "ListBox_CardRow_List"
        Me.ListBox_CardRow_List.Size = New System.Drawing.Size(75, 30)
        Me.ListBox_CardRow_List.TabIndex = 1
        '
        'Button_CardRow_List_Add
        '
        Me.Button_CardRow_List_Add.Location = New System.Drawing.Point(3, 39)
        Me.Button_CardRow_List_Add.Name = "Button_CardRow_List_Add"
        Me.Button_CardRow_List_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_CardRow_List_Add.TabIndex = 2
        Me.Button_CardRow_List_Add.Text = "Neue Zeile"
        Me.Button_CardRow_List_Add.UseVisualStyleBackColor = True
        '
        'Button_CardRow_List_Delete
        '
        Me.Button_CardRow_List_Delete.Location = New System.Drawing.Point(94, 39)
        Me.Button_CardRow_List_Delete.Name = "Button_CardRow_List_Delete"
        Me.Button_CardRow_List_Delete.Size = New System.Drawing.Size(75, 23)
        Me.Button_CardRow_List_Delete.TabIndex = 3
        Me.Button_CardRow_List_Delete.Text = "Zeile löschen"
        Me.Button_CardRow_List_Delete.UseVisualStyleBackColor = True
        '
        'TabPage_Table
        '
        Me.TabPage_Table.Controls.Add(Me.DGV_Table)
        Me.TabPage_Table.Controls.Add(Me.ListBox_Tabellen)
        Me.TabPage_Table.Location = New System.Drawing.Point(4, 49)
        Me.TabPage_Table.Name = "TabPage_Table"
        Me.TabPage_Table.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Table.Size = New System.Drawing.Size(232, 223)
        Me.TabPage_Table.TabIndex = 4
        Me.TabPage_Table.Text = "Tabellen"
        Me.TabPage_Table.UseVisualStyleBackColor = True
        '
        'DGV_Table
        '
        Me.DGV_Table.AllowUserToAddRows = False
        Me.DGV_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Table.Location = New System.Drawing.Point(323, 73)
        Me.DGV_Table.Name = "DGV_Table"
        Me.DGV_Table.Size = New System.Drawing.Size(125, 134)
        Me.DGV_Table.TabIndex = 0
        '
        'ListBox_Tabellen
        '
        Me.ListBox_Tabellen.BackColor = System.Drawing.SystemColors.Control
        Me.ListBox_Tabellen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_Tabellen.FormattingEnabled = True
        Me.ListBox_Tabellen.Location = New System.Drawing.Point(15, 39)
        Me.ListBox_Tabellen.Name = "ListBox_Tabellen"
        Me.ListBox_Tabellen.Size = New System.Drawing.Size(77, 299)
        Me.ListBox_Tabellen.TabIndex = 2
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
        'ToolStripMenuItem_Optionen
        '
        Me.ToolStripMenuItem_Optionen.Name = "ToolStripMenuItem_Optionen"
        Me.ToolStripMenuItem_Optionen.Size = New System.Drawing.Size(125, 22)
        Me.ToolStripMenuItem_Optionen.Text = "&Optionen"
        '
        'ToolStripMenuItem_Font
        '
        Me.ToolStripMenuItem_Font.Name = "ToolStripMenuItem_Font"
        Me.ToolStripMenuItem_Font.Size = New System.Drawing.Size(122, 22)
        Me.ToolStripMenuItem_Font.Text = "Schriftart"
        '
        'ToolStripMenuItem_Anpassen
        '
        Me.ToolStripMenuItem_Anpassen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Font})
        Me.ToolStripMenuItem_Anpassen.Name = "ToolStripMenuItem_Anpassen"
        Me.ToolStripMenuItem_Anpassen.Size = New System.Drawing.Size(125, 22)
        Me.ToolStripMenuItem_Anpassen.Text = "&Anpassen"
        '
        'ToolStripMenuItem_Extras
        '
        Me.ToolStripMenuItem_Extras.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Anpassen, Me.ToolStripMenuItem_Optionen})
        Me.ToolStripMenuItem_Extras.Name = "ToolStripMenuItem_Extras"
        Me.ToolStripMenuItem_Extras.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripMenuItem_Extras.Text = "E&xtras"
        '
        'AlleauswählenToolStripMenuItem
        '
        Me.AlleauswählenToolStripMenuItem.Name = "AlleauswählenToolStripMenuItem"
        Me.AlleauswählenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AlleauswählenToolStripMenuItem.Text = "&Alle auswählen"
        '
        'ToolStripSeparator05
        '
        Me.ToolStripSeparator05.Name = "ToolStripSeparator05"
        Me.ToolStripSeparator05.Size = New System.Drawing.Size(188, 6)
        '
        'ToolStripSeparator04
        '
        Me.ToolStripSeparator04.Name = "ToolStripSeparator04"
        Me.ToolStripSeparator04.Size = New System.Drawing.Size(188, 6)
        '
        'ToolStripMenuItem_Wiederholen
        '
        Me.ToolStripMenuItem_Wiederholen.Name = "ToolStripMenuItem_Wiederholen"
        Me.ToolStripMenuItem_Wiederholen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_Wiederholen.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem_Wiederholen.Text = "Wiede&rholen"
        '
        'ToolStripMenuItem_Rückgängig
        '
        Me.ToolStripMenuItem_Rückgängig.Name = "ToolStripMenuItem_Rückgängig"
        Me.ToolStripMenuItem_Rückgängig.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_Rückgängig.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem_Rückgängig.Text = "&Rückgängig"
        '
        'ToolStripMenuItem_Beenden
        '
        Me.ToolStripMenuItem_Beenden.Name = "ToolStripMenuItem_Beenden"
        Me.ToolStripMenuItem_Beenden.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem_Beenden.Text = "&Beenden"
        '
        'ToolStripSeparator03
        '
        Me.ToolStripSeparator03.Name = "ToolStripSeparator03"
        Me.ToolStripSeparator03.Size = New System.Drawing.Size(165, 6)
        '
        'ToolStripSeparator02
        '
        Me.ToolStripSeparator02.Name = "ToolStripSeparator02"
        Me.ToolStripSeparator02.Size = New System.Drawing.Size(165, 6)
        '
        'ToolStripMenuItem_XML_SaveAs
        '
        Me.ToolStripMenuItem_XML_SaveAs.Name = "ToolStripMenuItem_XML_SaveAs"
        Me.ToolStripMenuItem_XML_SaveAs.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem_XML_SaveAs.Text = "Speichern &unter"
        '
        'ToolStripSeparator01
        '
        Me.ToolStripSeparator01.Name = "ToolStripSeparator01"
        Me.ToolStripSeparator01.Size = New System.Drawing.Size(165, 6)
        '
        'ToolStripMenuItem_Datei
        '
        Me.ToolStripMenuItem_Datei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_XML_New, Me.ToolStripMenuItem_XML_Open, Me.ToolStripSeparator01, Me.ToolStripMenuItem_XML_Safe, Me.ToolStripMenuItem_XML_SaveAs, Me.ToolStripSeparator02, Me.ToolStripMenuItem_Print, Me.ToolStripMenuItem_Seitenansicht, Me.ToolStripSeparator03, Me.ToolStripMenuItem_Beenden})
        Me.ToolStripMenuItem_Datei.Name = "ToolStripMenuItem_Datei"
        Me.ToolStripMenuItem_Datei.Size = New System.Drawing.Size(46, 20)
        Me.ToolStripMenuItem_Datei.Text = "&Datei"
        '
        'ToolStripMenuItem_XML_New
        '
        Me.ToolStripMenuItem_XML_New.Image = CType(resources.GetObject("ToolStripMenuItem_XML_New.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem_XML_New.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem_XML_New.Name = "ToolStripMenuItem_XML_New"
        Me.ToolStripMenuItem_XML_New.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_XML_New.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem_XML_New.Text = "&Neu"
        '
        'ToolStripMenuItem_XML_Open
        '
        Me.ToolStripMenuItem_XML_Open.Image = CType(resources.GetObject("ToolStripMenuItem_XML_Open.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem_XML_Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem_XML_Open.Name = "ToolStripMenuItem_XML_Open"
        Me.ToolStripMenuItem_XML_Open.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_XML_Open.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem_XML_Open.Text = "Ö&ffnen"
        '
        'ToolStripMenuItem_XML_Safe
        '
        Me.ToolStripMenuItem_XML_Safe.Image = CType(resources.GetObject("ToolStripMenuItem_XML_Safe.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem_XML_Safe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem_XML_Safe.Name = "ToolStripMenuItem_XML_Safe"
        Me.ToolStripMenuItem_XML_Safe.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_XML_Safe.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem_XML_Safe.Text = "&Speichern"
        '
        'ToolStripMenuItem_Print
        '
        Me.ToolStripMenuItem_Print.Image = CType(resources.GetObject("ToolStripMenuItem_Print.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem_Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem_Print.Name = "ToolStripMenuItem_Print"
        Me.ToolStripMenuItem_Print.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_Print.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem_Print.Text = "&Drucken"
        '
        'ToolStripMenuItem_Seitenansicht
        '
        Me.ToolStripMenuItem_Seitenansicht.Image = CType(resources.GetObject("ToolStripMenuItem_Seitenansicht.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem_Seitenansicht.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem_Seitenansicht.Name = "ToolStripMenuItem_Seitenansicht"
        Me.ToolStripMenuItem_Seitenansicht.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem_Seitenansicht.Text = "&Seitenansicht"
        '
        'ToolStripMenuItem_Bearbeiten
        '
        Me.ToolStripMenuItem_Bearbeiten.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Rückgängig, Me.ToolStripMenuItem_Wiederholen, Me.ToolStripSeparator04, Me.AusschneidenToolStripMenuItem, Me.KopierenToolStripMenuItem, Me.EinfügenToolStripMenuItem, Me.ToolStripSeparator05, Me.AlleauswählenToolStripMenuItem})
        Me.ToolStripMenuItem_Bearbeiten.Name = "ToolStripMenuItem_Bearbeiten"
        Me.ToolStripMenuItem_Bearbeiten.Size = New System.Drawing.Size(75, 20)
        Me.ToolStripMenuItem_Bearbeiten.Text = "&Bearbeiten"
        '
        'AusschneidenToolStripMenuItem
        '
        Me.AusschneidenToolStripMenuItem.Image = CType(resources.GetObject("AusschneidenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AusschneidenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AusschneidenToolStripMenuItem.Name = "AusschneidenToolStripMenuItem"
        Me.AusschneidenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.AusschneidenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AusschneidenToolStripMenuItem.Text = "&Ausschneiden"
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.Image = CType(resources.GetObject("KopierenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KopierenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        Me.KopierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.KopierenToolStripMenuItem.Text = "&Kopieren"
        '
        'EinfügenToolStripMenuItem
        '
        Me.EinfügenToolStripMenuItem.Image = CType(resources.GetObject("EinfügenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EinfügenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
        Me.EinfügenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.EinfügenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EinfügenToolStripMenuItem.Text = "&Einfügen"
        '
        'MenuStrip_Main
        '
        Me.MenuStrip_Main.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Datei, Me.ToolStripMenuItem_Bearbeiten, Me.ToolStripMenuItem_Extras})
        Me.MenuStrip_Main.Location = New System.Drawing.Point(6, 6)
        Me.MenuStrip_Main.Name = "MenuStrip_Main"
        Me.MenuStrip_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip_Main.Size = New System.Drawing.Size(477, 24)
        Me.MenuStrip_Main.TabIndex = 4
        Me.MenuStrip_Main.Text = "MenuStrip1"
        '
        'ToolStripStatusLabel_SaveFile
        '
        Me.ToolStripStatusLabel_SaveFile.Name = "ToolStripStatusLabel_SaveFile"
        Me.ToolStripStatusLabel_SaveFile.Size = New System.Drawing.Size(37, 17)
        Me.ToolStripStatusLabel_SaveFile.Text = "Bereit"
        '
        'ToolStripStatusLabel_SaveInfo
        '
        Me.ToolStripStatusLabel_SaveInfo.Name = "ToolStripStatusLabel_SaveInfo"
        Me.ToolStripStatusLabel_SaveInfo.Size = New System.Drawing.Size(88, 17)
        Me.ToolStripStatusLabel_SaveInfo.Text = "Gespeichert in: "
        '
        'ToolStripStatusLabel_IsModified
        '
        Me.ToolStripStatusLabel_IsModified.AutoSize = False
        Me.ToolStripStatusLabel_IsModified.BackColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel_IsModified.Name = "ToolStripStatusLabel_IsModified"
        Me.ToolStripStatusLabel_IsModified.Size = New System.Drawing.Size(17, 17)
        '
        'StatusStrip_Main
        '
        Me.StatusStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_IsModified, Me.ToolStripStatusLabel_SaveInfo, Me.ToolStripStatusLabel_SaveFile})
        Me.StatusStrip_Main.Location = New System.Drawing.Point(6, 320)
        Me.StatusStrip_Main.Name = "StatusStrip_Main"
        Me.StatusStrip_Main.Size = New System.Drawing.Size(477, 22)
        Me.StatusStrip_Main.SizingGrip = False
        Me.StatusStrip_Main.TabIndex = 5
        Me.StatusStrip_Main.Text = "StatusStrip1"
        '
        'SplitContainer_Main
        '
        Me.SplitContainer_Main.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer_Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer_Main.Location = New System.Drawing.Point(12, 43)
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
        Me.SplitContainer_Main.Size = New System.Drawing.Size(449, 276)
        Me.SplitContainer_Main.SplitterDistance = 240
        Me.SplitContainer_Main.SplitterWidth = 9
        Me.SplitContainer_Main.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = Global.CSVtoQR.My.MySettings.Default.MySize
        Me.Controls.Add(Me.SplitContainer_Main)
        Me.Controls.Add(Me.StatusStrip_Main)
        Me.Controls.Add(Me.MenuStrip_Main)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.CSVtoQR.My.MySettings.Default, "MyLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.CSVtoQR.My.MySettings.Default, "MyFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ClientSize", Global.CSVtoQR.My.MySettings.Default, "MySize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.CSVtoQR.My.MySettings.Default.MyFont
        Me.Location = Global.CSVtoQR.My.MySettings.Default.MyLocation
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.Text = "Form1"
        Me.TableLayoutPanel_Separator.ResumeLayout(False)
        Me.TableLayoutPanel_Separator.PerformLayout()
        CType(Me.NumericUpDown_Separator_Column_Count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Separator_Column_Value, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Separator_Row_Count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Separator_Row_Value, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Separator_Row.ResumeLayout(False)
        CType(Me.NumericUpDown_Paper_Border_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Paper_Border_Bottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Paper_Border_Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Paper_Border_Right, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel_Files.ResumeLayout(False)
        Me.TableLayoutPanel_Files.PerformLayout()
        CType(Me.DGV_Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_CSV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator_CSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator_CSV.ResumeLayout(False)
        Me.BindingNavigator_CSV.PerformLayout()
        Me.TabPage_Files.ResumeLayout(False)
        Me.TabPage_Files.PerformLayout()
        Me.TabControl_Main.ResumeLayout(False)
        Me.TabPage_Paper.ResumeLayout(False)
        Me.TableLayoutPanel_Paper.ResumeLayout(False)
        Me.TableLayoutPanel_Paper.PerformLayout()
        Me.GroupBox_Separator_Column.ResumeLayout(False)
        Me.TableLayoutPanel_Separator_Column.ResumeLayout(False)
        Me.TableLayoutPanel_Separator_Column.PerformLayout()
        Me.GroupBox_Paper_Border.ResumeLayout(False)
        Me.GroupBox_Paper_Border.PerformLayout()
        Me.TableLayoutPanel_Paper_Border.ResumeLayout(False)
        Me.TableLayoutPanel_Paper_Border.PerformLayout()
        Me.GroupBox_Shema.ResumeLayout(False)
        Me.GroupBox_Shema.PerformLayout()
        Me.TableLayoutPanel_Shema.ResumeLayout(False)
        Me.TableLayoutPanel_Shema.PerformLayout()
        Me.TabPage_Card.ResumeLayout(False)
        Me.TableLayoutPanel_Card.ResumeLayout(False)
        Me.GroupBox_Card_Size.ResumeLayout(False)
        Me.TableLayoutPanel_Card_Size.ResumeLayout(False)
        Me.TableLayoutPanel_Card_Size.PerformLayout()
        Me.GroupBox_Card_Border.ResumeLayout(False)
        Me.GroupBox_Card_Border.PerformLayout()
        Me.TableLayoutPanel_Card_Border.ResumeLayout(False)
        Me.TableLayoutPanel_Card_Border.PerformLayout()
        CType(Me.NumericUpDown_Card_Border_Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Card_Border_Right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Card_Border_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Card_Border_Bottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Card_Font.ResumeLayout(False)
        Me.TableLayoutPanel_Card_Font.ResumeLayout(False)
        Me.TableLayoutPanel_Card_Font.PerformLayout()
        Me.TabPage_Row.ResumeLayout(False)
        Me.TableLayoutPanel_CardRow.ResumeLayout(False)
        Me.GroupBox_CardRow_Border.ResumeLayout(False)
        Me.GroupBox_CardRow_Border.PerformLayout()
        Me.TableLayoutPanel_Row_Border.ResumeLayout(False)
        Me.TableLayoutPanel_Row_Border.PerformLayout()
        CType(Me.NumericUpDown_CardRow_Border_Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_CardRow_Border_Right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_CardRow_Border_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_CardRow_Border_Bottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_CardRow_Line.ResumeLayout(False)
        Me.GroupBox_CardRow_Line.PerformLayout()
        Me.TableLayoutPanel_Row_Line.ResumeLayout(False)
        Me.TableLayoutPanel_Row_Line.PerformLayout()
        CType(Me.NumericUpDown_CardRow_LinePos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_CardRow_List.ResumeLayout(False)
        Me.TableLayoutPanel_CardRow_List.ResumeLayout(False)
        Me.TabPage_Table.ResumeLayout(False)
        CType(Me.DGV_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Preview.ResumeLayout(False)
        CType(Me.PictureBox_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip_Main.ResumeLayout(False)
        Me.MenuStrip_Main.PerformLayout()
        Me.StatusStrip_Main.ResumeLayout(False)
        Me.StatusStrip_Main.PerformLayout()
        CType(Me.BindingSource_CSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Main.Panel1.ResumeLayout(False)
        Me.SplitContainer_Main.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Main.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Separator_Row_Count As Label
    Friend WithEvents Label_Separator_Row_Value As Label
    Friend WithEvents TableLayoutPanel_Separator As TableLayoutPanel
    Friend WithEvents GroupBox_Separator_Row As GroupBox
    Friend WithEvents GroupBox_Shema As GroupBox
    Friend WithEvents TableLayoutPanel_Shema As TableLayoutPanel
    Friend WithEvents Label_Shema As Label
    Friend WithEvents TextBox_Shema As TextBox
    Friend WithEvents Label_Paper_Width As Label
    Friend WithEvents Label_Paper_Height As Label
    Friend WithEvents Label_Paper_DPI As Label
    Friend WithEvents Label_Paper_DIN As Label
    Friend WithEvents ComboBox_Paper_DIN As ComboBox
    Friend WithEvents Label_Paper_Height_Unit As Label
    Friend WithEvents Label_Paper_Width_Unit As Label
    Friend WithEvents Label_Paper_Border_Left As Label
    Friend WithEvents Label_Paper_Border_Bottom As Label
    Friend WithEvents Label_Paper_Border_Top As Label
    Friend WithEvents Label_Paper_Border_Right As Label
    Friend WithEvents FontDialog_Main As FontDialog
    Friend WithEvents Label_Import As Label
    Friend WithEvents TextBox_Import As TextBox
    Friend WithEvents Label_Export As Label
    Friend WithEvents TextBox_Export As TextBox
    Friend WithEvents Button_Import As Button
    Friend WithEvents ImageList_Main As ImageList
    Friend WithEvents Button_Export As Button
    Friend WithEvents TableLayoutPanel_Files As TableLayoutPanel
    Friend WithEvents Button_Search_Add As Button
    Friend WithEvents Button_Search_Delete As Button
    Friend WithEvents DGV_Search As DataGridView
    Friend WithEvents TabPage_Files As TabPage
    Friend WithEvents TabControl_Main As TabControl
    Friend WithEvents TabPage_Paper As TabPage
    Friend WithEvents Panel_Preview As Panel
    Friend WithEvents PictureBox_Preview As PictureBox
    Friend WithEvents TabPage_Table As TabPage
    Friend WithEvents DGV_Table As DataGridView
    Friend WithEvents ListBox_Tabellen As ListBox
    Friend WithEvents ToolStripMenuItem_Optionen As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Font As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Anpassen As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Extras As ToolStripMenuItem
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
    Friend WithEvents NumericUpDown_Paper_Border_Left As NumericUpDown
    Friend WithEvents NumericUpDown_Paper_Border_Top As NumericUpDown
    Friend WithEvents NumericUpDown_Paper_Border_Right As NumericUpDown
    Friend WithEvents NumericUpDown_Separator_Column_Count As NumericUpDown
    Friend WithEvents NumericUpDown_Separator_Row_Count As NumericUpDown
    Friend WithEvents NumericUpDown_Paper_Border_Bottom As NumericUpDown
    Friend WithEvents NumericUpDown_Separator_Column_Value As NumericUpDown
    Friend WithEvents NumericUpDown_Separator_Row_Value As NumericUpDown
    Friend WithEvents ComboBox_Paper_DPI As ComboBox
    Friend WithEvents Label_Paper_Width_Value As Label
    Friend WithEvents Label_Paper_Height_Value As Label
    Friend WithEvents TableLayoutPanel_Paper As TableLayoutPanel
    Friend WithEvents Button_Search_Refresh As Button
    Friend WithEvents TabPage_Card As TabPage
    Friend WithEvents TableLayoutPanel_Card_Border As TableLayoutPanel
    Friend WithEvents NumericUpDown_Card_Border_Left As NumericUpDown
    Friend WithEvents Label_Card_Border_Bottom As Label
    Friend WithEvents Label_Card_Border_Top As Label
    Friend WithEvents Label_Card_Border_Right As Label
    Friend WithEvents Label_Card_Border_Left As Label
    Friend WithEvents NumericUpDown_Card_Border_Bottom As NumericUpDown
    Friend WithEvents NumericUpDown_Card_Border_Top As NumericUpDown
    Friend WithEvents NumericUpDown_Card_Border_Right As NumericUpDown
    Friend WithEvents NumericUpDown_CardRow_LinePos As NumericUpDown
    Friend WithEvents NumericUpDown_CardRow_Border_Bottom As NumericUpDown
    Friend WithEvents NumericUpDown_CardRow_Border_Top As NumericUpDown
    Friend WithEvents NumericUpDown_CardRow_Border_Right As NumericUpDown
    Friend WithEvents NumericUpDown_CardRow_Border_Left As NumericUpDown
    Friend WithEvents Label_CardRow_DataColumn As Label
    Friend WithEvents Label_CardRow_LinePos As Label
    Friend WithEvents Label_CardRow_Border_Bottom As Label
    Friend WithEvents Label_CardRow_Border_Top As Label
    Friend WithEvents Label_CardRow_Border_Right As Label
    Friend WithEvents Label_CardRow_Border_Left As Label
    Friend WithEvents Label_CardRow_QRCode As Label
    Friend WithEvents CheckBox_CardRow_AutoFont As CheckBox
    Friend WithEvents CheckBox_CardRow_QRCode As CheckBox
    Friend WithEvents Label_CardRow_AutoFont As Label
    Friend WithEvents ComboBox_CardRow_DataColumn As ComboBox
    Friend WithEvents Label_Card_FontColor As Label
    Friend WithEvents Label_Card_Font As Label
    Friend WithEvents Label_Card_Font_Value As Label
    Friend WithEvents Label_Paper_Border_Bottom_Unit As Label
    Friend WithEvents Label_Paper_Border_Top_Unit As Label
    Friend WithEvents Label_Paper_Border_Right_Unit As Label
    Friend WithEvents Label_Paper_Border_Left_Unit As Label
    Friend WithEvents ListBox_CardRow_List As ListBox
    Friend WithEvents TableLayoutPanel_Paper_Border As TableLayoutPanel
    Friend WithEvents GroupBox_Paper_Border As GroupBox
    Friend WithEvents TabPage_Row As TabPage
    Friend WithEvents SplitContainer_Main As SplitContainer
    Friend WithEvents GroupBox_CardRow_Border As GroupBox
    Friend WithEvents TableLayoutPanel_Row_Border As TableLayoutPanel
    Friend WithEvents GroupBox_CardRow_Line As GroupBox
    Friend WithEvents TableLayoutPanel_CardRow As TableLayoutPanel
    Friend WithEvents TableLayoutPanel_Row_Line As TableLayoutPanel
    Friend WithEvents GroupBox_Card_Border As GroupBox
    Friend WithEvents Label_Separator_Column_Count As Label
    Friend WithEvents Label_Separator_Column_Value As Label
    Friend WithEvents Label_Separator_Column_Value_Unit As Label
    Friend WithEvents Label_Separator_Row_Value_Unit As Label
    Friend WithEvents GroupBox_Separator_Column As GroupBox
    Friend WithEvents TableLayoutPanel_Separator_Column As TableLayoutPanel
    Friend WithEvents Label_Card_Border_Bottom_Unit As Label
    Friend WithEvents Label_Card_Border_Top_Unit As Label
    Friend WithEvents Label_Card_Border_Right_Unit As Label
    Friend WithEvents Label_Card_Border_Left_Unit As Label
    Friend WithEvents Label_CardRow_Border_Bottom_Unit As Label
    Friend WithEvents Label_CardRow_Border_Top_Unit As Label
    Friend WithEvents Label_CardRow_Border_Right_Unit As Label
    Friend WithEvents Label_CardRow_Border_Left_Unit As Label
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
    Friend WithEvents GroupBox_Card_Font As GroupBox
    Friend WithEvents TableLayoutPanel_Card_Font As TableLayoutPanel
    Friend WithEvents Label_Card_FontColor_Value As Label
    Friend WithEvents TableLayoutPanel_Card As TableLayoutPanel
    Friend WithEvents GroupBox_Card_Size As GroupBox
    Friend WithEvents TableLayoutPanel_Card_Size As TableLayoutPanel
    Friend WithEvents Label_Card_Size_Hight As Label
    Friend WithEvents Label_Card_Size_Hight_Value As Label
    Friend WithEvents Label_Card_Size_Width As Label
    Friend WithEvents Label_Card_Size_Width_Value As Label
    Friend WithEvents GroupBox_CardRow_List As GroupBox
    Friend WithEvents TableLayoutPanel_CardRow_List As TableLayoutPanel
    Friend WithEvents Button_CardRow_List_Add As Button
    Friend WithEvents Button_CardRow_List_Delete As Button
End Class
