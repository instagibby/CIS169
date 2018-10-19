using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSV_Reader
{
    public partial class CVSReader : Form
    {
        public CVSReader()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile; // To read the file
                string line;            // To hold a line from the file
                int count = 0;          // Student counter
                int total;              // Accumulator
                double average;         // Test score average

                // Create a delimiter array.
                char[] delim = { ',' };

                // Open the CSV file.
                inputFile = File.OpenText("Grades.csv");

                while (!inputFile.EndOfStream)
                {
                    // Increment the student counter
                    count++;

                    // Read a line form the file.
                    line = inputFile.ReadLine();

                    // Get the test scores as tokens.
                    string[] tokens = line.Split(delim);

                    // Set the accumulator to 0.
                    total = 0;

                    // Calculate the total of the test score tokens.
                    foreach (string str in tokens)
                    {
                        total += int.Parse(str);
                    }

                    // Caluclate hte average of these tests scores
                    average = (double)total / tokens.Length;

                    // Display the average
                    averagesListBox.Items.Add("The average for student " + count + " is " + average.ToString("n1"));
                }

                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                //  Displays error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
