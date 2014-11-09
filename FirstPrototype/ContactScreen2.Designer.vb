<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactScreen2
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
        Me.Name8 = New System.Windows.Forms.Label()
        Me.Name7 = New System.Windows.Forms.Label()
        Me.Name6 = New System.Windows.Forms.Label()
        Me.Name5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Name8
        '
        Me.Name8.AutoSize = True
        Me.Name8.Location = New System.Drawing.Point(3, 92)
        Me.Name8.Name = "Name8"
        Me.Name8.Size = New System.Drawing.Size(67, 13)
        Me.Name8.TabIndex = 1
        Me.Name8.Text = "Drizzy Drake"
        '
        'Name7
        '
        Me.Name7.AutoSize = True
        Me.Name7.Location = New System.Drawing.Point(3, 65)
        Me.Name7.Name = "Name7"
        Me.Name7.Size = New System.Drawing.Size(45, 13)
        Me.Name7.TabIndex = 2
        Me.Name7.Text = "Danielle"
        '
        'Name6
        '
        Me.Name6.AutoSize = True
        Me.Name6.Location = New System.Drawing.Point(3, 38)
        Me.Name6.Name = "Name6"
        Me.Name6.Size = New System.Drawing.Size(35, 13)
        Me.Name6.TabIndex = 3
        Me.Name6.Text = "Butch"
        '
        'Name5
        '
        Me.Name5.AutoSize = True
        Me.Name5.Location = New System.Drawing.Point(3, 11)
        Me.Name5.Name = "Name5"
        Me.Name5.Size = New System.Drawing.Size(35, 13)
        Me.Name5.TabIndex = 4
        Me.Name5.Text = "Hogie"
        '
        'ContactScreen2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Name8)
        Me.Controls.Add(Me.Name7)
        Me.Controls.Add(Me.Name6)
        Me.Controls.Add(Me.Name5)
        Me.Name = "ContactScreen2"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Name8 As System.Windows.Forms.Label
    Friend WithEvents Name7 As System.Windows.Forms.Label
    Friend WithEvents Name6 As System.Windows.Forms.Label
    Friend WithEvents Name5 As System.Windows.Forms.Label

End Class
