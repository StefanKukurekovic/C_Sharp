using System;

namespace SWA
{
    class Program
    {
        static void Main(string[] args)
        {
            Student theStudent = new Student();
            Student[] students = new Student[2];

            theStudent.Name = "Stefan";
            String myName = theStudent.Name;
            theStudent.Name = "Faraz";

            //theStudent.name = "Faraz";
            Console.WriteLine(myName);
            Console.WriteLine(theStudent.name);

            /*st1.SetName = "Einstein";
            st1.SetAge = 20;
            st1.SetMarksInEnglish = 80;
            st1.SetMarksInMaths = 99;
            st1.SetMarksInScience = 96;

            st1.CalculateTotalMarks();
            st1.CalculatePercentage();
            double st1Percentage = st1.GetPercentage();
            st1Percentage = Math.Round(st1Percentage, 2);

            Student st2 = new Student();
            st2.SetName = "Newton";
            st2.SetAge = 23;
            st2.SetMarksInEnglish= 77;
            st2.SetMarksInMaths = 100;
            st2.SetMarksInScience = 99;

            st2.CalculateTotalMarks();
            st2.CalculatePercentage();
            double st2Percentage = st2.GetPercentage();
            st2Percentage = Math.Round(st2Percentage, 2);

            students[0] = st1;
            students[1] = st2;

            Console.WriteLine("{0} of {1} years age got {2}% marks", st1.name, st1.age, st1Percentage);
            Console.WriteLine("{0} of {1} years age got {2}% marks", st2.name, st2.age, st2Percentage);

            foreach(Student s in students)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(s.name);
                Console.WriteLine(s.age);                
            }*/

            
        }

       
    }

}
