using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M09_Davis_CarClassProgram
{
    class Car
    {
        // Fields
        private int _year;      // The car's year
        private string _make;   // The car's make
        private int _speed;      // Current Speed;

        // Constructor
        public Car(int year, string make)
        {
            _year = year;
            _make = make;
            _speed = 0;
        }

        // Year property
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        // Make property
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        // Speed property
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
    }
}
