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
 Module 8 Picture Frame
 Project Description: User clicks the photo frame and it cycles through
    an image list that is stored separately.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M08_Davis_PictureFrame
{
    public partial class PictureFrame : Form
    {
        public PictureFrame()
        {
            InitializeComponent();
        }

        int count = 0;

        private void PictureBoxDisplay_Click(object sender, EventArgs e)
        {
            // Increments
            count++;

            if (count <= 4) // Where count is within range of pictureBoxDisplay
            {
                PictureBoxDisplay.Image = photoList.Images[count];
            }
            else // Where count exceeds the index and so the index is reset to 0
            {
                count = 0;
                PictureBoxDisplay.Image = photoList.Images[count];
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Exits
            this.Close();
        }
    }
}
