using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalculation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MultiplyTest()
        {
            //throw new System.Exception("No No - Nothing here");
            CalculationLibrary.CalculationTypes calc = new CalculationLibrary.CalculationTypes();
            var resMul = calc.multiply(3,4);

            Assert.AreEqual(12, resMul);
        }

        [TestMethod]
        [DataRow(1.0, 2.0, 3.0)]
        [DataRow(10.0, 20.0, 30.0)]
        [DataRow(1.1, 2.2, 3.3000000000000003)]
        public void SumTest(double a, double b, double expct)
        {
            CalculationLibrary.CalculationTypes calc = new CalculationLibrary.CalculationTypes();
            var resSum = calc.sum(a, b);

            Assert.AreEqual(expct, resSum);
        }

        [TestMethod]
        public void DivisonTest()
        {
            CalculationLibrary.CalculationTypes calc = new CalculationLibrary.CalculationTypes();
            var resDiv = calc.divide(36, 4);

            Assert.AreEqual( 9, resDiv);
        }
    }
}
