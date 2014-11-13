Public Class SendImg

    Private Sub SendImg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "To: " + ContactScreen.contactScreen2.ContactName.Text
    End Sub
End Class
