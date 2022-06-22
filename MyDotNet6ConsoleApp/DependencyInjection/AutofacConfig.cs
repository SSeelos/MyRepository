using Autofac;
using MyLibrary_DotNETstd_2_1.DependencyInjection.Dependencies;

namespace MyDotNet6ConsoleApp.DependencyInjection
{
    public static class AutoFacConfig
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            //register a class type,
            //when looking for the corresponding interface
            //return an instance of the class
            builder.RegisterType<DependantA>().As<IDependant>();
            //builder.RegisterType<DependantB>().As<IDependant>();  //depandant can easily be swapped
            builder.RegisterType<DependencyA>().As<IDependencyA>();

            builder.RegisterExecutingAssemblyTypes(containsNamespace: "Dependencies");

            return builder.Build();
        }
    }
}
