using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace UdmArr
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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
            */
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hellouuu");
            arrayList.Add("2");
            arrayList.Add(new Number { n=4 });


            
        }

        class Number
        {
            public int n { get; set; }

            public override string ToString()
            {
                return n.ToString();
            }
        }

    }
}
