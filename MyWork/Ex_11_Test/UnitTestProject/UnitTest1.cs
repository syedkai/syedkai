using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            MyLib lib = new MyLib();
            int result = lib.Add(2, 2);
            Assert.AreEqual(4, result);           
        }

        [TestMethod]
        public void SubtractTest()
        {
            MyLib lib = new MyLib();
            int result = lib.Subtract(5, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            MyLib lib = new MyLib();
            int result = lib.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }
    }
}
