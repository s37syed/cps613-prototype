Public Class ContactScreen
    Public Shared contactScreen2 As ContactScreen2 = New ContactScreen2()
    Dim contacts() As String
    Dim buttons() As Button
    Dim firstPosition As Integer
    Dim lastPosition As Integer
    Dim currentPosition As Integer
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        contacts = {"Mom", "Dad", "Danielle", "Christina", "Andrea", "Johnny", "Lorde"}
        buttons = {Contact1, Contact2, Contact3, Contact4}
        firstPosition = 0
        lastPosition = 0
        currentPosition = 0
        For counter As Integer = 0 To 3
            buttons(counter).Text = contacts(counter)
            lastPosition += 1
        Next
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub scrollDown()
        If lastPosition + 1 <= 6 Then
            firstPosition += 1
            lastPosition += 1
            currentPosition = firstPosition
            For counter As Integer = 0 To 3
                buttons(counter).Text = contacts(currentPosition)
                currentPosition += 1
            Next
        End If
    End Sub

    Sub scrollUp()
        If firstPosition - 1 >= 0 Then
            firstPosition -= 1
            lastPosition -= 1
            currentPosition = firstPosition
            For counter As Integer = 0 To 3
                buttons(counter).Text = contacts(currentPosition)
                currentPosition += 1
            Next
        End If
    End Sub
    Private Sub Name_Click(sender As Object, e As EventArgs) Handles Contact1.Click, Contact2.Click, Contact3.Click, Contact4.Click
        'continue from here
        Dim clickedLabel = TryCast(sender, Button)
        Main.MainWatch.Controls.Add(contactScreen2)
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next cont
        contactScreen2.Show()
        contactScreen2.ContactName.Text = clickedLabel.Text.ToString
        contactScreen2.nameContact = "From: " & clickedLabel.Text.ToString
        ' center the text
        contactScreen2.ContactName.Left = 57 - contactScreen2.ContactName.Width \ 2
        ' make it so you can't scroll anywhere except left
        Main.freeze = True
        Main.horizontalCount = Main.horizontalCount + 1
    End Sub
End Class