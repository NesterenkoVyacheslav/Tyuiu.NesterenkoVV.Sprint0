using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NesterenkoVV.Sprint0.Task5.V0.Lib;

namespace Tyuiu.NesterenkoVV.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(15, 15));
            Console.WriteLine("A - B = " + DataService.Substraction(30, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(50, 5));
            Console.WriteLine("A / B = " + DataService.Division(10, 0));
            Console.ReadKey();
        }
    }
}
