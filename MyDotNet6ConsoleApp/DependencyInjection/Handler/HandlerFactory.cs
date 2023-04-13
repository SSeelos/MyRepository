namespace MyDotNet6ConsoleApp.DependencyInjection.Handler
{
    public interface IHandlerFactory
    {
        T CreateHandler<T>() where T : _Handler;
    }
    internal class HandlerFactory : IHandlerFactory
    {
        public T CreateHandler<T>() where T : _Handler
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}
