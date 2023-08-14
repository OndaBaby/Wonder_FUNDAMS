Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Apparel_Hoodies
    Private Sub Hoodie1_Click(sender As Object, e As EventArgs) Handles Hoodie1.Click
        id = 7
        search(id)
    End Sub

    Private Sub Hoodie2_Click(sender As Object, e As EventArgs) Handles Hoodie2.Click
        id = 8
        search(id)
    End Sub

    Private Sub Hoodie3_Click(sender As Object, e As EventArgs) Handles Hoodie3.Click
        id = 9
        search(id)
    End Sub

    Private Sub Hoodie4_Click(sender As Object, e As EventArgs) Handles Hoodie4.Click
        id = 10
        search(id)
    End Sub

    Private Sub Hoodie5_Click(sender As Object, e As EventArgs) Handles Hoodie5.Click
        id = 11
        search(id)
    End Sub

    Private Sub Hoodie6_Click(sender As Object, e As EventArgs) Handles Hoodie6.Click
        id = 12
        search(id)
    End Sub
End Class