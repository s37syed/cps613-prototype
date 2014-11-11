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
        Me.TransparentControl1 = New FirstPrototype.TransparentControl()
        Me.SuspendLayout()
        '
        'TransparentControl1
        '
        Me.TransparentControl1.Location = New System.Drawing.Point(20, 0)
        Me.TransparentControl1.Name = "TransparentControl1"
        Me.TransparentControl1.Size = New System.Drawing.Size(93, 113)
        Me.TransparentControl1.TabIndex = 0
        Me.TransparentControl1.Text = resources.GetString("TransparentControl1.Text")
        '
        'ReceiveMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TransparentControl1)
        Me.Name = "ReceiveMsg"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TransparentControl1 As FirstPrototype.TransparentControl

End Class
