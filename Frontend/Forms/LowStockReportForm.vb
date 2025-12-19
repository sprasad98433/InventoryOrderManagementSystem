Imports Inventory.BLL

Public Class LowStockReportForm
    Private Sub LowStockReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim service As New ProductService()
        dgvLowStock.DataSource = service.GetLowStockProducts()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
    End Sub
End Class