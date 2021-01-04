using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestCategory("Multests")]
        [TestMethod]
        public void Multipletest()
        {
            MyLib lib = new MyLib();
            var res = lib.Multiple(2, 4);

            Assert.AreEqual(8, res);
        }

        [TestCategory("sumtest")]
        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(10, 200, 210)]
        [DataRow(7, 20, 27)]

        public void Sumtest(int a, int b, int expected)
        {
            MyLib lib = new MyLib();
            var res = lib.sum(3, 4);

            Assert.AreEqual(7, res);
        }
        [TestCategory("dividetest")]
        [TestMethod]
        public void DivideTest()
        {
            MyLib lib = new MyLib();
            var res = lib.divide(32, 4);

            Assert.AreEqual(8, res);
        }
    }
}
