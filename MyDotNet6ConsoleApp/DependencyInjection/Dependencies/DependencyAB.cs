using System.Reflection;

namespace MyDotNet6ConsoleApp.DependencyInjection
{
    public class DependencyAB : IDependencyA
    {
        public void Execute()
        {
            Console.WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");
        }
    }
}
