Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class Form1
    ' Updated connection string
    Dim connStr As String = "server=localhost;user id=taskuser;password=taskpass;database=taskdb;SslMode=none;AllowPublicKeyRetrieval=True;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSecurityQuestion.Items.Clear()
        cmbSecurityQuestion.Items.Add("Your first pet's name?")
        cmbSecurityQuestion.Items.Add("Mother's maiden name?")
        cmbSecurityQuestion.Items.Add("Your favorite color?")
        cmbSecurityQuestion.Items.Add("Your birthplace?")
        cmbSecurityQuestion.SelectedIndex = 0
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LOGIN.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Basic validation
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtName.Text = "" Or txtAnswer.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim sql As String = "INSERT INTO users (username, password, name, security_question, security_answer) VALUES (@u,@p,@n,@q,@a)"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@u", txtUsername.Text)
            cmd.Parameters.AddWithValue("@p", txtPassword.Text)
            cmd.Parameters.AddWithValue("@n", txtName.Text)
            cmd.Parameters.AddWithValue("@q", cmbSecurityQuestion.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@a", txtAnswer.Text)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registration successful! You can now log in.")


                Me.Close()
                Dim loginForm As New LOGIN()
                loginForm.Show()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        LOGIN.Show()
        Me.Hide()
    End Sub
End Class
