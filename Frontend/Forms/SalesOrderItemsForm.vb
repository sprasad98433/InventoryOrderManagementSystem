Imports Inventory.BLL

Public Class SalesOrderItemsForm
    Private ReadOnly _orderId As Integer

    Public Sub New(orderId As Integer)
        InitializeComponent()
        _orderId = orderId
    End Sub

    Private Sub SalesOrderItemsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim service As New SalesOrderService()
        dgvItems.DataSource = service.GetSalesOrderItems(_orderId)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class