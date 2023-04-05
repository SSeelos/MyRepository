namespace MyConsoleAppProject
{
    public interface IMyGenericInterface<T>
    {
        void Execute(T param);
    }
    public interface IMyStringHandler : IMyGenericInterface<string>
    { }
    public interface IMyOtherStringHandler : IMyGenericInterface<string>
    { }
    public interface IMyStringHandlers
        : IMyStringHandler, IMyOtherStringHandler
    { }
    public interface IMyGenericInterfaceReturn<T>
    {
        T Execute();
    }
    public interface IMyGenericInterfaceParamReturn<T>
    {
        T Execute(T param);
    }
}
