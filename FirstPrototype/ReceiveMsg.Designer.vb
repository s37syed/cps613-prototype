<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiveMsg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReceiveMsg))
        Me.ContactName = New System.Windows.Forms.Label()
        Me.TransparentTextBox = New FirstPrototype.TransparentRichTextBox()
        Me.SuspendLayout()
        '
        'ContactName
        '
        Me.ContactName.AutoSize = True
        Me.ContactName.BackColor = System.Drawing.Color.Transparent
        Me.ContactName.Location = New System.Drawing.Point(39, 3)
        Me.ContactName.Name = "ContactName"
        Me.ContactName.Size = New System.Drawing.Size(35, 13)
        Me.ContactName.TabIndex = 1
        Me.ContactName.Text = "Name"
        '
        'TransparentTextBox
        '
        Me.TransparentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TransparentTextBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.TransparentTextBox.Location = New System.Drawing.Point(17, 21)
        Me.TransparentTextBox.MaxLength = 160
        Me.TransparentTextBox.Name = "TransparentTextBox"
        Me.TransparentTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TransparentTextBox.Size = New System.Drawing.Size(96, 94)
        Me.TransparentTextBox.TabIndex = 4
        Me.TransparentTextBox.Text = resources.GetString("TransparentTextBox.Text")
        '
        'ReceiveMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.note_bg
        Me.Controls.Add(Me.TransparentTextBox)
        Me.Controls.Add(Me.ContactName)
        Me.Name = "ReceiveMsg"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContactName As System.Windows.Forms.Label
    Friend WithEvents TransparentTextBox As FirstPrototype.TransparentRichTextBox

End Class
