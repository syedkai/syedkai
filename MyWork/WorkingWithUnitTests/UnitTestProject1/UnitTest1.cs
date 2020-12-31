using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void calculateTest()
        {
            MyLib Lib = new MyLib();

            var res = Lib.calculate(1, 2);

            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void multiplyTest()
        {
            MyLib Lib = new MyLib();

            var res = Lib.mutiply(1, 2);

            Assert.AreEqual(2, res);
        }
    }
}
