using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MyConsoleAppProject;

namespace MyUnitTestProject
{
    /// <summary>
    /// the internal class can only be seen outside its assembly
    /// because of the InternalsVisibleTo attribute!
    /// </summary>
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
