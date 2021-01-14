using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_ConsoleLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(10, 20, 10, 40)]
        [DataRow(20, 20, 20, 60)]
        [DataRow(40, 20, 30, 90)]
        public void TestAdd(int a, int b, int c, int expected)
        {

            Class1 obj = new Class1();
            var result = obj.Add(a, b, c);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]

        public void TestName()
        {
        }

        [TestMethod]

        public void TestMul()
        {
            Class1 obj = new Class1();
            var result = obj.Mul(72, 1);
            Assert.AreEqual(72, result);
        }
    }
}