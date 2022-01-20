namespace MyLibrary.MyDesignPrinciples.Strategy
{
    public class MyContext
    {
        public ModelCtx ctx;
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

        public MyContext(ModelCtx model) 
        { 
            this.ctx = model; 
        }
        public MyContext(ModelCtx model, IStrategyA strategyA, IStrategyB strategyB)
        {
            this.ctx=model;

            this.StrategyA = strategyA;
            this.StrategyB = strategyB;
        }

        public void ExecuteStrategyA(string data)
        {

            this.StrategyA.Execute(ctx, data);

        }
        public void ExecuteStrategyB(string data)
        {

            this.StrategyB.Execute(ctx, data);

        }
    }

    public class ModelCtx
    {
        public void New<T>() { }
    }
}
