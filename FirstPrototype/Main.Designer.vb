﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.NewMsgEventPic = New System.Windows.Forms.PictureBox()
        Me.VolumeUpButton = New System.Windows.Forms.Button()
        Me.VolumeDownButton = New System.Windows.Forms.Button()
        Me.PowerButton = New System.Windows.Forms.Button()
        Me.DoorButton = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SwipeRightButton = New System.Windows.Forms.PictureBox()
        Me.SwipeLeftButton = New System.Windows.Forms.PictureBox()
        Me.SwipeUpButton = New System.Windows.Forms.PictureBox()
        Me.SwipeDown = New System.Windows.Forms.PictureBox()
        Me.MainWatch.SuspendLayout()
        CType(Me.NewMsgEventPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwipeRightButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwipeLeftButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwipeUpButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwipeDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainWatch
        '
        Me.MainWatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainWatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainWatch.Controls.Add(Me.NewMsgEventPic)
        Me.MainWatch.Location = New System.Drawing.Point(87, 49)
        Me.MainWatch.Name = "MainWatch"
        Me.MainWatch.Size = New System.Drawing.Size(113, 113)
        Me.MainWatch.TabIndex = 1
        '
        'NewMsgEventPic
        '
        Me.NewMsgEventPic.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.NewMsgPrompt
        Me.NewMsgEventPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NewMsgEventPic.Location = New System.Drawing.Point(-1, -1)
        Me.NewMsgEventPic.Name = "NewMsgEventPic"
        Me.NewMsgEventPic.Size = New System.Drawing.Size(113, 113)
        Me.NewMsgEventPic.TabIndex = 10
        Me.NewMsgEventPic.TabStop = False
        Me.NewMsgEventPic.Visible = False
        '
        'VolumeUpButton
        '
        Me.VolumeUpButton.Location = New System.Drawing.Point(236, 205)
        Me.VolumeUpButton.Name = "VolumeUpButton"
        Me.VolumeUpButton.Size = New System.Drawing.Size(23, 23)
        Me.VolumeUpButton.TabIndex = 6
        Me.VolumeUpButton.Text = "+"
        Me.VolumeUpButton.UseVisualStyleBackColor = True
        '
        'VolumeDownButton
        '
        Me.VolumeDownButton.Location = New System.Drawing.Point(206, 205)
        Me.VolumeDownButton.Name = "VolumeDownButton"
        Me.VolumeDownButton.Size = New System.Drawing.Size(23, 23)
        Me.VolumeDownButton.TabIndex = 7
        Me.VolumeDownButton.Text = "-"
        Me.VolumeDownButton.UseVisualStyleBackColor = True
        '
        'PowerButton
        '
        Me.PowerButton.Location = New System.Drawing.Point(12, 205)
        Me.PowerButton.Name = "PowerButton"
        Me.PowerButton.Size = New System.Drawing.Size(75, 23)
        Me.PowerButton.TabIndex = 8
        Me.PowerButton.Text = "Power"
        Me.PowerButton.UseVisualStyleBackColor = True
        '
        'DoorButton
        '
        Me.DoorButton.Location = New System.Drawing.Point(111, 205)
        Me.DoorButton.Name = "DoorButton"
        Me.DoorButton.Size = New System.Drawing.Size(75, 23)
        Me.DoorButton.TabIndex = 9
        Me.DoorButton.Text = "Door"
        Me.DoorButton.UseVisualStyleBackColor = True
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
        'SwipeRightButton
        '
        Me.SwipeRightButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.swipe_right
        Me.SwipeRightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SwipeRightButton.Location = New System.Drawing.Point(248, 84)
        Me.SwipeRightButton.Name = "SwipeRightButton"
        Me.SwipeRightButton.Size = New System.Drawing.Size(33, 33)
        Me.SwipeRightButton.TabIndex = 10
        Me.SwipeRightButton.TabStop = False
        '
        'SwipeLeftButton
        '
        Me.SwipeLeftButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.swipe_left
        Me.SwipeLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SwipeLeftButton.Location = New System.Drawing.Point(12, 84)
        Me.SwipeLeftButton.Name = "SwipeLeftButton"
        Me.SwipeLeftButton.Size = New System.Drawing.Size(33, 33)
        Me.SwipeLeftButton.TabIndex = 11
        Me.SwipeLeftButton.TabStop = False
        '
        'SwipeUpButton
        '
        Me.SwipeUpButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.swipe_up
        Me.SwipeUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SwipeUpButton.Location = New System.Drawing.Point(129, 10)
        Me.SwipeUpButton.Name = "SwipeUpButton"
        Me.SwipeUpButton.Size = New System.Drawing.Size(33, 33)
        Me.SwipeUpButton.TabIndex = 12
        Me.SwipeUpButton.TabStop = False
        '
        'SwipeDown
        '
        Me.SwipeDown.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.swipe_down
        Me.SwipeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SwipeDown.Location = New System.Drawing.Point(129, 166)
        Me.SwipeDown.Name = "SwipeDown"
        Me.SwipeDown.Size = New System.Drawing.Size(33, 33)
        Me.SwipeDown.TabIndex = 13
        Me.SwipeDown.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 240)
        Me.Controls.Add(Me.SwipeDown)
        Me.Controls.Add(Me.SwipeUpButton)
        Me.Controls.Add(Me.SwipeLeftButton)
        Me.Controls.Add(Me.SwipeRightButton)
        Me.Controls.Add(Me.DoorButton)
        Me.Controls.Add(Me.PowerButton)
        Me.Controls.Add(Me.VolumeDownButton)
        Me.Controls.Add(Me.VolumeUpButton)
        Me.Controls.Add(Me.MainWatch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main"
        Me.Text = "Prototype B1"
        Me.MainWatch.ResumeLayout(False)
        CType(Me.NewMsgEventPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwipeRightButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwipeLeftButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwipeUpButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwipeDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainWatch As System.Windows.Forms.Panel
    Friend WithEvents VolumeUpButton As System.Windows.Forms.Button
    Friend WithEvents VolumeDownButton As System.Windows.Forms.Button
    Friend WithEvents PowerButton As System.Windows.Forms.Button
    Friend WithEvents DoorButton As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    'Friend WithEvents MainWatch As System.Windows.Forms.Panel
    Friend WithEvents HomeButton As System.Windows.Forms.Button
    Friend WithEvents NewMsgEventPic As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SwipeRightButton As System.Windows.Forms.PictureBox
    Friend WithEvents SwipeLeftButton As System.Windows.Forms.PictureBox
    Friend WithEvents SwipeUpButton As System.Windows.Forms.PictureBox
    Friend WithEvents SwipeDown As System.Windows.Forms.PictureBox

End Class
