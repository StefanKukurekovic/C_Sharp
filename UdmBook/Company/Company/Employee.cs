using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }

        public Employee() { }

        public Employee(string firstName, string lastName, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public void Work()
        {

        }

        public void Pause()
        {

        }
    }
}
