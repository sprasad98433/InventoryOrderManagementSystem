Imports Inventory.BLL
Imports Inventory.Contract.Inventory.Contracts.DTOs

Public Class RegisterForm
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            ' 1. Basic validation
            If String.IsNullOrWhiteSpace(txtFullName.Text) Then
                MessageBox.Show("Full Name is required")
                txtFullName.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(txtUsername.Text) Then
                MessageBox.Show("Username is required")
                txtUsername.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(txtEmail.Text) Then
                MessageBox.Show("Email is required")
                txtEmail.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(txtPassword.Text) Then
                MessageBox.Show("Password is required")
                txtPassword.Focus()
                Exit Sub
            End If

            If txtPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("Password and Confirm Password do not match")
                txtConfirmPassword.Focus()
                Exit Sub
            End If

            ' 2. Create DTO
            Dim user As New UserDTO With {
            .FullName = txtFullName.Text.Trim(),
            .Username = txtUsername.Text.Trim(),
            .Email = txtEmail.Text.Trim(),
            .Phone = txtPhone.Text.Trim(),
            .Address = txtAddress.Text.Trim(),
            .Password = txtPassword.Text,
            .CreatedBy = txtUsername.Text.Trim()
        }

            ' 3. Call BLL
            Dim auth As New AuthService()
            auth.Register(user)

            ' 4. Success
            MessageBox.Show("Registration successful. Please login.", "Success")

            ' 5. Redirect to Login
            Dim login As New LoginForm()
            login.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub
End Class