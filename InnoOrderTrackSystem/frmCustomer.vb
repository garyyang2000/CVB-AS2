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
        If custId <> 0 Then
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
        Else
            btnUpdate.Text = "Add Custmer"
        End If


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        If custId = 0 Then
            customer = New DLL_Library.IOTS.Customer()
            customer._firstName = txtFirst.Text.Trim
            customer._lastName = txtLast.Text.Trim
            customer._streetAddress = txtStreet.Text.Trim
            customer._city = txtCity.Text.Trim
            customer._province = txtProvince.Text.Trim
            customer._postalCode = txtPostal.Text.Trim
            customer._creditLimit = Double.Parse(txtCredit.Text.Trim)
            customer._email = txtEmail.Text.Trim
            customer._phoneNum = txtPhone.Text.Trim
            db.addNewCustomer(customer)
        Else
            customer._firstName = txtFirst.Text.Trim
            customer._lastName = txtLast.Text.Trim
            customer._streetAddress = txtStreet.Text.Trim
            customer._city = txtCity.Text.Trim
            customer._province = txtProvince.Text.Trim
            customer._postalCode = txtPostal.Text.Trim
            customer._creditLimit = Double.Parse(txtCredit.Text.Trim)
            customer._email = txtEmail.Text.Trim
            customer._phoneNum = txtPhone.Text.Trim
            db.updateCustomer(customer)
        End If
    End Sub
End Class