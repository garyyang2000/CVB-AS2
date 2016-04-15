Imports DBManager
Imports DLL_Library.IOTS.Product
Public Class Form1

    Dim db As New DBManager.DBManager
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadProduct()
    End Sub

    Private Sub loadCustomer()
        listData.Columns.Clear()
        listData.Items.Clear()
        listData.View = System.Windows.Forms.View.Details
        listData.Columns.Add("ProductId")
        listData.Columns.Add("Description")
        listData.Columns.Add("Qty")
        listData.Columns.Add("Price")

    End Sub

    Private Sub loadProduct()
        listData.Columns.Clear()
        listData.Items.Clear()
        listData.View = System.Windows.Forms.View.Details
        listData.Columns.Add("ProductId")
        listData.Columns.Add("Description")
        listData.Columns.Add("Qty")
        listData.Columns.Add("Price")

        Dim pList As List(Of DLL_Library.IOTS.Product) = db.getAllProduct()

        For Each prodcut As DLL_Library.IOTS.Product In pList
            Dim li As ListViewItem
            li = listData.Items.Add(prodcut._productId)
            li.SubItems.Add(prodcut._description)
            li.SubItems.Add(prodcut._QtyOnHand)
            li.SubItems.Add(prodcut._Price)
        Next


    End Sub
End Class
