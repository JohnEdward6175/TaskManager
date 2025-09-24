<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        txtSearch = New TextBox()
        btnSearch = New Button()
        txtTitle = New TextBox()
        txtTags = New TextBox()
        txtDescription = New TextBox()
        btnEdit = New Button()
        btnDelete = New Button()
        btnMoveLeft = New Button()
        btnMoveRight = New Button()
        lblLoggedIn = New Label()
        btnLogout = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lvTodo = New ListView()
        lvInProgress = New ListView()
        lvDone = New ListView()
        btnAddTask = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = Color.Silver
        txtSearch.Location = New Point(408, 16)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(301, 39)
        txtSearch.TabIndex = 16
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.RoyalBlue
        btnSearch.BackgroundImage = My.Resources.Resources.srch1_removebg_preview
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = SystemColors.ButtonHighlight
        btnSearch.Location = New Point(724, 18)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(34, 37)
        btnSearch.TabIndex = 18
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(99, 95)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(228, 35)
        txtTitle.TabIndex = 22
        ' 
        ' txtTags
        ' 
        txtTags.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTags.ForeColor = Color.Black
        txtTags.Location = New Point(107, 147)
        txtTags.Name = "txtTags"
        txtTags.Size = New Size(414, 32)
        txtTags.TabIndex = 24
        ' 
        ' txtDescription
        ' 
        txtDescription.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDescription.Location = New Point(478, 88)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(319, 43)
        txtDescription.TabIndex = 26
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.RoyalBlue
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = SystemColors.ButtonHighlight
        btnEdit.Location = New Point(107, 529)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(131, 43)
        btnEdit.TabIndex = 28
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.RoyalBlue
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = SystemColors.ButtonHighlight
        btnDelete.Location = New Point(262, 529)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(118, 43)
        btnDelete.TabIndex = 35
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnMoveLeft
        ' 
        btnMoveLeft.BackColor = Color.RoyalBlue
        btnMoveLeft.FlatAppearance.BorderSize = 0
        btnMoveLeft.FlatStyle = FlatStyle.Flat
        btnMoveLeft.Font = New Font("Impact", 18F)
        btnMoveLeft.ForeColor = SystemColors.ButtonHighlight
        btnMoveLeft.Location = New Point(438, 530)
        btnMoveLeft.Name = "btnMoveLeft"
        btnMoveLeft.Size = New Size(150, 43)
        btnMoveLeft.TabIndex = 36
        btnMoveLeft.Text = "MOVE RIGHT"
        btnMoveLeft.UseVisualStyleBackColor = False
        ' 
        ' btnMoveRight
        ' 
        btnMoveRight.BackColor = Color.RoyalBlue
        btnMoveRight.FlatAppearance.BorderSize = 0
        btnMoveRight.FlatStyle = FlatStyle.Flat
        btnMoveRight.Font = New Font("Impact", 18F)
        btnMoveRight.ForeColor = SystemColors.ButtonHighlight
        btnMoveRight.Location = New Point(603, 530)
        btnMoveRight.Name = "btnMoveRight"
        btnMoveRight.Size = New Size(151, 43)
        btnMoveRight.TabIndex = 37
        btnMoveRight.Text = "MOVE LEFT"
        btnMoveRight.UseVisualStyleBackColor = False
        ' 
        ' lblLoggedIn
        ' 
        lblLoggedIn.AutoSize = True
        lblLoggedIn.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLoggedIn.Location = New Point(12, 589)
        lblLoggedIn.Name = "lblLoggedIn"
        lblLoggedIn.Size = New Size(198, 19)
        lblLoggedIn.TabIndex = 28
        lblLoggedIn.Text = "LOGGED IN AS: USER123"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.BackgroundImage = My.Resources.Resources.lgout
        btnLogout.BackgroundImageLayout = ImageLayout.Stretch
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(787, 7)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(52, 51)
        btnLogout.TabIndex = 38
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(19, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 32)
        Label1.TabIndex = 39
        Label1.Text = "To Do"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(262, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 32)
        Label2.TabIndex = 40
        Label2.Text = "In Progress"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(505, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 32)
        Label3.TabIndex = 41
        Label3.Text = "Done"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(43, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 24)
        Label4.TabIndex = 42
        Label4.Text = "Title"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(43, 147)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 24)
        Label5.TabIndex = 43
        Label5.Text = "Tags"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(347, 99)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 24)
        Label6.TabIndex = 44
        Label6.Text = "Description"
        ' 
        ' lvTodo
        ' 
        lvTodo.BackColor = Color.LightCyan
        lvTodo.Location = New Point(19, 68)
        lvTodo.Name = "lvTodo"
        lvTodo.Size = New Size(212, 209)
        lvTodo.TabIndex = 45
        lvTodo.UseCompatibleStateImageBehavior = False
        lvTodo.View = View.List
        ' 
        ' lvInProgress
        ' 
        lvInProgress.BackColor = Color.LightCyan
        lvInProgress.Location = New Point(262, 68)
        lvInProgress.Name = "lvInProgress"
        lvInProgress.Size = New Size(210, 209)
        lvInProgress.TabIndex = 47
        lvInProgress.UseCompatibleStateImageBehavior = False
        lvInProgress.View = View.List
        ' 
        ' lvDone
        ' 
        lvDone.BackColor = Color.LightCyan
        lvDone.Location = New Point(505, 68)
        lvDone.Name = "lvDone"
        lvDone.Size = New Size(220, 209)
        lvDone.TabIndex = 48
        lvDone.UseCompatibleStateImageBehavior = False
        lvDone.View = View.List
        ' 
        ' btnAddTask
        ' 
        btnAddTask.BackColor = Color.RoyalBlue
        btnAddTask.FlatAppearance.BorderSize = 0
        btnAddTask.FlatStyle = FlatStyle.Flat
        btnAddTask.Font = New Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddTask.ForeColor = SystemColors.ButtonHighlight
        btnAddTask.Location = New Point(547, 140)
        btnAddTask.Name = "btnAddTask"
        btnAddTask.Size = New Size(250, 50)
        btnAddTask.TabIndex = 49
        btnAddTask.Text = "ADD"
        btnAddTask.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lvDone)
        Panel1.Controls.Add(lvInProgress)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(lvTodo)
        Panel1.Location = New Point(42, 212)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(755, 301)
        Panel1.TabIndex = 50
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RoyalBlue
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(txtSearch)
        Panel2.Controls.Add(btnLogout)
        Panel2.Location = New Point(-4, -4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(897, 75)
        Panel2.TabIndex = 51
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.task
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.InitialImage = My.Resources.Resources.task
        PictureBox1.Location = New Point(16, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(52, 48)
        PictureBox1.TabIndex = 53
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(74, 12)
        Label7.Name = "Label7"
        Label7.Size = New Size(215, 44)
        Label7.TabIndex = 52
        Label7.Text = "Dashboard"
        ' 
        ' main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(853, 622)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnAddTask)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtTags)
        Controls.Add(lblLoggedIn)
        Controls.Add(txtTitle)
        Controls.Add(btnMoveRight)
        Controls.Add(txtDescription)
        Controls.Add(btnMoveLeft)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "main"
        Text = "main"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtTags As TextBox
    Friend WithEvents btnAddTask123 As Button
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnMoveLeft As Button
    Friend WithEvents btnMoveRight As Button
    Friend WithEvents lblLoggedIn As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lvTodo As ListView
    Friend WithEvents lvInProgress As ListView
    Friend WithEvents lvDone As ListView
    Friend WithEvents btnAddTask As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
