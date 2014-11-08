Public Class Main
    Public count As Integer
    'Create controls
    Dim contactScreen As ContactScreen = New ContactScreen
    Private Sub MainFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hide the title bar
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Start the form in the center
        Dim X As Integer = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Dim Y As Integer = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New System.Drawing.Point(X, Y)
        'Add controls
        MainWatch.Controls.Add(contactScreen)
        For Each cont In MainWatch.Controls
            cont.Hide()
        Next cont
    End Sub

    Private Sub SwipeRightButton_Click(sender As Object, e As EventArgs) Handles SwipeRightButton.Click
        For Each cont In MainWatch.Controls
            cont.Hide()
        Next cont
        count = count + 1
        If (count = 1) Then
            contactScreen.Show()
        End If
    End Sub

    Private Sub PowerButton_Click(sender As Object, e As EventArgs) Handles PowerButton.Click
        Me.Close()
    End Sub

    Private Sub SwipeLeftButton_Click(sender As Object, e As EventArgs) Handles SwipeLeftButton.Click
        For Each cont In MainWatch.Controls
            cont.Hide()
        Next cont
        If Not count = 0 Then
            count = count - 1
        End If
        If (count = 1) Then
            contactScreen.Show()
        End If
    End Sub
End Class
