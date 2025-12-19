Imports Inventory.BLL
Imports Inventory.Contract

Public Class AddSupplierForm
    Private ReadOnly _service As New SupplierService()
    Private _supplierId As Integer = 0

    Private _supplier As SupplierDTO
    ' For ADD
    Public Sub New()
        InitializeComponent()
    End Sub

    ' For EDIT
    Public Sub New(supplier As SupplierDTO)
        InitializeComponent()
        _supplier = supplier
    End Sub

    Private Sub AddSupplierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _supplier IsNot Nothing Then
            txtName.Text = _supplier.Name
            txtEmail.Text = _supplier.ContactEmail
            txtLeadTime.Text = _supplier.LeadTimeDays.ToString()
            chkIsActive.Checked = _supplier.IsActive
        Else
            chkIsActive.Checked = True   ' default for new supplier
        End If
        LoadSuppliers()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try
            ' Basic validation
            If String.IsNullOrWhiteSpace(txtName.Text) Then
                MessageBox.Show("Supplier name is required")
                txtName.Focus()
                Exit Sub
            End If

            Dim leadTime As Integer
            If Not Integer.TryParse(txtLeadTime.Text, leadTime) OrElse leadTime <= 0 Then
                MessageBox.Show("Enter valid lead time (days)")
                txtLeadTime.Focus()
                Exit Sub
            End If

            ' Create DTO
            Dim supplier As New SupplierDTO With {
                .Name = txtName.Text.Trim(),
                .ContactEmail = txtEmail.Text.Trim(),
                .LeadTimeDays = leadTime,
                .IsActive = chkIsActive.Checked
            }

            Dim service As New SupplierService()

            ' ADD or UPDATE
            If _supplierId = 0 Then
                service.AddSupplier(supplier)
                MessageBox.Show("Supplier saved successfully")
            Else
                supplier.SupplierId = _supplier.SupplierId
                service.UpdateSupplier(supplier)
                MessageBox.Show("Supplier Updated successfully")
            End If



            ClearForm()
            LoadSuppliers()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub LoadSuppliers()
        dgvSuppliers.DataSource = _service.GetAllSuppliers()
    End Sub

    Private Sub ClearForm()
        txtName.Clear()
        txtEmail.Clear()
        txtLeadTime.Clear()
        chkIsActive.Checked = True
        _supplierId = 0
    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dgvSuppliers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSuppliers.CellClick

        If e.RowIndex < 0 Then Exit Sub

        _supplierId = Convert.ToInt32(
        dgvSuppliers.Rows(e.RowIndex).Cells("SupplierId").Value)

        Dim dt = _service.GetSupplierById(_supplierId)

        If dt.Rows.Count > 0 Then
            txtName.Text = dt.Rows(0)("Name").ToString()
            txtEmail.Text = dt.Rows(0)("ContactEmail").ToString()
            txtLeadTime.Text = dt.Rows(0)("LeadTimeDays").ToString()
            chkIsActive.Checked = Convert.ToBoolean(dt.Rows(0)("IsActive"))
        End If

    End Sub

End Class