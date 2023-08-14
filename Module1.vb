Imports CrystalDecisions.Windows
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module Module1

    Public conn As New MySqlConnection("host=localhost;database=dbfundams;username=root;password=")
    Public ConnectionString As String = ("host=localhost;database=dbfundams;username=root;password=")
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Public dataAdapter As MySqlDataAdapter
    Public ds As DataSet
    Public rb1 As Object
    Public VAT As Single = 0.12
    Public id As Integer = 0

    Public Function ReadData(query As String, Optional params As List(Of MySqlParameter) = Nothing) As DataTable
        Using conn As New MySqlConnection(ConnectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    If params IsNot Nothing Then
                        cmd.Parameters.AddRange(params.ToArray())
                    End If
                    Dim dataAdapter As New MySqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    dataAdapter.Fill(dataTable)
                    Return dataTable
                End Using
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
                Return Nothing
            End Try
        End Using
    End Function

    Sub Select_AccountManagement()
        If AccountManagement.DGAccountManagement.SelectedRows.Count > 0 Then
            Dim sr As DataGridViewRow = AccountManagement.DGAccountManagement.SelectedRows(0)
            Dim row As String
            row = CStr(sr.Cells("CustomerID").Value)

            AccountManagement.txtCustomerID.Text = sr.Cells("customer_name").Value.ToString()
            AccountManagement.txtCustomerName.Text = sr.Cells("customer_username").Value.ToString()
            AccountManagement.txtCustomerUsername.Text = sr.Cells("customer_number").Value.ToString()
            AccountManagement.txtCustomerContactNo.Text = sr.Cells("customer_number").Value.ToString()
            AccountManagement.txtaddress.Text = sr.Cells("customer_address").Value.ToString()
        End If
    End Sub

    Sub Delete_AccountManagement(sr As String)
        Using conn As New MySqlConnection("host=127.0.0.1;database=dbfundams;username=root;password=")
            Try
                conn.Open()

                Dim query As String = "DELETE FROM customertable1 WHERE CustomerID = @row"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@row", sr)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Customer is deleted sucessfully.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    Sub Select_InventoryManagement()
        If InventoryManagement.DGInventoryManagement.SelectedRows.Count > 0 Then
            Dim sr As DataGridViewRow = InventoryManagement.DGInventoryManagement.SelectedRows(0)
            Dim row As String
            row = CStr(sr.Cells("InventoryID").Value)

            InventoryManagement.txtinventoryid.Text = sr.Cells("InventoryID").Value.ToString()
            InventoryManagement.txtstock.Text = sr.Cells("inventory_stock").Value.ToString()
            InventoryManagement.txtproductid.Text = sr.Cells("ProductID").Value.ToString()
        End If
    End Sub

    Sub Update_InventoryManagement()
        If InventoryManagement.DGInventoryManagement.SelectedRows.Count > 0 Then
            Dim sr As DataGridViewRow = InventoryManagement.DGInventoryManagement.SelectedRows(0)
            Dim srID As String = CStr(sr.Cells("InventoryID").Value)

            Using conn As New MySqlConnection("host=127.0.0.1;database=dbfundams;username=root;password=")
                Try
                    conn.Open()

                    Dim query As String = $"UPDATE inventorytable1 SET InventoryID=@InventoryID, inventory_stock=@inventory_stock, ProductID=@ProductID WHERE InventoryID = @rowID"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@InventoryID", InventoryManagement.txtinventoryid.Text)
                        cmd.Parameters.AddWithValue("@inventory_stock", InventoryManagement.txtstock.Text)
                        cmd.Parameters.AddWithValue("@ProductID", InventoryManagement.txtproductid.Text)
                        cmd.Parameters.AddWithValue("@rowID", srID)
                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Stock Updated successfully.")
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error:" & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please select a row first.")
        End If
    End Sub

    Sub Select_OrderManagement()
        If OrderManagement.DGOrderManagement.SelectedRows.Count > 0 Then
            Dim sr As DataGridViewRow = OrderManagement.DGOrderManagement.SelectedRows(0)
            Dim row As String
            row = CStr(sr.Cells("OrderID").Value)

            OrderManagement.txtorderid.Text = sr.Cells("OrderID").Value.ToString()
            OrderManagement.txtcustomerid.Text = sr.Cells("CustomerID").Value.ToString()
            OrderManagement.txtstatus.Text = sr.Cells("order_tracking").Value.ToString()
            OrderManagement.txtdate.Text = sr.Cells("order_date").Value.ToString()
        End If
    End Sub

    Sub Delete_OrderManagement(sr As String)
        Using conn As New MySqlConnection("host=127.0.0.1;database=dbfundams;username=root;password=")
            Try
                conn.Open()

                Dim query As String = "DELETE FROM ordertable1 WHERE OrderID = @row"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@row", sr)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Order is deleted sucessfully.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub


    Sub Update_OrderManagement()
        If OrderManagement.DGOrderManagement.SelectedRows.Count > 0 Then
            Dim sr As DataGridViewRow = OrderManagement.DGOrderManagement.SelectedRows(0)
            Dim srID As String = CStr(sr.Cells("OrderID").Value)

            Using conn As New MySqlConnection("host=127.0.0.1;database=dbfundams;username=root;password=")
                Try
                    conn.Open()

                    Dim query As String = $"UPDATE ordertable1 SET OrderID=@OrderID, CustomerID=@CustomerID, order_tracking=@order_tracking WHERE OrderID = @rowID"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@OrderID", OrderManagement.txtorderid.Text)
                        cmd.Parameters.AddWithValue("@CustomerID", OrderManagement.txtcustomerid.Text)
                        cmd.Parameters.AddWithValue("@order_tracking", OrderManagement.txtstatus.Text)
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

    'INVOICE
    Sub Read_InvoiceManagement()
        Using conn As New MySqlConnection("host=127.0.0.1;database=dbfundams;username=root;password=")
            Try
                conn.Open()
                sql = "SELECT o.OrderID, o.CustomerID, o.order_tracking, DATE_FORMAT(o.order_date, '%Y-%m-%d %H:%i:%s') AS order_date, SUM(p.product_cost * p.order_quantity) AS total_cost
                         FROM ordertable1 o JOIN order_has_product p ON o.OrderID = p.OrderID GROUP BY o.OrderID, o.CustomerID, o.order_tracking, o.order_date;"
                dbcomm = New MySqlCommand(sql, conn)
                ds = New DataSet
                dataAdapter = New MySqlDataAdapter(sql, conn)
                ds = New DataSet
                dataAdapter.Fill(ds, "dbfundams")
                InvoiceManagement.DGInvoice.DataSource = ds
                InvoiceManagement.DGInvoice.DataMember = "dbfundams"
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub
    Sub DisplayOrdersOnTextBox()
        If Dashboard.DGMyOrders.SelectedRows.Count > 0 Then
            Dim sr As DataGridViewRow = Dashboard.DGMyOrders.SelectedRows(0)
            Dim row As String
            row = CStr(sr.Cells("customer_name").Value)

            Dashboard.txtname.Text = sr.Cells("customer_name").Value.ToString()
            Dashboard.txtpname.Text = sr.Cells("product_name").Value.ToString()
            Dashboard.txtoqty.Text = sr.Cells("order_quantity").Value.ToString()
            Dashboard.txtstatus.Text = sr.Cells("order_tracking").Value.ToString()
        End If
    End Sub

    Sub ShowProducts()
        Using conn As New MySqlConnection("host=127.0.0.1;database=dbfundams;username=root;password=")
            Try
                conn.Open()
                sql = "SELECT inventorytable1.ProductID, producttable1.product_name, inventorytable1.inventory_stock FROM inventorytable1 LEFT JOIN producttable1 ON inventorytable1.ProductID=producttable1.ProductID"
                dbcomm = New MySqlCommand(sql, conn)
                ds = New DataSet
                dataAdapter = New MySqlDataAdapter(sql, conn)
                ds = New DataSet
                dataAdapter.Fill(ds, "dbfundams")
                InventoryManagement.DGPname.DataSource = ds
                InventoryManagement.DGPname.DataMember = "dbfundams"
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    Sub ShowMyOrders()
        Using conn As New MySqlConnection("host=127.0.0.1;database=dbfundams;username=root;password=")
            Try
                conn.Open()
                sql = "SELECT customertable1.customer_name, producttable1.product_name, order_has_product.order_quantity, ordertable1.order_tracking
                   FROM customertable1
                   JOIN ordertable1 ON customertable1.CustomerID = ordertable1.CustomerID
                   JOIN order_has_product ON ordertable1.OrderID = order_has_product.OrderID
                   JOIN producttable1 ON order_has_product.ProductID = producttable1.ProductID
                   WHERE customertable1.CustomerID = (SELECT MAX(CustomerID) FROM customertable1)"

                ds = New DataSet
                dataAdapter = New MySqlDataAdapter(sql, conn)
                dataAdapter.Fill(ds, "dbfundams")

                Dashboard.DGMyOrders.DataSource = ds
                Dashboard.DGMyOrders.DataMember = "dbfundams"
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    Sub Update_Profile()
        If ProfileForm.DGProfile.SelectedRows.Count > 0 Then
            Dim sr As DataGridViewRow = ProfileForm.DGProfile.SelectedRows(0)
            Dim srID As String = CStr(sr.Cells("CustomerID").Value)

            Using conn As New MySqlConnection("host=127.0.0.1;database=dbfundams;username=root;password=")
                Try
                    conn.Open()

                    Dim query As String = $"UPDATE customertable1 SET CustomerID=@CustomerID, customer_name=@customer_name, customer_username=@customer_username, customer_number=@customer_number, customer_address=@customer_address WHERE CustomerID = @rowID"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@CustomerID", ProfileForm.txtid.Text)
                        cmd.Parameters.AddWithValue("@customer_name", ProfileForm.txtname.Text)
                        cmd.Parameters.AddWithValue("@customer_username", ProfileForm.txtusername.Text)
                        cmd.Parameters.AddWithValue("@customer_number", ProfileForm.txtnumber.Text)
                        cmd.Parameters.AddWithValue("@customer_address", ProfileForm.txtaddress.Text)
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
