Public Class ParentPhone
    Friend phoneMenuScreen As New PhoneMenu
    Friend MapAppScreen As New MapApp
    Friend ChildLocationScreen As New ChildLocation
    Friend CallChildScreen As New CallChild


    Private Sub ParentPhone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainPhoneControl.Controls.Add(phoneMenuScreen)
        MainPhoneControl.Controls.Add(MapAppScreen)
        MainPhoneControl.Controls.Add(ChildLocationScreen)
        MainPhoneControl.Controls.Add(CallChildScreen)
        For Each Control In MainPhoneControl.Controls
            Control.visible = False
        Next
        phoneMenuScreen.Enabled = True
        phoneMenuScreen.Visible = True

    End Sub
End Class