<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.listData = New System.Windows.Forms.ListView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listData
        '
        Me.listData.FullRowSelect = True
        Me.listData.GridLines = True
        Me.listData.Location = New System.Drawing.Point(8, 56)
        Me.listData.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.listData.MultiSelect = False
        Me.listData.Name = "listData"
        Me.listData.Size = New System.Drawing.Size(430, 283)
        Me.listData.TabIndex = 0
        Me.listData.UseCompatibleStateImageBehavior = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(445, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerSearchToolStripMenuItem, Me.OrderSearchToolStripMenuItem, Me.ProductSearchToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(54, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'CustomerSearchToolStripMenuItem
        '
        Me.CustomerSearchToolStripMenuItem.Name = "CustomerSearchToolStripMenuItem"
        Me.CustomerSearchToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CustomerSearchToolStripMenuItem.Text = "Customer Search"
        '
        'OrderSearchToolStripMenuItem
        '
        Me.OrderSearchToolStripMenuItem.Name = "OrderSearchToolStripMenuItem"
        Me.OrderSearchToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.OrderSearchToolStripMenuItem.Text = "Order Search"
        '
        'ProductSearchToolStripMenuItem
        '
        Me.ProductSearchToolStripMenuItem.Name = "ProductSearchToolStripMenuItem"
        Me.ProductSearchToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ProductSearchToolStripMenuItem.Text = "Product Search"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 27)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Customer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(105, 27)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 25)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Order"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(193, 27)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 25)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Product"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 347)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.listData)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "CVB-Assignment2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ProductSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents listData As ListView
End Class
