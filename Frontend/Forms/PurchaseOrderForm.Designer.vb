<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderForm
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
        Supplier = New Label()
        cmbSupplier = New ComboBox()
        Label1 = New Label()
        cmbProduct = New ComboBox()
        Label2 = New Label()
        txtQty = New TextBox()
        btnAddItem = New Button()
        dgvItems = New DataGridView()
        btnSavePO = New Button()
        btnCancel = New Button()
        CType(dgvItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Supplier
        ' 
        Supplier.AutoSize = True
        Supplier.Location = New Point(162, 78)
        Supplier.Name = "Supplier"
        Supplier.Size = New Size(77, 25)
        Supplier.TabIndex = 0
        Supplier.Text = "Supplier"
        ' 
        ' cmbSupplier
        ' 
        cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSupplier.FormattingEnabled = True
        cmbSupplier.Location = New Point(264, 75)
        cmbSupplier.Name = "cmbSupplier"
        cmbSupplier.Size = New Size(182, 33)
        cmbSupplier.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(162, 158)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 25)
        Label1.TabIndex = 2
        Label1.Text = "Product"
        ' 
        ' cmbProduct
        ' 
        cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProduct.FormattingEnabled = True
        cmbProduct.Location = New Point(264, 155)
        cmbProduct.Name = "cmbProduct"
        cmbProduct.Size = New Size(182, 33)
        cmbProduct.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(162, 238)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 25)
        Label2.TabIndex = 4
        Label2.Text = "Quantity"
        ' 
        ' txtQty
        ' 
        txtQty.Location = New Point(264, 235)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(181, 31)
        txtQty.TabIndex = 5
        ' 
        ' btnAddItem
        ' 
        btnAddItem.Location = New Point(264, 333)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(112, 34)
        btnAddItem.TabIndex = 6
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = True
        ' 
        ' dgvItems
        ' 
        dgvItems.AllowUserToAddRows = False
        dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvItems.Location = New Point(570, 59)
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        dgvItems.RowHeadersWidth = 62
        dgvItems.Size = New Size(370, 225)
        dgvItems.TabIndex = 7
        ' 
        ' btnSavePO
        ' 
        btnSavePO.Location = New Point(445, 337)
        btnSavePO.Name = "btnSavePO"
        btnSavePO.Size = New Size(112, 34)
        btnSavePO.TabIndex = 8
        btnSavePO.Text = "SavePO"
        btnSavePO.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(651, 337)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' PurchaseOrderForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1138, 450)
        Controls.Add(btnCancel)
        Controls.Add(btnSavePO)
        Controls.Add(dgvItems)
        Controls.Add(btnAddItem)
        Controls.Add(txtQty)
        Controls.Add(Label2)
        Controls.Add(cmbProduct)
        Controls.Add(Label1)
        Controls.Add(cmbSupplier)
        Controls.Add(Supplier)
        Name = "PurchaseOrderForm"
        Text = "PurchaseOrderForm"
        CType(dgvItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Supplier As Label
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents btnSavePO As Button
    Friend WithEvents btnCancel As Button
End Class
