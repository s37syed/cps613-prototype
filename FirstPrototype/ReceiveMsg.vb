Public Class ReceiveMsg
    Public Shared msgOptions As MessageOptions = New MessageOptions

    Private Sub ReceiveMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.MainWatch.Controls.Add(msgOptions)
    End Sub
    Sub showOptions()
        msgOptions.Location = New Point(0, 75)
        msgOptions.BringToFront()
        msgOptions.Show()
    End Sub
    Sub hideOptions()
        msgOptions.SendToBack()
        msgOptions.Hide()
    End Sub
End Class
