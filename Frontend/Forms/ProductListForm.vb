Imports Inventory.BLL

Public Class ProductListForm
    Private Sub ProductListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()

        Dim service As New ProductService()
        dgvProducts.DataSource = service.GetAllProducts()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to edit")
            Exit Sub
        End If

        Dim productId As Integer =
            Convert.ToInt32(dgvProducts.SelectedRows(0).Cells("ProductId").Value)

        Dim frm As New AddProductForm(productId)
        frm.ShowDialog()

        LoadProducts()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to delete")
            Exit Sub
        End If

        Dim productId As Integer =
            Convert.ToInt32(dgvProducts.SelectedRows(0).Cells("ProductId").Value)

        Dim confirm = MessageBox.Show(
            "Are you sure you want to delete this product?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirm = DialogResult.No Then Exit Sub

        Try
            Dim service As New ProductService()
            service.DeleteProduct(productId)

            MessageBox.Show("Product deleted successfully")

            LoadProducts()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadProducts()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim frm As New AddProductForm()
        frm.ShowDialog()

        ' After closing AddProductForm, refresh product list
        LoadProducts()
    End Sub
End Class