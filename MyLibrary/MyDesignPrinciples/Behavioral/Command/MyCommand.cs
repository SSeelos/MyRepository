using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Command
{
    public interface ICommand
    {
        void Execute();
    }
    public class MyCommandA : ICommand
    {
        public void Execute()
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());
        }
    }
    public class MyCommandB : ICommand
    {
        IReceiver receiver;
        string param;
        public MyCommandB(IReceiver receiver, string param)
        {
            this.receiver = receiver;
            this.param = param;

        }
        public void Execute()
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            receiver.Operation(param);
        }
    }
}
