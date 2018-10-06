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
 Module 3 Tip Tax and Total
 Project Description: User enters the meal price at a restaurant and when the 
    calculate button is clicked it calcuates the price of a 15% tip, 7% sales tax
    and then displays those values in addition to showing the total price of those
    included with the meal price.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M03_Davis_TipTaxAndTotal
{
    public partial class TipTaxAndTotal : Form
    {
        public TipTaxAndTotal()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // Declare variables
            double mealCost;
            double taxAmount;
            double tipAmount;
            double totalPrice;
            const double taxRate = 0.07;
            const double tipRate = 0.15;

            mealCost = double.Parse(mealPriceTextBox.Text);  // Parse user input for meal cost

            taxAmount = mealCost * taxRate; // Set tax amount
            tipAmount = mealCost * tipRate; // Set tip amount
            totalPrice = mealCost + taxAmount + tipAmount; // Set total Price today

            // Sets texboxes to the totals for each of their respective prices
            tipTextBox.Text = tipAmount.ToString("c");
            taxTextBox.Text = taxAmount.ToString("c");
            totalBillTextBox.Text = totalPrice.ToString("c");


        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
