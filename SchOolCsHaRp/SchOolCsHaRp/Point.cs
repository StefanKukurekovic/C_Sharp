using System;
using System.Collections.Generic;
using System.Text;

namespace SchOolCsHaRp
{
    struct Point
    {
        public double x;
        public double y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
}
