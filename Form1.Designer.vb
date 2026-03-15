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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label_BorderCard = New System.Windows.Forms.Label()
        Me.Label_SeparatorZeile = New System.Windows.Forms.Label()
        Me.Label_SeparatorAnzahl = New System.Windows.Forms.Label()
        Me.Label_SeparatorWert = New System.Windows.Forms.Label()
        Me.TLP_Separator = New System.Windows.Forms.TableLayoutPanel()
        Me.NUD_SeparatorZeileAnzahl = New System.Windows.Forms.NumericUpDown()
        Me.NUD_SeparatorSpalteAnzahl = New System.Windows.Forms.NumericUpDown()
        Me.NUD_SeparatorSpalteWert = New System.Windows.Forms.NumericUpDown()
        Me.NUD_SeparatorZeileWert = New System.Windows.Forms.NumericUpDown()
        Me.Label_SeparatorSpalte = New System.Windows.Forms.Label()
        Me.GroupBox_Separator = New System.Windows.Forms.GroupBox()
        Me.Label_Left = New System.Windows.Forms.Label()
        Me.Label_Bottom = New System.Windows.Forms.Label()
        Me.Label_Top = New System.Windows.Forms.Label()
        Me.Label_Right = New System.Windows.Forms.Label()
        Me.Label_PaperWidth = New System.Windows.Forms.Label()
        Me.Label_PaperHeight = New System.Windows.Forms.Label()
        Me.Label_DPI = New System.Windows.Forms.Label()
        Me.Label_DIN = New System.Windows.Forms.Label()
        Me.TLP_Border = New System.Windows.Forms.TableLayoutPanel()
        Me.NUD_CardBorderRight = New System.Windows.Forms.NumericUpDown()
        Me.NUD_CardBorderTop = New System.Windows.Forms.NumericUpDown()
        Me.Label_BorderPaper = New System.Windows.Forms.Label()
        Me.NUD_PaperBorderTop = New System.Windows.Forms.NumericUpDown()
        Me.NUD_CardBorderBottom = New System.Windows.Forms.NumericUpDown()
        Me.NUD_PaperBorderBottom = New System.Windows.Forms.NumericUpDown()
        Me.NUD_PaperBorderLeft = New System.Windows.Forms.NumericUpDown()
        Me.NUD_CardBorderLeft = New System.Windows.Forms.NumericUpDown()
        Me.NUD_PaperBorderRight = New System.Windows.Forms.NumericUpDown()
        Me.FD = New System.Windows.Forms.FontDialog()
        Me.Label_Import = New System.Windows.Forms.Label()
        Me.TextBox_Import = New System.Windows.Forms.TextBox()
        Me.Label_Export = New System.Windows.Forms.Label()
        Me.TextBox_Export = New System.Windows.Forms.TextBox()
        Me.Button_Import = New System.Windows.Forms.Button()
        Me.IL = New System.Windows.Forms.ImageList(Me.components)
        Me.Button_Export = New System.Windows.Forms.Button()
        Me.TLP_Files = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox_Files = New System.Windows.Forms.GroupBox()
        Me.Button_SearchAdd = New System.Windows.Forms.Button()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BNcsv = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.Button_SearchDelete = New System.Windows.Forms.Button()
        Me.DGVcsv = New System.Windows.Forms.DataGridView()
        Me.DGV_Search = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabPage_Files = New System.Windows.Forms.TabPage()
        Me.TabControl_Default = New System.Windows.Forms.TabControl()
        Me.TabPage_Paper = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox_Paper = New System.Windows.Forms.PictureBox()
        Me.TLP_Main = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox_Shema = New System.Windows.Forms.GroupBox()
        Me.TLP_Shema = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Shema = New System.Windows.Forms.Label()
        Me.TextBox_Shema = New System.Windows.Forms.TextBox()
        Me.GroupBox_Paper = New System.Windows.Forms.GroupBox()
        Me.TLP_Paper = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_PaperWidth_Value = New System.Windows.Forms.Label()
        Me.CB_DPI = New System.Windows.Forms.ComboBox()
        Me.Label_PaperHeight_Value = New System.Windows.Forms.Label()
        Me.CB_DIN = New System.Windows.Forms.ComboBox()
        Me.Label_PaperHeightEinheit = New System.Windows.Forms.Label()
        Me.Label_PaperWidthEinheit = New System.Windows.Forms.Label()
        Me.GroupBox_Border = New System.Windows.Forms.GroupBox()
        Me.TabPage_Table = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV_Table = New System.Windows.Forms.DataGridView()
        Me.ListBox_Tabellen = New System.Windows.Forms.ListBox()
        Me.OptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_Font = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnpassenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlleauswählenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.SeitenansichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SpeichernunterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_Safe = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_Main = New System.Windows.Forms.MenuStrip()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.TSSL_SaveFile = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_SaveInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_IsModified = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip_Main = New System.Windows.Forms.StatusStrip()
        Me.BScsv = New System.Windows.Forms.BindingSource(Me.components)
        Me.TLP_Separator.SuspendLayout()
        CType(Me.NUD_SeparatorZeileAnzahl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_SeparatorSpalteAnzahl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_SeparatorSpalteWert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_SeparatorZeileWert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Separator.SuspendLayout()
        Me.TLP_Border.SuspendLayout()
        CType(Me.NUD_CardBorderRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_CardBorderTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_PaperBorderTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_CardBorderBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_PaperBorderBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_PaperBorderLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_CardBorderLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_PaperBorderRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_Files.SuspendLayout()
        Me.GroupBox_Files.SuspendLayout()
        CType(Me.BNcsv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BNcsv.SuspendLayout()
        CType(Me.DGVcsv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage_Files.SuspendLayout()
        Me.TabControl_Default.SuspendLayout()
        Me.TabPage_Paper.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox_Paper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_Main.SuspendLayout()
        Me.GroupBox_Shema.SuspendLayout()
        Me.TLP_Shema.SuspendLayout()
        Me.GroupBox_Paper.SuspendLayout()
        Me.TLP_Paper.SuspendLayout()
        Me.GroupBox_Border.SuspendLayout()
        Me.TabPage_Table.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MS_Main.SuspendLayout()
        Me.StatusStrip_Main.SuspendLayout()
        CType(Me.BScsv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_BorderCard
        '
        Me.Label_BorderCard.AutoSize = True
        Me.Label_BorderCard.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_BorderCard.Location = New System.Drawing.Point(127, 0)
        Me.Label_BorderCard.Name = "Label_BorderCard"
        Me.Label_BorderCard.Size = New System.Drawing.Size(73, 17)
        Me.Label_BorderCard.TabIndex = 5
        Me.Label_BorderCard.Text = "Karte"
        Me.Label_BorderCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_BorderCard.UseCompatibleTextRendering = True
        '
        'Label_SeparatorZeile
        '
        Me.Label_SeparatorZeile.AutoSize = True
        Me.Label_SeparatorZeile.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_SeparatorZeile.Location = New System.Drawing.Point(3, 43)
        Me.Label_SeparatorZeile.Name = "Label_SeparatorZeile"
        Me.Label_SeparatorZeile.Size = New System.Drawing.Size(36, 17)
        Me.Label_SeparatorZeile.TabIndex = 2
        Me.Label_SeparatorZeile.Text = "Zeile"
        Me.Label_SeparatorZeile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_SeparatorZeile.UseCompatibleTextRendering = True
        '
        'Label_SeparatorAnzahl
        '
        Me.Label_SeparatorAnzahl.AutoSize = True
        Me.Label_SeparatorAnzahl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_SeparatorAnzahl.Location = New System.Drawing.Point(45, 0)
        Me.Label_SeparatorAnzahl.Name = "Label_SeparatorAnzahl"
        Me.Label_SeparatorAnzahl.Size = New System.Drawing.Size(74, 17)
        Me.Label_SeparatorAnzahl.TabIndex = 0
        Me.Label_SeparatorAnzahl.Text = "Anzahl"
        Me.Label_SeparatorAnzahl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_SeparatorAnzahl.UseCompatibleTextRendering = True
        '
        'Label_SeparatorWert
        '
        Me.Label_SeparatorWert.AutoSize = True
        Me.Label_SeparatorWert.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_SeparatorWert.Location = New System.Drawing.Point(125, 0)
        Me.Label_SeparatorWert.Name = "Label_SeparatorWert"
        Me.Label_SeparatorWert.Size = New System.Drawing.Size(75, 17)
        Me.Label_SeparatorWert.TabIndex = 1
        Me.Label_SeparatorWert.Text = "Wert"
        Me.Label_SeparatorWert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_SeparatorWert.UseCompatibleTextRendering = True
        '
        'TLP_Separator
        '
        Me.TLP_Separator.AutoSize = True
        Me.TLP_Separator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TLP_Separator.ColumnCount = 3
        Me.TLP_Separator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Separator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Separator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Separator.Controls.Add(Me.NUD_SeparatorZeileAnzahl, 1, 2)
        Me.TLP_Separator.Controls.Add(Me.NUD_SeparatorSpalteAnzahl, 1, 1)
        Me.TLP_Separator.Controls.Add(Me.Label_SeparatorZeile, 0, 2)
        Me.TLP_Separator.Controls.Add(Me.Label_SeparatorAnzahl, 1, 0)
        Me.TLP_Separator.Controls.Add(Me.NUD_SeparatorSpalteWert, 2, 1)
        Me.TLP_Separator.Controls.Add(Me.NUD_SeparatorZeileWert, 2, 2)
        Me.TLP_Separator.Controls.Add(Me.Label_SeparatorWert, 2, 0)
        Me.TLP_Separator.Controls.Add(Me.Label_SeparatorSpalte, 0, 1)
        Me.TLP_Separator.Dock = System.Windows.Forms.DockStyle.Top
        Me.TLP_Separator.Location = New System.Drawing.Point(3, 16)
        Me.TLP_Separator.Name = "TLP_Separator"
        Me.TLP_Separator.RowCount = 3
        Me.TLP_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Separator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Separator.Size = New System.Drawing.Size(203, 69)
        Me.TLP_Separator.TabIndex = 0
        Me.TLP_Separator.Tag = "Decimal"
        '
        'NUD_SeparatorZeileAnzahl
        '
        Me.NUD_SeparatorZeileAnzahl.Location = New System.Drawing.Point(45, 46)
        Me.NUD_SeparatorZeileAnzahl.Name = "NUD_SeparatorZeileAnzahl"
        Me.NUD_SeparatorZeileAnzahl.Size = New System.Drawing.Size(74, 20)
        Me.NUD_SeparatorZeileAnzahl.TabIndex = 2
        Me.NUD_SeparatorZeileAnzahl.Tag = "Anzahl"
        '
        'NUD_SeparatorSpalteAnzahl
        '
        Me.NUD_SeparatorSpalteAnzahl.Location = New System.Drawing.Point(45, 20)
        Me.NUD_SeparatorSpalteAnzahl.Name = "NUD_SeparatorSpalteAnzahl"
        Me.NUD_SeparatorSpalteAnzahl.Size = New System.Drawing.Size(74, 20)
        Me.NUD_SeparatorSpalteAnzahl.TabIndex = 0
        Me.NUD_SeparatorSpalteAnzahl.Tag = "Anzahl"
        '
        'NUD_SeparatorSpalteWert
        '
        Me.NUD_SeparatorSpalteWert.Location = New System.Drawing.Point(125, 20)
        Me.NUD_SeparatorSpalteWert.Name = "NUD_SeparatorSpalteWert"
        Me.NUD_SeparatorSpalteWert.Size = New System.Drawing.Size(75, 20)
        Me.NUD_SeparatorSpalteWert.TabIndex = 1
        Me.NUD_SeparatorSpalteWert.Tag = "Decimal"
        '
        'NUD_SeparatorZeileWert
        '
        Me.NUD_SeparatorZeileWert.Location = New System.Drawing.Point(125, 46)
        Me.NUD_SeparatorZeileWert.Name = "NUD_SeparatorZeileWert"
        Me.NUD_SeparatorZeileWert.Size = New System.Drawing.Size(75, 20)
        Me.NUD_SeparatorZeileWert.TabIndex = 3
        Me.NUD_SeparatorZeileWert.Tag = "Decimal"
        '
        'Label_SeparatorSpalte
        '
        Me.Label_SeparatorSpalte.AutoSize = True
        Me.Label_SeparatorSpalte.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_SeparatorSpalte.Location = New System.Drawing.Point(3, 17)
        Me.Label_SeparatorSpalte.Name = "Label_SeparatorSpalte"
        Me.Label_SeparatorSpalte.Size = New System.Drawing.Size(36, 17)
        Me.Label_SeparatorSpalte.TabIndex = 5
        Me.Label_SeparatorSpalte.Text = "Spalte"
        Me.Label_SeparatorSpalte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_SeparatorSpalte.UseCompatibleTextRendering = True
        '
        'GroupBox_Separator
        '
        Me.GroupBox_Separator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TLP_Main.SetColumnSpan(Me.GroupBox_Separator, 2)
        Me.GroupBox_Separator.Controls.Add(Me.TLP_Separator)
        Me.GroupBox_Separator.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox_Separator.Location = New System.Drawing.Point(3, 347)
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
        Me.Label_Left.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Left.Location = New System.Drawing.Point(3, 17)
        Me.Label_Left.Name = "Label_Left"
        Me.Label_Left.Size = New System.Drawing.Size(39, 17)
        Me.Label_Left.TabIndex = 1
        Me.Label_Left.Text = "Links"
        Me.Label_Left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Left.UseCompatibleTextRendering = True
        '
        'Label_Bottom
        '
        Me.Label_Bottom.AutoSize = True
        Me.Label_Bottom.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Bottom.Location = New System.Drawing.Point(3, 95)
        Me.Label_Bottom.Name = "Label_Bottom"
        Me.Label_Bottom.Size = New System.Drawing.Size(39, 17)
        Me.Label_Bottom.TabIndex = 7
        Me.Label_Bottom.Text = "Unten"
        Me.Label_Bottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Bottom.UseCompatibleTextRendering = True
        '
        'Label_Top
        '
        Me.Label_Top.AutoSize = True
        Me.Label_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Top.Location = New System.Drawing.Point(3, 69)
        Me.Label_Top.Name = "Label_Top"
        Me.Label_Top.Size = New System.Drawing.Size(39, 17)
        Me.Label_Top.TabIndex = 5
        Me.Label_Top.Text = "Oben"
        Me.Label_Top.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Top.UseCompatibleTextRendering = True
        '
        'Label_Right
        '
        Me.Label_Right.AutoSize = True
        Me.Label_Right.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Right.Location = New System.Drawing.Point(3, 43)
        Me.Label_Right.Name = "Label_Right"
        Me.Label_Right.Size = New System.Drawing.Size(39, 17)
        Me.Label_Right.TabIndex = 3
        Me.Label_Right.Text = "Rechts"
        Me.Label_Right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Right.UseCompatibleTextRendering = True
        '
        'Label_PaperWidth
        '
        Me.Label_PaperWidth.AutoSize = True
        Me.Label_PaperWidth.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_PaperWidth.Location = New System.Drawing.Point(3, 71)
        Me.Label_PaperWidth.Name = "Label_PaperWidth"
        Me.Label_PaperWidth.Size = New System.Drawing.Size(34, 17)
        Me.Label_PaperWidth.TabIndex = 6
        Me.Label_PaperWidth.Text = "Breite"
        Me.Label_PaperWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_PaperWidth.UseCompatibleTextRendering = True
        '
        'Label_PaperHeight
        '
        Me.Label_PaperHeight.AutoSize = True
        Me.Label_PaperHeight.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_PaperHeight.Location = New System.Drawing.Point(3, 54)
        Me.Label_PaperHeight.Name = "Label_PaperHeight"
        Me.Label_PaperHeight.Size = New System.Drawing.Size(34, 17)
        Me.Label_PaperHeight.TabIndex = 4
        Me.Label_PaperHeight.Text = "Höhe"
        Me.Label_PaperHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_PaperHeight.UseCompatibleTextRendering = True
        '
        'Label_DPI
        '
        Me.Label_DPI.AutoSize = True
        Me.Label_DPI.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_DPI.Location = New System.Drawing.Point(3, 0)
        Me.Label_DPI.Name = "Label_DPI"
        Me.Label_DPI.Size = New System.Drawing.Size(34, 17)
        Me.Label_DPI.TabIndex = 0
        Me.Label_DPI.Text = "DPI"
        Me.Label_DPI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_DPI.UseCompatibleTextRendering = True
        '
        'Label_DIN
        '
        Me.Label_DIN.AutoSize = True
        Me.Label_DIN.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_DIN.Location = New System.Drawing.Point(3, 27)
        Me.Label_DIN.Name = "Label_DIN"
        Me.Label_DIN.Size = New System.Drawing.Size(34, 17)
        Me.Label_DIN.TabIndex = 2
        Me.Label_DIN.Text = "DIN"
        Me.Label_DIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_DIN.UseCompatibleTextRendering = True
        '
        'TLP_Border
        '
        Me.TLP_Border.AutoSize = True
        Me.TLP_Border.ColumnCount = 3
        Me.TLP_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Border.Controls.Add(Me.NUD_CardBorderRight, 2, 2)
        Me.TLP_Border.Controls.Add(Me.NUD_CardBorderTop, 2, 3)
        Me.TLP_Border.Controls.Add(Me.Label_BorderPaper, 1, 0)
        Me.TLP_Border.Controls.Add(Me.NUD_PaperBorderTop, 1, 3)
        Me.TLP_Border.Controls.Add(Me.NUD_CardBorderBottom, 2, 4)
        Me.TLP_Border.Controls.Add(Me.NUD_PaperBorderBottom, 1, 4)
        Me.TLP_Border.Controls.Add(Me.Label_BorderCard, 2, 0)
        Me.TLP_Border.Controls.Add(Me.Label_Left, 0, 1)
        Me.TLP_Border.Controls.Add(Me.Label_Bottom, 0, 4)
        Me.TLP_Border.Controls.Add(Me.Label_Top, 0, 3)
        Me.TLP_Border.Controls.Add(Me.Label_Right, 0, 2)
        Me.TLP_Border.Controls.Add(Me.NUD_PaperBorderLeft, 1, 1)
        Me.TLP_Border.Controls.Add(Me.NUD_CardBorderLeft, 2, 1)
        Me.TLP_Border.Controls.Add(Me.NUD_PaperBorderRight, 1, 2)
        Me.TLP_Border.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Border.Location = New System.Drawing.Point(3, 16)
        Me.TLP_Border.Name = "TLP_Border"
        Me.TLP_Border.RowCount = 5
        Me.TLP_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Border.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Border.Size = New System.Drawing.Size(203, 122)
        Me.TLP_Border.TabIndex = 0
        '
        'NUD_CardBorderRight
        '
        Me.NUD_CardBorderRight.Location = New System.Drawing.Point(127, 46)
        Me.NUD_CardBorderRight.Name = "NUD_CardBorderRight"
        Me.NUD_CardBorderRight.Size = New System.Drawing.Size(73, 20)
        Me.NUD_CardBorderRight.TabIndex = 7
        Me.NUD_CardBorderRight.Tag = "Decimal"
        '
        'NUD_CardBorderTop
        '
        Me.NUD_CardBorderTop.Location = New System.Drawing.Point(127, 72)
        Me.NUD_CardBorderTop.Name = "NUD_CardBorderTop"
        Me.NUD_CardBorderTop.Size = New System.Drawing.Size(73, 20)
        Me.NUD_CardBorderTop.TabIndex = 8
        Me.NUD_CardBorderTop.Tag = "Decimal"
        '
        'Label_BorderPaper
        '
        Me.Label_BorderPaper.AutoSize = True
        Me.Label_BorderPaper.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_BorderPaper.Location = New System.Drawing.Point(48, 0)
        Me.Label_BorderPaper.Name = "Label_BorderPaper"
        Me.Label_BorderPaper.Size = New System.Drawing.Size(73, 17)
        Me.Label_BorderPaper.TabIndex = 0
        Me.Label_BorderPaper.Text = "Papier"
        Me.Label_BorderPaper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_BorderPaper.UseCompatibleTextRendering = True
        '
        'NUD_PaperBorderTop
        '
        Me.NUD_PaperBorderTop.Location = New System.Drawing.Point(48, 72)
        Me.NUD_PaperBorderTop.Name = "NUD_PaperBorderTop"
        Me.NUD_PaperBorderTop.Size = New System.Drawing.Size(73, 20)
        Me.NUD_PaperBorderTop.TabIndex = 3
        Me.NUD_PaperBorderTop.Tag = "Decimal"
        '
        'NUD_CardBorderBottom
        '
        Me.NUD_CardBorderBottom.Location = New System.Drawing.Point(127, 98)
        Me.NUD_CardBorderBottom.Name = "NUD_CardBorderBottom"
        Me.NUD_CardBorderBottom.Size = New System.Drawing.Size(73, 20)
        Me.NUD_CardBorderBottom.TabIndex = 9
        Me.NUD_CardBorderBottom.Tag = "Decimal"
        '
        'NUD_PaperBorderBottom
        '
        Me.NUD_PaperBorderBottom.Location = New System.Drawing.Point(48, 98)
        Me.NUD_PaperBorderBottom.Name = "NUD_PaperBorderBottom"
        Me.NUD_PaperBorderBottom.Size = New System.Drawing.Size(73, 20)
        Me.NUD_PaperBorderBottom.TabIndex = 4
        Me.NUD_PaperBorderBottom.Tag = "Decimal"
        '
        'NUD_PaperBorderLeft
        '
        Me.NUD_PaperBorderLeft.Location = New System.Drawing.Point(48, 20)
        Me.NUD_PaperBorderLeft.Name = "NUD_PaperBorderLeft"
        Me.NUD_PaperBorderLeft.Size = New System.Drawing.Size(73, 20)
        Me.NUD_PaperBorderLeft.TabIndex = 1
        Me.NUD_PaperBorderLeft.Tag = "Decimal"
        '
        'NUD_CardBorderLeft
        '
        Me.NUD_CardBorderLeft.Location = New System.Drawing.Point(127, 20)
        Me.NUD_CardBorderLeft.Name = "NUD_CardBorderLeft"
        Me.NUD_CardBorderLeft.Size = New System.Drawing.Size(73, 20)
        Me.NUD_CardBorderLeft.TabIndex = 6
        Me.NUD_CardBorderLeft.Tag = "Decimal"
        '
        'NUD_PaperBorderRight
        '
        Me.NUD_PaperBorderRight.Location = New System.Drawing.Point(48, 46)
        Me.NUD_PaperBorderRight.Name = "NUD_PaperBorderRight"
        Me.NUD_PaperBorderRight.Size = New System.Drawing.Size(73, 20)
        Me.NUD_PaperBorderRight.TabIndex = 2
        Me.NUD_PaperBorderRight.Tag = "Decimal"
        '
        'Label_Import
        '
        Me.Label_Import.AutoSize = True
        Me.Label_Import.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Import.Location = New System.Drawing.Point(3, 9)
        Me.Label_Import.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.Label_Import.Name = "Label_Import"
        Me.Label_Import.Size = New System.Drawing.Size(37, 17)
        Me.Label_Import.TabIndex = 3
        Me.Label_Import.Text = "Import"
        Me.Label_Import.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Import.UseCompatibleTextRendering = True
        '
        'TextBox_Import
        '
        Me.TextBox_Import.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox_Import.Location = New System.Drawing.Point(46, 9)
        Me.TextBox_Import.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.TextBox_Import.Name = "TextBox_Import"
        Me.TextBox_Import.Size = New System.Drawing.Size(487, 20)
        Me.TextBox_Import.TabIndex = 0
        Me.TextBox_Import.Tag = "String"
        '
        'Label_Export
        '
        Me.Label_Export.AutoSize = True
        Me.Label_Export.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.TextBox_Export.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox_Export.Location = New System.Drawing.Point(46, 53)
        Me.TextBox_Export.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.TextBox_Export.Name = "TextBox_Export"
        Me.TextBox_Export.Size = New System.Drawing.Size(487, 20)
        Me.TextBox_Export.TabIndex = 1
        Me.TextBox_Export.Tag = "String"
        '
        'Button_Import
        '
        Me.Button_Import.AutoSize = True
        Me.Button_Import.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Import.ImageKey = "Import.png"
        Me.Button_Import.ImageList = Me.IL
        Me.Button_Import.Location = New System.Drawing.Point(539, 3)
        Me.Button_Import.Name = "Button_Import"
        Me.Button_Import.Size = New System.Drawing.Size(38, 38)
        Me.Button_Import.TabIndex = 6
        Me.Button_Import.Text = "..."
        Me.Button_Import.UseVisualStyleBackColor = True
        '
        'IL
        '
        Me.IL.ImageStream = CType(resources.GetObject("IL.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IL.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.IL.Images.SetKeyName(0, "File_Printer.png")
        Me.IL.Images.SetKeyName(1, "Import.png")
        Me.IL.Images.SetKeyName(2, "ZoomIn.png")
        Me.IL.Images.SetKeyName(3, "ZoomOut.png")
        '
        'Button_Export
        '
        Me.Button_Export.AutoSize = True
        Me.Button_Export.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Export.ImageKey = "File_Printer.png"
        Me.Button_Export.ImageList = Me.IL
        Me.Button_Export.Location = New System.Drawing.Point(539, 47)
        Me.Button_Export.Name = "Button_Export"
        Me.Button_Export.Size = New System.Drawing.Size(38, 38)
        Me.Button_Export.TabIndex = 7
        Me.Button_Export.Text = "..."
        Me.Button_Export.UseVisualStyleBackColor = True
        '
        'TLP_Files
        '
        Me.TLP_Files.AutoSize = True
        Me.TLP_Files.ColumnCount = 3
        Me.TLP_Files.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Files.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Files.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Files.Controls.Add(Me.Label_Import, 0, 0)
        Me.TLP_Files.Controls.Add(Me.TextBox_Import, 1, 0)
        Me.TLP_Files.Controls.Add(Me.Label_Export, 0, 1)
        Me.TLP_Files.Controls.Add(Me.TextBox_Export, 1, 1)
        Me.TLP_Files.Controls.Add(Me.Button_Import, 2, 0)
        Me.TLP_Files.Controls.Add(Me.Button_Export, 2, 1)
        Me.TLP_Files.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Files.Location = New System.Drawing.Point(3, 16)
        Me.TLP_Files.Name = "TLP_Files"
        Me.TLP_Files.RowCount = 2
        Me.TLP_Files.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Files.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Files.Size = New System.Drawing.Size(580, 88)
        Me.TLP_Files.TabIndex = 0
        '
        'GroupBox_Files
        '
        Me.GroupBox_Files.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox_Files.Controls.Add(Me.TLP_Files)
        Me.GroupBox_Files.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox_Files.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox_Files.Name = "GroupBox_Files"
        Me.GroupBox_Files.Size = New System.Drawing.Size(586, 107)
        Me.GroupBox_Files.TabIndex = 43
        Me.GroupBox_Files.TabStop = False
        Me.GroupBox_Files.Text = "Dateien"
        '
        'Button_SearchAdd
        '
        Me.Button_SearchAdd.AutoSize = True
        Me.Button_SearchAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SearchAdd.ImageKey = "ZoomIn.png"
        Me.Button_SearchAdd.ImageList = Me.IL
        Me.Button_SearchAdd.Location = New System.Drawing.Point(545, 90)
        Me.Button_SearchAdd.Name = "Button_SearchAdd"
        Me.Button_SearchAdd.Size = New System.Drawing.Size(38, 38)
        Me.Button_SearchAdd.TabIndex = 47
        Me.Button_SearchAdd.UseVisualStyleBackColor = True
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(59, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BNcsv
        '
        Me.BNcsv.AddNewItem = Nothing
        Me.BNcsv.CountItem = Me.BindingNavigatorCountItem
        Me.BNcsv.DeleteItem = Nothing
        Me.BNcsv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BNcsv.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BNcsv.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BNcsv.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BNcsv.Location = New System.Drawing.Point(0, 62)
        Me.BNcsv.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BNcsv.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BNcsv.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BNcsv.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BNcsv.Name = "BNcsv"
        Me.BNcsv.PositionItem = Me.BindingNavigatorPositionItem
        Me.BNcsv.Size = New System.Drawing.Size(542, 25)
        Me.BNcsv.TabIndex = 45
        Me.BNcsv.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'Button_SearchDelete
        '
        Me.Button_SearchDelete.AutoSize = True
        Me.Button_SearchDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SearchDelete.ImageKey = "ZoomOut.png"
        Me.Button_SearchDelete.ImageList = Me.IL
        Me.Button_SearchDelete.Location = New System.Drawing.Point(545, 3)
        Me.Button_SearchDelete.Name = "Button_SearchDelete"
        Me.Button_SearchDelete.Size = New System.Drawing.Size(38, 38)
        Me.Button_SearchDelete.TabIndex = 46
        Me.Button_SearchDelete.UseVisualStyleBackColor = True
        '
        'DGVcsv
        '
        Me.DGVcsv.AllowUserToAddRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVcsv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVcsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVcsv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DGVcsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVcsv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVcsv.GridColor = System.Drawing.Color.DarkGray
        Me.DGVcsv.Location = New System.Drawing.Point(3, 90)
        Me.DGVcsv.MultiSelect = False
        Me.DGVcsv.Name = "DGVcsv"
        Me.DGVcsv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGVcsv.Size = New System.Drawing.Size(536, 358)
        Me.DGVcsv.TabIndex = 44
        '
        'DGV_Search
        '
        Me.DGV_Search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Search.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Search.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DGV_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Search.EnableHeadersVisualStyles = False
        Me.DGV_Search.GridColor = System.Drawing.Color.DarkGray
        Me.DGV_Search.Location = New System.Drawing.Point(3, 3)
        Me.DGV_Search.Name = "DGV_Search"
        Me.DGV_Search.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGV_Search.Size = New System.Drawing.Size(536, 56)
        Me.DGV_Search.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Button_SearchDelete, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DGVcsv, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DGV_Search, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BNcsv, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button_SearchAdd, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 110)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(586, 415)
        Me.TableLayoutPanel1.TabIndex = 46
        '
        'TabPage_Files
        '
        Me.TabPage_Files.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage_Files.Controls.Add(Me.GroupBox_Files)
        Me.TabPage_Files.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Files.Name = "TabPage_Files"
        Me.TabPage_Files.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Files.Size = New System.Drawing.Size(592, 528)
        Me.TabPage_Files.TabIndex = 5
        Me.TabPage_Files.Text = "Daten"
        Me.TabPage_Files.UseVisualStyleBackColor = True
        '
        'TabControl_Default
        '
        Me.TabControl_Default.Controls.Add(Me.TabPage_Paper)
        Me.TabControl_Default.Controls.Add(Me.TabPage_Files)
        Me.TabControl_Default.Controls.Add(Me.TabPage_Table)
        Me.TabControl_Default.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_Default.Location = New System.Drawing.Point(0, 24)
        Me.TabControl_Default.Name = "TabControl_Default"
        Me.TabControl_Default.SelectedIndex = 0
        Me.TabControl_Default.Size = New System.Drawing.Size(600, 554)
        Me.TabControl_Default.TabIndex = 6
        '
        'TabPage_Paper
        '
        Me.TabPage_Paper.AutoScroll = True
        Me.TabPage_Paper.Controls.Add(Me.Panel2)
        Me.TabPage_Paper.Controls.Add(Me.TLP_Main)
        Me.TabPage_Paper.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Paper.Name = "TabPage_Paper"
        Me.TabPage_Paper.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Paper.Size = New System.Drawing.Size(592, 528)
        Me.TabPage_Paper.TabIndex = 0
        Me.TabPage_Paper.Text = "Papier"
        Me.TabPage_Paper.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.PictureBox_Paper)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(223, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(366, 522)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox_Paper
        '
        Me.PictureBox_Paper.BackColor = System.Drawing.Color.FloralWhite
        Me.PictureBox_Paper.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox_Paper.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox_Paper.Name = "PictureBox_Paper"
        Me.PictureBox_Paper.Size = New System.Drawing.Size(68, 53)
        Me.PictureBox_Paper.TabIndex = 45
        Me.PictureBox_Paper.TabStop = False
        '
        'TLP_Main
        '
        Me.TLP_Main.AutoScroll = True
        Me.TLP_Main.AutoSize = True
        Me.TLP_Main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TLP_Main.ColumnCount = 3
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TLP_Main.Controls.Add(Me.GroupBox_Shema, 0, 0)
        Me.TLP_Main.Controls.Add(Me.GroupBox_Paper, 0, 1)
        Me.TLP_Main.Controls.Add(Me.GroupBox_Border, 0, 2)
        Me.TLP_Main.Controls.Add(Me.GroupBox_Separator, 0, 3)
        Me.TLP_Main.Dock = System.Windows.Forms.DockStyle.Left
        Me.TLP_Main.Location = New System.Drawing.Point(3, 3)
        Me.TLP_Main.Margin = New System.Windows.Forms.Padding(0)
        Me.TLP_Main.Name = "TLP_Main"
        Me.TLP_Main.RowCount = 4
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Main.Size = New System.Drawing.Size(220, 522)
        Me.TLP_Main.TabIndex = 44
        '
        'GroupBox_Shema
        '
        Me.TLP_Main.SetColumnSpan(Me.GroupBox_Shema, 2)
        Me.GroupBox_Shema.Controls.Add(Me.TLP_Shema)
        Me.GroupBox_Shema.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox_Shema.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox_Shema.Name = "GroupBox_Shema"
        Me.GroupBox_Shema.Size = New System.Drawing.Size(209, 57)
        Me.GroupBox_Shema.TabIndex = 0
        Me.GroupBox_Shema.TabStop = False
        Me.GroupBox_Shema.Text = "Shema"
        '
        'TLP_Shema
        '
        Me.TLP_Shema.AutoSize = True
        Me.TLP_Shema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TLP_Shema.ColumnCount = 2
        Me.TLP_Shema.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Shema.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Shema.Controls.Add(Me.Label_Shema, 0, 0)
        Me.TLP_Shema.Controls.Add(Me.TextBox_Shema, 1, 0)
        Me.TLP_Shema.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Shema.Location = New System.Drawing.Point(3, 16)
        Me.TLP_Shema.Name = "TLP_Shema"
        Me.TLP_Shema.RowCount = 1
        Me.TLP_Shema.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Shema.Size = New System.Drawing.Size(203, 38)
        Me.TLP_Shema.TabIndex = 0
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
        'TextBox_Shema
        '
        Me.TextBox_Shema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Shema.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox_Shema.Location = New System.Drawing.Point(43, 3)
        Me.TextBox_Shema.Name = "TextBox_Shema"
        Me.TextBox_Shema.Size = New System.Drawing.Size(157, 20)
        Me.TextBox_Shema.TabIndex = 0
        Me.TextBox_Shema.Tag = "String"
        '
        'GroupBox_Paper
        '
        Me.GroupBox_Paper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox_Paper.Controls.Add(Me.TLP_Paper)
        Me.GroupBox_Paper.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox_Paper.Location = New System.Drawing.Point(3, 66)
        Me.GroupBox_Paper.Name = "GroupBox_Paper"
        Me.GroupBox_Paper.Size = New System.Drawing.Size(203, 128)
        Me.GroupBox_Paper.TabIndex = 1
        Me.GroupBox_Paper.TabStop = False
        Me.GroupBox_Paper.Text = "Papier"
        '
        'TLP_Paper
        '
        Me.TLP_Paper.AutoSize = True
        Me.TLP_Paper.ColumnCount = 3
        Me.TLP_Paper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Paper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Paper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TLP_Paper.Controls.Add(Me.Label_PaperWidth_Value, 1, 3)
        Me.TLP_Paper.Controls.Add(Me.CB_DPI, 1, 0)
        Me.TLP_Paper.Controls.Add(Me.Label_PaperHeight_Value, 1, 2)
        Me.TLP_Paper.Controls.Add(Me.Label_PaperWidth, 0, 3)
        Me.TLP_Paper.Controls.Add(Me.Label_PaperHeight, 0, 2)
        Me.TLP_Paper.Controls.Add(Me.Label_DPI, 0, 0)
        Me.TLP_Paper.Controls.Add(Me.Label_DIN, 0, 1)
        Me.TLP_Paper.Controls.Add(Me.CB_DIN, 1, 1)
        Me.TLP_Paper.Controls.Add(Me.Label_PaperHeightEinheit, 2, 2)
        Me.TLP_Paper.Controls.Add(Me.Label_PaperWidthEinheit, 2, 3)
        Me.TLP_Paper.Dock = System.Windows.Forms.DockStyle.Top
        Me.TLP_Paper.Location = New System.Drawing.Point(3, 16)
        Me.TLP_Paper.Name = "TLP_Paper"
        Me.TLP_Paper.RowCount = 4
        Me.TLP_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Paper.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Paper.Size = New System.Drawing.Size(197, 88)
        Me.TLP_Paper.TabIndex = 0
        '
        'Label_PaperWidth_Value
        '
        Me.Label_PaperWidth_Value.AutoSize = True
        Me.Label_PaperWidth_Value.Location = New System.Drawing.Point(43, 71)
        Me.Label_PaperWidth_Value.Name = "Label_PaperWidth_Value"
        Me.Label_PaperWidth_Value.Size = New System.Drawing.Size(39, 13)
        Me.Label_PaperWidth_Value.TabIndex = 47
        Me.Label_PaperWidth_Value.Text = "Label2"
        '
        'CB_DPI
        '
        Me.CB_DPI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_DPI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_DPI.FormattingEnabled = True
        Me.CB_DPI.Location = New System.Drawing.Point(43, 3)
        Me.CB_DPI.Name = "CB_DPI"
        Me.CB_DPI.Size = New System.Drawing.Size(75, 21)
        Me.CB_DPI.TabIndex = 0
        Me.CB_DPI.Tag = "DPI"
        '
        'Label_PaperHeight_Value
        '
        Me.Label_PaperHeight_Value.AutoSize = True
        Me.Label_PaperHeight_Value.Location = New System.Drawing.Point(43, 54)
        Me.Label_PaperHeight_Value.Name = "Label_PaperHeight_Value"
        Me.Label_PaperHeight_Value.Size = New System.Drawing.Size(39, 13)
        Me.Label_PaperHeight_Value.TabIndex = 46
        Me.Label_PaperHeight_Value.Text = "Label1"
        '
        'CB_DIN
        '
        Me.CB_DIN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_DIN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TLP_Paper.SetColumnSpan(Me.CB_DIN, 2)
        Me.CB_DIN.Dock = System.Windows.Forms.DockStyle.Top
        Me.CB_DIN.DropDownWidth = 200
        Me.CB_DIN.FormattingEnabled = True
        Me.CB_DIN.Location = New System.Drawing.Point(43, 30)
        Me.CB_DIN.Name = "CB_DIN"
        Me.CB_DIN.Size = New System.Drawing.Size(151, 21)
        Me.CB_DIN.TabIndex = 1
        Me.CB_DIN.Tag = "DIN"
        '
        'Label_PaperHeightEinheit
        '
        Me.Label_PaperHeightEinheit.AutoSize = True
        Me.Label_PaperHeightEinheit.Location = New System.Drawing.Point(125, 54)
        Me.Label_PaperHeightEinheit.Name = "Label_PaperHeightEinheit"
        Me.Label_PaperHeightEinheit.Size = New System.Drawing.Size(23, 17)
        Me.Label_PaperHeightEinheit.TabIndex = 8
        Me.Label_PaperHeightEinheit.Text = "mm"
        Me.Label_PaperHeightEinheit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_PaperHeightEinheit.UseCompatibleTextRendering = True
        '
        'Label_PaperWidthEinheit
        '
        Me.Label_PaperWidthEinheit.AutoSize = True
        Me.Label_PaperWidthEinheit.Location = New System.Drawing.Point(125, 71)
        Me.Label_PaperWidthEinheit.Name = "Label_PaperWidthEinheit"
        Me.Label_PaperWidthEinheit.Size = New System.Drawing.Size(23, 17)
        Me.Label_PaperWidthEinheit.TabIndex = 9
        Me.Label_PaperWidthEinheit.Text = "mm"
        Me.Label_PaperWidthEinheit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_PaperWidthEinheit.UseCompatibleTextRendering = True
        '
        'GroupBox_Border
        '
        Me.GroupBox_Border.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TLP_Main.SetColumnSpan(Me.GroupBox_Border, 2)
        Me.GroupBox_Border.Controls.Add(Me.TLP_Border)
        Me.GroupBox_Border.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox_Border.Location = New System.Drawing.Point(3, 200)
        Me.GroupBox_Border.Name = "GroupBox_Border"
        Me.GroupBox_Border.Size = New System.Drawing.Size(209, 141)
        Me.GroupBox_Border.TabIndex = 2
        Me.GroupBox_Border.TabStop = False
        Me.GroupBox_Border.Text = "Rahmen"
        '
        'TabPage_Table
        '
        Me.TabPage_Table.Controls.Add(Me.Panel1)
        Me.TabPage_Table.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Table.Name = "TabPage_Table"
        Me.TabPage_Table.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Table.Size = New System.Drawing.Size(592, 528)
        Me.TabPage_Table.TabIndex = 4
        Me.TabPage_Table.Text = "Tabellen"
        Me.TabPage_Table.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DGV_Table)
        Me.Panel1.Controls.Add(Me.ListBox_Tabellen)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 522)
        Me.Panel1.TabIndex = 2
        '
        'DGV_Table
        '
        Me.DGV_Table.AllowUserToAddRows = False
        Me.DGV_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Table.Location = New System.Drawing.Point(143, 0)
        Me.DGV_Table.Name = "DGV_Table"
        Me.DGV_Table.Size = New System.Drawing.Size(443, 522)
        Me.DGV_Table.TabIndex = 0
        '
        'ListBox_Tabellen
        '
        Me.ListBox_Tabellen.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListBox_Tabellen.FormattingEnabled = True
        Me.ListBox_Tabellen.Location = New System.Drawing.Point(0, 0)
        Me.ListBox_Tabellen.Name = "ListBox_Tabellen"
        Me.ListBox_Tabellen.Size = New System.Drawing.Size(143, 522)
        Me.ListBox_Tabellen.TabIndex = 2
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
        'EinfügenToolStripMenuItem
        '
        Me.EinfügenToolStripMenuItem.Image = CType(resources.GetObject("EinfügenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EinfügenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
        Me.EinfügenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.EinfügenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EinfügenToolStripMenuItem.Text = "&Einfügen"
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
        'AusschneidenToolStripMenuItem
        '
        Me.AusschneidenToolStripMenuItem.Image = CType(resources.GetObject("AusschneidenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AusschneidenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AusschneidenToolStripMenuItem.Name = "AusschneidenToolStripMenuItem"
        Me.AusschneidenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.AusschneidenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AusschneidenToolStripMenuItem.Text = "&Ausschneiden"
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
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'SeitenansichtToolStripMenuItem
        '
        Me.SeitenansichtToolStripMenuItem.Image = CType(resources.GetObject("SeitenansichtToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SeitenansichtToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SeitenansichtToolStripMenuItem.Name = "SeitenansichtToolStripMenuItem"
        Me.SeitenansichtToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SeitenansichtToolStripMenuItem.Text = "&Seitenansicht"
        '
        'DruckenToolStripMenuItem
        '
        Me.DruckenToolStripMenuItem.Image = CType(resources.GetObject("DruckenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DruckenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DruckenToolStripMenuItem.Name = "DruckenToolStripMenuItem"
        Me.DruckenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.DruckenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DruckenToolStripMenuItem.Text = "&Drucken"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'SpeichernunterToolStripMenuItem
        '
        Me.SpeichernunterToolStripMenuItem.Name = "SpeichernunterToolStripMenuItem"
        Me.SpeichernunterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SpeichernunterToolStripMenuItem.Text = "Speichern &unter"
        '
        'TSMI_Safe
        '
        Me.TSMI_Safe.Image = CType(resources.GetObject("TSMI_Safe.Image"), System.Drawing.Image)
        Me.TSMI_Safe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSMI_Safe.Name = "TSMI_Safe"
        Me.TSMI_Safe.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.TSMI_Safe.Size = New System.Drawing.Size(180, 22)
        Me.TSMI_Safe.Text = "&Speichern"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(177, 6)
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Image = CType(resources.GetObject("ÖffnenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ÖffnenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Ö&ffnen"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Image = CType(resources.GetObject("NeuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NeuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NeuToolStripMenuItem.Text = "&Neu"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.ÖffnenToolStripMenuItem, Me.toolStripSeparator, Me.TSMI_Safe, Me.SpeichernunterToolStripMenuItem, Me.toolStripSeparator1, Me.DruckenToolStripMenuItem, Me.SeitenansichtToolStripMenuItem, Me.toolStripSeparator2, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RückgängigToolStripMenuItem, Me.WiederholenToolStripMenuItem, Me.toolStripSeparator3, Me.AusschneidenToolStripMenuItem, Me.KopierenToolStripMenuItem, Me.EinfügenToolStripMenuItem, Me.toolStripSeparator4, Me.AlleauswählenToolStripMenuItem})
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BearbeitenToolStripMenuItem.Text = "&Bearbeiten"
        '
        'MS_Main
        '
        Me.MS_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.BearbeitenToolStripMenuItem, Me.ExtrasToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MS_Main.Location = New System.Drawing.Point(0, 0)
        Me.MS_Main.Name = "MS_Main"
        Me.MS_Main.Size = New System.Drawing.Size(600, 24)
        Me.MS_Main.TabIndex = 4
        Me.MS_Main.Text = "MenuStrip1"
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
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
        'StatusStrip_Main
        '
        Me.StatusStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL_IsModified, Me.TSSL_SaveInfo, Me.TSSL_SaveFile})
        Me.StatusStrip_Main.Location = New System.Drawing.Point(0, 578)
        Me.StatusStrip_Main.Name = "StatusStrip_Main"
        Me.StatusStrip_Main.Size = New System.Drawing.Size(600, 22)
        Me.StatusStrip_Main.TabIndex = 5
        Me.StatusStrip_Main.Text = "StatusStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = Global.CSVtoQR.My.MySettings.Default.MySize
        Me.Controls.Add(Me.TabControl_Default)
        Me.Controls.Add(Me.MS_Main)
        Me.Controls.Add(Me.StatusStrip_Main)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.CSVtoQR.My.MySettings.Default, "MyLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.CSVtoQR.My.MySettings.Default, "MyFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ClientSize", Global.CSVtoQR.My.MySettings.Default, "MySize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.CSVtoQR.My.MySettings.Default.MyFont
        Me.Location = Global.CSVtoQR.My.MySettings.Default.MyLocation
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TLP_Separator.ResumeLayout(False)
        Me.TLP_Separator.PerformLayout()
        CType(Me.NUD_SeparatorZeileAnzahl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_SeparatorSpalteAnzahl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_SeparatorSpalteWert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_SeparatorZeileWert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Separator.ResumeLayout(False)
        Me.GroupBox_Separator.PerformLayout()
        Me.TLP_Border.ResumeLayout(False)
        Me.TLP_Border.PerformLayout()
        CType(Me.NUD_CardBorderRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_CardBorderTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_PaperBorderTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_CardBorderBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_PaperBorderBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_PaperBorderLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_CardBorderLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_PaperBorderRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_Files.ResumeLayout(False)
        Me.TLP_Files.PerformLayout()
        Me.GroupBox_Files.ResumeLayout(False)
        Me.GroupBox_Files.PerformLayout()
        CType(Me.BNcsv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BNcsv.ResumeLayout(False)
        Me.BNcsv.PerformLayout()
        CType(Me.DGVcsv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPage_Files.ResumeLayout(False)
        Me.TabControl_Default.ResumeLayout(False)
        Me.TabPage_Paper.ResumeLayout(False)
        Me.TabPage_Paper.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox_Paper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_Main.ResumeLayout(False)
        Me.GroupBox_Shema.ResumeLayout(False)
        Me.GroupBox_Shema.PerformLayout()
        Me.TLP_Shema.ResumeLayout(False)
        Me.TLP_Shema.PerformLayout()
        Me.GroupBox_Paper.ResumeLayout(False)
        Me.GroupBox_Paper.PerformLayout()
        Me.TLP_Paper.ResumeLayout(False)
        Me.TLP_Paper.PerformLayout()
        Me.GroupBox_Border.ResumeLayout(False)
        Me.GroupBox_Border.PerformLayout()
        Me.TabPage_Table.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MS_Main.ResumeLayout(False)
        Me.MS_Main.PerformLayout()
        Me.StatusStrip_Main.ResumeLayout(False)
        Me.StatusStrip_Main.PerformLayout()
        CType(Me.BScsv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_BorderCard As Label
    Friend WithEvents Label_SeparatorZeile As Label
    Friend WithEvents Label_SeparatorAnzahl As Label
    Friend WithEvents Label_SeparatorWert As Label
    Friend WithEvents TLP_Separator As TableLayoutPanel
    Friend WithEvents Label_SeparatorSpalte As Label
    Friend WithEvents GroupBox_Separator As GroupBox
    Friend WithEvents TLP_Main As TableLayoutPanel
    Friend WithEvents GroupBox_Shema As GroupBox
    Friend WithEvents TLP_Shema As TableLayoutPanel
    Friend WithEvents Label_Shema As Label
    Friend WithEvents TextBox_Shema As TextBox
    Friend WithEvents GroupBox_Paper As GroupBox
    Friend WithEvents TLP_Paper As TableLayoutPanel
    Friend WithEvents Label_PaperWidth As Label
    Friend WithEvents Label_PaperHeight As Label
    Friend WithEvents Label_DPI As Label
    Friend WithEvents Label_DIN As Label
    Friend WithEvents CB_DIN As ComboBox
    Friend WithEvents Label_PaperHeightEinheit As Label
    Friend WithEvents Label_PaperWidthEinheit As Label
    Friend WithEvents GroupBox_Border As GroupBox
    Friend WithEvents TLP_Border As TableLayoutPanel
    Friend WithEvents Label_BorderPaper As Label
    Friend WithEvents Label_Left As Label
    Friend WithEvents Label_Bottom As Label
    Friend WithEvents Label_Top As Label
    Friend WithEvents Label_Right As Label
    Friend WithEvents FD As FontDialog
    Friend WithEvents Label_Import As Label
    Friend WithEvents TextBox_Import As TextBox
    Friend WithEvents Label_Export As Label
    Friend WithEvents TextBox_Export As TextBox
    Friend WithEvents Button_Import As Button
    Friend WithEvents IL As ImageList
    Friend WithEvents Button_Export As Button
    Friend WithEvents TLP_Files As TableLayoutPanel
    Friend WithEvents GroupBox_Files As GroupBox
    Friend WithEvents Button_SearchAdd As Button
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BNcsv As BindingNavigator
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents Button_SearchDelete As Button
    Friend WithEvents DGVcsv As DataGridView
    Friend WithEvents DGV_Search As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabPage_Files As TabPage
    Friend WithEvents TabControl_Default As TabControl
    Friend WithEvents TabPage_Paper As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox_Paper As PictureBox
    Friend WithEvents TabPage_Table As TabPage
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents SpeichernunterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMI_Safe As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents ÖffnenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MS_Main As MenuStrip
    Friend WithEvents BScsv As BindingSource
    Friend WithEvents SFD As SaveFileDialog
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents TSSL_SaveFile As ToolStripStatusLabel
    Friend WithEvents TSSL_SaveInfo As ToolStripStatusLabel
    Friend WithEvents TSSL_IsModified As ToolStripStatusLabel
    Friend WithEvents StatusStrip_Main As StatusStrip
    Friend WithEvents NUD_PaperBorderLeft As NumericUpDown
    Friend WithEvents NUD_CardBorderLeft As NumericUpDown
    Friend WithEvents NUD_CardBorderRight As NumericUpDown
    Friend WithEvents NUD_CardBorderTop As NumericUpDown
    Friend WithEvents NUD_PaperBorderTop As NumericUpDown
    Friend WithEvents NUD_PaperBorderRight As NumericUpDown
    Friend WithEvents NUD_SeparatorSpalteAnzahl As NumericUpDown
    Friend WithEvents NUD_SeparatorZeileAnzahl As NumericUpDown
    Friend WithEvents NUD_PaperBorderBottom As NumericUpDown
    Friend WithEvents NUD_CardBorderBottom As NumericUpDown
    Friend WithEvents NUD_SeparatorSpalteWert As NumericUpDown
    Friend WithEvents NUD_SeparatorZeileWert As NumericUpDown
    Friend WithEvents CB_DPI As ComboBox
    Friend WithEvents Label_PaperWidth_Value As Label
    Friend WithEvents Label_PaperHeight_Value As Label
End Class
