<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calendar
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
        Me.MonthLabel = New System.Windows.Forms.Label()
        Me.Week1 = New System.Windows.Forms.Label()
        Me.Week3 = New System.Windows.Forms.Label()
        Me.Week2 = New System.Windows.Forms.Label()
        Me.Week4 = New System.Windows.Forms.Label()
        Me.Week5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MonthLabel
        '
        Me.MonthLabel.AutoSize = True
        Me.MonthLabel.BackColor = System.Drawing.Color.Transparent
        Me.MonthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthLabel.Location = New System.Drawing.Point(33, 9)
        Me.MonthLabel.Name = "MonthLabel"
        Me.MonthLabel.Size = New System.Drawing.Size(56, 13)
        Me.MonthLabel.TabIndex = 0
        Me.MonthLabel.Text = "November"
        '
        'Week1
        '
        Me.Week1.AutoSize = True
        Me.Week1.BackColor = System.Drawing.Color.Transparent
        Me.Week1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Week1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Week1.Location = New System.Drawing.Point(14, 34)
        Me.Week1.Name = "Week1"
        Me.Week1.Size = New System.Drawing.Size(102, 13)
        Me.Week1.TabIndex = 1
        Me.Week1.Text = "Week 1          (1 - 7)"
        '
        'Week3
        '
        Me.Week3.AutoSize = True
        Me.Week3.BackColor = System.Drawing.Color.Transparent
        Me.Week3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Week3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Week3.Location = New System.Drawing.Point(14, 61)
        Me.Week3.Name = "Week3"
        Me.Week3.Size = New System.Drawing.Size(102, 13)
        Me.Week3.TabIndex = 8
        Me.Week3.Text = "Week 3      (15 - 21)"
        '
        'Week2
        '
        Me.Week2.AutoSize = True
        Me.Week2.BackColor = System.Drawing.Color.Transparent
        Me.Week2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Week2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Week2.Location = New System.Drawing.Point(14, 47)
        Me.Week2.Name = "Week2"
        Me.Week2.Size = New System.Drawing.Size(102, 13)
        Me.Week2.TabIndex = 5
        Me.Week2.Text = "Week 2        (8 - 14)"
        '
        'Week4
        '
        Me.Week4.AutoSize = True
        Me.Week4.BackColor = System.Drawing.Color.Transparent
        Me.Week4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Week4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Week4.Location = New System.Drawing.Point(14, 75)
        Me.Week4.Name = "Week4"
        Me.Week4.Size = New System.Drawing.Size(102, 13)
        Me.Week4.TabIndex = 12
        Me.Week4.Text = "Week 4      (22 - 28)"
        '
        'Week5
        '
        Me.Week5.AutoSize = True
        Me.Week5.BackColor = System.Drawing.Color.Transparent
        Me.Week5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Week5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Week5.Location = New System.Drawing.Point(14, 88)
        Me.Week5.Name = "Week5"
        Me.Week5.Size = New System.Drawing.Size(102, 13)
        Me.Week5.TabIndex = 13
        Me.Week5.Text = "Week 5      (29 - 30)"
        '
        'Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.note_bg
        Me.Controls.Add(Me.Week5)
        Me.Controls.Add(Me.Week4)
        Me.Controls.Add(Me.Week3)
        Me.Controls.Add(Me.Week2)
        Me.Controls.Add(Me.Week1)
        Me.Controls.Add(Me.MonthLabel)
        Me.Name = "Calendar"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthLabel As System.Windows.Forms.Label
    Friend WithEvents Week1 As System.Windows.Forms.Label
    Friend WithEvents Week3 As System.Windows.Forms.Label
    Friend WithEvents Week2 As System.Windows.Forms.Label
    Friend WithEvents Week4 As System.Windows.Forms.Label
    Friend WithEvents Week5 As System.Windows.Forms.Label

End Class
