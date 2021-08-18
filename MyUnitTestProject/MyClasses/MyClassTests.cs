using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyConsoleAppProject.Tests
{
    [TestClass()]
    public class MyClassTests
    {
        private MyClass _myClass;
        private MyClass MyClass => _myClass != null ? _myClass : MyClassTest();

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
            MyClass.myProperty = 2;

            var myClass = MyClass;
            myClass.myProperty += 2;



            var result = MyClass.MyMethod();

            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void MyInterfaceFunctionTest()
        {
            MyClass.MyInterfaceFunction();
        }

        [TestMethod()]
        public void MyInterface2FunctionTest()
        {
            MyClass.MyInterfaceFunction();
        }
    }
}