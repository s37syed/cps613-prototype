<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactScreen
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
        Me.Contact1 = New System.Windows.Forms.Button()
        Me.Contact2 = New System.Windows.Forms.Button()
        Me.Contact3 = New System.Windows.Forms.Button()
        Me.Contact4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Contact1
        '
        Me.Contact1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Contact1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Contact1.Location = New System.Drawing.Point(-1, 4)
        Me.Contact1.Name = "Contact1"
        Me.Contact1.Size = New System.Drawing.Size(113, 23)
        Me.Contact1.TabIndex = 0
        Me.Contact1.Text = "Button 1"
        Me.Contact1.UseVisualStyleBackColor = True
        '
        'Contact2
        '
        Me.Contact2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Contact2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Contact2.Location = New System.Drawing.Point(-1, 31)
        Me.Contact2.Name = "Contact2"
        Me.Contact2.Size = New System.Drawing.Size(113, 23)
        Me.Contact2.TabIndex = 1
        Me.Contact2.Text = "Button2"
        Me.Contact2.UseVisualStyleBackColor = True
        '
        'Contact3
        '
        Me.Contact3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Contact3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Contact3.Location = New System.Drawing.Point(-1, 58)
        Me.Contact3.Name = "Contact3"
        Me.Contact3.Size = New System.Drawing.Size(113, 23)
        Me.Contact3.TabIndex = 2
        Me.Contact3.Text = "Button3"
        Me.Contact3.UseVisualStyleBackColor = True
        '
        'Contact4
        '
        Me.Contact4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Contact4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Contact4.Location = New System.Drawing.Point(-1, 85)
        Me.Contact4.Name = "Contact4"
        Me.Contact4.Size = New System.Drawing.Size(113, 23)
        Me.Contact4.TabIndex = 3
        Me.Contact4.Text = "Button4"
        Me.Contact4.UseVisualStyleBackColor = True
        '
        'ContactScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Contact4)
        Me.Controls.Add(Me.Contact3)
        Me.Controls.Add(Me.Contact2)
        Me.Controls.Add(Me.Contact1)
        Me.Name = "ContactScreen"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Contact1 As System.Windows.Forms.Button
    Friend WithEvents Contact2 As System.Windows.Forms.Button
    Friend WithEvents Contact3 As System.Windows.Forms.Button
    Friend WithEvents Contact4 As System.Windows.Forms.Button

End Class
