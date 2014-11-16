<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageOptions
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
        Me.DeleteMessage = New System.Windows.Forms.PictureBox()
        Me.NewMessage = New System.Windows.Forms.PictureBox()
        CType(Me.DeleteMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeleteMessage
        '
        Me.DeleteMessage.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.icon_delete_msg
        Me.DeleteMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DeleteMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeleteMessage.Location = New System.Drawing.Point(75, 0)
        Me.DeleteMessage.Name = "DeleteMessage"
        Me.DeleteMessage.Size = New System.Drawing.Size(33, 33)
        Me.DeleteMessage.TabIndex = 1
        Me.DeleteMessage.TabStop = False
        '
        'NewMessage
        '
        Me.NewMessage.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.icon_new_msg
        Me.NewMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NewMessage.Location = New System.Drawing.Point(5, 0)
        Me.NewMessage.Name = "NewMessage"
        Me.NewMessage.Size = New System.Drawing.Size(33, 33)
        Me.NewMessage.TabIndex = 0
        Me.NewMessage.TabStop = False
        '
        'MessageOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DeleteMessage)
        Me.Controls.Add(Me.NewMessage)
        Me.Name = "MessageOptions"
        Me.Size = New System.Drawing.Size(113, 33)
        CType(Me.DeleteMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NewMessage As System.Windows.Forms.PictureBox
    Friend WithEvents DeleteMessage As System.Windows.Forms.PictureBox

End Class
