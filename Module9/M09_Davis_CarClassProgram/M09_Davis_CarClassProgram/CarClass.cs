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
 Module 9 Car Class
 Project Description: User is displayed my car's year and make. When
    the user clicks accelerate, the car's speed increases by 5 and when
    brake is clicked, the speed is reduced by 5. A message is displayed
    to the user based on the current speed.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M09_Davis_CarClassProgram
{
    public partial class CarClass : Form
    {
        // Create Car class with my own car
        Car MyCar = new Car(2006, "Toyota");
        public CarClass()
        {
            InitializeComponent();
            YearDisplayLabel.Text = MyCar.Year.ToString();
            MakeDisplayLabel.Text = MyCar.Make;
            SpeedDisplayLabel.Text = MyCar._speed.ToString();
        }

        // Accelerate method adds 5 to speed
        private void Accelerate(Car car)
        {
            car._speed += 5;
            SpeedDisplayLabel.Text = car._speed.ToString();
        }

        // Brake method removes 5 from speed
        private void Brake(Car car)
        {
            car._speed -= 5;
            SpeedDisplayLabel.Text = car._speed.ToString();
        }

        private void MessageToUser(Car car)
        {
            if (car._speed == 0)
            {
                MessageBox.Show("You have stopped!");
            }
            else if (car._speed > 100)
            {
                MessageBox.Show("Slow down there, Speed Racer!");
            } 
            else if (car._speed < -100)
            {
                MessageBox.Show("You might consider driving forwards at this speed...");
            }
        }

        private void BrakeBtn_Click(object sender, EventArgs e)
        {
            // Calls brake method with MyCar
            Brake(MyCar);
            // Displays appropriate message
            MessageToUser(MyCar);
        }

        private void AccelBtn_Click(object sender, EventArgs e)
        {
            // Calls Accelerate method with MyCar
            Accelerate(MyCar);
            // Displays appropriate message
            MessageToUser(MyCar);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Closes Form
            this.Close();
        }
    }
}
