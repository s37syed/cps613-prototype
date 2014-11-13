Public Class CallContact
    Dim phoneNumbers() As String
    Dim value As String = ""

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        phoneNumbers = {"416-223-1435", "416-805-9931", "647-435-7865", "416-431-2455", "416-322-0956", "416-456-7891", "647-345-8811"}
    End Sub

    Private Sub CallButton_Click(sender As Object, e As EventArgs) Handles CallButton.Click
        Main.CallingScreen.ContactName.Text = Main.CallContactScreen.CallContactName.Text
        Main.CallContactScreen.Enabled = False
        Main.CallContactScreen.Visible = False
        Main.CallingScreen.Visible = True
    End Sub
End Class
