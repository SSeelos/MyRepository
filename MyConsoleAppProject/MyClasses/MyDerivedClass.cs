using System;
using System.Reflection;

namespace MyConsoleAppProject
{
    public class MyDerivedClass : MyClass
    {
        public new double MyMethod()
        {
            base.MyMethod();

            Console.WriteLine("New " + MethodBase.GetCurrentMethod().Name);

            return 0;
        }
    }
}
