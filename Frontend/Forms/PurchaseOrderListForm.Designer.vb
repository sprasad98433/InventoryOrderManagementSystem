<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderListForm
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
        dgvPOs = New DataGridView()
        btnViewItems = New Button()
        CType(dgvPOs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvPOs
        ' 
        dgvPOs.AllowUserToAddRows = False
        dgvPOs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPOs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPOs.Location = New Point(58, 64)
        dgvPOs.Name = "dgvPOs"
        dgvPOs.ReadOnly = True
        dgvPOs.RowHeadersWidth = 62
        dgvPOs.Size = New Size(627, 225)
        dgvPOs.TabIndex = 0
        ' 
        ' btnViewItems
        ' 
        btnViewItems.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewItems.Location = New Point(250, 363)
        btnViewItems.Name = "btnViewItems"
        btnViewItems.Size = New Size(165, 34)
        btnViewItems.TabIndex = 1
        btnViewItems.Text = "View Items"
        btnViewItems.UseVisualStyleBackColor = True
        ' 
        ' PurchaseOrderListForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnViewItems)
        Controls.Add(dgvPOs)
        Name = "PurchaseOrderListForm"
        Text = "PurchaseOrderListForm"
        CType(dgvPOs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvPOs As DataGridView
    Friend WithEvents btnViewItems As Button
End Class
