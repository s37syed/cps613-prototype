Public Class ReceiveCall

    Private Sub AnswerButton_Click(sender As Object, e As EventArgs) Handles AnswerButton.Click
        Me.Visible = False
        Main.horizontalCount = 15
        Main.CallConnectedScreen.ContactNameLabel.Text = "Dad"
        Main.CallConnectedScreen.Visible = True
        ParentPhone.ChildLocationScreen.OutGoingRingtone.Stop()
        ParentPhone.CallChildScreen.CallerName.Text = "Connected"
    End Sub
End Class
