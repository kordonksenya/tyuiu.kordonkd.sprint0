using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Подключение библиотеки
using tyuiu.kordonkd.sprint0.task5.v0.lib;

namespace tyuiu.kordonkd.sprint0.task5.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B= " +dataservice.Addition(1, 5));
            Console.WriteLine("A - B = "+dataservice.Subtraction(15, 5));
            Console.WriteLine("A * B = " +dataservice.Multiplication(10, 10));

            Console.WriteLine("A / B =" +dataservice.Division(9, 3));
            Console.ReadKey();
        }
    }
}
