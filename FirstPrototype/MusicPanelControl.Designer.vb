<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MusicPanelControl
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
        Me.SongName = New System.Windows.Forms.Label()
        Me.RepeatButton = New System.Windows.Forms.PictureBox()
        Me.ShuffleButton = New System.Windows.Forms.PictureBox()
        Me.PreviousButton = New System.Windows.Forms.PictureBox()
        Me.NextButton = New System.Windows.Forms.PictureBox()
        Me.PlayButton = New System.Windows.Forms.PictureBox()
        Me.PauseButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.notify = New System.Windows.Forms.Label()
        CType(Me.RepeatButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShuffleButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviousButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PauseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SongName
        '
        Me.SongName.AutoSize = True
        Me.SongName.Location = New System.Drawing.Point(26, 49)
        Me.SongName.Name = "SongName"
        Me.SongName.Size = New System.Drawing.Size(60, 13)
        Me.SongName.TabIndex = 1
        Me.SongName.Text = "SongName"
        '
        'RepeatButton
        '
        Me.RepeatButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.repeat
        Me.RepeatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RepeatButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RepeatButton.Location = New System.Drawing.Point(63, 93)
        Me.RepeatButton.Name = "RepeatButton"
        Me.RepeatButton.Size = New System.Drawing.Size(20, 20)
        Me.RepeatButton.TabIndex = 7
        Me.RepeatButton.TabStop = False
        '
        'ShuffleButton
        '
        Me.ShuffleButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.shuffle
        Me.ShuffleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ShuffleButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShuffleButton.Location = New System.Drawing.Point(28, 93)
        Me.ShuffleButton.Name = "ShuffleButton"
        Me.ShuffleButton.Size = New System.Drawing.Size(20, 20)
        Me.ShuffleButton.TabIndex = 6
        Me.ShuffleButton.TabStop = False
        '
        'PreviousButton
        '
        Me.PreviousButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.previous
        Me.PreviousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PreviousButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PreviousButton.Location = New System.Drawing.Point(0, 65)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(28, 28)
        Me.PreviousButton.TabIndex = 5
        Me.PreviousButton.TabStop = False
        '
        'NextButton
        '
        Me.NextButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources._next
        Me.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NextButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextButton.Location = New System.Drawing.Point(84, 66)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(28, 28)
        Me.NextButton.TabIndex = 4
        Me.NextButton.TabStop = False
        '
        'PlayButton
        '
        Me.PlayButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.play
        Me.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlayButton.Location = New System.Drawing.Point(28, 66)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(28, 28)
        Me.PlayButton.TabIndex = 3
        Me.PlayButton.TabStop = False
        '
        'PauseButton
        '
        Me.PauseButton.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.pause
        Me.PauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PauseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PauseButton.Location = New System.Drawing.Point(56, 66)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(28, 28)
        Me.PauseButton.TabIndex = 2
        Me.PauseButton.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.artist_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(32, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'notify
        '
        Me.notify.AutoSize = True
        Me.notify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.notify.Location = New System.Drawing.Point(33, 19)
        Me.notify.Name = "notify"
        Me.notify.Size = New System.Drawing.Size(41, 15)
        Me.notify.TabIndex = 8
        Me.notify.Text = "Label1"
        Me.notify.Visible = False
        '
        'MusicPanelControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.notify)
        Me.Controls.Add(Me.RepeatButton)
        Me.Controls.Add(Me.ShuffleButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.SongName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MusicPanelControl"
        Me.Size = New System.Drawing.Size(113, 113)
        CType(Me.RepeatButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShuffleButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviousButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PauseButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SongName As System.Windows.Forms.Label
    Friend WithEvents PauseButton As System.Windows.Forms.PictureBox
    Friend WithEvents PlayButton As System.Windows.Forms.PictureBox
    Friend WithEvents NextButton As System.Windows.Forms.PictureBox
    Friend WithEvents PreviousButton As System.Windows.Forms.PictureBox
    Friend WithEvents ShuffleButton As System.Windows.Forms.PictureBox
    Friend WithEvents RepeatButton As System.Windows.Forms.PictureBox
    Friend WithEvents notify As System.Windows.Forms.Label

End Class
