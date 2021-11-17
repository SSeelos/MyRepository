using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyDotNet6ConsoleApp.Threading
{
    public class AbortThreadExample : IThreadingExample
    {
        public void Execute()
        {
            var threadRef = new ThreadStart(ThreadMethod_Abort);

            var thread = new Thread(threadRef);
            thread.Name = "AbortThread";
            thread.Start();

            Thread.Sleep(2000);
        }
        private void ThreadMethod_Abort()
        {
            ThreadingProgram.Logger.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            TimeSpan timeSpan = TimeSpan.FromSeconds(5);
            var cancellationTokenSource = new CancellationTokenSource(timeSpan);


            try
            {
                VeryImportantWork(cancellationTokenSource.Token);
            }
            catch (TaskCanceledException ex)
            {
                WriteLine(ex.ToString());
            }
            finally
            {
                WriteLine("Dispose Token");

                cancellationTokenSource.Dispose();
            }
        }

        private static void VeryImportantWork(CancellationToken cancellationToken)
        {
            WriteLine(Thread.CurrentThread.Name + "Does some work: ");

            int length = 10;
            for (int i = 0; i < length; i++)
            {
                WriteLine(i);

                Thread.Sleep(1000);
                if (cancellationToken.IsCancellationRequested)
                    throw new TaskCanceledException();
            }
        }
    }
}
