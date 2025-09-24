<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Label4 = New Label()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        btnForgotPassword = New Button()
        btnLogin = New Button()
        btnRegister = New Button()
        Label1 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        btnLogout = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label4.ForeColor = Color.RoyalBlue
        Label4.Location = New Point(172, 257)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 22)
        Label4.TabIndex = 16
        Label4.Text = "PASSWORD:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(172, 289)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(464, 50)
        txtPassword.TabIndex = 15
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(172, 189)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(464, 50)
        txtUsername.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.RoyalBlue
        Label3.Location = New Point(167, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 22)
        Label3.TabIndex = 13
        Label3.Text = "USERNAME:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Leelawadee UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(279, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(256, 30)
        Label2.TabIndex = 11
        Label2.Text = "TASK MANAGEMENT APP"
        ' 
        ' btnForgotPassword
        ' 
        btnForgotPassword.BackColor = Color.Transparent
        btnForgotPassword.FlatAppearance.BorderSize = 0
        btnForgotPassword.FlatStyle = FlatStyle.Flat
        btnForgotPassword.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnForgotPassword.ForeColor = Color.RoyalBlue
        btnForgotPassword.Location = New Point(148, 352)
        btnForgotPassword.Name = "btnForgotPassword"
        btnForgotPassword.Size = New Size(246, 44)
        btnForgotPassword.TabIndex = 19
        btnForgotPassword.Text = "Forgot Password?"
        btnForgotPassword.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.RoyalBlue
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Impact", 26.25F)
        btnLogin.ForeColor = SystemColors.ButtonHighlight
        btnLogin.Location = New Point(172, 402)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(222, 65)
        btnLogin.TabIndex = 20
        btnLogin.Text = "LOG IN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.RoyalBlue
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Impact", 26.25F)
        btnRegister.ForeColor = SystemColors.ButtonHighlight
        btnRegister.Location = New Point(414, 402)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(222, 65)
        btnRegister.TabIndex = 21
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 42.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(322, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 71)
        Label1.TabIndex = 22
        Label1.Text = "LOG IN"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.BackgroundImage = My.Resources.Resources.lgout
        btnLogout.BackgroundImageLayout = ImageLayout.Stretch
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(39, 24)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(52, 51)
        btnLogout.TabIndex = 39
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.RoyalBlue
        Panel1.Controls.Add(btnLogout)
        Panel1.Location = New Point(697, -12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(190, 660)
        Panel1.TabIndex = 40
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RoyalBlue
        Panel2.Location = New Point(-5, -19)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(128, 657)
        Panel2.TabIndex = 41
        ' 
        ' LOGIN
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 531)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnRegister)
        Controls.Add(btnLogin)
        Controls.Add(btnForgotPassword)
        Controls.Add(Label4)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "LOGIN"
        Text = "LOGIN"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnForgotPassword As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
