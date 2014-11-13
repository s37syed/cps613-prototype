Public Class MapApp

    Private Sub Child1_Click(sender As Object, e As EventArgs) Handles Child1.Click
        ParentPhone.MapAppScreen.Enabled = False
        ParentPhone.MapAppScreen.Visible = False
        ParentPhone.ChildLocationScreen.Enabled = True
        ParentPhone.ChildLocationScreen.Visible = True
        ParentPhone.ChildLocationScreen.CallChildButton.Text = "Call " & Child1.Text
        ParentPhone.ChildLocationScreen.PictureBox1.Image = My.Resources.ChristinaMap
        ParentPhone.ChildLocationScreen.childName = Child1.Text
    End Sub

    Private Sub Child2_Click(sender As Object, e As EventArgs) Handles Child2.Click
        ParentPhone.MapAppScreen.Enabled = False
        ParentPhone.MapAppScreen.Visible = False
        ParentPhone.ChildLocationScreen.Enabled = True
        ParentPhone.ChildLocationScreen.Visible = True
        ParentPhone.ChildLocationScreen.CallChildButton.Text = "Call " & Child2.Text
        ParentPhone.ChildLocationScreen.PictureBox1.Image = My.Resources.RandyMap
        ParentPhone.ChildLocationScreen.childName = Child2.Text
    End Sub

    Private Sub Child3_Click(sender As Object, e As EventArgs) Handles Child3.Click
        ParentPhone.MapAppScreen.Enabled = False
        ParentPhone.MapAppScreen.Visible = False
        ParentPhone.ChildLocationScreen.Enabled = True
        ParentPhone.ChildLocationScreen.Visible = True
        ParentPhone.ChildLocationScreen.CallChildButton.Text = "Call " & Child3.Text
        ParentPhone.ChildLocationScreen.PictureBox1.Image = My.Resources.VladimirMap
        ParentPhone.ChildLocationScreen.childName = Child3.Text
    End Sub
End Class
