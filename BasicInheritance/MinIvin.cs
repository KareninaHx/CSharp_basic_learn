using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    internal class MinIvin:Car
    {

        public void TestMethod()
        {
            //可以访问父类中的公共成员
            Speed = 10;
            //不可以访问父类中的私有成员
            //currSpeed = 10;
        }
    }
}
