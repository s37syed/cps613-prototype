Public Class Calling

    Private Sub HangUp_Click(sender As Object, e As EventArgs) Handles HangUp.Click
        Main.CallingScreen.Visible = False
        Main.MenuScreen0.Visible = True
        Main.ResetTracker()
        'Main.SwipeLeftButton.
    End Sub


End Class
