using System;

namespace CoDj1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            bool oneOrTwo = false;

            ConvertUnit convertUnit = new ConvertUnit();
            // NON OO: Ask user after input take [Fahrenheit, Kelvin]
            do
            {
                Console.WriteLine("Please choose the unit you want to convert Celsius to:");
                Console.WriteLine("\t1) Fahrenheit \n\t2) Kelvin");

                try
                {
                    userInput = Int32.Parse(Console.ReadLine());
                }catch(Exception e)
                {
                    Console.WriteLine("[Exception Message]: Only nunmbers are allowed.");
                }
                
                if (userInput == 1 || userInput == 2)
                    oneOrTwo = true;
                else
                    Console.WriteLine("Please enter only 1 or 2. Try again.");

            } while (!oneOrTwo);

            convertUnit.UserInput(userInput);
            



        }
    }
}
