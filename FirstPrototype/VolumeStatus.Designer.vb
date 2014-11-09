<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VolumeStatus
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
        Me.VolumeStatusLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'VolumeStatusLabel
        '
        Me.VolumeStatusLabel.AutoSize = True
        Me.VolumeStatusLabel.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolumeStatusLabel.Location = New System.Drawing.Point(15, 6)
        Me.VolumeStatusLabel.Name = "VolumeStatusLabel"
        Me.VolumeStatusLabel.Size = New System.Drawing.Size(0, 22)
        Me.VolumeStatusLabel.TabIndex = 0
        '
        'VolumeStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.VolumeStatusLabel)
        Me.Location = New System.Drawing.Point(20, 30)
        Me.Name = "VolumeStatus"
        Me.Size = New System.Drawing.Size(83, 25)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VolumeStatusLabel As System.Windows.Forms.Label

End Class
