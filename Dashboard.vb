Imports MySql.Data.MySqlClient

Public Class Dashboard
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        ShowMyOrders()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        DisplayOrdersOnTextBox()

        txtname.Enabled = False
        txtpname.Enabled = False
        txtoqty.Enabled = False
        txtstatus.Enabled = False
    End Sub

    'Private Function GetLastOrderId1() As Integer
    '    Dim connection As New MySqlConnection(ConnectionString)
    '    Dim query As String = "SELECT MAX(OrderID) FROM ordertable1"
    '    Using cmd As New MySqlCommand(query, connection)
    '        connection.Open()
    '        Dim result As Object = cmd.ExecuteScalar()
    '        connection.Close()
    '        If result IsNot Nothing AndAlso Not IsDBNull(result) Then
    '            Return CInt(result) + 1
    '        Else
    '            Return 1
    '        End If
    '    End Using
    'End Function
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Dim connection As New MySqlConnection(ConnectionString)
        'Dim orderId As Integer = GetLastOrderId1() ' You need to retrieve the specific OrderID to cancel

        'Try
        '    connection.Open()

        '    ' Delete order items
        '    Dim deleteOrderItemsQuery As String = "DELETE FROM order_has_product WHERE OrderID = @OrderID"
        '    Using cmd As New MySqlCommand(deleteOrderItemsQuery, connection)
        '        cmd.Parameters.AddWithValue("@OrderID", orderId)
        '        cmd.ExecuteNonQuery()
        '    End Using

        '    ' Update inventory stock
        '    Dim updateInventoryQuery As String = "UPDATE inventorytable1
        '                              INNER JOIN order_has_product ON inventorytable1.ProductID = order_has_product.ProductID
        '                              SET inventorytable1.inventory_stock = inventorytable1.inventory_stock + order_has_product.order_quantity
        '                              WHERE order_has_product.OrderID = inventory_stock.ProductID"
        '    Using cmd As New MySqlCommand(updateInventoryQuery, connection)
        '        cmd.Parameters.AddWithValue("@OrderID", orderId)
        '        cmd.ExecuteNonQuery()
        '    End Using

        '    ' Delete the order
        '    Dim deleteOrderQuery As String = "DELETE FROM ordertable1 WHERE OrderID = @OrderID"
        '    Using cmd As New MySqlCommand(deleteOrderQuery, connection)
        '        cmd.Parameters.AddWithValue("@OrderID", orderId)
        '        cmd.ExecuteNonQuery()
        '    End Using

        '    MessageBox.Show("Order canceled and changes reverted.")

        'Catch ex As Exception
        '    MessageBox.Show("An error occurred: " & ex.Message)
        'Finally
        '    connection.Close()
        'End Try
    End Sub
End Class