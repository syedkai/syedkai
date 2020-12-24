using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex10;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] EFG = { 30, 31, 2, 33, -1 };
            Class1 XYZ = new Class1(EFG);
            XYZ.binarySort();
            CollectionAssert.AreEqual(new int[] { -1, 2, 30, 31, 33 }, EFG);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] EFG = { 30, 31, 2, 33, -1 };
            Class1 XYZ = new Class1(EFG);
            XYZ.binarySort();
            CollectionAssert.AreEqual(new int[] { -1, 2, 30, 31, 33 }, EFG);
        }
    }
}
