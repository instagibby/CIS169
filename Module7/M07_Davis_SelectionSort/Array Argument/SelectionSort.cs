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
 Module 7 Selection Sort
 Project Description: User clicks a go button that prints an array,
    when the user clicks the sort button it displays a message box with
    the array printed in descending order

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace Array_Argument
{
    public partial class SelectionSort : Form
    {
        public SelectionSort()
        {
            InitializeComponent();
        }
        // Create an int array.
        int[] numbers = { 1, 2, 3 };

        // Click event handler for the goButton control.
        private void goButton_Click(object sender, EventArgs e)
        {
            
           
            // Display the array in the list box.
            outputListBox.Items.Add("The array's original contents:");
            foreach (int number in numbers)
            {
                outputListBox.Items.Add(number);
            }

        }

        //  takes array as argument and sorts ascending, then reverses as
        //  we want descending order. It then saves the values from the array
        //  into a string to print to the user using foreach
        private void SortArray(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            String printableIntArray = "";
            foreach (int value in array) printableIntArray+= (value.ToString() + " ");
            MessageBox.Show("Sorted: " + printableIntArray);
        }

        // Click event handler for the exitButton control.
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        //  Click event handler for the SortBtn control
        private void SortBtn_Click(object sender, EventArgs e)
        {
            SortArray(numbers);
        }
    }
}
