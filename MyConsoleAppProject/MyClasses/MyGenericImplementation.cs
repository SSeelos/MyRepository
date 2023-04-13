using System;

namespace MyConsoleAppProject
{
    public class MyGenericImplementation : IMyGenericInterface<string>
    {
        public void Execute(string param)
        {
            throw new System.NotImplementedException();
        }
    }

    public class MyImplementation : IMyStringHandler, IMyOtherStringHandler
    {
        void IMyGenericInterface<string>.Execute(string param)
        {
            Console.WriteLine(param);
        }
    }
}
