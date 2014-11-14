Public Class CallConnected

    Private Sub ConnectedHangUpButton_Click(sender As Object, e As EventArgs) Handles ConnectedHangUpButton.Click
        Main.CallConnectedScreen.Visible = False
        Main.MenuScreen0.Visible = True
        Main.MenuScreen1.BringToFront()
    End Sub
End Class
