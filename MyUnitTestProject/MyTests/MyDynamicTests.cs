using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyConsoleAppProject;
using System.Collections.Generic;

namespace MyUnitTestProject.MyTests
{
    [TestClass]
    public class MyDynamicTests
    {
        [TestMethod]
        [DataRow(10, 10, 0, 10)]
        [DataRow(10, 11, 0, 10)]
        [DataRow(0, -1, 0, 10)]
        public void MinMaxTest(double expValue, double value, double min, double max)
        {
            var myClass = new MyClass() { Min = min, Max = max };

            myClass.MyClampedValue = value;

            Assert.AreEqual(expValue, myClass.MyClampedValue);
        }

        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void DynamicDataTest(double expValue, double value, double min, double max)
        {
            var myClass = new MyClass() { Min = min, Max = max };

            myClass.MyClampedValue = value;

            Assert.AreEqual(expValue, myClass.MyClampedValue);
        }

        private IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                -1, -1, -1, 0,
                -1, -10, -1,0,
                0, 1, -1, 0,
            };
        }
    }
}
