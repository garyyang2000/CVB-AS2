﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lbProductID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Desc:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Qty On Hand:"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(170, 89)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(182, 28)
        Me.txtDesc.TabIndex = 4
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(170, 132)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(182, 28)
        Me.txtQty.TabIndex = 5
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(170, 236)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(275, 235)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(170, 179)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(182, 28)
        Me.txtPrice.TabIndex = 9
        '
        'lbProductID
        '
        Me.lbProductID.AutoSize = True
        Me.lbProductID.Location = New System.Drawing.Point(170, 49)
        Me.lbProductID.Name = "lbProductID"
        Me.lbProductID.Size = New System.Drawing.Size(62, 18)
        Me.lbProductID.TabIndex = 10
        Me.lbProductID.Text = "Label5"
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 283)
        Me.Controls.Add(Me.lbProductID)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ProductForm"
        Me.Text = "Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lbProductID As Label
End Class
