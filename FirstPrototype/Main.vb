Public Class Main
    Public Shared horizontalCount As Integer
    Public Shared verticalCount As Integer
    'Create controls
    Public contactScreen1 As ContactScreen = New ContactScreen
    Public contactScreen2 As ContactScreen2 = New ContactScreen2
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
        MainWatch.Controls.Add(contactScreen2)
        For Each cont In MainWatch.Controls
            cont.Hide()
        Next cont
    End Sub
    Private Sub SwipeRightButton_Click(sender As Object, e As EventArgs) Handles SwipeRightButton.Click
        For Each cont In MainWatch.Controls
            cont.Hide()
        Next cont
        horizontalCount = horizontalCount + 1
        If (horizontalCount = 1) Then
            contactScreen1.Show()
        End If
    End Sub

    Private Sub PowerButton_Click(sender As Object, e As EventArgs) Handles PowerButton.Click
        Me.Close()
    End Sub

    Private Sub SwipeLeftButton_Click(sender As Object, e As EventArgs) Handles SwipeLeftButton.Click
        For Each cont In MainWatch.Controls
            cont.Hide()
        Next cont
        If Not horizontalCount = 0 Then
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
    End Sub

    Private Sub SwipeDownButton_Click(sender As Object, e As EventArgs) Handles SwipeDownButton.Click
        If (horizontalCount = 1) Then
            'For Each cont In MainWatch.Controls
            '    cont.Hide()
            'Next cont
            contactScreen1.scrollDown()
        End If
    End Sub
End Class
