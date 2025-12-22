Imports System.Data
Imports Inventory.Contract
Imports Inventory.DAL

Public Class CustomerService

    Private ReadOnly _repo As New CustomerRepository()

    Public Function GetAllCustomers() As DataTable
        Return _repo.GetAllCustomers()
    End Function

    Public Function GetCustomers() As DataTable
        Return _repo.GetCustomers()
    End Function

    Public Sub AddCustomer(c As CustomerDTO)

        If String.IsNullOrWhiteSpace(c.Name) Then
            Throw New Exception("Customer name is required")
        End If

        _repo.AddCustomer(c)
    End Sub

    Public Sub UpdateCustomer(c As CustomerDTO)
        _repo.UpdateCustomer(c)
    End Sub

End Class

