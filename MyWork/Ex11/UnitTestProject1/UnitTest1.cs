using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex11;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEven()
        {
            MyClassforTest a = new MyClassforTest();
            Assert.AreEqual("Even", a.EvenOrOdd(4));
        }

        [TestMethod]
        public void TestOdd()
        {
            MyClassforTest a = new MyClassforTest();
            Assert.AreEqual("Odd", a.EvenOrOdd(3));
        }
    }
}
