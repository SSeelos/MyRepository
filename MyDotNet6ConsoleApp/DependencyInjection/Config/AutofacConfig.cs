﻿using Autofac;
using Autofac.Configuration;
using Microsoft.Extensions.Configuration;

namespace MyDotNet6ConsoleApp.DependencyInjection
{
    public static class AutoFacConfig
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Dependant>();
            //register a class type,
            //when looking for the corresponding interface
            //return an instance of the class
            builder.RegisterType<DependantA>().As<IDependant>();
            //builder.RegisterType<DependantB>().As<IDependant>();  //depandant can easily be swapped

            //builder.RegisterType<DependencyA>().As<IDependencyA>();   //
            builder.RegisterExecutingAssemblyTypes(containsNamespace: "Dependencies");

            return builder.Build();
        }
        public static IContainer LambdaExpressionComponents()
        {
            var builder = new ContainerBuilder();

            builder.Register((IDependencyA dependencyA) => new Dependant(dependencyA));
            builder
                .Register(c => new DependantA(c.Resolve<IDependencyA>(), c.Resolve<IDependencyB>()))
                .As<IDependant>();
            builder
                .Register((IComponentContext ctx, IDependencyA dependencyA) => new DependantB(dependencyA, ctx.Resolve<IDependencyB>()))
                .As<IDependant>();

            builder.RegisterExecutingAssemblyTypes(containsNamespace: "Dependencies");

            return builder.Build();
        }
        public static IContainer ReflectionComponents()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Dependant>();
            //Autofac automatically uses the constructor for your class with the most parameters that are able to be obtained
            builder.RegisterType<DependantB>().As<IDependant>();
            builder.RegisterType<DependencyA>().As<IDependencyA>();

            return builder.Build();
        }
        public static IContainer ModuleConfig()
        {
            var builder = new ContainerBuilder();

            var module = new MyModule() { CheckCondition = true };
            builder.RegisterModule(module);

            return builder.Build();
        }
        public static IContainer JSONConfig()
        {
            var config = new ConfigurationBuilder();
            config.AddJsonFile("AutofacConfig.json");

            var module = new ConfigurationModule(config.Build());
            var builder = new ContainerBuilder();

            builder.RegisterModule(module);

            return builder.Build();
        }
    }
}
