<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MainWatch = New System.Windows.Forms.Panel()
        Me.Reminder = New System.Windows.Forms.Label()
        Me.ErrorMsg = New System.Windows.Forms.Label()
        Me.NewMsgEventPic = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SwipeDown = New System.Windows.Forms.PictureBox()
        Me.SwipeUpButton = New System.Windows.Forms.PictureBox()
        Me.SwipeRightButton = New System.Windows.Forms.PictureBox()
        Me.SwipeLeftButton = New System.Windows.Forms.PictureBox()
        Me.PowerButton = New System.Windows.Forms.PictureBox()
        Me.DoorButton = New System.Windows.Forms.PictureBox()
        Me.VolumeDownButton = New System.Windows.Forms.PictureBox()
        Me.VolumeUpButton = New System.Windows.Forms.PictureBox()
        Me.MainWatch.SuspendLayout()
        CType(Me.NewMsgEventPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwipeDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwipeUpButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwipeRightButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwipeLeftButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PowerButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoorButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeDownButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeUpButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainWatch
        '
        Me.MainWatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainWatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainWatch.Controls.Add(Me.Reminder)
        Me.MainWatch.Controls.Add(Me.ErrorMsg)
        Me.MainWatch.Controls.Add(Me.NewMsgEventPic)
        Me.MainWatch.Location = New System.Drawing.Point(84, 62)
        Me.MainWatch.Name = "MainWatch"
        Me.MainWatch.Size = New System.Drawing.Size(113, 113)
        Me.MainWatch.TabIndex = 1
        '
        'Reminder
        '
        Me.Reminder.AutoSize = True
        Me.Reminder.BackColor = System.Drawing.Color.Transparent
        Me.Reminder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Reminder.Location = New System.Drawing.Point(3, 34)
        Me.Reminder.Name = "Reminder"
        Me.Reminder.Size = New System.Drawing.Size(104, 15)
        Me.Reminder.TabIndex = 12
        Me.Reminder.Text = "Danielle to call Mom"
        Me.Reminder.Visible = False
        '
        'ErrorMsg
        '
        Me.ErrorMsg.AutoSize = True
        Me.ErrorMsg.BackColor = System.Drawing.Color.Transparent
        Me.ErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorMsg.Location = New System.Drawing.Point(12, 47)
        Me.ErrorMsg.Name = "ErrorMsg"
        Me.ErrorMsg.Size = New System.Drawing.Size(89, 15)
        Me.ErrorMsg.TabIndex = 11
        Me.ErrorMsg.Text = "Not Implemented"
        Me.ErrorMsg.Visible = False
        '
        'NewMsgEventPic
        '
        Me.NewMsgEventPic.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.new_msg_pic
        Me.NewMsgEventPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NewMsgEventPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewMsgEventPic.Location = New System.Drawing.Point(-1, -1)
        Me.NewMsgEventPic.Name = "NewMsgEventPic"
        Me.NewMsgEventPic.Size = New System.Drawing.Size(113, 113)
        Me.NewMsgEventPic.TabIndex = 10
        Me.NewMsgEventPic.TabStop = False
        Me.NewMsgEventPic.Visible = False
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(108, 205)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 9
        Me.HomeButton.Text = "Door"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'SwipeDown
        '
        Me.SwipeDown.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.swipe_down
        Me.SwipeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SwipeDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SwipeDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SwipeDown.Location = New System.Drawing.Point(123, 185)
        Me.SwipeDown.Name = "SwipeDown"
        Me.SwipeDown.Size = New System.Drawing.Size(45, 45)
        Me.SwipeDown.TabIndex = 14
        Me.SwipeDown.TabStop = False
        '
        'SwipeUpButton
        '
        Me.SwipeUpButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.swipe_up
        Me.SwipeUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SwipeUpButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SwipeUpButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SwipeUpButton.Location = New System.Drawing.Point(123, 3)
        Me.SwipeUpButton.Name = "SwipeUpButton"
        Me.SwipeUpButton.Size = New System.Drawing.Size(45, 45)
        Me.SwipeUpButton.TabIndex = 13
        Me.SwipeUpButton.TabStop = False
        '
        'SwipeRightButton
        '
        Me.SwipeRightButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.swipe_right
        Me.SwipeRightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SwipeRightButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SwipeRightButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SwipeRightButton.Location = New System.Drawing.Point(213, 94)
        Me.SwipeRightButton.Name = "SwipeRightButton"
        Me.SwipeRightButton.Size = New System.Drawing.Size(45, 45)
        Me.SwipeRightButton.TabIndex = 12
        Me.SwipeRightButton.TabStop = False
        '
        'SwipeLeftButton
        '
        Me.SwipeLeftButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.swipe_left
        Me.SwipeLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SwipeLeftButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SwipeLeftButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SwipeLeftButton.Location = New System.Drawing.Point(21, 94)
        Me.SwipeLeftButton.Name = "SwipeLeftButton"
        Me.SwipeLeftButton.Size = New System.Drawing.Size(45, 45)
        Me.SwipeLeftButton.TabIndex = 11
        Me.SwipeLeftButton.TabStop = False
        '
        'PowerButton
        '
        Me.PowerButton.BackgroundImage = CType(resources.GetObject("PowerButton.BackgroundImage"), System.Drawing.Image)
        Me.PowerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PowerButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PowerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PowerButton.Location = New System.Drawing.Point(12, 197)
        Me.PowerButton.Name = "PowerButton"
        Me.PowerButton.Size = New System.Drawing.Size(33, 33)
        Me.PowerButton.TabIndex = 10
        Me.PowerButton.TabStop = False
        '
        'DoorButton
        '
        Me.DoorButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.door_resized1
        Me.DoorButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DoorButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoorButton.Location = New System.Drawing.Point(63, 197)
        Me.DoorButton.Name = "DoorButton"
        Me.DoorButton.Size = New System.Drawing.Size(33, 33)
        Me.DoorButton.TabIndex = 9
        Me.DoorButton.TabStop = False
        Me.DoorButton.Visible = False
        '
        'VolumeDownButton
        '
        Me.VolumeDownButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.volume_silent
        Me.VolumeDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VolumeDownButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VolumeDownButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VolumeDownButton.Location = New System.Drawing.Point(200, 197)
        Me.VolumeDownButton.Name = "VolumeDownButton"
        Me.VolumeDownButton.Size = New System.Drawing.Size(33, 33)
        Me.VolumeDownButton.TabIndex = 15
        Me.VolumeDownButton.TabStop = False
        '
        'VolumeUpButton
        '
        Me.VolumeUpButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.volume_loud
        Me.VolumeUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VolumeUpButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VolumeUpButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VolumeUpButton.Location = New System.Drawing.Point(239, 197)
        Me.VolumeUpButton.Name = "VolumeUpButton"
        Me.VolumeUpButton.Size = New System.Drawing.Size(33, 33)
        Me.VolumeUpButton.TabIndex = 16
        Me.VolumeUpButton.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 240)
        Me.Controls.Add(Me.VolumeUpButton)
        Me.Controls.Add(Me.VolumeDownButton)
        Me.Controls.Add(Me.SwipeDown)
        Me.Controls.Add(Me.SwipeUpButton)
        Me.Controls.Add(Me.SwipeRightButton)
        Me.Controls.Add(Me.SwipeLeftButton)
        Me.Controls.Add(Me.PowerButton)
        Me.Controls.Add(Me.DoorButton)
        Me.Controls.Add(Me.MainWatch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main"
        Me.Text = "Prototype B1"
        Me.MainWatch.ResumeLayout(False)
        Me.MainWatch.PerformLayout()
        CType(Me.NewMsgEventPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwipeDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwipeUpButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwipeRightButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwipeLeftButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PowerButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoorButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeDownButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeUpButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainWatch As System.Windows.Forms.Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    'Friend WithEvents MainWatch As System.Windows.Forms.Panel
    Friend WithEvents HomeButton As System.Windows.Forms.Button
    Friend WithEvents NewMsgEventPic As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

    Friend WithEvents DoorButton As System.Windows.Forms.PictureBox
    Friend WithEvents PowerButton As System.Windows.Forms.PictureBox
    Friend WithEvents SwipeLeftButton As System.Windows.Forms.PictureBox
    Friend WithEvents SwipeRightButton As System.Windows.Forms.PictureBox
    Friend WithEvents SwipeUpButton As System.Windows.Forms.PictureBox
    Friend WithEvents SwipeDown As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorMsg As System.Windows.Forms.Label
    Friend WithEvents Reminder As System.Windows.Forms.Label
    Friend WithEvents VolumeDownButton As System.Windows.Forms.PictureBox
    Friend WithEvents VolumeUpButton As System.Windows.Forms.PictureBox
    Friend WithEvents Clock1 As AnalogClock.Clock

End Class
