using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uni_test;

namespace UnitTestProject_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(10, 20, 30)]
        [DataRow(20, 20, 40)]
        [DataRow(40, 20, 60)]
        public void TestAddition(double x, double y, double exp)
        {
            Class1 obj = new Class1();
            var result = obj.Addition(x, y);
            Assert.AreEqual(exp, result);

        }

        [TestMethod]
        [DataRow(10, 20, 200)]
        [DataRow(20, 20, 400)]
        [DataRow(40, 20, 800)]
        public void TestMultiplication(double x, double y, double exp)
        {
            Class1 obj = new Class1();
            var result = obj.Multiplication(x, y);
            Assert.AreEqual(exp, result);
        }

       
    }
}
