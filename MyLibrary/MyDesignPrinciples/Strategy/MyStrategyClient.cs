namespace MyLibrary.MyDesignPrinciples.Strategy
{
    class MyStrategyClient
    {
        public static void Run()
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
        }
    }
}
