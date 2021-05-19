using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyUnitTestProject;
using MyProject;

namespace MyUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var res = MyProgram.MyMethod(1);

            Assert.AreEqual(2, res);
        }
    }
}
