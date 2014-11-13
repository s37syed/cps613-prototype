Public Class ContactScreen2
    Public Shared receiveMsg As ReceiveMsg = New ReceiveMsg()
    Dim contacts() As String
    Dim buttons() As Button
    Dim firstPosition As Integer
    Dim lastPosition As Integer
    Dim currentPosition As Integer
    Public Shared nameContact As String

    Private Sub ContactMsg_Click(sender As Object, e As EventArgs) Handles ContactMsg.Click
        Debug.WriteLine("Test")
        'continue from here
        Main.MainWatch.Controls.Add(receiveMsg)
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next cont
        receiveMsg.Show()
        receiveMsg.ContactName.Text = nameContact
        ' ADD MESSAGES HERE
        Select Case receiveMsg.ContactName.Text.ToString
            Case "From: Dad"
                receiveMsg.getName = "12/11/2014" & vbCrLf & "@11:50 AM" & vbCrLf & "Hey Christina, I'm sick and tired of picking you up at school."
                receiveMsg.TransparentRichTextBox1.Text = receiveMsg.getName
            Case "From: Mom"
                receiveMsg.TransparentRichTextBox1.Text = "12/11/2014" & vbCrLf & "@10:50 AM" & vbCrLf & "Hey Christina, I love you."
                receiveMsg.getName = receiveMsg.TransparentRichTextBox1.Text
            Case "From: Danielle"
                receiveMsg.TransparentRichTextBox1.Text = "12/10/2014" & vbCrLf & "@10:50 AM" & vbCrLf & "Hey I'm coming over to play with you bae imu"
                receiveMsg.getName = receiveMsg.TransparentRichTextBox1.Text
            Case "From: Shahzina"
                receiveMsg.TransparentRichTextBox1.Text = "12/07/2014" & vbCrLf & "@04:00 PM" & vbCrLf & "I'm busy playing DOTA, leave me alone."
                receiveMsg.getName = receiveMsg.TransparentRichTextBox1.Text
            Case "From: Andrea"
                receiveMsg.TransparentRichTextBox1.Text = "12/12/2014" & vbCrLf & "@4:00 PM" & vbCrLf & "um y didnt u invite me? lol k im comin over tn"
                receiveMsg.getName = receiveMsg.TransparentRichTextBox1.Text
            Case "From: Johnny"
                receiveMsg.TransparentRichTextBox1.Text = "09/09/2014" & vbCrLf & "@10:50 AM" & vbCrLf & "Hey Christina, I love you."
                receiveMsg.getName = receiveMsg.TransparentRichTextBox1.Text
            Case "From: Lorde"
                receiveMsg.TransparentRichTextBox1.Text = "12/11/2014" & vbCrLf & "@10:50 AM" & vbCrLf & "YA YA YA YA YA, I AM LORDE"
                receiveMsg.getName = receiveMsg.TransparentRichTextBox1.Text
        End Select

        ' center the text
        receiveMsg.ContactName.Left = 57 - receiveMsg.ContactName.Width \ 2
    End Sub
End Class