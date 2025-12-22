Imports System.Data
Imports Inventory.Contract
Imports Inventory.DAL



Public Class SalesOrderService

        Private ReadOnly _repo As New SalesOrderRepository()

    Public Sub SaveOrder(order As SalesOrderDTO)

        If order Is Nothing Then
            Throw New Exception("Order cannot be null")
        End If

        If order.Items Is Nothing OrElse order.Items.Count = 0 Then
            Throw New Exception("Order must contain at least one item")
        End If

        _repo.SaveOrder(order)

    End Sub

    Public Function GetSalesOrders() As DataTable
        Return _repo.GetSalesOrders()
    End Function

    Public Function GetSalesOrderItems(orderId As Integer) As DataTable
        Return _repo.GetSalesOrderItems(orderId)
    End Function


End Class


