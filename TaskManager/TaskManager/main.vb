Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class Main
    ' MySQL connection string
    Dim connStr As String = "server=localhost;port=3306;user id=taskuser;password=taskpass;database=taskdb;SslMode=none;"
    Private currentUser As String

    ' Edit mode flags
    Private isEditMode As Boolean = False
    Private editTaskID As Integer = -1

    ' Constructor receives logged-in username
    Public Sub New(user As String)
        InitializeComponent()
        currentUser = user
    End Sub

    ' Form load
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLoggedIn.Text = "Logged in as: " & currentUser

        Dim listFont As New Font("Segoe UI", 12, FontStyle.Regular)
        lvTodo.Font = listFont
        lvInProgress.Font = listFont
        lvDone.Font = listFont

        ' Set ListView columns (reduced widths)
        For Each lv In New ListView() {lvTodo, lvInProgress, lvDone}
            lv.Columns.Clear()
            lv.View = View.Details
            lv.FullRowSelect = True
            lv.GridLines = True
            lv.Columns.Add("Title", 150)
            lv.Columns.Add("Description", 200)
            lv.Columns.Add("Tags", 100)
            lv.Columns.Add("Priority", 60)
            lv.Columns.Add("ID", 0) ' hidden
        Next

        LoadPriorities()
        LoadTasks()
    End Sub

    ' Load priorities into cmbPriority
    Private Sub LoadPriorities()
        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim sql As String = "SELECT id, name FROM priorities ORDER BY id"
            Using cmd As New MySqlCommand(sql, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    cmbPriority.Items.Clear()
                    While reader.Read()
                        ' store only name
                        cmbPriority.Items.Add(reader("name").ToString())
                    End While
                End Using
            End Using
        End Using

        If cmbPriority.Items.Count > 1 Then cmbPriority.SelectedIndex = 1 ' Default to Medium
    End Sub

    ' Load tasks with tags and priorities
    Private Sub LoadTasks(Optional searchTerm As String = "")
        lvTodo.Items.Clear()
        lvInProgress.Items.Clear()
        lvDone.Items.Clear()

        Using conn As New MySqlConnection(connStr)
            conn.Open()

            Dim sql As String =
                "SELECT t.id, t.title, t.description, t.status, p.name AS priority, " &
                "GROUP_CONCAT(g.tag_name SEPARATOR ', ') AS tags " &
                "FROM tasks t " &
                "LEFT JOIN priorities p ON t.priority_id = p.id " &
                "LEFT JOIN task_tags tg ON t.id = tg.task_id " &
                "LEFT JOIN tags g ON tg.tag_id = g.tag_id "

            If searchTerm <> "" Then
                sql &= "WHERE t.title LIKE @search OR t.description LIKE @search OR g.tag_name LIKE @search "
            End If

            sql &= "GROUP BY t.id, t.title, t.description, t.status, p.name"

            Using cmd As New MySqlCommand(sql, conn)
                If searchTerm <> "" Then
                    cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim li As New ListViewItem(reader("title").ToString())
                        li.SubItems.Add(reader("description").ToString())
                        li.SubItems.Add(If(IsDBNull(reader("tags")), "", reader("tags").ToString()))
                        li.SubItems.Add(If(IsDBNull(reader("priority")), "Medium", reader("priority").ToString()))
                        li.SubItems.Add(reader("id").ToString()) ' hidden ID

                        Select Case reader("status").ToString().ToLower()
                            Case "todo"
                                lvTodo.Items.Add(li)
                            Case "in-progress"
                                lvInProgress.Items.Add(li)
                            Case "done"
                                lvDone.Items.Add(li)
                        End Select
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' Add task / Confirm Edit
    Private Sub btnAddTask_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click
        If txtTitle.Text = "" Or txtDescription.Text = "" Or txtTags.Text = "" Or cmbPriority.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim transaction = conn.BeginTransaction()

            Try
                Dim taskID As Integer
                Dim selectedPriorityName As String = cmbPriority.SelectedItem.ToString()

                ' Get priority ID
                Dim priorityID As Integer
                Dim sqlPriority As String = "SELECT id FROM priorities WHERE name=@name"
                Using cmd As New MySqlCommand(sqlPriority, conn, transaction)
                    cmd.Parameters.AddWithValue("@name", selectedPriorityName)
                    priorityID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                If isEditMode Then
                    ' Update task
                    Dim sql As String = "UPDATE tasks SET title=@t, description=@d, priority_id=@p WHERE id=@id"
                    Using cmd As New MySqlCommand(sql, conn, transaction)
                        cmd.Parameters.AddWithValue("@t", txtTitle.Text)
                        cmd.Parameters.AddWithValue("@d", txtDescription.Text)
                        cmd.Parameters.AddWithValue("@p", priorityID)
                        cmd.Parameters.AddWithValue("@id", editTaskID)
                        cmd.ExecuteNonQuery()
                    End Using

                    taskID = editTaskID

                    ' Clear old tags
                    Dim delSql As String = "DELETE FROM task_tags WHERE task_id=@id"
                    Using cmd As New MySqlCommand(delSql, conn, transaction)
                        cmd.Parameters.AddWithValue("@id", taskID)
                        cmd.ExecuteNonQuery()
                    End Using
                Else
                    ' Insert new task
                    Dim sql As String = "INSERT INTO tasks (title, description, status, priority_id) VALUES (@t,@d,'todo',@p); SELECT LAST_INSERT_ID();"
                    Using cmd As New MySqlCommand(sql, conn, transaction)
                        cmd.Parameters.AddWithValue("@t", txtTitle.Text)
                        cmd.Parameters.AddWithValue("@d", txtDescription.Text)
                        cmd.Parameters.AddWithValue("@p", priorityID)
                        taskID = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using
                End If

                ' Insert tags
                Dim tags() As String = txtTags.Text.Split(","c)
                For Each rawTag As String In tags
                    Dim tagName As String = rawTag.Trim()
                    If tagName <> "" Then
                        ' Ensure tag exists
                        Dim tagID As Integer
                        Dim tagCheck As String = "SELECT tag_id FROM tags WHERE tag_name=@name"
                        Using cmd As New MySqlCommand(tagCheck, conn, transaction)
                            cmd.Parameters.AddWithValue("@name", tagName)
                            Dim result = cmd.ExecuteScalar()
                            If result IsNot Nothing Then
                                tagID = Convert.ToInt32(result)
                            Else
                                Dim insertTag As String = "INSERT INTO tags (tag_name) VALUES (@name); SELECT LAST_INSERT_ID();"
                                Using cmdInsert As New MySqlCommand(insertTag, conn, transaction)
                                    cmdInsert.Parameters.AddWithValue("@name", tagName)
                                    tagID = Convert.ToInt32(cmdInsert.ExecuteScalar())
                                End Using
                            End If
                        End Using

                        ' Link tag to task
                        Dim linkSql As String = "INSERT INTO task_tags (task_id, tag_id) VALUES (@tid,@gid)"
                        Using cmd As New MySqlCommand(linkSql, conn, transaction)
                            cmd.Parameters.AddWithValue("@tid", taskID)
                            cmd.Parameters.AddWithValue("@gid", tagID)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next

                transaction.Commit()

                If isEditMode Then
                    MessageBox.Show("Task updated successfully!")
                Else
                    MessageBox.Show("Task added successfully!")
                End If

                ' Reset
                txtTitle.Text = ""
                txtDescription.Text = ""
                txtTags.Text = ""
                cmbPriority.SelectedIndex = 1
                LoadTasks()
                isEditMode = False
                editTaskID = -1
                btnAddTask.Text = "Add Task"

            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Error saving task: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm As String = txtSearch.Text.Trim()
        LoadTasks(searchTerm)
    End Sub

    ' Delete
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedItem As ListViewItem = GetSelectedItem()
        If selectedItem Is Nothing Then Return

        If MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim taskID As Integer = CInt(selectedItem.SubItems(4).Text)
        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim sql As String = "DELETE FROM tasks WHERE id=@id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", taskID)
                Try
                    cmd.ExecuteNonQuery()
                    ' Close edit mode if deleted
                    If isEditMode And editTaskID = taskID Then
                        txtTitle.Text = ""
                        txtDescription.Text = ""
                        txtTags.Text = ""
                        cmbPriority.SelectedIndex = 1
                        isEditMode = False
                        editTaskID = -1
                        btnAddTask.Text = "Add Task"
                    End If
                    MessageBox.Show("Task deleted successfully.")
                    LoadTasks()
                Catch ex As Exception
                    MessageBox.Show("Error deleting task: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    ' Edit
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim selectedItem As ListViewItem = GetSelectedItem()
        If selectedItem Is Nothing Then Return

        txtTitle.Text = selectedItem.SubItems(0).Text
        txtDescription.Text = selectedItem.SubItems(1).Text
        txtTags.Text = selectedItem.SubItems(2).Text

        ' Set cmbPriority to match
        For i As Integer = 0 To cmbPriority.Items.Count - 1
            If cmbPriority.Items(i).ToString() = selectedItem.SubItems(3).Text Then
                cmbPriority.SelectedIndex = i
                Exit For
            End If
        Next

        isEditMode = True
        editTaskID = CInt(selectedItem.SubItems(4).Text)
        btnAddTask.Text = "Confirm Edit"
    End Sub

    ' Move Left
    Private Sub btnMoveLeft_Click(sender As Object, e As EventArgs) Handles btnMoveLeft.Click
        Dim selectedItem As ListViewItem = GetSelectedItem()
        If selectedItem Is Nothing Then Return

        Dim taskID As Integer = CInt(selectedItem.SubItems(4).Text)
        Dim currentStatus As String = GetItemStatus(selectedItem)
        Dim newStatus As String = ""

        Select Case currentStatus
            Case "in-progress" : newStatus = "todo"
            Case "done" : newStatus = "in-progress"
            Case "todo"
                MessageBox.Show("Cannot move left from TODO.")
                Return
        End Select

        UpdateTaskStatus(taskID, newStatus)
        LoadTasks()
    End Sub

    ' Move Right
    Private Sub btnMoveRight_Click(sender As Object, e As EventArgs) Handles btnMoveRight.Click
        Dim selectedItem As ListViewItem = GetSelectedItem()
        If selectedItem Is Nothing Then Return

        Dim taskID As Integer = CInt(selectedItem.SubItems(4).Text)
        Dim currentStatus As String = GetItemStatus(selectedItem)
        Dim newStatus As String = ""

        Select Case currentStatus
            Case "todo" : newStatus = "in-progress"
            Case "in-progress" : newStatus = "done"
            Case "done"
                MessageBox.Show("Cannot move right from DONE.")
                Return
        End Select

        UpdateTaskStatus(taskID, newStatus)
        LoadTasks()
    End Sub

    ' Logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New LOGIN()
        loginForm.Show()
        Me.Close()
    End Sub

    ' Helpers
    Private Function GetSelectedItem() As ListViewItem
        If lvTodo.SelectedItems.Count > 0 Then
            Return lvTodo.SelectedItems(0)
        ElseIf lvInProgress.SelectedItems.Count > 0 Then
            Return lvInProgress.SelectedItems(0)
        ElseIf lvDone.SelectedItems.Count > 0 Then
            Return lvDone.SelectedItems(0)
        Else
            MessageBox.Show("Please select a task.")
            Return Nothing
        End If
    End Function

    Private Function GetItemStatus(item As ListViewItem) As String
        If lvTodo.Items.Contains(item) Then Return "todo"
        If lvInProgress.Items.Contains(item) Then Return "in-progress"
        If lvDone.Items.Contains(item) Then Return "done"
        Return ""
    End Function

    Private Sub UpdateTaskStatus(taskID As Integer, newStatus As String)
        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim sql As String = "UPDATE tasks SET status=@s WHERE id=@id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@s", newStatus)
                cmd.Parameters.AddWithValue("@id", taskID)
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error updating task status: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

End Class
