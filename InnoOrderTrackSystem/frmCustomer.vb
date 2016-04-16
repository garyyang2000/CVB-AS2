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
        customer = db.getCustomerByID(custId)
        lbCusId.Text = custId
        txtFirst.Text = customer._firstName
        txtLast.Text = customer._lastName
        txtStreet.Text = customer._streetAddress
        txtCity.Text = customer._city
        txtProvince.Text = customer._province
        txtPostal.Text = customer._postalCode
        txtCredit.Text = customer._creditLimit
        txtEmail.Text = customer._email
        txtPhone.Text = customer._phoneNum

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class