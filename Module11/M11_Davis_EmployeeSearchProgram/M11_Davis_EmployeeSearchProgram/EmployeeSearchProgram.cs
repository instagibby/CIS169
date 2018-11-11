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
 Module 11  Employee Search Program
 Project Description: User types in a name or part of a name to search the
    Employee Database for a match, the results are then shown in the table
     to the user if there is a match, or if there is more than one, shows them
    all.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/



namespace M11_Davis_EmployeeSearchProgram
{
    public partial class EmployeeSearchProgram : Form
    {
        public EmployeeSearchProgram()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);

        }

        private void EmployeeSearchProgram_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Exits Program
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Searches Employee Table for name match
            this.employeeTableAdapter.SearchName(
                this.employeeDataSet.Employee, SearchNameTextBox.Text);
        }
    }
}
