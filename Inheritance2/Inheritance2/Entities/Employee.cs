using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance2.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        //We create a virtual method in the base class using the virtual keyword and that method 
        //is overriden in the derived class using the override keyword.
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
