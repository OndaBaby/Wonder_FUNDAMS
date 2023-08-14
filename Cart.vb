Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Cart

    Dim connection As New MySqlConnection(ConnectionString)


    Private Function GetLastCustomerId1() As Integer
        Dim connection As New MySqlConnection(ConnectionString)
        Dim query As String = "SELECT MAX(CustomerID) FROM customertable1"
        Using cmd As New MySqlCommand(query, connection)
            connection.Open()
            Dim result As Object = cmd.ExecuteScalar()
            connection.Close()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return CInt(result)
            Else
                Return 1
            End If
        End Using
    End Function

    Private Function GetLastOrderId1() As Integer
        Dim connection As New MySqlConnection(ConnectionString)
        Dim query As String = "SELECT MAX(OrderID) FROM ordertable1"
        Using cmd As New MySqlCommand(query, connection)
            connection.Open()
            Dim result As Object = cmd.ExecuteScalar()
            connection.Close()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return CInt(result) + 1
            Else
                Return 1
            End If
        End Using
    End Function

    Private Sub CartCheckOut_Click(sender As Object, e As EventArgs) Handles CartCheckOut.Click
        receipt.Clear()
        Dim connection As New MySqlConnection(ConnectionString)
        Dim customerId As Integer = GetLastCustomerId1()
        Dim orderId As Integer = GetLastOrderId1()
        Dim orderDate As Date = DateTime.Now
        Dim ordertracking As String = "Processing"

        Dim insertQuery As String = "INSERT INTO ordertable1 (OrderID, CustomerID, order_tracking, order_date) VALUES (@OrderID, @CustomerID, @order_tracking, @order_date)"
        Using cmd As New MySqlCommand(insertQuery, connection)
            cmd.Parameters.AddWithValue("@OrderID", orderId)
            cmd.Parameters.AddWithValue("@CustomerID", customerId)
            cmd.Parameters.AddWithValue("@order_tracking", ordertracking)
            cmd.Parameters.AddWithValue("@order_date", orderDate)
            connection.Open()
            cmd.ExecuteNonQuery()
        End Using

        For Each row As DataGridViewRow In DGCart.Rows
            Dim productId As Integer = CInt(row.Cells("ids").Value)
            Dim productCost As Decimal = CDec(row.Cells("pricess").Value)
            Dim orderQuantity As Integer = CInt(row.Cells("qtys").Value)

            Dim insertOrderItemQuery As String = "INSERT INTO order_has_product (OrderID, ProductID, product_cost, order_quantity) VALUES (@OrderID, @ProductID, @product_cost, @order_quantity)"
            Using cmd As New MySqlCommand(insertOrderItemQuery, connection)
                cmd.Parameters.AddWithValue("@OrderID", orderId)
                cmd.Parameters.AddWithValue("@ProductID", productId)
                cmd.Parameters.AddWithValue("@product_cost", productCost)
                cmd.Parameters.AddWithValue("@order_quantity", orderQuantity)
                cmd.ExecuteNonQuery()
            End Using

            Dim updateInventoryQuery As String = "UPDATE inventorytable1 SET inventory_stock = inventory_stock - @order_quantity WHERE ProductID = @ProductID"
            Using cmd As New MySqlCommand(updateInventoryQuery, connection)
                cmd.Parameters.AddWithValue("@order_quantity", orderQuantity)
                cmd.Parameters.AddWithValue("@ProductID", productId)
                cmd.ExecuteNonQuery()
            End Using

            If Not row.IsNewRow Then
                For Each cell As DataGridViewCell In row.Cells
                    receipt.AppendText(cell.Value.ToString() & vbCrLf)
                Next
                receipt.AppendText(vbCrLf)
            End If
        Next
        connection.Close()
        MessageBox.Show("Orders saved successfully.")
    End Sub

End Class