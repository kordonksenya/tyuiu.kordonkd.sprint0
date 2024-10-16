using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tyuiu.kordonkd.sprint0.task6.v0.lib;

namespace tyuiu.kordonkd.sprint0.task6.v0.test
{
    [TestClass]
    public class dataservicetest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = dataservice.AdditionArray(numbers);
            Assert.AreEqual(15, res);

        }
        [TestMethod]
        public void CheckSubtractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = dataservice.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckMultiplicationArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = dataservice.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }

    }
}
           
         






  
        





    
    

