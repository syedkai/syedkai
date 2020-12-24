using Microsoft.VisualStudio.TestTools.UnitTesting;
using unittest;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testA()
        {
            int[] a = { 7, 5, 13, 1, 8, 0 };
            ubbleSort b = new ubbleSort(a);
            b.bubblesort();
            CollectionAssert.AreEqual(new int[] { 0, 1, 5, 7, 8, 13 }, a);
        }
        [TestMethod]
        public void testB()
        {
            int[] c = { 7, 5, 13, 1, 8, 0 };
            unittest.ubbleSort d = new unittest.ubbleSort(c);
            d.bubblesort();
            CollectionAssert.AreEqual(new int[] { 0, 1, 5, 7, 8, 13 }, c);
        }
        [TestMethod]
        public void testC()
        {
            int[] x = { 7, 5, 13, 1, 8, 0 };
            unittest.ubbleSort y = new unittest.ubbleSort(x);
            y.bubblesort();
            CollectionAssert.AreEqual(new int[] { 0, 1, 5, 7, 8, 13 }, x);
        }
    }
}