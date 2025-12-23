Imports System.Data
Imports Inventory.Contract.Inventory.Contracts.DTOs
Imports Inventory.Infrastructure
Imports Microsoft.Data.SqlClient





Public Class UserRepository

    Public Sub Register(user As UserDTO, passwordHash As String)

        Using con = DbConnectionFactory.Create()
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(
            "INSERT INTO Users 
            (FullName, Username, PasswordHash, Email, Phone, Address, Role, IsActive, CreatedBy)
            VALUES
            (@FullName, @Username, @PasswordHash, @Email, @Phone, @Address, @Role, @IsActive, @CreatedBy)", con)

                cmd.Parameters.AddWithValue("@FullName", user.FullName)
                cmd.Parameters.AddWithValue("@Username", user.Username)
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash)
                cmd.Parameters.AddWithValue("@Email", user.Email)
                cmd.Parameters.AddWithValue("@Phone", user.Phone)
                cmd.Parameters.AddWithValue("@Address", user.Address)
                cmd.Parameters.AddWithValue("@Role", user.Role)
                cmd.Parameters.AddWithValue("@IsActive", user.IsActive)
                cmd.Parameters.AddWithValue("@CreatedBy", user.CreatedBy)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub


    Public Function Login(username As String, passwordHash As String) As DataTable

        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
                "SELECT UserId, Username, Role
             FROM Users
             WHERE Username = @u
               AND PasswordHash = @p
               AND IsActive = 1", con)

                cmd.Parameters.AddWithValue("@u", username)
                cmd.Parameters.AddWithValue("@p", passwordHash)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

            End Using
        End Using

        Return dt

    End Function




End Class
