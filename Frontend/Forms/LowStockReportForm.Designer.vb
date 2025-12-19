<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LowStockReportForm
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
        dgvLowStock = New DataGridView()
        btnRefresh = New Button()
        CType(dgvLowStock, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Red
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(50, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(237, 32)
        Label1.TabIndex = 0
        Label1.Text = "Low Stock Products"
        ' 
        ' dgvLowStock
        ' 
        dgvLowStock.AllowUserToAddRows = False
        dgvLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLowStock.Location = New Point(27, 93)
        dgvLowStock.Name = "dgvLowStock"
        dgvLowStock.ReadOnly = True
        dgvLowStock.RowHeadersWidth = 62
        dgvLowStock.Size = New Size(737, 225)
        dgvLowStock.TabIndex = 1
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.Location = New Point(199, 369)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(112, 34)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' LowStockReportForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRefresh)
        Controls.Add(dgvLowStock)
        Controls.Add(Label1)
        Name = "LowStockReportForm"
        Text = "LowStockReportForm"
        CType(dgvLowStock, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvLowStock As DataGridView
    Friend WithEvents btnRefresh As Button
End Class
