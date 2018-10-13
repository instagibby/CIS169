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
 Module 7 Array Argument Algorithm
 Project Description: User clicks a go button that loads an array with 15
    random numbers from 0-1000 and prints the numbers to the user. When the
    user clicks the find max button it gets the max value in the array and
    displays it the the user, the find min displays the smallest number to
    the user.

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

        // Create an int array.
        int[] numbers = new int[15];
        Random rnd = new Random();

        // Click event handler for the goButton control.
        private void goButton_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i < numbers.Length; i++)
            {
                //  Using numbers 0-1000 because without a cap 
                //  some are super massive
                numbers[i] = rnd.Next(1000);
            }

            // Display the array in the list box.
            outputListBox.Items.Add("The array's original contents:");
            foreach (int number in numbers)
            {
                outputListBox.Items.Add(number);
            }
        }

        //  Not sure if you wanted me to loop through the array
        //  and then store the largest / smallest value based off 
        //  of an if statement comparing the previous and the new,
        //  as to save the highest value but seemed unnessecary as 
        //  .Max() and .Min() exists
        private int FindMaxInArray(int[] array)
        {
            int max = array.Max();
            return max;
        }

        private int FindMinInArray(int[] array)
        {
            int min = array.Min();
            return min;
        }

        // Click event handler for the exitButton control.
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        //  Click event handler for find max button
        private void FindMaxBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Max: " + FindMaxInArray(numbers).ToString());
        }

        //  Click event handler for find min button
        private void FindMinBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Min: " + FindMinInArray(numbers).ToString());
        }
    }
}
