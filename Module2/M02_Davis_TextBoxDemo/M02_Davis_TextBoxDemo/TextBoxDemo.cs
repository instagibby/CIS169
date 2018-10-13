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
 Module 2 TextBox Demo
 Project Description: Takes an input from a textbox and outputs
    it to a label and resets the textbox

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/


namespace M02_Davis_TextBoxDemo
{
    public partial class TextBoxDemo : Form
    {
        public TextBoxDemo()
        {
            InitializeComponent();
        }

        private void ReadInputButton_Click(object sender, EventArgs e)
        {
            // Declare string variable
            string enteredName;

            // Set enteredName to value entered
            enteredName = EnterYourNameBox.Text;

            // Set DisplayNameEntered to enteredName
            DisplayNameEntered.Text = enteredName;

            // Reset EnterYourNameBox's value
            EnterYourNameBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
