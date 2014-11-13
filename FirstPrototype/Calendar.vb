Public Class Calendar
    'user control for days of the first half of the month 
    Private Sub Calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display current date
        CurrentDateLabel.Text = Format(Date.Now(), "MMM" + "." + " dd")
    End Sub

End Class
