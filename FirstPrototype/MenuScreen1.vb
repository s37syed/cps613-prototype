Public Class MenuScreen1
    Private Sub PhoneMenuButton_Click(sender As Object, e As EventArgs) Handles PhoneMenuButton.Click
        Main.PhoneContactsScreen.Enabled = True
        Main.PhoneContactsScreen.Visible = True
        Main.menuScreen1.Visible = False
    End Sub

    Private Sub ContactsMenuButton_Click(sender As Object, e As EventArgs) Handles ContactsMenuButton.Click
        Main.MainScreenTracker = 0
        Main.horizontalCount = 1
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next
        Main.contactScreen1.Visible = True
    End Sub
End Class
