using MyConsoleAppProject;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace MyNUnitTestProject.MyTests
{
    internal class MyTestCaseSource
    {

        /// <summary>
        /// https://docs.nunit.org/articles/nunit/writing-tests/attributes/testcasesource.html
        /// 
        /// The single attribute argument in this form is a string representing the name of the source used to provide test cases. 
        /// It has the following characteristics:
        ///     It may be a field, property or method in the test class.
        ///     It must be static.
        ///     It must return an IEnumerable or a type that implements IEnumerable.
        ///         For fields an array is generally used. 
        ///         For properties and methods, you may return an array or implement your own iterator.
        ///     The individual items returned by the enumerator must be compatible with the signature of the method on which the attribute appears.
        /// </summary>
        [TestCaseSource(nameof(MyCases))]
        public void MyTestCases(double value, double max, double exp)
        {
            var myClass = new MyClass { Max = max, };

            myClass.MyValue = value;

            Assert.AreEqual(exp, myClass.MyValue);
        }

        static object[] MyCases =
        {
            new object[] { 11, 10, 10 },
            new object[] { 10, 1,1},
            new object[] { 200, 100,100}
        };

        [TestCaseSource(nameof(MyCasesEnumerable))]
        public void MyTestCasesEnumerable(double value, double max, double exp)
        {
            var myClass = new MyClass { Max = max, };

            myClass.MyValue = value;

            Assert.AreEqual(exp, myClass.MyValue);
        }

        static IEnumerable<object[]> MyCasesEnumerable()
        {
            yield return new object[] { 11, 10, 10 };
            yield return new object[] { 10, 1, 1 };
            yield return new object[] { 200, 100, 100 };
        }

        [TestCaseSource(typeof(MyEnumerable))]
        public void MyTestCasesEnumerator(double value, double max, double exp)
        {
            var myClass = new MyClass { Max = max, };

            myClass.MyValue = value;

            Assert.AreEqual(exp, myClass.MyValue);
        }

    }
    public class MyEnumerable : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 11, 10, 10 };
            yield return new object[] { 10, 1, 1 };
            yield return new object[] { 200, 100, 100 };
        }
    }
}

