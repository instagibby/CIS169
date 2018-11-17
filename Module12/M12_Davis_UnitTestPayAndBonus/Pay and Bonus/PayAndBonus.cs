using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



/** =========================================================

 Spencer Davis
 Windows 7
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Module 12 Pay and Bonus Unit Testing
 Project Description: User inputs a gross pay and a bonus amount and
    recieves back a value that is being contributed to their retirement fund.
    The data is tested as it is recieved to confirm it is valid data.

    UNIT TESTING: 4 unit tests to test two valid, two invalid, first valid and
    second invalid, and finally first invalid and second valid.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace Pay_and_Bonus
{
    public partial class PayAndBonus : Form
    {
        //  Constant field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public PayAndBonus()
        {
            InitializeComponent();
        }
        //  Variables for gross pay, bonus, and contributions
        decimal pay = 0m, bonus = 0m, contributions = 0m;
        //  The InputIsValid method converts the user input and stores
        //  it in the arguments (passed by reference). If the conversion
        //  is successful, the method returns true. Otherwise it returns
        //  false.
        public bool InputIsValid(string gp, string b)
        {
            //  Flag variable to indicate whether the input is good.
            bool inputGood = false;

            //  Try to conver both inputs to decimal.
            if (decimal.TryParse(gp, out pay))
            {
                if (decimal.TryParse(b, out bonus))
                {
                    //  Both inputs are good.
                    inputGood = true;
                }
                else
                {
                    //  Display an error message for the bonus.
                    MessageBox.Show("Bonus amount is invalid.");
                }
            }
            else
            {
                //  Display an error message for the gross pay.
                MessageBox.Show("Gross pay is invalid.");
            }

            //  Return the result
            return inputGood;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string grossPayInput = grossPayTextBox.Text;
            string bonusInput = bonusTextBox.Text;

            if (InputIsValid(grossPayInput, bonusInput))
            {
                // Calculate the amount of contribution.
                contributions = (pay + bonus) * CONTRIB_RATE;

                // Display the contribution
                contributionLabel.Text = contributions.ToString("c");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //  Close the form
            this.Close();
        }
    }
}
