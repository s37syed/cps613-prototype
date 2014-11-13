Public Class ChildLocation
    Friend childName As String
    Private Sub CallChildButton_Click(sender As Object, e As EventArgs) Handles CallChildButton.Click
        ParentPhone.ChildLocationScreen.Enabled = False
        ParentPhone.ChildLocationScreen.Visible = False
        ParentPhone.CallChildScreen.CallerName.Text = "Calling" & childName
        ParentPhone.CallChildScreen.Enabled = True
        ParentPhone.CallChildScreen.Visible = True
    End Sub
End Class
