using System;
using System.Collections.Generic;
using System.Text;

namespace UdmBook
{
    class Box
    {
        private int volume;
        private int frontSurface;

        public Box(int length, int height, int width)
        {
            Length = length;
            Height = height;
            Width = width;
        }

        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }

        public int Volume
        {
            get
            {
                return Length * Height * Width;
            }
        }

        public int FrontSurface
        {
            get { return Height * Length; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", 
                                Length, Height, Width, volume = Length * Height * Width);
        }


    }
}
