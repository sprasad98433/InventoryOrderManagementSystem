Imports Inventory.BLL
Imports Inventory.Contract.Inventory.Contracts.DTOs

Public Class LoginForm

    Private ReadOnly _authService As New AuthService()
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
               String.IsNullOrWhiteSpace(txtPassword.Text) Then

                MessageBox.Show("Please enter username and password")
                Exit Sub
            End If

            Dim user As UserDTO =
                _authService.Login(txtUsername.Text.Trim(), txtPassword.Text)

            ' Store session
            SessionManager.UserId = user.UserId
            SessionManager.Username = user.Username
            SessionManager.Role = user.Role
            SessionManager.IsActive = user.IsActive

            MessageBox.Show("Login successful", "Success")

            ' Open Dashboard
            Dim dash As New DashboardForm()
            dash.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Login Failed")
        End Try
    End Sub

    Private Sub btnGoRegister_Click(sender As Object, e As EventArgs) Handles btnGoRegister.Click
        Dim dash As New RegisterForm()
        dash.Show()
    End Sub
End Class