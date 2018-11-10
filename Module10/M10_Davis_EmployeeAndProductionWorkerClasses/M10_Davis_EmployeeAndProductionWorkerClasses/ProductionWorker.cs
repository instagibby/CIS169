using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Davis_EmployeeAndProductionWorkerClasses
{
    class ProductionWorker : Employee
    {
        // Field
        private string _employeeName;
        private int _employeeNumber;
        private int _shiftNo;
        private double _hourlyRate;

        // Constructor
        public ProductionWorker(string employeeName, int employeeNumber, int shiftNo, double hourlyRate)
            : base (employeeName, employeeNumber)
        {
            _employeeName = employeeName;
            _employeeNumber = employeeNumber;
            _shiftNo = shiftNo;
            _hourlyRate = hourlyRate;
        }

        // Shift Number property
        public int ShiftNo
        {
            get { return _shiftNo; }
            set { _shiftNo = value; }
        }

        // Hourly Rate property
        public double HourlyRate
        {
            get { return _hourlyRate; }
            set { _hourlyRate = value; }
        }
    }
}
