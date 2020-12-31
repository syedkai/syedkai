using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculation;
namespace UnitTestProjectNameSpace
{
    [TestClass]
    public class UnitTestClass
    {
        [TestCategory("cat1")]

        [TestMethod]
        [DataRow(1,2,3)]
        [DataRow(4, 10, 14)]
        [DataRow(20, 100, 120)]
        [DataRow(1000, 22, 1022)]
        [TestCategory("SumTest")]
        public void SumTest(int a, int b, int exp)
        {
            basic lib = new basic();
            var result=lib.Aadd(a,b);
            Assert.AreEqual(exp,result);

          
        }
        [TestMethod]
        [TestCategory("MultiTest")]
        [TestCategory("cat2")]

        public void MultiTest()
        {
            basic lib = new basic();
            var result = lib.Mmultiply(1, 2);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        [TestCategory("DivideTest")]
        [TestCategory("cat2")]

        public void DivideTest()
        {
            basic lib = new basic();
            var result = lib.Ddivide(1, 2);
            Assert.AreEqual(0.5, result);
        }
        [TestCategory("cat1")]
        [TestMethod]
        [TestCategory("SubTest")]

        public void SubTest()
        {
            basic lib = new basic();
            var result = lib.Ssubtract(1, 2);
            Assert.AreEqual(-1, result);
        }

    }
}
