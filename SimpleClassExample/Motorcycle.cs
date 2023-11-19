using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    internal class Motorcycle
    {
        public int driverIntensity;
        public string name;
        // 构造函数链
        public Motorcycle() { PrintMessage("In default ctor"); }
        public Motorcycle(int intensity)
            //无对应参数的给出默认值
            :this(intensity, "unknown") { PrintMessage("In int ctor"); }
        public Motorcycle(string name)
            : this(0, name) { PrintMessage("In string ctor"); }

        //做所有工作的主构造函数
        public Motorcycle(int intensity,string name)
        {
            PrintMessage("In master ctor");
            if(intensity > 10)
            {
                driverIntensity = intensity;
            }
            driverIntensity = intensity;
            this.name = name;
        }
        //冗余的构造函数逻辑
        //public Motorcycle()
        //{

        //}
        //public Motorcycle(int driverIntensity)
        //{
        //    if(driverIntensity > 10)
        //    {
        //        driverIntensity = 10;
        //    }
        //    this.driverIntensity = driverIntensity;
        //}
        //public Motorcycle(int driverIntensity,string name)
        //{
        //    if(driverIntensity > 10)
        //    {
        //        driverIntensity = 10;
        //    }
        //    this.driverIntensity = driverIntensity;
        //    this.name = name;
        //}
        void PrintMessage(string text)
        {
            Console.WriteLine(text);
        }
    }
}
