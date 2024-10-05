using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.kordonkd.sprint0.task3.v0.lib;

namespace tyuiu.kordonkd.sprint0.task3.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(dataservice.Sum(7, 7));
            Console.ReadKey();
        }
    }
}
