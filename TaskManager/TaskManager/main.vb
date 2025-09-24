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

        ' Set ListView font
        Dim listFont As New Font("Segoe UI", 12, FontStyle.Regular)
        lvTodo.Font = listFont
        lvInProgress.Font = listFont
        lvDone.Font = listFont

        LoadTasks()
    End Sub

    ' Load tasks into ListViews (supports partial search)
    Private Sub LoadTasks(Optional searchTerm As String = "")
        lvTodo.Items.Clear()
        lvInProgress.Items.Clear()
        lvDone.Items.Clear()

        Using conn As New MySqlConnection(connStr)
            conn.Open()

            Dim sql As String = "SELECT id, title, description, tags, status FROM tasks"
            If searchTerm <> "" Then
                sql &= " WHERE title LIKE @search OR description LIKE @search OR tags LIKE @search"
            End If

            Using cmd As New MySqlCommand(sql, conn)
                If searchTerm <> "" Then
                    cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim li As New ListViewItem(reader("title").ToString())
                        li.SubItems.Add(reader("description").ToString())
                        li.SubItems.Add(reader("tags").ToString())
                        li.SubItems.Add(reader("id").ToString()) ' Hidden ID

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
        If txtTitle.Text = "" Or txtDescription.Text = "" Or txtTags.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim sql As String
            If isEditMode Then
                sql = "UPDATE tasks SET title=@t, description=@d, tags=@tg WHERE id=@id"
            Else
                sql = "INSERT INTO tasks (title, description, tags, status) VALUES (@t,@d,@tg,'todo')"
            End If

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@t", txtTitle.Text)
                cmd.Parameters.AddWithValue("@d", txtDescription.Text)
                cmd.Parameters.AddWithValue("@tg", txtTags.Text)
                If isEditMode Then
                    cmd.Parameters.AddWithValue("@id", editTaskID)
                End If

                Try
                    cmd.ExecuteNonQuery()
                    If isEditMode Then
                        MessageBox.Show("Task updated successfully!")
                    Else
                        MessageBox.Show("Task added successfully!")
                    End If

                    ' Reset fields
                    txtTitle.Text = ""
                    txtDescription.Text = ""
                    txtTags.Text = ""
                    LoadTasks()

                    ' Reset edit mode
                    isEditMode = False
                    editTaskID = -1
                    btnAddTask.Text = "Add Task"
                Catch ex As Exception
                    MessageBox.Show("Error saving task: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    ' Search tasks
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm As String = txtSearch.Text.Trim()
        LoadTasks(searchTerm)
    End Sub

    ' Logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New LOGIN()
        loginForm.Show()
        Me.Close()
    End Sub

    ' Delete selected task
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedItem As ListViewItem = GetSelectedItem()
        If selectedItem Is Nothing Then Return

        If MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim taskID As Integer = CInt(selectedItem.SubItems(3).Text)
        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim sql As String = "DELETE FROM tasks WHERE id=@id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", taskID)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Task deleted successfully.")
                    LoadTasks()
                Catch ex As Exception
                    MessageBox.Show("Error deleting task: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    ' Edit task (fills fields and sets edit mode)
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim selectedItem As ListViewItem = GetSelectedItem()
        If selectedItem Is Nothing Then Return

        txtTitle.Text = selectedItem.SubItems(0).Text
        txtDescription.Text = selectedItem.SubItems(1).Text
        txtTags.Text = selectedItem.SubItems(2).Text

        isEditMode = True
        editTaskID = CInt(selectedItem.SubItems(3).Text)
        btnAddTask.Text = "Confirm Edit"
    End Sub

    ' Move selected task left
    Private Sub btnMoveLeft_Click(sender As Object, e As EventArgs) Handles btnMoveLeft.Click
        Dim selectedItem As ListViewItem = GetSelectedItem()
        If selectedItem Is Nothing Then Return

        Dim taskID As Integer = CInt(selectedItem.SubItems(3).Text)
        Dim currentStatus As String = GetItemStatus(selectedItem)
        Dim newStatus As String = ""

        Select Case currentStatus
            Case "in-progress"
                newStatus = "todo"
            Case "done"
                newStatus = "in-progress"
            Case "todo"
                MessageBox.Show("Cannot move left from TODO.")
                Return
        End Select

        UpdateTaskStatus(taskID, newStatus)
        LoadTasks()
    End Sub

    ' Move selected task right
    Private Sub btnMoveRight_Click(sender As Object, e As EventArgs) Handles btnMoveRight.Click
        Dim selectedItem As ListViewItem = GetSelectedItem()
        If selectedItem Is Nothing Then Return

        Dim taskID As Integer = CInt(selectedItem.SubItems(3).Text)
        Dim currentStatus As String = GetItemStatus(selectedItem)
        Dim newStatus As String = ""

        Select Case currentStatus
            Case "todo"
                newStatus = "in-progress"
            Case "in-progress"
                newStatus = "done"
            Case "done"
                MessageBox.Show("Cannot move right from DONE.")
                Return
        End Select

        UpdateTaskStatus(taskID, newStatus)
        LoadTasks()
    End Sub

    ' Helper: get selected item from any ListView
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

    ' Helper: determine ListView status of an item
    Private Function GetItemStatus(item As ListViewItem) As String
        If lvTodo.Items.Contains(item) Then Return "todo"
        If lvInProgress.Items.Contains(item) Then Return "in-progress"
        If lvDone.Items.Contains(item) Then Return "done"
        Return ""
    End Function

    ' Helper: update task status in DB
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
