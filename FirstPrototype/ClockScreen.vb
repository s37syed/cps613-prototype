Public Class ClockScreen
    Public Sub ClockScreen_Click(sender As Object, e As EventArgs) Handles Clock1.Click
        Clock1.HourHand.Color = Color.Red
        Clock1.MinuteHand.Color = Color.Green
        Clock1.SecondHand.Color = Color.Blue
        Clock1.CenterPoint.Color = Color.Yellow

    End Sub
End Class