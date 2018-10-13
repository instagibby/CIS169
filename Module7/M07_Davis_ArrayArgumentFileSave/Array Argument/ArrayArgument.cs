using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/** =========================================================

 Spencer Davis
 Windows 7
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Module 7 Array Argument File Save
 Project Description: User clicks a button that loads an array into view as
    well as writes the array to a text file. After this it resets the array
    values to zero and prints it to the user as well.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace Array_Argument
{
    public partial class ArrayArgument : Form
    {
        public ArrayArgument()
        {
            InitializeComponent();
        }

        private void ArrayToTextFile(int[] numArray)
        {
            // Declare a StreamWriter variable
            StreamWriter outputFile;

            // Open the ArrayArgument.txt file for appending,
            // and get a streamWriter object.
            outputFile = File.AppendText("ArrayArgument.txt");

            // Write the array items to the file to the file.
            for (int i = 0; i < numArray.Length; i++)
            {
                outputFile.WriteLine(numArray[i]);
            }

            // Close the file
            outputFile.Close();

            // Let the user know the name was written.
            MessageBox.Show("The array was written");
        }

        // Click event handler for the goButton control.
        private void goButton_Click(object sender, EventArgs e)
        {
            // Create an int array.
            int[] numbers = { 1, 2, 3 };
           
            // Display the array in the list box.
            outputListBox.Items.Add("The array's original contents:");
            foreach (int number in numbers)
            {
                outputListBox.Items.Add(number);
            }

            //  Call method made to append array to text.
            ArrayToTextFile(numbers);

            // Pass the array to the SetToZero method.
            SetToZero(numbers);

            // Display the array in the list box again.
            outputListBox.Items.Add("");
            outputListBox.Items.Add("After calling SetToZero:");
            foreach (int number in numbers)
            {
                outputListBox.Items.Add(number);
            }
        }

        // The SetToZero method accepts an int array as an
        // argument and sets its elememts to 0.
        private void SetToZero(int[] iArray)
        {
            for (int index = 0; index < iArray.Length; index++)
            {
                iArray[index] = 0;
            }
        }

        // Click event handler for the exitButton control.
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
