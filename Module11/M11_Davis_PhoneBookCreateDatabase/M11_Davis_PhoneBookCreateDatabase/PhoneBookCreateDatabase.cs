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
 Module 11 Phone Book Create Database / DataGridView
 Project Description: User is displayed a table and can edit, add or delete
    values of the table.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/


namespace M11_Davis_PhoneBookCreateDatabase
{
    public partial class PhoneBookCreateDatabase : Form
    {
        public PhoneBookCreateDatabase()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phonelistDataSet);

        }

        private void PhoneBookCreateDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonelistDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.phonelistDataSet.Person);

        }
    }
}
