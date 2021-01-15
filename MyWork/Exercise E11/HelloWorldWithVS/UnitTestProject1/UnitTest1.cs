using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace UnitTestProjectNew
        {
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateTest()
        {
            Mylib lib = new Mylib();
            var Res = lib.Calculate(4, 2);
            Assert.AreEqual(8, Res);
        }
    }
}
