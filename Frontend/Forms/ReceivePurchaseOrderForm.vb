Imports Inventory.BLL
Imports Inventory.DAL

Public Class ReceivePurchaseOrderForm
    Private Sub ReceivePurchaseOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim repo As New PurchaseOrderRepository
        cmbPO.DataSource = repo.GetOpenPurchaseOrders
        cmbPO.DisplayMember = "PurchaseOrderId"
        cmbPO.ValueMember = "PurchaseOrderId"
        cmbPO.SelectedIndex = -1
    End Sub

    Private Sub cmbPO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPO.SelectedIndexChanged
        If cmbPO.SelectedIndex = -1 Then Exit Sub

        If cmbPO.SelectedValue Is Nothing Then Exit Sub
        If TypeOf cmbPO.SelectedValue Is DataRowView Then Exit Sub

        Dim poId As Integer
        If Not Integer.TryParse(cmbPO.SelectedValue.ToString(), poId) Then Exit Sub

        Dim repo As New PurchaseOrderRepository()
        dgvItems.DataSource = repo.GetPurchaseOrderItems(poId)
    End Sub

    Private Sub btnReceive_Click(sender As Object, e As EventArgs) Handles btnReceive.Click
        Try
            Dim service As New PurchaseOrderService()
            service.ReceivePurchaseOrder(
                Convert.ToInt32(cmbPO.SelectedValue),
                "Admin")

            MessageBox.Show("Goods received successfully")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class