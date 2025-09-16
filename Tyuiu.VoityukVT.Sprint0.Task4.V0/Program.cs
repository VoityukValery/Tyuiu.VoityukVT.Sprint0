using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VoityukVT.Sprint0.Task4.V0.Lib;
namespace Tyuiu.VoityukVT.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(9, 6));

            Console.WriteLine(DataService.Subtraction(9, 6));

            Console.WriteLine(DataService.Multiplication(3, 6));

            Console.WriteLine(DataService.Division(24, 6));

            Console.ReadKey();

        }
    }
}
