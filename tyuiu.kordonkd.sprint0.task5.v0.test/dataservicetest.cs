using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

//Подключение библиотеки
using tyuiu.kordonkd.sprint0.task5.v0.lib;

namespace tyuiu.kordonkd.sprint0.task5.v0.test
{
    [TestClass]
    public class dataservicetest
    {
        [TestMethod]
        public void CheckedAdditionalValid()
        {
            Assert.AreEqual(10, dataservice.Addition(5, 5));
        }

        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, dataservice.Subtraction(10, 5));
        }

        [TestMethod]

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, dataservice.Multiplication(10, 5));
        }

        [TestMethod]

        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, dataservice.Division(9, 3));
        }
    }
}   

