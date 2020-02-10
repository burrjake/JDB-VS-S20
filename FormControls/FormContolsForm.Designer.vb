<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormContolsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.TextGroupBox = New System.Windows.Forms.GroupBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StreetLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.UserSelction = New System.Windows.Forms.GroupBox()
        Me.UserPictureBox = New System.Windows.Forms.PictureBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.TextGroupBox.SuspendLayout()
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(637, 352)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(151, 93)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(468, 352)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(151, 93)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(300, 352)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(151, 93)
        Me.GoButton.TabIndex = 2
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'TextGroupBox
        '
        Me.TextGroupBox.Controls.Add(Me.StateLabel)
        Me.TextGroupBox.Controls.Add(Me.NameLabel)
        Me.TextGroupBox.Controls.Add(Me.StreetLabel)
        Me.TextGroupBox.Controls.Add(Me.StateTextBox)
        Me.TextGroupBox.Controls.Add(Me.StreetTextBox)
        Me.TextGroupBox.Controls.Add(Me.NameTextBox)
        Me.TextGroupBox.Location = New System.Drawing.Point(31, 41)
        Me.TextGroupBox.Name = "TextGroupBox"
        Me.TextGroupBox.Size = New System.Drawing.Size(270, 267)
        Me.TextGroupBox.TabIndex = 3
        Me.TextGroupBox.TabStop = False
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(6, 107)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(41, 17)
        Me.StateLabel.TabIndex = 10
        Me.StateLabel.Text = "State"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 33)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 17)
        Me.NameLabel.TabIndex = 6
        Me.NameLabel.Text = "Name"
        '
        'StreetLabel
        '
        Me.StreetLabel.AutoSize = True
        Me.StreetLabel.Location = New System.Drawing.Point(6, 70)
        Me.StreetLabel.Name = "StreetLabel"
        Me.StreetLabel.Size = New System.Drawing.Size(46, 17)
        Me.StreetLabel.TabIndex = 9
        Me.StreetLabel.Text = "Street"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(68, 107)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(187, 22)
        Me.StateTextBox.TabIndex = 8
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Location = New System.Drawing.Point(68, 70)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(187, 22)
        Me.StreetTextBox.TabIndex = 7
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(68, 33)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(187, 22)
        Me.NameTextBox.TabIndex = 6
        '
        'UserSelction
        '
        Me.UserSelction.Location = New System.Drawing.Point(323, 41)
        Me.UserSelction.Name = "UserSelction"
        Me.UserSelction.Size = New System.Drawing.Size(255, 267)
        Me.UserSelction.TabIndex = 4
        Me.UserSelction.TabStop = False
        '
        'UserPictureBox
        '
        Me.UserPictureBox.Location = New System.Drawing.Point(610, 53)
        Me.UserPictureBox.Name = "UserPictureBox"
        Me.UserPictureBox.Size = New System.Drawing.Size(178, 127)
        Me.UserPictureBox.TabIndex = 5
        Me.UserPictureBox.TabStop = False
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(610, 193)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(178, 115)
        Me.DisplayLabel.TabIndex = 6
        '
        'FormContolsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 457)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.UserPictureBox)
        Me.Controls.Add(Me.UserSelction)
        Me.Controls.Add(Me.TextGroupBox)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "FormContolsForm"
        Me.Text = "User Control Interface"
        Me.TextGroupBox.ResumeLayout(False)
        Me.TextGroupBox.PerformLayout()
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents GoButton As Button
    Friend WithEvents TextGroupBox As GroupBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents UserSelction As GroupBox
    Friend WithEvents UserPictureBox As PictureBox
    Friend WithEvents StreetLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents DisplayLabel As Label
End Class
