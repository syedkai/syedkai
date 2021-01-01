using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex11;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex11.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void CalcTest()
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(5, calc.Add(2,3));
            Assert.AreEqual(7, calc.Substract(10,3));
            Assert.AreEqual(3, calc.Mutliply(1,3));
            Assert.AreEqual(2, calc.Devide(4,2));
            Assert.AreEqual(4,calc.Square(2));
        }
    }
}