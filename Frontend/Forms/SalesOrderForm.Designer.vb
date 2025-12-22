<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesOrderForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        cmbCustomer = New ComboBox()
        Label2 = New Label()
        dtpOrderDate = New DateTimePicker()
        Label3 = New Label()
        cmbProduct = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        txtSKU = New TextBox()
        txtUnitPrice = New TextBox()
        Quantity = New Label()
        txtQuantity = New TextBox()
        btnAddItem = New Button()
        dgvItems = New DataGridView()
        ProductId = New DataGridViewTextBoxColumn()
        ProductName = New DataGridViewTextBoxColumn()
        Quantit = New DataGridViewTextBoxColumn()
        UnitPrice = New DataGridViewTextBoxColumn()
        LineTotal = New DataGridViewTextBoxColumn()
        Label6 = New Label()
        lblTotalAmount = New TextBox()
        btnSave = New Button()
        CType(dgvItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(110, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 25)
        Label1.TabIndex = 0
        Label1.Text = "Customer"
        ' 
        ' cmbCustomer
        ' 
        cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCustomer.FormattingEnabled = True
        cmbCustomer.Location = New Point(233, 69)
        cmbCustomer.Name = "cmbCustomer"
        cmbCustomer.Size = New Size(182, 33)
        cmbCustomer.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(120, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 25)
        Label2.TabIndex = 2
        Label2.Text = "Date"
        ' 
        ' dtpOrderDate
        ' 
        dtpOrderDate.Location = New Point(233, 136)
        dtpOrderDate.Name = "dtpOrderDate"
        dtpOrderDate.Size = New Size(192, 31)
        dtpOrderDate.TabIndex = 3
        dtpOrderDate.Value = New Date(2025, 12, 22, 9, 5, 8, 0)
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(110, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 25)
        Label3.TabIndex = 4
        Label3.Text = "Product"
        ' 
        ' cmbProduct
        ' 
        cmbProduct.FormattingEnabled = True
        cmbProduct.Location = New Point(233, 213)
        cmbProduct.Name = "cmbProduct"
        cmbProduct.Size = New Size(182, 33)
        cmbProduct.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(120, 282)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 25)
        Label4.TabIndex = 6
        Label4.Text = "SKU"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(110, 343)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 25)
        Label5.TabIndex = 7
        Label5.Text = "Unit Price"
        ' 
        ' txtSKU
        ' 
        txtSKU.Location = New Point(233, 282)
        txtSKU.Name = "txtSKU"
        txtSKU.ReadOnly = True
        txtSKU.Size = New Size(182, 31)
        txtSKU.TabIndex = 8
        ' 
        ' txtUnitPrice
        ' 
        txtUnitPrice.Location = New Point(233, 343)
        txtUnitPrice.Name = "txtUnitPrice"
        txtUnitPrice.ReadOnly = True
        txtUnitPrice.Size = New Size(182, 31)
        txtUnitPrice.TabIndex = 9
        ' 
        ' Quantity
        ' 
        Quantity.AutoSize = True
        Quantity.Location = New Point(110, 423)
        Quantity.Name = "Quantity"
        Quantity.Size = New Size(80, 25)
        Quantity.TabIndex = 10
        Quantity.Text = "Quantity"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(233, 420)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(182, 31)
        txtQuantity.TabIndex = 11
        ' 
        ' btnAddItem
        ' 
        btnAddItem.Location = New Point(181, 504)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(112, 34)
        btnAddItem.TabIndex = 12
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = True
        ' 
        ' dgvItems
        ' 
        dgvItems.AllowUserToAddRows = False
        dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvItems.Columns.AddRange(New DataGridViewColumn() {ProductId, ProductName, Quantit, UnitPrice, LineTotal})
        dgvItems.Location = New Point(462, 69)
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        dgvItems.RowHeadersWidth = 62
        dgvItems.Size = New Size(593, 225)
        dgvItems.TabIndex = 13
        ' 
        ' ProductId
        ' 
        ProductId.HeaderText = "ProductId"
        ProductId.MinimumWidth = 8
        ProductId.Name = "ProductId"
        ProductId.ReadOnly = True
        ProductId.Visible = False
        ' 
        ' ProductName
        ' 
        ProductName.HeaderText = "ProductName"
        ProductName.MinimumWidth = 8
        ProductName.Name = "ProductName"
        ProductName.ReadOnly = True
        ' 
        ' Quantit
        ' 
        Quantit.HeaderText = "QTY"
        Quantit.MinimumWidth = 8
        Quantit.Name = "Quantit"
        Quantit.ReadOnly = True
        ' 
        ' UnitPrice
        ' 
        UnitPrice.HeaderText = "Price"
        UnitPrice.MinimumWidth = 8
        UnitPrice.Name = "UnitPrice"
        UnitPrice.ReadOnly = True
        ' 
        ' LineTotal
        ' 
        LineTotal.HeaderText = "Total"
        LineTotal.MinimumWidth = 8
        LineTotal.Name = "LineTotal"
        LineTotal.ReadOnly = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(741, 495)
        Label6.Name = "Label6"
        Label6.Size = New Size(119, 25)
        Label6.TabIndex = 14
        Label6.Text = "Total Amount"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.Location = New Point(877, 489)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.ReadOnly = True
        lblTotalAmount.Size = New Size(150, 31)
        lblTotalAmount.TabIndex = 15
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(422, 504)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 16
        btnSave.Text = "Sold"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' SalesOrderForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1112, 573)
        Controls.Add(btnSave)
        Controls.Add(lblTotalAmount)
        Controls.Add(Label6)
        Controls.Add(dgvItems)
        Controls.Add(btnAddItem)
        Controls.Add(txtQuantity)
        Controls.Add(Quantity)
        Controls.Add(txtUnitPrice)
        Controls.Add(txtSKU)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(cmbProduct)
        Controls.Add(Label3)
        Controls.Add(dtpOrderDate)
        Controls.Add(Label2)
        Controls.Add(cmbCustomer)
        Controls.Add(Label1)
        Name = "SalesOrderForm"
        Text = "Sales Orders"
        CType(dgvItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpOrderDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSKU As TextBox
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents Quantity As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents ProductId As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Quantit As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents LineTotal As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotalAmount As TextBox
    Friend WithEvents btnSave As Button
End Class
