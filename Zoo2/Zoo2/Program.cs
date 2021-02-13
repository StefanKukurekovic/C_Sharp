using System;
using System.Collections.Generic;

namespace Zoo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo("Hellbrunn");

            Animal a = new Animal(5, "Toni");
            a.RequiredEnviroments.Add(typeof(Water));
            a.RequiredEnviroments.Add(typeof(Steppe));
            zoo.AddAnimal(a);

            zoo.AddAnimal(new Animal(7, "Anton")
            {
                RequiredEnviroments = new List<Type>() { typeof (Water), typeof(Steppe)}
            });

            zoo.AddCage(new Cage()
            {
                Size = 200,
                Enviroments = new List<Enviroment>() { new Water()}
            });

            zoo.AddCage(new Cage()
            {
                Size = 200,
                Enviroments = new List<Enviroment>() { new Steppe() }
            });

            zoo.AddCage(new Cage()
            {
                Size = 200,
                Enviroments = new List<Enviroment>() { new Water(), new Steppe() }
            });

            zoo.Zookeper = new Zookeeper();
            zoo.Zookeper.AssignAnimalToCage(zoo.Animals[0], zoo.Cages);
        }
    }
}
