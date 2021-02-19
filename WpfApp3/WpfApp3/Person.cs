﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public Person(string firstName, string lastName, int age, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
        }

    }
}
