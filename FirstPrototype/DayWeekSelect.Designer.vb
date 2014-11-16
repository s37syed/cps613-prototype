<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DayWeekSelect
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
        Me.DayButton = New System.Windows.Forms.Button()
        Me.WeekButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DayButton
        '
        Me.DayButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DayButton.Location = New System.Drawing.Point(-1, 20)
        Me.DayButton.Name = "DayButton"
        Me.DayButton.Size = New System.Drawing.Size(113, 23)
        Me.DayButton.TabIndex = 0
        Me.DayButton.Text = "Day"
        Me.DayButton.UseVisualStyleBackColor = True
        '
        'WeekButton
        '
        Me.WeekButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WeekButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WeekButton.Location = New System.Drawing.Point(-1, 58)
        Me.WeekButton.Name = "WeekButton"
        Me.WeekButton.Size = New System.Drawing.Size(113, 23)
        Me.WeekButton.TabIndex = 1
        Me.WeekButton.Text = "Week"
        Me.WeekButton.UseVisualStyleBackColor = True
        '
        'DayWeekSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.WeekButton)
        Me.Controls.Add(Me.DayButton)
        Me.Name = "DayWeekSelect"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DayButton As System.Windows.Forms.Button
    Friend WithEvents WeekButton As System.Windows.Forms.Button

End Class
