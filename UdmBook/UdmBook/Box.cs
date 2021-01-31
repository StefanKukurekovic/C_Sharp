using System;
using System.Collections.Generic;
using System.Text;

namespace UdmBook
{
    class Box
    {
        // member variables
        private int length = 3;
        public int height;
        public int width;
        public int volume;

        public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetLength()
        {
            return length;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", 
                                length, height, width,volume = length * height * width);
        }





    }
}
