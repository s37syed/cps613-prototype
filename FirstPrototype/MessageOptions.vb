Public Class MessageOptions
    Public Shared contactScreen2 As ContactScreen2 = New ContactScreen2()
    Private Sub DeleteMessage_Click(sender As Object, e As EventArgs) Handles DeleteMessage.Click
        For Each cont In Main.MainWatch.Controls
            If cont.ToString = "FirstPrototype.ReceiveMsg" Then
                cont.deleteMsg("")
                cont.HideOptions()
            End If
        Next
    End Sub
End Class