namespace MyLibrary.MyDesignPrinciples.Decorator
{
    class MyDecoratorClient
    {
        public static void Run()
        {
            var comp = new MyComponent("data");
            var decoratorA = new MyDecoratorA(comp);
            decoratorA.Execute();
            var decoratorB = new MyDecoratorB(comp);
            decoratorB.Execute();

            var manager = new MyManager(decoratorA);
            manager.UseComponent();
        }
    }
}
