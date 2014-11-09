Public Class Main
    Public cal As New Calendar
    Public cal2 As New Calendar2
    Private Sub MainFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hide the title bar
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Start the form in the center
        Dim X As Integer = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Dim Y As Integer = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New System.Drawing.Point(X, Y)
        'add calendar with first half of days
        Panel1.Controls.Add(cal)
    End Sub


    Private Sub SwipeRightButton_Click(sender As Object, e As EventArgs) Handles SwipeRightButton.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub SwipeDownButton_Click(sender As Object, e As EventArgs) Handles SwipeDownButton.Click
        Panel1.Controls.Remove(cal)
        Panel1.Controls.Add(cal2)
    End Sub

    Private Sub SwipeUpButton_Click(sender As Object, e As EventArgs) Handles SwipeUpButton.Click
        Panel1.Controls.Remove(cal2)
        Panel1.Controls.Add(cal)
    End Sub
End Class
