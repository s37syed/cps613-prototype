Public Class MenuScreen1
    Private Sub PhoneMenuButton_Click(sender As Object, e As EventArgs) Handles PhoneMenuButton.Click
        Main.PhoneContactsScreen.Enabled = True
        Main.PhoneContactsScreen.Visible = True
        Main.menuScreen1.Visible = False
    End Sub
End Class
