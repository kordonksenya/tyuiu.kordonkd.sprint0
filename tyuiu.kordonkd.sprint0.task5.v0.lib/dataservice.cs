using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using tyuiu.kordonkd.sprint0.task5.v0.lib;
namespace tyuiu.kordonkd.sprint0.task5.v0.lib
{
    public class dataservice
    {
        //Пример линейной структуры 
        public static int Addition(int a, int b)
        {
            return a+b;
        }

        //Пример линейной структуры 

        public static int Subtraction(int a, int b)
        {
            return a-b;
        }

        //Пример линейной структуры 

        public static int Multiplication(int a, int b)
        {
            return a*b;
        }

         
        public static double Division(int a, int b)
        {
            if (b== 0)
            {
                Console.WriteLine("Переменная b = {0} на ноль делить нельзя", b);
                return -1;


            }
            else
            {
                return a/b;

            }
        }














    }
}

    

