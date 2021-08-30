namespace MyLibrary.MyDesignPrinciples.Chain
{
    public class MyChainClient
    {
        public static void Run()
        {
            var handlerA = new MyHandlerA();
            var handlerB = new MyHandlerB();
            var handlerC = new MyHandlerC();
            handlerA.SetNext(handlerB);
            handlerB.SetNext(handlerC);

            handlerA.Execute("request");
        }
    }
}
