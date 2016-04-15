Imports DBManager
Imports DLL_Library.IOTS.Product
Public Class ProductForm
    Private product_id As String

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

        'Dim product As DLL_Library.IOTS.Product = db
    End Sub
End Class