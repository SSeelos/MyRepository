using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyDotNet6ConsoleApp.Threading;

internal class SleepingThread : IThreadingExample
{
    public void Execute()
    {
        StartSleepingThread();
    }
    private void StartSleepingThread()
    {
        ThreadingProgram.Logger.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod(), Hirarchy.Title);

        ThreadStart threadStart = new ThreadStart(ThreadMethod_Sleep);
        var thread = new Thread(threadStart);
        thread.Name = "My Sleeping Thread";
        thread.Start();
    }

    public void ThreadMethod_Sleep()
    {
        ThreadingProgram.Logger.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

        ThreadingProgram.Logger.ThreadLog(Thread.CurrentThread);

        int sleepTime = 2000;

        WriteLine("Sleeping for {0} seconds", sleepTime / 1000);
        Thread.Sleep(sleepTime);
        WriteLine("Thread resumes");
    }
}
