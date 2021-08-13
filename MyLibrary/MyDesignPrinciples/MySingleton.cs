using System;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples
{
    public class MySingleton
    {
        private static MySingleton instance;
        public static MySingleton Instance => GetInstance();

        private MySingleton() { }

        private static MySingleton GetInstance()
        {
            return instance != null ? instance : new MySingleton();
        }

        public void DoSomething()
        {
            Console.WriteLine(this.GetType().Name + ": " + MethodBase.GetCurrentMethod().Name);
        }
        public void DoSomethingElse()
        {
            Console.WriteLine(this.GetType().Name + ": " + MethodBase.GetCurrentMethod().Name);
        }
    }
}
