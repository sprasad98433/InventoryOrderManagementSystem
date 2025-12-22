<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesOrderListForm
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
        dgvOrders = New DataGridView()
        btnViewItems = New Button()
        btnRefresh = New Button()
        btnClose = New Button()
        CType(dgvOrders, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvOrders
        ' 
        dgvOrders.AllowUserToAddRows = False
        dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOrders.Location = New Point(12, 12)
        dgvOrders.Name = "dgvOrders"
        dgvOrders.ReadOnly = True
        dgvOrders.RowHeadersWidth = 62
        dgvOrders.Size = New Size(986, 263)
        dgvOrders.TabIndex = 0
        ' 
        ' btnViewItems
        ' 
        btnViewItems.Location = New Point(97, 346)
        btnViewItems.Name = "btnViewItems"
        btnViewItems.Size = New Size(112, 34)
        btnViewItems.TabIndex = 1
        btnViewItems.Text = "View Items"
        btnViewItems.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(312, 346)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(112, 34)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(514, 346)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 34)
        btnClose.TabIndex = 3
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' SalesOrderListForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1022, 450)
        Controls.Add(btnClose)
        Controls.Add(btnRefresh)
        Controls.Add(btnViewItems)
        Controls.Add(dgvOrders)
        Name = "SalesOrderListForm"
        Text = "SalesOrderListForm"
        CType(dgvOrders, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents btnViewItems As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClose As Button
End Class
