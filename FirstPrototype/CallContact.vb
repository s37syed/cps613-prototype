﻿Imports System.Media
Public Class CallContact
    Friend phoneNumbers() As String
    Dim value As String = ""

    Friend RingToneSound As SoundPlayer = New SoundPlayer(My.Resources.soundOutgoingRington)

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        phoneNumbers = {"416-223-1435", "416-805-9931", "647-435-7865", "416-431-2455", "416-322-0956", "416-456-7891", "647-345-8811"}
    End Sub

    Private Sub CallButton_Click(sender As Object, e As EventArgs) Handles CallButton.Click
        Main.horizontalCount = 10
        Main.CallingScreen.ContactName.Text = Main.CallContactScreen.CallContactName.Text
        Main.CallingScreen.ContactName.Left = 57 - Main.CallingScreen.ContactName.Width \ 2
        Main.CallContactScreen.Visible = False
        Main.CallingScreen.Visible = True
        Main.CallingScreen.CallingTimer.Start()
        Dim value As Integer = CInt(Int((5 * Rnd()) + 1))
        Main.CallingScreen.rndValue = value
        RingToneSound.PlayLooping()
    End Sub
End Class
