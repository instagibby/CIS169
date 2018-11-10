using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Davis_EmployeeAndProductionWorkerClasses
{
    class Employee
    {
        // Field
        private string _employeeName;
        private int _employeeNumber;

        // Constructor
        public Employee(string employeeName, int employeeNumber)
        {
            _employeeName = employeeName;
            _employeeNumber = employeeNumber;
        }

        // Name property
        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        // Number property
        public int EmployeeNumber
        {
            get { return _employeeNumber; }
            set { _employeeNumber = value; }
        }
    }
}
