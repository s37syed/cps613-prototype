Imports System.Threading
Public Class Main

    '########################################## ADD this into the MAIN Form ##########################################
    '@author Daniel Kozij 
    Dim volumeStatus As VolumeStatus = New VolumeStatus()

    Dim TimerValue As Integer = 0

    Dim musicArtist As MusicArtist = New MusicArtist()
    '########################################## ^^^^^^^^^^^^^^^^^^^^^^^^^^^ ##########################################

    Private Sub MainFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hide the title bar
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Start the form in the center
        Dim X As Integer = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Dim Y As Integer = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New System.Drawing.Point(X, Y)

      
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SwipeUpButton.Click

    End Sub

    Private Sub SwipeRightButton_Click(sender As Object, e As EventArgs) Handles SwipeRightButton.Click

        Panel1.Controls.Add(musicArtist)

    End Sub


    '########################################## ADD this into the MAIN Form ##########################################
    ' Note: make sure the Volume buttons are called VolumeDownButton and VolumeUpButton
    '@author Daniel Kozij 
    Private Sub VolumeDownButton_Click(sender As Object, e As EventArgs) Handles VolumeDownButton.Click
        volumeStatus.SubtractVolumeLevel()
        Panel1.Controls.Add(volumeStatus)
     
        Me.Timer1.Start()

    End Sub

    '@author Daniel Kozij 
    Private Sub VolumeUpButton_Click(sender As Object, e As EventArgs) Handles VolumeUpButton.Click
        volumeStatus.AddVolumeLevel()
        Panel1.Controls.Add(volumeStatus)
        Me.Timer1.Start()

    End Sub

    'Timer Tick handler
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TimerValue = TimerValue + 1
        TurnOffVolumeStatus()

    End Sub


    Private Sub TurnOffVolumeStatus()

        If (TimerValue.Equals(10)) Then
            Panel1.Controls.Remove(volumeStatus)
            Timer1.Stop()
            TimerValue = 0
        End If
    End Sub
    '########################################## ^^^^^^^^^^^^^^^^^^^^^^^^^^^ ##########################################


End Class
