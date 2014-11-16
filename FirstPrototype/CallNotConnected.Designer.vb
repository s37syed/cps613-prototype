<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CallNotConnected
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
        Me.CallNotConnectedLabel = New System.Windows.Forms.Label()
        Me.LeaveMessageButton = New System.Windows.Forms.Button()
        Me.RedialButton = New System.Windows.Forms.Button()
        Me.LeaveMsgText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CallNotConnectedLabel
        '
        Me.CallNotConnectedLabel.AutoSize = True
        Me.CallNotConnectedLabel.Location = New System.Drawing.Point(18, 10)
        Me.CallNotConnectedLabel.Name = "CallNotConnectedLabel"
        Me.CallNotConnectedLabel.Size = New System.Drawing.Size(77, 26)
        Me.CallNotConnectedLabel.TabIndex = 0
        Me.CallNotConnectedLabel.Text = "Call Could Not " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Be Completed"
        '
        'LeaveMessageButton
        '
        Me.LeaveMessageButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LeaveMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LeaveMessageButton.Location = New System.Drawing.Point(-1, 61)
        Me.LeaveMessageButton.Name = "LeaveMessageButton"
        Me.LeaveMessageButton.Size = New System.Drawing.Size(113, 23)
        Me.LeaveMessageButton.TabIndex = 1
        Me.LeaveMessageButton.Text = "Leave Message"
        Me.LeaveMessageButton.UseVisualStyleBackColor = True
        '
        'RedialButton
        '
        Me.RedialButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RedialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RedialButton.Location = New System.Drawing.Point(-1, 89)
        Me.RedialButton.Name = "RedialButton"
        Me.RedialButton.Size = New System.Drawing.Size(113, 23)
        Me.RedialButton.TabIndex = 2
        Me.RedialButton.Text = "Redial"
        Me.RedialButton.UseVisualStyleBackColor = True
        '
        'LeaveMsgText
        '
        Me.LeaveMsgText.AutoSize = True
        Me.LeaveMsgText.BackColor = System.Drawing.Color.Transparent
        Me.LeaveMsgText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LeaveMsgText.Location = New System.Drawing.Point(5, 40)
        Me.LeaveMsgText.Name = "LeaveMsgText"
        Me.LeaveMsgText.Size = New System.Drawing.Size(104, 15)
        Me.LeaveMsgText.TabIndex = 3
        Me.LeaveMsgText.Text = "Leaving a message!"
        Me.LeaveMsgText.Visible = False
        '
        'CallNotConnected
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LeaveMsgText)
        Me.Controls.Add(Me.RedialButton)
        Me.Controls.Add(Me.LeaveMessageButton)
        Me.Controls.Add(Me.CallNotConnectedLabel)
        Me.Name = "CallNotConnected"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CallNotConnectedLabel As System.Windows.Forms.Label
    Friend WithEvents LeaveMessageButton As System.Windows.Forms.Button
    Friend WithEvents RedialButton As System.Windows.Forms.Button
    Friend WithEvents LeaveMsgText As System.Windows.Forms.Label

End Class
