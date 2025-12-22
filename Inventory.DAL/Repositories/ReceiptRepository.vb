Imports System.Data
Imports Inventory.Contract
Imports Inventory.Infrastructure
Imports Microsoft.Data.SqlClient

Public Class ReceiptRepository

    Public Sub AddReceipt(receipt As ReceiptDTO)

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
                "INSERT INTO Receipts
                 (CustomerId, ReceiptDate, Amount, PaymentMode, ReferenceNo)
                 VALUES
                 (@CustomerId, @ReceiptDate, @Amount, @PaymentMode, @ReferenceNo)", con)

                cmd.Parameters.AddWithValue("@CustomerId", receipt.CustomerId)
                cmd.Parameters.AddWithValue("@ReceiptDate", receipt.ReceiptDate)
                cmd.Parameters.AddWithValue("@Amount", receipt.Amount)
                cmd.Parameters.AddWithValue("@PaymentMode", receipt.PaymentMode)
                cmd.Parameters.AddWithValue("@ReferenceNo",
                    If(String.IsNullOrWhiteSpace(receipt.ReferenceNo),
                       DBNull.Value,
                       receipt.ReferenceNo))

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub


    Public Function GetReceipts() As DataTable

        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(
            "SELECT
            r.ReceiptId,
            r.ReceiptDate,
            c.Name AS CustomerName,
            p.Name AS ProductName,
            oi.UnitPrice,
            oi.Quantity,
            oi.LineTotal,
            r.Amount AS ReceiptTotal,
            r.PaymentMode,
            r.ReferenceNo
         FROM Receipts r
         INNER JOIN Orders o ON r.CustomerId = o.CustomerId 
                             AND r.ReceiptDate = o.OrderDate
         INNER JOIN OrderItems oi ON o.OrderId = oi.OrderId
         INNER JOIN Products p ON oi.ProductId = p.ProductId
         INNER JOIN Customers c ON r.CustomerId = c.CustomerId
         ORDER BY r.ReceiptDate DESC", con)

                Using da As New Microsoft.Data.SqlClient.SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

            End Using
        End Using

        Return dt

    End Function


End Class

