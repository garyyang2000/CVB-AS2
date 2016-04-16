Imports DLL_Library.IOTS
Public Class frmOrder
    Private orderNumber As Long
    Private order As DLL_Library.IOTS.Order

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

    End Sub
End Class