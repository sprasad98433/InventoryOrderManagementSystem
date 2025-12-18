Imports System.IO
Imports Inventory.BLL




Public Class RegisterForm
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Load roles
        cmbRole.Items.Add("Admin")
        cmbRole.Items.Add("User")
        cmbRole.SelectedIndex = 1   ' Default User

        ' Load status
        cmbStatus.Items.Add("Active")
        cmbStatus.Items.Add("Inactive")
        cmbStatus.SelectedIndex = 0 ' Default Active
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim _auth As New AuthService()
        Try
            ' Basic UI validation
            If String.IsNullOrWhiteSpace(txtUsername.Text) Then
                MessageBox.Show("Username is required")
                txtUsername.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(txtPassword.Text) Then
                MessageBox.Show("Password is required")
                txtPassword.Focus()
                Exit Sub
            End If

            Dim user As New UserDTO With {
                .Username = txtUsername.Text.Trim(),
                .Password = txtPassword.Text,
                .Role = cmbRole.Text,
                .IsActive = (cmbStatus.Text = "Active")
            }

            _auth.Register(user)

            'MessageBox.Show("User registered successfully", "Success")
            Dim dash As New LoginForm()
            dash.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class