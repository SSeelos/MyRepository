using System.Reflection;

namespace MyDotNet6ConsoleApp.DependencyInjection.Services
{
    public interface IDependencyB : IService
    {
        void Execute();
    }
    public class NullDependencyB : IDependencyB
    {
        public static readonly NullDependencyB Instance = new NullDependencyB();
        public void Execute()
        {
            Console.WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");
        }
    }
}