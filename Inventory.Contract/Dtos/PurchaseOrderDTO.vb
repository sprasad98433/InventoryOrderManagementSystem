Public Class PurchaseOrderDTO

    Public Property PurchaseOrderId As Integer
    Public Property SupplierId As Integer
    Public Property OrderDate As DateTime
    Public Property Status As String
    Public Property CreatedBy As String

    ' Navigation (for UI/BLL convenience)
    Public Property Items As List(Of PurchaseOrderItemDTO)

    Public Sub New()
        Items = New List(Of PurchaseOrderItemDTO)()
    End Sub

End Class