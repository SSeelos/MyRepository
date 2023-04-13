using MyLibrary_DotNETstd_2_1.MyUtilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Strategy
{
    public class MyNestedStrategy : INestedStrategy
    {
        public IStrategyA StrategyA { get; set; }

        public IStrategyB StrategyB { get; set; }

        public void Execute(ModelCtx model, string data)
        {
            data += " Nested";
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(data);
        }
    }
}
