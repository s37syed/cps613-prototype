Imports System.Media
Public Class Main

    '########################################## ADD this into the MAIN Form ##########################################
    '@author Daniel Kozij 
    Dim volumeStatus As VolumeStatus = New VolumeStatus()

    Dim TimerValue As Integer = 0

    Private SongPlayer1 As SoundPlayer = New SoundPlayer(My.Resources.YUNGLEANHURT)
    Private SongPlayer2 As SoundPlayer = New SoundPlayer(My.Resources.South_Park___LORDE_Song____quot_Push_quot___Feeling_Good_on_a_Wednesday___Extended___Fixed_Audio_)
    Private SongPlayer3 As SoundPlayer = New SoundPlayer(My.Resources.Death_Metal_Rooster)
    Private SongPlayer4 As SoundPlayer = New SoundPlayer(My.Resources.Drake___Started_From_The_Bottom__Explicit_)


    Dim song1 As Music = New Music("YUNG LEAN", SongPlayer1)
    Dim song2 As Music = New Music("SouthPark LORDE", SongPlayer2)
    Dim song3 As Music = New Music("Death Metal Rooster", SongPlayer3)
    Dim song4 As Music = New Music("Drake Started from the bottom", SongPlayer4)

    Dim songs As Music() = {song1, song2, song3, song4}

    Dim songPanel1 As SongPanel
    Dim songPanel2 As SongPanel
    Dim songPanel3 As SongPanel
    Dim songPanel4 As SongPanel

    Friend MusicAppCounter As Integer = 0

    Friend musicControls As MusicPanelControl

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
        Debug.Write("test" & vbCrLf)
    End Sub

    Private Sub SwipeRightButton_Click(sender As Object, e As EventArgs) Handles SwipeRightButton.Click


        songPanel1 = New SongPanel(songs, 0)
        songPanel2 = New SongPanel(songs, 1)
        songPanel3 = New SongPanel(songs, 2)
        songPanel4 = New SongPanel(songs, 3)

        songPanel1.Location = New Point(0, 0)
        songPanel2.Location = New Point(0, 28)
        songPanel3.Location = New Point(0, 56)
        songPanel4.Location = New Point(0, 84)


        Me.Panel1.Controls.Add(songPanel1)
        Me.Panel1.Controls.Add(songPanel2)
        Me.Panel1.Controls.Add(songPanel3)
        Me.Panel1.Controls.Add(songPanel4)

        songPanel1.BringToFront()
        songPanel2.BringToFront()
        songPanel3.BringToFront()
        songPanel4.BringToFront()
        MusicAppCounter += 1
    End Sub

    Private Sub SwipeLeftButton_Click(sender As Object, e As EventArgs) Handles SwipeLeftButton.Click

        If MouseButtons >= 0 Then
            MusicAppCounter -= 1
            MsgBox(MusicAppCounter)

            If MusicAppCounter = 0 Then
                musicControls.Hide()
                songPanel1.Hide()
                songPanel2.Hide()
                songPanel3.Hide()
                songPanel4.Hide()

            ElseIf MusicAppCounter = 1 Then

                songPanel1.Show()
                songPanel2.Show()
                songPanel3.Show()
                songPanel4.Show()
                songPanel1.BringToFront()
                songPanel2.BringToFront()
                songPanel3.BringToFront()
                songPanel4.BringToFront()

            ElseIf MusicAppCounter = 2 Then


            End If
        End If


    End Sub


    '########################################## ADD this into the MAIN Form ##########################################
    ' Note: make sure the Volume buttons are called VolumeDownButton and VolumeUpButton
    '@author Daniel Kozij 
    Private Sub VolumeDownButton_Click(sender As Object, e As EventArgs) Handles VolumeDownButton.Click
        volumeStatus.SubtractVolumeLevel()
        Panel1.Controls.Add(volumeStatus)
        volumeStatus.BringToFront()
        Me.Timer1.Start()

    End Sub

    '@author Daniel Kozij 
    Private Sub VolumeUpButton_Click(sender As Object, e As EventArgs) Handles VolumeUpButton.Click
        volumeStatus.AddVolumeLevel()
        Panel1.Controls.Add(volumeStatus)
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
            Panel1.Controls.Remove(volumeStatus)
            Timer1.Stop()
            TimerValue = 0
        End If
    End Sub
    '########################################## ^^^^^^^^^^^^^^^^^^^^^^^^^^^ ##########################################

    Private Sub PowerButton_Click(sender As Object, e As EventArgs) Handles PowerButton.Click
        Me.Close()
    End Sub

End Class
