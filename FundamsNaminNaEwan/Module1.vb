Imports CrystalDecisions.Windows
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module Module1

    Public conn As New MySqlConnection("host=localhost;database=databasefundamentalproject;username=root;password=")
    Public ConnectionString As String = ("host=localhost;database=databasefundamentalproject;username=root;password=")
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Public dataAdapter As MySqlDataAdapter
    Public ds As DataSet
    Public dataAdapter2 As MySqlDataAdapter
    Public rb1 As Object
    Public VAT As Single = 0.1

    Public id As Integer = 0

    Sub Read_AccountManagement()
        Using conn As New MySqlConnection("host=127.0.0.1;database=databasefundamentalproject;username=root;password=")
            Try
                conn.Open()
                sql = "SELECT CustomerID, customer_name, customer_username, customer_number FROM customer_table"
                dbcomm = New MySqlCommand(sql, conn)
                ds = New DataSet
                dataAdapter = New MySqlDataAdapter(sql, conn)
                ds = New DataSet
                dataAdapter.Fill(ds, "mydb")
                AccountManagement.DGAccountManagement.DataSource = ds
                AccountManagement.DGAccountManagement.DataMember = "mydb"
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    Sub Select_AccountManagement()
        If AccountManagement.DGAccountManagement.SelectedRows.Count > 0 Then
            Dim sr As DataGridViewRow = AccountManagement.DGAccountManagement.SelectedRows(0)
            Dim row As String

            row = CStr(sr.Cells("CustomerID").Value)

            AccountManagement.txtCustomerID.Text = sr.Cells("CustomerID").Value.ToString()
            AccountManagement.txtCustomerName.Text = sr.Cells("customer_name").Value.ToString()
            AccountManagement.txtCustomerUsername.Text = sr.Cells("customer_username").Value.ToString()
            AccountManagement.txtCustomerContactNo.Text = sr.Cells("customer_number").Value.ToString()
        End If
    End Sub

    Sub Delete_AccountManagement(sr As String)
        Using conn As New MySqlConnection("host=127.0.0.1;database=mydb;username=root;password=")
            Try
                conn.Open()

                Dim query As String = "DELETE FROM customer_table WHERE CustomerID = @row"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@row", sr)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Deleted successfully.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    Sub Update_AccountManagement()
        If AccountManagement.DGAccountManagement.SelectedRows.Count > 0 Then
            Dim sr As DataGridViewRow = AccountManagement.DGAccountManagement.SelectedRows(0)
            Dim srID As String = CStr(sr.Cells("CustomerID").Value)

            Using conn As New MySqlConnection("host=127.0.0.1;database=mydb;username=root;password=")
                Try
                    conn.Open()

                    Dim query As String = $"UPDATE customer_table SET CustomerID=@CustomerID, customer_name=@customer_name, customer_username=@customer_username, customer_number=@customer_number WHERE CustomerID = @rowID"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@CustomerID", AccountManagement.txtCustomerID.Text)
                        cmd.Parameters.AddWithValue("@customer_name", AccountManagement.txtCustomerName.Text)
                        cmd.Parameters.AddWithValue("@customer_username", AccountManagement.txtCustomerUsername.Text)
                        cmd.Parameters.AddWithValue("@customer_number", AccountManagement.txtCustomerContactNo.Text)
                        cmd.Parameters.AddWithValue("@rowID", srID)
                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Updated successfully.")
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error:" & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("No row selected.")
        End If
    End Sub

    Public Sub search(id As Integer)
        Try
            Using connection As New MySqlConnection(ConnectionString)
                connection.Open()
                Dim query As String = "SELECT ProductID, product_name, product_type, product_cost FROM producttable1 WHERE ProductID = @ProductID"

                Using command As New MySqlCommand(query, connection)
                    ' Replace with the actual product ID you want to retrieve
                    command.Parameters.AddWithValue("@ProductID", id) ' Example ProductID

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim productID As Integer = reader.GetInt32(0)
                            Dim productName As String = reader.GetString(1)
                            Dim producttypes As String = reader.GetString(2)
                            Dim productcost As String = reader.GetString(3)

                            ' Set the TextBox texts
                            ProductsForm.productID.Text = productID.ToString()
                            ProductsForm.productname.Text = productName
                            ProductsForm.producttype.Text = producttypes
                            ProductsForm.productcost.Text = productcost

                        Else
                            ' Handle case where no data is found
                            MessageBox.Show("Product not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
