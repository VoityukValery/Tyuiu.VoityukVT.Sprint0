using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VoityukVT.Sprint0.Task5.V0.Lib;
namespace Tyuiu.VoityukVT.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(9, 6));

            Console.WriteLine("A - B = " + DataService.Subtraction(9, 6));

            Console.WriteLine("A * B = " + DataService.Multiplication(3, 6));

            Console.WriteLine("A / B = " + DataService.Division(24, 2));

            Console.ReadKey();
        }
    }
}
