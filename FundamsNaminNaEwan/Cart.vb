Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Cart
    Private connectionString As String = "host=localhost;database=databasefundamentalproject;username=root;password="

    Private Sub CartCheckOut_Click(sender As Object, e As EventArgs) Handles CartCheckOut.Click
        Dim transaction As MySqlTransaction = Nothing
        Dim connection As MySqlConnection = Nothing

        Try
            connection = New MySqlConnection(connectionString)
            connection.Open()

            transaction = connection.BeginTransaction()

            For Each row As DataGridViewRow In DGCart.Rows
                Dim productID As Integer = Convert.ToInt32(row.Cells("ids").Value)

                Dim latestCustomerID As Integer = GetLatestCustomerID(connection, transaction)

                Dim newOrderID As Integer = GenerateOrderID(connection, transaction)

                InsertOrderTable(connection, transaction, newOrderID, latestCustomerID, productID)
            Next

            transaction.Commit()

            MessageBox.Show("Orders inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            If transaction IsNot Nothing Then
                transaction.Rollback()
            End If

            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If transaction IsNot Nothing Then
                transaction.Dispose()
            End If

            If connection IsNot Nothing Then
                connection.Close()
                connection.Dispose()
            End If
        End Try
    End Sub
    Private Sub InsertOrderTable(connection As MySqlConnection, transaction As MySqlTransaction, orderID As Integer, customerID As Integer, productID As Integer)
        Dim insertQuery As String = "INSERT INTO ordertable1 (OrderID, CustomerID, ProductID) VALUES (@OrderID, @CustomerID, @ProductID)"

        Using insertCommand As New MySqlCommand(insertQuery, connection, transaction)
            insertCommand.Parameters.AddWithValue("@OrderID", orderID)
            insertCommand.Parameters.AddWithValue("@CustomerID", customerID)
            insertCommand.Parameters.AddWithValue("@ProductID", productID)
            insertCommand.ExecuteNonQuery()
        End Using
    End Sub
    Private Function GenerateOrderID(connection As MySqlConnection, transaction As MySqlTransaction) As Integer
        Dim newOrderID As Integer = 0

        Return newOrderID
    End Function

    Private Function GetLatestCustomerID(connection As MySqlConnection, transaction As MySqlTransaction) As Integer
        Dim latestCustomerID As Integer = 0
        Dim query As String = "SELECT MAX(CustomerID) FROM customertable1"

        Using command As New MySqlCommand(query, connection, transaction)
            Dim result As Object = command.ExecuteScalar()
            If result IsNot DBNull.Value Then
                latestCustomerID = Convert.ToInt32(result)
            End If
        End Using

        Return latestCustomerID
    End Function
End Class