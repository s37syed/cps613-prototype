Public Class ContactScreen2

    Private Sub Name5_Click(sender As Object, e As EventArgs) Handles Name5.Click, Name6.Click, Name7.Click, Name8.Click
        Dim clickedLabel = TryCast(sender, Label)
        Debug.Write(clickedLabel.Text.ToString & vbCrLf)
    End Sub
End Class
