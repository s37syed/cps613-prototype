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
        Me.MainWatch = New System.Windows.Forms.Panel()
        Me.Reminder = New System.Windows.Forms.Label()
        Me.ErrorMsg = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PowerOffButton = New System.Windows.Forms.Button()
        Me.ButtonSwipeLeft = New System.Windows.Forms.Button()
        Me.ButtonSwipeDown = New System.Windows.Forms.Button()
        Me.ButtonSwipeUp = New System.Windows.Forms.Button()
        Me.ButtonSwipeRight = New System.Windows.Forms.Button()
        Me.VolumeUpButton = New System.Windows.Forms.Button()
        Me.VolumeDownButton = New System.Windows.Forms.Button()
        Me.NewMsgEventPic = New System.Windows.Forms.PictureBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainWatch.SuspendLayout()
        CType(Me.NewMsgEventPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Reminder.Size = New System.Drawing.Size(108, 15)
        Me.Reminder.TabIndex = 12
        Me.Reminder.Text = "REMINDER ALERT!"
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
        'PowerOffButton
        '
        Me.PowerOffButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.power_off
        Me.PowerOffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PowerOffButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PowerOffButton.Location = New System.Drawing.Point(21, 185)
        Me.PowerOffButton.Name = "PowerOffButton"
        Me.PowerOffButton.Size = New System.Drawing.Size(45, 45)
        Me.PowerOffButton.TabIndex = 21
        Me.PowerOffButton.UseVisualStyleBackColor = True
        '
        'ButtonSwipeLeft
        '
        Me.ButtonSwipeLeft.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.swipe_left
        Me.ButtonSwipeLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSwipeLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSwipeLeft.Location = New System.Drawing.Point(21, 94)
        Me.ButtonSwipeLeft.Name = "ButtonSwipeLeft"
        Me.ButtonSwipeLeft.Size = New System.Drawing.Size(45, 45)
        Me.ButtonSwipeLeft.TabIndex = 20
        Me.ButtonSwipeLeft.UseVisualStyleBackColor = True
        '
        'ButtonSwipeDown
        '
        Me.ButtonSwipeDown.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.swipe_down
        Me.ButtonSwipeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSwipeDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSwipeDown.Location = New System.Drawing.Point(124, 185)
        Me.ButtonSwipeDown.Name = "ButtonSwipeDown"
        Me.ButtonSwipeDown.Size = New System.Drawing.Size(45, 45)
        Me.ButtonSwipeDown.TabIndex = 19
        Me.ButtonSwipeDown.UseVisualStyleBackColor = True
        '
        'ButtonSwipeUp
        '
        Me.ButtonSwipeUp.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.swipe_up
        Me.ButtonSwipeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSwipeUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSwipeUp.Location = New System.Drawing.Point(124, 11)
        Me.ButtonSwipeUp.Name = "ButtonSwipeUp"
        Me.ButtonSwipeUp.Size = New System.Drawing.Size(45, 45)
        Me.ButtonSwipeUp.TabIndex = 18
        Me.ButtonSwipeUp.UseVisualStyleBackColor = True
        '
        'ButtonSwipeRight
        '
        Me.ButtonSwipeRight.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.swipe_right
        Me.ButtonSwipeRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSwipeRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSwipeRight.Location = New System.Drawing.Point(212, 94)
        Me.ButtonSwipeRight.Name = "ButtonSwipeRight"
        Me.ButtonSwipeRight.Size = New System.Drawing.Size(45, 45)
        Me.ButtonSwipeRight.TabIndex = 17
        Me.ButtonSwipeRight.UseVisualStyleBackColor = True
        '
        'VolumeUpButton
        '
        Me.VolumeUpButton.BackColor = System.Drawing.Color.Transparent
        Me.VolumeUpButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.volume_loud
        Me.VolumeUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VolumeUpButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VolumeUpButton.Location = New System.Drawing.Point(239, 197)
        Me.VolumeUpButton.Name = "VolumeUpButton"
        Me.VolumeUpButton.Size = New System.Drawing.Size(33, 33)
        Me.VolumeUpButton.TabIndex = 16
        Me.VolumeUpButton.UseVisualStyleBackColor = False
        '
        'VolumeDownButton
        '
        Me.VolumeDownButton.BackColor = System.Drawing.Color.Transparent
        Me.VolumeDownButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.volume_silent
        Me.VolumeDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VolumeDownButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VolumeDownButton.Location = New System.Drawing.Point(200, 197)
        Me.VolumeDownButton.Name = "VolumeDownButton"
        Me.VolumeDownButton.Size = New System.Drawing.Size(33, 33)
        Me.VolumeDownButton.TabIndex = 15
        Me.VolumeDownButton.UseVisualStyleBackColor = False
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 240)
        Me.Controls.Add(Me.PowerOffButton)
        Me.Controls.Add(Me.ButtonSwipeLeft)
        Me.Controls.Add(Me.ButtonSwipeDown)
        Me.Controls.Add(Me.ButtonSwipeUp)
        Me.Controls.Add(Me.ButtonSwipeRight)
        Me.Controls.Add(Me.VolumeUpButton)
        Me.Controls.Add(Me.VolumeDownButton)
        Me.Controls.Add(Me.MainWatch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main"
        Me.Text = "Prototype B1"
        Me.MainWatch.ResumeLayout(False)
        Me.MainWatch.PerformLayout()
        CType(Me.NewMsgEventPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainWatch As System.Windows.Forms.Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    'Friend WithEvents MainWatch As System.Windows.Forms.Panel
    Friend WithEvents HomeButton As System.Windows.Forms.Button
    Friend WithEvents NewMsgEventPic As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

    Friend WithEvents ErrorMsg As System.Windows.Forms.Label
    Friend WithEvents Reminder As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents VolumeDownButton As System.Windows.Forms.Button
    Friend WithEvents VolumeUpButton As System.Windows.Forms.Button
    Friend WithEvents ButtonSwipeRight As System.Windows.Forms.Button
    Friend WithEvents ButtonSwipeUp As System.Windows.Forms.Button
    Friend WithEvents ButtonSwipeDown As System.Windows.Forms.Button
    Friend WithEvents ButtonSwipeLeft As System.Windows.Forms.Button
    Friend WithEvents PowerOffButton As System.Windows.Forms.Button

End Class
