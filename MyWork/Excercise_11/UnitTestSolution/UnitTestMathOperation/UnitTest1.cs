using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Squaremath;

namespace UnitTestMathOperation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAreaMethod()
        {
            Squaremath Sm = new Squaremath();

            double Area = Sm.Area(2, 2);

            Assert.AreEqual(Area, 4);

        }

        [TestMethod]
        public void TestPerimeterMethod()
        {
            Squaremath Sm = new Squaremath();

            Squaremath Sm = new Squaremath();

            double Per = Sm.Perimeter(2, 2);

            Assert.AreEqual(Per, 8);

        }
    }
}