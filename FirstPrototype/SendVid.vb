Public Class SendVid

    Private Sub SendVid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "To: " + ContactScreen.contactScreen2.ContactName.Text
    End Sub
End Class
