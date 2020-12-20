using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkingWithUnitTests;

namespace UnitTestMyLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Group 1")]
        public void AdditionTest()
        {
            MyLibrary lib = new MyLibrary();
            var res = lib.Add(2, 3);

            Assert.AreEqual(5, res);
         
        }

        [TestMethod]
        [TestCategory("Group 1")]
        [DataRow(10, 5, 5)]
        [DataRow(9, 4, 5)]
        [DataRow(3, 2, 1)]
        [DataRow(10, 20, -10)]
        public void SubtractionTest(int a, int b, int expected)
        {
            MyLibrary lib = new MyLibrary();
            var res = lib.Subtract(a, b);

            Assert.AreEqual(expected, res);

        }

        [TestMethod]
        [TestCategory("Group 2")]
        public void MultiplicationTest()
        {
            MyLibrary lib = new MyLibrary();
            var res = lib.Multiply(4, 2);

            Assert.AreEqual(8, res);
        }

        [TestMethod]
        [TestCategory("Group 2")]
        public void DivisionTest()
        {
            MyLibrary lib = new MyLibrary();
            var res = lib.Divide(80, 4);

            Assert.AreEqual(20, res);
        }
    }
}
