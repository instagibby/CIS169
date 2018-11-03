using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Polymorphism
{
    class Animal
    {
        // Field
        private string _species;

        // Constructor
        public Animal (string species)
        {
            _species = species;
        }

        // Species property
        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }

        // MakeSound method
        public virtual void MakeSound()
        {
            MessageBox.Show("Grrrrrrrr");
        }
    }
}
