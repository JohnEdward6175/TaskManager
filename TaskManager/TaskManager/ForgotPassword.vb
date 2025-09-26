Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class ForgotPassword
    Dim connStr As String = "server=localhost;user id=taskuser;password=taskpass;database=taskdb;SslMode=none;AllowPublicKeyRetrieval=True;"

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSecurityQuestion.Items.Clear()
        cmbSecurityQuestion.Items.Add("Your first pet's name?")
        cmbSecurityQuestion.Items.Add("Mother's maiden name?")
        cmbSecurityQuestion.Items.Add("Your favorite color?")
        cmbSecurityQuestion.Items.Add("Your birthplace?")
        cmbSecurityQuestion.SelectedIndex = 0
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        If txtUsername.Text = "" Or txtAnswer.Text = "" Or txtNewPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If

        Using conn As New MySqlConnection(connStr)
            conn.Open()

            ' Check username, security question, and answer
            Dim sqlCheck As String = "SELECT COUNT(*) FROM users WHERE username=@username AND security_question=@sq AND security_answer=@ans"
            Using cmd As New MySqlCommand(sqlCheck, conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@sq", cmbSecurityQuestion.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@ans", txtAnswer.Text.Trim())

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count = 0 Then
                    MessageBox.Show("Username, security question, or answer is incorrect.")
                    Return
                End If
            End Using

            ' Update password
            Dim sqlUpdate As String = "UPDATE users SET password=@newpass WHERE username=@username"
            Using cmd As New MySqlCommand(sqlUpdate, conn)
                cmd.Parameters.AddWithValue("@newpass", txtNewPassword.Text)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Password reset successfully. You can now log in.")
                    Me.Close()
                    LOGIN.Show()
                Catch ex As Exception
                    MessageBox.Show("Error updating password: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnBackToLogin_Click(sender As Object, e As EventArgs) Handles btnBackToLogin.Click
        Me.Close()
        LOGIN.Show()
    End Sub
End Class