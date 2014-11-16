<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendMsg
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Contact3 = New System.Windows.Forms.Button()
        Me.Contact2 = New System.Windows.Forms.Button()
        Me.Contact1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.BackColor = System.Drawing.Color.Transparent
        Me.NameLabel.Location = New System.Drawing.Point(30, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(54, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "To: Name"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.Color.Transparent
        Me.DateLabel.Location = New System.Drawing.Point(30, 14)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(53, 13)
        Me.DateLabel.TabIndex = 1
        Me.DateLabel.Text = "99/99/99"
        '
        'Contact3
        '
        Me.Contact3.BackColor = System.Drawing.SystemColors.Control
        Me.Contact3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Contact3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Contact3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Contact3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Contact3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.Contact3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Contact3.Location = New System.Drawing.Point(-1, 85)
        Me.Contact3.Name = "Contact3"
        Me.Contact3.Size = New System.Drawing.Size(113, 23)
        Me.Contact3.TabIndex = 6
        Me.Contact3.Text = "Yes, of course!"
        Me.Contact3.UseVisualStyleBackColor = False
        '
        'Contact2
        '
        Me.Contact2.BackColor = System.Drawing.SystemColors.Control
        Me.Contact2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Contact2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Contact2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Contact2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Contact2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.Contact2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Contact2.Location = New System.Drawing.Point(-1, 58)
        Me.Contact2.Name = "Contact2"
        Me.Contact2.Size = New System.Drawing.Size(113, 23)
        Me.Contact2.TabIndex = 5
        Me.Contact2.Text = "No, thank you."
        Me.Contact2.UseVisualStyleBackColor = False
        '
        'Contact1
        '
        Me.Contact1.BackColor = System.Drawing.SystemColors.Control
        Me.Contact1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Contact1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Contact1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Contact1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Contact1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.Contact1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Contact1.Location = New System.Drawing.Point(-1, 31)
        Me.Contact1.Name = "Contact1"
        Me.Contact1.Size = New System.Drawing.Size(113, 23)
        Me.Contact1.TabIndex = 4
        Me.Contact1.Text = "OK see you soon."
        Me.Contact1.UseVisualStyleBackColor = False
        '
        'SendMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.note_bg
        Me.Controls.Add(Me.Contact3)
        Me.Controls.Add(Me.Contact2)
        Me.Controls.Add(Me.Contact1)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Name = "SendMsg"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents Contact3 As System.Windows.Forms.Button
    Friend WithEvents Contact2 As System.Windows.Forms.Button
    Friend WithEvents Contact1 As System.Windows.Forms.Button

End Class
