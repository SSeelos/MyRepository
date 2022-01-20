namespace MyLibrary.MyDesignPrinciples.Strategy
{
    class MyStrategyClient
    {
        public static void Run()
        {
            MyContext context = ExampleA();

            ExampleNested(context);

            ExampleInheritance(context);
        }

        private static MyContext ExampleA()
        {
            var model = new ModelCtx();

            var context = new MyContext(model)
            {
                StrategyA = new MyStrategyA1(),
                StrategyB = new MyStrategyB1()
            };

            context.ExecuteStrategyA("MyDataA1");
            context.ExecuteStrategyB("MyDataB1");

            context.StrategyA = new MyStrategyA2();
            context.StrategyB = new MyStrategyB2();

            context.ExecuteStrategyA("MyDataA2");
            context.ExecuteStrategyB("MyDataB2");

            var nullContext = new MyContext(model);
            nullContext.ExecuteStrategyA("");
            nullContext.ExecuteStrategyB("");

            return context;
        }
        private static void ExampleNested(MyContext context)
        {
            var nestedContext = new MyNestedContext(context.ctx)
            {
                NestedStrategy = new MyNestedStrategy()
                {
                    StrategyA = context.StrategyA,
                    StrategyB = context.StrategyB,
                },
            };

            nestedContext.ExecuteStrategyA("MyDataANested");
            nestedContext.ExecuteStrategyB("MyDataBNested");

            nestedContext.Execute("MyNestedData");
        }
        private static void ExampleInheritance(MyContext context)
        {
            var inhertianceContext = new MyInheritanceContext(context.ctx)
            {
                StrategyA = context.StrategyA,
                StrategyB = context.StrategyB,

                IInheritanceStrategy = new MyInheritanceStrategy()
            };

            inhertianceContext.ExecuteStrategyA("MyDataAInheritance");
            inhertianceContext.ExecuteStrategyB("MyDataBInheritance");

            inhertianceContext.Execute("MyDataInheritance");
        }


    }
}
