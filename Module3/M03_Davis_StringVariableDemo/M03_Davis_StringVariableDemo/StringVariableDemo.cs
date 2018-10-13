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
 Module 3 String Variable Demo
 Project Description: User enters their first and last name and it displays the 
    full name concatenated with only the first letters of the first and last name capitalized

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/


namespace M03_Davis_StringVariableDemo
{
    public partial class StringVariableDemo : Form
    {
        public StringVariableDemo()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Sets variables to the content of the textboxes
            String firstName = FirstNameInput.Text;
            firstName = firstName.ToLower();
            firstName = char.ToUpper(firstName[0]) + firstName.Substring(1);

            String lastName = LastNameInput.Text;
            lastName = lastName.ToLower();
            lastName = char.ToUpper(lastName[0]) + lastName.Substring(1);

            // Concatenates the two strings to one variable with a space
            string fullName = firstName + " " + lastName;

            // Sets the text of the last label to the new full name
            FullNameDisplay.Text = fullName;
           
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
