using MyLibrary;
using MyLibrary.MyUtilities;
using System.Reflection;

namespace MyDotNet6ConsoleApp;

internal class ThreadingProgram : IProgram
{
    public static ILogger Logger = MyConsoleLogger.Instance;
    public void Run()
    {
        Logger.MethodLog(MethodBase.GetCurrentMethod());

        ThreadStart threadStart = new ThreadStart(ThreadMethod);
        Thread thread = new Thread(threadStart);
        thread.Start();
    }

    public static void ThreadMethod()
    {
        Logger.MethodLog(MethodBase.GetCurrentMethod());
        Thread.CurrentThread.Name = "My Thread";

        WriteLine(Thread.CurrentThread.Name);


    }
}



