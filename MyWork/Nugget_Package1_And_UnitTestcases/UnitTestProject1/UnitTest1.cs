using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Nuget_Package1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            Assert.AreEqual(SqrtPrecalculated.GetSqrt(81), 9);
        }
    }
}
