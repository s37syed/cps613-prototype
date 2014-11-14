Public Class PhoneMenu

    Private Sub PhoneMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeLabel.Text = Now.ToShortTimeString
        TimeLabel.Left = 105 - TimeLabel.Width \ 2
        DateLabel.Text = Format(Date.Now(), "dd" + "/" + "MM" + "/" + "yy")
        DateLabel.Left = 105 - DateLabel.Width \ 2
    End Sub
    Private Sub MapMenuButton_Click(sender As Object, e As EventArgs) Handles MapMenuButton.Click
        ParentPhone.phoneMenuScreen.Enabled = False
        ParentPhone.phoneMenuScreen.Visible = False
        ParentPhone.MapAppScreen.Enabled = True
        ParentPhone.MapAppScreen.Visible = True
    End Sub
End Class
