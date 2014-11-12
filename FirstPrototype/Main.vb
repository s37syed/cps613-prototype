Public Class Main
    ' Assuming we're already in the first screen
    Public Shared horizontalCount = 1
    Public Shared freeze As Boolean = True
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
        'Add controls
        MainWatch.Controls.Add(contactScreen1)
    End Sub
    Private Sub SwipeRightButton_Click(sender As Object, e As EventArgs) Handles SwipeRightButton.Click
        Debug.WriteLine(horizontalCount)
        'Increment every time you swipe to the right, as long as freeze isn't flagged
        If (freeze = False) Then
            horizontalCount = horizontalCount + 1
        End If
        ' If you slide to the right once, show the contact screen. Stop moving once ur at the right.
        If (horizontalCount = 1) Then
            Debug.WriteLine("Currently at Contacts screen")
            freeze = True
            contactScreen1.Show()
        End If
        ' If you are at the Contact3 screen, then you cannot go right anymore
        If (horizontalCount = 2) Then
            Debug.WriteLine("Currently at Contacts Add screen")
            freeze = True
        End If
    End Sub

    Private Sub PowerButton_Click(sender As Object, e As EventArgs) Handles PowerButton.Click
        Me.Close()
    End Sub

    Private Sub SwipeLeftButton_Click(sender As Object, e As EventArgs) Handles SwipeLeftButton.Click
        Debug.WriteLine(horizontalCount)
        'Decrement every time you swipe to the left, as long as it isn't the Contacts screen
        If Not horizontalCount = 1 Then
            horizontalCount = horizontalCount - 1
        End If
        If (horizontalCount = 1) Then
            contactScreen1.Show()
        End If
    End Sub

    Private Sub SwipeUpButton_Click(sender As Object, e As EventArgs) Handles SwipeUpButton.Click
        If (horizontalCount = 1) Then
            contactScreen1.scrollUp()
        End If
        If (horizontalCount = 3) Then
           
        End If
    End Sub

    Private Sub SwipeDownButton_Click(sender As Object, e As EventArgs) Handles SwipeDownButton.Click
        Debug.WriteLine(horizontalCount)
        If (horizontalCount = 1) Then
            contactScreen1.scrollDown()
        End If
        If (horizontalCount = 3) Then
            For Each cont In MainWatch.Controls
                Debug.WriteLine(cont)
                'If cont.ToString = "FirstPrototype.ReceiveMsg" Then
                '    cont.scrollUp()
                'End If
            Next
        End If
    End Sub
End Class
