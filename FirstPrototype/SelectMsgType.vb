Public Class SelectMsgType
    Public Shared send_msg As SendMsg = New SendMsg
    Public Shared send_img As SendImg = New SendImg
    Public Shared send_vid As SendVid = New SendVid
    Private Sub MsgPicBox_Click(sender As Object, e As EventArgs) Handles MsgPicBox.Click
        'send_msg.MsgSentNotification.Hide()
        Main.msg_sent_popup.Hide()
        Main.MainWatch.Controls.Add(send_msg)
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next cont
        send_msg.Show()
        send_msg.checkIfEmpty()
    End Sub

    Private Sub ImgPicBox_Click(sender As Object, e As EventArgs) Handles ImgPicBox.Click
        Main.MainWatch.Controls.Add(send_img)
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next cont
        send_img.Show()
    End Sub

    Private Sub VidPicBox_Click(sender As Object, e As EventArgs) Handles VidPicBox.Click
        Main.MainWatch.Controls.Add(send_vid)
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next cont
        send_vid.Show()
    End Sub
End Class
