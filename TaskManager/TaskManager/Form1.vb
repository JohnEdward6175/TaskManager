Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class Form1
    ' Updated connection string with fixed password
    Dim connStr As String = "server=localhost;user id=taskuser;password=taskpass;database=taskdb;SslMode=none;AllowPublicKeyRetrieval=True;"

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LOGIN.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim sql As String = "INSERT INTO users (username, password, name) VALUES (@u,@p,@n)"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@u", txtUsername.Text)
            cmd.Parameters.AddWithValue("@p", txtPassword.Text) ' ⚠️ For production, use hashing!
            cmd.Parameters.AddWithValue("@n", txtName.Text)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registration successful! You can now log in.")

                ' --- Close current registration form and open LOGIN form ---
                Me.Close()                ' Close Form1
                Dim loginForm As New LOGIN()
                loginForm.Show()          ' Open LOGIN form

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

