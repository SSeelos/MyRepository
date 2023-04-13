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
            //arrange/build (given)
            var myClass = new MyClass("value");
            myClass.MyAutoProperty += 2;

            //act/operate (when)
            var result = myClass.MyMethod();

            //assert/check (then)
            Assert.AreEqual(2, result);
        }
        [TestMethod()]
        public void MyNewMethodTest()
        {
            MyClass myClass = new MyClass("value");
            _MyAbstractClass absClass = myClass;
            var newRes = myClass.MyNewMethod();
            var absRes = absClass.MyNewMethod();

            Assert.AreNotEqual(newRes, absRes);
            Assert.AreEqual("<MyClass>:<_MyAbstractClass>.MyNewMethod", newRes);
            Assert.AreEqual("<_MyAbstractClass>.MyNewMethod", absRes);
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
            myClass.MyInterfaceAMethod();
        }

        [TestMethod()]
        public void MyInterface2FunctionTest()
        {
            var myClass = new MyClass("value");
            myClass.MyInterfaceAMethod();
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

            Assert.AreEqual(objA.GetBaseStaticProperty(), _MyAbstractClass._myStaticProperty);
            Assert.AreEqual(objB.GetBaseStaticProperty(), _MyAbstractClass._myStaticProperty);
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
            var baseType = typeof(_MyAbstractClass);

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

        [TestMethod()]
        public void GetPrivateSet()
        {
            var instance = new MyClass();

            string get = instance.myGetPrivateSet;

            //(cant change from extern)
            //instance.myGetPrivateSet = "new";
            get = "new";

            Assert.IsTrue(!instance.myGetPrivateSet.Equals("new"));
        }
        [TestMethod()]
        public void ChangeGetPrivateSetTest()
        {
            var instance = new MyClass();

            string get = instance.myGetPrivateSet;

            //(cant change from extern)
            //instance.myGetPrivateSet = "new";
            //but the value can still get changed
            instance.ChangeGetPrivateSet("new");

            Assert.IsTrue(instance.myGetPrivateSet.Equals("new"));
        }

        [TestMethod()]
        public void Readonly()
        {
            var instance = new MyClass();

            string myReadonly = instance.myReadonly;
            //instance.myReadonly = "new";
            myReadonly = "new";

            Assert.AreEqual("new", myReadonly);
        }
    }
}