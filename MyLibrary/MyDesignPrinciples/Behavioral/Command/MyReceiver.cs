using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Command
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
