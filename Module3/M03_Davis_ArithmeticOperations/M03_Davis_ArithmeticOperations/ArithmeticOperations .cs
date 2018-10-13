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
 Module 3 Arithmetic Operations
 Project Description: Displays several operations when the show button is clicked

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M03_Davis_ArithmeticOperations
{
    public partial class ArithmeticOperations : Form
    {
        public ArithmeticOperations()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {

            // Pretty straight forward, does the math, displays answer after converting to a string and concatenating
            int additionAnswer = 15 + 20;
            string displayAdd = "15 + 20 = " + additionAnswer.ToString();
            AddDisplay.Text = displayAdd;

            int subtractionAnswer = 20 - 7;
            string displaySub = "20 - 7 = " + subtractionAnswer.ToString();
            SubtractionDisplay.Text = displaySub;

            int multiplicationAnswer = 7 * 5;
            string displayMulti = "7 * 5 = " + multiplicationAnswer.ToString();
            MultiplicationDisplay.Text = displayMulti;

            int divisionAnswer = 15 / 5;
            string displayDiv = "15 / 5 = " + divisionAnswer.ToString();
            DivisionDisplay.Text = displayDiv;

            int modulusAnswer = 10 % 4;
            string displayModulus = "10 % 4 = " + modulusAnswer.ToString();
            ModulusDisplay.Text = displayModulus;

            int incrementA = 15;
            incrementA = ++incrementA;
            string displayIncrement = "15++ = " + incrementA.ToString();
            IncrementDisplay.Text = displayIncrement;

            int decrementB = 15;
            decrementB = --decrementB;
            string displayDecrement = "15-- = " + decrementB.ToString();
            DecrementDisplay.Text = displayDecrement;

        }
    }
}
