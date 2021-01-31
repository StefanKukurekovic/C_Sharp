using System;
using System.Collections.Generic;
using System.Text;

namespace UdmBook
{
    class Members
    {
        // variables are members of a class
        // propreties are members of a class
        // methods are members of a class
        // constructors are members of a class
        // destructors are members of a class

        // member prvate field
        private String memberName;
        private String jobTitle;
        private int salary;

        // member public field
        public int age;

        // member property
        public string JobTitle 
        { 
            get { return jobTitle; }
            set { jobTitle = value; } 
        }

        // member method
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0} and my job title is {1}. I'm {2} years old.", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is €{0} pro month.", salary);
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Stefan Kukurekovic";
            salary = 5000;
            jobTitle = "Data Scientist at United Nations.";
            Console.WriteLine("Object created");
        }

        // member destructor
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of Members object.");
        }

    }
}
