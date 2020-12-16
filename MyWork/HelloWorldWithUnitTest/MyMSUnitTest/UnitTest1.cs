using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestLibrary;

namespace MyMSUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(-100, -10, 0, 10, 100, 0)]
        [DataRow(-1000, -10, 5, 4, 3, -998)]
        [DataRow(-100.75, -2.5, 0, 25.5, 32.5, -45.25)]
        [TestCategory("Sum")]
        public void TestSumAlg(double val1, double val2, double val3, double val4, double val5, double correct_val)
        {
            MyAlgorithm alg = new MyAlgorithm();

            double[] data = new double[] { val1, val2, val3, val4, val5 };

            double res = alg.CalculateSum(data);

            Assert.AreEqual(res, correct_val);
        }

        [TestMethod]
        [DataRow(-100, -10, 0, 10, 100, 0)]
        [DataRow(-1000, -10, 5, 4, 3, -199.6)]
        [DataRow(-100.75, -2.5, 0, 25.5, 32.5, -9.05)]
        [TestCategory("Average")]
        public void TestAverageAlg(double val1, double val2, double val3, double val4, double val5, double correct_val)
        {
            MyAlgorithm alg = new MyAlgorithm();

            double[] data = new double[] { val1, val2, val3, val4, val5 };

            double res = alg.CalculateAverage(data);

            Assert.AreEqual(res, correct_val);
        }
    }
}

