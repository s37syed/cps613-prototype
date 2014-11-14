Public Class Tasks
    Private Sub Tasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.task.DateLabel.Text = Format(Date.Now(), "dd" & "/" & "MM" & "/" & "yy")
    End Sub
End Class
