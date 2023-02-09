using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyConsoleAppProject.Tests
{
    [TestClass()]
    public class MyStaticClassTests
    {
        [TestMethod()]
        public void MyPropertyTest()
        {
            var dataA = "static class property";
            MyStaticClass.MyProperty = dataA;

            var dataB = " is awesome";
            MyStaticClass.MyProperty += dataB;

            Assert.AreEqual(dataA + dataB, MyStaticClass.MyProperty);
        }
        [TestMethod()]
        public void MyMethodTest()
        {
            var dataA = "static class property";
            var dataB = " is awesome";


            var result = MyStaticClass.MyMethod(dataA, dataB);

            Assert.AreEqual(result, dataA + dataB);
        }
        [TestMethod()]
        public void MyExtensionMethodTest()
        {
            var mySealedClass = new MySealedClass();
            var result = mySealedClass.MyExtensionMethod();

            Assert.AreEqual(mySealedClass.MyProperty + "extended", result);
        }
    }
}