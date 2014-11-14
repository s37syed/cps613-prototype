<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Redialling
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
        Me.components = New System.ComponentModel.Container()
        Me.RedialLabel = New System.Windows.Forms.Label()
        Me.RedialingTimerLabel = New System.Windows.Forms.Label()
        Me.RedialTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'RedialLabel
        '
        Me.RedialLabel.AutoSize = True
        Me.RedialLabel.Location = New System.Drawing.Point(19, 9)
        Me.RedialLabel.Name = "RedialLabel"
        Me.RedialLabel.Size = New System.Drawing.Size(72, 26)
        Me.RedialLabel.TabIndex = 0
        Me.RedialLabel.Text = "Automatically " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Redialing in..."
        '
        'RedialingTimerLabel
        '
        Me.RedialingTimerLabel.AutoSize = True
        Me.RedialingTimerLabel.Location = New System.Drawing.Point(50, 51)
        Me.RedialingTimerLabel.Name = "RedialingTimerLabel"
        Me.RedialingTimerLabel.Size = New System.Drawing.Size(13, 13)
        Me.RedialingTimerLabel.TabIndex = 1
        Me.RedialingTimerLabel.Text = "5"
        '
        'RedialTimer
        '
        Me.RedialTimer.Interval = 1000
        '
        'CallNotConnected
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RedialingTimerLabel)
        Me.Controls.Add(Me.RedialLabel)
        Me.Name = "CallNotConnected"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RedialLabel As System.Windows.Forms.Label
    Friend WithEvents RedialingTimerLabel As System.Windows.Forms.Label
    Friend WithEvents RedialTimer As System.Windows.Forms.Timer

End Class
