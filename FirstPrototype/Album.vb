Public Class Album

    Dim AlbumName As String = "..."

    Dim AlbumImage As String = ""

    Dim ArtistAlbumMusic As Music() = {}

    Sub New(AlbumName As String)
        Me.AlbumName = AlbumName

    End Sub

    Sub New(AlbumName As String, artistMusic As Music())
        Me.AlbumName = AlbumName
        Me.ArtistAlbumMusic = artistMusic
    End Sub

    Public Function GetAlbumName() As String
        Return AlbumName

    End Function

    Public Function GetAlbumImagen() As String
        Return AlbumImage

    End Function

    Public Function GetArtistAlbumMusic() As Music()
        Return ArtistAlbumMusic

    End Function



End Class
