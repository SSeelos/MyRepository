using System.Reflection;

namespace MyDotNet6ConsoleApp.DependencyInjection
{
    public class DependencyA : IServiceA
    {
        public void Execute()
        {
            Console.WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");
        }
    }
}
