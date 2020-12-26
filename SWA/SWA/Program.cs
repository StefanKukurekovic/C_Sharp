using System;

namespace SWA
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] numbers = new string[5];
            
            Console.Write("Please enter 5 names: ");
            for(int i = 0; i < 5; i++)
            {
                numbers[i] = Console.ReadLine();
            }

            Console.WriteLine("You've entered following names:");
            foreach(string i in numbers)
            {
                Console.WriteLine(i);
            }

        }
    }
}
