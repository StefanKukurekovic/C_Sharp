using System;
using System.Collections.Generic;
using System.Text;

namespace PolymophismUMD
{
    class Audi : Car
    {
        private string brand = "Some Audi Brand XX41B";
        public string Model { get; set; }

        public Audi(string model, int hp, string color):base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("HP: {0}, \nColor: {1} \nModel: {2} \nBrand: {3}", HP, Color, Model, brand);
        }

        public override void Rapair()
        {
            Console.WriteLine("The Audi {0} was repaired.", Model);
        }
    }
}
