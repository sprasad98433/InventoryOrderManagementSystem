Imports System.Data
Imports Inventory.Contract
Imports Inventory.Infrastructure
Imports Microsoft.Data.SqlClient

Public Class CustomerRepository

    ' Used for dropdowns (Sales Order)
    Public Function GetAllCustomers() As DataTable

        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
                "SELECT CustomerId, Name
                 FROM Customers
                 WHERE IsActive = 1
                 ORDER BY Name", con)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function


    ' Used for Customer Master screen
    Public Function GetCustomers() As DataTable

        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
                "SELECT CustomerId, Name, Email, Phone, IsActive
                 FROM Customers
                 ORDER BY Name", con)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function


    Public Sub AddCustomer(c As CustomerDTO)

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
                "INSERT INTO Customers
                 (Name, Email, Phone, IsActive)
                 VALUES
                 (@Name, @Email, @Phone, 1)", con)

                cmd.Parameters.AddWithValue("@Name", c.Name)
                cmd.Parameters.AddWithValue("@Email", c.Email)
                cmd.Parameters.AddWithValue("@Phone", c.Phone)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub


    Public Sub UpdateCustomer(c As CustomerDTO)

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
                "UPDATE Customers
                 SET Name=@Name,
                     Email=@Email,
                     Phone=@Phone,
                     IsActive=@IsActive
                 WHERE CustomerId=@CustomerId", con)

                cmd.Parameters.AddWithValue("@Name", c.Name)
                cmd.Parameters.AddWithValue("@Email", c.Email)
                cmd.Parameters.AddWithValue("@Phone", c.Phone)
                cmd.Parameters.AddWithValue("@IsActive", c.IsActive)
                cmd.Parameters.AddWithValue("@CustomerId", c.CustomerId)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

End Class

