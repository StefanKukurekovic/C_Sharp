using System;
using System.Collections.Generic;
using System.Text;

namespace PolymophismUMD
{
    class Audi : Car
    {
        public string Model { get; set; }

        public Audi(string hp, string color, string model)
        {
            this.HP = hp;
            this.Color = color;

            this.Model = model;
        }
    }
}
