Public Class AccountManagement
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim sql As String = "SELECT CustomerID, customer_name, customer_username, customer_number, customer_address FROM customertable1"
        Dim dataTable As DataTable = ReadData(sql)
        If dataTable IsNot Nothing Then
            DGAccountManagement.DataSource = dataTable
        End If
    End Sub
    Private Sub AccountManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCustomerID.Enabled = False
        txtCustomerName.Enabled = False
        txtCustomerUsername.Enabled = False
        txtaddress.Enabled = False
        txtCustomerContactNo.Enabled = False
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Select_AccountManagement()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DGAccountManagement.SelectedRows.Count > 0 Then
            Dim selectedrow As DataGridViewRow = DGAccountManagement.SelectedRows(0)
            Dim row As String = CStr(selectedrow.Cells("CustomerID").Value)

            Delete_AccountManagement(row)
            Dim sql As String = "SELECT CustomerID, customer_name, customer_username, customer_number, customer_address FROM customertable1"
            Dim dataTable As DataTable = ReadData(sql)
            If dataTable IsNot Nothing Then
                DGAccountManagement.DataSource = dataTable
            End If
        End If
    End Sub
End Class