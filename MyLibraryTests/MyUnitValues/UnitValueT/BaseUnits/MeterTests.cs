using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLibrary_DotNETstd_2_1.Tests
{
    [TestClass()]
    public class MeterTests
    {
        [TestMethod()]
        public void MeterTest()
        {
            var meter = new Meter(1);
            Assert.AreEqual(1, meter.BaseValue);
            Assert.AreEqual(1, meter.DisplayValue);
        }
        [TestMethod()]
        public void MeterTest1()
        {
            var centimeter = new Centimeter(100);
            var meter = new Meter(centimeter);
            Assert.AreEqual(1, meter.BaseValue);
            Assert.AreEqual(1, meter.DisplayValue);
        }

        [TestMethod()]
        public void fromBaseUnitTest()
        {
            var meter = new Meter(1);

            Assert.AreEqual(1, meter.fromBaseUnit(meter.BaseValue));
        }

        [TestMethod()]
        public void toBaseUnitTest()
        {
            var meter = new Meter(1);

            Assert.AreEqual(1, meter.fromBaseUnit(meter.BaseValue));
        }

    }

    [TestClass()]
    public class MeterBuildOperateTests
    {
        [TestMethod()]
        public void BuildOperate()
        {
            Meter given = Given();

            Meter result = When(given);

            Then(result);
        }
        private Meter Given()
        {
            return new Meter(2);
        }

        private Meter When(Meter meter)
        {
            var centimeter = new Centimeter(100);
            return meter + centimeter;
        }

        private void Then(Meter result)
        {
            Assert.AreEqual(3, result.DisplayValue);
        }
    }

}