using Autofac;
using MyDotNet6ConsoleApp.DependencyInjection;
using MyDotNet6ConsoleApp.DependencyInjection.Handler;

namespace MyLibrary_DotNETstd_2_1
{
    public class MyDependencyInjectionProgram : IProgram
    {
        public MyDependencyInjectionProgram()
        {
        }
        public void Run()
        {
            //ExampleA();

            ExampleB();
        }

        private static void ExampleA()
        {
            //this is what we want to replace
            //var dependency = new Dependency();
            //var dependant = new Dependant(dependency);
            //dependant.Run();

            //IContainer? container = AutoFacConfig.ConfigureContainer();

            using (ILifetimeScope? scope = AutoFacConfig.Container.BeginLifetimeScope())
            {
                Dependant? dep = scope.Resolve<Dependant>();
                dep.Run();

                IDependant? dependant = scope.Resolve<IDependant>();
                dependant.Run();


            }
        }

        private static void ExampleB()
        {
            var container = AutoFacConfig.ConfigRegistrationSource();

            using (var scope = container.BeginLifetimeScope())
            {
                var componentA = scope.Resolve<ComponentA>();
                componentA.Execute();
                var componentB = scope.Resolve<ComponentB>();
                componentB.Execute();
            }
        }
    }
}
