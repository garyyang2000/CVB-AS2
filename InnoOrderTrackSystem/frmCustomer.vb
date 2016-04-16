Public Class frmCustomer
    Private custId As Long
    Private customer As DLL_Library.IOTS.Customer

    Private db As DBManager.DBManager = New DBManager.DBManager

    Property _CustID As Long
        Get
            Return custId
        End Get
        Set(value As Long)
            custId = value
        End Set
    End Property

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class