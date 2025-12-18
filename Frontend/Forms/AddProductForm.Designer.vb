<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProductForm
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
        SKU = New Label()
        Label3 = New Label()
        Quantity = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtName = New TextBox()
        txtSKU = New TextBox()
        txtUnitPrice = New TextBox()
        txtQuantity = New TextBox()
        txtReorderLevel = New TextBox()
        txtSupplierId = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 25)
        Label1.TabIndex = 0
        Label1.Text = "Product Name"
        ' 
        ' SKU
        ' 
        SKU.AutoSize = True
        SKU.Location = New Point(87, 147)
        SKU.Name = "SKU"
        SKU.Size = New Size(44, 25)
        SKU.TabIndex = 1
        SKU.Text = "SKU"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(64, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 25)
        Label3.TabIndex = 2
        Label3.Text = "Unit Price"
        ' 
        ' Quantity
        ' 
        Quantity.AutoSize = True
        Quantity.Location = New Point(64, 302)
        Quantity.Name = "Quantity"
        Quantity.Size = New Size(80, 25)
        Quantity.TabIndex = 3
        Quantity.Text = "Quantity"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(46, 375)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 25)
        Label5.TabIndex = 4
        Label5.Text = "Recorder Level"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(64, 422)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 25)
        Label6.TabIndex = 5
        Label6.Text = "Supplier Id"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(207, 74)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 6
        ' 
        ' txtSKU
        ' 
        txtSKU.Location = New Point(207, 147)
        txtSKU.Name = "txtSKU"
        txtSKU.Size = New Size(150, 31)
        txtSKU.TabIndex = 7
        ' 
        ' txtUnitPrice
        ' 
        txtUnitPrice.Location = New Point(207, 225)
        txtUnitPrice.Name = "txtUnitPrice"
        txtUnitPrice.Size = New Size(150, 31)
        txtUnitPrice.TabIndex = 8
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(207, 302)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(150, 31)
        txtQuantity.TabIndex = 9
        ' 
        ' txtReorderLevel
        ' 
        txtReorderLevel.Location = New Point(207, 369)
        txtReorderLevel.Name = "txtReorderLevel"
        txtReorderLevel.Size = New Size(150, 31)
        txtReorderLevel.TabIndex = 10
        ' 
        ' txtSupplierId
        ' 
        txtSupplierId.Location = New Point(207, 416)
        txtSupplierId.Name = "txtSupplierId"
        txtSupplierId.Size = New Size(150, 31)
        txtSupplierId.TabIndex = 11
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(134, 484)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 12
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(299, 484)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 13
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' AddProductForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 536)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtSupplierId)
        Controls.Add(txtReorderLevel)
        Controls.Add(txtQuantity)
        Controls.Add(txtUnitPrice)
        Controls.Add(txtSKU)
        Controls.Add(txtName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Quantity)
        Controls.Add(Label3)
        Controls.Add(SKU)
        Controls.Add(Label1)
        Name = "AddProductForm"
        Text = "AddProductForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SKU As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Quantity As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSKU As TextBox
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtReorderLevel As TextBox
    Friend WithEvents txtSupplierId As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
