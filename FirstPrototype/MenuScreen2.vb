﻿Public Class MenuScreen2

    Private Sub MusicMenuButton_Click(sender As Object, e As EventArgs) Handles MusicMenuButton.Click
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next
        Main.songPanel1.Show()
        Main.songPanel2.Show()
        Main.songPanel3.Show()
        Main.songPanel4.Show()
        Main.MusicAppCounter += 1
        Main.MainScreenTracker = 0
        Main.horizontalCount = 8
    End Sub

    Private Sub SilenceMenuButton_Click(sender As Object, e As EventArgs) Handles SilenceMenuButton.Click
        Main.ErrorMsgTime = New System.Threading.Thread(AddressOf Main.WorkerThread2)
        Main.ErrorMsgTime.Start()
    End Sub

    Private Sub SettingsMenuButton_Click(sender As Object, e As EventArgs) Handles SettingsMenuButton.Click
        Main.ErrorMsgTime = New System.Threading.Thread(AddressOf Main.WorkerThread2)
        Main.ErrorMsgTime.Start()
    End Sub

    Private Sub Reminder_Click(sender As Object, e As EventArgs) Handles ReminderAppoint.Click
        'selecting current date of calendar brings up tasks
        Main.horizontalCount = 9
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next
        Main.tasks2.Show()
    End Sub
End Class
