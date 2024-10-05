using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using tyuiu.kordonkd.sprint0.task3.v0.lib;
namespace tyuiu.kordonkd.sprint0.task3.v0.test
{
    [TestClass]
    public class dataservicetest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, dataservice.Sum(5, 5));
        }
    }
}
