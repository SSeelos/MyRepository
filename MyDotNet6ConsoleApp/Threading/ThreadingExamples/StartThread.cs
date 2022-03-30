
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyDotNet6ConsoleApp.Threading
{
    internal class StartThread : IThreadingExample
    {
        public void Execute()
        {
            StartNewThread();
        }
        //Threads are created by extending the Thread class.
        //The extended Thread class then calls the Start() method
        //to begin the child thread execution
        private void StartNewThread()
        {
            ThreadingProgram.Logger.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod(), MyLibrary_DotNETstd_2_1.MyUtilities.Hirarchy.Title);

            ThreadStart threadStart = new ThreadStart(ThreadMethod);
            Thread thread = new Thread(threadStart);
            thread.Name = "My StartThread";
            thread.Start();
        }

        public void ThreadMethod()
        {
            ThreadingProgram.Logger.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            ThreadingProgram.Logger.ThreadLog(Thread.CurrentThread);
        }

    }
}
