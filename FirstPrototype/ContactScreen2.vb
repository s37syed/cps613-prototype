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
                receiveMsg.getName = "12/11/2014" & vbCrLf & "@11:50 AM" & vbCrLf & "Hey Christina, keep it down, will ya?"
                receiveMsg.TransparentRichTextBox1.Text = receiveMsg.getName
            Case "From: Mom"
                receiveMsg.TransparentRichTextBox1.Text = "12/11/2014" & vbCrLf & "@10:50 AM" & vbCrLf & "I'll be coming to work late tonight."
                receiveMsg.getName = receiveMsg.TransparentRichTextBox1.Text
            Case "From: Danielle"
                receiveMsg.TransparentRichTextBox1.Text = "12/10/2014" & vbCrLf & "@10:50 AM" & vbCrLf & "Hey I'm coming over tonight!"
                receiveMsg.getName = receiveMsg.TransparentRichTextBox1.Text
            Case "From: Shahzina"
                receiveMsg.TransparentRichTextBox1.Text = "12/07/2014" & vbCrLf & "@04:00 PM" & vbCrLf & "I'm busy playing DOTA, leave me alone."
                receiveMsg.getName = receiveMsg.TransparentRichTextBox1.Text
            Case "From: Andrea"
                receiveMsg.TransparentRichTextBox1.Text = "12/19/2014" & vbCrLf & "@4:00 PM" & vbCrLf & "I wanna hang out with you gals tonight!"
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
        Main.horizontalCount = 4
    End Sub

    Private Sub ContactPhone_Click(sender As Object, e As EventArgs) Handles ContactPhone.Click
        Main.horizontalCount = 11
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next
        Main.CallContactScreen.CallContactName.Text = ContactName.Text
        Select Case Main.CallContactScreen.CallContactName.Text
            Case "Dad"
                Main.CallContactScreen.CallContactNumber.Text = Main.CallContactScreen.phoneNumbers(1)
            Case "Mom"
                Main.CallContactScreen.CallContactNumber.Text = Main.CallContactScreen.phoneNumbers(0)
            Case "Andrea"
                Main.CallContactScreen.CallContactNumber.Text = Main.CallContactScreen.phoneNumbers(4)
            Case "Shahzina"
                Main.CallContactScreen.CallContactNumber.Text = Main.CallContactScreen.phoneNumbers(3)
            Case "Johnny"
                Main.CallContactScreen.CallContactNumber.Text = Main.CallContactScreen.phoneNumbers(5)
            Case "Danielle"
                Main.CallContactScreen.CallContactNumber.Text = Main.CallContactScreen.phoneNumbers(2)
            Case "Lorde"
                Main.CallContactScreen.CallContactNumber.Text = Main.CallContactScreen.phoneNumbers(6)
        End Select
        Main.CallContactScreen.CallContactName.Text = ContactName.Text
        Main.CallContactScreen.CallContactName.Left = 57 - Main.CallContactScreen.CallContactName.Width \ 2
        Main.CallContactScreen.Visible = True

    End Sub
End Class