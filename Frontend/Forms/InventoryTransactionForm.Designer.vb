<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryTransactionForm
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
        cmbProduct = New ComboBox()
        Label2 = New Label()
        cmbTransactionType = New ComboBox()
        Label3 = New Label()
        txtQuantity = New TextBox()
        txtReference = New TextBox()
        Label4 = New Label()
        txtRemarks = New TextBox()
        Label5 = New Label()
        btnSave = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(108, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 25)
        Label1.TabIndex = 0
        Label1.Text = "Product"
        ' 
        ' cmbProduct
        ' 
        cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProduct.FormattingEnabled = True
        cmbProduct.Location = New Point(232, 86)
        cmbProduct.Name = "cmbProduct"
        cmbProduct.Size = New Size(182, 33)
        cmbProduct.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(64, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 25)
        Label2.TabIndex = 2
        Label2.Text = "Transaction Type"
        ' 
        ' cmbTransactionType
        ' 
        cmbTransactionType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTransactionType.FormattingEnabled = True
        cmbTransactionType.Items.AddRange(New Object() {"IN", "OUT"})
        cmbTransactionType.Location = New Point(232, 162)
        cmbTransactionType.Name = "cmbTransactionType"
        cmbTransactionType.Size = New Size(182, 33)
        cmbTransactionType.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(92, 228)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 25)
        Label3.TabIndex = 4
        Label3.Text = "Quantity"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(232, 225)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(182, 31)
        txtQuantity.TabIndex = 5
        ' 
        ' txtReference
        ' 
        txtReference.Location = New Point(232, 300)
        txtReference.Name = "txtReference"
        txtReference.Size = New Size(182, 31)
        txtReference.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 300)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 25)
        Label4.TabIndex = 7
        Label4.Text = "Reference No"
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Location = New Point(232, 391)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.Size = New Size(182, 31)
        txtRemarks.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(92, 391)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 25)
        Label5.TabIndex = 9
        Label5.Text = "Remarks"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(133, 477)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 10
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(313, 477)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 11
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' InventoryTransactionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 567)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(Label5)
        Controls.Add(txtRemarks)
        Controls.Add(Label4)
        Controls.Add(txtReference)
        Controls.Add(txtQuantity)
        Controls.Add(Label3)
        Controls.Add(cmbTransactionType)
        Controls.Add(Label2)
        Controls.Add(cmbProduct)
        Controls.Add(Label1)
        Name = "InventoryTransactionForm"
        Text = "InventoryTransactionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTransactionType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtReference As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
