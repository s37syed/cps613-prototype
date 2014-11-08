Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = DateTime.Now.ToShortTimeString()
    End Sub
End Class
