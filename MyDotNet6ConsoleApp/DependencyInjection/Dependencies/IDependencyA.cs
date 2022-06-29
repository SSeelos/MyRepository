namespace MyDotNet6ConsoleApp.DependencyInjection
{
    public interface IServiceA
    {
        void Execute();
    }
    public interface IDependencyA : IServiceA
    {
    }
}