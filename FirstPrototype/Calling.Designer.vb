<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calling
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
        Me.CallingLabel = New System.Windows.Forms.Label()
        Me.ContactName = New System.Windows.Forms.Label()
        Me.HangUp = New System.Windows.Forms.Button()
        Me.CallingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'CallingLabel
        '
        Me.CallingLabel.AutoSize = True
        Me.CallingLabel.Location = New System.Drawing.Point(34, 10)
        Me.CallingLabel.Name = "CallingLabel"
        Me.CallingLabel.Size = New System.Drawing.Size(47, 13)
        Me.CallingLabel.TabIndex = 0
        Me.CallingLabel.Text = "Calling..."
        '
        'ContactName
        '
        Me.ContactName.AutoSize = True
        Me.ContactName.Location = New System.Drawing.Point(37, 27)
        Me.ContactName.Name = "ContactName"
        Me.ContactName.Size = New System.Drawing.Size(39, 13)
        Me.ContactName.TabIndex = 1
        Me.ContactName.Text = "Label1"
        '
        'HangUp
        '
        Me.HangUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HangUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HangUp.Location = New System.Drawing.Point(-1, 89)
        Me.HangUp.Name = "HangUp"
        Me.HangUp.Size = New System.Drawing.Size(113, 23)
        Me.HangUp.TabIndex = 2
        Me.HangUp.Text = "Hang Up"
        Me.HangUp.UseVisualStyleBackColor = True
        '
        'CallingTimer
        '
        Me.CallingTimer.Interval = 1000
        '
        'Calling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.HangUp)
        Me.Controls.Add(Me.ContactName)
        Me.Controls.Add(Me.CallingLabel)
        Me.Name = "Calling"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CallingLabel As System.Windows.Forms.Label
    Friend WithEvents ContactName As System.Windows.Forms.Label
    Friend WithEvents HangUp As System.Windows.Forms.Button
    Friend WithEvents CallingTimer As System.Windows.Forms.Timer

End Class
