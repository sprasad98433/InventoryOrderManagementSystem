Public Class InventoryTransactionDTO
    Public Property TransactionId As Integer
    Public Property ProductId As Integer
    Public Property TransactionType As String   ' "IN" or "OUT"
    Public Property Quantity As Integer
    Public Property ReferenceNo As String
    Public Property Remarks As String
    Public Property TransactionDate As DateTime
    Public Property CreatedBy As String
End Class
