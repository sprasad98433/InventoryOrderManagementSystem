Imports Inventory.BLL
Imports System.Drawing.Printing


Public Class ReceiptForm

    Private _receiptId As Integer
    Private _customerName As String
    Private _receiptDate As DateTime
    Private _amount As Decimal
    Private _paymentMode As String

    Private Sub ReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim service As New ReceiptService()
        dgvReceipts.DataSource = service.GetReceipts()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dgvReceipts.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a receipt to print")
            Exit Sub
        End If

        _receiptId = Convert.ToInt32(
    dgvReceipts.CurrentRow.Cells("ReceiptId").Value)

        _receiptDate = Convert.ToDateTime(
    dgvReceipts.CurrentRow.Cells("ReceiptDate").Value)

        _customerName = dgvReceipts.CurrentRow.Cells("CustomerName").Value.ToString()

        _amount = Convert.ToDecimal(
    dgvReceipts.CurrentRow.Cells("ReceiptTotal").Value)

        _paymentMode = dgvReceipts.CurrentRow.Cells("PaymentMode").Value.ToString()

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage


        Dim g As Graphics = e.Graphics
        Dim titleFont As New Font("Arial", 14, FontStyle.Bold)
        Dim headerFont As New Font("Arial", 10, FontStyle.Bold)
        Dim bodyFont As New Font("Arial", 10)
        Dim y As Integer = 20

        ' ===== HEADER =====
        g.DrawString("INVENTORY SYSTEM", titleFont, Brushes.Black, 80, y)
        y += 30

        g.DrawString("----------------------------------", bodyFont, Brushes.Black, 20, y)
        y += 20

        g.DrawString("Receipt No : " & _receiptId, bodyFont, Brushes.Black, 20, y)
        y += 20

        g.DrawString("Date       : " & _receiptDate.ToShortDateString(), bodyFont, Brushes.Black, 20, y)
        y += 20

        g.DrawString("Customer   : " & _customerName, bodyFont, Brushes.Black, 20, y)
        y += 20

        g.DrawString("----------------------------------", bodyFont, Brushes.Black, 20, y)
        y += 20

        ' ===== ITEM HEADER =====
        g.DrawString("Item", headerFont, Brushes.Black, 20, y)
        g.DrawString("Qty", headerFont, Brushes.Black, 160, y)
        g.DrawString("Price", headerFont, Brushes.Black, 210, y)
        g.DrawString("Total", headerFont, Brushes.Black, 280, y)
        y += 15

        g.DrawString("----------------------------------", bodyFont, Brushes.Black, 20, y)
        y += 15

        ' ===== ITEM LINES =====
        Dim receiptTotal As Decimal = 0D

        For Each row As DataGridViewRow In dgvReceipts.Rows

            ' 🔒 SAFETY CHECKS
            If row.IsNewRow Then Continue For
            If row.Cells("ReceiptId").Value Is Nothing Then Continue For

            If Convert.ToInt32(row.Cells("ReceiptId").Value) = _receiptId Then

                Dim productName As String = row.Cells("ProductName").Value.ToString()
                Dim qty As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                Dim price As Decimal = Convert.ToDecimal(row.Cells("UnitPrice").Value)
                Dim lineTotal As Decimal = Convert.ToDecimal(row.Cells("LineTotal").Value)

                g.DrawString(productName, bodyFont, Brushes.Black, 20, y)
                g.DrawString(qty.ToString(), bodyFont, Brushes.Black, 165, y)
                g.DrawString(price.ToString("0.00"), bodyFont, Brushes.Black, 210, y)
                g.DrawString(lineTotal.ToString("0.00"), bodyFont, Brushes.Black, 280, y)

                receiptTotal += lineTotal
                y += 18
            End If

        Next

        ' ===== TOTAL =====
        y += 10
        g.DrawString("----------------------------------", bodyFont, Brushes.Black, 20, y)
        y += 20

        g.DrawString("TOTAL AMOUNT : ₹ " & receiptTotal.ToString("0.00"),
                     headerFont, Brushes.Black, 20, y)
        y += 25

        g.DrawString("Payment Mode : " & _paymentMode, bodyFont, Brushes.Black, 20, y)
        y += 25

        g.DrawString("----------------------------------", bodyFont, Brushes.Black, 20, y)
        y += 30

        g.DrawString("Thank you for your business!", bodyFont, Brushes.Black, 40, y)


    End Sub
End Class