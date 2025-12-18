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
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        cmbRole = New ComboBox()
        cmbStatus = New ComboBox()
        btnRegister = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(175, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(172, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(175, 241)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 25)
        Label3.TabIndex = 2
        Label3.Text = "Role"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(175, 311)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 25)
        Label4.TabIndex = 3
        Label4.Text = "Status"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(316, 116)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(150, 31)
        txtUsername.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(316, 175)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(150, 31)
        txtPassword.TabIndex = 5
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Admin", "User"})
        cmbRole.Location = New Point(316, 241)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(150, 33)
        cmbRole.TabIndex = 6
        ' 
        ' cmbStatus
        ' 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        cmbStatus.Location = New Point(316, 311)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(150, 33)
        cmbStatus.TabIndex = 7
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(225, 384)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(112, 34)
        btnRegister.TabIndex = 8
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(470, 384)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 482)
        Controls.Add(btnCancel)
        Controls.Add(btnRegister)
        Controls.Add(cmbStatus)
        Controls.Add(cmbRole)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
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
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
End Class
