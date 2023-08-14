Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Public Class Apparel_Shirts
    Private Sub Shirt1_Click(sender As Object, e As EventArgs) Handles Shirt1.Click
        id = 1
        search(id)
    End Sub

    Private Sub Shirt2_Click(sender As Object, e As EventArgs) Handles Shirt2.Click
        id = 2
        search(id)
    End Sub

    Private Sub Shirt3_Click(sender As Object, e As EventArgs) Handles Shirt3.Click
        id = 3
        search(id)
    End Sub

    Private Sub Shirt4_Click(sender As Object, e As EventArgs) Handles Shirt4.Click
        id = 4
        search(id)
    End Sub

    Private Sub Shirt5_Click(sender As Object, e As EventArgs) Handles Shirt5.Click
        id = 5
        search(id)
    End Sub

    Private Sub Shirt6_Click(sender As Object, e As EventArgs) Handles Shirt6.Click
        id = 6
        search(id)
    End Sub
End Class