
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
            Console.WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");

            _dependencyA.Execute();
        }
    }
}
