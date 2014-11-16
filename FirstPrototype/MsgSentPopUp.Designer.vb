<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgSentPopUp
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
        Me.Msg1 = New System.Windows.Forms.Label()
        Me.Msg2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Msg1
        '
        Me.Msg1.AutoSize = True
        Me.Msg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Msg1.Location = New System.Drawing.Point(10, 14)
        Me.Msg1.Name = "Msg1"
        Me.Msg1.Size = New System.Drawing.Size(93, 25)
        Me.Msg1.TabIndex = 0
        Me.Msg1.Text = "Message"
        '
        'Msg2
        '
        Me.Msg2.AutoSize = True
        Me.Msg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Msg2.Location = New System.Drawing.Point(27, 66)
        Me.Msg2.Name = "Msg2"
        Me.Msg2.Size = New System.Drawing.Size(59, 25)
        Me.Msg2.TabIndex = 1
        Me.Msg2.Text = "Sent!"
        '
        'MsgSentPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Msg2)
        Me.Controls.Add(Me.Msg1)
        Me.Name = "MsgSentPopUp"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Msg1 As System.Windows.Forms.Label
    Friend WithEvents Msg2 As System.Windows.Forms.Label

End Class
