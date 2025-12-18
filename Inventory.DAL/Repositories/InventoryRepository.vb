Imports System.Data
Imports Inventory.Contract
Imports Inventory.Infrastructure
Imports Microsoft.Data.SqlClient

Public Class InventoryRepository

    Public Sub AddInventoryTransaction(tx As InventoryTransactionDTO)

        Using con = DbConnectionFactory.Create()
            con.Open()

            Dim sqlTransaction As SqlTransaction = con.BeginTransaction()

            Try
                ' 1. Insert inventory transaction
                Using cmdInsert As New SqlCommand(
                    "INSERT INTO InventoryTransactions
                     (ProductId, TransactionType, Quantity, ReferenceNo, Remarks, CreatedBy)
                     VALUES
                     (@ProductId, @TransactionType, @Quantity, @ReferenceNo, @Remarks, @CreatedBy)",
                    con, sqlTransaction)

                    cmdInsert.Parameters.AddWithValue("@ProductId", tx.ProductId)
                    cmdInsert.Parameters.AddWithValue("@TransactionType", tx.TransactionType)
                    cmdInsert.Parameters.AddWithValue("@Quantity", tx.Quantity)
                    cmdInsert.Parameters.AddWithValue("@ReferenceNo", If(tx.ReferenceNo, DBNull.Value))
                    cmdInsert.Parameters.AddWithValue("@Remarks", If(tx.Remarks, DBNull.Value))
                    cmdInsert.Parameters.AddWithValue("@CreatedBy", If(tx.CreatedBy, DBNull.Value))

                    cmdInsert.ExecuteNonQuery()
                End Using

                ' 2. Update product quantity
                Dim qtyExpression As String =
                    If(tx.TransactionType = "IN",
                       "QuantityOnHand = QuantityOnHand + @Qty",
                       "QuantityOnHand = QuantityOnHand - @Qty")

                Using cmdUpdate As New SqlCommand(
                    $"UPDATE Products SET {qtyExpression}
                      WHERE ProductId = @ProductId",
                    con, sqlTransaction)

                    cmdUpdate.Parameters.AddWithValue("@Qty", tx.Quantity)
                    cmdUpdate.Parameters.AddWithValue("@ProductId", tx.ProductId)

                    cmdUpdate.ExecuteNonQuery()
                End Using

                ' 3. Commit transaction
                sqlTransaction.Commit()

            Catch
                sqlTransaction.Rollback()
                Throw
            End Try

        End Using

    End Sub

    Public Function GetInventoryTransactions() As DataTable

        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
            "SELECT 
                it.TransactionId,
                p.Name AS ProductName,
                it.TransactionType,
                it.Quantity,
                p.QuantityOnHand,
                it.ReferenceNo,
                it.Remarks,
                it.TransactionDate
             FROM InventoryTransactions it
             INNER JOIN Products p ON it.ProductId = p.ProductId
             ORDER BY it.TransactionDate DESC", con)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

            End Using
        End Using

        Return dt

    End Function


End Class
