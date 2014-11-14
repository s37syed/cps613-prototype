Public Class Tasks2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Main.appOptions.Location = New Point(0, 75)
        Main.appOptions.BringToFront()
        Main.appOptions.Show()
    End Sub
End Class
