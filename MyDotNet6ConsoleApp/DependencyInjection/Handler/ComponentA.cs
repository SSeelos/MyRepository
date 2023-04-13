using System.Reflection;

namespace MyDotNet6ConsoleApp.DependencyInjection.Handler
{
    internal class ComponentA
    {
        private HandlerA _handler;
        public ComponentA(HandlerA handler)
        {
            this._handler = handler;
        }
        public void Execute()
        {
            WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");

            var message = _handler.Handle($"{GetType().Name}: my message");
            WriteLine(message);
        }
    }
}
