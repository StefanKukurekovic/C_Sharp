using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo2
{
    class Zoo
    {
        public List<Animal> Animals { get; set; }
        public string Name { get; private set; }
        public List<Cage> Cages { get; set; }
        public Zookeeper Zookeper { get; set; }

        public Zoo(string name)
        {
            Name = name;
        }

        public void AddAnimal(Animal a)
        {
            if(Animals == null)
            {
                Animals = new List<Animal>();
            }
            Animals.Add(a);
        }

        public void AddCage(Cage ca)
        {
            if(Cages == null)
            {
                Cages = new List<Cage>();
            }
            Cages.Add(ca);
        }
    }
}
