Public Class PhoneContacts
    Dim contacts() As String
    Dim buttons() As Button
    Dim firstPosition As Integer
    Dim lastPosition As Integer
    Dim currenPosition As Integer

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        contacts = {"Mom", "Dad", "Danielle", "Christina", "Andrea", "Johnny", "Lorde"}
        buttons = {PhoneContact0, PhoneContact1, PhoneContact2, PhoneContact3}
        firstPosition = 0
        lastPosition = 0
        currenPosition = 0
        Debug.Write("I am here")
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
End Class
