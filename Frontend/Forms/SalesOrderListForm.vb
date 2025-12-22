Imports Inventory.BLL

Public Class SalesOrderListForm
    Private Sub SalesOrderListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrders()
    End Sub
    Private Sub LoadOrders()
        Dim service As New SalesOrderService()
        dgvOrders.DataSource = service.GetSalesOrders()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadOrders()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnViewItems_Click(sender As Object, e As EventArgs) Handles btnViewItems.Click
        If dgvOrders.CurrentRow Is Nothing Then
            MessageBox.Show("Select an order")
            Exit Sub
        End If

        Dim orderId As Integer =
            Convert.ToInt32(dgvOrders.CurrentRow.Cells("OrderId").Value)

        Dim frm As New SalesOrderItemsForm(orderId)
        frm.ShowDialog()
    End Sub
End Class