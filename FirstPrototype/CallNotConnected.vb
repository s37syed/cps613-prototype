Public Class CallNotConnected

    Private Sub LeaveMessageButton_Click(sender As Object, e As EventArgs) Handles LeaveMessageButton.Click
        Main.LeaveMsgTime = New System.Threading.Thread(AddressOf Main.WorkerThread4)
        Main.LeaveMsgTime.Start()
    End Sub
End Class
