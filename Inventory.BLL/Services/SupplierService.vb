Imports System.Data
Imports Inventory.DAL

Public Class SupplierService
    Private ReadOnly _supplierRepository As SupplierRepository

    ' Constructor
    Public Sub New()
        _supplierRepository = New SupplierRepository()
    End Sub

    ' Get all active suppliers
    Public Function GetAllSuppliers() As DataTable
        Return _supplierRepository.GetAllSuppliers()
    End Function

    ' Get supplier by Id
    Public Function GetSupplierById(supplierId As Integer) As DataTable
        Return _supplierRepository.GetSupplierById(supplierId)
    End Function

    ' Add new supplier
    Public Sub AddSupplier(Supplier As Contract.SupplierDTO)

        _supplierRepository.AddSupplier(Supplier)

    End Sub

    ' Update supplier
    Public Sub UpdateSupplier(Supplier As Contract.SupplierDTO)

        _supplierRepository.UpdateSupplier(Supplier)

    End Sub

    ' Soft delete / deactivate supplier
    Public Sub DeactivateSupplier(supplierId As Integer)
        _supplierRepository.DeactivateSupplier(supplierId)
    End Sub

End Class

