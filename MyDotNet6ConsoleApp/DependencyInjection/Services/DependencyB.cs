using System.Reflection;

namespace MyDotNet6ConsoleApp.DependencyInjection.Services
{
    public class DependencyB : IDependencyB
    {
        IDependencyA _dependencyA;
        public DependencyB(IDependencyA dependencyA)
        {
            _dependencyA = dependencyA;
        }
        public void Execute()
        {
            Console.WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");

            _dependencyA.Execute();
        }
    }
}
