Public Class ReceiveCall

    Private Sub AnswerButton_Click(sender As Object, e As EventArgs) Handles AnswerButton.Click
        Me.Visible = False
        Main.horizontalCount = 15
        Main.CallConnectedScreen.ContactNameLabel.Text = "Dad"
        Main.CallConnectedScreen.ContactNameLabel.Left = 57 - Main.CallConnectedScreen.ContactNameLabel.Width \ 2
        Main.CallConnectedScreen.Visible = True
        ParentPhone.ChildLocationScreen.OutGoingRingtone.Stop()
        ParentPhone.CallChildScreen.CallerName.Text = "Connected"
        ParentPhone.CallChildScreen.CallerName.Left = 105 - ParentPhone.CallChildScreen.CallerName.Width \ 2
    End Sub
    Public Sub swipeLeft()
        ParentPhone.ChildLocationScreen.OutGoingRingtone.Stop()
        ParentPhone.ChildLocationScreen.Visible = False
        ParentPhone.phoneMenuScreen.Visible = True
        ParentPhone.phoneMenuScreen.Enabled = True
    End Sub
End Class
