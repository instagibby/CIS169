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
 Module 6 Cards Tutorial
 Project Description: User selects a card to be displayed from the list and 
    it then shows that card. If another card is showing it hides that card 
    and shows the card selected.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace Cards
{
    public partial class Cards : Form
    {
        public Cards()
        {
            InitializeComponent();
        }
        
        //  The ShowCard method accepts a string that names
        //  the selected card, and displays that card.
        private void ShowCard(string card)
        {
            switch (card)
            {
                case "Ace of Spades":
                    ShowAceSpades();
                    break;
                case "10 of Hearts":
                    ShowTenHearts();
                    break;
                case "King of Clubs":
                    ShowKingClubs();
                    break;
            }
        }

        //  The ShowAceSpades method makes the Ace of Spades
        //  visible and the other cards invisible.
        private void ShowAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }

        //  The ShowTenHearts method makes the 10 of Hearts
        //  visible and the other cards invisible.
        private void ShowTenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }

        //  The ShowKingClubs method makes the King of Clubs
        //  visible and the other cards invisible.
        private void ShowKingClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }


        private void showCardButton_Click(object sender, EventArgs e)
        {
            //  If a card is selected in the ListBox, display it.
            if (cardListBox.SelectedIndex != -1)
            {
                ShowCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a card from " + "the list box.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //  Close the form.
            this.Close();
        }
    }
}
