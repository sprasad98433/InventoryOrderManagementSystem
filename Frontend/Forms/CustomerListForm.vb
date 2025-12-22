Imports Inventory.BLL
Imports Inventory.Contract

Public Class CustomerListForm
    Private Sub CustomerListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub
    Private Sub LoadCustomers()
        Dim service As New CustomerService()
        dgvCustomers.DataSource = service.GetCustomers()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New AddCustomerForm()
        If frm.ShowDialog() = DialogResult.OK Then
            LoadCustomers()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvCustomers.CurrentRow Is Nothing Then
            MessageBox.Show("Select a customer")
            Exit Sub
        End If

        Dim customer As New CustomerDTO With {
        .CustomerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells("CustomerId").Value),
        .Name = dgvCustomers.CurrentRow.Cells("Name").Value.ToString(),
        .Email = dgvCustomers.CurrentRow.Cells("Email").Value.ToString(),
        .Phone = dgvCustomers.CurrentRow.Cells("Phone").Value.ToString(),
        .IsActive = Convert.ToBoolean(dgvCustomers.CurrentRow.Cells("IsActive").Value)
    }

        Dim frm As New AddCustomerForm()
        If frm.ShowDialog() = DialogResult.OK Then
            LoadCustomers()
        End If

    End Sub
End Class