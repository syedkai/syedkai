using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(10, 5, 15)]
        [DataRow(9, 4, 13)]
        public void SumTest(double a, double b,double expected)
        {
            MyLib Lib = new MyLib();
            var res = Lib.Sum(a,b);
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        [TestCategory("Divison")]
        [DataRow(2, -2, -1)]
        public void DevideTest(double a, double b, double expected)
        {
            MyLib Lib = new MyLib();
            var res = Lib.Divide(a,b);
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        [TestCategory("Multiplication")]
        [DataRow(10, 5, 50)]
        [DataRow(9, -4, -36)]
        public void MultipleTest(double a, double b, double expected)
        {
            MyLib Lib = new MyLib();
            var res = Lib.Multiple(a,b);
            Assert.AreEqual(expected,res);
        }
    }
}
