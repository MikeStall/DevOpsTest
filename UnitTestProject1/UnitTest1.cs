using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(7, Class1.Add(5, 2));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(-3, Class1.Add(-5, 2));
        }
    }
}
