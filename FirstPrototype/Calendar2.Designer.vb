<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calendar2
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
        Me.WeekLabel = New System.Windows.Forms.Label()
        Me.Day1 = New System.Windows.Forms.Label()
        Me.Day2 = New System.Windows.Forms.Label()
        Me.Day3 = New System.Windows.Forms.Label()
        Me.Day4 = New System.Windows.Forms.Label()
        Me.Day5 = New System.Windows.Forms.Label()
        Me.Day6 = New System.Windows.Forms.Label()
        Me.Day7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WeekLabel
        '
        Me.WeekLabel.AutoSize = True
        Me.WeekLabel.BackColor = System.Drawing.Color.Transparent
        Me.WeekLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeekLabel.Location = New System.Drawing.Point(31, 0)
        Me.WeekLabel.Name = "WeekLabel"
        Me.WeekLabel.Size = New System.Drawing.Size(39, 13)
        Me.WeekLabel.TabIndex = 17
        Me.WeekLabel.Text = "Label1"
        '
        'Day1
        '
        Me.Day1.AutoSize = True
        Me.Day1.BackColor = System.Drawing.Color.Transparent
        Me.Day1.Location = New System.Drawing.Point(12, 24)
        Me.Day1.Name = "Day1"
        Me.Day1.Size = New System.Drawing.Size(39, 13)
        Me.Day1.TabIndex = 21
        Me.Day1.Text = "Label1"
        '
        'Day2
        '
        Me.Day2.AutoSize = True
        Me.Day2.BackColor = System.Drawing.Color.Transparent
        Me.Day2.Location = New System.Drawing.Point(12, 37)
        Me.Day2.Name = "Day2"
        Me.Day2.Size = New System.Drawing.Size(39, 13)
        Me.Day2.TabIndex = 22
        Me.Day2.Text = "Label2"
        '
        'Day3
        '
        Me.Day3.AutoSize = True
        Me.Day3.BackColor = System.Drawing.Color.Transparent
        Me.Day3.Location = New System.Drawing.Point(12, 49)
        Me.Day3.Name = "Day3"
        Me.Day3.Size = New System.Drawing.Size(39, 13)
        Me.Day3.TabIndex = 23
        Me.Day3.Text = "Label3"
        '
        'Day4
        '
        Me.Day4.AutoSize = True
        Me.Day4.BackColor = System.Drawing.Color.Transparent
        Me.Day4.Location = New System.Drawing.Point(12, 62)
        Me.Day4.Name = "Day4"
        Me.Day4.Size = New System.Drawing.Size(39, 13)
        Me.Day4.TabIndex = 24
        Me.Day4.Text = "Label4"
        '
        'Day5
        '
        Me.Day5.AutoSize = True
        Me.Day5.BackColor = System.Drawing.Color.Transparent
        Me.Day5.Location = New System.Drawing.Point(12, 75)
        Me.Day5.Name = "Day5"
        Me.Day5.Size = New System.Drawing.Size(39, 13)
        Me.Day5.TabIndex = 25
        Me.Day5.Text = "Label5"
        '
        'Day6
        '
        Me.Day6.AutoSize = True
        Me.Day6.BackColor = System.Drawing.Color.Transparent
        Me.Day6.Location = New System.Drawing.Point(12, 87)
        Me.Day6.Name = "Day6"
        Me.Day6.Size = New System.Drawing.Size(39, 13)
        Me.Day6.TabIndex = 26
        Me.Day6.Text = "Label6"
        '
        'Day7
        '
        Me.Day7.AutoSize = True
        Me.Day7.BackColor = System.Drawing.Color.Transparent
        Me.Day7.Location = New System.Drawing.Point(12, 100)
        Me.Day7.Name = "Day7"
        Me.Day7.Size = New System.Drawing.Size(39, 13)
        Me.Day7.TabIndex = 27
        Me.Day7.Text = "Label7"
        '
        'Calendar2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FirstPrototype.My.Resources.Resources.note_bg
        Me.Controls.Add(Me.Day7)
        Me.Controls.Add(Me.Day6)
        Me.Controls.Add(Me.Day5)
        Me.Controls.Add(Me.Day4)
        Me.Controls.Add(Me.Day3)
        Me.Controls.Add(Me.Day2)
        Me.Controls.Add(Me.Day1)
        Me.Controls.Add(Me.WeekLabel)
        Me.Name = "Calendar2"
        Me.Size = New System.Drawing.Size(113, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WeekLabel As System.Windows.Forms.Label
    Friend WithEvents Day1 As System.Windows.Forms.Label
    Friend WithEvents Day2 As System.Windows.Forms.Label
    Friend WithEvents Day3 As System.Windows.Forms.Label
    Friend WithEvents Day4 As System.Windows.Forms.Label
    Friend WithEvents Day5 As System.Windows.Forms.Label
    Friend WithEvents Day6 As System.Windows.Forms.Label
    Friend WithEvents Day7 As System.Windows.Forms.Label

End Class
