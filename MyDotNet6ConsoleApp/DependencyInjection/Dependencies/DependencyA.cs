using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.DependencyInjection.Dependencies
{
    public class DependencyA : IDependencyA
    {
        public void Execute()
        {
            Console.WriteLine($"{GetType().Name} {MethodBase.GetCurrentMethod().Name}");
        }
    }
}
