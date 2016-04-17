Imports DBManager
Imports DLL_Library.IOTS.Product
Public Class frmProduct
    Private product_id As String

    Private product As DLL_Library.IOTS.Product

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
        product._description = txtDesc.Text.Trim
        product._Price = Double.Parse(txtPrice.Text.Trim)
        product._QtyOnHand = Integer.Parse(txtQty.Text.Trim)
        db.updateProduct(product)
    End Sub

    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        product = db.getProductById(product_id)
        lbProductID.Text = product_id
        txtDesc.Text = product._description
        txtPrice.Text = product._Price
        txtQty.Text = product._QtyOnHand
    End Sub
End Class