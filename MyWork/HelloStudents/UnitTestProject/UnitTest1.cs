using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumTest()
        {
            MyLib lib = new MyLib(); 

            var res = lib.Sum(14, 2);

            Assert.AreEqual(16, res);
        }

        [TestMethod]
        public void DivideTest()
        {
            MyLib lib = new MyLib();

            var res = lib.Divide(14, 2);

            Assert.AreEqual(7, res);
        }

        [TestMethod]
        public void MultipleTest()
        {
            MyLib lib = new MyLib();

            var res = lib.Multiple(14, 2);

            Assert.AreEqual(28, res);
        }
    }
}
