Public Class SendMsg

    Private Sub SendMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateLabel.Text = Format(Date.Now(), "dd" + "/" + " MM" + "/" + "yy")
        NameLabel.Text = "To: " & Main.contactScreen1.sendName
    End Sub

    Private Sub Contact1_Click(sender As Object, e As EventArgs) Handles Contact1.Click, Contact2.Click, Contact3.Click
        MsgSentNotification.Visible = True
    End Sub

    Friend Sub checkIfEmpty()
        If Main.contactScreen1.sendName = vbNullString Then
            NameLabel.Text = "To: Andrea"
        End If
    End Sub
End Class
