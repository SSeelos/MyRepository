using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyConsoleAppProject.Tests
{
    [TestClass()]
    public class MyClassTests
    {

        [TestMethod()]
        public MyClass MyClassTest()
        {
            var myClass = new MyClass("value");

            Assert.IsNotNull(myClass);

            return myClass;
        }

        [TestMethod()]
        public void MyMethodTest()
        {
            //build
            var myClass = new MyClass("value");
            myClass.myProperty += 2;

            //operate
            var result = myClass.MyMethod();

            //check
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void MyInterfaceFunctionTest()
        {
            var myClass = new MyClass("value");
            myClass.MyInterfaceFunction();
        }

        [TestMethod()]
        public void MyInterface2FunctionTest()
        {
            var myClass = new MyClass("value");
            myClass.MyInterfaceFunction();
        }
    }
}