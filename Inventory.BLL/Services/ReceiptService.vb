Imports System.Data
Imports Inventory.Contract
Imports Inventory.DAL



Public Class ReceiptService

        Private ReadOnly _repo As New ReceiptRepository()

        Public Sub AddReceipt(receipt As ReceiptDTO)

            ' Basic validations
            If receipt Is Nothing Then
                Throw New Exception("Receipt data is missing")
            End If

            If receipt.CustomerId <= 0 Then
                Throw New Exception("Customer is required")
            End If

            If receipt.Amount <= 0 Then
                Throw New Exception("Receipt amount must be greater than zero")
            End If

            If String.IsNullOrWhiteSpace(receipt.PaymentMode) Then
                Throw New Exception("Payment mode is required")
            End If

            ' Save receipt
            _repo.AddReceipt(receipt)

        End Sub

        Public Function GetReceipts() As DataTable
            Return _repo.GetReceipts()
        End Function


    End Class


