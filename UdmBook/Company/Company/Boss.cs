using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss() { }

        public Boss(string firstName, string lastName, double salary, string companyCar)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;

            this.CompanyCar = companyCar;
        }

        public void Lead()
        {

        }
    }
}
