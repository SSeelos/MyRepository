using System;
using System.Reflection;

namespace MyConsoleAppProject
{
    public static class MyStaticClass
    {
        public static string MyProperty { get; set; }

        public static string MyMethod(string dataA, string dataB)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);

            return dataA + dataB;
        }

        public static string MyExtensionMethod(this MySealedClass subject)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);

            return subject.MyProperty + "extended";
        }

    }
}
