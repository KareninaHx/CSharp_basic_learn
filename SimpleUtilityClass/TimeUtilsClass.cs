using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUtilityClass
{
    //静态类
    internal static class TimeUtilsClass
    {
        //只能包含静态成员
        //所有功能都从类级别公开

        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
        public static void PrintMessage(string text)
        {
            Console.WriteLine(text);
        }
        public static void PrintDate()
        {
            PrintMessage(DateTime.Today.ToShortDateString());
        }
    }
}
