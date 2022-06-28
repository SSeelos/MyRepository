
using System.Reflection;

namespace MyDotNet6ConsoleApp.DependencyInjection
{
    public class DependantB : IDependant
    {
        IDependencyA _dependencyA;
        IDependencyB _dependencyB;
        public DependantB(IDependencyA dependencyA)
        {
            _dependencyA = dependencyA;
            _dependencyB = NullDependencyB.Instance;
        }
        public DependantB(IDependencyA dependencyA, IDependencyB dependencyB)
        {
            _dependencyA = dependencyA;
            _dependencyB = dependencyB;
        }
        public void Run()
        {
            Console.WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");


            _dependencyB.Execute();
            _dependencyA.Execute();
        }
    }
}
