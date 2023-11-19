using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    internal class SavingAccount
    {
        //实例级别的数据
        public double currBalance;
        //静态数据
        public static double currInterestRate;

        public SavingAccount(double balance)
        {
            Console.WriteLine("In instance ctor");
            currBalance = balance;
        }
        //静态构造函数
        //不允许 出现访问修饰符
        static SavingAccount()
        {
            Console.WriteLine("In static ctor");
            currInterestRate = 0.04;
        }
        public static void setInterestRate(double interestRate)
        {
            currInterestRate = interestRate;
        }

        //静态方法
        public static double getInterestRate()
        {
            return currInterestRate;
        }
    }
}
