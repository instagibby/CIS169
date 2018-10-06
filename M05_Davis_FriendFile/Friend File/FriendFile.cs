using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

/** =========================================================

 Spencer Davis
 Windows 7
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Module 5 File I/O
 Project Description:   User can input a name to be added to a friendlist
    text file that is stored to be printed to the display with the read file
    button. The name is ran through a regex test to confirm it only contains 
    letters and no numbers.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace Friend_File
{
    public partial class FriendFile : Form
    {
        public FriendFile()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                string textInput = nameTextBox.Text;

                // Rusn if statement with regex to test for the
                // input having only letters
                if (Regex.IsMatch(textInput, @"^[a-zA-Z]+$"))
                {
                    // Declare a StreamWriter variable
                    StreamWriter outputFile;

                    // Open the Friend.txt file for appending,
                    // and get a streamWriter object.
                    outputFile = File.AppendText("Friend.txt");

                    // Write the friend's name to the file.
                    outputFile.WriteLine(textInput);

                    // Close the file
                    outputFile.Close();

                    // Let the user know the name was written.
                    MessageBox.Show("The name was written");

                    // Clear the textbox control.
                    nameTextBox.Text = "";

                    // Give hte focus to the nameTextBox control.
                    nameTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Please enter a name without numbers!");
                }

                   

            } catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {

            try
            {
                // Declare a StreamWriter variable.
                StreamReader inputFile = null;

                // Declare variable to hold friend name.
                string friendName;

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("Friend.txt");

                // Clear anything currently in the textbox.
                FriendListListBox.Items.Clear();

                // Read the file's contents.
                while (!inputFile.EndOfStream)
                {
                    //Get friend name.
                    friendName = inputFile.ReadLine();

                    // Add name to the list box.
                    FriendListListBox.Items.Add(friendName);
                }
                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }
    }
}
