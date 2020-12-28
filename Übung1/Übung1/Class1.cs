using System;
using System.Collections.Generic;
using System.Text;

namespace Übung1
{
    class Converter
    {
        public void SwitchConvert(string input)
        {
            int num = int.Parse(input);
            switch (num)
            {
                case 1:
                    Console.Write("Enter temperature in Fahrenheit to convert to Celsius: ");
                    UserInput(1);
                    break;
                case 2:
                    Console.Write("Enter temperature in Reamur to convert to Celsius: ");
                    UserInput(2);
                    break;
                case 3:
                    Console.Write("Enter temperature in Kelvin to convert to Celsius: ");
                    UserInput(3);
                    break;
                default:
                    Console.Write("Please start the program again and try again.");
                    break;
            }

        }

        public void UserInput(int i)
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            if(i == 1)
            {
                double fahr = Fahrenheit((double)userInput);
                Console.WriteLine("{0} Fahrenheit is {1} Celsius", userInput, fahr);
            }
            else if(i == 2)
            {
                double reamur = Reamur((double)userInput);
                Console.WriteLine("{0} Reamur is {1} Celsius", userInput, reamur);
            }
            else if(i == 3)
            {
                double kelvin = Kelvin((double)userInput);
                Console.WriteLine("{0} Kelvin is {1} Celsius", userInput, kelvin);
            }
            
        }

        public double Fahrenheit(double num)
        {
            double result = (num - 32) * ((double)5 / 9);
            return Math.Round(result, 2);
        }


        public double Reamur(double num)
        {
            double result = num * 1.25;
            return Math.Round(result, 2);
        }

        public double Kelvin(double num)
        {
            double result = num - 273.15;
            return Math.Round(result, 2);
        }
    }
}
