using Autofac;
using MyDotNet6ConsoleApp.DependencyInjection.Services;

namespace MyDotNet6ConsoleApp.DependencyInjection
{
    public class MyModule : Module
    {
        public bool CheckCondition { get; set; }
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register((IDependencyA dependency) => new Dependant(dependency));

            //builder
            //    .Register(c => new DependantA(c.Resolve<IDependencyA>(), c.Resolve<IDependencyB>()))
            //    .As<IDependant>();

            builder
                .Register(c => new DependantB(c.Resolve<IDependencyA>()))
                .As<IDependant>();

            if (CheckCondition)
                builder.Register(c => new DependencyA()).As<IDependencyA>();
            else
                builder.Register(c => new DependencyAB()).As<IDependencyA>();

            builder.Register(c => new DependencyB(c.Resolve<IDependencyA>())).As<IDependencyB>();
        }
    }
}
