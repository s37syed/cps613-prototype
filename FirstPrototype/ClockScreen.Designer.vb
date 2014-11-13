<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClockScreen
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
        Me.MenuPage1Tracker = New System.Windows.Forms.PictureBox()
        CType(Me.MenuPage1Tracker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuPage1Tracker
        '
        Me.MenuPage1Tracker.Image = Global.FirstPrototype.My.Resources.Resources.Page1TrackerClear
        Me.MenuPage1Tracker.Location = New System.Drawing.Point(31, 102)
        Me.MenuPage1Tracker.Name = "MenuPage1Tracker"
        Me.MenuPage1Tracker.Size = New System.Drawing.Size(50, 10)
        Me.MenuPage1Tracker.TabIndex = 1
        Me.MenuPage1Tracker.TabStop = False
        '
        'ClockScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MenuPage1Tracker)
        Me.Name = "ClockScreen"
        Me.Size = New System.Drawing.Size(113, 113)
        CType(Me.MenuPage1Tracker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    'Friend WithEvents Clock1 As AnalogClock.Clock
    Friend WithEvents MenuPage1Tracker As System.Windows.Forms.PictureBox

End Class
