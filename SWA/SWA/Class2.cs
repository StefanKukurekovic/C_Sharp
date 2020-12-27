using System;
using System.Collections.Generic;
using System.Text;

namespace SWA
{
    class Person
    {
        // field
        private string name;

        // constructor
        public Person()
        {
            name = "unknown";
            Console.WriteLine("Constructor called...");
        }

        // property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
