' VolumeStatus UserControler displays current Volume Level Notification 
'@Daniel Kozij 
'@date: 8/11/2014
Public Class VolumeStatus

    '@author Daniel Kozij 
    'Dim Max Volume Level
    Dim MAX_VOLUME As Integer = 10
    'Min Volume 
    Dim MIN_VOLUME As Integer = 0
    ' Instance variable for Volume level
    Dim VolumeLevel As Integer = 5

    ' intitalize New VolumeStatus Object 
    ' @param Volume as Integer 
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        VolumeStatusLabel.Text = "Vol: " & VolumeLevel
        VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
    End Sub
    Public Sub SetVolumeDown(VolumeLevel As Integer)

        If VolumeLevel.Equals(0) Then
            VolumeStatusLabel.Text = "Silent"
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolDn))
            Next
        ElseIf VolumeLevel.Equals(1) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolDn))
            Next
        ElseIf VolumeLevel.Equals(2) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolDn))
            Next
        ElseIf VolumeLevel.Equals(3) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolDn))
            Next
        ElseIf VolumeLevel.Equals(4) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolDn))
            Next
        ElseIf VolumeLevel.Equals(5) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolDn))
            Next
        ElseIf VolumeLevel.Equals(6) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolDn))
            Next
        ElseIf VolumeLevel.Equals(7) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolDn))
            Next
        ElseIf VolumeLevel.Equals(8) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolDn))
            Next
        ElseIf VolumeLevel.Equals(9) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolDn))
            Next
        ElseIf VolumeLevel.Equals(10) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolDn))
            Next
        End If


    End Sub

    Public Sub SetVolumeUp(VolumeLevel As Integer)

        If VolumeLevel.Equals(0) Then
            VolumeStatusLabel.Text = "Silent"
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolUp))
            Next
        ElseIf VolumeLevel.Equals(1) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolUp))
            Next
        ElseIf VolumeLevel.Equals(2) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolUp))
            Next
        ElseIf VolumeLevel.Equals(3) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolUp))
            Next
        ElseIf VolumeLevel.Equals(4) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolUp))
            Next
        ElseIf VolumeLevel.Equals(5) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolUp))
            Next
        ElseIf VolumeLevel.Equals(6) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolUp))
            Next
        ElseIf VolumeLevel.Equals(7) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolUp))
            Next
        ElseIf VolumeLevel.Equals(8) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolUp))
            Next
        ElseIf VolumeLevel.Equals(9) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolUp))
            Next
        ElseIf VolumeLevel.Equals(10) Then
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
            VolumeStatusLabel.Left = 44 - VolumeStatusLabel.Width / 2
            For counter = 0 To 4
                Main.SendMessageW(Main.Handle, Main.MsgNo, Main.Handle, New IntPtr(Main.VolUp))
            Next
        End If


    End Sub

    Public Sub SubtractVolumeLevel()
        ' Volume can't be updated lower than MIN_Volume =0
        If (VolumeLevel - 1) >= MIN_VOLUME Then
            Me.VolumeLevel = VolumeLevel - 1
            ' Call User Controller of the Volume Status

            Me.SetVolumeDown(Me.VolumeLevel)

            ' System.Threading.Thread.Sleep(2000)
            'Panel1.Controls.Remove(volumeStatus)
        End If

    End Sub

    Public Sub AddVolumeLevel()

        If (VolumeLevel + 1) <= MAX_VOLUME Then
            Me.VolumeLevel = VolumeLevel + 1
            ' Call User Controller of the Volume Status
            Me.SetVolumeUp(Me.VolumeLevel)

            '  System.Threading.Thread.Sleep(2000)
            '  Panel1.Controls.Remove(volumeStatus)
        End If

    End Sub

End Class