Public Class CallContact
    Dim phoneNumbers() As String
    Dim value As String = ""

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        phoneNumbers = {"416-223-1435", "416-805-9931", "647-435-7865", "416-431-2455", "416-322-0956", "416-456-7891", "647-345-8811"}
        'value = Main.PhoneContactsScreen.getSelected
        'value = "Mom"
        'Select Case value
        '    Case "Mom"
        '        CallContactName.Text = value
        '        CallContactNumber.Text = phoneNumbers(0)
        '    Case "Dad"
        '        CallContactName.Text = value
        '        CallContactNumber.Text = phoneNumbers(1)
        '    Case "Danielle"
        '        CallContactName.Text = value
        '        CallContactNumber.Text = phoneNumbers(2)
        '    Case "Christina"
        '        CallContactName.Text = value
        '        CallContactNumber.Text = phoneNumbers(3)
        '    Case "Andrea"
        '        CallContactName.Text = value
        '        CallContactNumber.Text = phoneNumbers(4)
        '    Case "Johnny"
        '        CallContactName.Text = value
        '        CallContactNumber.Text = phoneNumbers(5)
        '    Case "Lorde"
        '        CallContactName.Text = value
        '        CallContactNumber.Text = phoneNumbers(6)


        'End Select
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CallButton_Click(sender As Object, e As EventArgs) Handles CallButton.Click
        Main.CallingScreen.ContactName.Text = Main.CallContactScreen.CallContactName.Text
        Main.CallContactScreen.Enabled = False
        Main.CallContactScreen.Visible = False
        Main.CallingScreen.Visible = True
    End Sub
End Class
