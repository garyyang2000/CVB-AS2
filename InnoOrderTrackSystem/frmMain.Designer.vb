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
        Me.btnCustomerList = New System.Windows.Forms.Button()
        Me.btnOrderList = New System.Windows.Forms.Button()
        Me.btnProductList = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listData
        '
        Me.listData.FullRowSelect = True
        Me.listData.GridLines = True
        Me.listData.Location = New System.Drawing.Point(8, 56)
        Me.listData.Margin = New System.Windows.Forms.Padding(2)
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
        'btnCustomerList
        '
        Me.btnCustomerList.Location = New System.Drawing.Point(9, 27)
        Me.btnCustomerList.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCustomerList.Name = "btnCustomerList"
        Me.btnCustomerList.Size = New System.Drawing.Size(78, 25)
        Me.btnCustomerList.TabIndex = 2
        Me.btnCustomerList.Text = "Customer"
        Me.btnCustomerList.UseVisualStyleBackColor = True
        '
        'btnOrderList
        '
        Me.btnOrderList.Location = New System.Drawing.Point(105, 27)
        Me.btnOrderList.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrderList.Name = "btnOrderList"
        Me.btnOrderList.Size = New System.Drawing.Size(64, 25)
        Me.btnOrderList.TabIndex = 3
        Me.btnOrderList.Text = "Order"
        Me.btnOrderList.UseVisualStyleBackColor = True
        '
        'btnProductList
        '
        Me.btnProductList.Location = New System.Drawing.Point(193, 27)
        Me.btnProductList.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProductList.Name = "btnProductList"
        Me.btnProductList.Size = New System.Drawing.Size(68, 25)
        Me.btnProductList.TabIndex = 4
        Me.btnProductList.Text = "Product"
        Me.btnProductList.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 347)
        Me.Controls.Add(Me.btnProductList)
        Me.Controls.Add(Me.btnOrderList)
        Me.Controls.Add(Me.btnCustomerList)
        Me.Controls.Add(Me.listData)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.Text = "CVB-Assignment2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCustomerList As Button
    Friend WithEvents btnOrderList As Button
    Friend WithEvents btnProductList As Button
    Friend WithEvents ProductSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents listData As ListView
End Class
