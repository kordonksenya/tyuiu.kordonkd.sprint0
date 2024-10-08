using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.kordonkd.sprint0.task4.v0.lib;
namespace tyuiu.kordonkd.sprint0.task4.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры
            //Вызов метода структуры Addition
            Console.WriteLine(dataservice.Addition(1, 5));
            //Вызов метода структуры Subtraction
            Console.WriteLine(dataservice.Subtraction(15, 5));
            //Вызов метода Multiplication
            Console.WriteLine(dataservice.Multiplication(10, 10));
            //Вызов метода деления Division
            Console.WriteLine(dataservice.Division(5, 5));

            Console.ReadKey();
        }
    }
}
