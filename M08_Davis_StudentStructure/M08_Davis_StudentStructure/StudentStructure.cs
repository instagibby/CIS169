using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/** =========================================================

 Spencer Davis
 Windows 7
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Module 8 Student Structure
 Project Description: User inputs a student name, student ID and major. 
    The values are taken from the user input and if they are valid will
    then print them to the user in a display message, otherwise it tells the
    user what they need to fix.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M08_Davis_StudentStructure
{
    struct Student
    {
        public string name;
        public int studentID;
        public string major;
    }

    public partial class StudentStructure : Form
    {
        public StudentStructure()
        {
            InitializeComponent();
        }

        private void DisplayStudent(Student student)
        {
            MessageBox.Show("Hello " + student.name + "!\nWelcome to DMACC, your" +
                " selected major is: " + student.major + ".\nYour Student ID is: " + 
                student.studentID + " try to keep it to yourself.");
        }


        public void CreateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // Makes a New student newStudent 
                Student newStudent = new Student();
                bool validStudent = false;
                int studentID;

                if (Regex.IsMatch(studentNameTextBox.Text, @"^[a-zA-Z]+$")) // Tests name input
                {
                    newStudent.name = studentNameTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Please only enter letters into the name.");
                }

                if (Regex.IsMatch(studentMajorTextBox.Text, @"^[a-zA-Z]+$")) // Tests Major input
                {
                    newStudent.major = studentMajorTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Please only enter letters into your major.");
                }

                if (int.TryParse(studentIDTextBox.Text, out studentID))
                {
                    newStudent.studentID = studentID;
                }
                else
                {
                    MessageBox.Show("Please only enter numbers into your student ID.");
                }

                if (validStudent)
                {
                    DisplayStudent(newStudent);
                }
                else
                {
                    MessageBox.Show("Please try again.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Exits
            this.Close();
        }
    }
}
