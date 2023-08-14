Public Class AccountManagement
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Read_AccountManagement()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Select_AccountManagement()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DGAccountManagement.SelectedRows.Count > 0 Then
            Dim selectedrow As DataGridViewRow = DGAccountManagement.SelectedRows(0)
            Dim row As String = CStr(selectedrow.Cells("CustomerID").Value)

            Delete_AccountManagement(row)
            Read_AccountManagement()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Update_AccountManagement()
    End Sub
End Class