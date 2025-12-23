Imports Inventory.Contract.Inventory.Contracts.DTOs
Imports Inventory.DAL
Imports Inventory.Infrastructure

Public Class AuthService

    Private ReadOnly _repo As New UserRepository()

    ' =========================
    ' REGISTER USER (ADMIN ONLY)
    ' =========================
    Public Sub Register(user As UserDTO)



        If String.IsNullOrWhiteSpace(user.Username) Then
            Throw New Exception("Username is required")
        End If

        If String.IsNullOrWhiteSpace(user.Password) Then
            Throw New Exception("Password is required")
        End If

        If String.IsNullOrWhiteSpace(user.Email) Then
            Throw New Exception("Email is required")
        End If

        ' 🔒 Enforce system rules
        user.Role = "User"        ' Default role
        user.IsActive = True      ' Default active

        ' Hash password
        Dim passwordHash As String = PasswordHasher.Hash(user.Password)

        _repo.Register(user, passwordHash)




    End Sub

    ' =========
    ' LOGIN USER
    ' =========
    Public Function Login(username As String, password As String) As UserDTO

        If String.IsNullOrWhiteSpace(username) OrElse
       String.IsNullOrWhiteSpace(password) Then
            Throw New Exception("Username and password are required")
        End If

        Dim hash As String = PasswordHasher.Hash(password)
        Dim dt = _repo.Login(username, hash)

        If dt.Rows.Count = 0 Then
            Throw New Exception("Invalid username, password, or inactive account")
        End If

        Return New UserDTO With {
            .UserId = Convert.ToInt32(dt.Rows(0)("UserId")),
            .Username = dt.Rows(0)("Username").ToString(),
            .Role = dt.Rows(0)("Role").ToString()
        }


    End Function

End Class
