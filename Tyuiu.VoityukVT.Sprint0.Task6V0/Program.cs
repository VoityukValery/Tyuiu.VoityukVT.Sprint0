using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VoityukVT.Sprint0.Task6.V0.Lib;
namespace Tyuiu.VoityukVT.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 2, 4, 6, 8, 11 };

            //Пример цикличной структуры находится в библиотеке классов. Метод AdditionArray
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));

            //Пример цикличной структуры находится в библиотеке классов. Метод SubtractionArray
            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(numsArray));

            //Пример цикличной структуры находится в библиотеке классов. Метод MultArray
            Console.WriteLine("Сумма элементов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
