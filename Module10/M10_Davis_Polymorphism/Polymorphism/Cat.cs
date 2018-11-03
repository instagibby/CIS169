using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Polymorphism
{
    class Cat : Animal
    {
        // Field
        private string _name;

        // Constructor
        public Cat(string name)
            : base("Cat")
        {
            _name = name;
        }

        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // MakeSound method
        public override void MakeSound()
        {
            MessageBox.Show("Meow");
        }
    }
}
