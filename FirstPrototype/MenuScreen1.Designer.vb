<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuScreen1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuScreen1))
        Me.MenuPage2Tracker = New System.Windows.Forms.PictureBox()
        Me.MessagesMenuButton = New System.Windows.Forms.PictureBox()
        Me.PhoneMenuButton = New System.Windows.Forms.PictureBox()
        Me.ContactsMenuButton = New System.Windows.Forms.PictureBox()
        Me.CalendarMenuButton = New System.Windows.Forms.PictureBox()
        CType(Me.MenuPage2Tracker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MessagesMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendarMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuPage2Tracker
        '
        Me.MenuPage2Tracker.Image = Global.FirstPrototype.My.Resources.Resources.Page2TrackerClear
        Me.MenuPage2Tracker.Location = New System.Drawing.Point(31, 102)
        Me.MenuPage2Tracker.Name = "MenuPage2Tracker"
        Me.MenuPage2Tracker.Size = New System.Drawing.Size(50, 10)
        Me.MenuPage2Tracker.TabIndex = 4
        Me.MenuPage2Tracker.TabStop = False
        '
        'MessagesMenuButton
        '
        Me.MessagesMenuButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MessagesMenuButton.Image = CType(resources.GetObject("MessagesMenuButton.Image"), System.Drawing.Image)
        Me.MessagesMenuButton.Location = New System.Drawing.Point(59, 54)
        Me.MessagesMenuButton.Name = "MessagesMenuButton"
        Me.MessagesMenuButton.Size = New System.Drawing.Size(45, 45)
        Me.MessagesMenuButton.TabIndex = 3
        Me.MessagesMenuButton.TabStop = False
        '
        'PhoneMenuButton
        '
        Me.PhoneMenuButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PhoneMenuButton.Image = CType(resources.GetObject("PhoneMenuButton.Image"), System.Drawing.Image)
        Me.PhoneMenuButton.Location = New System.Drawing.Point(8, 54)
        Me.PhoneMenuButton.Name = "PhoneMenuButton"
        Me.PhoneMenuButton.Size = New System.Drawing.Size(45, 45)
        Me.PhoneMenuButton.TabIndex = 2
        Me.PhoneMenuButton.TabStop = False
        '
        'ContactsMenuButton
        '
        Me.ContactsMenuButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactsMenuButton.Image = CType(resources.GetObject("ContactsMenuButton.Image"), System.Drawing.Image)
        Me.ContactsMenuButton.Location = New System.Drawing.Point(59, 3)
        Me.ContactsMenuButton.Name = "ContactsMenuButton"
        Me.ContactsMenuButton.Size = New System.Drawing.Size(45, 45)
        Me.ContactsMenuButton.TabIndex = 1
        Me.ContactsMenuButton.TabStop = False
        '
        'CalendarMenuButton
        '
        Me.CalendarMenuButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CalendarMenuButton.Image = CType(resources.GetObject("CalendarMenuButton.Image"), System.Drawing.Image)
        Me.CalendarMenuButton.Location = New System.Drawing.Point(8, 3)
        Me.CalendarMenuButton.Name = "CalendarMenuButton"
        Me.CalendarMenuButton.Size = New System.Drawing.Size(45, 45)
        Me.CalendarMenuButton.TabIndex = 0
        Me.CalendarMenuButton.TabStop = False
        '
        'MenuScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MenuPage2Tracker)
        Me.Controls.Add(Me.MessagesMenuButton)
        Me.Controls.Add(Me.PhoneMenuButton)
        Me.Controls.Add(Me.ContactsMenuButton)
        Me.Controls.Add(Me.CalendarMenuButton)
        Me.Name = "MenuScreen1"
        Me.Size = New System.Drawing.Size(113, 113)
        CType(Me.MenuPage2Tracker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MessagesMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendarMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContactsMenuButton As System.Windows.Forms.PictureBox
    Friend WithEvents PhoneMenuButton As System.Windows.Forms.PictureBox
    Friend WithEvents MessagesMenuButton As System.Windows.Forms.PictureBox
    Friend WithEvents MenuPage2Tracker As System.Windows.Forms.PictureBox
    Friend WithEvents CalendarMenuButton As System.Windows.Forms.PictureBox

End Class
