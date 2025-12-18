Imports Inventory.BLL
Imports Inventory.Contract

Public Class InventoryTransactionForm
    Private Sub InventoryTransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
        LoadTransactionTypes()
    End Sub
    Private Sub LoadProducts()

        Dim service As New ProductService()
        Dim dt = service.GetAllProducts()

        cmbProduct.DataSource = dt
        cmbProduct.DisplayMember = "Name"
        cmbProduct.ValueMember = "ProductId"
        cmbProduct.SelectedIndex = -1

    End Sub
    Private Sub LoadTransactionTypes()
        cmbTransactionType.Items.Clear()
        cmbTransactionType.Items.Add("IN")
        cmbTransactionType.Items.Add("OUT")
        cmbTransactionType.SelectedIndex = -1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If cmbProduct.SelectedIndex = -1 Then
                MessageBox.Show("Please select a product")
                Exit Sub
            End If

            If cmbTransactionType.SelectedIndex = -1 Then
                MessageBox.Show("Please select transaction type")
                Exit Sub
            End If

            Dim qty As Integer
            If Not Integer.TryParse(txtQuantity.Text, qty) Then
                MessageBox.Show("Enter valid quantity")
                Exit Sub
            End If

            Dim tx As New InventoryTransactionDTO With {
                .ProductId = Convert.ToInt32(cmbProduct.SelectedValue),
                .TransactionType = cmbTransactionType.SelectedItem.ToString(),
                .Quantity = qty,
                .ReferenceNo = txtReference.Text.Trim(),
                .Remarks = txtRemarks.Text.Trim(),
                .CreatedBy = "Admin"   ' later from login
            }

            Dim service As New InventoryService()
            service.AddTransaction(tx)

            MessageBox.Show("Inventory transaction saved successfully")

            ClearForm()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
    Private Sub ClearForm()
        cmbProduct.SelectedIndex = -1
        cmbTransactionType.SelectedIndex = -1
        txtQuantity.Clear()
        txtReference.Clear()
        txtRemarks.Clear()
    End Sub

End Class