using System;

namespace UdmArr
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare jagged array
            
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };
            

            // alternitive way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] {2, 3, 5, 7, 11},
                new int[] {1, 2, 3}
            };

            for(int i = 0; i < jaggedArray.Length; i++)
            {
                for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if(j == (jaggedArray[i].Length - 1))
                    {
                        Console.Write("{0} ", jaggedArray[i][j]);
                    }
                    else
                    {
                        Console.Write("{0}, ", jaggedArray[i][j]);
                    }
                    
                }
                Console.WriteLine();
            }
            
        }
    }
}
