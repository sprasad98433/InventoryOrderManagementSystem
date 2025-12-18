<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryTransactionListForm
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
        dgvTransactions = New DataGridView()
        btnRefresh = New Button()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvTransactions
        ' 
        dgvTransactions.AllowUserToAddRows = False
        dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactions.Dock = DockStyle.Top
        dgvTransactions.Location = New Point(0, 0)
        dgvTransactions.Name = "dgvTransactions"
        dgvTransactions.ReadOnly = True
        dgvTransactions.RowHeadersWidth = 62
        dgvTransactions.Size = New Size(1043, 225)
        dgvTransactions.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(226, 417)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(112, 34)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' InventoryTransactionListForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1043, 568)
        Controls.Add(btnRefresh)
        Controls.Add(dgvTransactions)
        Name = "InventoryTransactionListForm"
        Text = "InventoryTransactionListForm"
        CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents btnRefresh As Button
End Class
