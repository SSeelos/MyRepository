using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MyConsoleAppProject;

namespace MyUnitTestProject
{
    [TestClass]
    public class MyInternalClassTests
    {
        [TestMethod]
        public void TestInternalClass()
        {
            var internalClass = new MyInternalClass();
            internalClass.Should().NotBeNull();
        }
    }
}
