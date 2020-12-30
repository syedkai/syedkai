using E11;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E11Tests
{
    [TestClass]
    public class WageTests
    {
        [TestMethod]
        public void TestHoursOfWork()
        {
            double itemPrice = 250.25;
            double hourlyRate = 15.50;
            int expectedHours = 17;
            int actualHours = Wage.CalculateHoursOfWork(itemPrice, hourlyRate);

            Assert.AreEqual(expectedHours, actualHours);
        }
    }
}
