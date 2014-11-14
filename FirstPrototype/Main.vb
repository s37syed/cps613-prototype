Imports System.Media
Public Class Main
    Public Shared MainScreenTracker = 0
    Friend MenuScreen0 As ClockScreen = New ClockScreen
    Friend MenuScreen1 As MenuScreen1 = New MenuScreen1
    Friend MenuScreen2 As MenuScreen2 = New MenuScreen2
    Friend PhoneContactsScreen As PhoneContacts = New PhoneContacts
    Friend CallContactScreen As CallContact = New CallContact
    Friend CallingScreen As Calling = New Calling
    Friend SendMsgType2 As SelectMsgType2 = New SelectMsgType2
    Friend MsgSendContacts1 As MsgSendContacts = New MsgSendContacts
    Friend send_image As SendImg = New SendImg
    Friend send_video As SendVid = New SendVid
    Friend send_message As SendMsg = New SendMsg
    Friend day_or_week As DayWeekSelect = New DayWeekSelect
    Public cal As New Calendar
    Public cal2 As New Calendar2
    Public Shared task As New Tasks
    Public Shared tasks2 As New Tasks2
    Public Shared appOptions As New AppointmentOptions
    Public Shared horizontalCount = 0
    Public contactScreen1 As ContactScreen = New ContactScreen
    Friend Strt As System.Threading.Thread
    Friend ErrorMsgTime As System.Threading.Thread
    Friend ReminderTime As System.Threading.Thread
    Friend LeaveMsgTime As System.Threading.Thread
    Friend volumeStatus As VolumeStatus = New VolumeStatus()
    Friend CallConnectedScreen As CallConnected = New CallConnected
    Friend RediallingScreen As Redialling = New Redialling
    Friend CallNotConnectedScreen As CallNotConnected = New CallNotConnected
    Dim TimerValue As Integer = 0

    Private SongPlayer1 As SoundPlayer = New SoundPlayer(My.Resources.yung_lean)
    Private SongPlayer2 As SoundPlayer = New SoundPlayer(My.Resources.push_lorde)
    Private SongPlayer3 As SoundPlayer = New SoundPlayer(My.Resources.death_metal)
    Private SongPlayer4 As SoundPlayer = New SoundPlayer(My.Resources.drake_song)

    Dim song1 As Music = New Music("Yung Lean", SongPlayer1)
    Dim song2 As Music = New Music("Lorde - Push", SongPlayer2)
    Dim song3 As Music = New Music("Death Metal", SongPlayer3)
    Dim song4 As Music = New Music("Drake Song", SongPlayer4)

    Dim songs As Music() = {song1, song2, song3, song4}

    Friend songPanel1 As SongPanel
    Friend songPanel2 As SongPanel
    Friend songPanel3 As SongPanel
    Friend songPanel4 As SongPanel

    Friend MusicAppCounter As Integer = 0

    Friend musicControls As MusicPanelControl

    Private Sub MainFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        BaseLoad()
        'thread for delayed msg prompt
        Strt = New System.Threading.Thread(AddressOf WorkerThread)
        Strt.Start()
    End Sub
    Friend Sub WorkerThread()
        'worker thread to handle display of new msg event
        Threading.Thread.Sleep(5) '2 seconds currently
        AccessControl()
        Threading.Thread.Sleep(5) '2 seconds currently
        AccessControl2()
    End Sub
    Friend Sub WorkerThread2()
        AccessControl3()
        Threading.Thread.Sleep(2000)
        AccessControl4()
    End Sub
    Friend Sub WorkerThread3()
        'worker thread to handle display of new msg event
        Threading.Thread.Sleep(300) '2 seconds currently
        AccessControl5()
        Threading.Thread.Sleep(2000) '2 seconds currently
        AccessControl6()
    End Sub
    Friend Sub WorkerThread4()
        'worker thread to handle display of new msg event
        Threading.Thread.Sleep(300) '2 seconds currently
        AccessControl7()
        Threading.Thread.Sleep(2000) '2 seconds currently
        AccessControl8()
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
            NewMsgEventPic.Visible = False
        End If
    End Sub
    Private Sub AccessControl3()
        'remove new msg prompt
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl3))
        Else
            ErrorMsg.Visible = True
        End If
    End Sub
    Private Sub AccessControl4()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl4))
        Else
            ErrorMsg.Visible = False
        End If
    End Sub
    Private Sub AccessControl5()
        'display new msg prompt
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl5))
        Else
            Reminder.Visible = True
        End If
    End Sub
    Private Sub AccessControl6()
        'remove new msg prompt
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl6))
        Else
            Reminder.Visible = False
        End If
    End Sub
    Private Sub AccessControl7()
        'display new msg prompt
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl7))
        Else
            CallNotConnectedScreen.LeaveMsgText.Visible = True
        End If
    End Sub
    Private Sub AccessControl8()
        'remove new msg prompt
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl8))
        Else
            CallNotConnectedScreen.LeaveMsgText.Visible = False
        End If
    End Sub
    Private Sub BaseLoad()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Start the form in the center
        Dim X As Integer = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Dim Y As Integer = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New System.Drawing.Point(X, Y)
        MainWatch.Controls.Add(MenuScreen0)
        MainWatch.Controls.Add(MenuScreen1)
        MainWatch.Controls.Add(MenuScreen2)
        MainWatch.Controls.Add(PhoneContactsScreen)
        MainWatch.Controls.Add(CallContactScreen)
        MainWatch.Controls.Add(CallingScreen)
        MainWatch.Controls.Add(cal)
        MainWatch.Controls.Add(cal2)
        MainWatch.Controls.Add(task)
        MainWatch.Controls.Add(tasks2)
        MainWatch.Controls.Add(appOptions)
        MainWatch.Controls.Add(day_or_week)
        songPanel1 = New SongPanel(songs, 0)
        songPanel2 = New SongPanel(songs, 1)
        songPanel3 = New SongPanel(songs, 2)
        songPanel4 = New SongPanel(songs, 3)

        songPanel1.Location = New Point(0, 0)
        songPanel2.Location = New Point(0, 28)
        songPanel3.Location = New Point(0, 56)
        songPanel4.Location = New Point(0, 84)


        Me.MainWatch.Controls.Add(songPanel1)
        Me.MainWatch.Controls.Add(songPanel2)
        Me.MainWatch.Controls.Add(songPanel3)
        Me.MainWatch.Controls.Add(songPanel4)

        MainWatch.Controls.Add(songPanel1)
        MainWatch.Controls.Add(songPanel2)
        MainWatch.Controls.Add(songPanel3)
        MainWatch.Controls.Add(songPanel4)

        MainWatch.Controls.Add(SendMsgType2) 'added this 
        MainWatch.Controls.Add(MsgSendContacts1) ' added this
        MainWatch.Controls.Add(send_image) ' added this
        MainWatch.Controls.Add(send_video) ' added this
        MainWatch.Controls.Add(send_message) ' added this
        MainWatch.Controls.Add(CallConnectedScreen)
        MainWatch.Controls.Add(RediallingScreen)
        MainWatch.Controls.Add(CallNotConnectedScreen)
        PhoneContactsScreen.Enabled = False
        CallContactScreen.Enabled = False
        ParentPhone.Visible = True

        'Add controls
        MainWatch.Controls.Add(contactScreen1)
    End Sub
    Private Sub SwipeLeftButton_Click(sender As Object, e As EventArgs) Handles SwipeLeftButton.Click
        Debug.WriteLine("Value of horizontalCount was at: " & horizontalCount)
        'Chris' code
        If MainScreenTracker = 0 Then

        ElseIf MainScreenTracker = 1 Then
            MenuScreen0.Visible = True
            MenuScreen1.Visible = False
            MenuScreen2.Visible = False
            MainScreenTracker = 0
        ElseIf MainScreenTracker = 2 Then
            MenuScreen0.Visible = False
            MenuScreen1.Visible = True
            MenuScreen2.Visible = False
            MainScreenTracker = 1
        End If
        If horizontalCount = 0 Then

        ElseIf horizontalCount = 1 Or horizontalCount = 2 Or horizontalCount = 5 Or horizontalCount = 6 Then
            contactScreen1.Hide()
            MenuScreen0.Visible = True
            MenuScreen1.Visible = False
            MenuScreen2.Visible = False
            MainScreenTracker = 0
            horizontalCount = 0
        End If
        ' if you're at the options screen
        If (horizontalCount = 4) Then
            For Each cont In MainWatch.Controls
                cont.Hide()
                If cont.ToString = "FirstPrototype.ReceiveMsg" Then
                    cont.hideOptions()
                End If
            Next
            contactScreen1.Hide()
            MenuScreen0.Visible = True
            MenuScreen1.Visible = False
            MenuScreen2.Visible = False
            MainScreenTracker = 0
            horizontalCount = 0
        End If
        If (horizontalCount = 5) Then
            For Each cont In MainWatch.Controls
                cont.Hide()
            Next
            'Main.SendMsg.MsgSentNotification.Hide()
            MenuScreen0.Visible = True
            MenuScreen1.Visible = False
            MenuScreen2.Visible = False
            MainScreenTracker = 0
            horizontalCount = 0
        End If
        If (horizontalCount = 6) Then
            For Each cont In MainWatch.Controls
                cont.Hide()
            Next
            MenuScreen0.Visible = True
            MenuScreen1.Visible = False
            MenuScreen2.Visible = False
            MainScreenTracker = 0
            horizontalCount = 0
        End If
        If (horizontalCount = 7) Then
            For Each cont In MainWatch.Controls
                cont.Hide()
            Next
            MenuScreen0.Visible = True
            MenuScreen1.Visible = False
            MenuScreen2.Visible = False
            MainScreenTracker = 0
            horizontalCount = 0
        End If
        If (horizontalCount = 8) Then
            For Each cont In MainWatch.Controls
                cont.Hide()
            Next
            MenuScreen0.Visible = True
            MenuScreen1.Visible = False
            MenuScreen2.Visible = False
            MainScreenTracker = 0
            horizontalCount = 0
        End If
        If (horizontalCount = 9) Then
            For Each cont In MainWatch.Controls
                cont.Hide()
            Next
            MenuScreen0.Visible = True
            MenuScreen1.Visible = False
            MenuScreen2.Visible = False
            MainScreenTracker = 0
            horizontalCount = 0
        End If
        If (horizontalCount = 10) Then
            For Each cont In MainWatch.Controls
                cont.Hide()
            Next
            MenuScreen0.Visible = True
            MenuScreen1.Visible = False
            MenuScreen2.Visible = False
            MainScreenTracker = 0
            horizontalCount = 0
        End If
        'add calendar with first half of days - dont think we need this 
        'MainWatch.Controls.Add(cal)
    End Sub
    Private Sub SwipeRightButton_Click(sender As Object, e As EventArgs) Handles SwipeRightButton.Click
        If MainScreenTracker = 0 And Not horizontalCount = 1 And Not horizontalCount = 2 And Not horizontalCount = 4 And Not horizontalCount = 5 And Not horizontalCount = 6 And Not horizontalCount = 7 And Not horizontalCount = 8 And Not horizontalCount = 9 And Not horizontalCount = 10 Then
            MenuScreen0.Visible = False
            MenuScreen1.Visible = True
            MenuScreen2.Visible = False
            MainScreenTracker = 1
        ElseIf MainScreenTracker = 1 Then
            MenuScreen0.Visible = False
            MenuScreen1.Visible = False
            MenuScreen2.Visible = True
            MainScreenTracker = 2
        ElseIf MainScreenTracker = 2 Then

        End If
    End Sub
    Private Sub PowerButton_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub DoorButton_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub SwipeDown_Click(sender As Object, e As EventArgs) Handles SwipeDown.Click
        'Chris' code
        If PhoneContactsScreen.Enabled = True Then
            PhoneContactsScreen.scrollDown()
        End If
        'Shah's code
        If (horizontalCount = 1) Then
            contactScreen1.scrollDown()
        End If
        If (horizontalCount = 4) Then
            For Each cont In MainWatch.Controls
                If cont.ToString = "FirstPrototype.ReceiveMsg" Then
                    cont.HideOptions()
                End If
            Next
        End If
        If (horizontalCount = 5) Then
            For Each cont In MainWatch.Controls
                cont.Hide()
            Next
            cal.Show()
            Debug.WriteLine("i was called 1")
        End If
        If (horizontalCount = 7) Then
            Me.MsgSendContacts1.scrollDown()
        End If
        If (horizontalCount = 9) Then
            appOptions.Hide()
        End If
    End Sub
    Private Sub SwipeUp_Click(sender As Object, e As EventArgs) Handles SwipeUpButton.Click
        'Chris' code
        If PhoneContactsScreen.Enabled = True Then
            PhoneContactsScreen.scrollUp()
        End If
        'Shah's code
        If (horizontalCount = 1) Then
            contactScreen1.scrollUp()
        End If
        If (horizontalCount = 4) Then
            For Each cont In MainWatch.Controls
                If cont.ToString = "FirstPrototype.ReceiveMsg" Then
                    cont.ShowOptions()
                End If
            Next
        End If
        If (horizontalCount = 5) Then
            cal.Hide()
            cal2.Show()
        End If
        If (horizontalCount = 7) Then
            Me.MsgSendContacts1.scrollUp()
        End If
        If (horizontalCount = 9) Then
            appOptions.Show()
        End If
    End Sub
    Friend Sub ResetTracker()
        MainScreenTracker = 0
    End Sub
    Private Sub NewMsgEventPic_Click(sender As Object, e As EventArgs) Handles NewMsgEventPic.Click
        'load message
    End Sub

    Private Sub Clock1_TimeChanged(sender As Object, e As EventArgs)
        songPanel1 = New SongPanel(songs, 0)
        songPanel2 = New SongPanel(songs, 1)
        songPanel3 = New SongPanel(songs, 2)
        songPanel4 = New SongPanel(songs, 3)

        songPanel1.Location = New Point(0, 0)
        songPanel2.Location = New Point(0, 28)
        songPanel3.Location = New Point(0, 56)
        songPanel4.Location = New Point(0, 84)


        Me.MainWatch.Controls.Add(songPanel1)
        Me.MainWatch.Controls.Add(songPanel2)
        Me.MainWatch.Controls.Add(songPanel3)
        Me.MainWatch.Controls.Add(songPanel4)

        songPanel1.BringToFront()
        songPanel2.BringToFront()
        songPanel3.BringToFront()
        songPanel4.BringToFront()
        MusicAppCounter += 1
    End Sub
    Private Sub VolumeDownButton_Click(sender As Object, e As EventArgs) Handles VolumeDownButton.Click
        volumeStatus.SubtractVolumeLevel()
        MainWatch.Controls.Add(volumeStatus)
        volumeStatus.BringToFront()
        Me.Timer1.Start()

    End Sub

    '@author Daniel Kozij 
    Private Sub VolumeUpButton_Click(sender As Object, e As EventArgs) Handles VolumeUpButton.Click
        volumeStatus.AddVolumeLevel()
        MainWatch.Controls.Add(volumeStatus)
        volumeStatus.BringToFront()
        Me.Timer1.Start()

    End Sub

    'Timer Tick handler
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TimerValue = TimerValue + 1
        TurnOffVolumeStatus()

    End Sub


    Private Sub TurnOffVolumeStatus()

        If (TimerValue.Equals(10)) Then
            MainWatch.Controls.Remove(volumeStatus)
            Timer1.Stop()
            TimerValue = 0
        End If
    End Sub

    Private Sub DoorButton_Click_1(sender As Object, e As EventArgs) Handles DoorButton.Click
        MenuScreen1.Visible = False
        MenuScreen2.Visible = False
        MenuScreen0.Visible = True
        horizontalCount = 0
        MainScreenTracker = 0
    End Sub

    Private Sub PowerButton_Click_1(sender As Object, e As EventArgs) Handles PowerButton.Click
        Me.Close()
    End Sub
End Class
