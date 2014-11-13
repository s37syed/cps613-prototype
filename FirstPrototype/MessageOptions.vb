Public Class MessageOptions
    Public Shared slctMsg As SelectMsgType = New SelectMsgType
    Private Sub NewMessage_Click(sender As Object, e As EventArgs) Handles NewMessage.Click
        Main.MainWatch.Controls.Add(slctMsg)
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next cont
        slctMsg.Show()
    End Sub
End Class