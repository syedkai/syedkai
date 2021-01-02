using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkingwithUnitTests;

namespace UnitTestingLib
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        [TestCategory ("Prod")]
        public void TestFunc1()
        {
            TestFunc b = new TestFunc();

            int result = b.TestFuncSum(1, 2);

            Assert.AreEqual(3, result);

        }

        [TestCategory("Prod")]
        [TestMethod]
        [DataRow (1,2,2)]
        [DataRow(1, 4, 4)]
        [DataRow(1, 7, 7)]
        [DataRow(1, 10, 10)]
        public void TestFunc2(int x, int y, int expected)
        {
            TestFunc c = new TestFunc();
            int result = c.TestFuncMulti(x,y);
            Assert.AreEqual(expected, result);
        }


        [TestCategory("Prod")]
        [TestMethod]
        public void TestFunc3()
        {
            TestFunc f = new TestFunc();

            double result = f.TestFuncDivide(4, 5);
            Assert.AreEqual(0.8, result);

            result = f.TestFuncDivide(1, 2);
            Assert.AreEqual(0.5, result);

            result = f.TestFuncDivide(5, 5);
            Assert.AreEqual(1, result);

        }

    }
}
