<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectMsgType
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
        Me.VidPicBox = New System.Windows.Forms.PictureBox()
        Me.ImgPicBox = New System.Windows.Forms.PictureBox()
        Me.MsgPicBox = New System.Windows.Forms.PictureBox()
        CType(Me.VidPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsgPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VidPicBox
        '
        Me.VidPicBox.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.video
        Me.VidPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VidPicBox.Location = New System.Drawing.Point(59, 60)
        Me.VidPicBox.Name = "VidPicBox"
        Me.VidPicBox.Size = New System.Drawing.Size(50, 50)
        Me.VidPicBox.TabIndex = 2
        Me.VidPicBox.TabStop = False
        '
        'ImgPicBox
        '
        Me.ImgPicBox.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.image
        Me.ImgPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImgPicBox.Location = New System.Drawing.Point(3, 60)
        Me.ImgPicBox.Name = "ImgPicBox"
        Me.ImgPicBox.Size = New System.Drawing.Size(50, 50)
        Me.ImgPicBox.TabIndex = 1
        Me.ImgPicBox.TabStop = False
        '
        'MsgPicBox
        '
        Me.MsgPicBox.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.msg
        Me.MsgPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MsgPicBox.Location = New System.Drawing.Point(34, 4)
        Me.MsgPicBox.Name = "MsgPicBox"
        Me.MsgPicBox.Size = New System.Drawing.Size(50, 50)
        Me.MsgPicBox.TabIndex = 0
        Me.MsgPicBox.TabStop = False
        '
        'SelectMsgType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.VidPicBox)
        Me.Controls.Add(Me.ImgPicBox)
        Me.Controls.Add(Me.MsgPicBox)
        Me.Name = "SelectMsgType"
        Me.Size = New System.Drawing.Size(113, 113)
        CType(Me.VidPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsgPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MsgPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents ImgPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents VidPicBox As System.Windows.Forms.PictureBox

End Class
