using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestClass()]
    public class Dimension3DTests
    {
        [TestMethod()]
        public void Dimension3DTest()
        {
            var dim3D = new Dimension3D(1, 2, 3);
        }
        [TestMethod()]
        public void Dimension3DTest_From2D()
        {
            var dim2D = new Dimension2D(1, 2);
            var dim3D = new Dimension3D(dim2D, 3);

            Assert.AreEqual(1, dim3D.X);
            Assert.AreEqual(2, dim3D.Y);
            Assert.AreEqual(3, dim3D.Z);
        }
        [TestMethod()]
        public void Dimension3DTest_FromXZ()
        {
            var dimXZ = new DimensionXZ(1, 2);
            var dim3D = new Dimension3D(dimXZ, 3);

            Assert.AreEqual(1, dim3D.X);
            Assert.AreEqual(3, dim3D.Y);
            Assert.AreEqual(2, dim3D.Z);
        }
        [TestMethod()]
        public void Dimension3DTest_FromYZ()
        {
            var dimYZ = new DimensionYZ(1, 2);
            var dim3D = new Dimension3D(dimYZ, 3);

            Assert.AreEqual(3, dim3D.Y);
            Assert.AreEqual(1, dim3D.Y);
            Assert.AreEqual(2, dim3D.Z);
        }


        [TestMethod()]
        public void Get2DTest()
        {
            var dim3D = new Dimension3D(1, 2, 3);
            var dim2D = dim3D.XY;

            Assert.AreEqual(1, dim2D.X);
            Assert.AreEqual(2, dim2D.Y);
        }
        [TestMethod()]
        public void GetXZTest()
        {
            var dim3D = new Dimension3D(1, 2, 3);
            var dim2D = dim3D.XZ;

            Assert.AreEqual(1, dim2D.X);
            Assert.AreEqual(3, dim2D.Z);
        }
        [TestMethod()]
        public void GetYZTest()
        {
            var dim3D = new Dimension3D(1, 2, 3);
            var dim2D = dim3D.YZ;

            Assert.AreEqual(2, dim2D.Y);
            Assert.AreEqual(3, dim2D.Z);
        }
        [TestMethod()]
        public void SetXYZ()
        {
            var dim3D = new Dimension3D();
            dim3D.SetXYZ(1, 2, 3);

            Assert.AreEqual(1, dim3D.X);
            Assert.AreEqual(2, dim3D.Y);
            Assert.AreEqual(3, dim3D.Z);
        }

        [TestMethod]
        public void IsEmptyTest()
        {
            var dim3D = new Dimension3D();

            Assert.AreEqual(true, dim3D.IsEmpty());
        }
        [DataTestMethod]
        [DataRow(0.0, 0.0, 0.0, "zero")]
        [DataRow(-1, 0, 0, "negative")]
        [DataRow(-1, -1, 0, "negative")]
        [DataRow(-1, -1, -1, "negative")]
        public void IsEmptyTest(double x, double y, double z, string comment)
        {
            var dim3D = new Dimension3D();

            Assert.AreEqual(true, dim3D.IsEmpty(), comment);
        }



        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { 1, 2, 3 };
        }
    }
}