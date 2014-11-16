Public Class SendMsg
    Friend msg_sent_popup_thread As System.Threading.Thread
    Private Sub SendMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateLabel.Text = Format(Date.Now(), "dd" + "/" + " MM" + "/" + "yy")
        NameLabel.Text = "To: " & Main.contactScreen1.sendName
        NameLabel.Left = 57 - NameLabel.Width \ 2
        DateLabel.Left = 57 - DateLabel.Width \ 2
    End Sub

    Private Sub Contact1_Click(sender As Object, e As EventArgs) Handles Contact1.Click, Contact2.Click, Contact3.Click
        Main.msg_sent_popup.Visible = True
        msg_sent_popup_thread = New System.Threading.Thread(AddressOf WorkerThread)
        msg_sent_popup_thread.Start()
    End Sub
    Friend Sub WorkerThread()
        'worker thread to handle display of new msg event
        Threading.Thread.Sleep(1000) '2 seconds currently
        AccessControl()
    End Sub
    Private Sub AccessControl()
        'display new msg prompt
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl))
        Else
            Main.msg_sent_popup.Visible = False
            Main.horizontalCount = 0
            Main.MenuScreen0.Visible = True
        End If
    End Sub
    Friend Sub checkIfEmpty()
        If Main.contactScreen1.sendName = vbNullString Then
            NameLabel.Text = "To: Andrea"
            NameLabel.Left = 57 - NameLabel.Width \ 2
        End If
    End Sub
End Class
