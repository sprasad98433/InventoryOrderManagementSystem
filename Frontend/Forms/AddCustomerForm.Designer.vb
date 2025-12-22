<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomerForm
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
        Label4 = New Label()
        txtName = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        chkIsActive = New CheckBox()
        btnSave = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(135, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(135, 187)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(105, 260)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 25)
        Label3.TabIndex = 2
        Label3.Text = "Phone number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(131, 330)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 25)
        Label4.TabIndex = 3
        Label4.Text = "Acticate"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(254, 109)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 4
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(251, 260)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(150, 31)
        txtPhone.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(251, 187)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 5
        ' 
        ' chkIsActive
        ' 
        chkIsActive.AutoSize = True
        chkIsActive.Checked = True
        chkIsActive.CheckState = CheckState.Checked
        chkIsActive.Location = New Point(258, 330)
        chkIsActive.Name = "chkIsActive"
        chkIsActive.Size = New Size(86, 29)
        chkIsActive.TabIndex = 7
        chkIsActive.Text = "Active"
        chkIsActive.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(195, 388)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 8
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(401, 388)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' AddCustomerForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(chkIsActive)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AddCustomerForm"
        Text = "AddCustomerForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents chkIsActive As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
