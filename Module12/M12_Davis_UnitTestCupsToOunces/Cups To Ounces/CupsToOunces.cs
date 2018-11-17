using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class CupsToOunces : Form
    {
        public CupsToOunces()
        {
            InitializeComponent();
        }

        // The CupsToOz method accepts a number
        // of cups as an argument and returns the
        // equivalent number of fluid ounces
        public double CupsToOz(double cups)
        {
            if (cups < 0)
            {
                throw new ArgumentException("Invalid Number");
            }
            return cups * 8.0;
        }
        public void convertButton_Click(object sender, EventArgs e)
        {
            // Varaibles to hold cups and ounces
            double cups, ounces;

            

            // Get the number of cups;
            if (double.TryParse(cupsTextBox.Text, out cups))
            {
                
                // Convert cups to ounces
                ounces = CupsToOz(cups);

                // Display the ounces
                ouncesLabel.Text = ounces.ToString("n1");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
