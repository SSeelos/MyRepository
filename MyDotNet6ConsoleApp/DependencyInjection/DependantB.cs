using MyLibrary_DotNETstd_2_1.DependencyInjection.Dependencies;

namespace MyDotNet6ConsoleApp.DependencyInjection
{
    public class DependantB : IDependant
    {
        IDependencyA _dependencyA;
        IDependencyB _dependencyB;
        public DependantB(IDependencyA dependencyA, IDependencyB dependencyB)
        {
            _dependencyA = dependencyA;
            _dependencyB = dependencyB;
        }
        public void Run()
        {
            _dependencyB.Execute();
            _dependencyA.Execute();
        }
    }
}
