Imports Inventory.BLL
Imports Inventory.Contract
Imports Inventory.DAL

Public Class PurchaseOrderForm
    Private _items As New List(Of PurchaseOrderItemDTO)
    Private Sub PurchaseOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSuppliers()
        LoadProducts()
    End Sub

    Private Sub LoadSuppliers()

        Dim repo As New SupplierRepository()
        Dim dt = repo.GetAllSuppliers()   ' We’ll add this method next

        cmbSupplier.DataSource = dt
        cmbSupplier.DisplayMember = "Name"
        cmbSupplier.ValueMember = "SupplierId"
        cmbSupplier.SelectedIndex = -1

    End Sub

    Private Sub LoadProducts()

        Dim service As New ProductService()
        Dim dt = service.GetReorderProducts()   ' smart default

        cmbProduct.DataSource = dt
        cmbProduct.DisplayMember = "Name"
        cmbProduct.ValueMember = "ProductId"
        cmbProduct.SelectedIndex = -1

    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click


        If cmbProduct.SelectedIndex = -1 Then
            MessageBox.Show("Select a product")
            Exit Sub
        End If

        Dim qty As Integer
        If Not Integer.TryParse(txtQty.Text, qty) OrElse qty <= 0 Then
            MessageBox.Show("Enter valid quantity")
            Exit Sub
        End If

        Dim productId As Integer = Convert.ToInt32(cmbProduct.SelectedValue)

        ' Prevent duplicate products
        If _items.Any(Function(i) i.ProductId = productId) Then
            MessageBox.Show("Product already added")
            Exit Sub
        End If

        Dim item As New PurchaseOrderItemDTO With {
        .ProductId = productId,
        .Quantity = qty
    }

        _items.Add(item)
        BindGrid()

        txtQty.Clear()
        cmbProduct.SelectedIndex = -1

    End Sub
    Private Sub BindGrid()
        dgvItems.DataSource = Nothing
        dgvItems.DataSource = _items
    End Sub

    Private Sub btnSavePO_Click(sender As Object, e As EventArgs) Handles btnSavePO.Click
        Try
            If cmbSupplier.SelectedIndex = -1 Then
                MessageBox.Show("Select supplier")
                Exit Sub
            End If

            If _items.Count = 0 Then
                MessageBox.Show("Add at least one product")
                Exit Sub
            End If

            Dim po As New PurchaseOrderDTO With {
            .SupplierId = Convert.ToInt32(cmbSupplier.SelectedValue),
            .CreatedBy = "Admin"
        }

            po.Items.AddRange(_items)

            Dim service As New PurchaseOrderService()
            Dim poId = service.CreatePurchaseOrder(po)

            MessageBox.Show($"Purchase Order #{poId} created successfully")

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub
End Class