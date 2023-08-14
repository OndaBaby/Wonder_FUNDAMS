Public Class ProductsAndServices

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainPage.Show()
    End Sub

    Private Sub products_btn_Click(sender As Object, e As EventArgs) Handles products_btn.Click
        Me.Hide()
        ProductsForm.Show()
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub profile_btn_Click(sender As Object, e As EventArgs) Handles profile_btn.Click
        switchPanel(ProfileForm)
    End Sub
End Class