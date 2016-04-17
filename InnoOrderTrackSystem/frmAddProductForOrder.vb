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
        If lbProductId.Text = "" Then
            MessageBox.Show("Please select the product in the list")
            Return
        End If

        item = New DLL_Library.IOTS.OrderItem(Long.Parse(lbOrderNumber.Text), Integer.Parse(txtNuberOrdered.Text),
                                              lbProductId.Text, Double.Parse(txtDiscount.Text))
    End Sub

    Private Sub dgpSelectProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgpSelectProduct.CellClick
        Dim selectedRow As DataGridViewRow = dgpSelectProduct.Rows(e.RowIndex)
        lbDesc.Text = selectedRow.Cells(1).Value
        lbProductId.Text = selectedRow.Cells(3).Value
    End Sub
End Class