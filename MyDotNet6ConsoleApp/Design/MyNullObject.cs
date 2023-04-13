using MyConsoleAppProject;

namespace MyDotNet6ConsoleApp
{
    //null object pattern
    public sealed class MyNullInterfaceA : IMyInterfaceA
    {
        private static readonly IMyInterfaceA nullInterfaceA = new MyNullInterfaceA();
        private MyNullInterfaceA() { }
        public static IMyInterfaceA Instance => nullInterfaceA;
        public void MyInterfaceAMethod()
        {
            //do nothing
        }
    }
}
