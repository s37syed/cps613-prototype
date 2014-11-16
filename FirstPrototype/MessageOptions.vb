Public Class MessageOptions
    Public Shared slctMsg As SelectMsgType = New SelectMsgType
    Public Shared contactScreen2 As ContactScreen2 = New ContactScreen2()
    Private Sub NewMessage_Click(sender As Object, e As EventArgs) Handles NewMessage.Click
        Main.MainWatch.Controls.Add(slctMsg)
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next cont
        slctMsg.Show()
    End Sub
    Private Sub DeleteMessage_Click(sender As Object, e As EventArgs) Handles DeleteMessage.Click
        'For Each cont In Main.MainWatch.Controls
        '    If cont.ToString = "FirstPrototype.ReceiveMsg" Then
        '        cont.deleteMsg("")
        '        cont.HideOptions()
        '    End If
        'Next
        Debug.WriteLine("delete message")
        Main.receive_msg_notification.TransparentRichTextBox1.Hide()
        'Main.receive_msg_notification.TransparentRichTextBox1.Clear()
        'Main.receive_msg_notification.TransparentRichTextBox1.Refresh()
    End Sub
End Class