﻿Public Class DayWeekSelect

    Private Sub DayButton_Click(sender As Object, e As EventArgs) Handles DayButton.Click
        Main.horizontalCount = 13
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next
        Main.task.Visible = True
    End Sub

    Private Sub WeekButton_Click(sender As Object, e As EventArgs) Handles WeekButton.Click
        Main.horizontalCount = 13
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next
        Main.cal.Visible = True
    End Sub
End Class
