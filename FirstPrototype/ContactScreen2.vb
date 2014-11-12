Public Class ContactScreen2
    Public Shared receiveMsg As ReceiveMsg = New ReceiveMsg()
    Public Shared receiveMsg2 As ReceiveMsg = New ReceiveMsg()
    Dim contacts() As String
    Dim buttons() As Button
    Dim firstPosition As Integer
    Dim lastPosition As Integer
    Dim currentPosition As Integer
    Public Shared nameContact As String

    Private Sub ContactMsg_Click(sender As Object, e As EventArgs) Handles ContactMsg.Click
        'continue from here
        Main.MainWatch.Controls.Add(receiveMsg)
        Main.MainWatch.Controls.Add(receiveMsg2)
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next cont
        receiveMsg.Show()
        receiveMsg.ContactName.Text = nameContact
        ' ADD MESSAGES HEERE
        Select Case receiveMsg.ContactName.Text.ToString
            Case "From: Dad"
                receiveMsg.TransparentRichTextBox1.Text = "12/11/2014" & vbCrLf & "@11:50 AM" & vbCrLf & "Hey Christina, I'm sick and tired of picking you up at school."
            Case "From: Mom"
                receiveMsg.TransparentRichTextBox1.Text = "12/11/2014" & vbCrLf & "@10:50 AM" & vbCrLf & "Hey Christina, I love you."
                receiveMsg.TransparentRichTextBox1.Text = "12/11/2014" & vbCrLf & "@10:50 AM" & vbCrLf & "Also, you have AIDS."
            Case "From: Danielle"
                receiveMsg.TransparentRichTextBox1.Text = "12/10/2014" & vbCrLf & "@10:50 AM" & vbCrLf & "Hey I'm coming over tn bae imu"
            Case "From: Andrea"
                receiveMsg.TransparentRichTextBox1.Text = "12/12/2014" & vbCrLf & "@4:00 PM" & vbCrLf & "um y didnt u invite me? lol k im comin over tn"
            Case "From: Johnny"
                receiveMsg.TransparentRichTextBox1.Text = "09/09/2014" & vbCrLf & "@10:50 AM" & vbCrLf & "Hey Christina, I love you."
            Case "From: Lorde"
                receiveMsg.TransparentRichTextBox1.Text = "12/11/2014" & vbCrLf & "@10:50 AM" & vbCrLf & "LA LA LA LA LA I AM LORDE"
        End Select

        ' center the text
        receiveMsg.ContactName.Left = 57 - receiveMsg.ContactName.Width \ 2
        ' make it so you can't scroll anywhere except left
        Main.freeze = True
        Main.horizontalCount = Main.horizontalCount + 1
    End Sub
    Sub scrollDown()
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next cont
        receiveMsg2.Show()
    End Sub
End Class