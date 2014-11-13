Public Class SongPanel

    Dim musicSong As Music()

    Dim whichSong As Integer

    Sub New(ByVal music As Music(), ByVal whichSong As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        Me.SongLabel.Text = music(whichSong).getSongName
        ' Add any initialization after the InitializeComponent() call.
        musicSong = music
        Me.whichSong = whichSong
        Main.musicControls = New MusicPanelControl(music, whichSong)

    End Sub



    Private Sub SongPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Click, PictureBox1.Click, SongLabel.Click
        Main.musicControls = New MusicPanelControl(musicSong, whichSong)
        Main.MainWatch.Controls.Add(Main.musicControls)
        Main.musicControls.BringToFront()
        Main.MusicAppCounter += 1
    End Sub
End Class
