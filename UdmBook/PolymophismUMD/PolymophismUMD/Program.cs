using System;
using System.Collections.Generic;

namespace PolymophismUMD
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\kukab\OneDrive\Desktop\UdemyAssets\textFile.txt");
            Console.WriteLine(text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\kukab\OneDrive\Desktop\UdemyAssets\textFile.txt");
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }

            //text = System.IO.File.WriteAllText(@"C:\Users\kukab\OneDrive\Desktop\UdemyAssets\textFile.txt", "UPDATE: just kidding, you not fat gurl, you full of love");
            
            
            
            
            
            
            
            /*
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

            bmwZ3.SetCarIDInfo(1234, "Stefan Kukurekovic");
            audiA3.SetCarIDInfo(5678, "Marija Kukurekovic");

            bmwZ3.getCarIdInfo();
            audiA3.getCarIdInfo();*/
        }
    }
}
