using MyLibrary_DotNETstd_2_1.DependencyInjection.Dependencies;

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
            _dependencyA.Execute();
            _dependencyB.Execute();
        }
    }
}
