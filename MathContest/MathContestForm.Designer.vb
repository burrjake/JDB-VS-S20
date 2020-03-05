<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.StudentInfoBox = New System.Windows.Forms.GroupBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.GradeBox = New System.Windows.Forms.TextBox()
        Me.AgeBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.ButtonBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ProblemTypeBox = New System.Windows.Forms.GroupBox()
        Me.DivideButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyButton = New System.Windows.Forms.RadioButton()
        Me.SubtractButton = New System.Windows.Forms.RadioButton()
        Me.AddButton = New System.Windows.Forms.RadioButton()
        Me.MathProblemBox = New System.Windows.Forms.GroupBox()
        Me.FirstNumberBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberBox = New System.Windows.Forms.TextBox()
        Me.AnswerBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.AnswerLabel = New System.Windows.Forms.Label()
        Me.StudentInfoBox.SuspendLayout()
        Me.ButtonBox.SuspendLayout()
        Me.ProblemTypeBox.SuspendLayout()
        Me.MathProblemBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(800, 450)
        Me.WebBrowser1.TabIndex = 0
        '
        'StudentInfoBox
        '
        Me.StudentInfoBox.Controls.Add(Me.GradeLabel)
        Me.StudentInfoBox.Controls.Add(Me.AgeLabel)
        Me.StudentInfoBox.Controls.Add(Me.NameLabel)
        Me.StudentInfoBox.Controls.Add(Me.GradeBox)
        Me.StudentInfoBox.Controls.Add(Me.AgeBox)
        Me.StudentInfoBox.Controls.Add(Me.NameBox)
        Me.StudentInfoBox.Location = New System.Drawing.Point(12, 12)
        Me.StudentInfoBox.Name = "StudentInfoBox"
        Me.StudentInfoBox.Size = New System.Drawing.Size(462, 100)
        Me.StudentInfoBox.TabIndex = 1
        Me.StudentInfoBox.TabStop = False
        Me.StudentInfoBox.Text = "Student Information"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(312, 18)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(48, 17)
        Me.GradeLabel.TabIndex = 5
        Me.GradeLabel.Text = "Grade"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(259, 18)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(33, 17)
        Me.AgeLabel.TabIndex = 4
        Me.AgeLabel.Text = "Age"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 22)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 17)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Name"
        '
        'GradeBox
        '
        Me.GradeBox.Location = New System.Drawing.Point(315, 41)
        Me.GradeBox.Name = "GradeBox"
        Me.GradeBox.Size = New System.Drawing.Size(22, 22)
        Me.GradeBox.TabIndex = 2
        '
        'AgeBox
        '
        Me.AgeBox.Location = New System.Drawing.Point(262, 41)
        Me.AgeBox.Name = "AgeBox"
        Me.AgeBox.Size = New System.Drawing.Size(22, 22)
        Me.AgeBox.TabIndex = 1
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(6, 41)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(216, 22)
        Me.NameBox.TabIndex = 0
        '
        'ButtonBox
        '
        Me.ButtonBox.Controls.Add(Me.ExitButton)
        Me.ButtonBox.Controls.Add(Me.SummaryButton)
        Me.ButtonBox.Controls.Add(Me.ClearButton)
        Me.ButtonBox.Controls.Add(Me.SubmitButton)
        Me.ButtonBox.Location = New System.Drawing.Point(496, 11)
        Me.ButtonBox.Name = "ButtonBox"
        Me.ButtonBox.Size = New System.Drawing.Size(281, 427)
        Me.ButtonBox.TabIndex = 2
        Me.ButtonBox.TabStop = False
        Me.ButtonBox.Text = " "
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(38, 310)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(212, 78)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(38, 212)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(212, 78)
        Me.SummaryButton.TabIndex = 2
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(38, 116)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(212, 78)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(38, 23)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(212, 78)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ProblemTypeBox
        '
        Me.ProblemTypeBox.Controls.Add(Me.DivideButton)
        Me.ProblemTypeBox.Controls.Add(Me.MultiplyButton)
        Me.ProblemTypeBox.Controls.Add(Me.SubtractButton)
        Me.ProblemTypeBox.Controls.Add(Me.AddButton)
        Me.ProblemTypeBox.Location = New System.Drawing.Point(274, 127)
        Me.ProblemTypeBox.Name = "ProblemTypeBox"
        Me.ProblemTypeBox.Size = New System.Drawing.Size(200, 311)
        Me.ProblemTypeBox.TabIndex = 3
        Me.ProblemTypeBox.TabStop = False
        Me.ProblemTypeBox.Text = "Math Problem Type"
        '
        'DivideButton
        '
        Me.DivideButton.AutoSize = True
        Me.DivideButton.Location = New System.Drawing.Point(31, 165)
        Me.DivideButton.Name = "DivideButton"
        Me.DivideButton.Size = New System.Drawing.Size(68, 21)
        Me.DivideButton.TabIndex = 3
        Me.DivideButton.TabStop = True
        Me.DivideButton.Text = "Divide"
        Me.DivideButton.UseVisualStyleBackColor = True
        '
        'MultiplyButton
        '
        Me.MultiplyButton.AutoSize = True
        Me.MultiplyButton.Location = New System.Drawing.Point(31, 125)
        Me.MultiplyButton.Name = "MultiplyButton"
        Me.MultiplyButton.Size = New System.Drawing.Size(76, 21)
        Me.MultiplyButton.TabIndex = 2
        Me.MultiplyButton.TabStop = True
        Me.MultiplyButton.Text = "Multiply"
        Me.MultiplyButton.UseVisualStyleBackColor = True
        '
        'SubtractButton
        '
        Me.SubtractButton.AutoSize = True
        Me.SubtractButton.Location = New System.Drawing.Point(31, 85)
        Me.SubtractButton.Name = "SubtractButton"
        Me.SubtractButton.Size = New System.Drawing.Size(82, 21)
        Me.SubtractButton.TabIndex = 1
        Me.SubtractButton.TabStop = True
        Me.SubtractButton.Text = "Subtract"
        Me.SubtractButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.AutoSize = True
        Me.AddButton.Location = New System.Drawing.Point(31, 46)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(54, 21)
        Me.AddButton.TabIndex = 0
        Me.AddButton.TabStop = True
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'MathProblemBox
        '
        Me.MathProblemBox.Controls.Add(Me.AnswerLabel)
        Me.MathProblemBox.Controls.Add(Me.SecondNumberLabel)
        Me.MathProblemBox.Controls.Add(Me.FirstNumberLabel)
        Me.MathProblemBox.Controls.Add(Me.AnswerBox)
        Me.MathProblemBox.Controls.Add(Me.SecondNumberBox)
        Me.MathProblemBox.Controls.Add(Me.FirstNumberBox)
        Me.MathProblemBox.Location = New System.Drawing.Point(12, 127)
        Me.MathProblemBox.Name = "MathProblemBox"
        Me.MathProblemBox.Size = New System.Drawing.Size(242, 311)
        Me.MathProblemBox.TabIndex = 0
        Me.MathProblemBox.TabStop = False
        Me.MathProblemBox.Text = "Current Math Problem"
        '
        'FirstNumberBox
        '
        Me.FirstNumberBox.Enabled = False
        Me.FirstNumberBox.Location = New System.Drawing.Point(9, 56)
        Me.FirstNumberBox.Name = "FirstNumberBox"
        Me.FirstNumberBox.Size = New System.Drawing.Size(183, 22)
        Me.FirstNumberBox.TabIndex = 0
        '
        'SecondNumberBox
        '
        Me.SecondNumberBox.Enabled = False
        Me.SecondNumberBox.Location = New System.Drawing.Point(9, 124)
        Me.SecondNumberBox.Name = "SecondNumberBox"
        Me.SecondNumberBox.Size = New System.Drawing.Size(183, 22)
        Me.SecondNumberBox.TabIndex = 1
        '
        'AnswerBox
        '
        Me.AnswerBox.Location = New System.Drawing.Point(9, 194)
        Me.AnswerBox.Name = "AnswerBox"
        Me.AnswerBox.Size = New System.Drawing.Size(183, 22)
        Me.AnswerBox.TabIndex = 2
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(6, 36)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(89, 17)
        Me.FirstNumberLabel.TabIndex = 3
        Me.FirstNumberLabel.Text = "First Number"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(6, 104)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(110, 17)
        Me.SecondNumberLabel.TabIndex = 4
        Me.SecondNumberLabel.Text = "Second Number"
        '
        'AnswerLabel
        '
        Me.AnswerLabel.AutoSize = True
        Me.AnswerLabel.Location = New System.Drawing.Point(6, 174)
        Me.AnswerLabel.Name = "AnswerLabel"
        Me.AnswerLabel.Size = New System.Drawing.Size(107, 17)
        Me.AnswerLabel.TabIndex = 5
        Me.AnswerLabel.Text = "Student Answer"
        '
        'MathContestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MathProblemBox)
        Me.Controls.Add(Me.ProblemTypeBox)
        Me.Controls.Add(Me.ButtonBox)
        Me.Controls.Add(Me.StudentInfoBox)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "MathContestForm"
        Me.Text = "Form1"
        Me.StudentInfoBox.ResumeLayout(False)
        Me.StudentInfoBox.PerformLayout()
        Me.ButtonBox.ResumeLayout(False)
        Me.ProblemTypeBox.ResumeLayout(False)
        Me.ProblemTypeBox.PerformLayout()
        Me.MathProblemBox.ResumeLayout(False)
        Me.MathProblemBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents StudentInfoBox As GroupBox
    Friend WithEvents ButtonBox As GroupBox
    Friend WithEvents ProblemTypeBox As GroupBox
    Friend WithEvents MathProblemBox As GroupBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents GradeBox As TextBox
    Friend WithEvents AgeBox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents DivideButton As RadioButton
    Friend WithEvents MultiplyButton As RadioButton
    Friend WithEvents SubtractButton As RadioButton
    Friend WithEvents AddButton As RadioButton
    Friend WithEvents FirstNumberBox As TextBox
    Friend WithEvents AnswerLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents AnswerBox As TextBox
    Friend WithEvents SecondNumberBox As TextBox
End Class
