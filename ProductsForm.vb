Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient

Public Class ProductsForm
    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub shirts_btn_Click(sender As Object, e As EventArgs) Handles shirts_btn.Click
        switchPanel(Apparel_Shirts)
    End Sub

    Private Sub hoodies_btn_Click(sender As Object, e As EventArgs) Handles hoodies_btn.Click
        switchPanel(Apparel_Hoodies)
    End Sub

    Private Sub tote_btn_Click(sender As Object, e As EventArgs) Handles tote_btn.Click
        switchPanel(Apparel_ToteBag)
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs)
        Me.Hide()
        ProductsAndServices.Show()
    End Sub

    Private Sub stationaries_btn_Click(sender As Object, e As EventArgs) Handles stationaries_btn.Click
        switchPanel(DP_Stationeries)
    End Sub

    Private Sub packaging_btn_Click(sender As Object, e As EventArgs) Handles packaging_btn.Click
        switchPanel(DP_Packaging)
    End Sub

    Private Sub walldecor_btn_Click(sender As Object, e As EventArgs) Handles walldecor_btn.Click
        switchPanel(DP_WallDecor)
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Close()
        ProductsAndServices.Show()
    End Sub

    Private Sub PackagingCheckOut_Click(sender As Object, e As EventArgs) Handles PackagingCheckOut.Click
        switchPanel(Cart)
    End Sub

    Private Sub PackageAddToCart_Click(sender As Object, e As EventArgs) Handles PackageAddToCart.Click
        Try
            Dim quantity As Integer = Convert.ToInt32(productquantity.Text)
            Dim productID1 As Integer = Convert.ToInt32(productID.Text)
            Dim hoodietypees As String = producttype.Text
            Dim productName1 As String = productname.Text
            Dim productCost1 As Decimal = Convert.ToDecimal(productcost.Text)

            Dim addedtax As Decimal = quantity * productCost1 * VAT
            Dim totalPricewithTax As Decimal = (productCost1 * quantity) + (productCost1 * quantity * VAT)

            Dim rowIndex As Integer = Cart.DGCart.Rows.Add()
            Cart.DGCart.Rows(rowIndex).Cells(0).Value = productID1
            Cart.DGCart.Rows(rowIndex).Cells(1).Value = productName1
            Cart.DGCart.Rows(rowIndex).Cells(2).Value = hoodietypees
            Cart.DGCart.Rows(rowIndex).Cells(3).Value = productCost1
            Cart.DGCart.Rows(rowIndex).Cells(4).Value = quantity
            Cart.DGCart.Rows(rowIndex).Cells(5).Value = addedtax
            Cart.DGCart.Rows(rowIndex).Cells(6).Value = totalPricewithTax

            productquantity.Clear()
            productID.Clear()
            productname.Clear()
            producttype.Clear()
            productcost.Clear()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        MessageBox.Show("Added successfully!")
    End Sub

    Private Sub ProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productID.Enabled = False
        productname.Enabled = False
        producttype.Enabled = False
        productcost.Enabled = False
    End Sub
End Class