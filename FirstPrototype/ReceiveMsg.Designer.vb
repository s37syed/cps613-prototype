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
        Me.TempTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'ContactName
        '
        Me.ContactName.AutoSize = True
        Me.ContactName.Location = New System.Drawing.Point(39, 3)
        Me.ContactName.Name = "ContactName"
        Me.ContactName.Size = New System.Drawing.Size(35, 13)
        Me.ContactName.TabIndex = 1
        Me.ContactName.Text = "Name"
        '
        'TempTextBox
        '
        Me.TempTextBox.Location = New System.Drawing.Point(17, 19)
        Me.TempTextBox.MaxLength = 160
        Me.TempTextBox.Name = "TempTextBox"
        Me.TempTextBox.Size = New System.Drawing.Size(96, 94)
        Me.TempTextBox.TabIndex = 2
        Me.TempTextBox.Text = resources.GetString("TempTextBox.Text")
        '
        'ReceiveMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TempTextBox)
        Me.Controls.Add(Me.ContactName)
        Me.Name = "ReceiveMsg"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContactName As System.Windows.Forms.Label
    Friend WithEvents TempTextBox As System.Windows.Forms.RichTextBox

End Class
