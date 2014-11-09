<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MusicArtist
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
        Me.MusicArtist1 = New System.Windows.Forms.Button()
        Me.MusicArtist2 = New System.Windows.Forms.Button()
        Me.MusicArtist3 = New System.Windows.Forms.Button()
        Me.MusicArtist4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MusicArtist1
        '
        Me.MusicArtist1.Location = New System.Drawing.Point(0, 0)
        Me.MusicArtist1.Name = "MusicArtist1"
        Me.MusicArtist1.Size = New System.Drawing.Size(113, 30)
        Me.MusicArtist1.TabIndex = 0
        Me.MusicArtist1.Text = "Music Artist1"
        Me.MusicArtist1.UseVisualStyleBackColor = True
        '
        'MusicArtist2
        '
        Me.MusicArtist2.Location = New System.Drawing.Point(0, 28)
        Me.MusicArtist2.Name = "MusicArtist2"
        Me.MusicArtist2.Size = New System.Drawing.Size(113, 30)
        Me.MusicArtist2.TabIndex = 1
        Me.MusicArtist2.Text = "Music Artist2"
        Me.MusicArtist2.UseVisualStyleBackColor = True
        '
        'MusicArtist3
        '
        Me.MusicArtist3.Location = New System.Drawing.Point(0, 56)
        Me.MusicArtist3.Name = "MusicArtist3"
        Me.MusicArtist3.Size = New System.Drawing.Size(113, 30)
        Me.MusicArtist3.TabIndex = 2
        Me.MusicArtist3.Text = "Music Artist3"
        Me.MusicArtist3.UseVisualStyleBackColor = True
        '
        'MusicArtist4
        '
        Me.MusicArtist4.Location = New System.Drawing.Point(0, 85)
        Me.MusicArtist4.Name = "MusicArtist4"
        Me.MusicArtist4.Size = New System.Drawing.Size(113, 30)
        Me.MusicArtist4.TabIndex = 3
        Me.MusicArtist4.Text = "Music Artist4"
        Me.MusicArtist4.UseVisualStyleBackColor = True
        '
        'MusicArtist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MusicArtist4)
        Me.Controls.Add(Me.MusicArtist3)
        Me.Controls.Add(Me.MusicArtist2)
        Me.Controls.Add(Me.MusicArtist1)
        Me.Name = "MusicArtist"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MusicArtist1 As System.Windows.Forms.Button
    Friend WithEvents MusicArtist2 As System.Windows.Forms.Button
    Friend WithEvents MusicArtist3 As System.Windows.Forms.Button
    Friend WithEvents MusicArtist4 As System.Windows.Forms.Button

End Class
