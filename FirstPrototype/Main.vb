Public Class Main
    Private MainScreenTracker As Integer
    Dim MenuScreen0 As ClockScreen = New ClockScreen
    Dim menuScreen1 As MenuScreen1 = New MenuScreen1
    Dim menuScreen2 As MenuScreen2 = New MenuScreen2
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


    End Sub

   
    
    Private Sub SwipeRightButton_Click(sender As Object, e As EventArgs) Handles SwipeRightButton.Click
        If MainScreenTracker = 0 Then
            MenuScreen0.Visible = False
            menuScreen1.Visible = True
            MainScreenTracker = 1
        ElseIf MainScreenTracker = 1 Then
            menuScreen1.Visible = False
            MenuScreen2.Visible = True
            MainScreenTracker = 2
        ElseIf MainScreenTracker = 2 Then

        End If


    End Sub

    Private Sub SwipeLeftButton_Click(sender As Object, e As EventArgs) Handles SwipeLeftButton.Click
        If MainScreenTracker = 0 Then

        ElseIf MainScreenTracker = 1 Then
            MenuScreen0.Visible = True
            MenuScreen1.Visible = False
            MainScreenTracker = 0
        ElseIf MainScreenTracker = 2 Then
            MenuScreen1.Visible = True
            MenuScreen2.Visible = False
            MainScreenTracker = 1
        End If
    End Sub

    Private Sub DoorButton_Click(sender As Object, e As EventArgs) Handles DoorButton.Click
        MenuScreen1.Visible = False
        MenuScreen2.Visible = False
        MenuScreen0.Visible = True
        MainScreenTracker = 0
    End Sub

End Class
