<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CallContact
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
        Me.CallButton = New System.Windows.Forms.Button()
        Me.CallContactName = New System.Windows.Forms.Label()
        Me.CallContactNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CallButton
        '
        Me.CallButton.Location = New System.Drawing.Point(19, 87)
        Me.CallButton.Name = "CallButton"
        Me.CallButton.Size = New System.Drawing.Size(75, 23)
        Me.CallButton.TabIndex = 0
        Me.CallButton.Text = "Call"
        Me.CallButton.UseVisualStyleBackColor = True
        '
        'CallContactName
        '
        Me.CallContactName.AutoSize = True
        Me.CallContactName.Location = New System.Drawing.Point(37, 9)
        Me.CallContactName.Name = "CallContactName"
        Me.CallContactName.Size = New System.Drawing.Size(39, 13)
        Me.CallContactName.TabIndex = 1
        Me.CallContactName.Text = "Label1"
        '
        'CallContactNumber
        '
        Me.CallContactNumber.AutoSize = True
        Me.CallContactNumber.Location = New System.Drawing.Point(20, 47)
        Me.CallContactNumber.Name = "CallContactNumber"
        Me.CallContactNumber.Size = New System.Drawing.Size(73, 13)
        Me.CallContactNumber.TabIndex = 2
        Me.CallContactNumber.Text = "416-416-4166"
        '
        'CallContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CallContactNumber)
        Me.Controls.Add(Me.CallContactName)
        Me.Controls.Add(Me.CallButton)
        Me.Name = "CallContact"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CallButton As System.Windows.Forms.Button
    Friend WithEvents CallContactName As System.Windows.Forms.Label
    Friend WithEvents CallContactNumber As System.Windows.Forms.Label

End Class
