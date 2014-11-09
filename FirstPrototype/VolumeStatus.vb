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
        Me.SetVolume(VolumeLevel)

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub VolumeStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Set Volume Level 
    Public Sub SetVolume(VolumeLevel As Integer)

        If VolumeLevel.Equals(0) Then
            VolumeStatusLabel.Text = "Silent"
        Else
            VolumeStatusLabel.Text = "Vol: " & VolumeLevel
        End If


    End Sub

    Public Sub SubtractVolumeLevel()
        ' Volume can't be updated lower than MIN_Volume =0
        If (VolumeLevel - 1) >= MIN_VOLUME Then
            Me.VolumeLevel = VolumeLevel - 1
            ' Call User Controller of the Volume Status

            Me.SetVolume(Me.VolumeLevel)

            ' System.Threading.Thread.Sleep(2000)
            'Panel1.Controls.Remove(volumeStatus)
        End If

    End Sub

    Public Sub AddVolumeLevel()

        If (VolumeLevel + 1) <= MAX_VOLUME Then
            Me.VolumeLevel = VolumeLevel + 1
            ' Call User Controller of the Volume Status
            Me.SetVolume(Me.VolumeLevel)

            '  System.Threading.Thread.Sleep(2000)
            '  Panel1.Controls.Remove(volumeStatus)
        End If

    End Sub

End Class
