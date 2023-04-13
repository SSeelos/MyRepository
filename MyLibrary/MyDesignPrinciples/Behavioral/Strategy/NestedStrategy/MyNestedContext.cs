using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Strategy
{
    public interface INestedStrategy
    {
        IStrategyA StrategyA { get; }
        IStrategyB StrategyB { get; }
        void Execute(ModelCtx model, string data);
    }

    public class MyNestedContext
    {
        public ModelCtx ctx { get; set; }
        public INestedStrategy NestedStrategy { get; set; }
        public MyNestedContext(ModelCtx model)
        {
            this.ctx = model;
        }
        public MyNestedContext(ModelCtx model,INestedStrategy nestedStrategy)
        {
            this.ctx=model;

            this.NestedStrategy = nestedStrategy;
        }

        public void Execute(string data)
        {
            this.NestedStrategy.Execute(this.ctx, data);
        }
        public void ExecuteStrategyA(string data)
        {
            this.NestedStrategy.StrategyA.Execute(this.ctx, data);
        }
        public void ExecuteStrategyB(string data)
        {
            this.NestedStrategy.StrategyB.Execute(this.ctx, data);
        }
    }
}
