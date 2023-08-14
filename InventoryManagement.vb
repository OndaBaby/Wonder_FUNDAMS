Imports MySql.Data.MySqlClient

Public Class InventoryManagement
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim sql As String = "SELECT InventoryID, inventory_stock, ProductID FROM inventorytable1"
        Dim dataTable As DataTable = ReadData(sql)
        If dataTable IsNot Nothing Then
            DGInventoryManagement.DataSource = dataTable
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select_InventoryManagement()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Update_InventoryManagement()

        Dim sql As String = "SELECT InventoryID, inventory_stock, ProductID FROM inventorytable1"
        Dim dataTable As DataTable = ReadData(sql)
        If dataTable IsNot Nothing Then
            DGInventoryManagement.DataSource = dataTable
        End If
        txtinventoryid.Clear()
        txtstock.Clear()
        txtproductid.Clear()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ShowProducts()
    End Sub

    Private Sub InventoryManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtinventoryid.Enabled = False
        txtproductid.Enabled = False
    End Sub
End Class