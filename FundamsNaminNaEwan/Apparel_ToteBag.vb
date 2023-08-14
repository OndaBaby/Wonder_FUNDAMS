Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Public Class Apparel_ToteBag
    Private Sub Tote1_Click(sender As Object, e As EventArgs) Handles Tote1.Click
        id = 13
        search(id)
    End Sub

    Private Sub Tote2_Click(sender As Object, e As EventArgs) Handles Tote2.Click
        id = 14
        search(id)
    End Sub

    Private Sub Tote3_Click(sender As Object, e As EventArgs) Handles Tote3.Click
        id = 15
        search(id)
    End Sub

    Private Sub Tote4_Click(sender As Object, e As EventArgs) Handles Tote4.Click
        id = 16
        search(id)
    End Sub

    Private Sub Tote5_Click(sender As Object, e As EventArgs) Handles Tote5.Click
        id = 17
        search(id)
    End Sub
End Class