using MyLibrary.MyUtilities;
using System;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples.Strategy
{
    public interface IStrategyB
    {
        void Execute(string data);
    }
    public class MyStrategyB1 : IStrategyB
    {
        public void Execute(string data)
        {
            data += " B1";
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(data);
        }
    }
    public class MyStrategyB2 : IStrategyB
    {
        public void Execute(string data)
        {
            data += " B2";
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(data);
        }
    }
}
