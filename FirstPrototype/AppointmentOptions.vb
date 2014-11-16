Public Class AppointmentOptions

    Private Sub DeleteMessage_Click(sender As Object, e As EventArgs) Handles DeleteMessage.Click
        Main.tasks2.Label1.Text = ""
        Me.Hide()
    End Sub

    Private Sub CreateReminder_Click(sender As Object, e As EventArgs) Handles CreateReminder.Click
        Me.Hide()
        Main.ReminderTime = New System.Threading.Thread(AddressOf Main.WorkerThread3)
        Main.ReminderTime.Start()
        Main.tasks2.Label1.Text = "6pm - danielle mom"
    End Sub
End Class
