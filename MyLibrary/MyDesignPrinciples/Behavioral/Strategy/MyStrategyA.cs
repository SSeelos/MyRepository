using MyLibrary.MyUtilities;
using System;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples.Strategy
{
    public interface IStrategyA
    {
        void Execute(string data);
    }
    public class MyStrategyA1 : IStrategyA
    {
        public void Execute(string data)
        {
            data += " A1";
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(data);
        }
    }
    public class MyStrategyA2 : IStrategyA
    {
        public void Execute(string data)
        {
            data += " A2";
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(data);
        }
    }
}
