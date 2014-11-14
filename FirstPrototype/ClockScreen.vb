Public Class ClockScreen
    Private IsSelected As Boolean = False
    Public Sub ClockScreen_Click(sender As Object, e As EventArgs) Handles Clock1.Click
        If IsSelected = False Then
            Clock1.HourHand.Color = Color.Red
            Clock1.MinuteHand.Color = Color.Green
            Clock1.SecondHand.Color = Color.Blue
            Clock1.CenterPoint.Color = Color.Yellow
            IsSelected = True
        ElseIf IsSelected = True Then
            Clock1.HourHand.Color = Color.Black
            Clock1.MinuteHand.Color = Color.Black
            Clock1.SecondHand.Color = Color.Black
            Clock1.CenterPoint.Color = Color.Black
            IsSelected = False
        End If



    End Sub
End Class