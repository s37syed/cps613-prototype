Public Class Main
    Public cal As New Calendar
    Public cal2 As New Calendar2
    Private Strt As System.Threading.Thread

    Private Sub MainFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        BaseLoad()
        'thread for delayed msg prompt
        Strt = New System.Threading.Thread(AddressOf WorkerThread)
        Strt.Start()


    End Sub
    Private Sub BaseLoad()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Start the form in the center
        Dim X As Integer = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Dim Y As Integer = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New System.Drawing.Point(X, Y)
        'add calendar with first half of days
        MainWatch.Controls.Add(cal)
    End Sub


    Private Sub SwipeRightButton_Click(sender As Object, e As EventArgs) Handles SwipeRightButton.Click
        'no functionality as of yet
    End Sub

    Private Sub PowerButton_Click(sender As Object, e As EventArgs) Handles PowerButton.Click
        Me.Close()
    End Sub

    Private Sub SwipeDownButton_Click(sender As Object, e As EventArgs) Handles SwipeDownButton.Click
        'show other days on swipe down
        MainWatch.Controls.Remove(cal)
        MainWatch.Controls.Add(cal2)
    End Sub

    Private Sub SwipeUpButton_Click(sender As Object, e As EventArgs) Handles SwipeUpButton.Click
        'show other days on swipe up
        MainWatch.Controls.Remove(cal2)
        MainWatch.Controls.Add(cal)
    End Sub

    Private Sub WorkerThread()
        'worker thread to handle display of new msg event
        Threading.Thread.Sleep(2000) '2 seconds currently
        AccessControl()
        Threading.Thread.Sleep(2000) '2 seconds currently
        AccessControl2()
    End Sub

    Private Sub AccessControl()
        'display new msg prompt
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl))
        Else
            'NewMsgEventPic.Visible = True
        End If
    End Sub
    Private Sub AccessControl2()
        'remove new msg prompt
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl2))
        Else
            'NewMsgEventPic.Visible = False
        End If
    End Sub


    Private Sub NewMsgEventPic_Click(sender As Object, e As EventArgs) Handles NewMsgEventPic.Click
        'load message
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MainWatch.Controls.Remove(Calendar2.task)
        BaseLoad()
    End Sub
End Class
