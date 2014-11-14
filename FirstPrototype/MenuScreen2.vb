Public Class MenuScreen2

    Private Sub MusicMenuButton_Click(sender As Object, e As EventArgs) Handles MusicMenuButton.Click
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next
        Main.songPanel1.Show()
        Main.songPanel2.Show()
        Main.songPanel3.Show()
        Main.songPanel4.Show()
        Main.MusicAppCounter += 1
        Main.MainScreenTracker = 0
        Main.horizontalCount = 8
    End Sub
End Class
