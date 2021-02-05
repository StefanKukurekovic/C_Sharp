using System;

namespace UdmBook
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int[,] array2D = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            Console.WriteLine("Center value is {0}", array2D[2,0]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"}
                },
                {
                    {"100", "101"},
                    {"110", "111"}
                }
            };

            Console.WriteLine("Center value is {0}", array3D[1, 1, 0]);

            int dimensions = array3D.Rank;
            Console.WriteLine(dimensions);



        }
    }
}
