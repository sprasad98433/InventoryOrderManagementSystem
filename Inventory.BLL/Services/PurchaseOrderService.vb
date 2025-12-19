Imports System.Data
Imports Inventory.Contract
Imports Inventory.DAL

Public Class PurchaseOrderService

    Private ReadOnly _repo As New PurchaseOrderRepository()
    Private ReadOnly _supplierRepo As New SupplierRepository()
    Public Function GetPurchaseOrders() As DataTable
        Return _repo.GetPurchaseOrders()
    End Function

    Public Function CreatePurchaseOrder(po As PurchaseOrderDTO) As Integer

        ' 1. Validate supplier
        If po.SupplierId <= 0 OrElse Not _supplierRepo.SupplierExists(po.SupplierId) Then
            Throw New Exception("Invalid or inactive supplier selected")
        End If


        ' 2. Validate items
        If po.Items Is Nothing OrElse po.Items.Count = 0 Then
            Throw New Exception("Purchase order must contain at least one product")
        End If

        ' 3. Validate each item
        Dim productIds As New HashSet(Of Integer)

        For Each item In po.Items

            If item.ProductId <= 0 Then
                Throw New Exception("Invalid product in purchase order")
            End If

            If item.Quantity <= 0 Then
                Throw New Exception("Quantity must be greater than zero")
            End If

            If productIds.Contains(item.ProductId) Then
                Throw New Exception("Duplicate product found in purchase order")
            End If

            productIds.Add(item.ProductId)

        Next

        ' 4. Default values
        po.Status = "OPEN"

        ' 5. Call DAL
        Return _repo.CreatePurchaseOrder(po)

    End Function

    Public Sub ReceivePurchaseOrder(poId As Integer, receivedBy As String)

        If poId <= 0 Then
            Throw New Exception("Invalid purchase order")
        End If

        Dim dtItems = _repo.GetPurchaseOrderItems(poId)

        If dtItems.Rows.Count = 0 Then
            Throw New Exception("No items found for purchase order")
        End If

        Dim inventoryService As New InventoryService()

        For Each row As DataRow In dtItems.Rows

            Dim tx As New InventoryTransactionDTO With {
            .ProductId = Convert.ToInt32(row("ProductId")),
            .TransactionType = "IN",
            .Quantity = Convert.ToInt32(row("Quantity")),
            .ReferenceNo = $"PO-{poId}",
            .CreatedBy = receivedBy
        }

            inventoryService.AddTransaction(tx)
        Next

        ' Close PO
        _repo.ClosePurchaseOrder(poId)

    End Sub


End Class
