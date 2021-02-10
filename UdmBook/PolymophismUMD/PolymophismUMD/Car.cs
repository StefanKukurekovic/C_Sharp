using System;
using System.Collections.Generic;
using System.Text;

namespace PolymophismUMD
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("HP of this car is {0}, and the color is {1}.", HP, Color);
        }

        public virtual void Rapair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
