using MySystemExtensions;
using System;
using System.Reflection;

namespace MyConsoleAppProject
{
    public interface IMyInterface
    {
        void MyInterfaceMethod();
    }
    public abstract class _MyAbstractClass : IMyInterface
    {
        public static string _myStaticProperty;
        //only accessible from this class
        private string myField;

        //only accessible from derived classes
        protected string myProtectedVariable;

        public _MyAbstractClass()
        {

        }
        public _MyAbstractClass(string field)
        {
            this.myField = field;
        }
        public string GetField() => this.myField;
        public void MyInterfaceMethod()
        {
            Console.WriteLine($"{GetType().BaseType.Name}.{MethodBase.GetCurrentMethod().Name}");
        }

        /// <summary>
        /// derived classes CAN override virtual method
        /// </summary>
        protected virtual void MyProtectedVirtualMethod()
        {
            Console.WriteLine($"{GetType().BaseType.Name}.{MethodBase.GetCurrentMethod().Name}");

            //default implementation...
        }
        public virtual void MyPublicVirtualMethod()
        {
            Console.WriteLine($"{GetType().BaseType.Name}.{MethodBase.GetCurrentMethod().Name}");

            //default implementation...
        }

        /// <summary>
        /// derived classes MUST override abstract methods
        /// </summary>
        protected abstract void _MyProtectedAbstractMethod();
        public abstract void _MyPublicAbstractMethod();

        public void MyMethodOfAbstractClass()
        {
            Console.WriteLine($"{GetType().BaseType.Name}.{MethodBase.GetCurrentMethod().Name}");

            MyProtectedVirtualMethod();

            _MyProtectedAbstractMethod();
        }
        /// <summary>
        /// use the new keyword in the derived class to test the behaviour
        /// (any derived class cast to this abstract class will call this method rather than the "new" method of the derived class)
        /// </summary>
        /// <returns></returns>
        public string MyNewMethod()
        {
            string msg2 = $"{MethodBase.GetCurrentMethod().Display()}";
            string msg = $"{GetType().BaseType.Name}.{MethodBase.GetCurrentMethod().Name}";
            Console.WriteLine(msg);

            return msg;
        }


    }
}
