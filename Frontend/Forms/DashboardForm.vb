Public Class DashboardForm
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name As String = SessionManager.Username
        Label1.Text = "Welcome, " & name & "!"
    End Sub





    Private Sub mnuInventoryTxn_Click(sender As Object, e As EventArgs) Handles mnuInventoryTxn.Click
        Dim frm As New InventoryTransactionForm()
        frm.ShowDialog()
    End Sub

    Private Sub mnuInventoryHistory_Click(sender As Object, e As EventArgs) Handles mnuInventoryHistory.Click
        Dim frm As New InventoryTransactionListForm()
        frm.ShowDialog()
    End Sub

    Private Sub mnuReorder_Click(sender As Object, e As EventArgs) Handles mnuReorder.Click
        Dim frm As New ReorderSuggestionForm()
        frm.ShowDialog()
    End Sub

    Private Sub mnuCreatePO_Click(sender As Object, e As EventArgs) Handles mnuCreatePO.Click
        Dim frm As New PurchaseOrderForm()
        frm.ShowDialog()
    End Sub

    Private Sub mnuReceivePO_Click(sender As Object, e As EventArgs) Handles mnuReceivePO.Click
        Dim frm As New ReceivePurchaseOrderForm()
        frm.ShowDialog()
    End Sub

    Private Sub mnuPOList_Click(sender As Object, e As EventArgs) Handles mnuPOList.Click
        Dim frm As New PurchaseOrderListForm()
        frm.ShowDialog()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuProductList_Click(sender As Object, e As EventArgs) Handles mnuProductList.Click
        Dim frm As New ProductListForm()
        frm.ShowDialog()
    End Sub

    Private Sub mnuAddProduct_Click(sender As Object, e As EventArgs) Handles mnuAddProduct.Click
        Dim frm As New AddProductForm()
        frm.ShowDialog()
    End Sub

    Private Sub mnuLowStockReport_Click(sender As Object, e As EventArgs) Handles mnuLowStockReport.Click
        Dim frm As New LowStockReportForm()
        frm.ShowDialog()
    End Sub

    Private Sub AddUpdateSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUpdateSupplierToolStripMenuItem.Click
        Dim frm As New AddSupplierForm()
        frm.Show()

    End Sub
End Class