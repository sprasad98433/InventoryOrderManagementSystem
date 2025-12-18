<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReorderSuggestionForm
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
        dgvReorder = New DataGridView()
        btnRefresh = New Button()
        CType(dgvReorder, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvReorder
        ' 
        dgvReorder.AllowUserToAddRows = False
        dgvReorder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReorder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReorder.Dock = DockStyle.Top
        dgvReorder.Location = New Point(0, 0)
        dgvReorder.Name = "dgvReorder"
        dgvReorder.ReadOnly = True
        dgvReorder.RowHeadersWidth = 62
        dgvReorder.Size = New Size(800, 225)
        dgvReorder.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(163, 315)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(112, 34)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' ReorderSuggestionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 456)
        Controls.Add(btnRefresh)
        Controls.Add(dgvReorder)
        Name = "ReorderSuggestionForm"
        Text = "ReorderSuggestionForm"
        CType(dgvReorder, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvReorder As DataGridView
    Friend WithEvents btnRefresh As Button
End Class
