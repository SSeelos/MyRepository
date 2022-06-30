using Autofac.Features.Metadata;
using System.Reflection;

namespace MyDotNet6ConsoleApp.DependencyInjection
{
    public class MetaDependant
    {
        Meta<IDependencyA> _dependencyA;
        public MetaDependant(Meta<IDependencyA> dependencyA)
        {
            _dependencyA = dependencyA;
        }
        public void Run()
        {
            WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");

            //use meta data to make a decision
            if (_dependencyA.Metadata["meta data value"] != "check")
                return;

            _dependencyA.Value.Execute();
        }
    }
    public class TypedMetaDependant
    {
        Meta<IDependencyA, string> _dependencyA;
        public TypedMetaDependant(Meta<IDependencyA, string> dependencyA)
        {
            _dependencyA = dependencyA;
        }
        public void Run()
        {
            WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");

            //use meta data to make a decision
            if (_dependencyA.Metadata != "check")
                return;

            _dependencyA.Value.Execute();
        }
    }
}
