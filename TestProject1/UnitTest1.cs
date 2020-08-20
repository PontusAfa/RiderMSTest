
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testTest;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c1 = new Test();

            Assert.AreEqual(2,c1.Calc());
            
        }
    }
}