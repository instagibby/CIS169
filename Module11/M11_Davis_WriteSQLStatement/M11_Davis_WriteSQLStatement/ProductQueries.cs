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
 Module 11 Write SQL Statement
 Project Description: User clicks sort by price to sort the data by the price,
    if the products over 100 units is clicked, it displays the product to the user, 
    if the show $40 items it shows the products that cost more than $40, finally if
    show most expensive product is clicked, it will print a message to the user to
    display the most expensive price.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/


namespace M11_Davis_WriteSQLStatement
{
    public partial class ProductQueries : Form
    {
        public ProductQueries()
        {
            InitializeComponent();
            ExitBtn.Visible = false;
        }


        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDBDataSet);

        }

        private void ProductQueries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);

        }

        private void sortByPriceButton_Click(object sender, EventArgs e)
        {
            // Sorts by Price
            this.productTableAdapter.FillByPrice(this.productDBDataSet.Product);
        }

        private void unitsGreater100Button_Click(object sender, EventArgs e)
        {
            // Shows Greater than 100 Units
            this.productTableAdapter.FillByUnits(this.productDBDataSet.Product);
        }

        private void fortyPlusBtn_Click(object sender, EventArgs e)
        {
            // Products over $40
            this.productTableAdapter.ProductsOver40(this.productDBDataSet.Product);
        }

        private void maxPriceBtn_Click(object sender, EventArgs e)
        {
            // Displays max price product to user
            decimal maxPrice = 0;
            maxPrice = (decimal)this.productTableAdapter.MaxPrice();
            MessageBox.Show("Max price is: " + maxPrice.ToString());
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
