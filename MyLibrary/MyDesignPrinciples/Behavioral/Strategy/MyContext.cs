namespace MyLibrary.MyDesignPrinciples.Strategy
{
    public class MyContext
    {
        //private IStrategyA _strategyA;
        public IStrategyA StrategyA { get; set; } = new NullStrategyA();
        //{
        //    get => this._strategyA;
        //    set => this._strategyA = value;
        //}
        //private IStrategyB _strategyB;
        public IStrategyB StrategyB { get; set; } = new NullStrategyB();
        //{
        //    get => this._strategyB;
        //    set => this._strategyB = value;
        //}

        public MyContext() { }
        public MyContext(IStrategyA strategyA, IStrategyB strategyB)
        {
            this.StrategyA = strategyA;
            this.StrategyB = strategyB;
        }

        public void ExecuteStrategyA(string data)
        {

            this.StrategyA.Execute(data);

        }
        public void ExecuteStrategyB(string data)
        {

            this.StrategyB.Execute(data);

        }
    }
}
