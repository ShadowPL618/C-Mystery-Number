using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MysteryNumberJkra
{
    public partial class Form1 : Form
    {
        private int LogLineJkra = 0;           // Counts log messages
        private int randomNumber = 0;          // The secret number to guess
        private int attemptsLeft = 0;          // How many guesses left
        private int wrongGuesses = 0;          // How many wrong guesses made
        private bool gameStarted = false;      // Is a game currently running?

        public Form1()
        {
            InitializeComponent();
        }

        // This runs when the form first loads
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "MysteryNumber Game";
            pbxStartScreenJkra.Left = groupBox1.Left;
            btnShowGameJkra.Left = btnLocateJkra.Left + 32;
            this.Width = pbxStartScreenJkra.Width + 32;
        }

        // Hide the start screen picture and button
        private void btnShowGameSgem_click(object sender, EventArgs e)
        {
            pbxStartScreenJkra.Visible = false;  // Hide picture
            btnShowGameJkra.Visible = false;     // Hide button
        }

        // START GAME BUTTON
        private void btgStartGameJkra_Click(object sender, EventArgs e)
        {
            int userStartAt = Convert.ToInt32(tbxStartAtJkra.Text);      // Start number
            int userEndAt = Convert.ToInt32(tbxEndAtJkra.Text);          // End number
            int userNrTries = Convert.ToInt32(cbxNoOfAttempstJkra.Text); // Number of attempts

            Random randomGenerator = new Random();
            randomNumber = randomGenerator.Next(userStartAt, userEndAt + 1);


            attemptsLeft = userNrTries;  // How many guesses the player has
            wrongGuesses = 0;            // Reset wrong guesses to zero
            gameStarted = true;          // Game is now active


            rtbInfoJkra.Clear();
            LogLineJkra = 0;
            UpdateLoggingText("NEW GAME STARTED!", "G");
            UpdateLoggingText("Mystery number is between " + userStartAt + " and " + userEndAt, "B");
            UpdateLoggingText("You have " + userNrTries + " tries!", "B");

            tbxMyGuessJkra.Enabled = true;
            btnGuessJkra.Enabled = true;
            tbxMyGuessJkra.Clear();
        }

        // This runs when you type in the guess textbox
        private void tbxMyGuessJkra_TextChanged(object sender, EventArgs e)
        {
            // Enable the Guess button only if there's text
            if (tbxMyGuessJkra.Text.Length > 0)
            {
                btnGuessJkra.Enabled = true;
            }
        }

        // GUESS BUTTON - This checks if your guess is correct
        private void btnGuessJkra_Click(object sender, EventArgs e)
        {
            //Get the player's guess from the textbox
            int userGuess = Convert.ToInt32(tbxMyGuessJkra.Text);

            // Check if the guess is correct
            if (userGuess == randomNumber)
            {
                // Player win scenario
                UpdateLoggingText("You guessed: " + userGuess, "B");
                UpdateLoggingText("CORRECT! YOU WIN!", "G");
                UpdateLoggingText("The number was: " + randomNumber, "G");

                MessageBox.Show("You guessed it! The number was " + randomNumber);

                // End the game
                gameStarted = false;
                tbxMyGuessJkra.Enabled = false;
                btnGuessJkra.Enabled = false;
            }
            else if (userGuess < randomNumber)
            {
                // Reduce attempts and update
                attemptsLeft = attemptsLeft - 1;
                wrongGuesses = wrongGuesses + 1;

                // Update labels and progress bar
                lblAttemptsLeftJkra.Text = attemptsLeft.ToString();
                lblWrongJkra.Text = wrongGuesses.ToString();
                pgbAttemptsLeftJkra.Value = attemptsLeft;

                // Check if out of attempts
                if (attemptsLeft == 0)
                {
                    UpdateLoggingText("GAME OVER! No attempts left!", "R");
                    UpdateLoggingText("The number was: " + randomNumber, "R");
                    MessageBox.Show("Game Over! The number was " + randomNumber);

                    gameStarted = false;
                    tbxMyGuessJkra.Enabled = false;
                    btnGuessJkra.Enabled = false;
                }
            }
            else // userGuess > randomNumber
            {
                // Reduce attempts and update
                attemptsLeft = attemptsLeft - 1;
                wrongGuesses = wrongGuesses + 1;

                // Update labels and progress bar
                lblAttemptsLeftJkra.Text = attemptsLeft.ToString();
                lblWrongJkra.Text = wrongGuesses.ToString();
                pgbAttemptsLeftJkra.Value = attemptsLeft;

                // Check if out of attempts
                if (attemptsLeft == 0)
                {
                    UpdateLoggingText("GAME OVER! No attempts left!", "R");
                    UpdateLoggingText("The number was: " + randomNumber, "R");
                    MessageBox.Show("Game Over! The number was " + randomNumber);

                    gameStarted = false;
                    tbxMyGuessJkra.Enabled = false;
                    btnGuessJkra.Enabled = false;
                }
            }

            // Clear the textbox for next guess
            tbxMyGuessJkra.Clear();
        }


        // ABOUT BUTTON - Shows information about the game
        private void btnAboutJkra_Click(object sender, EventArgs e)
        {
            string message = "Mystery Number Game\n";
            message = message + "Made by: Juliusz Krajewski\n\n";

            MessageBox.Show(message);
        }

        // CHEAT BUTTON - Shows the secret number (ends game)
        private void btnSheatJkra_Click(object sender, EventArgs e)
        {
            if (gameStarted == true)
            {
                UpdateLoggingText("The number is: " + randomNumber, "R");
                MessageBox.Show("The mystery number is: " + randomNumber);
            }
            else
            {
                MessageBox.Show("Start a game first!");
            }
        }

        // CLEAR BUTTON - Clears the log window
        private void btnClearJkra_Click(object sender, EventArgs e)
        {
            rtbInfoJkra.Clear();  // Clear all text
            LogLineJkra = 0;      // Reset line counter
        }

        // This function adds colored text to the log window
        private void UpdateLoggingText(string a_text, string a_colorCode)
        {
            // Pick the color based on the code
            Color m_logColor = Color.Blue;

            if (a_colorCode == "R")
            {
                m_logColor = Color.Red;      // Red for errors/wrong
            }
            else if (a_colorCode == "G")
            {
                m_logColor = Color.Green;    // Green for success
            }
            else if (a_colorCode == "B")
            {
                m_logColor = Color.Black;    // Black for info
            }

            // Add line number
            LogLineJkra = LogLineJkra + 1;
            string prefix = LogLineJkra.ToString("D4"); 

            // Add the colored text to the log
            rtbInfoJkra.SelectionStart = rtbInfoJkra.TextLength;
            rtbInfoJkra.SelectionLength = 0;
            rtbInfoJkra.SelectionColor = m_logColor;
            rtbInfoJkra.AppendText(prefix + " " + a_text + Environment.NewLine);
            rtbInfoJkra.SelectionColor = rtbInfoJkra.ForeColor;
            rtbInfoJkra.ScrollToCaret();
        }
    }
}
