using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMessage("====Basic Inheritance====");
            Car myCar = new Car(80);
            myCar.Speed = 50;
            Console.WriteLine("My car is goint {0} MPH", myCar.Speed);

            PrintMessage("==== extends fater====");
            MinIvin min = new MinIvin();
            //并没有继承 父类的构造方法，下方语句编译会报错
            //MinIvin minIvin = new MinIvin(100);
            min.Speed = 40;
            Console.WriteLine("My min is going {0} MPH", min.Speed);
            //min.currSpeed = 10;

        }
        static void PrintMessage(string text)
        {
            Console.WriteLine(text);
        }
    }
}
