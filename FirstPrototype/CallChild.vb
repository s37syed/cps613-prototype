Public Class CallChild

    Private Sub ParentHangUpButton_Click(sender As Object, e As EventArgs) Handles ParentHangUpButton.Click
        ParentPhone.CallChildScreen.Enabled = False
        ParentPhone.CallChildScreen.Visible = False
        ParentPhone.phoneMenuScreen.Enabled = True
        ParentPhone.phoneMenuScreen.Visible = True

    End Sub
End Class
