using System;
using System.Collections.Generic;
using System.Text;

namespace CoDj1
{
    class ConvertUnit
    {
        public void UserInput(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Please enter a value of a Celsius: ");
                    CelsiusToFahrenheit(Int32.Parse(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("Please enter a value of a Celsius: ");
                    CelsiusToKelvin(Int32.Parse(Console.ReadLine()));
                    break;
            }
        }
        private void CelsiusToKelvin(double c)
        {
            Console.WriteLine("{0} Celsius is {1} Kelvin.", c, (c + 274.15));
        }

        private void CelsiusToFahrenheit(double c)
        {
            Console.WriteLine("{0} Celsius is {1} Fahrenheit.", c, (c*9/5)+32);
        }
    }
}
