<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiveCall
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
        Me.AnswerButton = New System.Windows.Forms.Button()
        Me.CallerName = New System.Windows.Forms.Label()
        Me.CallingLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AnswerButton
        '
        Me.AnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AnswerButton.Location = New System.Drawing.Point(-1, 89)
        Me.AnswerButton.Name = "AnswerButton"
        Me.AnswerButton.Size = New System.Drawing.Size(113, 23)
        Me.AnswerButton.TabIndex = 5
        Me.AnswerButton.Text = "Answer"
        Me.AnswerButton.UseVisualStyleBackColor = True
        '
        'CallerName
        '
        Me.CallerName.AutoSize = True
        Me.CallerName.Location = New System.Drawing.Point(43, 22)
        Me.CallerName.Name = "CallerName"
        Me.CallerName.Size = New System.Drawing.Size(27, 13)
        Me.CallerName.TabIndex = 4
        Me.CallerName.Text = "Dad"
        '
        'CallingLabel
        '
        Me.CallingLabel.AutoSize = True
        Me.CallingLabel.Location = New System.Drawing.Point(35, 5)
        Me.CallingLabel.Name = "CallingLabel"
        Me.CallingLabel.Size = New System.Drawing.Size(50, 13)
        Me.CallingLabel.TabIndex = 3
        Me.CallingLabel.Text = "Call from "
        '
        'ReceiveCall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AnswerButton)
        Me.Controls.Add(Me.CallerName)
        Me.Controls.Add(Me.CallingLabel)
        Me.Name = "ReceiveCall"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AnswerButton As System.Windows.Forms.Button
    Friend WithEvents CallerName As System.Windows.Forms.Label
    Friend WithEvents CallingLabel As System.Windows.Forms.Label

End Class
