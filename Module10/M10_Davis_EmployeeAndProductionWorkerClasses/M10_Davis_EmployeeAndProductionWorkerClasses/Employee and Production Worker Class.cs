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
 Module 10 
 Project Description:

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M10_Davis_EmployeeAndProductionWorkerClasses
{
    public partial class EmployeeAndProductionWorkerClass : Form
    {
        public EmployeeAndProductionWorkerClass()
        {
            InitializeComponent();
        }

        private void CreateWorkerBtn_Click(object sender, EventArgs e)
        {
            // Variables to hold input
            string name;
            int number = -1;
            int shiftNo = 0;
            double payRate = -1;

            
            try
            {
                name = employeeNameTextBox.Text;
                number = int.Parse(employeeNumberTextBox.Text);
                payRate = double.Parse(employeePayRateTextBox.Text);

                if (dayShiftCheckBox.Checked)
                {
                    shiftNo = 1;
                }
                else if (nightShiftCheckBox.Checked)
                {
                    shiftNo = 2;
                }
                else
                {
                    MessageBox.Show("Please Select Night/Day shift.");
                }

                if (name != "" && number != -1 && shiftNo != 0 && payRate != -1 )
                {
                    ProductionWorker myMan = new ProductionWorker(name, number, shiftNo, payRate);

                    nameDisplayLabel.Text = myMan.EmployeeName;
                    numberDisplayLabel.Text = myMan.EmployeeNumber.ToString();
                    shiftNumberDisplay.Text = "Shift no: " + myMan.ShiftNo.ToString();
                    hourlyRateDisplay.Text = myMan.HourlyRate.ToString("c");


                } else
                {
                    MessageBox.Show("Please enter all fields");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
           

           

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Closes Form
            this.Close();
        }
    }
}
