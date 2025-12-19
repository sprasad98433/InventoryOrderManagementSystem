Imports System.Data
Imports Inventory.Contract
Imports Inventory.Infrastructure
Imports Microsoft.Data.SqlClient

Public Class ProductRepository

    Public Sub AddProduct(product As ProductDTO)

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
                "INSERT INTO Products
                 (Name, SKU, UnitPrice, QuantityOnHand, ReorderLevel, SupplierId, IsActive)
                 VALUES
                 (@Name, @SKU, @UnitPrice, @QuantityOnHand, @ReorderLevel, @SupplierId, @IsActive)", con)

                cmd.Parameters.AddWithValue("@Name", product.Name)
                cmd.Parameters.AddWithValue("@SKU", product.SKU)
                cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice)
                cmd.Parameters.AddWithValue("@QuantityOnHand", product.QuantityOnHand)
                cmd.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel)
                cmd.Parameters.AddWithValue("@SupplierId", product.SupplierId)
                cmd.Parameters.AddWithValue("@IsActive", product.IsActive)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Public Function GetAllProducts() As DataTable

        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
            "SELECT 
                ProductId,
                Name,
                SKU,
                UnitPrice,
                QuantityOnHand,
                ReorderLevel,
                SupplierId,
                IsActive
             FROM Products WHERE IsActive = 1", con)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

            End Using
        End Using

        Return dt

    End Function
    Public Function GetProductById(productId As Integer) As DataTable

        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
            "SELECT 
                ProductId,
                Name,
                SKU,
                UnitPrice,
                QuantityOnHand,
                ReorderLevel,
                SupplierId
             FROM Products
             WHERE ProductId = @ProductId", con)

                cmd.Parameters.AddWithValue("@ProductId", productId)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

            End Using
        End Using

        Return dt

    End Function
    Public Sub UpdateProduct(product As ProductDTO)

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
            "UPDATE Products SET
                Name = @Name,
                SKU = @SKU,
                UnitPrice = @UnitPrice,
                QuantityOnHand = @QuantityOnHand,
                ReorderLevel = @ReorderLevel,
                SupplierId = @SupplierId
             WHERE ProductId = @ProductId", con)

                cmd.Parameters.AddWithValue("@Name", product.Name)
                cmd.Parameters.AddWithValue("@SKU", product.SKU)
                cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice)
                cmd.Parameters.AddWithValue("@QuantityOnHand", product.QuantityOnHand)
                cmd.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel)
                cmd.Parameters.AddWithValue("@SupplierId", product.SupplierId)
                cmd.Parameters.AddWithValue("@ProductId", product.ProductId)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Public Sub DeleteProduct(productId As Integer)

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
            "UPDATE Products 
             SET IsActive = 0 
             WHERE ProductId = @ProductId", con)

                cmd.Parameters.AddWithValue("@ProductId", productId)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Public Function GetReorderProducts() As DataTable

        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
            "SELECT 
                p.ProductId,
                p.Name,
                p.QuantityOnHand,
                p.ReorderLevel,
                s.Name AS SupplierName
             FROM Products p
             INNER JOIN Suppliers s ON p.SupplierId = s.SupplierId
             WHERE p.IsActive = 1
               AND p.QuantityOnHand <= p.ReorderLevel
             ORDER BY p.QuantityOnHand ASC", con)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

            End Using
        End Using

        Return dt

    End Function
    Public Function GetLowStockProducts() As DataTable

        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(
            "SELECT 
                ProductId,
                Name,
                SKU,
                QuantityOnHand,
                ReorderLevel
             FROM Products
             WHERE QuantityOnHand <= ReorderLevel
               AND IsActive = 1
             ORDER BY QuantityOnHand ASC", con)

                Using da As New Microsoft.Data.SqlClient.SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

            End Using
        End Using

        Return dt

    End Function


End Class
