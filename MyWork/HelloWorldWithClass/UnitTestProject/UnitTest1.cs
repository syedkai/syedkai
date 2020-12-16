using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsChildMessage()
        {
            var user = new UserLibrary.User("Tom", 5);
            string message = "Du bist ein Kind";
            Assert.AreEqual(user.AgeMessage(), message);
        }
    }
}
