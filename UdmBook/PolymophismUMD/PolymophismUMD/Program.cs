using System;
using System.Collections.Generic;

namespace PolymophismUMD
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi("A4", 200, "blue"),
                new BMW("M3", 250, "red")
            };

            foreach(var car in cars)
            {
                car.Rapair();
            }

            BMW bmwZ3 = new BMW("Z3", 200, "black");
            Audi audiA3 = new Audi("A3", 100, "green");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();
        }
    }
}
