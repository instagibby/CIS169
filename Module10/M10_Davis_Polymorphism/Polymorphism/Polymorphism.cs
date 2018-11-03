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
 Module 10 Polymorphism
 Project Description: User can click a button that lists either a regular
    generic animal, or a dog / cat that are a sublcass of the animal. 
    Based on that the user will see a text box that prints the animal's sound.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace Polymorphism
{
    public partial class Polymorphism : Form
    {
        public Polymorphism()
        {
            InitializeComponent();
        }
        
        // The ShowAnimalInfo method accepts an Animal
        // object as an argument. It displays the object's
        // species and calls its MakeSound method.
        private void ShowAnimalInfo(Animal animal)
        {
            MessageBox.Show("Species: " + animal.Species);
            animal.MakeSound();
        }

        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            Animal myAnimal = new Animal("Regular Animal");
            ShowAnimalInfo(myAnimal);
        }

        private void createDogButton_Click(object sender, EventArgs e)
        {
            Dog myDog = new Dog("Fido");
            MessageBox.Show("The dog's name is " + myDog.Name);
            ShowAnimalInfo(myDog);
        }

        private void createCatButton_Click(object sender, EventArgs e)
        {
            Cat myCat = new Cat("Kitty");
            MessageBox.Show("The cat's name is " + myCat.Name);
            ShowAnimalInfo(myCat);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exits form
            this.Close();
        }
    }
}
