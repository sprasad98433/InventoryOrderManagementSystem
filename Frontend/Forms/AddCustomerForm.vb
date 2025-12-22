Imports Inventory.BLL
Imports Inventory.Contract

Public Class AddCustomerForm
    Private _customer As CustomerDTO = Nothing

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Basic validation
            If String.IsNullOrWhiteSpace(txtName.Text) Then
                MessageBox.Show("Customer name is required")
                txtName.Focus()
                Exit Sub
            End If

            ' Create DTO
            Dim customer As New CustomerDTO With {
            .Name = txtName.Text.Trim(),
            .Email = txtEmail.Text.Trim(),
            .Phone = txtPhone.Text.Trim(),
            .IsActive = chkIsActive.Checked
        }

            ' Save
            Dim service As New CustomerService()
            service.AddCustomer(customer)

            MessageBox.Show("Customer added successfully")

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class