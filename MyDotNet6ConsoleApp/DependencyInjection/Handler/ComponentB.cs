using System.Reflection;

namespace MyDotNet6ConsoleApp.DependencyInjection.Handler
{
    internal class ComponentB
    {
        private HandlerB _handler;
        public ComponentB(HandlerB handler)
        {
            _handler = handler;
        }
        public void Execute()
        {
            WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");

            var message = _handler.Handle("handle message");
            WriteLine(message);
        }
    }
}
