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
            //build (given)
            var myClass = new MyClass("value");
            myClass.myProperty += 2;

            //operate (when)
            var result = myClass.MyMethod();

            //check (then)
            Assert.AreEqual(2, result);
        }
        [TestMethod()]
        public void MyStaticPropertyTest()
        {
            var dataA = "A";
            var objA = new MyClass("value");
            objA.SetStaticProperty(dataA);

            Assert.AreEqual(dataA, MyClass.myStaticProperty);


            var data2 = ", ";
            MyClass.myStaticProperty += data2;

            Assert.AreEqual(dataA + data2, MyClass.myStaticProperty);

            var dataB = "B";
            var objB = new MyClass("value");
            objB.SetStaticProperty(dataB);

            Assert.AreEqual(dataB, MyClass.myStaticProperty);
            Assert.AreEqual(objA.GetStaticProperty(), objB.GetStaticProperty());

        }
        [TestMethod()]
        public void MyStaticMethodTest()
        {
            MyClass.MyStaticMethod();

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