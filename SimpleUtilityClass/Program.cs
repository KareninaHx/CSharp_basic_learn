using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUtilityClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeUtilsClass.PrintMessage("===Fun with Static Data===");
            TimeUtilsClass.PrintDate();
            TimeUtilsClass.PrintTime();
        }
    }
}
