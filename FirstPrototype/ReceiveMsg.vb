Public Class ReceiveMsg
    Public Shared msgOptions As MessageOptions = New MessageOptions
    Public Shared getName As String
    Private Sub ReceiveMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.MainWatch.Controls.Add(msgOptions)
    End Sub
    Sub setName(tempStr As String)
        ContactName.Text = tempStr
    End Sub
    Sub deleteMsg(tempStr As String)
        Me.TransparentRichTextBox1.Text = tempStr
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
