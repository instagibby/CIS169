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
 Module 3 Sale Price Calculator
 Project Description: Takes a value from input for price, discount percent and then
    calculates the discount amount based on the percent and original price then outputs
    the sale price of the item.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M03_Davis_ExceptionHandling
{
    public partial class SalePriceCalculator : Form
    {
        public SalePriceCalculator()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                decimal originalPrice;
                decimal discountPercentage;
                decimal discountAmount;
                decimal salePrice;

                // Parses input and sets the price to a decimal from the string 
                originalPrice = decimal.Parse(originalPriceTextBox.Text);

                discountPercentage = decimal.Parse(discountPercentageTextBox.Text);
                discountPercentage = discountPercentage / 100;

                discountAmount = originalPrice * discountPercentage;

                salePrice = originalPrice - discountAmount;

                salePriceTextBox.Text = salePrice.ToString("c");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
