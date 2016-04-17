Public Class frmAddProductForOrder

    Dim item As DLL_Library.IOTS.OrderItem

    Dim db As New DBManager.DBManager

    Property _Item As DLL_Library.IOTS.OrderItem
        Get
            Return item
        End Get
        Set(value As DLL_Library.IOTS.OrderItem)
            item = value
        End Set
    End Property

    Private Sub frmAddProductForOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgpSelectProduct.DataSource = Nothing
        dgpSelectProduct.Columns.Clear()
        dgpSelectProduct.DataSource = db.getAllProduct

        With dgpSelectProduct
            .RowHeadersVisible = False
            .Columns("_Price").DisplayIndex = 3
            .Columns("_productId").DisplayIndex = 0
            .Columns(1).HeaderCell.Value = "Description"
            .Columns(2).HeaderCell.Value = "QTY"
            .Columns(3).HeaderCell.Value = "Product ID"
            .Columns(0).HeaderCell.Value = "Price"

        End With
        txtDiscount.Text = 0
        txtNuberOrdered.Text = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        item = New DLL_Library.IOTS.OrderItem(Long.Parse(lbOrderNumber.Text), Integer.Parse(txtNuberOrdered.Text),
                                              lbProductId.Text, Double.Parse(txtDiscount.Text))
    End Sub

    Private Sub dgpSelectProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgpSelectProduct.CellClick
        Dim selectedRow As DataGridViewRow = dgpSelectProduct.Rows(e.RowIndex)
        lbDesc.Text = selectedRow.Cells(1).Value
        lbProductId.Text = selectedRow.Cells(3).Value
        btnAdd.Enabled = True
    End Sub

    Private Sub txtNuberOrdered_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNuberOrdered.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDiscount_Leave(sender As Object, e As EventArgs) Handles txtDiscount.Leave
        If Not IsNumeric(txtDiscount.Text) Then
            MessageBox.Show("Please input numeric only for discount")
            txtDiscount.Text = 0
        End If
    End Sub
End Class