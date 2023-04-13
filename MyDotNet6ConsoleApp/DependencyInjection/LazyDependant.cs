using MyDotNet6ConsoleApp.DependencyInjection.Services;
using System.Reflection;

namespace MyDotNet6ConsoleApp.DependencyInjection
{
    public class LazyDependant
    {
        Lazy<IDependencyA> _dependencyA;
        public LazyDependant(Lazy<IDependencyA> dependencyA)
        {
            _dependencyA = dependencyA;


        }
        public void Run()
        {
            Console.WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");

            _dependencyA.Value.Execute();
        }
    }
}
