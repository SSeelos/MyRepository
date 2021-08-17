using MyLibrary.MyUtilities;
using System;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples.Strategy
{
    public interface IStrategy
    {
        void Execute(string data);
    }
    public class MyStrategyA : IStrategy
    {
        public void Execute(string data)
        {
            data += " A";
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(data);
        }
    }
    public class MyStrategyB : IStrategy
    {
        public void Execute(string data)
        {
            data += " B";
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(data);
        }
    }
}
