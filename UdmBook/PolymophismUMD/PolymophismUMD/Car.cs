using System;
using System.Collections.Generic;
using System.Text;

namespace PolymophismUMD
{
    class Car
    {
        
        public int HP { get; set; }
        public string Color { get; set; }

        // has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();
        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void getCarIdInfo()
        {
            Console.WriteLine("The car has ID of {0} and is owned by {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }

        

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
