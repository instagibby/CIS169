using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/** =========================================================

 Spencer Davis
 Windows 7
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Module 5 Random Number Guessing Game
 Project Description: User enters a value to test against the random number
    the game has generated. If the number is too high, or too low, the user
    is told to guess again and instructed if it was too high or low. If the
    user gets the guess correct, they are congratulated as well as told the
    amount of guesses it took to get the guess right. At that point the game 
    is reset, count set to zero, and the guess number is rerandomed.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M05_Davis_RandomNumberGuessingGame
{
    public partial class RandomNumberGuessingGame : Form
    {
        public RandomNumberGuessingGame()
        {
            InitializeComponent();
        }
        // Declare variables
        int guessCount = 0;
        int randomNumber = 0;

        private void RandomNumberGuessingGame_Load(object sender, EventArgs e)
        {
            // Randomize a number when the game loads
            Random random = new Random();
            randomNumber = random.Next(1, 101);
        }

        private void CheckGuessBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the user input to declare a variable as an int
                int inputInt = int.Parse(UserInputTextBox.Text);

                // Tests the value the user entered
                if (randomNumber < inputInt)    // Too high
                {
                    guessCount++;
                    MessageBox.Show("Too high, try again.");
                    UserInputTextBox.Text = "";
                } 
                else if (randomNumber > inputInt)   // Too low
                {
                    guessCount++;
                    MessageBox.Show("Too low, try again.");
                    UserInputTextBox.Text = "";
                }
                else if ( randomNumber == inputInt) // Winner winner
                {
                    guessCount++;
                    MessageBox.Show("Congratulations You win! Feel free to play again.");
                    MessageBox.Show("Your guess count was: " + guessCount.ToString());
                    Random random = new Random();
                    randomNumber = random.Next(1, 101);
                    UserInputTextBox.Text = "";
                    guessCount = 0;
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
