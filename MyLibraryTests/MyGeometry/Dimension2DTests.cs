using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass()]
    public class Dimension2DTests
    {
        [TestMethod()]
        public void Dimension2DTest()
        {
            var dim = new Dimension2D(1, 2);
            Assert.AreEqual(1, dim.X);
            Assert.AreEqual(2, dim.Y);
        }

    }
}