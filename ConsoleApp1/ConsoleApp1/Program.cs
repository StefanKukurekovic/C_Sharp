using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddStudents addStudents = new AddStudents();
            addStudents.ev_BannedStudents += EventMessage;
            addStudents.ev_BannedStudents += WarningAlarm;

            string name = " ";

            Console.WriteLine("Please enter your name: ");

            name = Console.ReadLine();
            addStudents.NameCheck(name);
            

        }

        static void EventMessage(object sender, EventArgs e)
        {
            Console.WriteLine("You are banned from this course!");
        }

        static void WarningAlarm(object sender, EventArgs e)
        {
            Console.WriteLine("Banned Users Found, Sending Email to Administration.");
            Console.WriteLine("Email Sent");
            Console.WriteLine("Warning Alarm Started");
            // endles loop
            for(; ; )
            {
                Console.Beep();
            }
        }
    }

    class AddStudents
    {
        public event EventHandler ev_BannedStudents;
        public void NameCheck(string name)
        {
            List<string> bannedStudents = new List<string>() { "jack", "steven", "mathew" };
            bool banned = false;

            foreach (string s in bannedStudents)
            {
                if (name.ToLower() == s)
                {
                    ev_BannedStudents(this, EventArgs.Empty);
                    banned = true;
                }
            }

            if (banned == false)
            {
                Console.WriteLine("Welcome, {0}!", name);
            }
        }
    }

}
