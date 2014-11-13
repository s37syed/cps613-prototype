Public Class Artist


    Dim artistName As String = "..."

    Dim artistImageLocation As String = "FirstPrototype.My.Resources.Resources.artist_icon"

    Dim ArtistAlbums As Album() = {}

    Sub New(ByVal artistName As String, ByVal artistImageLocation As String, ByRef artistAlbums As Album())

        Me.artistName = artistName
        Me.artistImageLocation = artistImageLocation
        Me.ArtistAlbums = artistAlbums
    End Sub

    Public Function GetArtistName() As String
        Return artistName

    End Function

    Public Function GetArtistImageLocation() As String
        Return artistName

    End Function

    Public Function GetArtistAlbums() As Album()
        Return ArtistAlbums

    End Function

End Class
