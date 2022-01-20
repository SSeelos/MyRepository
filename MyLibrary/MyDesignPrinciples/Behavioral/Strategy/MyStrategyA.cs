using MyLibrary.MyUtilities;
using System;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples.Strategy
{
    public interface IStrategyA
    {
        void Execute(ModelCtx model, string data);
    }
    public class NullStrategyA : IStrategyA
    {
        public void Execute(ModelCtx model, string data)
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(data);
        }
    }
    public class MyStrategyA1 : IStrategyA
    {
        public void Execute(ModelCtx model, string data)
        {
            data += " A1";
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(data);
        }
    }
    public class MyStrategyA2 : IStrategyA
    {
        public void Execute(ModelCtx model, string data)
        {
            data += " A2";
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(data);
        }
    }
}
