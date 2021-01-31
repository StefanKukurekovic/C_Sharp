using System;

namespace UdmBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,4,5);
            box.Width = 10;

            box.DisplayInfo();
            Console.WriteLine("Front Surface: {0} ", box.FrontSurface);
        }
    }
}
