<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CallConnected
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
        Me.CallConnectedLabel = New System.Windows.Forms.Label()
        Me.ContactNameLabel = New System.Windows.Forms.Label()
        Me.ConnectedHangUpButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CallConnectedLabel
        '
        Me.CallConnectedLabel.AutoSize = True
        Me.CallConnectedLabel.Location = New System.Drawing.Point(27, 9)
        Me.CallConnectedLabel.Name = "CallConnectedLabel"
        Me.CallConnectedLabel.Size = New System.Drawing.Size(59, 13)
        Me.CallConnectedLabel.TabIndex = 0
        Me.CallConnectedLabel.Text = "Connected"
        '
        'ContactNameLabel
        '
        Me.ContactNameLabel.AutoSize = True
        Me.ContactNameLabel.Location = New System.Drawing.Point(37, 35)
        Me.ContactNameLabel.Name = "ContactNameLabel"
        Me.ContactNameLabel.Size = New System.Drawing.Size(39, 13)
        Me.ContactNameLabel.TabIndex = 1
        Me.ContactNameLabel.Text = "Label2"
        '
        'ConnectedHangUpButton
        '
        Me.ConnectedHangUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectedHangUpButton.Location = New System.Drawing.Point(-1, 89)
        Me.ConnectedHangUpButton.Name = "ConnectedHangUpButton"
        Me.ConnectedHangUpButton.Size = New System.Drawing.Size(113, 23)
        Me.ConnectedHangUpButton.TabIndex = 2
        Me.ConnectedHangUpButton.Text = "Hang Up"
        Me.ConnectedHangUpButton.UseVisualStyleBackColor = True
        '
        'CallConnected
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ConnectedHangUpButton)
        Me.Controls.Add(Me.ContactNameLabel)
        Me.Controls.Add(Me.CallConnectedLabel)
        Me.Name = "CallConnected"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CallConnectedLabel As System.Windows.Forms.Label
    Friend WithEvents ContactNameLabel As System.Windows.Forms.Label
    Friend WithEvents ConnectedHangUpButton As System.Windows.Forms.Button

End Class
