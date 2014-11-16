Public Class MsgSendContacts
    Dim contacts() As String
    Dim buttons() As Button

    Friend selectedContact As String
    Dim firstPosition As Integer
    Dim lastPosition As Integer
    Dim currenPosition As Integer
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        contacts = {"Mom", "Dad", "Danielle", "Shahzina", "Andrea", "Johnny", "Lorde"}
        buttons = {PhoneContact0, PhoneContact1, PhoneContact2, PhoneContact3}

        firstPosition = 0
        lastPosition = 0
        currenPosition = 0
        selectedContact = ""
        For counter As Integer = 0 To 3
            buttons(counter).Text = contacts(counter)
            lastPosition += 1
        Next
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub scrollDown()
        If lastPosition + 1 <= 7 Then
            firstPosition += 1
            lastPosition += 1
            currenPosition = firstPosition
            For counter As Integer = 0 To 3
                buttons(counter).Text = contacts(currenPosition)
                Debug.WriteLine("button" & counter & "= " & contacts(currenPosition))
                currenPosition += 1
            Next
        End If

    End Sub

    Sub scrollUp()
        If firstPosition - 1 >= 0 Then
            firstPosition -= 1
            lastPosition -= 1
            currenPosition = firstPosition
            For counter As Integer = 0 To 3
                buttons(counter).Text = contacts(currenPosition)
                Debug.WriteLine("button" & counter & "= " & contacts(currenPosition))
                currenPosition += 1
            Next
        End If
    End Sub
    'MISSING CALLCONTACT USER CONTROL
    Private Sub Contact_Click(sender As Object, e As EventArgs) Handles PhoneContact0.Click, PhoneContact1.Click, PhoneContact2.Click, PhoneContact3.Click
        Dim button As Button
        button = sender
        Main.CallContactScreen.CallContactName.Text = button.Text
        Dim value = button.Text

        'If (button.Text = "Mom") Then
        '    Main.CallContactScreen.CallContactNumber.Text = phoneNumbers(0)
        'ElseIf (button.Text = "Dad") Then
        '    Main.CallContactScreen.CallContactNumber.Text = phoneNumbers(1)
        'ElseIf (button.Text = "Danielle") Then
        '    Main.CallContactScreen.CallContactNumber.Text = phoneNumbers(2)
        'ElseIf (button.Text = "Christina") Then
        '    Main.CallContactScreen.CallContactNumber.Text = phoneNumbers(3)
        'ElseIf (button.Text = "Andrea") Then
        '    Main.CallContactScreen.CallContactNumber.Text = phoneNumbers(4)
        'ElseIf (button.Text = "Johnny") Then
        '    Main.CallContactScreen.CallContactNumber.Text = phoneNumbers(5)
        'ElseIf (button.Text = "Lorde") Then
        '    Main.CallContactScreen.CallContactNumber.Text = phoneNumbers(6)
        'End If

        If SelectMsgType2.MsgType = 1 Then
            For Each cont In Main.MainWatch.Controls
                cont.Hide()
            Next cont
            Main.send_message.NameLabel.Text = "To: " & button.Text
            Main.send_message.Visible = True
        ElseIf SelectMsgType2.MsgType = 2 Then
            For Each cont In Main.MainWatch.Controls
                cont.Hide()
            Next cont
            Main.send_image.Label1.Text = "To: " & button.Text
            Main.send_image.Visible = True
        ElseIf SelectMsgType2.MsgType = 3 Then
            For Each cont In Main.MainWatch.Controls
                cont.Hide()
            Next cont
            Main.send_video.Label1.Text = "To: " & button.Text
            Main.send_video.Visible = True
        End If
    End Sub

    Public Function getSelected() As String
        Return selectedContact
    End Function
End Class
