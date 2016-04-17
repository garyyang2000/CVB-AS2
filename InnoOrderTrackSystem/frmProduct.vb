Imports DBManager
Imports DLL_Library.IOTS.Product
Public Class frmProduct
    Private product_id As String

    Private product As DLL_Library.IOTS.Product
    Dim closing As Boolean = True
    Dim db As New DBManager.DBManager
    Property _Product_id As String
        Get
            Return product_id
        End Get
        Set(value As String)
            product_id = value
        End Set
    End Property

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Add Product" Then
            Try
                product = New DLL_Library.IOTS.Product(txtProductId.Text.Trim, txtDesc.Text.Trim, Integer.Parse(txtQty.Text), Double.Parse(txtPrice.Text))
                db.addNewProduct(product)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                closing = False
                Return
            End Try
        Else
            product._description = txtDesc.Text.Trim
            product._Price = Double.Parse(txtPrice.Text.Trim)
            product._QtyOnHand = Integer.Parse(txtQty.Text.Trim)
            db.updateProduct(product)
        End If

    End Sub

    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If product_id IsNot Nothing Then
            product = db.getProductById(product_id)
            lbProductID.Text = product_id
            lbProductID.Visible = True
            txtDesc.Text = product._description
            txtPrice.Text = product._Price
            txtQty.Text = product._QtyOnHand
        Else
            txtProductId.Visible = True
            txtPrice.Text = 0
            txtQty.Text = 0
            btnUpdate.Text = "Add Product"
        End If

    End Sub

    Private Sub txtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave
        If Not IsNumeric(txtPrice.Text) Then
            MessageBox.Show("Please input numeric only for price")
            txtPrice.Text = 0
        End If
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub frmProduct_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not closing Then
            e.Cancel = True
            closing = True
        End If
    End Sub
End Class