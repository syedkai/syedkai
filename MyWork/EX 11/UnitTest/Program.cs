using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace UnitTest
{
    [TestClass]
    public class Program
    {
        [TestMethod()]
        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(10, 20, 30)]
        [DataRow(1000, 20, 1020)]
        public void TestAdd1(int value1, int value2, int expectedValue)
        {
            var api = new Calc();
            Assert.AreEqual(api.Add(value1, value2), expectedValue);
        }
    }
}
