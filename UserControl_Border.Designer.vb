<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Border
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
        Me.TableLayoutPanel_Border = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Right_Unit = New System.Windows.Forms.Label()
        Me.Label_Top_Unit = New System.Windows.Forms.Label()
        Me.Label_Bottom_Unit = New System.Windows.Forms.Label()
        Me.Label_Left = New System.Windows.Forms.Label()
        Me.Label_Right = New System.Windows.Forms.Label()
        Me.Label_Top = New System.Windows.Forms.Label()
        Me.NumericUpDown_Left = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Right = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Top = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Bottom = New System.Windows.Forms.NumericUpDown()
        Me.Label_Bottom = New System.Windows.Forms.Label()
        Me.Label_Left_Unit = New System.Windows.Forms.Label()
        Me.Label_Header = New System.Windows.Forms.Label()
        Me.TableLayoutPanel_Border.SuspendLayout()
        CType(Me.NumericUpDown_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel_Border
        '
        Me.TableLayoutPanel_Border.AutoSize = True
        Me.TableLayoutPanel_Border.ColumnCount = 3
        Me.TableLayoutPanel_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Border.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Border.Controls.Add(Me.Label_Right_Unit, 2, 2)
        Me.TableLayoutPanel_Border.Controls.Add(Me.Label_Top_Unit, 2, 3)
        Me.TableLayoutPanel_Border.Controls.Add(Me.Label_Bottom_Unit, 2, 4)
        Me.TableLayoutPanel_Border.Controls.Add(Me.Label_Left, 0, 1)
        Me.TableLayoutPanel_Border.Controls.Add(Me.Label_Right, 0, 2)
        Me.TableLayoutPanel_Border.Controls.Add(Me.Label_Top, 0, 3)
        Me.TableLayoutPanel_Border.Controls.Add(Me.NumericUpDown_Left, 1, 1)
        Me.TableLayoutPanel_Border.Controls.Add(Me.NumericUpDown_Right, 1, 2)
        Me.TableLayoutPanel_Border.Controls.Add(Me.NumericUpDown_Top, 1, 3)
        Me.TableLayoutPanel_Border.Controls.Add(Me.NumericUpDown_Bottom, 1, 4)
        Me.TableLayoutPanel_Border.Controls.Add(Me.Label_Bottom, 0, 4)
        Me.TableLayoutPanel_Border.Controls.Add(Me.Label_Left_Unit, 2, 1)
        Me.TableLayoutPanel_Border.Controls.Add(Me.Label_Header, 0, 0)
        Me.TableLayoutPanel_Border.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_Border.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel_Border.Name = "TableLayoutPanel_Border"
        Me.TableLayoutPanel_Border.RowCount = 5
        Me.TableLayoutPanel_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Border.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Border.Size = New System.Drawing.Size(153, 130)
        Me.TableLayoutPanel_Border.TabIndex = 47
        '
        'Label_Right_Unit
        '
        Me.Label_Right_Unit.AutoSize = True
        Me.Label_Right_Unit.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Right_Unit.Location = New System.Drawing.Point(127, 55)
        Me.Label_Right_Unit.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Right_Unit.Name = "Label_Right_Unit"
        Me.Label_Right_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Right_Unit.TabIndex = 46
        Me.Label_Right_Unit.Text = "mm"
        Me.Label_Right_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Right_Unit.UseCompatibleTextRendering = True
        '
        'Label_Top_Unit
        '
        Me.Label_Top_Unit.AutoSize = True
        Me.Label_Top_Unit.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Top_Unit.Location = New System.Drawing.Point(127, 81)
        Me.Label_Top_Unit.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Top_Unit.Name = "Label_Top_Unit"
        Me.Label_Top_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Top_Unit.TabIndex = 46
        Me.Label_Top_Unit.Text = "mm"
        Me.Label_Top_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Top_Unit.UseCompatibleTextRendering = True
        '
        'Label_Bottom_Unit
        '
        Me.Label_Bottom_Unit.AutoSize = True
        Me.Label_Bottom_Unit.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Bottom_Unit.Location = New System.Drawing.Point(127, 107)
        Me.Label_Bottom_Unit.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Bottom_Unit.Name = "Label_Bottom_Unit"
        Me.Label_Bottom_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Bottom_Unit.TabIndex = 46
        Me.Label_Bottom_Unit.Text = "mm"
        Me.Label_Bottom_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Bottom_Unit.UseCompatibleTextRendering = True
        '
        'Label_Left
        '
        Me.Label_Left.AutoSize = True
        Me.Label_Left.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Left.Location = New System.Drawing.Point(3, 29)
        Me.Label_Left.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Left.Name = "Label_Left"
        Me.Label_Left.Size = New System.Drawing.Size(39, 17)
        Me.Label_Left.TabIndex = 1
        Me.Label_Left.Text = "Links"
        Me.Label_Left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Left.UseCompatibleTextRendering = True
        '
        'Label_Right
        '
        Me.Label_Right.AutoSize = True
        Me.Label_Right.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Right.Location = New System.Drawing.Point(3, 55)
        Me.Label_Right.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Right.Name = "Label_Right"
        Me.Label_Right.Size = New System.Drawing.Size(39, 17)
        Me.Label_Right.TabIndex = 3
        Me.Label_Right.Text = "Rechts"
        Me.Label_Right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Right.UseCompatibleTextRendering = True
        '
        'Label_Top
        '
        Me.Label_Top.AutoSize = True
        Me.Label_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Top.Location = New System.Drawing.Point(3, 81)
        Me.Label_Top.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Top.Name = "Label_Top"
        Me.Label_Top.Size = New System.Drawing.Size(39, 17)
        Me.Label_Top.TabIndex = 5
        Me.Label_Top.Text = "Oben"
        Me.Label_Top.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Top.UseCompatibleTextRendering = True
        '
        'NumericUpDown_Left
        '
        Me.NumericUpDown_Left.DecimalPlaces = 1
        Me.NumericUpDown_Left.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumericUpDown_Left.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_Left.Location = New System.Drawing.Point(48, 29)
        Me.NumericUpDown_Left.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NumericUpDown_Left.Name = "NumericUpDown_Left"
        Me.NumericUpDown_Left.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_Left.TabIndex = 1
        Me.NumericUpDown_Left.Tag = "Paper;Left"
        Me.NumericUpDown_Left.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumericUpDown_Right
        '
        Me.NumericUpDown_Right.DecimalPlaces = 1
        Me.NumericUpDown_Right.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumericUpDown_Right.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_Right.Location = New System.Drawing.Point(48, 55)
        Me.NumericUpDown_Right.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NumericUpDown_Right.Name = "NumericUpDown_Right"
        Me.NumericUpDown_Right.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_Right.TabIndex = 2
        Me.NumericUpDown_Right.Tag = "Paper;Right"
        Me.NumericUpDown_Right.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumericUpDown_Top
        '
        Me.NumericUpDown_Top.DecimalPlaces = 1
        Me.NumericUpDown_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumericUpDown_Top.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_Top.Location = New System.Drawing.Point(48, 81)
        Me.NumericUpDown_Top.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NumericUpDown_Top.Name = "NumericUpDown_Top"
        Me.NumericUpDown_Top.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_Top.TabIndex = 3
        Me.NumericUpDown_Top.Tag = "Paper;Top"
        Me.NumericUpDown_Top.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumericUpDown_Bottom
        '
        Me.NumericUpDown_Bottom.DecimalPlaces = 1
        Me.NumericUpDown_Bottom.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumericUpDown_Bottom.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_Bottom.Location = New System.Drawing.Point(48, 107)
        Me.NumericUpDown_Bottom.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NumericUpDown_Bottom.Name = "NumericUpDown_Bottom"
        Me.NumericUpDown_Bottom.Size = New System.Drawing.Size(73, 20)
        Me.NumericUpDown_Bottom.TabIndex = 4
        Me.NumericUpDown_Bottom.Tag = "Paper;Bottom"
        Me.NumericUpDown_Bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_Bottom
        '
        Me.Label_Bottom.AutoSize = True
        Me.Label_Bottom.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Bottom.Location = New System.Drawing.Point(3, 107)
        Me.Label_Bottom.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Bottom.Name = "Label_Bottom"
        Me.Label_Bottom.Size = New System.Drawing.Size(39, 17)
        Me.Label_Bottom.TabIndex = 7
        Me.Label_Bottom.Text = "Unten"
        Me.Label_Bottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Bottom.UseCompatibleTextRendering = True
        '
        'Label_Left_Unit
        '
        Me.Label_Left_Unit.AutoSize = True
        Me.Label_Left_Unit.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Left_Unit.Location = New System.Drawing.Point(127, 29)
        Me.Label_Left_Unit.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Left_Unit.Name = "Label_Left_Unit"
        Me.Label_Left_Unit.Size = New System.Drawing.Size(23, 17)
        Me.Label_Left_Unit.TabIndex = 46
        Me.Label_Left_Unit.Text = "mm"
        Me.Label_Left_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_Left_Unit.UseCompatibleTextRendering = True
        '
        'Label_Header
        '
        Me.Label_Header.AutoSize = True
        Me.Label_Header.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TableLayoutPanel_Border.SetColumnSpan(Me.Label_Header, 3)
        Me.Label_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Header.Location = New System.Drawing.Point(3, 3)
        Me.Label_Header.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_Header.Name = "Label_Header"
        Me.Label_Header.Size = New System.Drawing.Size(147, 20)
        Me.Label_Header.TabIndex = 47
        Me.Label_Header.Text = "Rahmen"
        Me.Label_Header.UseCompatibleTextRendering = True
        '
        'UserControl_Border
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.TableLayoutPanel_Border)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "UserControl_Border"
        Me.Size = New System.Drawing.Size(153, 130)
        Me.TableLayoutPanel_Border.ResumeLayout(False)
        Me.TableLayoutPanel_Border.PerformLayout()
        CType(Me.NumericUpDown_Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Bottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel_Border As TableLayoutPanel
    Friend WithEvents Label_Right_Unit As Label
    Friend WithEvents Label_Top_Unit As Label
    Friend WithEvents Label_Bottom_Unit As Label
    Friend WithEvents Label_Left As Label
    Friend WithEvents Label_Right As Label
    Friend WithEvents Label_Top As Label
    Friend WithEvents NumericUpDown_Left As NumericUpDown
    Friend WithEvents NumericUpDown_Right As NumericUpDown
    Friend WithEvents NumericUpDown_Top As NumericUpDown
    Friend WithEvents NumericUpDown_Bottom As NumericUpDown
    Friend WithEvents Label_Bottom As Label
    Friend WithEvents Label_Left_Unit As Label
    Friend WithEvents Label_Header As Label
End Class
