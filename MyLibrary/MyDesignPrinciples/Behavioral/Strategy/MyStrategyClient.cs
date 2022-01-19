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

        private static void ExampleInheritance(MyContext context)
        {
            var inhertianceContext = new MyInheritanceContext()
            {
                StrategyA = context.StrategyA,
                StrategyB = context.StrategyB,

                IInheritanceStrategy = new MyInheritanceStrategy()
            };

            inhertianceContext.ExecuteStrategyA("MyDataAInheritance");
            inhertianceContext.ExecuteStrategyB("MyDataBInheritance");

            inhertianceContext.Execute("MyDataInheritance");
        }

        private static void ExampleNested(MyContext context)
        {
            var nestedContext = new MyNestedContext()
            {
                NestedStrategy = new MyNestedStrategy()
                {
                    StrategyA = context.StrategyA,
                    StrategyB = context.StrategyB,
                },
            };

            nestedContext.NestedStrategy.StrategyA.Execute("MyDataANested");
            nestedContext.NestedStrategy.StrategyB.Execute("MyDataBNested");

            nestedContext.Execute("MyNestedData");
        }

        private static MyContext ExampleA()
        {
            var context = new MyContext()
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

            var nullContext = new MyContext();
            nullContext.ExecuteStrategyA("");
            nullContext.ExecuteStrategyB("");

            return context;
        }
    }
}
