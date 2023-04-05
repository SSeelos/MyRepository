namespace MyConsoleAppProject
{
    public interface IMyInterfaceA
    {
        void MyInterfaceAMethod();
    }

    public interface IMyInterfaceB
    {
        void MyInterfaceBMethod();
    }

    public interface IMyIntefaceAB : IMyInterfaceA, IMyInterfaceB
    {

    }
    public interface IMyIntefaceParam
    {
        void MyIntefaceParamMethod(string param);
    }
    public interface IMyIntefaceReturn
    {
        string MyIntefaceReturnMethod();
    }
    public interface IMyIntefaceParamReturn
    {
        string MyIntefaceParamReturnMethod(string param);
    }
}
