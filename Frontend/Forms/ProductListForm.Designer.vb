<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductListForm
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
        dgvProducts = New DataGridView()
        btnEdit = New Button()
        btnRefresh = New Button()
        btnDelete = New Button()
        btnAddNew = New Button()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AllowUserToDeleteRows = False
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Dock = DockStyle.Top
        dgvProducts.Location = New Point(0, 0)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.ReadOnly = True
        dgvProducts.RowHeadersWidth = 62
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProducts.Size = New Size(800, 225)
        dgvProducts.TabIndex = 0
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(272, 311)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(112, 34)
        btnEdit.TabIndex = 1
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(568, 311)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(112, 34)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(420, 311)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnAddNew
        ' 
        btnAddNew.Location = New Point(46, 311)
        btnAddNew.Name = "btnAddNew"
        btnAddNew.Size = New Size(184, 34)
        btnAddNew.TabIndex = 4
        btnAddNew.Text = "Add new product"
        btnAddNew.UseVisualStyleBackColor = True
        ' 
        ' ProductListForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAddNew)
        Controls.Add(btnDelete)
        Controls.Add(btnRefresh)
        Controls.Add(btnEdit)
        Controls.Add(dgvProducts)
        Name = "ProductListForm"
        Text = "ProductListForm"
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAddNew As Button
End Class
