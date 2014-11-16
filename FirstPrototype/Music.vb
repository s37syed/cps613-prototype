Imports System.Media
Public Class Music


    Dim songName As String

    Dim songPlayer As SoundPlayer

    Sub New(ByVal songName As String)
        Me.songName = songName

    End Sub


    Sub New(ByVal songName As String, ByVal song As SoundPlayer)
        Me.songName = songName
        songPlayer = song
    End Sub

    Public Function getSongName() As String
        Return Me.songName
    End Function

    Public Function getSongPlayer() As SoundPlayer
        Return songPlayer
    End Function


End Class
