Public Class Main
    Private MainScreenTracker As Integer
    Friend MenuScreen0 As ClockScreen = New ClockScreen
    Friend menuScreen1 As MenuScreen1 = New MenuScreen1
    Friend menuScreen2 As MenuScreen2 = New MenuScreen2
    Friend PhoneContactsScreen As PhoneContacts = New PhoneContacts
    Friend CallContactScreen As CallContact = New CallContact
    Friend CallingScreen As Calling = New Calling
    ' Assuming we're already in the first screen
    Public Shared horizontalCount = 1
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
        MainScreenTracker = 0
        MainWatch.Controls.Add(MenuScreen0)
        MainWatch.Controls.Add(menuScreen1)
        MainWatch.Controls.Add(menuScreen2)
        MainWatch.Controls.Add(PhoneContactsScreen)
        MainWatch.Controls.Add(CallContactScreen)
        MainWatch.Controls.Add(CallingScreen)
        PhoneContactsScreen.Enabled = False
        CallContactScreen.Enabled = False

        ParentPhone.Visible = True

        'Add controls
        MainWatch.Controls.Add(contactScreen1)
    End Sub
    Private Sub SwipeRightButton_Click(sender As Object, e As EventArgs) Handles SwipeRightButton.Click
    End Sub



    Private Sub SwipeRightButton_Click(sender As Object, e As EventArgs) Handles SwipeRightButton.Click
        If MainScreenTracker = 0 Then
            MenuScreen0.Visible = False
            menuScreen1.Visible = True
            menuScreen2.Visible = False
            MainScreenTracker = 1
        ElseIf MainScreenTracker = 1 Then
            menuScreen1.Visible = False
            menuScreen2.Visible = True
            MenuScreen0.Visible = False
            MainScreenTracker = 2
        ElseIf MainScreenTracker = 2 Then

        End If


    End Sub

    Private Sub SwipeLeftButton_Click(sender As Object, e As EventArgs) Handles SwipeLeftButton.Click
        If MainScreenTracker = 0 Then

        ElseIf MainScreenTracker = 1 Then
            MenuScreen0.Visible = True
            menuScreen1.Visible = False
            menuScreen2.Visible = False
            MainScreenTracker = 0
        ElseIf MainScreenTracker = 2 Then
            MenuScreen0.Visible = False
            menuScreen1.Visible = True
            menuScreen2.Visible = False
            MainScreenTracker = 1
        End If
    Private Sub PowerButton_Click(sender As Object, e As EventArgs) Handles PowerButton.Click
        Me.Close()
    End Sub

    Private Sub DoorButton_Click(sender As Object, e As EventArgs) Handles DoorButton.Click
        MenuScreen1.Visible = False
        MenuScreen2.Visible = False
        MenuScreen0.Visible = True
        MainScreenTracker = 0
    End Sub
    Private Sub SwipeLeftButton_Click(sender As Object, e As EventArgs) Handles SwipeLeftButton.Click
        'Decrement every time you swipe to the left, as long as it isn't the Contacts screen
        If Not horizontalCount = 1 Then
            horizontalCount = horizontalCount - 1
        End If
        If (horizontalCount = 1) Then

        End If
        If (horizontalCount = 2) Then
            horizontalCount = 1
            contactScreen1.Show()
        End If
        ' if you're at the options screen
        If (horizontalCount = 3) Then
            For Each cont In MainWatch.Controls
                cont.Hide()
                If cont.ToString = "FirstPrototype.ReceiveMsg" Then
                    cont.hideOptions()
                End If
            Next
            horizontalCount = 1
            contactScreen1.Show()
        End If
    Private Sub SwipeDownButton_Click(sender As Object, e As EventArgs) Handles SwipeDown.Click
        If PhoneContactsScreen.Enabled = True Then
            PhoneContactsScreen.scrollDown()
        End If
        End If
    End Sub
    Private Sub SwipeUpButton_Click(sender As Object, e As EventArgs) Handles SwipeUpButton.Click
        If PhoneContactsScreen.Enabled = True Then
            PhoneContactsScreen.scrollUp()
        End If
    End Sub
    Friend Sub ResetTracker()
        MainScreenTracker = 0
    End Sub
    Friend Sub incrementTracker()
        MainScreenTracker += 1
    End Sub
    Private Sub SwipeUpButton_Click(sender As Object, e As EventArgs) Handles SwipeUpButton.Click
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
    Private Sub SwipeRightButton_Click(sender As Object, e As EventArgs) Handles SwipeRightButton.Click
    Friend Sub decrementTracker()
        MainScreenTracker -= 1
    Private Sub SwipeDownButton_Click(sender As Object, e As EventArgs) Handles SwipeDownButton.Click
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
End Class
