Public Class Calendar2
    Private Sub Calendar2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display current date
        WeekLabel.Text = Format(Date.Now(), "MMM" + "." + " dd")
    End Sub

    Private Sub CurrentDay_Click(sender As Object, e As EventArgs) Handles Day5.Click
        If Main.cal.SelectableDay = 3 Then
            'selecting current date of calendar brings up tasks
            Main.cal2.Hide()
            For Each cont In Main.MainWatch.Controls
                cont.Hide()
            Next
            Main.task.Show()
        End If
    End Sub
End Class
