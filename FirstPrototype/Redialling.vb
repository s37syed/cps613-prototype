Public Class Redialling
    Dim timerValue As Integer = 0
    Dim countDown As Integer = 5

    Private Sub RedialTimer_Tick(sender As Object, e As EventArgs) Handles RedialTimer.Tick
        timerValue += 1
        countDown -= 1
        RedialingTimerLabel.Text = countDown
        If timerValue = 5 Then
            Main.CallContactScreen.RingToneSound.PlayLooping()
            countDown = 6
            RedialTimer.Stop()
            timerValue = 0
            Main.RediallingScreen.Visible = False
            Main.CallingScreen.Visible = True
            Main.CallingScreen.BringToFront()
            Main.CallingScreen.CallingTimer.Start()
            Dim value As Integer = CInt(Int((5 * Rnd()) + 1))
            Main.CallingScreen.rndValue = value
        End If
    End Sub
End Class
