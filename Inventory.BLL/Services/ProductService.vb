Imports System.Data
Imports Inventory.Contract
Imports Inventory.DAL


Public Class ProductService

    Private ReadOnly _repo As New ProductRepository()

    Public Sub AddProduct(product As ProductDTO)

        ' 1. Basic validation
        If String.IsNullOrWhiteSpace(product.Name) Then
            Throw New Exception("Product name is required")
        End If

        If String.IsNullOrWhiteSpace(product.SKU) Then
            Throw New Exception("SKU is required")
        End If

        If product.UnitPrice <= 0 Then
            Throw New Exception("Unit price must be greater than zero")
        End If

        If product.QuantityOnHand < 0 Then
            Throw New Exception("Quantity cannot be negative")
        End If

        If product.ReorderLevel < 0 Then
            Throw New Exception("Reorder level cannot be negative")
        End If

        ' 2. Default values
        product.IsActive = True

        ' 3. Call DAL
        _repo.AddProduct(product)

    End Sub

    Public Function GetAllProducts() As DataTable
        Return _repo.GetAllProducts()
    End Function
    Public Function GetProductById(productId As Integer) As DataTable
        Return _repo.GetProductById(productId)
    End Function
    Public Sub UpdateProduct(product As ProductDTO)

        ' Same validations as Add
        If String.IsNullOrWhiteSpace(product.Name) Then
            Throw New Exception("Product name is required")
        End If

        If String.IsNullOrWhiteSpace(product.SKU) Then
            Throw New Exception("SKU is required")
        End If

        If product.UnitPrice <= 0 Then
            Throw New Exception("Unit price must be greater than zero")
        End If

        _repo.UpdateProduct(product)

    End Sub
    Public Sub DeleteProduct(productId As Integer)

        If productId <= 0 Then
            Throw New Exception("Invalid product selected")
        End If

        _repo.DeleteProduct(productId)

    End Sub
    Public Function GetReorderProducts() As DataTable
        Return _repo.GetReorderProducts()
    End Function


End Class

