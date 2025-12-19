Imports Inventory.BLL

Public Class PurchaseOrderListForm

    Private Sub PurchaseOrderListForm_Load(
        sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPOs()
    End Sub

    Private Sub LoadPOs()
        Dim service As New PurchaseOrderService()
        dgvPOs.DataSource = service.GetPurchaseOrders()
    End Sub
    Private Sub btnViewItems_Click(sender As Object, e As EventArgs) Handles btnViewItems.Click
        If dgvPOs.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a purchase order")
            Exit Sub
        End If

        Dim poId As Integer =
            Convert.ToInt32(dgvPOs.CurrentRow.Cells("PurchaseOrderId").Value)

        Dim frm As New PurchaseOrderItemsForm(poId)
        frm.ShowDialog()


    End Sub
End Class