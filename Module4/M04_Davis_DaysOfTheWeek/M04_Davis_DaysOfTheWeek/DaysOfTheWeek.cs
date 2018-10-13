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
 Project Description: User enters a number (hopefully) and then when the button
    is clicked it tests if it is a number, then tests if it is from 1-7 and if that
    is true, the input is ran through a switch to tell the user what day it is. Otherwise 
    if the input isn't a number a message box asks for a number, and if the number isn't
    from 1-7 then a different box asks the user to enter a number from 1-7.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M04_Davis_DaysOfTheWeek
{
    public partial class DaysOfTheWeek : Form
    {
        public DaysOfTheWeek()
        {
            InitializeComponent();
        }

        private void showDayBtn_Click(object sender, EventArgs e)
        {

            if (Int32.TryParse(numberInputTextBox.Text, out int textInputNumber))
            {
                if (textInputNumber >= 1 && textInputNumber <=7 )
                {
                    switch (textInputNumber)
                    {
                        case 1:
                            todayIsDisplay.Text = "Monday";
                            break;
                        case 2:
                            todayIsDisplay.Text = "Tuesday";
                            break;
                        case 3:
                            todayIsDisplay.Text = "Wednesday";
                            break;
                        case 4:
                            todayIsDisplay.Text = "Thursday";
                            break;
                        case 5:
                            todayIsDisplay.Text = "Friday";
                            break;
                        case 6:
                            todayIsDisplay.Text = "Saturday";
                            break;
                        case 7:
                            todayIsDisplay.Text = "Sunday";
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("A Number from 1-7 please!");
                }
                
            }
            else
            {
                MessageBox.Show("Please Enter a number");
            }
                
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
