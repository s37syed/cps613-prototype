Public Class Main
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
        'Add controls
        MainWatch.Controls.Add(contactScreen1)
    End Sub
    Private Sub SwipeRightButton_Click(sender As Object, e As EventArgs) Handles SwipeRightButton.Click
    End Sub

    Private Sub PowerButton_Click(sender As Object, e As EventArgs) Handles PowerButton.Click
        Me.Close()
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
    End Sub

    Private Sub SwipeUpButton_Click(sender As Object, e As EventArgs) Handles SwipeUpButton.Click
        If (horizontalCount = 1) Then
            contactScreen1.scrollUp()
        End If
    End Sub

    Private Sub SwipeDownButton_Click(sender As Object, e As EventArgs) Handles SwipeDownButton.Click
        If (horizontalCount = 1) Then
            contactScreen1.scrollDown()
        End If
        If (horizontalCount = 4) Then
            For Each cont In MainWatch.Controls
                If cont.ToString = "FirstPrototype.ReceiveMsg" Then
                    cont.ShowOptions()
                End If
            Next
        End If
    End Sub
End Class
