using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.MyDesignPrinciples.Strategy
{

    public interface IInheritanceStrategy
    {
        void Execute(string data);
    }

    public class MyInheritanceContext : MyContext
    {
        public IInheritanceStrategy IInheritanceStrategy { get; set; }
        public MyInheritanceContext(ModelCtx model)
            :base(model)
        {

        }
        public MyInheritanceContext(ModelCtx model,IInheritanceStrategy inheritanceStrategy,
            IStrategyA strategyA, IStrategyB strategyB)
            : base(model, strategyA, strategyB)
        {
            this.IInheritanceStrategy = inheritanceStrategy;
        }

        public void Execute(string data)
        {
            this.IInheritanceStrategy.Execute(data);
        }
    }
}
