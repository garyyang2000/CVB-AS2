Public Class frmCustomer
    Private custId As Long
    Private customer As DLL_Library.IOTS.Customer = New DLL_Library.IOTS.Customer()

    Private db As DBManager.DBManager = New DBManager.DBManager
    Dim closing As Boolean = True
    Property _CustID As Long
        Get
            Return custId
        End Get
        Set(value As Long)
            custId = value
        End Set
    End Property

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCustomerOrderList.DataSource = Nothing
        dgvCustomerOrderList.Columns.Clear()
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


            dgvCustomerOrderList.DataSource = db.getCustOrders(custId)

            With dgvCustomerOrderList
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Order Number"
                .Columns(1).Visible = False
                .Columns(2).Visible = False
                .Columns(3).HeaderCell.Value = "Order Date"
                .Columns(4).HeaderCell.Value = "Ship Date"
                .Columns(5).Visible = False
                .Columns(6).Visible = False
            End With

        Else
            btnUpdate.Text = "Add Custmer"
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        If custId = 0 Then
            Try
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
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                closing = False
            End Try

        Else
            Try
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
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                closing = False
            End Try

        End If
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        Dim addOrder As New frmAddOrder
        addOrder.lbCustomer.Text = customer._firstName + " " + customer._lastName
        Dim dr = addOrder.ShowDialog
        If dr = System.Windows.Forms.DialogResult.OK Then
            Dim order As New DLL_Library.IOTS.Order(addOrder.dtOrderDate.Value, addOrder.dtShipDate.Value, customer._custId)
            db.addNewOrder(order)
        End If
    End Sub

    Private Sub txtCredit_Leave(sender As Object, e As EventArgs) Handles txtCredit.Leave
        If Not IsNumeric(txtCredit.Text) Then
            MessageBox.Show("Please input numeric only for Credit Limit")
            txtCredit.Text = 0
        End If
    End Sub

    Private Sub frmCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not closing Then
            e.Cancel = True
            closing = True
        End If
    End Sub
End Class