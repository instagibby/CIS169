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
 Module 10 Computer Science Student
 Project Description: User can enter a student name and id number and 
    it creates a new student, based on which checkbox is selected it displays
    hours required. There is a reset button that resets all the values on the
    form as well as an exit button.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace Computer_Science_Student
{
    public partial class ComputerScienceStudent : Form
    {
        public ComputerScienceStudent()
        {
            InitializeComponent();
        }

        private void getHoursButton_Click(object sender, EventArgs e)
        {
            // Variables to hold input
            string name, id, track;

            // Get the student's name and ID.
            name = nameTextBox.Text;
            id = idTextBox.Text;

            // Get the student's academic track.
            if (infoSystemsRadioButton.Checked)
            {
                track = "Information Systems";
            }
            else
            {
                track = "Software Engineering";
            }

            // Create a CompSciStudent object.
            CompSciStudent csStudent =
                new CompSciStudent(name, id, track);

            // Display the student's required hours.
            requiredHoursLabel.Text = csStudent.RequiredHours.ToString("n1");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the form
            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            idTextBox.Text = "";
            softwareEngineeringRadioButton.Checked = false;
            infoSystemsRadioButton.Checked = false;
            requiredHoursLabel.Text = "";
        }
    }
}
