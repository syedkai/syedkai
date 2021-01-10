using Microsoft.VisualStudio.TestTools.UnitTesting;
using E10_WorkingWithUnitTest;

namespace E10_UnitTest
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestSum()
        {
            var calculator = new Calculator();
            
            double result = calculator.add(15.5, 3.4);

            Assert.AreEqual(18.9, result);
        }
        
        [TestMethod]
        public void testSub()
        {
            var calculator = new Calculator();

            double result = calculator.sub(5, 3);

            Assert.AreEqual(2, result);
        }
    }
}
