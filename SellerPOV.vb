Imports System.Web.UI.WebControls

Public Class SellerPOV
    Sub switchPanel(ByVal panel As Form)
        SellerPanel.Controls.Clear()
        panel.TopLevel = False
        SellerPanel.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub btnAccountManagement_Click(sender As Object, e As EventArgs) Handles btnAccountManagement.Click
        switchPanel(AccountManagement)
    End Sub

    Private Sub btnOrderManagement_Click(sender As Object, e As EventArgs) Handles btnOrderManagement.Click
        switchPanel(OrderManagement)
    End Sub

    Private Sub btnInventoryManagement_Click(sender As Object, e As EventArgs) Handles btnInventoryManagement.Click
        switchPanel(InventoryManagement)
    End Sub

    Private Sub btnInvoiceManagement_Click(sender As Object, e As EventArgs) Handles btnInvoiceManagement.Click
        switchPanel(InvoiceManagement)
    End Sub
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
        MainPage.Show()
    End Sub
End Class