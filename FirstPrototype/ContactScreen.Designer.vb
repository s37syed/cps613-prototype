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
        Me.Name1 = New System.Windows.Forms.Label()
        Me.Name2 = New System.Windows.Forms.Label()
        Me.Name3 = New System.Windows.Forms.Label()
        Me.Name4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Name1
        '
        Me.Name1.AutoSize = True
        Me.Name1.Location = New System.Drawing.Point(3, 11)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(41, 13)
        Me.Name1.TabIndex = 0
        Me.Name1.Text = "Andrea"
        '
        'Name2
        '
        Me.Name2.AutoSize = True
        Me.Name2.Location = New System.Drawing.Point(3, 38)
        Me.Name2.Name = "Name2"
        Me.Name2.Size = New System.Drawing.Size(36, 13)
        Me.Name2.TabIndex = 0
        Me.Name2.Text = "Mama"
        '
        'Name3
        '
        Me.Name3.AutoSize = True
        Me.Name3.Location = New System.Drawing.Point(3, 65)
        Me.Name3.Name = "Name3"
        Me.Name3.Size = New System.Drawing.Size(32, 13)
        Me.Name3.TabIndex = 0
        Me.Name3.Text = "Papa"
        '
        'Name4
        '
        Me.Name4.AutoSize = True
        Me.Name4.Location = New System.Drawing.Point(3, 92)
        Me.Name4.Name = "Name4"
        Me.Name4.Size = New System.Drawing.Size(45, 13)
        Me.Name4.TabIndex = 0
        Me.Name4.Text = "Grammy"
        '
        'ContactScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Name4)
        Me.Controls.Add(Me.Name3)
        Me.Controls.Add(Me.Name2)
        Me.Controls.Add(Me.Name1)
        Me.Name = "ContactScreen"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Name1 As System.Windows.Forms.Label
    Friend WithEvents Name2 As System.Windows.Forms.Label
    Friend WithEvents Name3 As System.Windows.Forms.Label
    Friend WithEvents Name4 As System.Windows.Forms.Label

End Class
