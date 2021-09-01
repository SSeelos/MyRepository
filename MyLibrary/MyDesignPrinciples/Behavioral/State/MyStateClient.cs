namespace MyLibrary.MyDesignPrinciples.State
{
    public class MyStateClient
    {
        public static void Run()
        {
            var stateA = new MyStateA();
            var context = new MyContext(stateA);
            DoStuff(context);
            DoStuff(context);

            var stateB = new MyStateB();
            context.ChangeState(stateB);
            DoStuff(context);
        }
        private static void DoStuff(MyContext context)
        {
            context.DoSomething();
            context.SwitchState();

        }
    }
}
