using System.Reflection;

namespace MyDotNet6ConsoleApp.DependencyInjection.Handler
{
    public abstract class _Handler
    {
        public virtual string Handle(string message)
        {
            WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");

            return message;
        }
    }
    public class HandlerA : _Handler
    {
        public override string Handle(string message)
        {

            return "A " + base.Handle(message);
        }
    }
    public class HandlerB : _Handler
    {
        public override string Handle(string message)
        {

            return "B " + base.Handle(message);
        }
    }
}
