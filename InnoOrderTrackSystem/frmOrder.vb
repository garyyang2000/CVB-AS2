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
        loadOrderItems(order.orderItems)
    End Sub

    Private Sub loadOrderItems(ByVal orderItems As List(Of OrderItem))
        dgvOrderItems.DataSource = Nothing
        dgvOrderItems.Columns.Clear()
        dgvOrderItems.DataSource = orderItems
        Dim delecolumn As DataGridViewButtonColumn = New DataGridViewButtonColumn
        delecolumn.UseColumnTextForButtonValue = True
        delecolumn.Text = "DEL"
        delecolumn.Name = "DEL"
        delecolumn.DataPropertyName = "_productId"
        delecolumn.HeaderText = "DEL"
        dgvOrderItems.Columns.Add(delecolumn)

        With dgvOrderItems
            .RowHeadersVisible = False
            .Columns("DEL").DisplayIndex = 0
            .Columns(0).Visible = 0
            .Columns(1).HeaderCell.Value = "QTY"
            .Columns(2).HeaderCell.Value = "Discount"
            .Columns(3).HeaderCell.Value = "Product"
            .Columns(3).DisplayIndex = 1
        End With
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim addProdcut As New frmAddProductForOrder
        addProdcut.lbOrderNumber.Text = order._orderNumber
        Dim dr = addProdcut.ShowDialog(Me)
        If dr = System.Windows.Forms.DialogResult.OK Then
            db.addOrderItem(addProdcut._Item)
            order = db.getOrderByID(orderNumber)
            loadOrderItems(order.orderItems)
        End If
    End Sub

    Private Sub dgvOrderItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderItems.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            Return
        End If

        If (dgvOrderItems.Columns(e.ColumnIndex).Name = "DEL") Then
            Dim result As Integer = MessageBox.Show("Confirm to delete the row?", "Delete the record", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Return
            ElseIf result = DialogResult.Yes Then
                db.deleteProductFromOrderById(order._orderNumber, dgvOrderItems.Rows(e.RowIndex).Cells(3).Value.ToString())
                order = db.getOrderByID(orderNumber)
                loadOrderItems(order.orderItems)
            End If
        End If
    End Sub
End Class