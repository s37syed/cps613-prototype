Public Class MsgSendContacts
    Dim contacts() As String
    Dim buttons() As Button

    Friend selectedContact As String
    Dim firstPosition As Integer
    Dim lastPosition As Integer
    Dim currenPosition As Integer
    Public Shared hide_thread As System.Threading.Thread
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        contacts = {"Mom", "Dad", "Danielle", "Shahzina", "Andrea", "Johnny", "Lorde"}
        buttons = {PhoneContact0, PhoneContact1, PhoneContact2, PhoneContact3}

        firstPosition = 0
        lastPosition = 0
        currenPosition = 0
        selectedContact = ""
        For counter As Integer = 0 To 3
            buttons(counter).Text = contacts(counter)
            lastPosition += 1
        Next
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub scrollDown()
        If lastPosition + 1 <= 7 Then
            firstPosition += 1
            lastPosition += 1
            currenPosition = firstPosition
            For counter As Integer = 0 To 3
                buttons(counter).Text = contacts(currenPosition)
                currenPosition += 1
            Next
        End If

    End Sub

    Sub scrollUp()
        If firstPosition - 1 >= 0 Then
            firstPosition -= 1
            lastPosition -= 1
            currenPosition = firstPosition
            For counter As Integer = 0 To 3
                buttons(counter).Text = contacts(currenPosition)
                currenPosition += 1
            Next
        End If
    End Sub
    Private Sub Contact_Click(sender As Object, e As EventArgs) Handles PhoneContact0.Click, PhoneContact1.Click, PhoneContact2.Click, PhoneContact3.Click
        Dim button As Button
        button = sender
        Main.CallContactScreen.CallContactName.Text = button.Text
        Dim value = button.Text

        If SelectMsgType2.MsgType = 1 Then
            For Each cont In Main.MainWatch.Controls
                cont.Hide()
            Next cont
            Main.send_message.NameLabel.Text = "To: " & button.Text
            Main.send_message.NameLabel.Left = 57 - Main.send_message.NameLabel.Width / 2
            Main.send_message.Visible = True
        ElseIf SelectMsgType2.MsgType = 2 Then
            For Each cont In Main.MainWatch.Controls
                cont.Hide()
            Next cont
            Main.send_image.Label1.Text = "To: " & button.Text
            Main.send_image.Visible = True
            Main.send_image.Label1.Left = 57 - Main.send_image.Label1.Width / 2
            hide_thread = New System.Threading.Thread(AddressOf WorkerThread)
            hide_thread.Start()
        ElseIf SelectMsgType2.MsgType = 3 Then
            For Each cont In Main.MainWatch.Controls
                cont.Hide()
            Next cont
            Main.send_video.Label1.Text = "To: " & button.Text
            Main.send_video.Visible = True
            Main.send_video.Label1.Left = 57 - Main.send_video.Label1.Width / 2
            hide_thread = New System.Threading.Thread(AddressOf WorkerThread2)
            hide_thread.Start()
        End If
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
            Main.send_image.Visible = False
            Main.horizontalCount = 0
            Main.MenuScreen0.Visible = True
        End If
    End Sub
    Private Sub AccessControl2()
        'display new msg prompt
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl2))
        Else
            Main.send_video.Visible = False
            Main.horizontalCount = 0
            Main.MenuScreen0.Visible = True
        End If
    End Sub

    Public Function getSelected() As String
        Return selectedContact
    End Function
End Class
