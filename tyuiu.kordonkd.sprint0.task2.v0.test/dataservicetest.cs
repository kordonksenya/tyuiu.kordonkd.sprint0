﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using tyuiu.kordonkd.sprint0.task2.v0.lib;


namespace tyuiu.kordonkd.sprint0.task2.v0.test
{
    [TestClass]
    public class dataservicetest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Игорь";
            var res = dataservice.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
           
            
            Assert.AreEqual("Привет, Игорь", res);
        }    
            
    }
}
