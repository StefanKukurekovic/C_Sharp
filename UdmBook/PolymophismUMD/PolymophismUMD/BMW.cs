using System;
using System.Collections.Generic;
using System.Text;

namespace PolymophismUMD
{
    class BMW : Car
    {
        private string brand = "Some BMW Brand";
        public string Model { get; set; }

        public BMW(string model, int hp, string color):base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("HP: {0}, \nColor: {1} \nModel: {2} \nBrand: {3}", HP, Color, Model, brand);
        }

        public override void Rapair()
        {
            Console.WriteLine("The BMW {0} was repaired.", Model);
        }
    }
}
