using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculationLib;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(10, 5, 15)]
        [DataRow(9, 4, 13)]
        [DataRow(3, 2, 5)]
        [DataRow(-10, 20, 10)]
        public void AdditionTest(int a, int b, int expected)
        {
            SimpleCalculation lib = new SimpleCalculation();
            var res = lib.Sum(a, b);

            Assert.AreEqual(expected, res);

        }

        [TestMethod]
        [TestCategory("Substract")]
        [DataRow(10, 5, 5)]
        [DataRow(9, 4, 5)]
        [DataRow(3, 2, 1)]
        [DataRow(10, -20, 30)]
        public void SubtractionTest(int a, int b, int expected)
        {
            SimpleCalculation lib = new SimpleCalculation();
            var res = lib.Subtract(a, b);

            Assert.AreEqual(expected, res);

        }

        [TestMethod]
        [TestCategory("Multiplication")]
        [DataRow(10, 5, 50)]
        [DataRow(9, -4, -36)]
        
        public void MultiplicationTest(int a, int b, int expected)
        {
            SimpleCalculation lib = new SimpleCalculation();
            var res = lib.Multiply(a, b);

            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        [TestCategory("Divison")]
        [DataRow(10, 5, 2)]
        [DataRow(2, -2, -1)]
       
        public void DivisionTest(int a, int b, int expected)
        {
            SimpleCalculation lib = new SimpleCalculation();
            var res = lib.Divide(a, b);

            Assert.AreEqual(expected, res);
        }
    }
}

