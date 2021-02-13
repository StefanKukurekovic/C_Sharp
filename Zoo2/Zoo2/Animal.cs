using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo2
{
    class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public List<Type> RequiredEnviroments { get; set; }
        public Cage Cage { get; set; }

        public Animal(int age, string name)
        {
            Age = age;
            Name = name;
            RequiredEnviroments = new List<Type>();
        }
    }
}
