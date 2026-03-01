# C-Mystery-Number
Mystery Number is an interactive logic game built with C# and Windows Forms. Players must deduce a hidden randomly generated number within a set range using a limited number of attempts. The game features real-time logging, visual progress tracking, and customizable difficulty.

🎮 How to Play
Set Up: Define the range of numbers (e.g., 1 to 100) and choose the number of attempts you want.

Start: Click GO! to generate the secret mystery number.

Guess: Enter your number in the "My Guess" field and click Guess.

Analyze: * The Progress Bar and HOT/COLD labels provide visual feedback on your remaining chances.

Check the Information Log to see your history and whether your guess was too high or too low.

Win/Loss: Successfully find the number before attempts run out to win!

✨ Key Features
Customizable Difficulty: Users define the starting number, ending number, and total attempts.

Dynamic Logging System: A RichTextBox log that uses color-coding (Green for wins, Red for losses/errors, Black for info) to track every move.

Visual Feedback: Includes a progress bar and counter for "Attempts Left" and "Wrong Guesses."

Cheat Mode: A "Cheat" button for testing purposes that reveals the mystery number in the log.

Smart UI: The game starts with a splash screen that tucks away once the game begins, optimizing the workspace.

🛠️ Technical Implementation
The game is built using C# .NET Framework and demonstrates several core programming concepts:

Randomization: Utilizing the Random class to generate unpredictable secret numbers.

Input Validation: Converting string inputs from TextBox and ComboBox into integers for logic processing.

State Management: Using a gameStarted boolean to prevent actions (like cheating) when a race isn't active.

Custom Logging Function: A modular UpdateLoggingText method that handles text selection and color formatting dynamically.

📜 Credits
Developer: Juliusz Krajewski
Framework: Windows Forms (WinForms)


<img width="652" height="492" alt="Screenshot 2026-03-01 144711" src="https://github.com/user-attachments/assets/3249df3d-ccd6-4c26-b455-d3159c3a0345" />
