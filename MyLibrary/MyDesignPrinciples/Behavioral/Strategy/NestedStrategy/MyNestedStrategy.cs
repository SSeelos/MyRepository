using MyLibrary.MyUtilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLibrary.MyDesignPrinciples.Strategy
{
    public class MyNestedStrategy : INestedStrategy
    {
        public IStrategyA StrategyA { get; set; }

        public IStrategyB StrategyB { get; set; }

        public void Execute(string data)
        {
            data += " Nested";
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(data);
        }
    }
}
