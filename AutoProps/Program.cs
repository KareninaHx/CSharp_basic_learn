using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMessage("===AutoProp====");
            Car car = new Car();
            car.PetName = "大众";
            car.Speed = 400;
            car.Color = "黑色";

            car.showCarState();
        }
        static void PrintMessage(string text)
        {
            Console.WriteLine(text);
        }
    }
}
