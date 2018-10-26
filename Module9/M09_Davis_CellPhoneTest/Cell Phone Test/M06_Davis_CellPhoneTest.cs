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
 Module 9 Cell Phone Test
 Project Description: User inputs a brand, model and price of a phone and
    then the information is validated and if it is correct it is displayed
    to the user. If the info is not valid, an appropriate response is 
    displayed to the user and judgement is held.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace Cell_Phone_Test
{
    public partial class M06_Davis_CellPhoneTest : Form
    {
        public M06_Davis_CellPhoneTest()
        {
            InitializeComponent();
        }
        // The GetPhoneData method accepts a CellPhone object
        // as an argument. It assigns the data entered by the
        // user to the object's properties.
        private void GetPhoneData(CellPhone phone)
        {
            // Temporary variable to hold the price.
            decimal price;

            /* 
             * I added specific validation for each possible option and
             * since I was instructed to individualize this, I thought I
             * would include a bit of sassy attitude to the responses.
             * if there isn't a match the user gets feedback and a 
             * bit of judgement as well.
             */
            // Variable to hold if the brand and model name pass
            bool validPhone = false;

            // Get the phone's brand.
            string brandName = brandTextBox.Text.ToLower();

            // Get the phone's model.
            string modelName = modelTextBox.Text.ToLower(); ;

            switch (brandName)
            {
                case "iphone":
                    switch (modelName)
                    {
                        case "x":
                            phone.Model = modelTextBox.Text;
                            phone.Brand = brandTextBox.Text;
                            validPhone = true;
                            break;
                        case "8":
                            phone.Model = modelTextBox.Text;
                            phone.Brand = brandTextBox.Text;
                            validPhone = true;
                            break;
                        default:
                            MessageBox.Show("That phone doesn't exist!");
                            break;
                    }
                    break;
                case "samsung":
                    switch (modelName)
                    {
                        case "galaxy":
                            phone.Model = modelTextBox.Text;
                            phone.Brand = brandTextBox.Text;
                            validPhone = true;
                            break;
                        case "note":
                            phone.Model = modelTextBox.Text;
                            phone.Brand = brandTextBox.Text;
                            validPhone = true;
                            break;
                        default:
                            MessageBox.Show("That phone doesn't exist!");
                            break;
                    }
                    break;
                case "google":
                    switch (modelName)
                    {
                        case "pixel":
                            phone.Model = modelTextBox.Text;
                            phone.Brand = brandTextBox.Text;
                            validPhone = true;
                            break;
                        case "pixel xl":
                            phone.Model = modelTextBox.Text;
                            phone.Brand = brandTextBox.Text;
                            validPhone = true;
                            break;
                        default:
                            MessageBox.Show("That phone doesn't exist!");
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("Nice phone brand, ya hipster. Try again.");
                    break;
            }
            


            // Get the phone's price.
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                // Price is within the specified range and phone model/brand is valid
                if (price > (decimal)0.01 && price < 2000 && validPhone)
                {
                    phone.Price = price;
                }
                else
                {   
                    if ( price < (decimal)0.01)
                    {
                        MessageBox.Show("What kind of phone price is that?");
                    }
                    else
                    {
                        MessageBox.Show("Who would buy a phone for that price?!?");
                    }
                }
                
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid price");
            }

            // Resets text boxes
            brandTextBox.Text = "";
            modelTextBox.Text = "";
            priceTextBox.Text = "";

        }
        private void createObjectButton_Click(object sender, EventArgs e)
        {
            // Create a CellPhone object.
            CellPhone myPhone = new CellPhone();

            // Get the phone data.
            GetPhoneData(myPhone);

            // Display the phone data.
            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
