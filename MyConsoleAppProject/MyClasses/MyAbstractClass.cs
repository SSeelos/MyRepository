using System;
using System.Reflection;

namespace MyConsoleAppProject
{
    public abstract class MyAbstractClass
    {
        public static string _myStaticProperty;
        //only accessible from this class
        private string myField;

        //only accessible from derived classes
        protected string myProtectedVariable;

        public MyAbstractClass(string field)
        {
            this.myField = field;
        }

        //derived classes can override virtual method
        protected virtual void MyProtectedVirtualMethod()
        {
            Console.WriteLine($"{GetType().Name} - {MethodBase.GetCurrentMethod().Name}");

            //default implementation...
        }
        public virtual void MyPublicVirtualMethod()
        {
            Console.WriteLine($"{GetType().Name} - {MethodBase.GetCurrentMethod().Name}");

            //default implementation...
        }

        //derived classes must override abstract method
        protected abstract void MyProtectedAbstractMethod();
        public abstract void MyPublicAbstractMethod();

        public void MyMethodOfAbstractClass()
        {
            Console.WriteLine($"{GetType().Name} - {MethodBase.GetCurrentMethod().Name}");

            MyProtectedVirtualMethod();

            MyProtectedAbstractMethod();
        }
    }
}
