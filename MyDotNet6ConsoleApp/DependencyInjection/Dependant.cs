
using MyDotNet6ConsoleApp.DependencyInjection.Services;
using System.Reflection;

namespace MyDotNet6ConsoleApp.DependencyInjection
{
    public class Dependant
    {
        IDependencyA _dependencyA;
        public Dependant(IDependencyA dependencyA)
        {
            _dependencyA = dependencyA;
        }
        public void Run()
        {
            WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");

            _dependencyA.Execute();
        }
    }
}
