<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Font
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
        Me.Button_Font = New System.Windows.Forms.Button()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.Label_Size = New System.Windows.Forms.Label()
        Me.Label_Style = New System.Windows.Forms.Label()
        Me.Label_Name_Value = New System.Windows.Forms.Label()
        Me.Label_Size_Value = New System.Windows.Forms.Label()
        Me.Label_Style_Value = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Header = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Font
        '
        Me.Button_Font.BackgroundImage = Global.CSVtoQR.My.Resources.Resources.Font
        Me.Button_Font.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button_Font.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Font.ImageKey = "Font"
        Me.Button_Font.Location = New System.Drawing.Point(127, 23)
        Me.Button_Font.Name = "Button_Font"
        Me.TableLayoutPanel1.SetRowSpan(Me.Button_Font, 3)
        Me.Button_Font.Size = New System.Drawing.Size(40, 40)
        Me.Button_Font.TabIndex = 8
        Me.Button_Font.UseCompatibleTextRendering = True
        Me.Button_Font.UseVisualStyleBackColor = True
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Name.Location = New System.Drawing.Point(3, 20)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(36, 17)
        Me.Label_Name.TabIndex = 9
        Me.Label_Name.Text = "Name"
        Me.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Name.UseCompatibleTextRendering = True
        '
        'Label_Size
        '
        Me.Label_Size.AutoSize = True
        Me.Label_Size.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Size.Location = New System.Drawing.Point(3, 37)
        Me.Label_Size.Name = "Label_Size"
        Me.Label_Size.Size = New System.Drawing.Size(36, 17)
        Me.Label_Size.TabIndex = 10
        Me.Label_Size.Text = "Größe"
        Me.Label_Size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Size.UseCompatibleTextRendering = True
        '
        'Label_Style
        '
        Me.Label_Style.AutoSize = True
        Me.Label_Style.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Style.Location = New System.Drawing.Point(3, 54)
        Me.Label_Style.Name = "Label_Style"
        Me.Label_Style.Size = New System.Drawing.Size(36, 17)
        Me.Label_Style.TabIndex = 11
        Me.Label_Style.Text = "Style"
        Me.Label_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Style.UseCompatibleTextRendering = True
        '
        'Label_Name_Value
        '
        Me.Label_Name_Value.AutoSize = True
        Me.Label_Name_Value.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Name_Value.Location = New System.Drawing.Point(45, 20)
        Me.Label_Name_Value.Name = "Label_Name_Value"
        Me.Label_Name_Value.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Label_Name_Value.Size = New System.Drawing.Size(76, 17)
        Me.Label_Name_Value.TabIndex = 13
        Me.Label_Name_Value.Text = "Name_Value"
        Me.Label_Name_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Name_Value.UseCompatibleTextRendering = True
        '
        'Label_Size_Value
        '
        Me.Label_Size_Value.AutoSize = True
        Me.Label_Size_Value.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Size_Value.Location = New System.Drawing.Point(45, 37)
        Me.Label_Size_Value.Name = "Label_Size_Value"
        Me.Label_Size_Value.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Label_Size_Value.Size = New System.Drawing.Size(76, 17)
        Me.Label_Size_Value.TabIndex = 14
        Me.Label_Size_Value.Text = "Size_Value"
        Me.Label_Size_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Size_Value.UseCompatibleTextRendering = True
        '
        'Label_Style_Value
        '
        Me.Label_Style_Value.AutoSize = True
        Me.Label_Style_Value.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Style_Value.Location = New System.Drawing.Point(45, 54)
        Me.Label_Style_Value.Name = "Label_Style_Value"
        Me.Label_Style_Value.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Label_Style_Value.Size = New System.Drawing.Size(76, 17)
        Me.Label_Style_Value.TabIndex = 15
        Me.Label_Style_Value.Text = "Style_Value"
        Me.Label_Style_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Style_Value.UseCompatibleTextRendering = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Button_Font, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Style_Value, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Name, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Size_Value, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Style, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Name_Value, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Size, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Header, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 71)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'Label_Header
        '
        Me.Label_Header.AutoSize = True
        Me.Label_Header.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label_Header, 3)
        Me.Label_Header.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.CSVtoQR.My.MySettings.Default, "MyFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label_Header.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Header.Font = Global.CSVtoQR.My.MySettings.Default.MyFont
        Me.Label_Header.Location = New System.Drawing.Point(3, 0)
        Me.Label_Header.Name = "Label_Header"
        Me.Label_Header.Size = New System.Drawing.Size(164, 20)
        Me.Label_Header.TabIndex = 16
        Me.Label_Header.Text = "Schriftart"
        Me.Label_Header.UseCompatibleTextRendering = True
        '
        'UserControl_Font
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.CSVtoQR.My.MySettings.Default, "MyFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.CSVtoQR.My.MySettings.Default.MyFont
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "UserControl_Font"
        Me.Size = New System.Drawing.Size(170, 71)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Font As Button
    Friend WithEvents Label_Name As Label
    Friend WithEvents Label_Size As Label
    Friend WithEvents Label_Style As Label
    Friend WithEvents Label_Name_Value As Label
    Friend WithEvents Label_Size_Value As Label
    Friend WithEvents Label_Style_Value As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label_Header As Label
End Class
