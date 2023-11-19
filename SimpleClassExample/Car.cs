using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    internal class Car
    {
        //Car的状态
        private string petName;
        public int currSpeed;

        //自定义构造函数
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }
        public Car(string pn)
        {
            petName = pn;
        }
        //让调用设置完整的状态
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        //car的功能
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        }
        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
        //自动属性
        public string PetName { get; set; }
    }
}
