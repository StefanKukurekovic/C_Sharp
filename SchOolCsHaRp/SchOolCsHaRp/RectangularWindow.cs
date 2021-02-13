using System;
using System.Collections.Generic;
using System.Text;

namespace SchOolCsHaRp
{
    class RectangularWindow : IWindow
    {
        string title;
        Point position;

        public RectangularWindow(string title, Point position)
        {
            this.title = title;
            this.position = position;
        }

        public Point Position 
        { 
            get { return position; } 
            set { position = value; } 
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangular Window");
        }
        public void Minimize()
        {
            Console.WriteLine("Minimizing Rectangular Window");
        }
    }
}
