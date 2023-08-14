Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SignUpForm

    Private Sub chkpass_CheckedChanged(sender As Object, e As EventArgs) Handles chkpass.CheckedChanged
        If chkpass.Checked = True Then
            txtpassS.UseSystemPasswordChar = False
        Else
            txtpassS.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles SignUp.Click
        Dim name As String = txtname.Text
        Dim username As String = txtusernameS.Text
        Dim contact As Single = Convert.ToSingle(txtC_number.Text)
        Dim address As String = txtaddress.Text
        Dim password As String = txtpassS.Text

        Dim queryMaxId As String = "SELECT MAX(CustomerID) FROM customertable1"
        Dim cmdMaxId As New MySqlCommand(queryMaxId, conn)

        Try
            conn.Open()

            ' Get the maximum existing customerid
            Dim maxId As Object = cmdMaxId.ExecuteScalar()
            Dim nextCustomerId As Integer = If(maxId IsNot DBNull.Value, Convert.ToInt32(maxId) + 1, 1)

            ' Insert the new record with the calculated customerid
            Dim queryInsert As String = "INSERT INTO customertable1 (CustomerID, customer_name, customer_username, customer_number, customer_address, customer_password) VALUES (@CustomerID, @customer_name, @customer_username, @customer_number, @customer_address, @customer_password)"
            Dim cmdInsert As New MySqlCommand(queryInsert, conn)
            cmdInsert.Parameters.AddWithValue("@customerid", nextCustomerId)
            cmdInsert.Parameters.AddWithValue("@customer_name", name)
            cmdInsert.Parameters.AddWithValue("@customer_username", username)
            cmdInsert.Parameters.AddWithValue("@customer_number", contact)
            cmdInsert.Parameters.AddWithValue("@customer_address", address)
            cmdInsert.Parameters.AddWithValue("@customer_password", password)

            cmdInsert.ExecuteNonQuery()

            MessageBox.Show("Registration successful!")
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub close_form(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub
End Class
