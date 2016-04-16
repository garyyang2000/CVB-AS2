<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbOrderNumber = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.dtShipDate = New System.Windows.Forms.DateTimePicker()
        Me.listOrderItems = New System.Windows.Forms.ListView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Number:"
        '
        'lbOrderNumber
        '
        Me.lbOrderNumber.AutoSize = True
        Me.lbOrderNumber.Location = New System.Drawing.Point(95, 13)
        Me.lbOrderNumber.Name = "lbOrderNumber"
        Me.lbOrderNumber.Size = New System.Drawing.Size(78, 13)
        Me.lbOrderNumber.TabIndex = 1
        Me.lbOrderNumber.Text = "lbOrderNumber"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Order Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ship Date:"
        '
        'dtOrderDate
        '
        Me.dtOrderDate.Location = New System.Drawing.Point(98, 39)
        Me.dtOrderDate.Name = "dtOrderDate"
        Me.dtOrderDate.Size = New System.Drawing.Size(200, 20)
        Me.dtOrderDate.TabIndex = 4
        '
        'dtShipDate
        '
        Me.dtShipDate.Location = New System.Drawing.Point(98, 65)
        Me.dtShipDate.Name = "dtShipDate"
        Me.dtShipDate.Size = New System.Drawing.Size(200, 20)
        Me.dtShipDate.TabIndex = 5
        '
        'listOrderItems
        '
        Me.listOrderItems.FullRowSelect = True
        Me.listOrderItems.GridLines = True
        Me.listOrderItems.Location = New System.Drawing.Point(19, 110)
        Me.listOrderItems.MultiSelect = False
        Me.listOrderItems.Name = "listOrderItems"
        Me.listOrderItems.Size = New System.Drawing.Size(269, 117)
        Me.listOrderItems.TabIndex = 6
        Me.listOrderItems.UseCompatibleStateImageBehavior = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Order Items:"
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(19, 233)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnAddProduct.TabIndex = 8
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 261)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.listOrderItems)
        Me.Controls.Add(Me.dtShipDate)
        Me.Controls.Add(Me.dtOrderDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbOrderNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOrder"
        Me.Text = "Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbOrderNumber As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtOrderDate As DateTimePicker
    Friend WithEvents dtShipDate As DateTimePicker
    Friend WithEvents listOrderItems As ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAddProduct As Button
End Class
