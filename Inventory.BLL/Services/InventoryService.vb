Imports System.Data
Imports Inventory.Contract
Imports Inventory.DAL

Public Class InventoryService

    Private ReadOnly _repo As New InventoryRepository()
    Private ReadOnly _productRepo As New ProductRepository()

    Public Sub AddTransaction(tx As InventoryTransactionDTO)

        ' 1. Basic validation
        If tx.ProductId <= 0 Then
            Throw New Exception("Invalid product selected")
        End If

        If tx.Quantity <= 0 Then
            Throw New Exception("Quantity must be greater than zero")
        End If

        If tx.TransactionType <> "IN" AndAlso tx.TransactionType <> "OUT" Then
            Throw New Exception("Invalid transaction type")
        End If

        ' 2. Stock OUT validation
        If tx.TransactionType = "OUT" Then

            Dim dt = _productRepo.GetProductById(tx.ProductId)

            If dt.Rows.Count = 0 Then
                Throw New Exception("Product not found")
            End If

            Dim currentQty As Integer =
                Convert.ToInt32(dt.Rows(0)("QuantityOnHand"))

            If currentQty < tx.Quantity Then
                Throw New Exception("Insufficient stock available")
            End If

        End If

        ' 3. All rules passed → call DAL
        _repo.AddInventoryTransaction(tx)

    End Sub

    Public Function GetInventoryTransactions() As DataTable
        Return _repo.GetInventoryTransactions()
    End Function


End Class

