Public Class SendImg

    Private Sub SendImg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Label1.Text = "To: " & Main.contactScreen1.sendName
    End Sub
    Friend Sub checkIfEmpty()
        If Main.contactScreen1.sendName = vbNullString Then
            Label1.Text = "To: Andrea"
            Label1.Left = 57 - Label1.Width \ 2
        End If
    End Sub
End Class
