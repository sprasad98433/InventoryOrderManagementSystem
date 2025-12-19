<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceivePurchaseOrderForm
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
        cmbPO = New ComboBox()
        dgvItems = New DataGridView()
        btnReceive = New Button()
        Label1 = New Label()
        CType(dgvItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbPO
        ' 
        cmbPO.FormattingEnabled = True
        cmbPO.Location = New Point(208, 87)
        cmbPO.Name = "cmbPO"
        cmbPO.Size = New Size(182, 33)
        cmbPO.TabIndex = 0
        ' 
        ' dgvItems
        ' 
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvItems.Location = New Point(409, 42)
        dgvItems.Name = "dgvItems"
        dgvItems.RowHeadersWidth = 62
        dgvItems.Size = New Size(360, 225)
        dgvItems.TabIndex = 1
        ' 
        ' btnReceive
        ' 
        btnReceive.Location = New Point(135, 306)
        btnReceive.Name = "btnReceive"
        btnReceive.Size = New Size(112, 34)
        btnReceive.TabIndex = 2
        btnReceive.Text = "Receive"
        btnReceive.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 25)
        Label1.TabIndex = 3
        Label1.Text = "Select Purchase Order"
        ' 
        ' ReceivePurchaseOrderForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(btnReceive)
        Controls.Add(dgvItems)
        Controls.Add(cmbPO)
        Name = "ReceivePurchaseOrderForm"
        Text = "ReceivePurchaseOrderForm"
        CType(dgvItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbPO As ComboBox
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents btnReceive As Button
    Friend WithEvents Label1 As Label
End Class
