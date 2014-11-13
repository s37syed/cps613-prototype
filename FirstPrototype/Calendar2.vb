Public Class Calendar2
    Private Sub Calendar2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display current date
        CurrentDateLabel.Text = Format(Date.Now(), "MMM" + "." + " dd")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles CurrentDay.Click
        'selecting current date of calendar brings up tasks
        Main.horizontalCount = 6
        Main.cal2.Hide()
        Main.task.Show()
    End Sub
End Class
