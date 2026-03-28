<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label_Separator_Row_Count = New System.Windows.Forms.Label()
        Me.Label_Separator_Row_Value = New System.Windows.Forms.Label()
        Me.TableLayoutPanel_Separator = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Separator_Column_Value_Unit = New System.Windows.Forms.Label()
        Me.Label_Separator_Column_Count = New System.Windows.Forms.Label()
        Me.Label_Separator_Column_Value = New System.Windows.Forms.Label()
        Me.NumericUpDown_Separator_Column_Count = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Separator_Spalte_Wert = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Separator_Row_Anzahl = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Separator_Zeile_Wert = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox_Separator_Row = New System.Windows.Forms.GroupBox()
        Me.Label_Paper_Border_Left = New System.Windows.Forms.Label()
        Me.Label_Paper_Border_Bottom = New System.Windows.Forms.Label()
        Me.Label_Paper_Border_Top = New System.Windows.Forms.Label()
        Me.Label_Paper_Border_Right = New System.Windows.Forms.Label()
        Me.Label_Paper_Width = New System.Windows.Forms.Label()
        Me.Label_Paper_Height = New System.Windows.Forms.Label()
        Me.Label_DPI = New System.Windows.Forms.Label()
        Me.Label_DIN = New System.Windows.Forms.Label()
        Me.NumericUpDown_Paper_Border_Top = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Paper_Border_Bottom = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Paper_Border_Left = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Paper_Border_Right = New System.Windows.Forms.NumericUpDown()
        Me.Main_FontDialog = New System.Windows.Forms.FontDialog()
        Me.Label_Import = New System.Windows.Forms.Label()
        Me.TextBox_Import = New System.Windows.Forms.TextBox()
        Me.Label_Export = New System.Windows.Forms.Label()
        Me.TextBox_Export = New System.Windows.Forms.TextBox()
        Me.Main_ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel_Files = New System.Windows.Forms.TableLayoutPanel()
        Me.DGV_Search = New System.Windows.Forms.DataGridView()
        Me.Button_Search_Add = New System.Windows.Forms.Button()
        Me.Button_Search_Delete = New System.Windows.Forms.Button()
        Me.Button_Import = New System.Windows.Forms.Button()
        Me.Button_Export = New System.Windows.Forms.Button()
        Me.Button_Search_Refresh = New System.Windows.Forms.Button()
        Me.Panel_Daten_CSV = New System.Windows.Forms.Panel()
        Me.DGV_CSV = New System.Windows.Forms.DataGridView()
        Me.Main_BindingNavigator_CSV = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabPage_Files = New System.Windows.Forms.TabPage()
        Me.Main_TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage_Paper = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel_Paper = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox_Separator_Column = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Separator_Row_Wert_Unit = New System.Windows.Forms.Label()
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
        Me.ComboBox_DPI = New System.Windows.Forms.ComboBox()
        Me.TextBox_Shema = New System.Windows.Forms.TextBox()
        Me.ComboBox_DIN = New System.Windows.Forms.ComboBox()
        Me.TabPage_Card = New System.Windows.Forms.TabPage()
        Me.GroupBox_Card = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Card = New System.Windows.Forms.TableLayoutPanel()
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabPage_Row = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel_Row = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox_Row_Border = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Row_Border = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown_CardRow_Border_Left = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox_Row_Line = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Row_Line = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBox_DataColumn = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CheckBox_AutoFont = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CheckBox_QRCode = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.TabPage_Table = New System.Windows.Forms.TabPage()
        Me.DGV_Table = New System.Windows.Forms.DataGridView()
        Me.ListBox_Tabellen = New System.Windows.Forms.ListBox()
        Me.Panel_Paper = New System.Windows.Forms.Panel()
        Me.PictureBox_Paper = New System.Windows.Forms.PictureBox()
        Me.ToolStripMenuItem_Optionen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Font = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Anpassen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Extras = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlleauswählenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator05 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator04 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_Wiederholen = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InhaltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Suchen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator06 = New System.Windows.Forms.ToolStripSeparator()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Rückgängig = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Beenden = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator03 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator02 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_XML_SaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator01 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_Datei = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_XML_New = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Öffnen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Safe = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Print = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Seitenansicht = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Bearbeiten = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Main_MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Main_SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Main_OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStripStatusLabel_SaveFile = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_SaveInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_IsModified = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Main_StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Main_BindingSource_CSV = New System.Windows.Forms.BindingSource(Me.components)
        Me.Main_SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel_Separator.SuspendLayout()
        CType(Me.NumericUpDown_Separator_Column_Count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Separator_Spalte_Wert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Separator_Row_Anzahl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Separator_Zeile_Wert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Separator_Row.SuspendLayout()
        CType(Me.NumericUpDown_Paper_Border_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Paper_Border_Bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Paper_Border_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Paper_Border_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel_Files.SuspendLayout()
        CType(Me.DGV_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Daten_CSV.SuspendLayout()
        CType(Me.DGV_CSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_BindingNavigator_CSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Main_BindingNavigator_CSV.SuspendLayout()
        Me.TabPage_Files.SuspendLayout()
        Me.Main_TabControl.SuspendLayout()
        Me.TabPage_Paper.SuspendLayout()
        Me.TableLayoutPanel_Paper.SuspendLayout()
        Me.GroupBox_Separator_Column.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox_Paper_Border.SuspendLayout()
        Me.TableLayoutPanel_Paper_Border.SuspendLayout()
        Me.GroupBox_Shema.SuspendLayout()
        Me.TableLayoutPanel_Shema.SuspendLayout()
        Me.TabPage_Card.SuspendLayout()
        Me.GroupBox_Card.SuspendLayout()
        Me.TableLayoutPanel_Card.SuspendLayout()
        CType(Me.NumericUpDown_Card_Border_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Card_Border_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Card_Border_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Card_Border_Bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Row.SuspendLayout()
        Me.TableLayoutPanel_Row.SuspendLayout()
        Me.GroupBox_Row_Border.SuspendLayout()
        Me.TableLayoutPanel_Row_Border.SuspendLayout()
        CType(Me.NumericUpDown_CardRow_Border_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Row_Line.SuspendLayout()
        Me.TableLayoutPanel_Row_Line.SuspendLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Table.SuspendLayout()
        CType(Me.DGV_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Paper.SuspendLayout()
        CType(Me.PictureBox_Paper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Main_MenuStrip.SuspendLayout()
        Me.Main_StatusStrip.SuspendLayout()
        CType(Me.Main_BindingSource_CSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Main_SplitContainer.Panel1.SuspendLayout()
        Me.Main_SplitContainer.Panel2.SuspendLayout()
        Me.Main_SplitContainer.SuspendLayout()
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
        Me.TableLayoutPanel_Separator.Controls.Add(Me.NumericUpDown_Separator_Spalte_Wert, 1, 1)
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
        'NumericUpDown_Separator_Spalte_Wert
        '
        Me.NumericUpDown_Separator_Spalte_Wert.Location = New System.Drawing.Point(48, 29)
        Me.NumericUpDown_Separator_Spalte_Wert.Name = "NumericUpDown_Separator_Spalte_Wert"
        Me.NumericUpDown_Separator_Spalte_Wert.Size = New System.Drawing.Size(75, 20)
        Me.NumericUpDown_Separator_Spalte_Wert.TabIndex = 1
        Me.NumericUpDown_Separator_Spalte_Wert.Tag = "SeparatorSpalteWert"
        '
        'NumericUpDown_Separator_Row_Anzahl
        '
        Me.NumericUpDown_Separator_Row_Anzahl.Location = New System.Drawing.Point(48, 3)
        Me.NumericUpDown_Separator_Row_Anzahl.Name = "NumericUpDown_Separator_Row_Anzahl"
        Me.NumericUpDown_Separator_Row_Anzahl.Size = New System.Drawing.Size(74, 20)
        Me.NumericUpDown_Separator_Row_Anzahl.TabIndex = 2
        Me.NumericUpDown_Separator_Row_Anzahl.Tag = "SeparatorZeileAnzahl"
        '
        'NumericUpDown_Separator_Zeile_Wert
        '
        Me.NumericUpDown_Separator_Zeile_Wert.Location = New System.Drawing.Point(48, 29)
        Me.NumericUpDown_Separator_Zeile_Wert.Name = "NumericUpDown_Separator_Zeile_Wert"
        Me.NumericUpDown_Separator_Zeile_Wert.Size = New System.Drawing.Size(75, 20)
        Me.NumericUpDown_Separator_Zeile_Wert.TabIndex = 3
        Me.NumericUpDown_Separator_Zeile_Wert.Tag = "SeparatorZeileWert"
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
        'Label_DPI
        '
        Me.Label_DPI.AutoSize = True
        Me.Label_DPI.Location = New System.Drawing.Point(3, 26)
        Me.Label_DPI.Name = "Label_DPI"
        Me.Label_DPI.Size = New System.Drawing.Size(23, 17)
        Me.Label_DPI.TabIndex = 0
        Me.Label_DPI.Text = "DPI"
        Me.Label_DPI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_DPI.UseCompatibleTextRendering = True
        '
        'Label_DIN
        '
        Me.Label_DIN.AutoSize = True
        Me.Label_DIN.Location = New System.Drawing.Point(3, 53)
        Me.Label_DIN.Name = "Label_DIN"
        Me.Label_DIN.Size = New System.Drawing.Size(24, 17)
        Me.Label_DIN.TabIndex = 2
        Me.Label_DIN.Text = "DIN"
        Me.Label_DIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_DIN.UseCompatibleTextRendering = True
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
        Me.Label_Import.Location = New System.Drawing.Point(3, 12)
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
        Me.TextBox_Import.Location = New System.Drawing.Point(46, 12)
        Me.TextBox_Import.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.TextBox_Import.Name = "TextBox_Import"
        Me.TextBox_Import.Size = New System.Drawing.Size(234, 20)
        Me.TextBox_Import.TabIndex = 0
        Me.TextBox_Import.Tag = "Import"
        '
        'Label_Export
        '
        Me.Label_Export.AutoSize = True
        Me.Label_Export.Location = New System.Drawing.Point(3, 56)
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
        Me.TextBox_Export.Location = New System.Drawing.Point(46, 56)
        Me.TextBox_Export.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.TextBox_Export.Name = "TextBox_Export"
        Me.TextBox_Export.Size = New System.Drawing.Size(234, 20)
        Me.TextBox_Export.TabIndex = 1
        Me.TextBox_Export.Tag = "Export"
        '
        'Main_ImageList
        '
        Me.Main_ImageList.ImageStream = CType(resources.GetObject("Main_ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Main_ImageList.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Main_ImageList.Images.SetKeyName(0, "File_Printer.png")
        Me.Main_ImageList.Images.SetKeyName(1, "Import.png")
        Me.Main_ImageList.Images.SetKeyName(2, "ZoomIn.png")
        Me.Main_ImageList.Images.SetKeyName(3, "ZoomOut.png")
        Me.Main_ImageList.Images.SetKeyName(4, "Refresh_Arrow_Green")
        '
        'TableLayoutPanel_Files
        '
        Me.TableLayoutPanel_Files.AutoSize = True
        Me.TableLayoutPanel_Files.ColumnCount = 3
        Me.TableLayoutPanel_Files.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Files.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Files.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Files.Controls.Add(Me.DGV_Search, 0, 6)
        Me.TableLayoutPanel_Files.Controls.Add(Me.Button_Search_Add, 2, 8)
        Me.TableLayoutPanel_Files.Controls.Add(Me.Button_Search_Delete, 2, 6)
        Me.TableLayoutPanel_Files.Controls.Add(Me.Button_Import, 2, 0)
        Me.TableLayoutPanel_Files.Controls.Add(Me.Label_Import, 0, 1)
        Me.TableLayoutPanel_Files.Controls.Add(Me.Button_Export, 2, 3)
        Me.TableLayoutPanel_Files.Controls.Add(Me.TextBox_Import, 1, 1)
        Me.TableLayoutPanel_Files.Controls.Add(Me.Label_Export, 0, 4)
        Me.TableLayoutPanel_Files.Controls.Add(Me.TextBox_Export, 1, 4)
        Me.TableLayoutPanel_Files.Controls.Add(Me.Button_Search_Refresh, 2, 7)
        Me.TableLayoutPanel_Files.Controls.Add(Me.Panel_Daten_CSV, 0, 7)
        Me.TableLayoutPanel_Files.Location = New System.Drawing.Point(21, 21)
        Me.TableLayoutPanel_Files.Name = "TableLayoutPanel_Files"
        Me.TableLayoutPanel_Files.RowCount = 9
        Me.TableLayoutPanel_Files.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Files.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Files.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Files.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Files.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Files.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Files.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Files.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Files.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Files.Size = New System.Drawing.Size(327, 227)
        Me.TableLayoutPanel_Files.TabIndex = 0
        '
        'DGV_Search
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Search.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DGV_Search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Search.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Search.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DGV_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel_Files.SetColumnSpan(Me.DGV_Search, 2)
        Me.DGV_Search.EnableHeadersVisualStyles = False
        Me.DGV_Search.GridColor = System.Drawing.Color.DarkGray
        Me.DGV_Search.Location = New System.Drawing.Point(3, 91)
        Me.DGV_Search.Name = "DGV_Search"
        Me.DGV_Search.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGV_Search.Size = New System.Drawing.Size(185, 29)
        Me.DGV_Search.TabIndex = 0
        '
        'Button_Search_Add
        '
        Me.Button_Search_Add.AutoSize = True
        Me.Button_Search_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Search_Add.ImageKey = "ZoomIn.png"
        Me.Button_Search_Add.ImageList = Me.Main_ImageList
        Me.Button_Search_Add.Location = New System.Drawing.Point(286, 179)
        Me.Button_Search_Add.Name = "Button_Search_Add"
        Me.Button_Search_Add.Size = New System.Drawing.Size(38, 38)
        Me.Button_Search_Add.TabIndex = 47
        Me.Button_Search_Add.UseVisualStyleBackColor = True
        '
        'Button_Search_Delete
        '
        Me.Button_Search_Delete.AutoSize = True
        Me.Button_Search_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Search_Delete.ImageKey = "ZoomOut.png"
        Me.Button_Search_Delete.ImageList = Me.Main_ImageList
        Me.Button_Search_Delete.Location = New System.Drawing.Point(286, 91)
        Me.Button_Search_Delete.Name = "Button_Search_Delete"
        Me.Button_Search_Delete.Size = New System.Drawing.Size(38, 38)
        Me.Button_Search_Delete.TabIndex = 46
        Me.Button_Search_Delete.UseVisualStyleBackColor = True
        '
        'Button_Import
        '
        Me.Button_Import.AutoSize = True
        Me.Button_Import.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Import.ImageKey = "Import.png"
        Me.Button_Import.ImageList = Me.Main_ImageList
        Me.Button_Import.Location = New System.Drawing.Point(286, 3)
        Me.Button_Import.Name = "Button_Import"
        Me.TableLayoutPanel_Files.SetRowSpan(Me.Button_Import, 3)
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
        Me.Button_Export.ImageList = Me.Main_ImageList
        Me.Button_Export.Location = New System.Drawing.Point(286, 47)
        Me.Button_Export.Name = "Button_Export"
        Me.TableLayoutPanel_Files.SetRowSpan(Me.Button_Export, 3)
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
        Me.Button_Search_Refresh.ImageList = Me.Main_ImageList
        Me.Button_Search_Refresh.Location = New System.Drawing.Point(286, 135)
        Me.Button_Search_Refresh.Name = "Button_Search_Refresh"
        Me.Button_Search_Refresh.Size = New System.Drawing.Size(38, 38)
        Me.Button_Search_Refresh.TabIndex = 48
        Me.Button_Search_Refresh.UseVisualStyleBackColor = True
        '
        'Panel_Daten_CSV
        '
        Me.Panel_Daten_CSV.AutoScroll = True
        Me.TableLayoutPanel_Files.SetColumnSpan(Me.Panel_Daten_CSV, 2)
        Me.Panel_Daten_CSV.Controls.Add(Me.DGV_CSV)
        Me.Panel_Daten_CSV.Controls.Add(Me.Main_BindingNavigator_CSV)
        Me.Panel_Daten_CSV.Location = New System.Drawing.Point(3, 135)
        Me.Panel_Daten_CSV.Name = "Panel_Daten_CSV"
        Me.TableLayoutPanel_Files.SetRowSpan(Me.Panel_Daten_CSV, 2)
        Me.Panel_Daten_CSV.Size = New System.Drawing.Size(248, 89)
        Me.Panel_Daten_CSV.TabIndex = 49
        '
        'DGV_CSV
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_CSV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DGV_CSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGV_CSV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DGV_CSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CSV.GridColor = System.Drawing.Color.DarkGray
        Me.DGV_CSV.Location = New System.Drawing.Point(0, 28)
        Me.DGV_CSV.MultiSelect = False
        Me.DGV_CSV.Name = "DGV_CSV"
        Me.DGV_CSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGV_CSV.Size = New System.Drawing.Size(241, 56)
        Me.DGV_CSV.TabIndex = 44
        '
        'Main_BindingNavigator_CSV
        '
        Me.Main_BindingNavigator_CSV.AddNewItem = Nothing
        Me.Main_BindingNavigator_CSV.CountItem = Me.BindingNavigatorCountItem
        Me.Main_BindingNavigator_CSV.DeleteItem = Nothing
        Me.Main_BindingNavigator_CSV.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_BindingNavigator_CSV.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Main_BindingNavigator_CSV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Main_BindingNavigator_CSV.Location = New System.Drawing.Point(0, 0)
        Me.Main_BindingNavigator_CSV.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Main_BindingNavigator_CSV.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Main_BindingNavigator_CSV.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Main_BindingNavigator_CSV.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Main_BindingNavigator_CSV.Name = "Main_BindingNavigator_CSV"
        Me.Main_BindingNavigator_CSV.PositionItem = Me.BindingNavigatorPositionItem
        Me.Main_BindingNavigator_CSV.Size = New System.Drawing.Size(248, 25)
        Me.Main_BindingNavigator_CSV.TabIndex = 45
        Me.Main_BindingNavigator_CSV.Text = "BindingNavigator1"
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
        'TabPage_Files
        '
        Me.TabPage_Files.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_Files.Controls.Add(Me.TableLayoutPanel_Files)
        Me.TabPage_Files.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_Files.Name = "TabPage_Files"
        Me.TabPage_Files.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Files.Size = New System.Drawing.Size(293, 541)
        Me.TabPage_Files.TabIndex = 5
        Me.TabPage_Files.Text = "Daten"
        '
        'Main_TabControl
        '
        Me.Main_TabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.Main_TabControl.Controls.Add(Me.TabPage_Paper)
        Me.Main_TabControl.Controls.Add(Me.TabPage_Card)
        Me.Main_TabControl.Controls.Add(Me.TabPage_Row)
        Me.Main_TabControl.Controls.Add(Me.TabPage_Files)
        Me.Main_TabControl.Controls.Add(Me.TabPage_Table)
        Me.Main_TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main_TabControl.Location = New System.Drawing.Point(0, 0)
        Me.Main_TabControl.Name = "Main_TabControl"
        Me.Main_TabControl.SelectedIndex = 0
        Me.Main_TabControl.Size = New System.Drawing.Size(300, 570)
        Me.Main_TabControl.TabIndex = 6
        '
        'TabPage_Paper
        '
        Me.TabPage_Paper.Controls.Add(Me.TableLayoutPanel_Paper)
        Me.TabPage_Paper.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_Paper.Name = "TabPage_Paper"
        Me.TabPage_Paper.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Paper.Size = New System.Drawing.Size(292, 541)
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
        Me.TableLayoutPanel_Paper.RowCount = 5
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Paper.Size = New System.Drawing.Size(282, 520)
        Me.TableLayoutPanel_Paper.TabIndex = 45
        '
        'GroupBox_Separator_Column
        '
        Me.GroupBox_Separator_Column.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox_Separator_Column.Location = New System.Drawing.Point(3, 298)
        Me.GroupBox_Separator_Column.Name = "GroupBox_Separator_Column"
        Me.GroupBox_Separator_Column.Size = New System.Drawing.Size(179, 96)
        Me.GroupBox_Separator_Column.TabIndex = 29
        Me.GroupBox_Separator_Column.TabStop = False
        Me.GroupBox_Separator_Column.Text = "Separator Zeile"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Separator_Row_Count, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Separator_Row_Value, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown_Separator_Row_Anzahl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown_Separator_Zeile_Wert, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Separator_Row_Wert_Unit, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(164, 62)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label_Separator_Row_Wert_Unit
        '
        Me.Label_Separator_Row_Wert_Unit.AutoSize = True
        Me.Label_Separator_Row_Wert_Unit.Location = New System.Drawing.Point(129, 26)
        Me.Label_Separator_Row_Wert_Unit.Name = "Label_Separator_Row_Wert_Unit"
        Me.Label_Separator_Row_Wert_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Separator_Row_Wert_Unit.TabIndex = 48
        Me.Label_Separator_Row_Wert_Unit.Text = "mm"
        Me.Label_Separator_Row_Wert_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Separator_Row_Wert_Unit.UseCompatibleTextRendering = True
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
        Me.TableLayoutPanel_Shema.Controls.Add(Me.ComboBox_DPI, 1, 1)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_Width, 0, 4)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.TextBox_Shema, 1, 0)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_Height, 0, 3)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_DPI, 0, 1)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_DIN, 0, 2)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.ComboBox_DIN, 1, 2)
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
        'ComboBox_DPI
        '
        Me.ComboBox_DPI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_DPI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_DPI.FormattingEnabled = True
        Me.ComboBox_DPI.Location = New System.Drawing.Point(43, 29)
        Me.ComboBox_DPI.Name = "ComboBox_DPI"
        Me.ComboBox_DPI.Size = New System.Drawing.Size(57, 21)
        Me.ComboBox_DPI.TabIndex = 0
        Me.ComboBox_DPI.Tag = "DPI"
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
        Me.TextBox_Shema.Tag = "String"
        '
        'ComboBox_DIN
        '
        Me.ComboBox_DIN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_DIN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_DIN.DropDownWidth = 200
        Me.ComboBox_DIN.FormattingEnabled = True
        Me.ComboBox_DIN.Location = New System.Drawing.Point(43, 56)
        Me.ComboBox_DIN.Name = "ComboBox_DIN"
        Me.ComboBox_DIN.Size = New System.Drawing.Size(57, 21)
        Me.ComboBox_DIN.TabIndex = 1
        Me.ComboBox_DIN.Tag = "DIN"
        '
        'TabPage_Card
        '
        Me.TabPage_Card.Controls.Add(Me.GroupBox_Card)
        Me.TabPage_Card.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_Card.Name = "TabPage_Card"
        Me.TabPage_Card.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Card.Size = New System.Drawing.Size(293, 541)
        Me.TabPage_Card.TabIndex = 6
        Me.TabPage_Card.Text = "Karte"
        Me.TabPage_Card.UseVisualStyleBackColor = True
        '
        'GroupBox_Card
        '
        Me.GroupBox_Card.Controls.Add(Me.TableLayoutPanel_Card)
        Me.GroupBox_Card.Location = New System.Drawing.Point(8, 19)
        Me.GroupBox_Card.Name = "GroupBox_Card"
        Me.GroupBox_Card.Size = New System.Drawing.Size(195, 216)
        Me.GroupBox_Card.TabIndex = 1
        Me.GroupBox_Card.TabStop = False
        Me.GroupBox_Card.Text = "Rahmen Karte"
        '
        'TableLayoutPanel_Card
        '
        Me.TableLayoutPanel_Card.AutoSize = True
        Me.TableLayoutPanel_Card.ColumnCount = 3
        Me.TableLayoutPanel_Card.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label_Card_Border_Bottom_Unit, 2, 3)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label_Card_Border_Bottom, 0, 3)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label_Card_Border_Top_Unit, 2, 2)
        Me.TableLayoutPanel_Card.Controls.Add(Me.NumericUpDown_Card_Border_Left, 1, 0)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label_Card_Border_Right_Unit, 2, 1)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label_Card_Border_Top, 0, 2)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label_Card_Border_Left_Unit, 2, 0)
        Me.TableLayoutPanel_Card.Controls.Add(Me.NumericUpDown_Card_Border_Right, 1, 1)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label_Card_Border_Right, 0, 1)
        Me.TableLayoutPanel_Card.Controls.Add(Me.NumericUpDown_Card_Border_Top, 1, 2)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label_Card_Border_Left, 0, 0)
        Me.TableLayoutPanel_Card.Controls.Add(Me.NumericUpDown_Card_Border_Bottom, 1, 3)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label15, 0, 4)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label17, 0, 5)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label16, 1, 4)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label18, 1, 5)
        Me.TableLayoutPanel_Card.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel_Card.Name = "TableLayoutPanel_Card"
        Me.TableLayoutPanel_Card.RowCount = 7
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Card.Size = New System.Drawing.Size(168, 178)
        Me.TableLayoutPanel_Card.TabIndex = 0
        '
        'Label_Card_Border_Bottom_Unit
        '
        Me.Label_Card_Border_Bottom_Unit.AutoSize = True
        Me.Label_Card_Border_Bottom_Unit.Location = New System.Drawing.Point(142, 78)
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
        Me.Label_Card_Border_Top_Unit.Location = New System.Drawing.Point(142, 52)
        Me.Label_Card_Border_Top_Unit.Name = "Label_Card_Border_Top_Unit"
        Me.Label_Card_Border_Top_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Card_Border_Top_Unit.TabIndex = 49
        Me.Label_Card_Border_Top_Unit.Text = "mm"
        Me.Label_Card_Border_Top_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Border_Top_Unit.UseCompatibleTextRendering = True
        '
        'NumericUpDown_Card_Border_Left
        '
        Me.NumericUpDown_Card_Border_Left.Location = New System.Drawing.Point(63, 3)
        Me.NumericUpDown_Card_Border_Left.Name = "NumericUpDown_Card_Border_Left"
        Me.NumericUpDown_Card_Border_Left.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_Card_Border_Left.TabIndex = 7
        Me.NumericUpDown_Card_Border_Left.Tag = "Card;Left"
        '
        'Label_Card_Border_Right_Unit
        '
        Me.Label_Card_Border_Right_Unit.AutoSize = True
        Me.Label_Card_Border_Right_Unit.Location = New System.Drawing.Point(142, 26)
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
        Me.Label_Card_Border_Left_Unit.Location = New System.Drawing.Point(142, 0)
        Me.Label_Card_Border_Left_Unit.Name = "Label_Card_Border_Left_Unit"
        Me.Label_Card_Border_Left_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Card_Border_Left_Unit.TabIndex = 47
        Me.Label_Card_Border_Left_Unit.Text = "mm"
        Me.Label_Card_Border_Left_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Card_Border_Left_Unit.UseCompatibleTextRendering = True
        '
        'NumericUpDown_Card_Border_Right
        '
        Me.NumericUpDown_Card_Border_Right.Location = New System.Drawing.Point(63, 29)
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
        Me.NumericUpDown_Card_Border_Top.Location = New System.Drawing.Point(63, 55)
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
        Me.NumericUpDown_Card_Border_Bottom.Location = New System.Drawing.Point(63, 81)
        Me.NumericUpDown_Card_Border_Bottom.Name = "NumericUpDown_Card_Border_Bottom"
        Me.NumericUpDown_Card_Border_Bottom.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_Card_Border_Bottom.TabIndex = 11
        Me.NumericUpDown_Card_Border_Bottom.Tag = "Card;Bottom"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 17)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Font"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.UseCompatibleTextRendering = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 121)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 17)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "FontColor"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label17.UseCompatibleTextRendering = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.TableLayoutPanel_Card.SetColumnSpan(Me.Label16, 2)
        Me.Label16.Location = New System.Drawing.Point(63, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 17)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "FontName"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label16.UseCompatibleTextRendering = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.TableLayoutPanel_Card.SetColumnSpan(Me.Label18, 2)
        Me.Label18.Location = New System.Drawing.Point(63, 121)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 17)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "FontColor"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label18.UseCompatibleTextRendering = True
        '
        'TabPage_Row
        '
        Me.TabPage_Row.Controls.Add(Me.TableLayoutPanel_Row)
        Me.TabPage_Row.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_Row.Name = "TabPage_Row"
        Me.TabPage_Row.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Row.Size = New System.Drawing.Size(293, 541)
        Me.TabPage_Row.TabIndex = 7
        Me.TabPage_Row.Text = "Zeile"
        Me.TabPage_Row.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_Row
        '
        Me.TableLayoutPanel_Row.ColumnCount = 1
        Me.TableLayoutPanel_Row.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Row.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Row.Controls.Add(Me.GroupBox_Row_Border, 0, 0)
        Me.TableLayoutPanel_Row.Controls.Add(Me.GroupBox_Row_Line, 0, 1)
        Me.TableLayoutPanel_Row.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel_Row.Name = "TableLayoutPanel_Row"
        Me.TableLayoutPanel_Row.RowCount = 3
        Me.TableLayoutPanel_Row.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Row.Size = New System.Drawing.Size(265, 435)
        Me.TableLayoutPanel_Row.TabIndex = 5
        '
        'GroupBox_Row_Border
        '
        Me.GroupBox_Row_Border.Controls.Add(Me.TableLayoutPanel_Row_Border)
        Me.GroupBox_Row_Border.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox_Row_Border.Name = "GroupBox_Row_Border"
        Me.GroupBox_Row_Border.Size = New System.Drawing.Size(209, 193)
        Me.GroupBox_Row_Border.TabIndex = 4
        Me.GroupBox_Row_Border.TabStop = False
        Me.GroupBox_Row_Border.Text = "Rahmen"
        '
        'TableLayoutPanel_Row_Border
        '
        Me.TableLayoutPanel_Row_Border.AutoSize = True
        Me.TableLayoutPanel_Row_Border.ColumnCount = 3
        Me.TableLayoutPanel_Row_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Row_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Row_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label4, 2, 3)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label2, 2, 2)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.NumericUpDown_CardRow_Border_Left, 1, 0)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label10, 0, 1)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.NumericUpDown6, 1, 1)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.Label9, 0, 2)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.NumericUpDown5, 1, 2)
        Me.TableLayoutPanel_Row_Border.Controls.Add(Me.NumericUpDown4, 1, 3)
        Me.TableLayoutPanel_Row_Border.Location = New System.Drawing.Point(15, 34)
        Me.TableLayoutPanel_Row_Border.Name = "TableLayoutPanel_Row_Border"
        Me.TableLayoutPanel_Row_Border.RowCount = 4
        Me.TableLayoutPanel_Row_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Border.Size = New System.Drawing.Size(184, 104)
        Me.TableLayoutPanel_Row_Border.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 17)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "mm"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Links"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 17)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "mm"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 17)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "mm"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.UseCompatibleTextRendering = True
        '
        'NumericUpDown_CardRow_Border_Left
        '
        Me.NumericUpDown_CardRow_Border_Left.Location = New System.Drawing.Point(48, 3)
        Me.NumericUpDown_CardRow_Border_Left.Name = "NumericUpDown_CardRow_Border_Left"
        Me.NumericUpDown_CardRow_Border_Left.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_CardRow_Border_Left.TabIndex = 14
        Me.NumericUpDown_CardRow_Border_Left.Tag = "Decimal"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Rechts"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "mm"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Unten"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.UseCompatibleTextRendering = True
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Location = New System.Drawing.Point(48, 29)
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown6.TabIndex = 13
        Me.NumericUpDown6.Tag = "Decimal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Oben"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.UseCompatibleTextRendering = True
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Location = New System.Drawing.Point(48, 55)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown5.TabIndex = 12
        Me.NumericUpDown5.Tag = "Decimal"
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(48, 81)
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown4.TabIndex = 11
        Me.NumericUpDown4.Tag = "Decimal"
        '
        'GroupBox_Row_Line
        '
        Me.GroupBox_Row_Line.Controls.Add(Me.TableLayoutPanel_Row_Line)
        Me.GroupBox_Row_Line.Location = New System.Drawing.Point(3, 202)
        Me.GroupBox_Row_Line.Name = "GroupBox_Row_Line"
        Me.GroupBox_Row_Line.Size = New System.Drawing.Size(247, 223)
        Me.GroupBox_Row_Line.TabIndex = 0
        Me.GroupBox_Row_Line.TabStop = False
        Me.GroupBox_Row_Line.Text = "Lines"
        '
        'TableLayoutPanel_Row_Line
        '
        Me.TableLayoutPanel_Row_Line.AutoSize = True
        Me.TableLayoutPanel_Row_Line.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel_Row_Line.ColumnCount = 2
        Me.TableLayoutPanel_Row_Line.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Row_Line.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Row_Line.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.ListBox1, 0, 0)
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.ComboBox_DataColumn, 1, 4)
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.Label14, 0, 3)
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.CheckBox_AutoFont, 1, 3)
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.Label13, 0, 2)
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.CheckBox_QRCode, 1, 2)
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.Label12, 0, 1)
        Me.TableLayoutPanel_Row_Line.Controls.Add(Me.NumericUpDown3, 1, 1)
        Me.TableLayoutPanel_Row_Line.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel_Row_Line.Name = "TableLayoutPanel_Row_Line"
        Me.TableLayoutPanel_Row_Line.RowCount = 5
        Me.TableLayoutPanel_Row_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Line.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Row_Line.Size = New System.Drawing.Size(223, 199)
        Me.TableLayoutPanel_Row_Line.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "DataColumn"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.UseCompatibleTextRendering = True
        '
        'ListBox1
        '
        Me.TableLayoutPanel_Row_Line.SetColumnSpan(Me.ListBox1, 2)
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(4, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(215, 82)
        Me.ListBox1.TabIndex = 1
        '
        'ComboBox_DataColumn
        '
        Me.ComboBox_DataColumn.FormattingEnabled = True
        Me.ComboBox_DataColumn.Location = New System.Drawing.Point(78, 174)
        Me.ComboBox_DataColumn.Name = "ComboBox_DataColumn"
        Me.ComboBox_DataColumn.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_DataColumn.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 147)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 17)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "AutoFont"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.UseCompatibleTextRendering = True
        '
        'CheckBox_AutoFont
        '
        Me.CheckBox_AutoFont.AutoSize = True
        Me.CheckBox_AutoFont.Location = New System.Drawing.Point(78, 150)
        Me.CheckBox_AutoFont.Name = "CheckBox_AutoFont"
        Me.CheckBox_AutoFont.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox_AutoFont.TabIndex = 25
        Me.CheckBox_AutoFont.Text = "CheckBox2"
        Me.CheckBox_AutoFont.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 17)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "QRCode"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label13.UseCompatibleTextRendering = True
        '
        'CheckBox_QRCode
        '
        Me.CheckBox_QRCode.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_QRCode.AutoSize = True
        Me.CheckBox_QRCode.Location = New System.Drawing.Point(78, 120)
        Me.CheckBox_QRCode.Name = "CheckBox_QRCode"
        Me.CheckBox_QRCode.Size = New System.Drawing.Size(72, 23)
        Me.CheckBox_QRCode.TabIndex = 24
        Me.CheckBox_QRCode.Text = "CheckBox1"
        Me.CheckBox_QRCode.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "LinePos"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.UseCompatibleTextRendering = True
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(78, 93)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown3.TabIndex = 10
        Me.NumericUpDown3.Tag = "Decimal"
        '
        'TabPage_Table
        '
        Me.TabPage_Table.Controls.Add(Me.DGV_Table)
        Me.TabPage_Table.Controls.Add(Me.ListBox_Tabellen)
        Me.TabPage_Table.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_Table.Name = "TabPage_Table"
        Me.TabPage_Table.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Table.Size = New System.Drawing.Size(293, 541)
        Me.TabPage_Table.TabIndex = 4
        Me.TabPage_Table.Text = "Tabellen"
        Me.TabPage_Table.UseVisualStyleBackColor = True
        '
        'DGV_Table
        '
        Me.DGV_Table.AllowUserToAddRows = False
        Me.DGV_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Table.Location = New System.Drawing.Point(130, 23)
        Me.DGV_Table.Name = "DGV_Table"
        Me.DGV_Table.Size = New System.Drawing.Size(125, 134)
        Me.DGV_Table.TabIndex = 0
        '
        'ListBox_Tabellen
        '
        Me.ListBox_Tabellen.BackColor = System.Drawing.SystemColors.Control
        Me.ListBox_Tabellen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_Tabellen.FormattingEnabled = True
        Me.ListBox_Tabellen.Location = New System.Drawing.Point(20, 14)
        Me.ListBox_Tabellen.Name = "ListBox_Tabellen"
        Me.ListBox_Tabellen.Size = New System.Drawing.Size(77, 130)
        Me.ListBox_Tabellen.TabIndex = 2
        '
        'Panel_Paper
        '
        Me.Panel_Paper.AutoScroll = True
        Me.Panel_Paper.Controls.Add(Me.PictureBox_Paper)
        Me.Panel_Paper.Location = New System.Drawing.Point(27, 12)
        Me.Panel_Paper.Name = "Panel_Paper"
        Me.Panel_Paper.Size = New System.Drawing.Size(169, 115)
        Me.Panel_Paper.TabIndex = 0
        '
        'PictureBox_Paper
        '
        Me.PictureBox_Paper.BackColor = System.Drawing.Color.FloralWhite
        Me.PictureBox_Paper.Location = New System.Drawing.Point(22, 16)
        Me.PictureBox_Paper.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox_Paper.Name = "PictureBox_Paper"
        Me.PictureBox_Paper.Size = New System.Drawing.Size(68, 53)
        Me.PictureBox_Paper.TabIndex = 45
        Me.PictureBox_Paper.TabStop = False
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
        Me.ToolStripMenuItem_Extras.Size = New System.Drawing.Size(50, 20)
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
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InhaltToolStripMenuItem, Me.IndexToolStripMenuItem, Me.ToolStripMenuItem_Suchen, Me.ToolStripSeparator06, Me.InfoToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "&Hilfe"
        '
        'InhaltToolStripMenuItem
        '
        Me.InhaltToolStripMenuItem.Name = "InhaltToolStripMenuItem"
        Me.InhaltToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.InhaltToolStripMenuItem.Text = "I&nhalt"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'ToolStripMenuItem_Suchen
        '
        Me.ToolStripMenuItem_Suchen.Name = "ToolStripMenuItem_Suchen"
        Me.ToolStripMenuItem_Suchen.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem_Suchen.Text = "&Suchen"
        '
        'ToolStripSeparator06
        '
        Me.ToolStripSeparator06.Name = "ToolStripSeparator06"
        Me.ToolStripSeparator06.Size = New System.Drawing.Size(110, 6)
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.InfoToolStripMenuItem.Text = "Inf&o..."
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
        Me.ToolStripMenuItem_Datei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_XML_New, Me.ToolStripMenuItem_Öffnen, Me.ToolStripSeparator01, Me.ToolStripMenuItem_Safe, Me.ToolStripMenuItem_XML_SaveAs, Me.ToolStripSeparator02, Me.ToolStripMenuItem_Print, Me.ToolStripMenuItem_Seitenansicht, Me.ToolStripSeparator03, Me.ToolStripMenuItem_Beenden})
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
        'ToolStripMenuItem_Öffnen
        '
        Me.ToolStripMenuItem_Öffnen.Image = CType(resources.GetObject("ToolStripMenuItem_Öffnen.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem_Öffnen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem_Öffnen.Name = "ToolStripMenuItem_Öffnen"
        Me.ToolStripMenuItem_Öffnen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_Öffnen.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem_Öffnen.Text = "Ö&ffnen"
        '
        'ToolStripMenuItem_Safe
        '
        Me.ToolStripMenuItem_Safe.Image = CType(resources.GetObject("ToolStripMenuItem_Safe.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem_Safe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenuItem_Safe.Name = "ToolStripMenuItem_Safe"
        Me.ToolStripMenuItem_Safe.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem_Safe.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem_Safe.Text = "&Speichern"
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
        'Main_MenuStrip
        '
        Me.Main_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Datei, Me.ToolStripMenuItem_Bearbeiten, Me.ToolStripMenuItem_Extras, Me.HilfeToolStripMenuItem})
        Me.Main_MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.Main_MenuStrip.Name = "Main_MenuStrip"
        Me.Main_MenuStrip.Size = New System.Drawing.Size(600, 24)
        Me.Main_MenuStrip.TabIndex = 4
        Me.Main_MenuStrip.Text = "MenuStrip1"
        '
        'Main_OpenFileDialog
        '
        Me.Main_OpenFileDialog.FileName = "OpenFileDialog1"
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
        'Main_StatusStrip
        '
        Me.Main_StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_IsModified, Me.ToolStripStatusLabel_SaveInfo, Me.ToolStripStatusLabel_SaveFile})
        Me.Main_StatusStrip.Location = New System.Drawing.Point(0, 628)
        Me.Main_StatusStrip.Name = "Main_StatusStrip"
        Me.Main_StatusStrip.Size = New System.Drawing.Size(600, 22)
        Me.Main_StatusStrip.SizingGrip = False
        Me.Main_StatusStrip.TabIndex = 5
        Me.Main_StatusStrip.Text = "StatusStrip1"
        '
        'Main_SplitContainer
        '
        Me.Main_SplitContainer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Main_SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Main_SplitContainer.Location = New System.Drawing.Point(12, 43)
        Me.Main_SplitContainer.Name = "Main_SplitContainer"
        '
        'Main_SplitContainer.Panel1
        '
        Me.Main_SplitContainer.Panel1.Controls.Add(Me.Main_TabControl)
        Me.Main_SplitContainer.Panel1MinSize = 240
        '
        'Main_SplitContainer.Panel2
        '
        Me.Main_SplitContainer.Panel2.Controls.Add(Me.Panel_Paper)
        Me.Main_SplitContainer.Size = New System.Drawing.Size(549, 570)
        Me.Main_SplitContainer.SplitterDistance = 300
        Me.Main_SplitContainer.SplitterWidth = 9
        Me.Main_SplitContainer.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = Global.CSVtoQR.My.MySettings.Default.MySize
        Me.Controls.Add(Me.Main_SplitContainer)
        Me.Controls.Add(Me.Main_StatusStrip)
        Me.Controls.Add(Me.Main_MenuStrip)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.CSVtoQR.My.MySettings.Default, "MyLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.CSVtoQR.My.MySettings.Default, "MyFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ClientSize", Global.CSVtoQR.My.MySettings.Default, "MySize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.CSVtoQR.My.MySettings.Default.MyFont
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Location = Global.CSVtoQR.My.MySettings.Default.MyLocation
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TopMost = True
        Me.TableLayoutPanel_Separator.ResumeLayout(False)
        Me.TableLayoutPanel_Separator.PerformLayout()
        CType(Me.NumericUpDown_Separator_Column_Count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Separator_Spalte_Wert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Separator_Row_Anzahl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Separator_Zeile_Wert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Separator_Row.ResumeLayout(False)
        CType(Me.NumericUpDown_Paper_Border_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Paper_Border_Bottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Paper_Border_Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Paper_Border_Right, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel_Files.ResumeLayout(False)
        Me.TableLayoutPanel_Files.PerformLayout()
        CType(Me.DGV_Search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Daten_CSV.ResumeLayout(False)
        Me.Panel_Daten_CSV.PerformLayout()
        CType(Me.DGV_CSV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Main_BindingNavigator_CSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Main_BindingNavigator_CSV.ResumeLayout(False)
        Me.Main_BindingNavigator_CSV.PerformLayout()
        Me.TabPage_Files.ResumeLayout(False)
        Me.TabPage_Files.PerformLayout()
        Me.Main_TabControl.ResumeLayout(False)
        Me.TabPage_Paper.ResumeLayout(False)
        Me.TableLayoutPanel_Paper.ResumeLayout(False)
        Me.TableLayoutPanel_Paper.PerformLayout()
        Me.GroupBox_Separator_Column.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox_Paper_Border.ResumeLayout(False)
        Me.GroupBox_Paper_Border.PerformLayout()
        Me.TableLayoutPanel_Paper_Border.ResumeLayout(False)
        Me.TableLayoutPanel_Paper_Border.PerformLayout()
        Me.GroupBox_Shema.ResumeLayout(False)
        Me.GroupBox_Shema.PerformLayout()
        Me.TableLayoutPanel_Shema.ResumeLayout(False)
        Me.TableLayoutPanel_Shema.PerformLayout()
        Me.TabPage_Card.ResumeLayout(False)
        Me.GroupBox_Card.ResumeLayout(False)
        Me.GroupBox_Card.PerformLayout()
        Me.TableLayoutPanel_Card.ResumeLayout(False)
        Me.TableLayoutPanel_Card.PerformLayout()
        CType(Me.NumericUpDown_Card_Border_Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Card_Border_Right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Card_Border_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Card_Border_Bottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Row.ResumeLayout(False)
        Me.TableLayoutPanel_Row.ResumeLayout(False)
        Me.GroupBox_Row_Border.ResumeLayout(False)
        Me.GroupBox_Row_Border.PerformLayout()
        Me.TableLayoutPanel_Row_Border.ResumeLayout(False)
        Me.TableLayoutPanel_Row_Border.PerformLayout()
        CType(Me.NumericUpDown_CardRow_Border_Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Row_Line.ResumeLayout(False)
        Me.GroupBox_Row_Line.PerformLayout()
        Me.TableLayoutPanel_Row_Line.ResumeLayout(False)
        Me.TableLayoutPanel_Row_Line.PerformLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Table.ResumeLayout(False)
        CType(Me.DGV_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Paper.ResumeLayout(False)
        CType(Me.PictureBox_Paper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Main_MenuStrip.ResumeLayout(False)
        Me.Main_MenuStrip.PerformLayout()
        Me.Main_StatusStrip.ResumeLayout(False)
        Me.Main_StatusStrip.PerformLayout()
        CType(Me.Main_BindingSource_CSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Main_SplitContainer.Panel1.ResumeLayout(False)
        Me.Main_SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.Main_SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Main_SplitContainer.ResumeLayout(False)
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
    Friend WithEvents Label_DPI As Label
    Friend WithEvents Label_DIN As Label
    Friend WithEvents ComboBox_DIN As ComboBox
    Friend WithEvents Label_Paper_Height_Unit As Label
    Friend WithEvents Label_Paper_Width_Unit As Label
    Friend WithEvents Label_Paper_Border_Left As Label
    Friend WithEvents Label_Paper_Border_Bottom As Label
    Friend WithEvents Label_Paper_Border_Top As Label
    Friend WithEvents Label_Paper_Border_Right As Label
    Friend WithEvents Main_FontDialog As FontDialog
    Friend WithEvents Label_Import As Label
    Friend WithEvents TextBox_Import As TextBox
    Friend WithEvents Label_Export As Label
    Friend WithEvents TextBox_Export As TextBox
    Friend WithEvents Button_Import As Button
    Friend WithEvents Main_ImageList As ImageList
    Friend WithEvents Button_Export As Button
    Friend WithEvents TableLayoutPanel_Files As TableLayoutPanel
    Friend WithEvents Button_Search_Add As Button
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents Main_BindingNavigator_CSV As BindingNavigator
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents Button_Search_Delete As Button
    Friend WithEvents DGV_CSV As DataGridView
    Friend WithEvents DGV_Search As DataGridView
    Friend WithEvents TabPage_Files As TabPage
    Friend WithEvents Main_TabControl As TabControl
    Friend WithEvents TabPage_Paper As TabPage
    Friend WithEvents Panel_Paper As Panel
    Friend WithEvents PictureBox_Paper As PictureBox
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
    Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InhaltToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Suchen As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator06 As ToolStripSeparator
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Rückgängig As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Beenden As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator03 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem_Seitenansicht As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Print As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator02 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem_XML_SaveAs As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Safe As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator01 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem_Öffnen As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_XML_New As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Datei As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Bearbeiten As ToolStripMenuItem
    Friend WithEvents Main_MenuStrip As MenuStrip
    Friend WithEvents Main_BindingSource_CSV As BindingSource
    Friend WithEvents Main_SaveFileDialog As SaveFileDialog
    Friend WithEvents Main_OpenFileDialog As OpenFileDialog
    Friend WithEvents ToolStripStatusLabel_SaveFile As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_SaveInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_IsModified As ToolStripStatusLabel
    Friend WithEvents Main_StatusStrip As StatusStrip
    Friend WithEvents NumericUpDown_Paper_Border_Left As NumericUpDown
    Friend WithEvents NumericUpDown_Paper_Border_Top As NumericUpDown
    Friend WithEvents NumericUpDown_Paper_Border_Right As NumericUpDown
    Friend WithEvents NumericUpDown_Separator_Column_Count As NumericUpDown
    Friend WithEvents NumericUpDown_Separator_Row_Anzahl As NumericUpDown
    Friend WithEvents NumericUpDown_Paper_Border_Bottom As NumericUpDown
    Friend WithEvents NumericUpDown_Separator_Spalte_Wert As NumericUpDown
    Friend WithEvents NumericUpDown_Separator_Zeile_Wert As NumericUpDown
    Friend WithEvents ComboBox_DPI As ComboBox
    Friend WithEvents Label_Paper_Width_Value As Label
    Friend WithEvents Label_Paper_Height_Value As Label
    Friend WithEvents TableLayoutPanel_Paper As TableLayoutPanel
    Friend WithEvents Button_Search_Refresh As Button
    Friend WithEvents Panel_Daten_CSV As Panel
    Friend WithEvents TabPage_Card As TabPage
    Friend WithEvents TableLayoutPanel_Card As TableLayoutPanel
    Friend WithEvents NumericUpDown_Card_Border_Left As NumericUpDown
    Friend WithEvents Label_Card_Border_Bottom As Label
    Friend WithEvents Label_Card_Border_Top As Label
    Friend WithEvents Label_Card_Border_Right As Label
    Friend WithEvents Label_Card_Border_Left As Label
    Friend WithEvents NumericUpDown_Card_Border_Bottom As NumericUpDown
    Friend WithEvents NumericUpDown_Card_Border_Top As NumericUpDown
    Friend WithEvents NumericUpDown_Card_Border_Right As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents NumericUpDown6 As NumericUpDown
    Friend WithEvents NumericUpDown_CardRow_Border_Left As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CheckBox_AutoFont As CheckBox
    Friend WithEvents CheckBox_QRCode As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox_DataColumn As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label_Paper_Border_Bottom_Unit As Label
    Friend WithEvents Label_Paper_Border_Top_Unit As Label
    Friend WithEvents Label_Paper_Border_Right_Unit As Label
    Friend WithEvents Label_Paper_Border_Left_Unit As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TableLayoutPanel_Paper_Border As TableLayoutPanel
    Friend WithEvents GroupBox_Paper_Border As GroupBox
    Friend WithEvents TabPage_Row As TabPage
    Friend WithEvents Main_SplitContainer As SplitContainer
    Friend WithEvents GroupBox_Row_Border As GroupBox
    Friend WithEvents TableLayoutPanel_Row_Border As TableLayoutPanel
    Friend WithEvents GroupBox_Row_Line As GroupBox
    Friend WithEvents TableLayoutPanel_Row As TableLayoutPanel
    Friend WithEvents TableLayoutPanel_Row_Line As TableLayoutPanel
    Friend WithEvents GroupBox_Card As GroupBox
    Friend WithEvents Label_Separator_Column_Count As Label
    Friend WithEvents Label_Separator_Column_Value As Label
    Friend WithEvents Label_Separator_Column_Value_Unit As Label
    Friend WithEvents Label_Separator_Row_Wert_Unit As Label
    Friend WithEvents GroupBox_Separator_Column As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label_Card_Border_Bottom_Unit As Label
    Friend WithEvents Label_Card_Border_Top_Unit As Label
    Friend WithEvents Label_Card_Border_Right_Unit As Label
    Friend WithEvents Label_Card_Border_Left_Unit As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
