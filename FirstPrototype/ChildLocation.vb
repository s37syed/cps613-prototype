Public Class ChildLocation
    Friend childName As String
    Private Sub CallChildButton_Click(sender As Object, e As EventArgs) Handles CallChildButton.Click
        ParentPhone.ChildLocationScreen.Enabled = False
        ParentPhone.ChildLocationScreen.Visible = False
        If ParentPhone.CallChildScreen.CallerName.Text = "Christina" Then
            Debug.WriteLine("Line reached")
            ' call user control here
            For Each cont In Main.MainWatch.Controls
                cont.Hide()
            Next
            Main.receive_call.Visible = True
        End If
        ParentPhone.CallChildScreen.CallerName.Text = "Calling " & childName
        ParentPhone.CallChildScreen.CallerName.Left = 105 - ParentPhone.CallChildScreen.CallerName.Width \ 2
        ParentPhone.CallChildScreen.Enabled = True
        ParentPhone.CallChildScreen.Visible = True
    End Sub
End Class
