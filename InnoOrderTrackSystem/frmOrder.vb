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
            .Columns(1).HeaderCell.Value = "Product"
            .Columns(2).HeaderCell.Value = "QTY"
            .Columns(3).HeaderCell.Value = "Discount"
        End With
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click

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
                db.deleteProductFromOrderById(order._orderNumber, dgvOrderItems.Rows(e.RowIndex).Cells(0).Value.ToString())
            End If
        End If
    End Sub
End Class