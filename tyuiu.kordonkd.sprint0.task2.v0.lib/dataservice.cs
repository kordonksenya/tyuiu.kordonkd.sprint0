﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyuiu.kordonkd.sprint0.task2.v0.lib
{
    public class dataservice
    {
        public static string GetMessage(string name)
        {
            return $"Привет, {name}";
        }
    }
}
