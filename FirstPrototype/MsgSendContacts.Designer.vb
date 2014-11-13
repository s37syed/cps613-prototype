<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgSendContacts
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
        Me.PhoneContact3 = New System.Windows.Forms.Button()
        Me.PhoneContact2 = New System.Windows.Forms.Button()
        Me.PhoneContact1 = New System.Windows.Forms.Button()
        Me.PhoneContact0 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PhoneContact3
        '
        Me.PhoneContact3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PhoneContact3.Location = New System.Drawing.Point(0, 84)
        Me.PhoneContact3.Name = "PhoneContact3"
        Me.PhoneContact3.Size = New System.Drawing.Size(113, 23)
        Me.PhoneContact3.TabIndex = 7
        Me.PhoneContact3.Text = "Button4"
        Me.PhoneContact3.UseVisualStyleBackColor = True
        '
        'PhoneContact2
        '
        Me.PhoneContact2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PhoneContact2.Location = New System.Drawing.Point(0, 57)
        Me.PhoneContact2.Name = "PhoneContact2"
        Me.PhoneContact2.Size = New System.Drawing.Size(113, 23)
        Me.PhoneContact2.TabIndex = 6
        Me.PhoneContact2.Text = "Button3"
        Me.PhoneContact2.UseVisualStyleBackColor = True
        '
        'PhoneContact1
        '
        Me.PhoneContact1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PhoneContact1.Location = New System.Drawing.Point(0, 30)
        Me.PhoneContact1.Name = "PhoneContact1"
        Me.PhoneContact1.Size = New System.Drawing.Size(113, 23)
        Me.PhoneContact1.TabIndex = 5
        Me.PhoneContact1.Text = "Button2"
        Me.PhoneContact1.UseVisualStyleBackColor = True
        '
        'PhoneContact0
        '
        Me.PhoneContact0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PhoneContact0.Location = New System.Drawing.Point(0, 3)
        Me.PhoneContact0.Name = "PhoneContact0"
        Me.PhoneContact0.Size = New System.Drawing.Size(113, 23)
        Me.PhoneContact0.TabIndex = 4
        Me.PhoneContact0.Text = "Button1"
        Me.PhoneContact0.UseVisualStyleBackColor = True
        '
        'MsgSendContacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PhoneContact3)
        Me.Controls.Add(Me.PhoneContact2)
        Me.Controls.Add(Me.PhoneContact1)
        Me.Controls.Add(Me.PhoneContact0)
        Me.Name = "MsgSendContacts"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PhoneContact3 As System.Windows.Forms.Button
    Friend WithEvents PhoneContact2 As System.Windows.Forms.Button
    Friend WithEvents PhoneContact1 As System.Windows.Forms.Button
    Friend WithEvents PhoneContact0 As System.Windows.Forms.Button

End Class
