Public Class ContactScreen2
    Public Sub Name2_Click(sender As Object, e As EventArgs) Handles Name5.Click, Name6.Click, Name7.Click, Name8.Click
        Dim clickedLabel = TryCast(sender, Label)
        ContactScreen3.nameContact = clickedLabel.Text.ToString
    End Sub
End Class
