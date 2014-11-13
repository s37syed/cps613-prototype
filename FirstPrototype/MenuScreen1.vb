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

    Private Sub CalendarMenuButton_Click(sender As Object, e As EventArgs) Handles CalendarMenuButton.Click
        Main.MainScreenTracker = 0
        Main.horizontalCount = 5
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next
        Main.cal.Visible = True
    End Sub

    Private Sub MessagesMenuButton_Click(sender As Object, e As EventArgs) Handles MessagesMenuButton.Click
        Main.MainScreenTracker = 0
        Main.horizontalCount = 7
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next
        Main.SendMsgType2.Visible = True 'added this
    End Sub
End Class
