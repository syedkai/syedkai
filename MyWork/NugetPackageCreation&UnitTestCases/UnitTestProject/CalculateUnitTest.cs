using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorNugetPackage;

namespace UnitTestProject
{
    [TestClass]
    public class CalculateUnitTest
    {
        [TestMethod]
        public void AddTest()
        {
            Calculate calObj = new Calculate();
            Assert.AreEqual(calObj.Add(2, 3), 5);
        }
        [TestMethod]
        [DataRow(3,4,12)]
        public void MultiplyTest(double a, double b, double expected)
        {
            Assert.AreEqual(Calculate.Multiply(a, b), expected);
        }
        [TestMethod]
        public void SubtractTest()
        {
            Calculate calObj = new Calculate();
            Assert.AreEqual(calObj.Subtract(6, 3), 3);
        }
        [TestMethod]
        public void DivideTest()
        {
            Assert.AreEqual(Calculate.Divide(6, 3), 2);
        }
    }
}
