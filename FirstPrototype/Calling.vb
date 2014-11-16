﻿Imports System.Media
Public Class Calling
    Dim timerValue As Integer = 0
    Friend rndValue As Integer = 0

    Private Sub HangUp_Click(sender As Object, e As EventArgs) Handles HangUp.Click
        Main.horizontalCount = 0
        Main.CallingScreen.Visible = False
        Main.MenuScreen0.Visible = True
        Main.ResetTracker()
        CallingTimer.Stop()
        timerValue = 0
        Main.CallContactScreen.RingToneSound.Stop()
    End Sub
    Private Sub CallingTimer_Tick(sender As Object, e As EventArgs) Handles CallingTimer.Tick
        timerValue += 1
        If timerValue = 5 Then
            If rndValue = 1 Or rndValue = 2 Or rndValue = 3 Then
                Main.CallContactScreen.RingToneSound.Stop()
                CallingTimer.Stop()
                timerValue = 0
                For Each cont In Main.MainWatch.Controls
                    cont.hide()
                Next
                Main.CallConnectedScreen.ContactNameLabel.Text = ContactName.Text
                Main.CallConnectedScreen.ContactNameLabel.Left = 57 - Main.CallConnectedScreen.ContactNameLabel.Width \ 2
                Main.CallingScreen.Visible = False
                Main.CallConnectedScreen.Visible = True
                Main.CallConnectedScreen.BringToFront()
            ElseIf rndValue = 4 Or rndValue = 5 Then
                Main.CallContactScreen.RingToneSound.Stop()

                CallingTimer.Stop()
                timerValue = 0
                For Each cont In Main.MainWatch.Controls
                    cont.hide()
                Next
                Main.horizontalCount = 10
                Main.CallingScreen.Visible = False
                Main.CallNotConnectedScreen.Visible = True
                Main.CallNotConnectedScreen.BringToFront()
            End If
        End If
    End Sub
End Class
