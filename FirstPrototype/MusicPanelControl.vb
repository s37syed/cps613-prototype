Public Class MusicPanelControl

    Dim whichPlaying As Integer
    Private Strt As System.Threading.Thread
    Dim song As Music()
    Dim max_songs As Integer = 3

    Sub New(ByVal music As Music(), ByVal playing As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        Me.SongName.Text = music(playing).getSongName
        ' Add any initialization after the InitializeComponent() call.
        song = music
        whichPlaying = playing
    End Sub

 
    Private Sub PauseButton_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        Me.song(whichPlaying).getSongPlayer.Stop()
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        MsgBox(whichPlaying)
        Me.song(whichPlaying).getSongPlayer.Play()
    End Sub

    Private Sub ShuffleButton_Click(sender As Object, e As EventArgs) Handles ShuffleButton.Click
        'change image
        Dim rng As New Random
        Me.song(whichPlaying).getSongPlayer.Stop()
        whichPlaying = rng.Next(0, 3)
        Me.song(whichPlaying).getSongPlayer.Play()
        Me.SongName.Text = song(whichPlaying).getSongName
        Strt = New System.Threading.Thread(AddressOf WorkerThread)
        Strt.Start()
        notify.Text = "Shuffling Playlist"
        notify.Left = 57 - notify.Width \ 2
        notify.Visible = True
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If whichPlaying > 0 Then
            Me.song(whichPlaying).getSongPlayer.Stop()
            whichPlaying -= 1
            Me.song(whichPlaying).getSongPlayer.Play()
            Me.SongName.Text = song(whichPlaying).getSongName
            SongName.Left = 57 - SongName.Width \ 2
        Else
            Me.song(whichPlaying).getSongPlayer.Stop()
            whichPlaying = 3
            Me.song(whichPlaying).getSongPlayer.Play()
            Me.SongName.Text = song(whichPlaying).getSongName
            SongName.Left = 57 - SongName.Width \ 2
        End If

    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If whichPlaying < 3 Then
            Me.song(whichPlaying).getSongPlayer.Stop()
            whichPlaying += 1
            Me.song(whichPlaying).getSongPlayer.Play()
            MsgBox(whichPlaying)
            Me.SongName.Text = song(whichPlaying).getSongName
            SongName.Left = 57 - SongName.Width \ 2
        Else
            Me.song(whichPlaying).getSongPlayer.Stop()
            whichPlaying = 0
            Me.song(whichPlaying).getSongPlayer.Play()
            Me.SongName.Text = song(whichPlaying).getSongName
            SongName.Left = 57 - SongName.Width \ 2
        End If
    End Sub

    Private Sub MusicPanelControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub WorkerThread()
        Threading.Thread.Sleep(2000)
        AccessControl()
    End Sub
    Private Sub AccessControl()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl))
        Else
            notify.Visible = False
        End If
    End Sub

    Private Sub RepeatButton_Click(sender As Object, e As EventArgs) Handles RepeatButton.Click
        Strt = New System.Threading.Thread(AddressOf WorkerThread)
        Strt.Start()
        notify.Text = "Repeating Playlist"
        notify.Left = 57 - notify.Width \ 2
        notify.Visible = True
    End Sub
End Class
