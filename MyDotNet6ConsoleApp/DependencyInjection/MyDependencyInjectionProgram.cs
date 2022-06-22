﻿using Autofac;
using MyDotNet6ConsoleApp.DependencyInjection;

namespace MyLibrary_DotNETstd_2_1
{
    public class MyDependencyInjectionProgram : IProgram
    {
        public MyDependencyInjectionProgram()
        {
        }
        public void Run()
        {
            //this is what we want to replace
            //var dependency = new Dependency();
            //var dependant = new Dependant(dependency);
            //dependant.Run();

            var container = AutoFacConfig.ConfigureContainer();

            using (ILifetimeScope? scope = container.BeginLifetimeScope())
            {
                IDependant? dependant = scope.Resolve<IDependant>();
                dependant.Run();
            }

        }
    }
}
