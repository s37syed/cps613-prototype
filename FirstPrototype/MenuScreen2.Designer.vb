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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuScreen2))
        Me.MenuPage3Tracker = New System.Windows.Forms.PictureBox()
        Me.ReminderAppoint = New System.Windows.Forms.PictureBox()
        Me.SettingsMenuButton = New System.Windows.Forms.PictureBox()
        Me.SilenceMenuButton = New System.Windows.Forms.PictureBox()
        Me.MusicMenuButton = New System.Windows.Forms.PictureBox()
        CType(Me.MenuPage3Tracker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReminderAppoint, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ReminderAppoint
        '
        Me.ReminderAppoint.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.reminder_image
        Me.ReminderAppoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReminderAppoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReminderAppoint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReminderAppoint.Location = New System.Drawing.Point(59, 54)
        Me.ReminderAppoint.Name = "ReminderAppoint"
        Me.ReminderAppoint.Size = New System.Drawing.Size(45, 45)
        Me.ReminderAppoint.TabIndex = 3
        Me.ReminderAppoint.TabStop = False
        '
        'SettingsMenuButton
        '
        Me.SettingsMenuButton.BackgroundImage = CType(resources.GetObject("SettingsMenuButton.BackgroundImage"), System.Drawing.Image)
        Me.SettingsMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SettingsMenuButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SettingsMenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingsMenuButton.Location = New System.Drawing.Point(8, 54)
        Me.SettingsMenuButton.Name = "SettingsMenuButton"
        Me.SettingsMenuButton.Size = New System.Drawing.Size(45, 45)
        Me.SettingsMenuButton.TabIndex = 2
        Me.SettingsMenuButton.TabStop = False
        '
        'SilenceMenuButton
        '
        Me.SilenceMenuButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.playlist_icon
        Me.SilenceMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SilenceMenuButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SilenceMenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SilenceMenuButton.Location = New System.Drawing.Point(59, 3)
        Me.SilenceMenuButton.Name = "SilenceMenuButton"
        Me.SilenceMenuButton.Size = New System.Drawing.Size(45, 45)
        Me.SilenceMenuButton.TabIndex = 1
        Me.SilenceMenuButton.TabStop = False
        '
        'MusicMenuButton
        '
        Me.MusicMenuButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MusicMenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MusicMenuButton.Image = Global.FirstPrototype.My.Resources.Resources.music
        Me.MusicMenuButton.Location = New System.Drawing.Point(8, 3)
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
        Me.Controls.Add(Me.ReminderAppoint)
        Me.Controls.Add(Me.SettingsMenuButton)
        Me.Controls.Add(Me.SilenceMenuButton)
        Me.Controls.Add(Me.MusicMenuButton)
        Me.Name = "MenuScreen2"
        Me.Size = New System.Drawing.Size(113, 113)
        CType(Me.MenuPage3Tracker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReminderAppoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SilenceMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusicMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MusicMenuButton As System.Windows.Forms.PictureBox
    Friend WithEvents SilenceMenuButton As System.Windows.Forms.PictureBox
    Friend WithEvents SettingsMenuButton As System.Windows.Forms.PictureBox
    Friend WithEvents ReminderAppoint As System.Windows.Forms.PictureBox
    Friend WithEvents MenuPage3Tracker As System.Windows.Forms.PictureBox

End Class
