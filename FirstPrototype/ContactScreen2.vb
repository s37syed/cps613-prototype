Public Class ContactScreen2
    Public Shared receiveMsg As ReceiveMsg = New ReceiveMsg()
    Dim contacts() As String
    Dim buttons() As Button
    Dim firstPosition As Integer
    Dim lastPosition As Integer
    Dim currentPosition As Integer
    Public Shared nameContact As String

    Private Sub ContactMsg_Click(sender As Object, e As EventArgs) Handles ContactMsg.Click
        'continue from here
        Main.MainWatch.Controls.Add(receiveMsg)
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next cont
        receiveMsg.Show()
        receiveMsg.ContactName.Text = nameContact
        ' center the text
        receiveMsg.ContactName.Left = 57 - receiveMsg.ContactName.Width \ 2
        ' make it so you can't scroll anywhere except left
        Main.freeze = True
        Main.horizontalCount = Main.horizontalCount + 1
    End Sub
End Class