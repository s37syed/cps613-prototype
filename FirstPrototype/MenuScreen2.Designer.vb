<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuScreen2
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuPage3Tracker = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.SettingsMenuButton = New System.Windows.Forms.PictureBox()
        Me.SilenceMenuButton = New System.Windows.Forms.PictureBox()
        Me.MusicMenuButton = New System.Windows.Forms.PictureBox()
        CType(Me.MenuPage3Tracker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SilenceMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusicMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuPage3Tracker
        '
        Me.MenuPage3Tracker.Image = Global.FirstPrototype.My.Resources.Resources.Page3TrackerClear
        Me.MenuPage3Tracker.Location = New System.Drawing.Point(31, 102)
        Me.MenuPage3Tracker.Name = "MenuPage3Tracker"
        Me.MenuPage3Tracker.Size = New System.Drawing.Size(50, 10)
        Me.MenuPage3Tracker.TabIndex = 4
        Me.MenuPage3Tracker.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(54, 54)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'SettingsMenuButton
        '
        Me.SettingsMenuButton.Image = Global.FirstPrototype.My.Resources.Resources.Settings
        Me.SettingsMenuButton.Location = New System.Drawing.Point(3, 54)
        Me.SettingsMenuButton.Name = "SettingsMenuButton"
        Me.SettingsMenuButton.Size = New System.Drawing.Size(45, 45)
        Me.SettingsMenuButton.TabIndex = 2
        Me.SettingsMenuButton.TabStop = False
        '
        'SilenceMenuButton
        '
        Me.SilenceMenuButton.Image = Global.FirstPrototype.My.Resources.Resources.silence
        Me.SilenceMenuButton.Location = New System.Drawing.Point(54, 3)
        Me.SilenceMenuButton.Name = "SilenceMenuButton"
        Me.SilenceMenuButton.Size = New System.Drawing.Size(45, 45)
        Me.SilenceMenuButton.TabIndex = 1
        Me.SilenceMenuButton.TabStop = False
        '
        'MusicMenuButton
        '
        Me.MusicMenuButton.Image = Global.FirstPrototype.My.Resources.Resources.music
        Me.MusicMenuButton.Location = New System.Drawing.Point(3, 3)
        Me.MusicMenuButton.Name = "MusicMenuButton"
        Me.MusicMenuButton.Size = New System.Drawing.Size(45, 45)
        Me.MusicMenuButton.TabIndex = 0
        Me.MusicMenuButton.TabStop = False
        '
        'MenuScreen2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MenuPage3Tracker)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.SettingsMenuButton)
        Me.Controls.Add(Me.SilenceMenuButton)
        Me.Controls.Add(Me.MusicMenuButton)
        Me.Name = "MenuScreen2"
        Me.Size = New System.Drawing.Size(113, 113)
        CType(Me.MenuPage3Tracker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SilenceMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusicMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MusicMenuButton As System.Windows.Forms.PictureBox
    Friend WithEvents SilenceMenuButton As System.Windows.Forms.PictureBox
    Friend WithEvents SettingsMenuButton As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuPage3Tracker As System.Windows.Forms.PictureBox

End Class
