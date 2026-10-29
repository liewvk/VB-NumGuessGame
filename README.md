# VB NumGuessGame

A simple number guessing game built with Visual Basic .NET and Windows Forms.

## Overview

This project is a classic "guess the secret number" game where the player tries to guess a random number between 1 and 100. The game gives feedback such as:

- Too low
- Too high
- Correct guess
- Game over when attempts are exhausted

It also tracks the player's score and lets them restart the game.

## Features

- Random secret number generation
- Validates player input
- Limits the player to 7 attempts
- Shows remaining attempts and score
- Displays hints after each guess
- Restart button to begin a new round

## Project type

- Visual Basic .NET
- Windows Forms Application
- Target framework: .NET 10.0 Windows

## Running the project

1. Open the solution file `NumGuessGame.slnx` in Visual Studio 2022 or a compatible .NET development environment.
2. Restore NuGet packages if prompted.
3. Build and run the project.

## Files

- `Form1.vb` - main game logic and event handlers
- `Form1.Designer.vb` - Windows Forms designer code
- `NumGuessGame.vbproj` - project configuration
- `NumGuessGame.slnx` - solution file

## Gameplay

- A random number is chosen between 1 and 100.
- The player enters a guess.
- The game tells them if the guess is too low or too high.
- Each wrong guess reduces the remaining attempts.
- If the player guesses correctly, they win and earn points based on remaining attempts.
- If the attempts run out, the game ends and reveals the hidden number.

## License

This project does not currently include a license file.
