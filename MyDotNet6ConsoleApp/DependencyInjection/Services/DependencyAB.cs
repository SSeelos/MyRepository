using System.Reflection;

namespace MyDotNet6ConsoleApp.DependencyInjection.Services
{
    public class DependencyAB : IDependencyA
    {
        public void Execute()
        {
            Console.WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");
        }
    }
}
