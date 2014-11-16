Public Class SendMsg
    Friend msg_sent_popup_thread As System.Threading.Thread
    Private Sub SendMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateLabel.Text = Format(Date.Now(), "dd" + "/" + " MM" + "/" + "yy")
        NameLabel.Text = "To: " & Main.contactScreen1.sendName
    End Sub

    Private Sub Contact1_Click(sender As Object, e As EventArgs) Handles Contact1.Click, Contact2.Click, Contact3.Click
        Main.msg_sent_popup.Visible = True
        msg_sent_popup_thread = New System.Threading.Thread(AddressOf WorkerThread)
        msg_sent_popup_thread.Start()
    End Sub
    Friend Sub WorkerThread()
        'worker thread to handle display of new msg event
        Threading.Thread.Sleep(2000) '2 seconds currently
        AccessControl()
    End Sub
    Private Sub AccessControl()
        'display new msg prompt
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl))
        Else
            Main.msg_sent_popup.Visible = False
        End If
    End Sub
    Friend Sub checkIfEmpty()
        If Main.contactScreen1.sendName = vbNullString Then
            NameLabel.Text = "To: Andrea"
        End If
    End Sub

End Class
