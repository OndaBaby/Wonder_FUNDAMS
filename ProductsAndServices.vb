Imports System.Web
Imports MySql.Data.MySqlClient

Public Class ProductsAndServices

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainPage.Show()
    End Sub

    Private Sub products_btn_Click(sender As Object, e As EventArgs) Handles products_btn.Click
        Me.Hide()
        ProductsForm.Show()
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub profile_btn_Click(sender As Object, e As EventArgs) Handles profile_btn.Click
        Try
            Using connection As New MySqlConnection(ConnectionString)
                connection.Open()

                ' Get the last inserted CustomerID
                Dim maxCustomerIdQuery As String = "SELECT MAX(CustomerID) FROM customertable1"
                Dim lastCustomerId As Integer

                Using maxCustomerIdCommand As New MySqlCommand(maxCustomerIdQuery, connection)
                    Dim result As Object = maxCustomerIdCommand.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        lastCustomerId = Convert.ToInt32(result)
                    Else
                        ' Handle case where no data is found
                        MessageBox.Show("No customers found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If
                End Using

                ' Use the retrieved CustomerID to fetch customer details
                Dim query As String = "SELECT CustomerID, customer_name, customer_username, customer_number, customer_address, customer_password FROM customertable1 WHERE CustomerID = @CustomerID"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@CustomerID", lastCustomerId)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim id As Integer = reader.GetInt32(0)
                            Dim name As String = reader.GetString(1)
                            Dim username As String = reader.GetString(2)
                            Dim number As Integer = reader.GetInt32(3)
                            Dim address As String = reader.GetString(4)
                            Dim password As String = reader.GetString(5)

                            ' Set the TextBox texts
                            ProfileForm.txtid.Text = id
                            ProfileForm.txtname.Text = name
                            ProfileForm.txtusername.Text = username
                            ProfileForm.txtnumber.Text = number.ToString() ' Convert to string
                            ProfileForm.txtaddress.Text = address
                            ProfileForm.txtpassword.Text = password

                            ProfileForm.labelName.Text = "Hello, " & name
                        Else
                            ' Handle case where no data is found
                            MessageBox.Show("Customer not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        Dim sql As String = "SELECT  CustomerID, customer_name, customer_username, customer_number, customer_address, customer_password " &
                          "FROM customertable1 " & "WHERE CustomerID = (SELECT MAX(CustomerID) FROM customertable1)"

                        Dim dataTable As DataTable = ReadData(sql)
                        If dataTable IsNot Nothing Then
                            ProfileForm.DGProfile.DataSource = dataTable
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        switchPanel(ProfileForm)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchPanel(Dashboard)
    End Sub
End Class