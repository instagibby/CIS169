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
 Module 4 Controls & Compound Conditions
 Project Description: User selects a city and then checks a box to unlock the
    OK button and when pressed it displays the time zone for the selected city.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M04_Davis_ControlsAndCompoundCondition
{
    public partial class ControlsAndCompoundCondition : Form
    {
        public ControlsAndCompoundCondition()
        {
            InitializeComponent();
            okButton.Enabled = false;

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city;    // To hold the name of a city

            if (cityListBox.SelectedIndex != -1)
            {
                // Get the selected item.
                city = cityListBox.SelectedItem.ToString();

                // Determine the time zone.
                if (city == "San Francisco")
                {
                    timeZoneLabel.Text = "Pacific";
                }
                /* 
                 * This next comparison runs no differently than the next that immediately 
                 * follows when code runs, this is because the button cannot be clicked if the 
                 * SubmitCheckBox.Checked != true. Though the assignemnt asked for 
                 * this and so I didn't replace the original option as it simply says,
                 * "add a condition" not replace. Though if I reordered them and put the
                 * original where it doesn't check the checkbox the second wouldn't run due
                 * to the (city == "honolulu") resulting in true and excuting the code.
                 */
                else if (city == "Honolulu" && SubmitCheckBox.Checked == true) 
                {
                    timeZoneLabel.Text = "Hawaii-Aleutian";
                }
                else if (city == "Honolulu")
                {
                    timeZoneLabel.Text = "Hawaii-Aleutian";
                }
                else if (city == "Denver")
                {
                    timeZoneLabel.Text = "Mountain";
                }
                else if (city == "Minneapolis")
                {
                    timeZoneLabel.Text = "Central";
                }
                else if (city == "New York")
                {
                    timeZoneLabel.Text = "Eastern";
                }
                
            }
            else
            {
                // No city was selected.
                MessageBox.Show("Select a city.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void SubmitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SubmitCheckBox.Checked)
            {
                okButton.Enabled = true;
            }
            else
            {
               okButton.Enabled = false;

            }
        }
    }
}
