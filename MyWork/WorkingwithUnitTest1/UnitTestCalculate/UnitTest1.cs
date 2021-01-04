using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace UnitTestCalculate
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sumtest()
        {
            MyLib lib = new MyLib();
            var res = lib.sum(2, 4);

            Assert.AreEqual(6, res);
        }
    

        [TestMethod]
        public void dividetest()
        {
            MyLib lib = new MyLib();
            var res = lib.Divide(32, 4);

            Assert.AreEqual(8, res);
        }
    }
}





