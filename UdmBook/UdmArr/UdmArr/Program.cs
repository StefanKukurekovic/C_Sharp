using System;
using System.Collections.Generic;
using System.Linq;

namespace UdmArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 99, 96, 87, 76 };
            List<int> list = new List<int> { 1, 2, 3, 4 };
            list.Add(0);
            list.Add(32);

            list.Sort();

            foreach(int num in list)
            {
                Console.WriteLine(num);
            }

            int index = list.FindIndex(x => x == 4);

            Console.WriteLine(list[index]);
            list.RemoveAt(index);

            list.ForEach(i => Console.WriteLine(i));
        }

    }
}
