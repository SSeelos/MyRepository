using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.MyDesignPrinciples.Strategy
{
    public interface INestedStrategy
    {
        IStrategyA StrategyA { get; }
        IStrategyB StrategyB { get; }
        void Execute(string data);
    }

    public class MyNestedContext
    {
        public INestedStrategy NestedStrategy { get; set; }
        public MyNestedContext()
        {

        }
        public MyNestedContext(INestedStrategy nestedStrategy)
        {
            this.NestedStrategy = nestedStrategy;
        }

        public void Execute(string data)
        {
            this.NestedStrategy.Execute(data);
        }
    }
}
