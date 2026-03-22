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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label_Separator_Zeile = New System.Windows.Forms.Label()
        Me.Label_Separator_Anzahl = New System.Windows.Forms.Label()
        Me.Label_Separator_Wert = New System.Windows.Forms.Label()
        Me.TableLayoutPanel_Separator = New System.Windows.Forms.TableLayoutPanel()
        Me.NUD_Separator_Zeile_Anzahl = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Separator_Spalte_Anzahl = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Separator_Spalte_Wert = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Separator_Zeile_Wert = New System.Windows.Forms.NumericUpDown()
        Me.Label_Separator_Spalte = New System.Windows.Forms.Label()
        Me.GroupBox_Separator = New System.Windows.Forms.GroupBox()
        Me.Label_Left = New System.Windows.Forms.Label()
        Me.Label_Bottom = New System.Windows.Forms.Label()
        Me.Label_Top = New System.Windows.Forms.Label()
        Me.Label_Right = New System.Windows.Forms.Label()
        Me.Label_Paper_Width = New System.Windows.Forms.Label()
        Me.Label_Paper_Height = New System.Windows.Forms.Label()
        Me.Label_DPI = New System.Windows.Forms.Label()
        Me.Label_DIN = New System.Windows.Forms.Label()
        Me.NUD_Paper_Border_Top = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Paper_Border_Bottom = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Paper_Border_Left = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Paper_Border_Right = New System.Windows.Forms.NumericUpDown()
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
        Me.GroupBox_Shema = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Shema = New System.Windows.Forms.TableLayoutPanel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label_Paper_Einheit_Width = New System.Windows.Forms.Label()
        Me.Label_Paper_Einheit_Height = New System.Windows.Forms.Label()
        Me.Label_Paper_Value_Width = New System.Windows.Forms.Label()
        Me.Label_Shema = New System.Windows.Forms.Label()
        Me.Label_Paper_Value_Height = New System.Windows.Forms.Label()
        Me.CB_DPI = New System.Windows.Forms.ComboBox()
        Me.TextBox_Shema = New System.Windows.Forms.TextBox()
        Me.CB_DIN = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel_Paper = New System.Windows.Forms.Panel()
        Me.PictureBox_Paper = New System.Windows.Forms.PictureBox()
        Me.TabPage_Table = New System.Windows.Forms.TabPage()
        Me.DGV_Table = New System.Windows.Forms.DataGridView()
        Me.ListBox_Tabellen = New System.Windows.Forms.ListBox()
        Me.TabPage_Card = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel_Card = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NUD_CardBorderLeft = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NUD_CardBorderRight = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NUD_CardBorderTop = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NUD_CardBorderBottom = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.OptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_Font = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnpassenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlleauswählenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.WiederholenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InhaltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RückgängigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMI_XML_SaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_XML_New = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_Safe = New System.Windows.Forms.ToolStripMenuItem()
        Me.DruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeitenansichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Main_MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Main_SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Main_OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TSSL_SaveFile = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_SaveInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_IsModified = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Main_StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Main_BindingSource_CSV = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel_Paper_Border = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox_Paper_Border = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Separator.SuspendLayout()
        CType(Me.NUD_Separator_Zeile_Anzahl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Separator_Spalte_Anzahl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Separator_Spalte_Wert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Separator_Zeile_Wert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Separator.SuspendLayout()
        CType(Me.NUD_Paper_Border_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Paper_Border_Bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Paper_Border_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Paper_Border_Right, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox_Shema.SuspendLayout()
        Me.TableLayoutPanel_Shema.SuspendLayout()
        Me.Panel_Paper.SuspendLayout()
        CType(Me.PictureBox_Paper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Table.SuspendLayout()
        CType(Me.DGV_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Card.SuspendLayout()
        Me.TableLayoutPanel_Card.SuspendLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_CardBorderLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_CardBorderRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_CardBorderTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_CardBorderBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Main_MenuStrip.SuspendLayout()
        Me.Main_StatusStrip.SuspendLayout()
        CType(Me.Main_BindingSource_CSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel_Paper_Border.SuspendLayout()
        Me.GroupBox_Paper_Border.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Separator_Zeile
        '
        Me.Label_Separator_Zeile.AutoSize = True
        Me.Label_Separator_Zeile.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Separator_Zeile.Location = New System.Drawing.Point(3, 43)
        Me.Label_Separator_Zeile.Name = "Label_Separator_Zeile"
        Me.Label_Separator_Zeile.Size = New System.Drawing.Size(36, 17)
        Me.Label_Separator_Zeile.TabIndex = 2
        Me.Label_Separator_Zeile.Text = "Zeile"
        Me.Label_Separator_Zeile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Separator_Zeile.UseCompatibleTextRendering = True
        '
        'Label_Separator_Anzahl
        '
        Me.Label_Separator_Anzahl.AutoSize = True
        Me.Label_Separator_Anzahl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Separator_Anzahl.Location = New System.Drawing.Point(45, 0)
        Me.Label_Separator_Anzahl.Name = "Label_Separator_Anzahl"
        Me.Label_Separator_Anzahl.Size = New System.Drawing.Size(74, 17)
        Me.Label_Separator_Anzahl.TabIndex = 0
        Me.Label_Separator_Anzahl.Text = "Anzahl"
        Me.Label_Separator_Anzahl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Separator_Anzahl.UseCompatibleTextRendering = True
        '
        'Label_Separator_Wert
        '
        Me.Label_Separator_Wert.AutoSize = True
        Me.Label_Separator_Wert.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Separator_Wert.Location = New System.Drawing.Point(125, 0)
        Me.Label_Separator_Wert.Name = "Label_Separator_Wert"
        Me.Label_Separator_Wert.Size = New System.Drawing.Size(75, 17)
        Me.Label_Separator_Wert.TabIndex = 1
        Me.Label_Separator_Wert.Text = "Wert"
        Me.Label_Separator_Wert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Separator_Wert.UseCompatibleTextRendering = True
        '
        'TableLayoutPanel_Separator
        '
        Me.TableLayoutPanel_Separator.AutoSize = True
        Me.TableLayoutPanel_Separator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel_Separator.ColumnCount = 3
        Me.TableLayoutPanel_Separator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Separator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_Separator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_Separator.Controls.Add(Me.NUD_Separator_Zeile_Anzahl, 1, 2)
        Me.TableLayoutPanel_Separator.Controls.Add(Me.NUD_Separator_Spalte_Anzahl, 1, 1)
        Me.TableLayoutPanel_Separator.Controls.Add(Me.Label_Separator_Zeile, 0, 2)
        Me.TableLayoutPanel_Separator.Controls.Add(Me.Label_Separator_Anzahl, 1, 0)
        Me.TableLayoutPanel_Separator.Controls.Add(Me.NUD_Separator_Spalte_Wert, 2, 1)
        Me.TableLayoutPanel_Separator.Controls.Add(Me.NUD_Separator_Zeile_Wert, 2, 2)
        Me.TableLayoutPanel_Separator.Controls.Add(Me.Label_Separator_Wert, 2, 0)
        Me.TableLayoutPanel_Separator.Controls.Add(Me.Label_Separator_Spalte, 0, 1)
        Me.TableLayoutPanel_Separator.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel_Separator.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel_Separator.Name = "TableLayoutPanel_Separator"
        Me.TableLayoutPanel_Separator.RowCount = 3
        Me.TableLayoutPanel_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Separator.Size = New System.Drawing.Size(203, 69)
        Me.TableLayoutPanel_Separator.TabIndex = 0
        Me.TableLayoutPanel_Separator.Tag = "Decimal"
        '
        'NUD_Separator_Zeile_Anzahl
        '
        Me.NUD_Separator_Zeile_Anzahl.Location = New System.Drawing.Point(45, 46)
        Me.NUD_Separator_Zeile_Anzahl.Name = "NUD_Separator_Zeile_Anzahl"
        Me.NUD_Separator_Zeile_Anzahl.Size = New System.Drawing.Size(74, 20)
        Me.NUD_Separator_Zeile_Anzahl.TabIndex = 2
        Me.NUD_Separator_Zeile_Anzahl.Tag = "SeparatorZeileAnzahl"
        '
        'NUD_Separator_Spalte_Anzahl
        '
        Me.NUD_Separator_Spalte_Anzahl.Location = New System.Drawing.Point(45, 20)
        Me.NUD_Separator_Spalte_Anzahl.Name = "NUD_Separator_Spalte_Anzahl"
        Me.NUD_Separator_Spalte_Anzahl.Size = New System.Drawing.Size(74, 20)
        Me.NUD_Separator_Spalte_Anzahl.TabIndex = 0
        Me.NUD_Separator_Spalte_Anzahl.Tag = "SeparatorSpalteAnzahl"
        '
        'NUD_Separator_Spalte_Wert
        '
        Me.NUD_Separator_Spalte_Wert.Location = New System.Drawing.Point(125, 20)
        Me.NUD_Separator_Spalte_Wert.Name = "NUD_Separator_Spalte_Wert"
        Me.NUD_Separator_Spalte_Wert.Size = New System.Drawing.Size(75, 20)
        Me.NUD_Separator_Spalte_Wert.TabIndex = 1
        Me.NUD_Separator_Spalte_Wert.Tag = "SeparatorSpalteWert"
        '
        'NUD_Separator_Zeile_Wert
        '
        Me.NUD_Separator_Zeile_Wert.Location = New System.Drawing.Point(125, 46)
        Me.NUD_Separator_Zeile_Wert.Name = "NUD_Separator_Zeile_Wert"
        Me.NUD_Separator_Zeile_Wert.Size = New System.Drawing.Size(75, 20)
        Me.NUD_Separator_Zeile_Wert.TabIndex = 3
        Me.NUD_Separator_Zeile_Wert.Tag = "SeparatorZeileWert"
        '
        'Label_Separator_Spalte
        '
        Me.Label_Separator_Spalte.AutoSize = True
        Me.Label_Separator_Spalte.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Separator_Spalte.Location = New System.Drawing.Point(3, 17)
        Me.Label_Separator_Spalte.Name = "Label_Separator_Spalte"
        Me.Label_Separator_Spalte.Size = New System.Drawing.Size(36, 17)
        Me.Label_Separator_Spalte.TabIndex = 5
        Me.Label_Separator_Spalte.Text = "Spalte"
        Me.Label_Separator_Spalte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Separator_Spalte.UseCompatibleTextRendering = True
        '
        'GroupBox_Separator
        '
        Me.GroupBox_Separator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox_Separator.Controls.Add(Me.TableLayoutPanel_Separator)
        Me.GroupBox_Separator.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox_Separator.Location = New System.Drawing.Point(265, 3)
        Me.GroupBox_Separator.Name = "GroupBox_Separator"
        Me.GroupBox_Separator.Size = New System.Drawing.Size(209, 91)
        Me.GroupBox_Separator.TabIndex = 3
        Me.GroupBox_Separator.TabStop = False
        Me.GroupBox_Separator.Text = "Separatoren"
        Me.GroupBox_Separator.UseCompatibleTextRendering = True
        '
        'Label_Left
        '
        Me.Label_Left.AutoSize = True
        Me.Label_Left.Location = New System.Drawing.Point(3, 0)
        Me.Label_Left.Name = "Label_Left"
        Me.Label_Left.Size = New System.Drawing.Size(31, 17)
        Me.Label_Left.TabIndex = 1
        Me.Label_Left.Text = "Links"
        Me.Label_Left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Left.UseCompatibleTextRendering = True
        '
        'Label_Bottom
        '
        Me.Label_Bottom.AutoSize = True
        Me.Label_Bottom.Location = New System.Drawing.Point(3, 78)
        Me.Label_Bottom.Name = "Label_Bottom"
        Me.Label_Bottom.Size = New System.Drawing.Size(34, 17)
        Me.Label_Bottom.TabIndex = 7
        Me.Label_Bottom.Text = "Unten"
        Me.Label_Bottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Bottom.UseCompatibleTextRendering = True
        '
        'Label_Top
        '
        Me.Label_Top.AutoSize = True
        Me.Label_Top.Location = New System.Drawing.Point(3, 52)
        Me.Label_Top.Name = "Label_Top"
        Me.Label_Top.Size = New System.Drawing.Size(32, 17)
        Me.Label_Top.TabIndex = 5
        Me.Label_Top.Text = "Oben"
        Me.Label_Top.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Top.UseCompatibleTextRendering = True
        '
        'Label_Right
        '
        Me.Label_Right.AutoSize = True
        Me.Label_Right.Location = New System.Drawing.Point(3, 26)
        Me.Label_Right.Name = "Label_Right"
        Me.Label_Right.Size = New System.Drawing.Size(39, 17)
        Me.Label_Right.TabIndex = 3
        Me.Label_Right.Text = "Rechts"
        Me.Label_Right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Right.UseCompatibleTextRendering = True
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
        'NUD_Paper_Border_Top
        '
        Me.NUD_Paper_Border_Top.Location = New System.Drawing.Point(81, 55)
        Me.NUD_Paper_Border_Top.Name = "NUD_Paper_Border_Top"
        Me.NUD_Paper_Border_Top.Size = New System.Drawing.Size(73, 20)
        Me.NUD_Paper_Border_Top.TabIndex = 3
        Me.NUD_Paper_Border_Top.Tag = "BorderTop"
        '
        'NUD_Paper_Border_Bottom
        '
        Me.NUD_Paper_Border_Bottom.Location = New System.Drawing.Point(81, 81)
        Me.NUD_Paper_Border_Bottom.Name = "NUD_Paper_Border_Bottom"
        Me.NUD_Paper_Border_Bottom.Size = New System.Drawing.Size(73, 20)
        Me.NUD_Paper_Border_Bottom.TabIndex = 4
        Me.NUD_Paper_Border_Bottom.Tag = "BorderBottom"
        '
        'NUD_Paper_Border_Left
        '
        Me.NUD_Paper_Border_Left.Location = New System.Drawing.Point(81, 3)
        Me.NUD_Paper_Border_Left.Name = "NUD_Paper_Border_Left"
        Me.NUD_Paper_Border_Left.Size = New System.Drawing.Size(73, 20)
        Me.NUD_Paper_Border_Left.TabIndex = 1
        Me.NUD_Paper_Border_Left.Tag = "BorderLeft"
        '
        'NUD_Paper_Border_Right
        '
        Me.NUD_Paper_Border_Right.Location = New System.Drawing.Point(81, 29)
        Me.NUD_Paper_Border_Right.Name = "NUD_Paper_Border_Right"
        Me.NUD_Paper_Border_Right.Size = New System.Drawing.Size(73, 20)
        Me.NUD_Paper_Border_Right.TabIndex = 2
        Me.NUD_Paper_Border_Right.Tag = "BorderRight"
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
        Me.TextBox_Import.Size = New System.Drawing.Size(445, 20)
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
        Me.TextBox_Export.Size = New System.Drawing.Size(445, 20)
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
        Me.TableLayoutPanel_Files.Size = New System.Drawing.Size(563, 389)
        Me.TableLayoutPanel_Files.TabIndex = 0
        '
        'DGV_Search
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Search.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
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
        Me.Button_Search_Add.Location = New System.Drawing.Point(522, 179)
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
        Me.Button_Search_Delete.Location = New System.Drawing.Point(522, 91)
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
        Me.Button_Import.Location = New System.Drawing.Point(522, 3)
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
        Me.Button_Export.Location = New System.Drawing.Point(522, 47)
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
        Me.Button_Search_Refresh.Location = New System.Drawing.Point(522, 135)
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
        Me.Panel_Daten_CSV.Size = New System.Drawing.Size(277, 158)
        Me.Panel_Daten_CSV.TabIndex = 49
        '
        'DGV_CSV
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_CSV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_CSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_CSV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DGV_CSV.GridColor = System.Drawing.Color.DarkGray
        Me.DGV_CSV.Location = New System.Drawing.Point(20, 44)
        Me.DGV_CSV.MultiSelect = False
        Me.DGV_CSV.Name = "DGV_CSV"
        Me.DGV_CSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGV_CSV.Size = New System.Drawing.Size(211, 93)
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
        Me.Main_BindingNavigator_CSV.Size = New System.Drawing.Size(277, 25)
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
        Me.TabPage_Files.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Files.Name = "TabPage_Files"
        Me.TabPage_Files.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Files.Size = New System.Drawing.Size(592, 337)
        Me.TabPage_Files.TabIndex = 5
        Me.TabPage_Files.Text = "Daten"
        '
        'Main_TabControl
        '
        Me.Main_TabControl.Controls.Add(Me.TabPage_Paper)
        Me.Main_TabControl.Controls.Add(Me.TabPage_Files)
        Me.Main_TabControl.Controls.Add(Me.TabPage_Table)
        Me.Main_TabControl.Controls.Add(Me.TabPage_Card)
        Me.Main_TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main_TabControl.Location = New System.Drawing.Point(0, 24)
        Me.Main_TabControl.Name = "Main_TabControl"
        Me.Main_TabControl.SelectedIndex = 0
        Me.Main_TabControl.Size = New System.Drawing.Size(834, 491)
        Me.Main_TabControl.TabIndex = 6
        '
        'TabPage_Paper
        '
        Me.TabPage_Paper.Controls.Add(Me.TableLayoutPanel_Paper)
        Me.TabPage_Paper.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Paper.Name = "TabPage_Paper"
        Me.TabPage_Paper.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Paper.Size = New System.Drawing.Size(826, 465)
        Me.TabPage_Paper.TabIndex = 0
        Me.TabPage_Paper.Text = "Papier"
        Me.TabPage_Paper.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_Paper
        '
        Me.TableLayoutPanel_Paper.ColumnCount = 3
        Me.TableLayoutPanel_Paper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Paper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Paper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Paper.Controls.Add(Me.GroupBox_Paper_Border, 0, 2)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.GroupBox_Separator, 1, 0)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.GroupBox_Shema, 0, 0)
        Me.TableLayoutPanel_Paper.Controls.Add(Me.Panel_Paper, 1, 1)
        Me.TableLayoutPanel_Paper.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel_Paper.Name = "TableLayoutPanel_Paper"
        Me.TableLayoutPanel_Paper.RowCount = 4
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Paper.Size = New System.Drawing.Size(484, 314)
        Me.TableLayoutPanel_Paper.TabIndex = 45
        '
        'GroupBox_Shema
        '
        Me.GroupBox_Shema.AutoSize = True
        Me.GroupBox_Shema.Controls.Add(Me.TableLayoutPanel_Shema)
        Me.GroupBox_Shema.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox_Shema.Name = "GroupBox_Shema"
        Me.TableLayoutPanel_Paper.SetRowSpan(Me.GroupBox_Shema, 2)
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
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_Einheit_Width, 2, 4)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_Einheit_Height, 2, 3)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_Value_Width, 1, 4)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Shema, 0, 0)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_Value_Height, 1, 3)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.CB_DPI, 1, 1)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_Width, 0, 4)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.TextBox_Shema, 1, 0)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_Paper_Height, 0, 3)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_DPI, 0, 1)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.Label_DIN, 0, 2)
        Me.TableLayoutPanel_Shema.Controls.Add(Me.CB_DIN, 1, 2)
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
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(160, 78)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(23, 17)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "mm"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label21.UseCompatibleTextRendering = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(160, 52)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(23, 17)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "mm"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label20.UseCompatibleTextRendering = True
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(160, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 17)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "mm"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label19.UseCompatibleTextRendering = True
        '
        'Label_Paper_Einheit_Width
        '
        Me.Label_Paper_Einheit_Width.AutoSize = True
        Me.Label_Paper_Einheit_Width.Location = New System.Drawing.Point(106, 97)
        Me.Label_Paper_Einheit_Width.Name = "Label_Paper_Einheit_Width"
        Me.Label_Paper_Einheit_Width.Size = New System.Drawing.Size(23, 17)
        Me.Label_Paper_Einheit_Width.TabIndex = 9
        Me.Label_Paper_Einheit_Width.Text = "mm"
        Me.Label_Paper_Einheit_Width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Einheit_Width.UseCompatibleTextRendering = True
        '
        'Label_Paper_Einheit_Height
        '
        Me.Label_Paper_Einheit_Height.AutoSize = True
        Me.Label_Paper_Einheit_Height.Location = New System.Drawing.Point(106, 80)
        Me.Label_Paper_Einheit_Height.Name = "Label_Paper_Einheit_Height"
        Me.Label_Paper_Einheit_Height.Size = New System.Drawing.Size(23, 17)
        Me.Label_Paper_Einheit_Height.TabIndex = 8
        Me.Label_Paper_Einheit_Height.Text = "mm"
        Me.Label_Paper_Einheit_Height.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Paper_Einheit_Height.UseCompatibleTextRendering = True
        '
        'Label_Paper_Value_Width
        '
        Me.Label_Paper_Value_Width.AutoSize = True
        Me.Label_Paper_Value_Width.Location = New System.Drawing.Point(43, 97)
        Me.Label_Paper_Value_Width.Name = "Label_Paper_Value_Width"
        Me.Label_Paper_Value_Width.Size = New System.Drawing.Size(25, 13)
        Me.Label_Paper_Value_Width.TabIndex = 47
        Me.Label_Paper_Value_Width.Text = "PW"
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
        'Label_Paper_Value_Height
        '
        Me.Label_Paper_Value_Height.AutoSize = True
        Me.Label_Paper_Value_Height.Location = New System.Drawing.Point(43, 80)
        Me.Label_Paper_Value_Height.Name = "Label_Paper_Value_Height"
        Me.Label_Paper_Value_Height.Size = New System.Drawing.Size(22, 13)
        Me.Label_Paper_Value_Height.TabIndex = 46
        Me.Label_Paper_Value_Height.Text = "PH"
        '
        'CB_DPI
        '
        Me.CB_DPI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_DPI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_DPI.FormattingEnabled = True
        Me.CB_DPI.Location = New System.Drawing.Point(43, 29)
        Me.CB_DPI.Name = "CB_DPI"
        Me.CB_DPI.Size = New System.Drawing.Size(57, 21)
        Me.CB_DPI.TabIndex = 0
        Me.CB_DPI.Tag = "DPI"
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
        'CB_DIN
        '
        Me.CB_DIN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_DIN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_DIN.DropDownWidth = 200
        Me.CB_DIN.FormattingEnabled = True
        Me.CB_DIN.Location = New System.Drawing.Point(43, 56)
        Me.CB_DIN.Name = "CB_DIN"
        Me.CB_DIN.Size = New System.Drawing.Size(57, 21)
        Me.CB_DIN.TabIndex = 1
        Me.CB_DIN.Tag = "DIN"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(160, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(23, 17)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "mm"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.UseCompatibleTextRendering = True
        '
        'Panel_Paper
        '
        Me.Panel_Paper.AutoScroll = True
        Me.Panel_Paper.Controls.Add(Me.PictureBox_Paper)
        Me.Panel_Paper.Location = New System.Drawing.Point(265, 100)
        Me.Panel_Paper.Name = "Panel_Paper"
        Me.TableLayoutPanel_Paper.SetRowSpan(Me.Panel_Paper, 2)
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
        'TabPage_Table
        '
        Me.TabPage_Table.Controls.Add(Me.DGV_Table)
        Me.TabPage_Table.Controls.Add(Me.ListBox_Tabellen)
        Me.TabPage_Table.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Table.Name = "TabPage_Table"
        Me.TabPage_Table.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Table.Size = New System.Drawing.Size(592, 337)
        Me.TabPage_Table.TabIndex = 4
        Me.TabPage_Table.Text = "Tabellen"
        Me.TabPage_Table.UseVisualStyleBackColor = True
        '
        'DGV_Table
        '
        Me.DGV_Table.AllowUserToAddRows = False
        Me.DGV_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Table.Location = New System.Drawing.Point(219, 35)
        Me.DGV_Table.Name = "DGV_Table"
        Me.DGV_Table.Size = New System.Drawing.Size(125, 134)
        Me.DGV_Table.TabIndex = 0
        '
        'ListBox_Tabellen
        '
        Me.ListBox_Tabellen.FormattingEnabled = True
        Me.ListBox_Tabellen.Location = New System.Drawing.Point(19, 20)
        Me.ListBox_Tabellen.Name = "ListBox_Tabellen"
        Me.ListBox_Tabellen.Size = New System.Drawing.Size(147, 134)
        Me.ListBox_Tabellen.TabIndex = 2
        '
        'TabPage_Card
        '
        Me.TabPage_Card.Controls.Add(Me.TableLayoutPanel_Card)
        Me.TabPage_Card.Controls.Add(Me.ListBox1)
        Me.TabPage_Card.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Card.Name = "TabPage_Card"
        Me.TabPage_Card.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Card.Size = New System.Drawing.Size(592, 337)
        Me.TabPage_Card.TabIndex = 6
        Me.TabPage_Card.Text = "Karte"
        Me.TabPage_Card.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_Card
        '
        Me.TableLayoutPanel_Card.ColumnCount = 3
        Me.TableLayoutPanel_Card.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel_Card.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel_Card.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label17, 0, 15)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label13, 0, 11)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label6, 0, 13)
        Me.TableLayoutPanel_Card.Controls.Add(Me.CheckBox2, 1, 12)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label12, 0, 10)
        Me.TableLayoutPanel_Card.Controls.Add(Me.NumericUpDown3, 1, 10)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label8, 0, 9)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label9, 0, 8)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label10, 0, 7)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label11, 0, 6)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label2, 0, 4)
        Me.TableLayoutPanel_Card.Controls.Add(Me.NUD_CardBorderLeft, 1, 1)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel_Card.Controls.Add(Me.NUD_CardBorderRight, 1, 2)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel_Card.Controls.Add(Me.NUD_CardBorderTop, 1, 3)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel_Card.Controls.Add(Me.NUD_CardBorderBottom, 1, 4)
        Me.TableLayoutPanel_Card.Controls.Add(Me.NumericUpDown7, 1, 6)
        Me.TableLayoutPanel_Card.Controls.Add(Me.NumericUpDown6, 1, 7)
        Me.TableLayoutPanel_Card.Controls.Add(Me.NumericUpDown5, 1, 8)
        Me.TableLayoutPanel_Card.Controls.Add(Me.NumericUpDown4, 1, 9)
        Me.TableLayoutPanel_Card.Controls.Add(Me.CheckBox1, 1, 11)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label14, 0, 12)
        Me.TableLayoutPanel_Card.Controls.Add(Me.ComboBox1, 1, 13)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label15, 0, 14)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label16, 1, 14)
        Me.TableLayoutPanel_Card.Controls.Add(Me.Label18, 1, 15)
        Me.TableLayoutPanel_Card.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel_Card.Location = New System.Drawing.Point(103, 3)
        Me.TableLayoutPanel_Card.Name = "TableLayoutPanel_Card"
        Me.TableLayoutPanel_Card.RowCount = 19
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.TableLayoutPanel_Card.Size = New System.Drawing.Size(456, 331)
        Me.TableLayoutPanel_Card.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 255)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 17)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "FontColor"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label17.UseCompatibleTextRendering = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 17)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "QRCode"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label13.UseCompatibleTextRendering = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "DataColumn"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.UseCompatibleTextRendering = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(154, 207)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 11)
        Me.CheckBox2.TabIndex = 25
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 170)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "LinePos"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.UseCompatibleTextRendering = True
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(154, 173)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown3.TabIndex = 10
        Me.NumericUpDown3.Tag = "Decimal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Unten"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.UseCompatibleTextRendering = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.TableLayoutPanel_Card.SetColumnSpan(Me.Label7, 3)
        Me.Label7.Location = New System.Drawing.Point(3, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Rahmen Zeile"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.UseCompatibleTextRendering = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Oben"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.UseCompatibleTextRendering = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Rechts"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.UseCompatibleTextRendering = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Links"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel_Card.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Rahmen Karte "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Unten"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.UseCompatibleTextRendering = True
        '
        'NUD_CardBorderLeft
        '
        Me.NUD_CardBorderLeft.Location = New System.Drawing.Point(154, 20)
        Me.NUD_CardBorderLeft.Name = "NUD_CardBorderLeft"
        Me.NUD_CardBorderLeft.Size = New System.Drawing.Size(73, 20)
        Me.NUD_CardBorderLeft.TabIndex = 7
        Me.NUD_CardBorderLeft.Tag = "Decimal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Oben"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.UseCompatibleTextRendering = True
        '
        'NUD_CardBorderRight
        '
        Me.NUD_CardBorderRight.Location = New System.Drawing.Point(154, 37)
        Me.NUD_CardBorderRight.Name = "NUD_CardBorderRight"
        Me.NUD_CardBorderRight.Size = New System.Drawing.Size(73, 20)
        Me.NUD_CardBorderRight.TabIndex = 9
        Me.NUD_CardBorderRight.Tag = "Decimal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Rechts"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.UseCompatibleTextRendering = True
        '
        'NUD_CardBorderTop
        '
        Me.NUD_CardBorderTop.Location = New System.Drawing.Point(154, 54)
        Me.NUD_CardBorderTop.Name = "NUD_CardBorderTop"
        Me.NUD_CardBorderTop.Size = New System.Drawing.Size(73, 20)
        Me.NUD_CardBorderTop.TabIndex = 10
        Me.NUD_CardBorderTop.Tag = "Decimal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Links"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.UseCompatibleTextRendering = True
        '
        'NUD_CardBorderBottom
        '
        Me.NUD_CardBorderBottom.Location = New System.Drawing.Point(154, 71)
        Me.NUD_CardBorderBottom.Name = "NUD_CardBorderBottom"
        Me.NUD_CardBorderBottom.Size = New System.Drawing.Size(73, 20)
        Me.NUD_CardBorderBottom.TabIndex = 11
        Me.NUD_CardBorderBottom.Tag = "Decimal"
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.Location = New System.Drawing.Point(154, 105)
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown7.TabIndex = 14
        Me.NumericUpDown7.Tag = "Decimal"
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Location = New System.Drawing.Point(154, 122)
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown6.TabIndex = 13
        Me.NumericUpDown6.Tag = "Decimal"
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Location = New System.Drawing.Point(154, 139)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown5.TabIndex = 12
        Me.NumericUpDown5.Tag = "Decimal"
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(154, 156)
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown4.TabIndex = 11
        Me.NumericUpDown4.Tag = "Decimal"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(154, 190)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 11)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 204)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 17)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "AutoFont"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.UseCompatibleTextRendering = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(154, 224)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 238)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 17)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Font"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.UseCompatibleTextRendering = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(154, 238)
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
        Me.Label18.Location = New System.Drawing.Point(154, 255)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 17)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "FontColor"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label18.UseCompatibleTextRendering = True
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(100, 331)
        Me.ListBox1.TabIndex = 1
        '
        'OptionenToolStripMenuItem
        '
        Me.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem"
        Me.OptionenToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.OptionenToolStripMenuItem.Text = "&Optionen"
        '
        'TSMI_Font
        '
        Me.TSMI_Font.Name = "TSMI_Font"
        Me.TSMI_Font.Size = New System.Drawing.Size(122, 22)
        Me.TSMI_Font.Text = "Schriftart"
        '
        'AnpassenToolStripMenuItem
        '
        Me.AnpassenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_Font})
        Me.AnpassenToolStripMenuItem.Name = "AnpassenToolStripMenuItem"
        Me.AnpassenToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AnpassenToolStripMenuItem.Text = "&Anpassen"
        '
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnpassenToolStripMenuItem, Me.OptionenToolStripMenuItem})
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ExtrasToolStripMenuItem.Text = "E&xtras"
        '
        'AlleauswählenToolStripMenuItem
        '
        Me.AlleauswählenToolStripMenuItem.Name = "AlleauswählenToolStripMenuItem"
        Me.AlleauswählenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AlleauswählenToolStripMenuItem.Text = "&Alle auswählen"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(188, 6)
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(188, 6)
        '
        'WiederholenToolStripMenuItem
        '
        Me.WiederholenToolStripMenuItem.Name = "WiederholenToolStripMenuItem"
        Me.WiederholenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.WiederholenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.WiederholenToolStripMenuItem.Text = "Wiede&rholen"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InhaltToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SuchenToolStripMenuItem, Me.toolStripSeparator5, Me.InfoToolStripMenuItem})
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
        'SuchenToolStripMenuItem
        '
        Me.SuchenToolStripMenuItem.Name = "SuchenToolStripMenuItem"
        Me.SuchenToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.SuchenToolStripMenuItem.Text = "&Suchen"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(110, 6)
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.InfoToolStripMenuItem.Text = "Inf&o..."
        '
        'RückgängigToolStripMenuItem
        '
        Me.RückgängigToolStripMenuItem.Name = "RückgängigToolStripMenuItem"
        Me.RückgängigToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.RückgängigToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.RückgängigToolStripMenuItem.Text = "&Rückgängig"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'TSMI_XML_SaveAs
        '
        Me.TSMI_XML_SaveAs.Name = "TSMI_XML_SaveAs"
        Me.TSMI_XML_SaveAs.Size = New System.Drawing.Size(168, 22)
        Me.TSMI_XML_SaveAs.Text = "Speichern &unter"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(165, 6)
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_XML_New, Me.ÖffnenToolStripMenuItem, Me.toolStripSeparator, Me.TSMI_Safe, Me.TSMI_XML_SaveAs, Me.toolStripSeparator1, Me.DruckenToolStripMenuItem, Me.SeitenansichtToolStripMenuItem, Me.toolStripSeparator2, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'TSMI_XML_New
        '
        Me.TSMI_XML_New.Image = CType(resources.GetObject("TSMI_XML_New.Image"), System.Drawing.Image)
        Me.TSMI_XML_New.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSMI_XML_New.Name = "TSMI_XML_New"
        Me.TSMI_XML_New.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.TSMI_XML_New.Size = New System.Drawing.Size(168, 22)
        Me.TSMI_XML_New.Text = "&Neu"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Image = CType(resources.GetObject("ÖffnenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ÖffnenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Ö&ffnen"
        '
        'TSMI_Safe
        '
        Me.TSMI_Safe.Image = CType(resources.GetObject("TSMI_Safe.Image"), System.Drawing.Image)
        Me.TSMI_Safe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSMI_Safe.Name = "TSMI_Safe"
        Me.TSMI_Safe.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.TSMI_Safe.Size = New System.Drawing.Size(168, 22)
        Me.TSMI_Safe.Text = "&Speichern"
        '
        'DruckenToolStripMenuItem
        '
        Me.DruckenToolStripMenuItem.Image = CType(resources.GetObject("DruckenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DruckenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DruckenToolStripMenuItem.Name = "DruckenToolStripMenuItem"
        Me.DruckenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.DruckenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.DruckenToolStripMenuItem.Text = "&Drucken"
        '
        'SeitenansichtToolStripMenuItem
        '
        Me.SeitenansichtToolStripMenuItem.Image = CType(resources.GetObject("SeitenansichtToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SeitenansichtToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SeitenansichtToolStripMenuItem.Name = "SeitenansichtToolStripMenuItem"
        Me.SeitenansichtToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SeitenansichtToolStripMenuItem.Text = "&Seitenansicht"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RückgängigToolStripMenuItem, Me.WiederholenToolStripMenuItem, Me.toolStripSeparator3, Me.AusschneidenToolStripMenuItem, Me.KopierenToolStripMenuItem, Me.EinfügenToolStripMenuItem, Me.toolStripSeparator4, Me.AlleauswählenToolStripMenuItem})
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BearbeitenToolStripMenuItem.Text = "&Bearbeiten"
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
        Me.Main_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.BearbeitenToolStripMenuItem, Me.ExtrasToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.Main_MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.Main_MenuStrip.Name = "Main_MenuStrip"
        Me.Main_MenuStrip.Size = New System.Drawing.Size(834, 24)
        Me.Main_MenuStrip.TabIndex = 4
        Me.Main_MenuStrip.Text = "MenuStrip1"
        '
        'Main_OpenFileDialog
        '
        Me.Main_OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'TSSL_SaveFile
        '
        Me.TSSL_SaveFile.Name = "TSSL_SaveFile"
        Me.TSSL_SaveFile.Size = New System.Drawing.Size(37, 17)
        Me.TSSL_SaveFile.Text = "Bereit"
        '
        'TSSL_SaveInfo
        '
        Me.TSSL_SaveInfo.Name = "TSSL_SaveInfo"
        Me.TSSL_SaveInfo.Size = New System.Drawing.Size(88, 17)
        Me.TSSL_SaveInfo.Text = "Gespeichert in: "
        '
        'TSSL_IsModified
        '
        Me.TSSL_IsModified.AutoSize = False
        Me.TSSL_IsModified.BackColor = System.Drawing.Color.Red
        Me.TSSL_IsModified.Name = "TSSL_IsModified"
        Me.TSSL_IsModified.Size = New System.Drawing.Size(17, 17)
        '
        'Main_StatusStrip
        '
        Me.Main_StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL_IsModified, Me.TSSL_SaveInfo, Me.TSSL_SaveFile})
        Me.Main_StatusStrip.Location = New System.Drawing.Point(0, 515)
        Me.Main_StatusStrip.Name = "Main_StatusStrip"
        Me.Main_StatusStrip.Size = New System.Drawing.Size(834, 22)
        Me.Main_StatusStrip.SizingGrip = False
        Me.Main_StatusStrip.TabIndex = 5
        Me.Main_StatusStrip.Text = "StatusStrip1"
        '
        'TableLayoutPanel_Paper_Border
        '
        Me.TableLayoutPanel_Paper_Border.AutoSize = True
        Me.TableLayoutPanel_Paper_Border.ColumnCount = 3
        Me.TableLayoutPanel_Paper_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel_Paper_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel_Paper_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label19, 2, 1)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label20, 2, 2)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label21, 2, 3)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label_Left, 0, 0)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label_Right, 0, 1)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label_Top, 0, 2)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.NUD_Paper_Border_Left, 1, 0)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.NUD_Paper_Border_Right, 1, 1)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.NUD_Paper_Border_Top, 1, 2)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.NUD_Paper_Border_Bottom, 1, 3)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label_Bottom, 0, 3)
        Me.TableLayoutPanel_Paper_Border.Controls.Add(Me.Label22, 2, 0)
        Me.TableLayoutPanel_Paper_Border.Location = New System.Drawing.Point(6, 37)
        Me.TableLayoutPanel_Paper_Border.Name = "TableLayoutPanel_Paper_Border"
        Me.TableLayoutPanel_Paper_Border.RowCount = 4
        Me.TableLayoutPanel_Paper_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Paper_Border.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_Paper_Border.Size = New System.Drawing.Size(237, 104)
        Me.TableLayoutPanel_Paper_Border.TabIndex = 46
        '
        'GroupBox_Paper_Border
        '
        Me.GroupBox_Paper_Border.Controls.Add(Me.TableLayoutPanel_Paper_Border)
        Me.GroupBox_Paper_Border.Location = New System.Drawing.Point(3, 161)
        Me.GroupBox_Paper_Border.Name = "GroupBox_Paper_Border"
        Me.GroupBox_Paper_Border.Size = New System.Drawing.Size(256, 156)
        Me.GroupBox_Paper_Border.TabIndex = 47
        Me.GroupBox_Paper_Border.TabStop = False
        Me.GroupBox_Paper_Border.Text = "Rahmen"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = Global.CSVtoQR.My.MySettings.Default.MySize
        Me.Controls.Add(Me.Main_TabControl)
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
        CType(Me.NUD_Separator_Zeile_Anzahl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Separator_Spalte_Anzahl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Separator_Spalte_Wert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Separator_Zeile_Wert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Separator.ResumeLayout(False)
        Me.GroupBox_Separator.PerformLayout()
        CType(Me.NUD_Paper_Border_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Paper_Border_Bottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Paper_Border_Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Paper_Border_Right, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.GroupBox_Shema.ResumeLayout(False)
        Me.GroupBox_Shema.PerformLayout()
        Me.TableLayoutPanel_Shema.ResumeLayout(False)
        Me.TableLayoutPanel_Shema.PerformLayout()
        Me.Panel_Paper.ResumeLayout(False)
        CType(Me.PictureBox_Paper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Table.ResumeLayout(False)
        CType(Me.DGV_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Card.ResumeLayout(False)
        Me.TableLayoutPanel_Card.ResumeLayout(False)
        Me.TableLayoutPanel_Card.PerformLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_CardBorderLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_CardBorderRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_CardBorderTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_CardBorderBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Main_MenuStrip.ResumeLayout(False)
        Me.Main_MenuStrip.PerformLayout()
        Me.Main_StatusStrip.ResumeLayout(False)
        Me.Main_StatusStrip.PerformLayout()
        CType(Me.Main_BindingSource_CSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel_Paper_Border.ResumeLayout(False)
        Me.TableLayoutPanel_Paper_Border.PerformLayout()
        Me.GroupBox_Paper_Border.ResumeLayout(False)
        Me.GroupBox_Paper_Border.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Separator_Zeile As Label
    Friend WithEvents Label_Separator_Anzahl As Label
    Friend WithEvents Label_Separator_Wert As Label
    Friend WithEvents TableLayoutPanel_Separator As TableLayoutPanel
    Friend WithEvents Label_Separator_Spalte As Label
    Friend WithEvents GroupBox_Separator As GroupBox
    Friend WithEvents GroupBox_Shema As GroupBox
    Friend WithEvents TableLayoutPanel_Shema As TableLayoutPanel
    Friend WithEvents Label_Shema As Label
    Friend WithEvents TextBox_Shema As TextBox
    Friend WithEvents Label_Paper_Width As Label
    Friend WithEvents Label_Paper_Height As Label
    Friend WithEvents Label_DPI As Label
    Friend WithEvents Label_DIN As Label
    Friend WithEvents CB_DIN As ComboBox
    Friend WithEvents Label_Paper_Einheit_Height As Label
    Friend WithEvents Label_Paper_Einheit_Width As Label
    Friend WithEvents Label_Left As Label
    Friend WithEvents Label_Bottom As Label
    Friend WithEvents Label_Top As Label
    Friend WithEvents Label_Right As Label
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
    Friend WithEvents OptionenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMI_Font As ToolStripMenuItem
    Friend WithEvents AnpassenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExtrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlleauswählenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents EinfügenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KopierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AusschneidenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents WiederholenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InhaltToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuchenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RückgängigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SeitenansichtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DruckenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TSMI_XML_SaveAs As ToolStripMenuItem
    Friend WithEvents TSMI_Safe As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents ÖffnenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMI_XML_New As ToolStripMenuItem
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Main_MenuStrip As MenuStrip
    Friend WithEvents Main_BindingSource_CSV As BindingSource
    Friend WithEvents Main_SaveFileDialog As SaveFileDialog
    Friend WithEvents Main_OpenFileDialog As OpenFileDialog
    Friend WithEvents TSSL_SaveFile As ToolStripStatusLabel
    Friend WithEvents TSSL_SaveInfo As ToolStripStatusLabel
    Friend WithEvents TSSL_IsModified As ToolStripStatusLabel
    Friend WithEvents Main_StatusStrip As StatusStrip
    Friend WithEvents NUD_Paper_Border_Left As NumericUpDown
    Friend WithEvents NUD_Paper_Border_Top As NumericUpDown
    Friend WithEvents NUD_Paper_Border_Right As NumericUpDown
    Friend WithEvents NUD_Separator_Spalte_Anzahl As NumericUpDown
    Friend WithEvents NUD_Separator_Zeile_Anzahl As NumericUpDown
    Friend WithEvents NUD_Paper_Border_Bottom As NumericUpDown
    Friend WithEvents NUD_Separator_Spalte_Wert As NumericUpDown
    Friend WithEvents NUD_Separator_Zeile_Wert As NumericUpDown
    Friend WithEvents CB_DPI As ComboBox
    Friend WithEvents Label_Paper_Value_Width As Label
    Friend WithEvents Label_Paper_Value_Height As Label
    Friend WithEvents TableLayoutPanel_Paper As TableLayoutPanel
    Friend WithEvents Button_Search_Refresh As Button
    Friend WithEvents Panel_Daten_CSV As Panel
    Friend WithEvents TabPage_Card As TabPage
    Friend WithEvents TableLayoutPanel_Card As TableLayoutPanel
    Friend WithEvents NUD_CardBorderLeft As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NUD_CardBorderBottom As NumericUpDown
    Friend WithEvents NUD_CardBorderTop As NumericUpDown
    Friend WithEvents NUD_CardBorderRight As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents NumericUpDown6 As NumericUpDown
    Friend WithEvents NumericUpDown7 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TableLayoutPanel_Paper_Border As TableLayoutPanel
    Friend WithEvents GroupBox_Paper_Border As GroupBox
End Class
