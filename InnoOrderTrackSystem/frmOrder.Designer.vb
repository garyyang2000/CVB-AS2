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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.dgvOrderItems = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbCustomer = New System.Windows.Forms.Label()
        Me.lbCustAddress = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label3.Location = New System.Drawing.Point(13, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Order Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ship Date:"
        '
        'dtOrderDate
        '
        Me.dtOrderDate.Location = New System.Drawing.Point(98, 65)
        Me.dtOrderDate.Name = "dtOrderDate"
        Me.dtOrderDate.Size = New System.Drawing.Size(200, 20)
        Me.dtOrderDate.TabIndex = 4
        '
        'dtShipDate
        '
        Me.dtShipDate.Location = New System.Drawing.Point(98, 91)
        Me.dtShipDate.Name = "dtShipDate"
        Me.dtShipDate.Size = New System.Drawing.Size(200, 20)
        Me.dtShipDate.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Order Items:"
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(223, 288)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnAddProduct.TabIndex = 8
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'dgvOrderItems
        '
        Me.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderItems.Location = New System.Drawing.Point(16, 132)
        Me.dgvOrderItems.MultiSelect = False
        Me.dgvOrderItems.Name = "dgvOrderItems"
        Me.dgvOrderItems.ReadOnly = True
        Me.dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrderItems.Size = New System.Drawing.Size(483, 150)
        Me.dgvOrderItems.TabIndex = 9
        '
        'btnUpdate
        '
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnUpdate.Location = New System.Drawing.Point(321, 288)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(424, 288)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Customer:"
        '
        'lbCustomer
        '
        Me.lbCustomer.AutoSize = True
        Me.lbCustomer.Location = New System.Drawing.Point(98, 37)
        Me.lbCustomer.Name = "lbCustomer"
        Me.lbCustomer.Size = New System.Drawing.Size(39, 13)
        Me.lbCustomer.TabIndex = 13
        Me.lbCustomer.Text = "Label6"
        '
        'lbCustAddress
        '
        Me.lbCustAddress.AutoSize = True
        Me.lbCustAddress.Location = New System.Drawing.Point(274, 37)
        Me.lbCustAddress.Name = "lbCustAddress"
        Me.lbCustAddress.Size = New System.Drawing.Size(39, 13)
        Me.lbCustAddress.TabIndex = 14
        Me.lbCustAddress.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(220, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Address:"
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 333)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbCustAddress)
        Me.Controls.Add(Me.lbCustomer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dgvOrderItems)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtShipDate)
        Me.Controls.Add(Me.dtOrderDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbOrderNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOrder"
        Me.Text = "Order"
        CType(Me.dgvOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbOrderNumber As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtOrderDate As DateTimePicker
    Friend WithEvents dtShipDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents dgvOrderItems As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbCustomer As Label
    Friend WithEvents lbCustAddress As Label
    Friend WithEvents Label7 As Label
End Class
