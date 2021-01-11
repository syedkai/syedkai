using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace UnitTestforLibrary
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        [DataRow(4, new int[] { 4, 12, 36, 108, 324, 972, 2916, 8748, 26244, 78732 })]
        [DataRow(2, new int[] { 2, 6, 18, 54, 162, 486, 1458, 4374, 13122, 39366 })]
        [DataRow(5, new int[] { 5, 15, 45, 135, 405, 1215, 3645, 10935, 32805, 98415 })]
        public void SerieseTest(int a, int[] expected)
        {
            Class1 ser = new Class1();

            int[] tester = ser.SerieseBuilder(a);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], tester[i]);
            }

        }
    }
}
