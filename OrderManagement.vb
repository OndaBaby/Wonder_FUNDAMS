Public Class OrderManagement
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim sql As String = "SELECT OrderID, CustomerID, order_tracking, DATE_FORMAT(order_date, '%Y-%m-%d %H:%i:%s') order_date FROM ordertable1"
        Dim dataTable As DataTable = ReadData(sql)
        If dataTable IsNot Nothing Then
            DGOrderManagement.DataSource = dataTable
        End If
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Select_OrderManagement()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Update_OrderManagement()
        Dim sql As String = "SELECT OrderID, CustomerID, order_tracking, DATE_FORMAT(order_date, '%Y-%m-%d %H:%i:%s') order_date FROM ordertable1"
        Dim dataTable As DataTable = ReadData(sql)
        If dataTable IsNot Nothing Then
            DGOrderManagement.DataSource = dataTable
        End If

        txtorderid.Clear()
        txtcustomerid.Clear()
        txtstatus.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If DGOrderManagement.SelectedRows.Count > 0 Then
            Dim selectedrow As DataGridViewRow = DGOrderManagement.SelectedRows(0)
            Dim row As String = CStr(selectedrow.Cells("OrderID").Value)

            Delete_OrderManagement(row)
            Dim sql As String = "SELECT OrderID, CustomerID, order_tracking, DATE_FORMAT(order_date, '%Y-%m-%d %H:%i:%s') order_date FROM ordertable1"
            Dim dataTable As DataTable = ReadData(sql)
            If dataTable IsNot Nothing Then
                DGOrderManagement.DataSource = dataTable
            End If
        End If
    End Sub
End Class