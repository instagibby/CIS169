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
 Module 9 Multiform Practice Tutorial
 Project Description: User clicks the show form button, and the form
    is displayed. User can then exit the form with the exit button.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace Multiform_Practice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void displayFormButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the MessageForm class.
            MessageForm myMessageForm = new MessageForm();

            // Display the form.
            myMessageForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
