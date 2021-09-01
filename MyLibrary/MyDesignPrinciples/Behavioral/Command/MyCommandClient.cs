namespace MyLibrary.MyDesignPrinciples.Command
{
    public class MyCommandClient
    {
        public static void Run()
        {
            var commandA = new MyCommandA();
            var invoker = new MyInvoker();
            invoker.SetCommand(commandA);
            invoker.ExecuteCommand();

            var receiver = new MyReceiver();
            var commandB = new MyCommandB(receiver,"param");
            invoker.SetCommand(commandB);
            invoker.ExecuteCommand();

        }
    }
}
