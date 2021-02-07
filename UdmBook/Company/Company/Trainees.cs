using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    class Trainees : Employee
    {
        public int WorkingHours { get; set; }

        public Trainees() { }

        public Trainees(string firstName, string lastName, double salary, int workingHours)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;

            this.WorkingHours = workingHours;
        }
    }
}
