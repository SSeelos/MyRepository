using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

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
        [TestMethod()]
        public void MyBaseStaticPropertyTest()
        {
            var dataA = "A";
            var objA = new MyClass("value");
            objA.SetBaseStaticProperty(dataA);
            var dataB = "B";
            var objB = new MyClassB("value");
            objB.SetBaseStaticProperty(dataB);

            Assert.AreEqual(objA.GetBaseStaticProperty(), MyAbstractClass._myStaticProperty);
            Assert.AreEqual(objB.GetBaseStaticProperty(), MyAbstractClass._myStaticProperty);
        }


        [TestMethod()]
        public void GetClassTypeTest()
        {
            var myClass = new MyClass();

            var type = typeof(MyClass);

            Assert.AreEqual(myClass.GetType(), type);
            Assert.AreEqual("MyClass", type.Name);
            Assert.AreEqual("MyConsoleAppProject.MyClass", type.FullName);
        }

        [TestMethod()]
        public void GetBaseClassTypeTest()
        {
            var type = typeof(MyClass);
            var baseType = typeof(MyAbstractClass);

            Assert.AreEqual(baseType, type.BaseType);
            Assert.AreEqual("MyAbstractClass", type.BaseType.Name);
            Assert.AreEqual("MyConsoleAppProject.MyAbstractClass", type.BaseType.FullName);
        }

        [TestMethod()]
        public void GetRuntimeMethodHandleTest()
        {
            var myclass = new MyClass();

            RuntimeMethodHandle methH = myclass.GetRuntimeMethodHandle();
            MethodBase methHMeth = MethodBase.GetMethodFromHandle(methH);

            Assert.AreEqual("GetRuntimeMethodHandle", methHMeth.Name);
        }

        [TestMethod()]
        public void GetRuntimeMethodHandleFromTypeTest()
        {
            var classType = typeof(MyClass);

            //var runTimeM = classType.GetRuntimeMethods();
            var meth = classType.GetMethods();

            string name = "";
            foreach (var m in meth)
            {
                if (m.Name == "GetRuntimeMethodHandle")
                    name = m.Name;
            }

            Assert.AreEqual("GetRuntimeMethodHandle", name);
        }
    }
}