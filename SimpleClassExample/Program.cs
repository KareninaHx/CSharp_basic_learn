using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("===Fun with Class Types ===");
            ////分配和设置Car对象
            Car myCar = new Car();
            myCar.PetName = "Henry";
            Console.WriteLine("car naem:{0}", myCar.PetName);

            

            ////加速
            //for(int i = 0; i <= 10; i++)
            //{
            //    myCar.SpeedUp(5);
            //    myCar.PrintState();
            //}

            //Car Chuck = new Car();
            //Chuck.PrintState();
            //摩托车 骑手
            //Motorcycle rider1 = new Motorcycle("wuqi");
            //Console.WriteLine(rider1.name);
            //银行账户
            Console.WriteLine("===Fun with Static Data===");
            //创建一个账户
            SavingAccount s1 = new SavingAccount(50);
            Console.WriteLine("InterestRate is {0}", SavingAccount.getInterestRate());
            //修改利率
            SavingAccount.setInterestRate(0.07);
            //再创建一个账户
            SavingAccount s2 = new SavingAccount(100);
            Console.WriteLine("InterestRate is {0}", SavingAccount.getInterestRate());
        }
    }
}
