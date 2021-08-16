using System;

namespace MyLibrary.MyDesignPrinciples.MyStrategy
{
    public class MyContext
    {
        private IStrategy _strategy;
        public IStrategy Strategy
        {
            get => this._strategy;
            set => this._strategy = value;
        }
        public MyContext() { }
        public MyContext(IStrategy strategy)
        {
            this.Strategy = strategy;
        }

        public void ExecuteStrategy(string data)
        {
            try
            {
                this._strategy.Execute(data);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
