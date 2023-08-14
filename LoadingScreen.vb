Public Class LoadingScreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblprog.Text = ProgLoad1.Value & "%"

        ProgLoad1.Value += 1

        If ProgLoad1.Value > 10 Then
            lblstatus.Text = "Loading"
        End If

        If ProgLoad1.Value > 40 Then
            lblstatus.Text = "Please wait..."
        End If

        If ProgLoad1.Value > 70 Then
            lblstatus.Text = "Launching"
        End If

        If ProgLoad1.Value > 99 Then
            lblstatus.Text = "Welcome to Wonderprints"
        End If

        If ProgLoad1.Value = 100 Then
            MainPage.Show()
            Me.Hide()
            Timer1.Dispose()
        End If

    End Sub

    Private Sub close_form(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class