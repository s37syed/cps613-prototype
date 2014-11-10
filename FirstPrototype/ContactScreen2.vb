Public Class ContactScreen2
    Public Shared nameContact As String
    Private Sub ContactScreen3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ContactName.Left = Me.ClientSize.Width \ 2 - Me.ContactName.Width \ 2
        ContactName.Text = nameContact
    End Sub
End Class
