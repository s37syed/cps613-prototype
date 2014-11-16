Public Class SelectMsgType2
    Public Shared MsgType As Integer
    Private Sub MsgPicBox_Click(sender As Object, e As EventArgs) Handles MsgPicBox.Click
        MsgType = 1 ' denotes user chose text msg
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next
        Main.MsgSendContacts1.Visible = True 'added this
    End Sub
    Private Sub ImgPicBox_Click(sender As Object, e As EventArgs) Handles ImgPicBox.Click
        MsgType = 2 ' denotes user chose image msg
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next
        Main.MsgSendContacts1.Visible = True 'added this
    End Sub
    Private Sub VidPicBox_Click(sender As Object, e As EventArgs) Handles VidPicBox.Click
        MsgType = 3 ' denotes user chose video msg
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next
        Main.MsgSendContacts1.Visible = True 'added this
    End Sub
End Class
