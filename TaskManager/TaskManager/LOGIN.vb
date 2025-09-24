Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class LOGIN
    ' Updated connection string
    Dim connStr As String = "server=localhost;user id=taskuser;password=taskpass;database=taskdb;SslMode=none;AllowPublicKeyRetrieval=True;"

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim sql As String = "SELECT * FROM users WHERE username=@u AND password=@p"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@u", txtUsername.Text)
                cmd.Parameters.AddWithValue("@p", txtPassword.Text)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    MessageBox.Show("Login successful!")
                    Dim board As New main(txtUsername.Text)
                    board.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid username or password.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim reg As New Form1()
        reg.ShowDialog()
    End Sub
End Class
