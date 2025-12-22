Public Class SalesOrderDTO
    Public Property OrderId As Integer
    Public Property CustomerId As Integer
    Public Property OrderDate As DateTime
    Public Property TotalAmount As Decimal
    Public Property Items As List(Of SalesOrderItemDTO)
End Class
