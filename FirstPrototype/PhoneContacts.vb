﻿Public Class PhoneContacts
    Dim contacts() As String
    Dim buttons() As Button
    Dim phoneNumbers() As String
    Friend selectedContact As String
    Dim firstPosition As Integer
    Dim lastPosition As Integer
    Dim currenPosition As Integer

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        contacts = {"Mom", "Dad", "Danielle", "Shahzina", "Andrea", "Johnny", "Lorde"}
        buttons = {PhoneContact0, PhoneContact1, PhoneContact2, PhoneContact3}
        phoneNumbers = {"416-223-1435", "416-805-9931", "647-435-7865", "416-431-2455", "416-322-0956", "416-456-7891", "647-345-8811"}
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
                currenPosition += 1
            Next
        End If
    End Sub
    'MISSING CALLCONTACT USER CONTROL
    Private Sub Contact_Click(sender As Object, e As EventArgs) Handles PhoneContact0.Click, PhoneContact1.Click, PhoneContact2.Click, PhoneContact3.Click
        Dim button As Button
        button = sender
        Main.CallContactScreen.CallContactName.Text = button.Text
        Main.CallContactScreen.CallContactName.Left = 57 - Main.CallContactScreen.CallContactName.Width \ 2
        Dim value = button.Text

        If (button.Text = "Mom") Then
            Main.CallContactScreen.CallContactNumber.Text = phoneNumbers(0)
        ElseIf (button.Text = "Dad") Then
            Main.CallContactScreen.CallContactNumber.Text = phoneNumbers(1)
        ElseIf (button.Text = "Danielle") Then
            Main.CallContactScreen.CallContactNumber.Text = phoneNumbers(2)
        ElseIf (button.Text = "Christina") Then
            Main.CallContactScreen.CallContactNumber.Text = phoneNumbers(3)
        ElseIf (button.Text = "Andrea") Then
            Main.CallContactScreen.CallContactNumber.Text = phoneNumbers(4)
        ElseIf (button.Text = "Johnny") Then
            Main.CallContactScreen.CallContactNumber.Text = phoneNumbers(5)
        ElseIf (button.Text = "Lorde") Then
            Main.CallContactScreen.CallContactNumber.Text = phoneNumbers(6)
        End If

        Main.CallContactScreen.Enabled = True
        Main.PhoneContactsScreen.Visible = False
        Main.CallContactScreen.Visible = True
        Main.PhoneContactsScreen.Enabled = False
    End Sub

    Public Function getSelected() As String
        Return selectedContact
    End Function
End Class
