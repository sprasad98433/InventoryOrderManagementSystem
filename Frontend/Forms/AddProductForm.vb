Imports Inventory.BLL
Imports Inventory.Contract


Public Class AddProductForm

    Private _productId As Integer = 0
    Public Sub New(productId As Integer)
        InitializeComponent()
        _productId = productId
    End Sub

    Private Sub AddProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _productId > 0 Then
            LoadProductForEdit()
            Me.Text = "Edit Product"
            btnSave.Text = "Update"
        End If

    End Sub
    Private Sub LoadProductForEdit()

        Dim service As New ProductService()
        Dim dt = service.GetProductById(_productId)

        If dt.Rows.Count = 0 Then Exit Sub

        Dim row = dt.Rows(0)

        txtName.Text = row("Name").ToString()
        txtSKU.Text = row("SKU").ToString()
        txtUnitPrice.Text = row("UnitPrice").ToString()
        txtQuantity.Text = row("QuantityOnHand").ToString()
        txtReorderLevel.Text = row("ReorderLevel").ToString()
        txtSupplierId.Text = row("SupplierId").ToString()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            ' 1. Basic UI validation
            If String.IsNullOrWhiteSpace(txtName.Text) Then
                MessageBox.Show("Product name is required")
                txtName.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(txtSKU.Text) Then
                MessageBox.Show("SKU is required")
                txtSKU.Focus()
                Exit Sub
            End If

            ' 2. Convert numeric values safely
            Dim unitPrice As Decimal
            If Not Decimal.TryParse(txtUnitPrice.Text, unitPrice) Then
                MessageBox.Show("Enter valid unit price")
                txtUnitPrice.Focus()
                Exit Sub
            End If

            Dim quantity As Integer
            If Not Integer.TryParse(txtQuantity.Text, quantity) Then
                MessageBox.Show("Enter valid quantity")
                txtQuantity.Focus()
                Exit Sub
            End If

            Dim reorderLevel As Integer
            If Not Integer.TryParse(txtReorderLevel.Text, reorderLevel) Then
                MessageBox.Show("Enter valid reorder level")
                txtReorderLevel.Focus()
                Exit Sub
            End If

            Dim supplierId As Integer
            If Not Integer.TryParse(txtSupplierId.Text, supplierId) Then
                MessageBox.Show("Enter valid supplier id")
                txtSupplierId.Focus()
                Exit Sub
            End If

            ' 3. Create ProductDTO
            Dim product As New ProductDTO With {
            .Name = txtName.Text.Trim(),
            .SKU = txtSKU.Text.Trim(),
            .UnitPrice = unitPrice,
            .QuantityOnHand = quantity,
            .ReorderLevel = reorderLevel,
            .SupplierId = supplierId
        }

            ' 4. Call BLL
            Dim service As New ProductService()

            If _productId = 0 Then
                service.AddProduct(product)
                MessageBox.Show("Product added successfully", "Success")
                ClearForm()
            Else
                product.ProductId = _productId
                service.UpdateProduct(product)
                MessageBox.Show("Product updated successfully", "Success")
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub


    Private Sub ClearForm()
        txtName.Clear()
        txtSKU.Clear()
        txtUnitPrice.Clear()
        txtQuantity.Clear()
        txtReorderLevel.Clear()
        txtSupplierId.Clear()
        txtName.Focus()
    End Sub

End Class