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
        Me.UserPictureBox = New System.Windows.Forms.PictureBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.UserSelction = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.TextGroupBox.SuspendLayout()
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserSelction.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(639, 352)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(151, 94)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(468, 352)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(151, 94)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(300, 352)
        Me.GoButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(151, 94)
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
        Me.TextGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextGroupBox.Name = "TextGroupBox"
        Me.TextGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextGroupBox.Size = New System.Drawing.Size(269, 267)
        Me.TextGroupBox.TabIndex = 3
        Me.TextGroupBox.TabStop = False
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(5, 107)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(41, 17)
        Me.StateLabel.TabIndex = 10
        Me.StateLabel.Text = "State"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(5, 33)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 17)
        Me.NameLabel.TabIndex = 6
        Me.NameLabel.Text = "Name"
        '
        'StreetLabel
        '
        Me.StreetLabel.AutoSize = True
        Me.StreetLabel.Location = New System.Drawing.Point(5, 70)
        Me.StreetLabel.Name = "StreetLabel"
        Me.StreetLabel.Size = New System.Drawing.Size(46, 17)
        Me.StreetLabel.TabIndex = 9
        Me.StreetLabel.Text = "Street"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(68, 107)
        Me.StateTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(187, 22)
        Me.StateTextBox.TabIndex = 8
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Location = New System.Drawing.Point(68, 70)
        Me.StreetTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(187, 22)
        Me.StreetTextBox.TabIndex = 7
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(68, 33)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(187, 22)
        Me.NameTextBox.TabIndex = 6
        '
        'UserPictureBox
        '
        Me.UserPictureBox.Location = New System.Drawing.Point(611, 53)
        Me.UserPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserPictureBox.Name = "UserPictureBox"
        Me.UserPictureBox.Size = New System.Drawing.Size(179, 127)
        Me.UserPictureBox.TabIndex = 5
        Me.UserPictureBox.TabStop = False
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(611, 193)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(179, 114)
        Me.DisplayLabel.TabIndex = 6
        '
        'UserSelction
        '
        Me.UserSelction.Controls.Add(Me.RadioButton3)
        Me.UserSelction.Controls.Add(Me.RadioButton2)
        Me.UserSelction.Controls.Add(Me.CheckBox3)
        Me.UserSelction.Controls.Add(Me.CheckBox2)
        Me.UserSelction.Controls.Add(Me.CheckBox1)
        Me.UserSelction.Controls.Add(Me.RadioButton1)
        Me.UserSelction.Location = New System.Drawing.Point(323, 41)
        Me.UserSelction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserSelction.Name = "UserSelction"
        Me.UserSelction.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserSelction.Size = New System.Drawing.Size(255, 267)
        Me.UserSelction.TabIndex = 4
        Me.UserSelction.TabStop = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(57, 85)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(57, 57)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(57, 175)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(57, 146)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(57, 118)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(57, 28)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(16, 329)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton4.TabIndex = 7
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(16, 357)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton5.TabIndex = 8
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "RadioButton5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(16, 389)
        Me.RadioButton6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton6.TabIndex = 9
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "RadioButton6"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(144, 330)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox4.TabIndex = 10
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(144, 358)
        Me.CheckBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox5.TabIndex = 11
        Me.CheckBox5.Text = "CheckBox5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(144, 390)
        Me.CheckBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox6.TabIndex = 12
        Me.CheckBox6.Text = "CheckBox6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'FormContolsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 457)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.UserPictureBox)
        Me.Controls.Add(Me.UserSelction)
        Me.Controls.Add(Me.TextGroupBox)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormContolsForm"
        Me.Text = "X"
        Me.TextGroupBox.ResumeLayout(False)
        Me.TextGroupBox.PerformLayout()
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserSelction.ResumeLayout(False)
        Me.UserSelction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents GoButton As Button
    Friend WithEvents TextGroupBox As GroupBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents UserPictureBox As PictureBox
    Friend WithEvents StreetLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents UserSelction As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
End Class
