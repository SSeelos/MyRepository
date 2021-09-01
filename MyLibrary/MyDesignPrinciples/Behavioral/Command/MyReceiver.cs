using MyLibrary.MyUtilities;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples.Command
{
    public interface IReceiver
    {
        void Operation(string data);
    }
    public class MyReceiver : IReceiver
    {
        public void Operation(string data)
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());
        }
    }
}
