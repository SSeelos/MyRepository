using MyLibrary_DotNETstd_2_1.MyUtilities;
using System;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Strategy
{
    public interface IStrategyB
    {
        void Execute(ModelCtx model, string data);
    }
    public class NullStrategyB : IStrategyB
    {
        public void Execute(ModelCtx model, string data)
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(data);
        }
    }
    public class MyStrategyB1 : IStrategyB
    {
        public void Execute(ModelCtx model, string data)
        {
            data += " B1";
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(data);
        }
    }
    public class MyStrategyB2 : IStrategyB
    {
        public void Execute(ModelCtx model, string data)
        {
            data += " B2";
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(data);
        }
    }
}
