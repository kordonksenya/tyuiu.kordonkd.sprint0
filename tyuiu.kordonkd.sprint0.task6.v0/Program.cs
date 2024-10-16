using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.kordonkd.sprint0.task6.v0.lib;

namespace tyuiu.kordonkd.sprint0.task6.v0
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма элементов массива = " + dataservice.AdditionArray(numsArray));

            Console.WriteLine("Разность элементов массива = " + dataservice.SubtractionArray(numsArray));

            Console.WriteLine("Произведение элементов массива = " + dataservice.MultiplicationArray(numsArray));

            Console.ReadKey();

        }
    }
            
        
    
}
    

