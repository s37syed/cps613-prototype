Public Class Calendar2
    'user control for days of the first half of the month 
    Public Shared task As New Tasks
    Private Sub Calendar2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display current date
        CurrentDateLabel.Text = Format(Date.Now(), "MMM" + "." + " dd")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        'selecting current date of calendar brings up tasks
        Main.Panel1.Controls.Remove(Main.cal2)
        Main.Panel1.Controls.Add(task)
    End Sub
End Class
