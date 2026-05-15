<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Files
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.TableLayoutPanel_General_XML = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox_General_XML_Filename = New System.Windows.Forms.TextBox()
        Me.Label_General_XML_Filname = New System.Windows.Forms.Label()
        Me.Button_General_XML_Open = New System.Windows.Forms.Button()
        Me.TextBox_General_XML_Directory = New System.Windows.Forms.TextBox()
        Me.Label_General_XML_Directory = New System.Windows.Forms.Label()
        Me.Label_Header = New System.Windows.Forms.Label()
        Me.TableLayoutPanel_General_XML.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel_General_XML
        '
        Me.TableLayoutPanel_General_XML.AutoSize = True
        Me.TableLayoutPanel_General_XML.ColumnCount = 3
        Me.TableLayoutPanel_General_XML.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_General_XML.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_General_XML.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_General_XML.Controls.Add(Me.TextBox_General_XML_Filename, 1, 2)
        Me.TableLayoutPanel_General_XML.Controls.Add(Me.Label_General_XML_Filname, 0, 2)
        Me.TableLayoutPanel_General_XML.Controls.Add(Me.Button_General_XML_Open, 2, 1)
        Me.TableLayoutPanel_General_XML.Controls.Add(Me.TextBox_General_XML_Directory, 1, 1)
        Me.TableLayoutPanel_General_XML.Controls.Add(Me.Label_General_XML_Directory, 0, 1)
        Me.TableLayoutPanel_General_XML.Controls.Add(Me.Label_Header, 0, 0)
        Me.TableLayoutPanel_General_XML.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_General_XML.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel_General_XML.Name = "TableLayoutPanel_General_XML"
        Me.TableLayoutPanel_General_XML.RowCount = 3
        Me.TableLayoutPanel_General_XML.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_General_XML.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_General_XML.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_General_XML.Size = New System.Drawing.Size(203, 57)
        Me.TableLayoutPanel_General_XML.TabIndex = 1
        '
        'TextBox_General_XML_Filename
        '
        Me.TextBox_General_XML_Filename.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox_General_XML_Filename.Location = New System.Drawing.Point(59, 33)
        Me.TextBox_General_XML_Filename.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox_General_XML_Filename.Name = "TextBox_General_XML_Filename"
        Me.TextBox_General_XML_Filename.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_General_XML_Filename.TabIndex = 12
        '
        'Label_General_XML_Filname
        '
        Me.Label_General_XML_Filname.AutoSize = True
        Me.Label_General_XML_Filname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_General_XML_Filname.Location = New System.Drawing.Point(0, 33)
        Me.Label_General_XML_Filname.Margin = New System.Windows.Forms.Padding(0)
        Me.Label_General_XML_Filname.Name = "Label_General_XML_Filname"
        Me.Label_General_XML_Filname.Size = New System.Drawing.Size(59, 24)
        Me.Label_General_XML_Filname.TabIndex = 11
        Me.Label_General_XML_Filname.Text = "Dateiname"
        Me.Label_General_XML_Filname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_General_XML_Filname.UseCompatibleTextRendering = True
        '
        'Button_General_XML_Open
        '
        Me.Button_General_XML_Open.AutoSize = True
        Me.Button_General_XML_Open.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_General_XML_Open.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_General_XML_Open.ImageKey = "DatabaseSchema"
        Me.Button_General_XML_Open.Location = New System.Drawing.Point(162, 16)
        Me.Button_General_XML_Open.Name = "Button_General_XML_Open"
        Me.TableLayoutPanel_General_XML.SetRowSpan(Me.Button_General_XML_Open, 2)
        Me.Button_General_XML_Open.Size = New System.Drawing.Size(38, 38)
        Me.Button_General_XML_Open.TabIndex = 10
        Me.Button_General_XML_Open.UseVisualStyleBackColor = True
        '
        'TextBox_General_XML_Directory
        '
        Me.TextBox_General_XML_Directory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox_General_XML_Directory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.TextBox_General_XML_Directory.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox_General_XML_Directory.Location = New System.Drawing.Point(59, 13)
        Me.TextBox_General_XML_Directory.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox_General_XML_Directory.Name = "TextBox_General_XML_Directory"
        Me.TextBox_General_XML_Directory.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_General_XML_Directory.TabIndex = 9
        Me.TextBox_General_XML_Directory.Tag = "Export"
        '
        'Label_General_XML_Directory
        '
        Me.Label_General_XML_Directory.AutoSize = True
        Me.Label_General_XML_Directory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_General_XML_Directory.Location = New System.Drawing.Point(0, 13)
        Me.Label_General_XML_Directory.Margin = New System.Windows.Forms.Padding(0)
        Me.Label_General_XML_Directory.Name = "Label_General_XML_Directory"
        Me.Label_General_XML_Directory.Size = New System.Drawing.Size(59, 20)
        Me.Label_General_XML_Directory.TabIndex = 8
        Me.Label_General_XML_Directory.Text = "Ordner"
        Me.Label_General_XML_Directory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_General_XML_Directory.UseCompatibleTextRendering = True
        '
        'Label_Header
        '
        Me.Label_Header.AutoSize = True
        Me.TableLayoutPanel_General_XML.SetColumnSpan(Me.Label_Header, 3)
        Me.Label_Header.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Header.Location = New System.Drawing.Point(3, 0)
        Me.Label_Header.Name = "Label_Header"
        Me.Label_Header.Size = New System.Drawing.Size(197, 13)
        Me.Label_Header.TabIndex = 13
        Me.Label_Header.Text = "Label1"
        '
        'UserControl_Files
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.TableLayoutPanel_General_XML)
        Me.Name = "UserControl_Files"
        Me.Size = New System.Drawing.Size(203, 57)
        Me.TableLayoutPanel_General_XML.ResumeLayout(False)
        Me.TableLayoutPanel_General_XML.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel_General_XML As TableLayoutPanel
    Friend WithEvents TextBox_General_XML_Filename As TextBox
    Friend WithEvents Label_General_XML_Filname As Label
    Friend WithEvents Button_General_XML_Open As Button
    Friend WithEvents TextBox_General_XML_Directory As TextBox
    Friend WithEvents Label_General_XML_Directory As Label
    Friend WithEvents Label_Header As Label
End Class
