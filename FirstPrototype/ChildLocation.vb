Imports System.Media
Public Class ChildLocation
    Friend childName As String

    Friend OutGoingRingtone As SoundPlayer = New SoundPlayer(My.Resources.soundOutgoingRington)

    Private Sub CallChildButton_Click(sender As Object, e As EventArgs) Handles CallChildButton.Click
        ParentPhone.ChildLocationScreen.Enabled = False
        ParentPhone.ChildLocationScreen.Visible = False
        Me.OutGoingRingtone.PlayLooping()
        If ParentPhone.ChildLocationScreen.childName = "Christina" Then
            ' call user control here
            For Each cont In Main.MainWatch.Controls
                cont.Hide()
            Next
            Main.horizontalCount = 15
            Main.MainScreenTracker = 0
            Main.receive_call.Visible = True
        End If
        ParentPhone.CallChildScreen.CallerName.Text = "Calling " & childName
        ParentPhone.CallChildScreen.CallerName.Left = 105 - ParentPhone.CallChildScreen.CallerName.Width \ 2
        ParentPhone.CallChildScreen.Enabled = True
        ParentPhone.CallChildScreen.Visible = True
    End Sub
End Class
