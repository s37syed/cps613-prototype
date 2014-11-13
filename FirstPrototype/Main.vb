Public Class Main
    Public Shared MainScreenTracker = 0
    Friend MenuScreen0 As ClockScreen = New ClockScreen
    Friend MenuScreen1 As MenuScreen1 = New MenuScreen1
    Friend MenuScreen2 As MenuScreen2 = New MenuScreen2
    Friend PhoneContactsScreen As PhoneContacts = New PhoneContacts
    Friend CallContactScreen As CallContact = New CallContact
    Friend CallingScreen As Calling = New Calling
    ' Assuming we're already in the first screen
    Public Shared horizontalCount = 0
    'Create controls
    Public contactScreen1 As ContactScreen = New ContactScreen
    Private Sub MainFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hide the title bar
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
        PhoneContactsScreen.Enabled = False
        CallContactScreen.Enabled = False
        ParentPhone.Visible = True

        'Add controls
        MainWatch.Controls.Add(contactScreen1)
    End Sub
    Private Sub SwipeLeftButton_Click(sender As Object, e As EventArgs) Handles SwipeLeftButton.Click
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

        ElseIf horizontalCount = 1 Or horizontalCount = 2 Then
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
    End Sub
    Private Sub SwipeRightButton_Click(sender As Object, e As EventArgs) Handles SwipeRightButton.Click
        If MainScreenTracker = 0 And Not horizontalCount = 1 And Not horizontalCount = 2 And Not horizontalCount = 4 Then
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
    Private Sub PowerButton_Click(sender As Object, e As EventArgs) Handles PowerButton.Click
        Me.Close()
    End Sub

    Private Sub DoorButton_Click(sender As Object, e As EventArgs) Handles DoorButton.Click
        MenuScreen1.Visible = False
        MenuScreen2.Visible = False
        MenuScreen0.Visible = True
        MainScreenTracker = 0
    End Sub
    Private Sub SwipeDownButton_Click(sender As Object, e As EventArgs) Handles SwipeDown.Click
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
    End Sub
    Private Sub SwipeUpButton_Click(sender As Object, e As EventArgs) Handles SwipeUpButton.Click
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
    End Sub
    Friend Sub ResetTracker()
        MainScreenTracker = 0
    End Sub
    Friend Sub incrementTracker()
        MainScreenTracker += 1
    End Sub

    Friend Sub decrementTracker()
        MainScreenTracker -= 1
    End Sub
End Class
