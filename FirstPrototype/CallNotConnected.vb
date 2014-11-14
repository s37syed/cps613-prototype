Public Class CallNotConnected

    Private Sub RedialButton_Click(sender As Object, e As EventArgs) Handles RedialButton.Click
        Main.RediallingScreen.RedialTimer.Start()
        Main.RediallingScreen.RedialingTimerLabel.Text = 5
        Main.CallNotConnectedScreen.Visible = False
        Main.RediallingScreen.Visible = True
        Main.RediallingScreen.BringToFront()
    End Sub
End Class
