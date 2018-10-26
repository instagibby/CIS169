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
 Module 8 Drink Vending Machine
 Project Description: User can select a soda to purchase, and then when the
    soda is purchased, it adds to the total sale of the machine. If there is
    no sodas left in the machine the user is informed it is out.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace MO8_Davis_DrinkVendingMachineProgram
{
    struct Soda
    {
        public string name;
        public double drinkCost;
        public int count;
    }

    public partial class DrinkVendingMachine : Form
    {
        const int SIZE = 5;
        Soda[] sodas = new Soda[SIZE];

        double totalSales = 0;

        public DrinkVendingMachine()
        {
            InitializeComponent();
            //  Create coke object
            sodas[0].name = "Coke";
            sodas[0].drinkCost = 1;
            sodas[0].count = 20;
            //  Create root beer object
            sodas[1].name = "Root Beer";
            sodas[1].drinkCost = 1.00;
            sodas[1].count = 20;
            //  Create sprite object
            sodas[2].name = "Sprite";
            sodas[2].drinkCost = 1;
            sodas[2].count = 20;
            //  Create grape soda object
            sodas[3].name = "Fanta";
            sodas[3].drinkCost = 1.5;
            sodas[3].count = 20;
            //  Create cream soda object
            sodas[4].name = "Cream Soda";
            sodas[4].drinkCost = 1.5;
            sodas[4].count = 20;
        }



        private void cokeBox_Click(object sender, EventArgs e)
        {
            //  Coke is clicked
            if (sodas[0].count > 0)
            {
                sodas[0].count--;
                cokeCountLabel.Text = sodas[0].count.ToString();
                totalSales += sodas[0].drinkCost;
                totalSalesCount.Text = totalSales.ToString("C");
            }
            else
            {
                MessageBox.Show("Sorry " + sodas[0].name + " is sold out!");
            }
            
        }

        private void rootbeerBox_Click(object sender, EventArgs e)
        {
            //  Rootbeer is clicked
            if (sodas[1].count > 0)
            {
                sodas[1].count--;
                rootbeerCountLabel.Text = sodas[1].count.ToString();
                totalSales += 1;
                totalSalesCount.Text = totalSales.ToString("C");
            }
            else
            {
                MessageBox.Show("Sorry " + sodas[1].name + " is sold out!");
            }
            
        }

        private void spriteBox_Click(object sender, EventArgs e)
        {
            // Sprite is clicked
            if (sodas[2].count > 0)
            {
                sodas[2].count--;
                spriteCountLabel.Text = sodas[2].count.ToString();
                totalSales += 1;
                totalSalesCount.Text = totalSales.ToString("C");
            }
            else
            {
                MessageBox.Show("Sorry " + sodas[2].name + " is sold out!");
            }
            
        }

        private void grapeBox_Click(object sender, EventArgs e)
        {
            // Grape is clicked
            if (sodas[3].count > 0)
            {
                sodas[3].count--;
                grapeCountLabel.Text = sodas[3].count.ToString();
                totalSales += 1.5;
                totalSalesCount.Text = totalSales.ToString("C");
            }
            else
            {
                MessageBox.Show("Sorry " + sodas[3].name + " is sold out!");
            }
            
        }

        private void creamBox_Click(object sender, EventArgs e)
        {
            // Cream is clicked
            if (sodas[4].count > 0)
            {
                sodas[4].count--;
                creamCountLabel.Text = sodas[4].count.ToString();
                totalSales += 1.5;
                totalSalesCount.Text = totalSales.ToString("C");
            }
            else
            {
                MessageBox.Show("Sorry " + sodas[4].name + " is sold out!");
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Exits
            this.Close();
        }
    }
}
