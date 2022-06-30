using Autofac;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MyDotNet6ConsoleApp
{
    public static class ContainerBuilderExt
    {
        public static void RegisterExecutingAssemblyTypes(this ContainerBuilder containerBuilder, string containsNamespace)
        {
            containerBuilder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly(), containsNamespace);
        }
        public static void RegisterAssemblyTypes(this ContainerBuilder containerBuilder, Assembly assembly, string containsNamespace)
        {
            containerBuilder.RegisterAssemblyTypes(assembly)
                .Where(t => t.Namespace.Contains(containsNamespace))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == $"I{ t.Name}"));
        }
        public static void RegisterExecutingAssemblyTypes(this ContainerBuilder containerBuilder, string nameSuffix, string namespaceEnd)
        {
            containerBuilder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly(), nameSuffix, namespaceEnd);
        }
        public static void RegisterAssemblyTypes(this ContainerBuilder containerBuilder, Assembly assembly, string nameSuffix, string namespaceEnd)
        {
            containerBuilder.RegisterAssemblyTypes(assembly)
                .Where(t => t.Name.EndsWith(nameSuffix) && t.Namespace.EndsWith(namespaceEnd))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == $"I{ t.Name}"));
        }
        public static void RegisterAssemblyTypesAsImplementedInterfaces(this ContainerBuilder containerBuilder, Assembly assembly, string nameSuffix)
        {
            containerBuilder.RegisterAssemblyTypes(assembly)
                .Where(t => t.Name.EndsWith(nameSuffix))
                .AsImplementedInterfaces();
        }
        public static void RegisterAssemblyTypesAsImplementedInterfaces(this ContainerBuilder containerBuilder, Assembly assembly, Regex matchTypeName)
        {
            containerBuilder.RegisterAssemblyTypes(assembly)
                .Where(t => matchTypeName.IsMatch(t.Name))
                .AsImplementedInterfaces();
        }
        public static void RegisterAssemblyTypesAs(this ContainerBuilder containerBuilder, Assembly assembly, Regex matchTypeName)
        {
            containerBuilder.RegisterAssemblyTypes(assembly)
                .Where(t => matchTypeName.IsMatch(t.Name))
                .As(t => t.GetInterfaces().FirstOrDefault(i => matchTypeName.IsMatch(i.Name)));
        }

    }
}
