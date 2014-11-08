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
        Me.SwipeUpButton = New System.Windows.Forms.Button()
        Me.SwipeLeftButton = New System.Windows.Forms.Button()
        Me.SwipeDownButton = New System.Windows.Forms.Button()
        Me.SwipeRightButton = New System.Windows.Forms.Button()
        Me.VolumeUpButton = New System.Windows.Forms.Button()
        Me.VolumeDownButton = New System.Windows.Forms.Button()
        Me.PowerButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.MainWatch = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'SwipeUpButton
        '
        Me.SwipeUpButton.Location = New System.Drawing.Point(108, 20)
        Me.SwipeUpButton.Name = "SwipeUpButton"
        Me.SwipeUpButton.Size = New System.Drawing.Size(75, 23)
        Me.SwipeUpButton.TabIndex = 2
        Me.SwipeUpButton.Text = "SwipeUp"
        Me.SwipeUpButton.UseVisualStyleBackColor = True
        '
        'SwipeLeftButton
        '
        Me.SwipeLeftButton.Location = New System.Drawing.Point(6, 94)
        Me.SwipeLeftButton.Name = "SwipeLeftButton"
        Me.SwipeLeftButton.Size = New System.Drawing.Size(75, 23)
        Me.SwipeLeftButton.TabIndex = 3
        Me.SwipeLeftButton.Text = "SwipeLeft"
        Me.SwipeLeftButton.UseVisualStyleBackColor = True
        '
        'SwipeDownButton
        '
        Me.SwipeDownButton.Location = New System.Drawing.Point(108, 168)
        Me.SwipeDownButton.Name = "SwipeDownButton"
        Me.SwipeDownButton.Size = New System.Drawing.Size(75, 23)
        Me.SwipeDownButton.TabIndex = 4
        Me.SwipeDownButton.Text = "SwipeDown"
        Me.SwipeDownButton.UseVisualStyleBackColor = True
        '
        'SwipeRightButton
        '
        Me.SwipeRightButton.Location = New System.Drawing.Point(206, 94)
        Me.SwipeRightButton.Name = "SwipeRightButton"
        Me.SwipeRightButton.Size = New System.Drawing.Size(75, 23)
        Me.SwipeRightButton.TabIndex = 5
        Me.SwipeRightButton.Text = "SwipeRight"
        Me.SwipeRightButton.UseVisualStyleBackColor = True
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
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(108, 205)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 9
        Me.HomeButton.Text = "Door"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'MainWatch
        '
        Me.MainWatch.Location = New System.Drawing.Point(87, 49)
        Me.MainWatch.Name = "MainWatch"
        Me.MainWatch.Size = New System.Drawing.Size(113, 113)
        Me.MainWatch.TabIndex = 10
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 240)
        Me.Controls.Add(Me.MainWatch)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.PowerButton)
        Me.Controls.Add(Me.VolumeDownButton)
        Me.Controls.Add(Me.VolumeUpButton)
        Me.Controls.Add(Me.SwipeRightButton)
        Me.Controls.Add(Me.SwipeDownButton)
        Me.Controls.Add(Me.SwipeLeftButton)
        Me.Controls.Add(Me.SwipeUpButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main"
        Me.Text = "Prototype B1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SwipeUpButton As System.Windows.Forms.Button
    Friend WithEvents SwipeLeftButton As System.Windows.Forms.Button
    Friend WithEvents SwipeDownButton As System.Windows.Forms.Button
    Friend WithEvents SwipeRightButton As System.Windows.Forms.Button
    Friend WithEvents VolumeUpButton As System.Windows.Forms.Button
    Friend WithEvents VolumeDownButton As System.Windows.Forms.Button
    Friend WithEvents PowerButton As System.Windows.Forms.Button
    Friend WithEvents HomeButton As System.Windows.Forms.Button
    Friend WithEvents MainWatch As System.Windows.Forms.Panel

End Class
