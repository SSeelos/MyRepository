using MyDotNet6ConsoleApp.Threading;
using MyLibrary_DotNETstd_2_1;
using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyDotNet6ConsoleApp;

internal class ThreadingProgram : IProgram
{
    public static ILogger Logger = MyConsoleLogger.Instance;
    public void Run()
    {
        Logger.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

        var examples = new ThreadingExamples(
            new SleepingThread(),
            new StartThread(),
            new AbortThreadExample(),
            new ThreadLocalExample(),
            new MyTaskExample());

        examples.Execute();
    }

    public void ExecuteExample(IThreadingExample example)
    {
        example.Execute();
    }
}



