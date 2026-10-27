Public Class Form1
    Dim rnd As New Random()
    Dim secretNumber As Integer
    Dim attemptsLeft As Integer
    Dim maxAttempts As Integer = 7
    Dim score As Integer = 0
    Dim gameOver As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "Number Guessing Game"
        lblInstruction.Text = "Guess the secret number!"
        StartNewGame()
    End Sub

    Private Sub StartNewGame()
        secretNumber = rnd.Next(1, 101)
        attemptsLeft = maxAttempts
        score = 0
        gameOver = False

        txtGuess.Clear()
        txtGuess.Focus()

        lblFeedback.Text = "Enter your guess."
        lblAttempts.Text = "Attempts Left: " & attemptsLeft.ToString()
        lblRange.Text = "Guess a number between 1 and 100."
        lblScore.Text = "Score: 0"

        btnGuess.Enabled = True
    End Sub

    Private Function ValidateGuess() As Boolean
        If txtGuess.Text.Trim() = "" Then
            MessageBox.Show("Please enter a guess.")
            txtGuess.Focus()
            Return False
        End If

        If Not IsNumeric(txtGuess.Text) Then
            MessageBox.Show("Please enter a valid number.")
            txtGuess.SelectAll()
            txtGuess.Focus()
            Return False
        End If

        Dim playerGuess As Integer = Convert.ToInt32(txtGuess.Text)

        If playerGuess < 1 OrElse playerGuess > 100 Then
            MessageBox.Show("Please enter a number between 1 and 100.")
            txtGuess.SelectAll()
            txtGuess.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        If gameOver Then Exit Sub
        If Not ValidateGuess() Then Exit Sub

        Dim playerGuess As Integer = Convert.ToInt32(txtGuess.Text)

        attemptsLeft -= 1
        lblAttempts.Text = "Attempts Left: " & attemptsLeft.ToString()

        If playerGuess = secretNumber Then
            score = attemptsLeft * 10
            lblScore.Text = "Score: " & score.ToString()
            gameOver = True
            btnGuess.Enabled = False
            lblFeedback.Text = "Correct! You guessed the number!"
            MessageBox.Show("You win!")
        ElseIf playerGuess < secretNumber Then
            lblFeedback.Text = "Too low!"
            CheckGameOver()
        Else
            lblFeedback.Text = "Too high!"
            CheckGameOver()
        End If

        txtGuess.SelectAll()
        txtGuess.Focus()
    End Sub

    Private Sub CheckGameOver()
        If attemptsLeft <= 0 Then
            gameOver = True
            btnGuess.Enabled = False
            lblFeedback.Text = "Game Over! The number was " & secretNumber.ToString() & "."
            MessageBox.Show("No more attempts left.")
        End If
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        StartNewGame()
    End Sub

    Private Sub lblInstruction_Click(sender As Object, e As EventArgs) Handles lblInstruction.Click

    End Sub
End Class
