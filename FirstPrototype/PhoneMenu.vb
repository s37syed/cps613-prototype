Public Class PhoneMenu

   
    Private Sub MapMenuButton_Click(sender As Object, e As EventArgs) Handles MapMenuButton.Click
        ParentPhone.phoneMenuScreen.Enabled = False
        ParentPhone.phoneMenuScreen.Visible = False
        ParentPhone.MapAppScreen.Enabled = True
        ParentPhone.MapAppScreen.Visible = True
    End Sub
End Class
