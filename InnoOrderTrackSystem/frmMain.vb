Imports DBManager
Imports DLL_Library.IOTS.Product
Public Class frmMain

    Dim db As New DBManager.DBManager
    Dim currentViewType As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCustomer()

    End Sub

    Private Sub loadCustomer()
        listData.Columns.Clear()
        listData.Items.Clear()
        listData.View = System.Windows.Forms.View.Details
        listData.Columns.Add("custId")
        listData.Columns.Add("firstName")
        listData.Columns.Add("lastName")
        listData.Columns.Add("streetAddress")
        listData.Columns.Add("city")
        listData.Columns.Add("province")
        listData.Columns.Add("postalCode")
        listData.Columns.Add("creditLimit")
        listData.Columns.Add("email")
        listData.Columns.Add("phoneNum")

        Dim cList As List(Of DLL_Library.IOTS.Customer) = db.getAllCustomer()

        For Each customer As DLL_Library.IOTS.Customer In cList
            Dim li As ListViewItem
            li = listData.Items.Add(customer._custId)
            li.SubItems.Add(customer._firstName)
            li.SubItems.Add(customer._lastName)
            li.SubItems.Add(customer._streetAddress)
            li.SubItems.Add(customer._city)
            li.SubItems.Add(customer._province)
            li.SubItems.Add(customer._postalCode)
            li.SubItems.Add(customer._creditLimit)
            li.SubItems.Add(customer._email)
            li.SubItems.Add(customer._phoneNum)
        Next

        currentViewType = "Customer"
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
        currentViewType = "Product"

    End Sub

    Private Sub loadOrder()

    End Sub

    Private Sub listData_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles listData.MouseDoubleClick
        Dim items As ListView.SelectedListViewItemCollection = listData.SelectedItems

        Dim item As ListViewItem = items(0)

        Dim id As Object = item.Text.Trim

        Select Case currentViewType
            Case "Customer"
                MessageBox.Show("Customer")
            Case "Product"
                Dim frmProduct As New ProductForm
                frmProduct.ShowDialog()
            Case "Order"
                MessageBox.Show("Order")

        End Select
    End Sub

    Private Sub btnProductList_Click(sender As Object, e As EventArgs) Handles btnProductList.Click
        loadProduct()
    End Sub

    Private Sub btnOrderList_Click(sender As Object, e As EventArgs) Handles btnOrderList.Click

    End Sub

    Private Sub btnCustomerList_Click(sender As Object, e As EventArgs) Handles btnCustomerList.Click
        loadCustomer()
    End Sub
End Class
