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
 Module 4 Days of the Week
 Project Description: User inputs a number and then based on how large the
    program will display to the user the amount of days/hours/minutes/seconds
    the number input has. 

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M04_Davis_TimeCalculatorProgram
{
    public partial class TimeCalculatorProgram : Form
    {
        public TimeCalculatorProgram()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // Declare constants for minutes per day/hour/minute
            const int SECONDS_IN_DAY = 86400;
            const int SECONDS_IN_HOUR = 3600;
            const int SECONDS_IN_MINUTE = 60;

            double daysFromSeconds;
            double daysRounded;
            double hoursFromSeconds;
            double hoursRounded;
            double minutesFromSeconds;
            double minutesRounded;
            double updatedSeconds;

            // Try used so I can use parse and it will throw an exception
            try
            {
                // Pull parse seconds from the user input
                double userInputSeconds = double.Parse(secondsInputTextBox.Text);
                // Updated seconds so that the remainder can be passed from each set to the next
                updatedSeconds = userInputSeconds;

                /*
                 * Didn't use if statements because it seemed like a whole lot of extra code,
                 * in the scenario you don't have enough seconds to fill a Day/hour/minute it passes a 
                 * zero through so it carries on without changing the total seconds.
                 */
                // Days
                daysFromSeconds = userInputSeconds / SECONDS_IN_DAY;    // Gets days as a double
                daysRounded = Math.Floor(daysFromSeconds);              // rounds down the days
                daysPrintLabel.Text = daysRounded.ToString();           // Puts days into label
                //Updates the remaining seconds by removing the amount of seconds in the days category
                updatedSeconds = updatedSeconds - (daysRounded * SECONDS_IN_DAY);
                
                // Hours
                hoursFromSeconds = updatedSeconds / SECONDS_IN_HOUR;    // Gets hours as a double
                hoursRounded = Math.Floor(hoursFromSeconds);            // rounds down the hours
                hoursPrintLabel.Text = hoursRounded.ToString();         // Puts hours into label
                //Updates the remaining seconds by removing the amount of seconds in the hours category
                updatedSeconds = updatedSeconds - (hoursRounded * SECONDS_IN_HOUR);

                // Minutes
                minutesFromSeconds = updatedSeconds / SECONDS_IN_MINUTE;    // Gets minutes as a double
                minutesRounded = Math.Floor(minutesFromSeconds);            // rounds down the minutes
                minutesPrintLabel.Text = minutesRounded.ToString();         // Puts hours into label
                //Updates the remaining seconds by removing the amount of seconds in the minutes category
                updatedSeconds = updatedSeconds - (minutesRounded * SECONDS_IN_MINUTE);

                // Seconds
                 secondsPrintLabel.Text = updatedSeconds.ToString(); // Attaches remaining seconds to seconds label
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Please enter a number!");
            }


        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            secondsInputTextBox.Text = "";
            daysPrintLabel.Text = "0";
            hoursPrintLabel.Text = "0";
            minutesPrintLabel.Text = "0";
            secondsPrintLabel.Text = "0";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
