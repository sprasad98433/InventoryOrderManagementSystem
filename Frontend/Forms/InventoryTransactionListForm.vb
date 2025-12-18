Imports Inventory.BLL

Public Class InventoryTransactionListForm
    Private Sub InventoryTransactionListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransactions()
    End Sub

    Private Sub LoadTransactions()

        Dim service As New InventoryService()
        dgvTransactions.DataSource = service.GetInventoryTransactions()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadTransactions()
    End Sub
End Class