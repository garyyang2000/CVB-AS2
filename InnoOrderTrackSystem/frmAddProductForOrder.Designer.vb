<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddProductForOrder
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
        Me.dgpSelectProduct = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtNuberOrdered = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.lbDesc = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbProductId = New System.Windows.Forms.Label()
        CType(Me.dgpSelectProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Number"
        '
        'lbOrderNumber
        '
        Me.lbOrderNumber.AutoSize = True
        Me.lbOrderNumber.Location = New System.Drawing.Point(104, 13)
        Me.lbOrderNumber.Name = "lbOrderNumber"
        Me.lbOrderNumber.Size = New System.Drawing.Size(0, 13)
        Me.lbOrderNumber.TabIndex = 2
        '
        'dgpSelectProduct
        '
        Me.dgpSelectProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpSelectProduct.Location = New System.Drawing.Point(23, 163)
        Me.dgpSelectProduct.MultiSelect = False
        Me.dgpSelectProduct.Name = "dgpSelectProduct"
        Me.dgpSelectProduct.ReadOnly = True
        Me.dgpSelectProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgpSelectProduct.Size = New System.Drawing.Size(424, 179)
        Me.dgpSelectProduct.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(356, 348)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Number Ordered"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Discount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Selected Product Desc"
        '
        'btnAdd
        '
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(266, 348)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtNuberOrdered
        '
        Me.txtNuberOrdered.Location = New System.Drawing.Point(161, 90)
        Me.txtNuberOrdered.Name = "txtNuberOrdered"
        Me.txtNuberOrdered.Size = New System.Drawing.Size(100, 20)
        Me.txtNuberOrdered.TabIndex = 10
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(161, 123)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscount.TabIndex = 11
        '
        'lbDesc
        '
        Me.lbDesc.AutoSize = True
        Me.lbDesc.Location = New System.Drawing.Point(158, 71)
        Me.lbDesc.Name = "lbDesc"
        Me.lbDesc.Size = New System.Drawing.Size(0, 13)
        Me.lbDesc.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Selected Product ID"
        '
        'lbProductId
        '
        Me.lbProductId.AutoSize = True
        Me.lbProductId.Location = New System.Drawing.Point(158, 41)
        Me.lbProductId.Name = "lbProductId"
        Me.lbProductId.Size = New System.Drawing.Size(0, 13)
        Me.lbProductId.TabIndex = 14
        '
        'frmAddProductForOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 384)
        Me.Controls.Add(Me.lbProductId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbDesc)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtNuberOrdered)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dgpSelectProduct)
        Me.Controls.Add(Me.lbOrderNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddProductForOrder"
        Me.Text = "Add Product For Order"
        CType(Me.dgpSelectProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbOrderNumber As Label
    Friend WithEvents dgpSelectProduct As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtNuberOrdered As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents lbDesc As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbProductId As Label
End Class
