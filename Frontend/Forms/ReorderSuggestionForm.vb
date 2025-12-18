Imports Inventory.BLL

Public Class ReorderSuggestionForm
    Private Sub ReorderSuggestionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReorderProducts()
    End Sub
    Private Sub LoadReorderProducts()

        Dim service As New ProductService()
        dgvReorder.DataSource = service.GetReorderProducts()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadReorderProducts()
    End Sub
End Class