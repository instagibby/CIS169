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
 Module 7 Tic-Tac-Toe Simulator
 Project Description: User clicks the new game button and a 2 dimensional
    array is created and is looped through to store a random 0 or 1 in each
    index. Then based on those results a many if statements are ran to set
    values for the display to be either an X (if 1) or a O (if 0). I decided
    to then save the values from each row / column / diagnal into a single int
    so that I can easily test if it was three in a row (three in a row has to
    to be either a zero or 3, else it is broken) This could have been achieved
    by comparing each individual item to see if it is the same as the one before
    it but that seemed like a significant amount of extra effort for the same end
    result. After those values are calculated the winner is checked and printed.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M07_Davis_TicTacToeSimulatorProgram
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        int[,] gameBoard = new int[3,3];
        Random rnd = new Random();

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[i, j] = rnd.Next(2);
                }
            }

            //      HERE SETS VALUES FOR DISPLAY
            //  TOP ROW
            //  LEFT
            if (gameBoard[0,0] == 0)
            {
                topLeftLabel.Text = "O";
            }
            else
            {
                topLeftLabel.Text = "X";
            }
            //  Center
            if (gameBoard[0, 1] == 0)
            {
                topCenterLabel.Text = "O";
            }
            else
            {
                topCenterLabel.Text = "X";
            }
            //  RIGHT
            if (gameBoard[0, 2] == 0)
            {
                topRightLabel.Text = "O";
            }
            else
            {
                topRightLabel.Text = "X";
            }

            //  CENTER ROW
            //  LEFT
            if (gameBoard[1, 0] == 0)
            {
                centerLeftLabel.Text = "O";
            }
            else
            {
                centerLeftLabel.Text = "X";
            }
            //  CENTER
            if (gameBoard[1, 1] == 0)
            {
                centerLabel.Text = "O";
            }
            else
            {
                centerLabel.Text = "X";
            }
            //  RIGHT
            if (gameBoard[1, 2] == 0)
            {
                centerRightLabel.Text = "O";
            }
            else
            {
                centerRightLabel.Text = "X";
            }

            //  BOTTOM
            //  LEFT
            if (gameBoard[2, 0] == 0)
            {
                bottomLeftLabel.Text = "O";
            }
            else
            {
                bottomLeftLabel.Text = "X";
            }
            //  CENTER
            if (gameBoard[2, 1] == 0)
            {
                bottomCenterLabel.Text = "O";
            }
            else
            {
                bottomCenterLabel.Text = "X";
            }
            //  RIGHT
            if (gameBoard[2, 2] == 0)
            {
                bottomRightLabel.Text = "O";
            }
            else
            {
                bottomRightLabel.Text = "X";
            }

            //      DISPLAY VALUE ENDS
            

            //  Variables for each row total
            int row1 = gameBoard[0,0] + gameBoard[0, 1] + gameBoard[0, 2];
            int row2 = gameBoard[1,0] + gameBoard[1, 1] + gameBoard[1, 2];
            int row3 = gameBoard[2,0] + gameBoard[2, 1] + gameBoard[2, 2];
            //  Variables for each column total
            int col1 = gameBoard[0,0] + gameBoard[1, 0] + gameBoard[2, 0];
            int col2 = gameBoard[0,1] + gameBoard[1, 1] + gameBoard[2, 1];
            int col3 = gameBoard[0,2] + gameBoard[1, 2] + gameBoard[2, 2];
            //  Diagnals
            int topLeftBottomRight = gameBoard[0, 0] + gameBoard[1, 1] + gameBoard[2, 2];
            int topRightBottomLeft = gameBoard[0, 2] + gameBoard[1, 1] + gameBoard[2, 0];

            //  Counts for *three in a row*
            int xWinningCount = 0;
            int oWinningCount = 0;

            //  Array of each rows total values to test and count
            int[] testCasesForPoints = { row1, row2, row3, col1, col2, col3, topRightBottomLeft, topLeftBottomRight };

            //  Runs foreach to test if the row is of 0 value (O + 1 point)
            //  if value is 3 (X + 1 point)
            foreach (int val in testCasesForPoints)
            {
                if (val == 0)
                {
                    oWinningCount++;
                }
                else if (val == 3)
                {
                    xWinningCount++;
                }
            }

            //  Tests win conditions to declare a winner or if it is a tie
            if ((xWinningCount > 0 && oWinningCount > 0) || (xWinningCount == 0 && oWinningCount == 0))
            {
                winnerLabel.Text = "Tie Game!";
            } else if (xWinningCount > oWinningCount)
            {
                winnerLabel.Text = "X Wins!";
            } else
            {
                winnerLabel.Text = "O Wins!";
            }
        }
        

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //  Exits
            this.Close();
        }
    }
}
