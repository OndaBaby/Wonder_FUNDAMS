Imports MySql.Data.MySqlClient

Public Class LogInForm
    Private Sub cbshow_CheckedChanged(sender As Object, e As EventArgs) Handles chklogpass.CheckedChanged
        If chklogpass.Checked = True Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub LogIncmd_Click(sender As Object, e As EventArgs) Handles LogIncmd.Click
        Dim defaultUsername As String = "admin"
        Dim defaultPassword As String = "kawonder"
        Dim enteredUsername As String = txtusername.Text
        Dim enteredPassword As String = txtpass.Text
        Dim connString As String = "Data Source=localhost;database=dbfundams;port=3306;;username=root;password="
        Dim query As String = "SELECT * FROM customertable1 WHERE customer_username=@customer_username AND customer_password=@customer_password"


        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@customer_username", txtusername.Text.Trim())
                cmd.Parameters.AddWithValue("@customer_password", txtpass.Text.Trim())
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ProductsAndServices.Show()
                    Me.Hide()
                    MainPage.Hide()
                ElseIf enteredUsername = defaultUsername AndAlso enteredPassword = defaultPassword Then
                    MessageBox.Show("Admin Log In successfully!")
                    Dim targetForm As New SellerPOV()
                    targetForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Incorrect username or password! Please try again.")
                End If
            End Using
        End Using
    End Sub

    Private Sub close_form(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub
End Class