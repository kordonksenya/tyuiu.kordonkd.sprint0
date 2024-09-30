using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 using tyuiu.kordonkd.sprint0.task2.v0.lib

namespace tyuiu.kordonnkd.sprint0.task2.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса dataservice и метода getmessage
            //из библиотеки tyuiu.kordonkd.sprint0.task2.v0.lib
            Console.WriteLine(dataservice.getmessage("Игорь"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
