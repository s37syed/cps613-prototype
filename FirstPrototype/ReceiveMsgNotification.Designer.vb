<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiveMsgNotification
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
        Me.TransparentRichTextBox1 = New FirstPrototype.TransparentRichTextBox()
        Me.ContactName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TransparentRichTextBox1
        '
        Me.TransparentRichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TransparentRichTextBox1.Location = New System.Drawing.Point(16, 21)
        Me.TransparentRichTextBox1.Name = "TransparentRichTextBox1"
        Me.TransparentRichTextBox1.ReadOnly = True
        Me.TransparentRichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TransparentRichTextBox1.ShortcutsEnabled = False
        Me.TransparentRichTextBox1.Size = New System.Drawing.Size(97, 94)
        Me.TransparentRichTextBox1.TabIndex = 4
        Me.TransparentRichTextBox1.Text = "This is a message."
        '
        'ContactName
        '
        Me.ContactName.AutoSize = True
        Me.ContactName.BackColor = System.Drawing.Color.Transparent
        Me.ContactName.Location = New System.Drawing.Point(39, 3)
        Me.ContactName.Name = "ContactName"
        Me.ContactName.Size = New System.Drawing.Size(35, 13)
        Me.ContactName.TabIndex = 3
        Me.ContactName.Text = "Name"
        '
        'ReceiveMsgNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.note_bg
        Me.Controls.Add(Me.TransparentRichTextBox1)
        Me.Controls.Add(Me.ContactName)
        Me.Name = "ReceiveMsgNotification"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TransparentRichTextBox1 As FirstPrototype.TransparentRichTextBox
    Friend WithEvents ContactName As System.Windows.Forms.Label

End Class
