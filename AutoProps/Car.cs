using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Car
    {
        private string petName;
        private int speed;
        private string color;

        public Car() { }

        public Car(string petName,int speed,string color)
        {
            this.petName = petName;
            this.speed = speed;
            this.color = color;
        }

        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public void showCarState()
        {
            Console.WriteLine("car's name:{0}", PetName);
            Console.WriteLine("car's speed:{0}", Speed);
            Console.WriteLine("car's color:{0}", Color);
        }
        public void PrintMessage(string text)
        {
            Console.WriteLine(text);
        }
    }
}
