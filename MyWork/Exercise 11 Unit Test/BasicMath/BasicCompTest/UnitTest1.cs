using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath;
namespace BasicCompTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_Addition()
        {
            BasicComputation bc = new BasicComputation();
            double res = bc.Add(10, 12);
            Assert.AreEqual(res, 22);
        }
        [TestMethod]
        public void TestMethod2_Subtraction()
        {
            BasicComputation bc = new BasicComputation();
            double res = bc.Substract(12, 2);
            Assert.AreEqual(res, 10);
        }
        [TestMethod]
        public void TestMethod3_Divison()
        {
            BasicComputation bc = new BasicComputation();
            double res = bc.divide(36, 12);
            Assert.AreEqual(res, 3);
        }
        [TestMethod]
        public void TestMethod4_Multiplication()
        {
            BasicComputation bc = new BasicComputation();
            double res = bc.Multiply(6, 12);
            Assert.AreEqual(res, 72);
        }
    }
}
