Public Class CallChild

    Private Sub ParentHangUpButton_Click(sender As Object, e As EventArgs) Handles ParentHangUpButton.Click
        ParentPhone.CallChildScreen.Enabled = False
        ParentPhone.CallChildScreen.Visible = False
        ParentPhone.phoneMenuScreen.Enabled = True
        ParentPhone.phoneMenuScreen.Visible = True
        ParentPhone.ChildLocationScreen.OutGoingRingtone.Stop()
        Main.CallConnectedScreen.Visible = False
        Main.horizontalCount = 0
        Main.MenuScreen0.Visible = True
        Main.MenuScreen0.BringToFront()
    End Sub
End Class
