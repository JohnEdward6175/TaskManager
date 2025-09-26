<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        cmbSecurityQuestion = New ComboBox()
        Label6 = New Label()
        txtAnswer = New TextBox()
        Label7 = New Label()
        btnBackToLogin = New Button()
        btnResetPassword = New Button()
        Label4 = New Label()
        txtNewPassword = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        Label5 = New Label()
        btnLogout = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        txtConfirmPassword = New TextBox()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbSecurityQuestion
        ' 
        cmbSecurityQuestion.Font = New Font("Segoe UI", 24F)
        cmbSecurityQuestion.FormattingEnabled = True
        cmbSecurityQuestion.Location = New Point(230, 241)
        cmbSecurityQuestion.Name = "cmbSecurityQuestion"
        cmbSecurityQuestion.Size = New Size(431, 53)
        cmbSecurityQuestion.TabIndex = 63
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label6.ForeColor = Color.RoyalBlue
        Label6.Location = New Point(229, 297)
        Label6.Name = "Label6"
        Label6.Size = New Size(168, 22)
        Label6.TabIndex = 62
        Label6.Text = "Security Answer:"
        ' 
        ' txtAnswer
        ' 
        txtAnswer.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAnswer.Location = New Point(231, 322)
        txtAnswer.Name = "txtAnswer"
        txtAnswer.Size = New Size(432, 50)
        txtAnswer.TabIndex = 61
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label7.ForeColor = Color.RoyalBlue
        Label7.Location = New Point(230, 216)
        Label7.Name = "Label7"
        Label7.Size = New Size(183, 22)
        Label7.TabIndex = 60
        Label7.Text = "Security Question:"
        ' 
        ' btnBackToLogin
        ' 
        btnBackToLogin.BackColor = Color.Transparent
        btnBackToLogin.FlatAppearance.BorderSize = 0
        btnBackToLogin.FlatStyle = FlatStyle.Flat
        btnBackToLogin.Font = New Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBackToLogin.ForeColor = Color.RoyalBlue
        btnBackToLogin.Location = New Point(450, 585)
        btnBackToLogin.Name = "btnBackToLogin"
        btnBackToLogin.Size = New Size(222, 65)
        btnBackToLogin.TabIndex = 58
        btnBackToLogin.Text = "CANCEL"
        btnBackToLogin.UseVisualStyleBackColor = False
        ' 
        ' btnResetPassword
        ' 
        btnResetPassword.BackColor = Color.RoyalBlue
        btnResetPassword.FlatAppearance.BorderSize = 0
        btnResetPassword.FlatStyle = FlatStyle.Flat
        btnResetPassword.Font = New Font("Impact", 26.25F)
        btnResetPassword.ForeColor = SystemColors.ButtonHighlight
        btnResetPassword.Location = New Point(222, 585)
        btnResetPassword.Name = "btnResetPassword"
        btnResetPassword.Size = New Size(222, 65)
        btnResetPassword.TabIndex = 57
        btnResetPassword.Text = "RESET"
        btnResetPassword.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label4.ForeColor = Color.RoyalBlue
        Label4.Location = New Point(231, 411)
        Label4.Name = "Label4"
        Label4.Size = New Size(175, 22)
        Label4.TabIndex = 56
        Label4.Text = "NEW PASSWORD:"
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNewPassword.Location = New Point(229, 436)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(432, 50)
        txtNewPassword.TabIndex = 54
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.RoyalBlue
        Label3.Location = New Point(231, 489)
        Label3.Name = "Label3"
        Label3.Size = New Size(221, 22)
        Label3.TabIndex = 53
        Label3.Text = "CONFIRM PASSWORD:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(231, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 22)
        Label1.TabIndex = 52
        Label1.Text = "USERNAME:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Leelawadee UI", 15.75F)
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(358, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(178, 30)
        Label2.TabIndex = 51
        Label2.Text = "RESET ACCOUNT:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(229, 163)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(432, 50)
        txtUsername.TabIndex = 50
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Impact", 40F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(219, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(472, 66)
        Label5.TabIndex = 59
        Label5.Text = "FORGOT PASSWORD?"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.BackgroundImage = My.Resources.Resources.lgout
        btnLogout.BackgroundImageLayout = ImageLayout.Stretch
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(130, 49)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(52, 51)
        btnLogout.TabIndex = 64
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.RoyalBlue
        Panel1.Location = New Point(-5, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(186, 749)
        Panel1.TabIndex = 65
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RoyalBlue
        Panel2.Controls.Add(btnLogout)
        Panel2.Location = New Point(714, -37)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(281, 892)
        Panel2.TabIndex = 66
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtConfirmPassword.Location = New Point(231, 514)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(432, 50)
        txtConfirmPassword.TabIndex = 67
        ' 
        ' ForgotPassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(908, 704)
        Controls.Add(txtConfirmPassword)
        Controls.Add(Panel2)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Controls.Add(cmbSecurityQuestion)
        Controls.Add(Label6)
        Controls.Add(txtAnswer)
        Controls.Add(Label7)
        Controls.Add(btnBackToLogin)
        Controls.Add(btnResetPassword)
        Controls.Add(Label4)
        Controls.Add(txtNewPassword)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(txtUsername)
        Controls.Add(Label5)
        FormBorderStyle = FormBorderStyle.None
        Name = "ForgotPassword"
        Text = "ForgotPassword"
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbSecurityQuestion As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBackToLogin As Button
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtConfirmPassword As TextBox
End Class
