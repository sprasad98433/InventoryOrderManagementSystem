Imports Inventory.Contract.Inventory.Contracts.DTOs
Imports Inventory.DAL
Imports Inventory.Infrastructure

Public Class AuthService

    Private ReadOnly _repo As New UserRepository()

    ' =========================
    ' REGISTER USER (ADMIN ONLY)
    ' =========================
    Public Sub Register(user As UserDTO)

        ' Business validation
        If String.IsNullOrWhiteSpace(user.Username) Then
            Throw New Exception("Username is required")
        End If

        If String.IsNullOrWhiteSpace(user.Password) Then
            Throw New Exception("Password is required")
        End If

        If String.IsNullOrWhiteSpace(user.Email) Then
            Throw New Exception("Email is required")
        End If

        ' Hash password in BLL
        Dim passwordHash As String = PasswordHasher.Hash(user.Password)

        ' Call DAL (pass DTO + hash)
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

        ' Map DAL result to DTO
        Return New UserDTO With {
            .UserId = CInt(dt.Rows(0)("UserId")),
            .FullName = dt.Rows(0)("FullName").ToString(),
            .username = dt.Rows(0)("Username").ToString(),
            .Email = dt.Rows(0)("Email").ToString(),
            .Phone = dt.Rows(0)("Phone").ToString(),
            .Address = dt.Rows(0)("Address").ToString(),
            .Role = dt.Rows(0)("Role").ToString(),
            .IsActive = CBool(dt.Rows(0)("IsActive"))
        }

    End Function

End Class
