﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyuiu.kordonkd.sprint0.task6.v0.lib
{
    public class dataservice

    {
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            return total;

        }
        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            var index = 0;

            while (index < numbers.Length) 
            {
                total = total - numbers[index];
                index++;
            }
            return total;
        }
        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total = total * numbers[index];
                index++;
            }
            while (index < numbers.Length);
            return total;
        }

    }
}
            
       
    

