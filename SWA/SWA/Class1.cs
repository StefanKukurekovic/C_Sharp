using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWA
{
    public class Student
    {
        private string name;
        private int age;
        private int marksOfMaths;
        private int marksOfEnglish;
        private int marksOfScience;
        private int totalMarks = 300;
        private int obtainedMarks;
        private double precentage;

        // Name
        public string Name 
        { 
            get { return name; }
            set { name = value; }
        }

        //Age
        public int Age 
        {
            get { return age; }
            set { age = value; }
        }

        //Math
        public int MarksOfMaths
        {
            get { return marksOfMaths; }
            set { IfCondition(marksOfMaths, value); }
        }

        //English
        public int MarksOfEnglish
        {
            get { return marksOfEnglish; }
            set { IfCondition(marksOfEnglish, value); }
        }

        //Science
        public int MarksOfScience
        {
            get { return marksOfScience; }
            set { IfCondition(marksOfScience, value); }
        }

        // Obtained Marks
        public int CalculateTotalMarks 
        {
            get { return obtainedMarks; }
            set
            {
                obtainedMarks = marksOfMaths + marksOfEnglish + marksOfScience;
            }
        }

        public double CalculatePercentage 
        { 
            get { return precentage; }
            set
            {
                precentage = (double)obtainedMarks / totalMarks * 100;
            }
        }


        public void IfCondition(int var, int value)
        {
            if (value >= 0 && value <= 100)
            {
                var = value;
            }
            else
            {
                var = 0;
            }
        }


    }
}
