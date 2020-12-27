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
        public Person(string theName)
        {
            name = theName;
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
