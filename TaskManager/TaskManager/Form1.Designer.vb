<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label4 = New Label()
        btnLogout = New Button()
        btnRegister = New Button()
        btnCancel = New Button()
        Label5 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(199, 178)
        txtName.Name = "txtName"
        txtName.Size = New Size(432, 50)
        txtName.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Leelawadee UI", 15.75F)
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(286, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(264, 30)
        Label2.TabIndex = 2
        Label2.Text = "REGISTER NEW ACCOUNT:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(199, 153)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 22)
        Label1.TabIndex = 3
        Label1.Text = "FULLNAME:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.RoyalBlue
        Label3.Location = New Point(199, 252)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 22)
        Label3.TabIndex = 4
        Label3.Text = "USERNAME:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(199, 277)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(432, 50)
        txtUsername.TabIndex = 5
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(199, 363)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(432, 50)
        txtPassword.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label4.ForeColor = Color.RoyalBlue
        Label4.Location = New Point(199, 338)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 22)
        Label4.TabIndex = 7
        Label4.Text = "PASSWORD:"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.BackgroundImage = My.Resources.Resources.lgout
        btnLogout.BackgroundImageLayout = ImageLayout.Stretch
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(49, 13)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(52, 51)
        btnLogout.TabIndex = 39
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.RoyalBlue
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Impact", 26.25F)
        btnRegister.ForeColor = SystemColors.ButtonHighlight
        btnRegister.Location = New Point(199, 436)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(222, 65)
        btnRegister.TabIndex = 40
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Transparent
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.RoyalBlue
        btnCancel.Location = New Point(427, 436)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(222, 65)
        btnCancel.TabIndex = 41
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Impact", 42.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(296, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(242, 71)
        Label5.TabIndex = 42
        Label5.Text = "REGISTER"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.RoyalBlue
        Panel1.Controls.Add(btnLogout)
        Panel1.Location = New Point(687, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 643)
        Panel1.TabIndex = 43
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RoyalBlue
        Panel2.Location = New Point(-6, -3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(154, 613)
        Panel2.TabIndex = 44
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 541)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(btnCancel)
        Controls.Add(btnRegister)
        Controls.Add(Label4)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(txtName)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel

End Class
