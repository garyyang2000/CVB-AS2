Imports DBManager
Imports DLL_Library.IOTS
Public Class frmMain

    Dim db As New DBManager.DBManager
    Dim currentViewType As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCustomer()
    End Sub

    Private Sub loadCustomer()
        dgvData.DataSource = Nothing
        dgvData.Columns.Clear()
        dgvData.DataSource = db.getAllCustomer()
        Dim delecolumn As DataGridViewButtonColumn = New DataGridViewButtonColumn
        delecolumn.UseColumnTextForButtonValue = True
        delecolumn.Text = "DEL"
        delecolumn.Name = "DEL"
        delecolumn.DataPropertyName = "_custId"
        delecolumn.HeaderText = "DEL"
        dgvData.Columns.Add(delecolumn)

        With dgvData
            .RowHeadersVisible = False
            .Columns("_phoneNum").DisplayIndex = 10
            .Columns("DEL").DisplayIndex = 0
            .Columns(1).HeaderCell.Value = "Customer ID"
            .Columns(2).HeaderCell.Value = "First Name"
            .Columns(3).HeaderCell.Value = "Last Name"
            .Columns(4).HeaderCell.Value = "Street Address"
            .Columns(5).HeaderCell.Value = "City"
            .Columns(6).HeaderCell.Value = "Province"
            .Columns(7).HeaderCell.Value = "Postal Code"
            .Columns(8).HeaderCell.Value = "Credit Limit"
            .Columns(9).HeaderCell.Value = "Email"
            .Columns(0).HeaderCell.Value = "Phone Number"
        End With
        currentViewType = "Customer"
    End Sub


    Private Sub loadProduct()
        dgvData.DataSource = Nothing
        dgvData.Columns.Clear()
        dgvData.DataSource = db.getAllProduct()
        Dim delecolumn As DataGridViewButtonColumn = New DataGridViewButtonColumn
        delecolumn.UseColumnTextForButtonValue = True
        delecolumn.Text = "DEL"
        delecolumn.Name = "DEL"
        delecolumn.DataPropertyName = "_productId"
        delecolumn.HeaderText = "DEL"
        dgvData.Columns.Add(delecolumn)

        With dgvData
            .RowHeadersVisible = False
            .Columns("DEL").DisplayIndex = 0
            .Columns("_Price").DisplayIndex = 4
            .Columns("_productId").DisplayIndex = 1
            .Columns(1).HeaderCell.Value = "Description"
            .Columns(2).HeaderCell.Value = "QTY"
            .Columns(3).HeaderCell.Value = "Product ID"
            .Columns(0).HeaderCell.Value = "Price"

        End With
        currentViewType = "Product"

    End Sub

    Private Sub loadOrder()
        dgvData.DataSource = Nothing
        dgvData.Columns.Clear()
        dgvData.DataSource = db.getAllOrder()
        Dim delecolumn As DataGridViewButtonColumn = New DataGridViewButtonColumn
        delecolumn.UseColumnTextForButtonValue = True
        delecolumn.Text = "DEL"
        delecolumn.Name = "DEL"
        delecolumn.DataPropertyName = "_orderNumber"
        delecolumn.HeaderText = "DEL"
        dgvData.Columns.Add(delecolumn)

        With dgvData
            .RowHeadersVisible = False
            .Columns("DEL").DisplayIndex = 0

            .Columns(0).HeaderCell.Value = "Order Number"
            .Columns(1).Visible = False
            .Columns(2).Visible = False
            .Columns(3).HeaderCell.Value = "Order Date"
            .Columns(4).HeaderCell.Value = "Ship Date"
            .Columns(5).HeaderCell.Value = "Customer"
            .Columns(6).HeaderCell.Value = "Discount"



        End With
        currentViewType = "Order"
    End Sub

    Private Sub btnProductList_Click(sender As Object, e As EventArgs) Handles btnProductList.Click
        loadProduct()
    End Sub

    Private Sub btnOrderList_Click(sender As Object, e As EventArgs) Handles btnOrderList.Click
        loadOrder()
    End Sub

    Private Sub btnCustomerList_Click(sender As Object, e As EventArgs) Handles btnCustomerList.Click
        loadCustomer()
    End Sub

    Private Sub dgvData_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = dgvData.Rows(e.RowIndex)
            Dim id As Object = selectedRow.Cells(1).Value.ToString()
            Select Case currentViewType
                Case "Customer"
                    Dim frmCust As New frmCustomer
                    frmCust._CustID = Long.Parse(id)
                    frmCust.ShowDialog()
                Case "Product"
                    Dim frmProd As New frmProduct
                    frmProd._Product_id = id.ToString
                    frmProd.ShowDialog()
                Case "Order"
                    Dim frmOd As New frmOrder
                    frmOd._OrderNumber = Long.Parse(id)
                    frmOd.ShowDialog()

            End Select
        End If

    End Sub

    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            Return
        End If

        If (dgvData.Columns(e.ColumnIndex).Name = "DEL") Then
            Dim result As Integer = MessageBox.Show("Confirm to delete the row?", "Delete the record", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                MessageBox.Show("No pressed")
            ElseIf result = DialogResult.Yes Then
                MessageBox.Show("Yes pressed")
            End If
        End If
    End Sub
End Class
