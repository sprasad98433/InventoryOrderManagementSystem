Imports System.Data
Imports Inventory.Contract
Imports Inventory.Infrastructure
Imports Microsoft.Data.SqlClient

Public Class SupplierRepository

    Public Function SupplierExists(supplierId As Integer) As Boolean

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
                "SELECT COUNT(1)
                 FROM Suppliers
                 WHERE SupplierId = @SupplierId
                   AND IsActive = 1", con)

                cmd.Parameters.AddWithValue("@SupplierId", supplierId)

                con.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                Return count > 0
            End Using
        End Using

    End Function
    'For combo boxes and dropdowns
    Public Function GetAllSuppliers() As DataTable

        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
            "SELECT SupplierId, Name
             FROM Suppliers
             WHERE IsActive = 1
             ORDER BY Name", con)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

            End Using
        End Using

        Return dt

    End Function
    Public Sub AddSupplier(s As SupplierDTO)

        Using con = DbConnectionFactory.Create()
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(
            "INSERT INTO Suppliers
             (Name, ContactEmail, LeadTimeDays, IsActive)
             VALUES
             (@Name, @Email, @LeadTimeDays, 1)", con)

                cmd.Parameters.AddWithValue("@Name", s.Name)
                cmd.Parameters.AddWithValue("@Email", s.ContactEmail)
                cmd.Parameters.AddWithValue("@LeadTimeDays", s.LeadTimeDays)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub
    Public Function GetSuppliers() As DataTable
        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
            "SELECT SupplierId, Name, ContactEmail, LeadTimeDays, IsActive
             FROM Suppliers
             ORDER BY Name", con)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Public Function GetSupplierById(supplierId As Integer) As DataTable
        Dim dt As New DataTable()

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
                "SELECT SupplierId, Name, ContactEmail, LeadTimeDays, IsActive
                 FROM Suppliers
                 WHERE SupplierId = @SupplierId", con)

                cmd.Parameters.AddWithValue("@SupplierId", supplierId)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Public Sub AddSupplier(name As String,
                           contactEmail As String,
                           leadTimeDays As Integer,
                           isActive As Boolean)

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
                "INSERT INTO Suppliers (Name, ContactEmail, LeadTimeDays, IsActive)
                 VALUES (@Name, @ContactEmail, @LeadTimeDays, @IsActive)", con)

                cmd.Parameters.AddWithValue("@Name", name)
                cmd.Parameters.AddWithValue("@ContactEmail", contactEmail)
                cmd.Parameters.AddWithValue("@LeadTimeDays", leadTimeDays)
                cmd.Parameters.AddWithValue("@IsActive", isActive)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    ' Update supplier
    Public Sub UpdateSupplier(Supplier As Contract.SupplierDTO)

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
                "UPDATE Suppliers
                 SET Name = @Name,
                     ContactEmail = @ContactEmail,
                     LeadTimeDays = @LeadTimeDays,
                     IsActive = @IsActive
                 WHERE SupplierId = @SupplierId", con)

                cmd.Parameters.AddWithValue("@SupplierId", Supplier.SupplierId)
                cmd.Parameters.AddWithValue("@Name", Supplier.Name)
                cmd.Parameters.AddWithValue("@ContactEmail", Supplier.ContactEmail)
                cmd.Parameters.AddWithValue("@LeadTimeDays", Supplier.LeadTimeDays)
                cmd.Parameters.AddWithValue("@IsActive", Supplier.IsActive)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    ' Soft delete / deactivate supplier
    Public Sub DeactivateSupplier(supplierId As Integer)

        Using con = DbConnectionFactory.Create()
            Using cmd As New SqlCommand(
                "UPDATE Suppliers
                 SET IsActive = 0
                 WHERE SupplierId = @SupplierId", con)

                cmd.Parameters.AddWithValue("@SupplierId", supplierId)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

End Class
