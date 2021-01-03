using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DivisionTestMethod()
        {
            MyLib lib = new MyLib();
            var result = lib.divide(11, 11);

            Assert.AreEqual(1, result);
        }


        [TestMethod]
        [DataRow(1, 2 ,3)]
        [DataRow(5, 10 ,15)]
        [DataRow(7, 7 ,14)]
        [DataRow(1000.01, 200.90 ,1200.91)]
        public void SumTestMethod(double a, double b, double expected)
        {

            MyLib lib = new MyLib();
            var result = lib.add(a, b);

            Assert.AreEqual(expected, result);
        }



        [TestMethod]
        public void MultiplicationTestMethod()
        {
            MyLib lib = new MyLib();
            var result = lib.multiply(5, 5);

            Assert.AreEqual(25, result);

        }
    }

 
}
