<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapApp
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Child1 = New System.Windows.Forms.Button()
        Me.Child2 = New System.Windows.Forms.Button()
        Me.Child3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Locate Child"
        '
        'Child1
        '
        Me.Child1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Child1.Location = New System.Drawing.Point(68, 98)
        Me.Child1.Name = "Child1"
        Me.Child1.Size = New System.Drawing.Size(75, 23)
        Me.Child1.TabIndex = 1
        Me.Child1.Text = "Christina"
        Me.Child1.UseVisualStyleBackColor = True
        '
        'Child2
        '
        Me.Child2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Child2.Location = New System.Drawing.Point(68, 127)
        Me.Child2.Name = "Child2"
        Me.Child2.Size = New System.Drawing.Size(75, 23)
        Me.Child2.TabIndex = 2
        Me.Child2.Text = "Randy"
        Me.Child2.UseVisualStyleBackColor = True
        '
        'Child3
        '
        Me.Child3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Child3.Location = New System.Drawing.Point(68, 156)
        Me.Child3.Name = "Child3"
        Me.Child3.Size = New System.Drawing.Size(75, 23)
        Me.Child3.TabIndex = 3
        Me.Child3.Text = "Vladimir"
        Me.Child3.UseVisualStyleBackColor = True
        '
        'MapApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Child3)
        Me.Controls.Add(Me.Child2)
        Me.Controls.Add(Me.Child1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MapApp"
        Me.Size = New System.Drawing.Size(210, 323)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Child1 As System.Windows.Forms.Button
    Friend WithEvents Child2 As System.Windows.Forms.Button
    Friend WithEvents Child3 As System.Windows.Forms.Button

End Class
