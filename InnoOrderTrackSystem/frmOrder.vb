Imports DLL_Library.IOTS
Public Class frmOrder
    Private orderNumber As Long
    Private order As DLL_Library.IOTS.Order

    Private productID As String

    Private db As DBManager.DBManager = New DBManager.DBManager

    Property _OrderNumber As Long
        Get
            Return orderNumber
        End Get
        Set(value As Long)
            orderNumber = value
        End Set
    End Property

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        order = db.getOrderByID(orderNumber)
        lbOrderNumber.Text = order._orderNumber
        dtOrderDate.Value = order._orderDate
        dtShipDate.Value = order._shipDate
    End Sub

    Private Sub loadOrderItems(ByVal orderItems As List(Of OrderItem))
        listOrderItems.Columns.Clear()
        listOrderItems.Items.Clear()
        listOrderItems.View = System.Windows.Forms.View.Details
        listOrderItems.Columns.Add("Product")
        listOrderItems.Columns.Add("numberOrdered")
        listOrderItems.Columns.Add("discount")

        For Each item As DLL_Library.IOTS.OrderItem In orderItems
            Dim product As DLL_Library.IOTS.Product = db.getProductById(item._productId)
            Dim li As ListViewItem
            li = listOrderItems.Items.Add(product._description)
            li.SubItems.Add(item._numberOrdered)
            li.SubItems.Add(item._discount)
        Next
    End Sub

    Private Sub listOrderItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listOrderItems.SelectedIndexChanged
        Dim items As ListView.SelectedListViewItemCollection = listOrderItems.SelectedItems
        Dim item As ListViewItem = items.Item(0)

        productID = item.Text

    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click

    End Sub
End Class