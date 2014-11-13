<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CallChild
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
        Me.CallerName = New System.Windows.Forms.Label()
        Me.ParentHangUpButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CallerName
        '
        Me.CallerName.AutoSize = True
        Me.CallerName.Location = New System.Drawing.Point(78, 40)
        Me.CallerName.Name = "CallerName"
        Me.CallerName.Size = New System.Drawing.Size(39, 13)
        Me.CallerName.TabIndex = 0
        Me.CallerName.Text = "Label1"
        '
        'ParentHangUpButton
        '
        Me.ParentHangUpButton.Location = New System.Drawing.Point(63, 278)
        Me.ParentHangUpButton.Name = "ParentHangUpButton"
        Me.ParentHangUpButton.Size = New System.Drawing.Size(75, 23)
        Me.ParentHangUpButton.TabIndex = 1
        Me.ParentHangUpButton.Text = "Hang Up"
        Me.ParentHangUpButton.UseVisualStyleBackColor = True
        '
        'CallChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ParentHangUpButton)
        Me.Controls.Add(Me.CallerName)
        Me.Name = "CallChild"
        Me.Size = New System.Drawing.Size(210, 323)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CallerName As System.Windows.Forms.Label
    Friend WithEvents ParentHangUpButton As System.Windows.Forms.Button

End Class
