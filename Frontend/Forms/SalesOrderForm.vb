Imports Inventory.BLL
Imports Inventory.Contract

Public Class SalesOrderForm
    Dim service As New SalesOrderService()
    Private Sub SalesOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
        LoadProducts()
    End Sub

    Private Sub cmbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduct.SelectedIndexChanged
        If cmbProduct.SelectedIndex = -1 Then Exit Sub

        Dim row As DataRowView =
            CType(cmbProduct.SelectedItem, DataRowView)

        txtSKU.Text = row("SKU").ToString()
        txtUnitPrice.Text = row("UnitPrice").ToString()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        ' Validation
        If cmbProduct.SelectedIndex = -1 Then
            MessageBox.Show("Please select a product")
            Exit Sub
        End If

        Dim qty As Integer
        If Not Integer.TryParse(txtQuantity.Text, qty) OrElse qty <= 0 Then
            MessageBox.Show("Enter valid quantity")
            Exit Sub
        End If

        Dim price As Decimal =
        Convert.ToDecimal(txtUnitPrice.Text)

        Dim lineTotal As Decimal = qty * price

        ' Add row to grid
        dgvItems.Rows.Add(
        cmbProduct.SelectedValue,   ' ProductId (hidden)
        cmbProduct.Text,            ' ProductName
        qty,
        price,
        lineTotal
    )

        CalculateTotal()

        ' Clear inputs
        cmbProduct.SelectedIndex = -1
        txtSKU.Clear()
        txtUnitPrice.Clear()
        txtQuantity.Clear()

    End Sub

    Private Sub CalculateTotal()

        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgvItems.Rows
            total += Convert.ToDecimal(row.Cells("LineTotal").Value)
        Next

        lblTotalAmount.Text = total.ToString("0.00")

    End Sub

    Private Sub LoadCustomers()

        Dim service As New CustomerService()
        Dim dt As DataTable = service.GetAllCustomers()

        If dt.Rows.Count = 0 Then
            MessageBox.Show("No customers found")
        End If

        cmbCustomer.DataSource = dt
        cmbCustomer.DisplayMember = "Name"
        cmbCustomer.ValueMember = "CustomerId"
        cmbCustomer.SelectedIndex = -1

    End Sub
    Private Sub LoadProducts()

        Dim service As New ProductService()
        Dim dt As DataTable = service.GetAllProducts()

        If dt.Rows.Count = 0 Then
            MessageBox.Show("No products found")
        End If

        cmbProduct.DataSource = dt
        cmbProduct.DisplayMember = "Name"
        cmbProduct.ValueMember = "ProductId"
        cmbProduct.SelectedIndex = -1

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If cmbCustomer.SelectedIndex = -1 Then
                MessageBox.Show("Select customer")
                Exit Sub
            End If

            Dim order As New SalesOrderDTO With {
                .CustomerId = Convert.ToInt32(cmbCustomer.SelectedValue),
                .OrderDate = dtpOrderDate.Value,
                .TotalAmount = Convert.ToDecimal(lblTotalAmount.Text),
                .Items = BuildOrderItems()
            }

            Dim service As New SalesOrderService()
            service.SaveOrder(order)

            MessageBox.Show("Sales order saved successfully")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Function BuildOrderItems() As List(Of SalesOrderItemDTO)
        Dim items As New List(Of SalesOrderItemDTO)

        For Each row As DataGridViewRow In dgvItems.Rows
            items.Add(New SalesOrderItemDTO With {
            .ProductId = Convert.ToInt32(row.Cells("ProductId").Value),
            .Quantity = Convert.ToInt32(row.Cells("Quantit").Value),
            .UnitPrice = Convert.ToDecimal(row.Cells("UnitPrice").Value),
            .LineTotal = Convert.ToDecimal(row.Cells("LineTotal").Value)
        })
        Next

        Return items
    End Function

End Class