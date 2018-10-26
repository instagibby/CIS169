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
        public int _speed;      // Current Speed;

        // Constructor
        public Car(int year, string make)
        {
            _year = year;
            _make = make;
            _speed = 0;
        }

        // Brand property
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        // Model property
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        // Price property
        public int Price
        {
            get { return _speed; }
            set { _speed = value; }
        }
    }
}
