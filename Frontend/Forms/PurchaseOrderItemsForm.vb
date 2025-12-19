Imports Inventory.DAL

Public Class PurchaseOrderItemsForm

    Private ReadOnly _poId As Integer

    Public Sub New(poId As Integer)
        InitializeComponent()
        _poId = poId
    End Sub

    Private Sub PurchaseOrderItemsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim repo As New PurchaseOrderRepository()
        dgvItems.DataSource = repo.GetPurchaseOrderItems(_poId)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class