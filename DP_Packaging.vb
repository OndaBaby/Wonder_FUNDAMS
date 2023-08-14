Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography.X509Certificates

Public Class DP_Packaging
    Private Sub Package1_Click(sender As Object, e As EventArgs) Handles Package1.Click
        id = 26
        search(id)
    End Sub

    Private Sub Package3_Click(sender As Object, e As EventArgs) Handles Package3.Click
        id = 27
        search(id)
    End Sub

    Private Sub Package4_Click(sender As Object, e As EventArgs) Handles Package4.Click
        id = 28
        search(id)
    End Sub

    Private Sub PhotoPrint2_Click(sender As Object, e As EventArgs) Handles PhotoPrint2.Click
        id = 24
        search(id)
    End Sub

    Private Sub PhotoPrint1_Click(sender As Object, e As EventArgs) Handles PhotoPrint1.Click
        id = 25
        search(id)
    End Sub
End Class
