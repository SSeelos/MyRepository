
using MyDotNet6ConsoleApp.DependencyInjection.Services;
using System.Reflection;

namespace MyDotNet6ConsoleApp.DependencyInjection
{
    public class DependantA : IDependant
    {
        IDependencyA _dependencyA;
        IDependencyB _dependencyB;
        public DependantA(IDependencyA dependencyA, IDependencyB dependencyB)
        {
            _dependencyA = dependencyA;
            _dependencyB = dependencyB;
        }
        public void Run()
        {
            Console.WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");

            _dependencyA.Execute();
            _dependencyB.Execute();
        }
    }
}
