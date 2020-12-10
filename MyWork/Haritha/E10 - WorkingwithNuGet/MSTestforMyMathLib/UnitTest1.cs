using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathLibrary;

namespace MyMathLibUnitTest
{

    // tested 16 decimal places after 0 with Logarithm test
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Exponentof2Test()
        {
            MyMathLib testinstance = new MyMathLib();
            var actualresult = testinstance.Exponentof2(8);
            Assert.AreEqual(256,actualresult);
        }
        [TestMethod]
        public void SquareRootTest()
        {
            MyMathLib testinstance = new MyMathLib();
            var actualresult = testinstance.SquareRoot(0.81);
            Assert.AreEqual(0.9, actualresult);
        }
        [TestMethod]
        public void NaturalLogarithmTest()
        {
            MyMathLib testinstance = new MyMathLib();
            var actualresult = testinstance.NaturalLogarithm(4.55);
            Assert.AreEqual(1.5151272329628591, actualresult);
        }
    }
}
