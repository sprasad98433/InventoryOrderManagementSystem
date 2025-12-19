Imports System.Data
Imports Inventory.Contract
Imports Inventory.Infrastructure
Imports Microsoft.Data.SqlClient

Public Class PurchaseOrderRepository

    Public Function CreatePurchaseOrder(po As PurchaseOrderDTO) As Integer

        Using con = DbConnectionFactory.Create()
            con.Open()

            Dim sqlTx As SqlTransaction = con.BeginTransaction()

            Try
                ' 1. Insert Purchase Order header
                Dim poId As Integer

                Using cmdHeader As New SqlCommand(
                    "INSERT INTO PurchaseOrders (SupplierId, Status, CreatedBy)
                     VALUES (@SupplierId, @Status, @CreatedBy);
                     SELECT SCOPE_IDENTITY();",
                    con, sqlTx)

                    cmdHeader.Parameters.AddWithValue("@SupplierId", po.SupplierId)
                    cmdHeader.Parameters.AddWithValue("@Status", po.Status)
                    cmdHeader.Parameters.AddWithValue("@CreatedBy", If(po.CreatedBy, DBNull.Value))

                    poId = Convert.ToInt32(cmdHeader.ExecuteScalar())
                End Using

                ' 2. Insert Purchase Order items
                For Each item In po.Items
                    Using cmdItem As New SqlCommand(
                        "INSERT INTO PurchaseOrderItems
                         (PurchaseOrderId, ProductId, Quantity)
                         VALUES (@PurchaseOrderId, @ProductId, @Quantity)",
                        con, sqlTx)

                        cmdItem.Parameters.AddWithValue("@PurchaseOrderId", poId)
                        cmdItem.Parameters.AddWithValue("@ProductId", item.ProductId)
                        cmdItem.Parameters.AddWithValue("@Quantity", item.Quantity)

                        cmdItem.ExecuteNonQuery()
                    End Using
                Next

                ' 3. Commit transaction
                sqlTx.Commit()

                Return poId

            Catch
                sqlTx.Rollback()
                Throw
            End Try

        End Using

    End Function

    Public Function GetOpenPurchaseOrders() As DataTable

        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
            "SELECT po.PurchaseOrderId, s.Name AS SupplierName, po.OrderDate
             FROM PurchaseOrders po
             INNER JOIN Suppliers s ON po.SupplierId = s.SupplierId
             WHERE po.Status = 'OPEN'
             ORDER BY po.OrderDate", con)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt

    End Function

    Public Function GetPurchaseOrderItems(poId As Integer) As DataTable

        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
            "SELECT 
                poi.ProductId,
                p.Name AS ProductName,
                poi.Quantity
             FROM PurchaseOrderItems poi
             INNER JOIN Products p ON poi.ProductId = p.ProductId
             WHERE poi.PurchaseOrderId = @POId", con)

                cmd.Parameters.AddWithValue("@POId", poId)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt

    End Function
    Public Sub ClosePurchaseOrder(poId As Integer)

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
            "UPDATE PurchaseOrders
             SET Status = 'CLOSED'
             WHERE PurchaseOrderId = @POId", con)

                cmd.Parameters.AddWithValue("@POId", poId)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Public Function GetPurchaseOrders() As DataTable

        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(
            "SELECT 
                po.PurchaseOrderId,
                s.Name AS SupplierName,
                po.OrderDate,
                po.Status
             FROM PurchaseOrders po
             INNER JOIN Suppliers s ON po.SupplierId = s.SupplierId
             ORDER BY po.OrderDate DESC", con)

                Using da As New Microsoft.Data.SqlClient.SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

            End Using
        End Using

        Return dt

    End Function


End Class
