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
        Me.ContactName = New System.Windows.Forms.Label()
        Me.ContactPhoto = New System.Windows.Forms.PictureBox()
        Me.ContactPhone = New System.Windows.Forms.PictureBox()
        Me.ContactMsg = New System.Windows.Forms.PictureBox()
        CType(Me.ContactPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactMsg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContactName
        '
        Me.ContactName.AutoSize = True
        Me.ContactName.Location = New System.Drawing.Point(39, 3)
        Me.ContactName.Name = "ContactName"
        Me.ContactName.Size = New System.Drawing.Size(35, 13)
        Me.ContactName.TabIndex = 0
        Me.ContactName.Text = "Name"
        '
        'ContactPhoto
        '
        Me.ContactPhoto.BackgroundImage = My.Resources.placeholder_image
        Me.ContactPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactPhoto.Location = New System.Drawing.Point(40, 19)
        Me.ContactPhoto.Name = "ContactPhoto"
        Me.ContactPhoto.Size = New System.Drawing.Size(33, 33)
        Me.ContactPhoto.TabIndex = 1
        Me.ContactPhoto.TabStop = False
        '
        'ContactPhone
        '
        Me.ContactPhone.BackgroundImage = My.Resources.placeholder_call
        Me.ContactPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactPhone.Location = New System.Drawing.Point(8, 58)
        Me.ContactPhone.Name = "ContactPhone"
        Me.ContactPhone.Size = New System.Drawing.Size(33, 33)
        Me.ContactPhone.TabIndex = 1
        Me.ContactPhone.TabStop = False
        '
        'ContactMsg
        '
        Me.ContactMsg.BackgroundImage = My.Resources.placeholder_text
        Me.ContactMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactMsg.Location = New System.Drawing.Point(72, 58)
        Me.ContactMsg.Name = "ContactMsg"
        Me.ContactMsg.Size = New System.Drawing.Size(33, 33)
        Me.ContactMsg.TabIndex = 1
        Me.ContactMsg.TabStop = False
        '
        'ContactScreen2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ContactPhone)
        Me.Controls.Add(Me.ContactMsg)
        Me.Controls.Add(Me.ContactPhoto)
        Me.Controls.Add(Me.ContactName)
        Me.Name = "ContactScreen2"
        Me.Size = New System.Drawing.Size(113, 113)
        CType(Me.ContactPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactMsg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContactName As System.Windows.Forms.Label
    Friend WithEvents ContactPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents ContactPhone As System.Windows.Forms.PictureBox
    Friend WithEvents ContactMsg As System.Windows.Forms.PictureBox

End Class
