<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        lblInstruction = New Label()
        txtGuess = New TextBox()
        btnGuess = New Button()
        btnRestart = New Button()
        btnExit = New Button()
        lblFeedback = New Label()
        lblAttempts = New Label()
        lblRange = New Label()
        lblScore = New Label()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(226, 39)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(272, 31)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Number Guessing Game"
        ' 
        ' lblInstruction
        ' 
        lblInstruction.AutoSize = True
        lblInstruction.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInstruction.Location = New Point(226, 83)
        lblInstruction.Name = "lblInstruction"
        lblInstruction.Size = New Size(105, 28)
        lblInstruction.TabIndex = 0
        lblInstruction.Text = "Instruction"
        ' 
        ' txtGuess
        ' 
        txtGuess.Location = New Point(241, 166)
        txtGuess.Name = "txtGuess"
        txtGuess.Size = New Size(164, 27)
        txtGuess.TabIndex = 1
        ' 
        ' btnGuess
        ' 
        btnGuess.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGuess.Location = New Point(240, 216)
        btnGuess.Name = "btnGuess"
        btnGuess.Size = New Size(167, 37)
        btnGuess.TabIndex = 2
        btnGuess.Text = "Click to Guess"
        btnGuess.UseVisualStyleBackColor = True
        ' 
        ' btnRestart
        ' 
        btnRestart.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRestart.Location = New Point(226, 331)
        btnRestart.Name = "btnRestart"
        btnRestart.Size = New Size(167, 37)
        btnRestart.TabIndex = 2
        btnRestart.Text = "Restart"
        btnRestart.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(438, 331)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(167, 37)
        btnExit.TabIndex = 2
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblFeedback
        ' 
        lblFeedback.AutoSize = True
        lblFeedback.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFeedback.Location = New Point(44, 165)
        lblFeedback.Name = "lblFeedback"
        lblFeedback.Size = New Size(95, 28)
        lblFeedback.TabIndex = 0
        lblFeedback.Text = "Feedback"
        ' 
        ' lblAttempts
        ' 
        lblAttempts.AutoSize = True
        lblAttempts.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAttempts.Location = New Point(259, 272)
        lblAttempts.Name = "lblAttempts"
        lblAttempts.Size = New Size(148, 28)
        lblAttempts.TabIndex = 0
        lblAttempts.Text = "No of Attempts"
        ' 
        ' lblRange
        ' 
        lblRange.AutoSize = True
        lblRange.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRange.Location = New Point(226, 123)
        lblRange.Name = "lblRange"
        lblRange.Size = New Size(67, 28)
        lblRange.TabIndex = 0
        lblRange.Text = "Range"
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblScore.Location = New Point(476, 166)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(61, 28)
        lblScore.TabIndex = 0
        lblScore.Text = "Score"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(btnRestart)
        Controls.Add(btnGuess)
        Controls.Add(txtGuess)
        Controls.Add(lblRange)
        Controls.Add(lblAttempts)
        Controls.Add(lblScore)
        Controls.Add(lblFeedback)
        Controls.Add(lblInstruction)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstruction As Label
    Friend WithEvents txtGuess As TextBox
    Friend WithEvents btnGuess As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFeedback As Label
    Friend WithEvents lblAttempts As Label
    Friend WithEvents lblRange As Label
    Friend WithEvents lblScore As Label

End Class
