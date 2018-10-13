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
 Module 2 Heads or Tails
 Project Description: When user clicks show heads, it displays a picture of coin's head,
    when tails is clicked, heads is hidden and tails is displayed. Flip it! gives a random
    number between 0-1000, and tests if the number is odd or even and then shows heads or tails.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M02_Davis_HeadsOrTails
{
    public partial class HeadsOrTails : Form
    {
        public HeadsOrTails()
        {
            InitializeComponent();

            /** =======================================================================
            
            Have the flip button selected because due to tab order, the Heads button 
            being ahead of the flip button, this allows the accept/enter key to work
            from the start of the program.

            ======================================================================= **/

            FlipButton.Select();

            // Hide both images
            HeadsImage.Visible = false;
            TailsImage.Visible = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exits
            this.Close();
        }

        private void ShowHeadsButton_Click(object sender, EventArgs e)
        {
            // Shows Heads Image by setting visibility to true
            HeadsImage.Visible = true;
            // Hides Tails Image by setting visibility to false
            TailsImage.Visible = false;
        }

        private void ShowTailsButton_Click(object sender, EventArgs e)
        {
            // Shows Tails Image by setting visibility to true
            TailsImage.Visible = true;
            // Hides Heads Image by setting visibility to false
            HeadsImage.Visible = false;
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            // This is the fun part - sets a variable equal to a random number and tests if even or odd
            Random random = new Random();
            int randomNumber = random.Next(0, 1000);
            if (randomNumber % 2 == 0)
            {
                // If Even - show heads and hides tails
                HeadsImage.Visible = true;
                TailsImage.Visible = false;
            }
            else
            {
                // If Odd - shows tails and hides heads
                HeadsImage.Visible = false;
                TailsImage.Visible = true;
            }
            
        }
    }
}
