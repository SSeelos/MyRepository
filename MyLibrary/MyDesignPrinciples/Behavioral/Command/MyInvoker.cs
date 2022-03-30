using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Command
{
    public class MyInvoker
    {
        ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            command.Execute();
        }
    }
}
