using MyConsoleAppProject;
using NUnit.Framework;

namespace MyNUnitTestProject.MyTests
{
    /// <summary>
    /// https://docs.nunit.org/articles/nunit/writing-tests/attributes/testcase.html

    /// </summary>
    public class MyTestCase
    {
        /// <summary>
        /// marking a method with parameters as a test method 
        /// and providing inline data to be used when invoking that method.
        /// </summary>
        [TestCase(11, 10, 10)]
        [TestCase(10, 1, 1)]
        public void MinMaxTest(double value, double max, double exp)
        {
            var myClass = new MyClass { Max = max, };

            myClass.MyValue = value;

            Assert.AreEqual(exp, myClass.MyValue);
        }

        [TestCase(11, 10, ExpectedResult = 10)]
        [TestCase(10, 1, ExpectedResult = 1)]
        public double MinMaxTestReturn(double value, double max)
        {
            var myClass = new MyClass { Max = max, };

            myClass.MyValue = value;

            return myClass.MyValue;
        }
    }
}
