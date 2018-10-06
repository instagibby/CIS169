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
 Module 6 Hospital Charges
 Project Description: A user enters values for the medical charges for a patient's
    hospital stay and it calculates the price of the stay. The only requirement is
    that the values are positive numbers and that the stay was for atleast one day.
    Error are printed if a mistake is made.


 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M06_Davis_HospitalCharges
{
    public partial class HospitalCharges : Form
    {
        public HospitalCharges()
        {
            InitializeComponent();
        }

        //  Decalares variables and constant rate for a day
        const int DAY_RATE = 350;
        String errorMsg = "";
        int baseCostStay = 0;
        double miscFees = 0;

        private int CalcStayCharges()
        {
            //  Parses for days and validates its atleast one day
            if (int.TryParse(daysSpentTextBox.Text, out int daysSpentValue) && daysSpentValue >= 1)
            {
                baseCostStay = daysSpentValue * DAY_RATE;
            }
            else
            {
                errorMsg += "Please enter a whole number into the days box. \n";
            }

            return baseCostStay;
        }

        private double CalcMiscCharges()
        {
            //  Parses for medication charges and validates its not negative
            if (double.TryParse(medicationTextBox.Text, out double medicationCharge) && medicationCharge >= 0)
            {
                miscFees += medicationCharge;
            }
            else
            {
                errorMsg += "Please enter a valid number into the medication box. \n";
            }

            //  Parses for surgical charges and validates its not negative
            if (double.TryParse(surgicalTextBox.Text, out double surgicalCharge) && surgicalCharge >= 0)
            {
                miscFees += surgicalCharge;
            }
            else
            {
                errorMsg += "Please enter a valid number into the surgical box. \n";
            }

            // Parses for lab fees and validates its not negative
            if (double.TryParse(labFeesTextBox.Text, out double labFees) && labFees >= 0)
            {
                miscFees += labFees;
            }
            else
            {
                errorMsg += "Please enter a valid number into the lab fees box. \n";
            }

            //  Parses for physical rehab charges and validates its not negative
            if (double.TryParse(physicalRehabTextBox.Text, out double physicalRehabCharges) && physicalRehabCharges >= 0)
            {
                miscFees += physicalRehabCharges;
            }
            else
            {
                errorMsg += "Please enter a valid number into the medication box. \n";
            }

            return miscFees;
        }

        //  Calculates total charges by running the two previous methods
        private double CalcTotalCharges()
        {
            return CalcStayCharges() + CalcMiscCharges();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //  Runs code to test following if statement
            CalcTotalCharges();

            //  Confirms there was no error
            if (errorMsg.Length > 0)
            {
                //  Shows all the errors saved
                MessageBox.Show(errorMsg);
                errorMsg = ""; //   Resets 'error log'
            }
            else
            {
                //  Success due to no errors, prints the data returned from the
                //  methods into the appropriate labels.
                baseChargeValueLabel.Text = CalcStayCharges().ToString("c");
                miscChargeValueLabel.Text = CalcMiscCharges().ToString("c");
                totalChargeValueLabel.Text = CalcTotalCharges().ToString("c");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //  Closes form
            this.Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //  Resets variables and textboxes
            errorMsg = "";
            baseCostStay = 0;
            miscFees = 0;
            baseChargeValueLabel.Text = "";
            miscChargeValueLabel.Text = "";
            totalChargeValueLabel.Text = "";
            daysSpentTextBox.Text = "";
            medicationTextBox.Text = "";
            surgicalTextBox.Text = "";
            labFeesTextBox.Text = "";
            physicalRehabTextBox.Text = "";
            daysSpentTextBox.Focus();

        }
    }
}
