Imports System.Data
Imports Inventory.Contract
Imports Inventory.Infrastructure
Imports Microsoft.Data.SqlClient

Public Class SalesOrderRepository

    Public Sub SaveOrder(order As SalesOrderDTO)

        Using con = DbConnectionFactory.Create()
            con.Open()

            Using tran = con.BeginTransaction()

                Try
                    ' 1️⃣ Insert Order
                    Dim orderId As Integer

                    Using cmd As New SqlCommand(
                        "INSERT INTO Orders (CustomerId, OrderDate, Status, TotalAmount)
                         OUTPUT INSERTED.OrderId
                         VALUES (@CustomerId, @OrderDate, 'Completed', @TotalAmount)",
                        con, tran)

                        cmd.Parameters.AddWithValue("@CustomerId", order.CustomerId)
                        cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate)
                        cmd.Parameters.AddWithValue("@TotalAmount", order.TotalAmount)

                        orderId = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using

                    'Auto receipt generation
                    Using cmdReceipt As New SqlCommand(
                    "INSERT INTO Receipts
                     (CustomerId, ReceiptDate, Amount, PaymentMode)
                     VALUES (@CustomerId, @ReceiptDate, @Amount, 'Cash')",
                    con, tran)

                        cmdReceipt.Parameters.AddWithValue("@CustomerId", order.CustomerId)
                        cmdReceipt.Parameters.AddWithValue("@ReceiptDate", order.OrderDate)
                        cmdReceipt.Parameters.AddWithValue("@Amount", order.TotalAmount)

                        cmdReceipt.ExecuteNonQuery()
                    End Using
                    ' 2️ Insert OrderItems + Reduce Stock
                    For Each item In order.Items

                        Using cmdItem As New SqlCommand(
                            "INSERT INTO OrderItems
                             (OrderId, ProductId, Quantity, UnitPrice, LineTotal)
                             VALUES (@OrderId, @ProductId, @Qty, @Price, @LineTotal)",
                            con, tran)

                            cmdItem.Parameters.AddWithValue("@OrderId", orderId)
                            cmdItem.Parameters.AddWithValue("@ProductId", item.ProductId)
                            cmdItem.Parameters.AddWithValue("@Qty", item.Quantity)
                            cmdItem.Parameters.AddWithValue("@Price", item.UnitPrice)
                            cmdItem.Parameters.AddWithValue("@LineTotal", item.LineTotal)

                            cmdItem.ExecuteNonQuery()
                        End Using

                        Using cmdStock As New SqlCommand(
                            "UPDATE Products
                             SET QuantityOnHand = QuantityOnHand - @Qty
                             WHERE ProductId = @ProductId",
                            con, tran)

                            cmdStock.Parameters.AddWithValue("@Qty", item.Quantity)
                            cmdStock.Parameters.AddWithValue("@ProductId", item.ProductId)

                            cmdStock.ExecuteNonQuery()
                        End Using

                    Next

                    tran.Commit()

                Catch
                    tran.Rollback()
                    Throw
                End Try

            End Using
        End Using

    End Sub

    Public Function GetSalesOrders() As DataTable

        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(
            "SELECT o.OrderId,
                    o.OrderDate,
                    c.Name AS CustomerName,
                    o.TotalAmount
             FROM Orders o
             INNER JOIN Customers c ON o.CustomerId = c.CustomerId
             ORDER BY o.OrderDate DESC", con)

                Using da As New Microsoft.Data.SqlClient.SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

            End Using
        End Using

        Return dt

    End Function

    Public Function GetSalesOrderItems(orderId As Integer) As DataTable

        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(
            "SELECT p.Name AS ProductName,
                    oi.Quantity,
                    oi.UnitPrice,
                    oi.LineTotal
             FROM OrderItems oi
             INNER JOIN Products p ON oi.ProductId = p.ProductId
             WHERE oi.OrderId = @OrderId", con)

                cmd.Parameters.AddWithValue("@OrderId", orderId)

                Using da As New Microsoft.Data.SqlClient.SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

            End Using
        End Using

        Return dt

    End Function



End Class
