<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtFullName = New TextBox()
        txtUsername = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtAddress = New TextBox()
        txtPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        btnRegister = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(123, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(123, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 25)
        Label2.TabIndex = 1
        Label2.Text = "User Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(123, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 25)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(123, 269)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 25)
        Label4.TabIndex = 3
        Label4.Text = "Phone"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(123, 345)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 25)
        Label5.TabIndex = 4
        Label5.Text = "Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(123, 400)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 25)
        Label6.TabIndex = 5
        Label6.Text = "Password"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(66, 457)
        Label7.Name = "Label7"
        Label7.Size = New Size(156, 25)
        Label7.TabIndex = 6
        Label7.Text = "Confirm Password"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(252, 76)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(150, 31)
        txtFullName.TabIndex = 7
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(252, 139)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(150, 31)
        txtUsername.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(252, 201)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 9
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(252, 269)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(150, 31)
        txtPhone.TabIndex = 10
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(252, 345)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(150, 31)
        txtAddress.TabIndex = 11
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(252, 400)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(150, 31)
        txtPassword.TabIndex = 12
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(252, 457)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.Size = New Size(150, 31)
        txtConfirmPassword.TabIndex = 13
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(171, 524)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(112, 34)
        btnRegister.TabIndex = 14
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(352, 524)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 15
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 581)
        Controls.Add(btnCancel)
        Controls.Add(btnRegister)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(txtAddress)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtUsername)
        Controls.Add(txtFullName)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "RegisterForm"
        Text = "RegisterForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
End Class
