using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.DependencyInjection.Dependencies
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
