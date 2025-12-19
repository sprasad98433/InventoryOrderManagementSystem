<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSupplierForm
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
        Label2 = New Label()
        Label3 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtLeadTime = New TextBox()
        chkIsActive = New CheckBox()
        Save = New Button()
        btnCancel = New Button()
        dgvSuppliers = New DataGridView()
        CType(dgvSuppliers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 25)
        Label1.TabIndex = 0
        Label1.Text = "Supplier Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(61, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 25)
        Label3.TabIndex = 2
        Label3.Text = "Lead Time"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(210, 70)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(210, 137)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 4
        ' 
        ' txtLeadTime
        ' 
        txtLeadTime.Location = New Point(210, 221)
        txtLeadTime.Name = "txtLeadTime"
        txtLeadTime.Size = New Size(150, 31)
        txtLeadTime.TabIndex = 5
        ' 
        ' chkIsActive
        ' 
        chkIsActive.AutoSize = True
        chkIsActive.Location = New Point(248, 285)
        chkIsActive.Name = "chkIsActive"
        chkIsActive.Size = New Size(86, 29)
        chkIsActive.TabIndex = 7
        chkIsActive.Text = "Active"
        chkIsActive.UseVisualStyleBackColor = True
        ' 
        ' Save
        ' 
        Save.Location = New Point(51, 359)
        Save.Name = "Save"
        Save.Size = New Size(129, 34)
        Save.TabIndex = 8
        Save.Text = "Save/Update"
        Save.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(248, 359)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' dgvSuppliers
        ' 
        dgvSuppliers.AllowUserToAddRows = False
        dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSuppliers.Location = New Point(423, 38)
        dgvSuppliers.Name = "dgvSuppliers"
        dgvSuppliers.ReadOnly = True
        dgvSuppliers.RowHeadersWidth = 62
        dgvSuppliers.Size = New Size(513, 241)
        dgvSuppliers.TabIndex = 10
        ' 
        ' AddSupplierForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1007, 441)
        Controls.Add(dgvSuppliers)
        Controls.Add(btnCancel)
        Controls.Add(Save)
        Controls.Add(chkIsActive)
        Controls.Add(txtLeadTime)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AddSupplierForm"
        Text = "AddSupplierForm"
        CType(dgvSuppliers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLeadTime As TextBox
    Friend WithEvents chkIsActive As CheckBox
    Friend WithEvents Save As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dgvSuppliers As DataGridView
End Class
