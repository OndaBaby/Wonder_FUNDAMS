Imports MySql.Data.MySqlClient

Public Class ProfileForm

    Private Sub ProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Enabled = False
        txtname.Enabled = False
        txtusername.Enabled = False
        txtnumber.Enabled = False
        txtaddress.Enabled = False
        txtpassword.Enabled = False
    End Sub

    Private Sub chkpass_CheckedChanged(sender As Object, e As EventArgs) Handles chkpass.CheckedChanged
        If chkpass.Checked = True Then
            txtpassword.UseSystemPasswordChar = False
        Else
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Update_Profile()

        Dim sql As String = "SELECT  CustomerID, customer_name, customer_username, customer_number, customer_address, customer_password " &
                  "FROM customertable1 " &
                  "WHERE CustomerID = (SELECT MAX(CustomerID) FROM customertable1)"

        Dim dataTable As DataTable = ReadData(sql)
        If dataTable IsNot Nothing Then
            DGProfile.DataSource = dataTable
        End If
    End Sub

    Private Sub btnPindot_Click(sender As Object, e As EventArgs) Handles btnPindot.Click
        If DGProfile.SelectedRows.Count > 0 Then
            Dim sr As DataGridViewRow = DGProfile.SelectedRows(0)
            Dim row As String
            row = CStr(sr.Cells("CustomerID").Value)

            txtid.Text = sr.Cells("CustomerID").Value.ToString()
            txtname.Text = sr.Cells("customer_name").Value.ToString()
            txtusername.Text = sr.Cells("customer_username").Value.ToString()
            txtnumber.Text = sr.Cells("customer_number").Value.ToString()
            txtaddress.Text = sr.Cells("customer_address").Value.ToString()
        End If

        txtname.Enabled = True
        txtusername.Enabled = True
        txtnumber.Enabled = True
        txtaddress.Enabled = True
        txtpassword.Enabled = True
    End Sub
End Class