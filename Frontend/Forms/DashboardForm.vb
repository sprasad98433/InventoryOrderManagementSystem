Public Class DashboardForm
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name As String = SessionManager.Username
        Label1.Text = "Welcome, " & name & "!"
    End Sub
End Class