Public Class SelectMsgType
    Public Shared send_msg As SendMsg = New SendMsg
    Public Shared send_img As SendImg = New SendImg
    Public Shared send_vid As SendVid = New SendVid
    Public Shared hide_thread As System.Threading.Thread
    Private Sub MsgPicBox_Click(sender As Object, e As EventArgs) Handles MsgPicBox.Click
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
        hide_thread = New System.Threading.Thread(AddressOf WorkerThread)
        hide_thread.Start()
    End Sub

    Private Sub VidPicBox_Click(sender As Object, e As EventArgs) Handles VidPicBox.Click
        Main.MainWatch.Controls.Add(send_vid)
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next cont
        send_vid.Show()
        hide_thread = New System.Threading.Thread(AddressOf WorkerThread2)
        hide_thread.Start()
    End Sub
    Friend Sub WorkerThread()
        'worker thread to handle display of new msg event
        Threading.Thread.Sleep(2000) '2 seconds currently
        AccessControl()
    End Sub
    Friend Sub WorkerThread2()
        'worker thread to handle display of new msg event
        Threading.Thread.Sleep(1000) '2 seconds currently
        AccessControl2()
    End Sub
    Private Sub AccessControl()
        'display new msg prompt
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl))
        Else
            send_img.Visible = False
            Main.horizontalCount = 0
            Main.MenuScreen0.Visible = True
        End If
    End Sub
    Private Sub AccessControl2()
        'display new msg prompt
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl2))
        Else
            send_vid.Visible = False
            Main.horizontalCount = 0
            Main.MenuScreen0.Visible = True
        End If
    End Sub
End Class
