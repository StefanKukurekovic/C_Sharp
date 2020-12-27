using System;

namespace Übung1
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter conv = new Converter();

            Console.WriteLine("Please choose Temperature type:");
            Console.WriteLine("1) Fahrenheit");
            Console.WriteLine("2) Reamur");
            Console.WriteLine("3) Kelvin");

            conv.SwitchConvert(Console.ReadLine());


        }
    }
}
