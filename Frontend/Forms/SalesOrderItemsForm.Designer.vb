<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesOrderItemsForm
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
        dgvItems = New DataGridView()
        btnClose = New Button()
        CType(dgvItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvItems
        ' 
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvItems.Location = New Point(22, 12)
        dgvItems.Name = "dgvItems"
        dgvItems.RowHeadersWidth = 62
        dgvItems.Size = New Size(938, 275)
        dgvItems.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(236, 346)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 34)
        btnClose.TabIndex = 1
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' SalesOrderItemsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1020, 450)
        Controls.Add(btnClose)
        Controls.Add(dgvItems)
        Name = "SalesOrderItemsForm"
        Text = "SalesOrderItemsForm"
        CType(dgvItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents btnClose As Button
End Class
