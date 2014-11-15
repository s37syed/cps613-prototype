Public Class CallConnected
    Private Sub ConnectedHangUpButton_Click(sender As Object, e As EventArgs) Handles ConnectedHangUpButton.Click
        Main.horizontalCount = 0
        Main.CallConnectedScreen.Visible = False
        Main.MenuScreen0.Visible = True
        Main.MenuScreen0.BringToFront()
        ParentPhone.CallChildScreen.Visible = False
        ParentPhone.phoneMenuScreen.Visible = True
        ParentPhone.phoneMenuScreen.Enabled = True
    End Sub
End Class
