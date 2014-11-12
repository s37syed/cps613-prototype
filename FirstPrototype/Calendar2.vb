Public Class Calendar2

    Public Shared task As New Tasks
    Private Sub Calendar2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display current date
        CurrentDateLabel.Text = Format(Date.Now(), "MMM" + "." + " dd")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Main.Panel1.Controls.Remove(Main.cal2)
        Main.Panel1.Controls.Add(task)
    End Sub
End Class
