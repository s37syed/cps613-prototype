Public Class ContactScreen

    Private Sub Name_Click(sender As Object, e As EventArgs) Handles Name1.Click, Name2.Click, Name3.Click, Name4.Click
        Dim clickedLabel = TryCast(sender, Label)
        Debug.Write(clickedLabel.Text.ToString & vbCrLf)
    End Sub
End Class