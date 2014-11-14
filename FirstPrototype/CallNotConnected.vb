Public Class CallNotConnected

    Private Sub LeaveMessageButton_Click(sender As Object, e As EventArgs) Handles LeaveMessageButton.Click
        Main.LeaveMsgTime = New System.Threading.Thread(AddressOf Main.WorkerThread4)
        Main.LeaveMsgTime.Start()
    End Sub
    Private Sub RedialButton_Click(sender As Object, e As EventArgs) Handles RedialButton.Click
        Main.RediallingScreen.RedialTimer.Start()
        Main.RediallingScreen.RedialingTimerLabel.Text = 5
        Main.CallNotConnectedScreen.Visible = False
        Main.RediallingScreen.Visible = True
        Main.RediallingScreen.BringToFront()
    End Sub
End Class
