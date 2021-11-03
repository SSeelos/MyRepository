using System;

namespace MyLibrary.MyProcess
{
    public class MyProcessProgram : IProgram
    {
        IProcessHandler processHandler = new MyProcessHandler();
        //private Process myProcess;
        public void Run()
        {
            processHandler.Init(@"C:\Temp\12254_angebot_NR390.ifc");

            Console.ReadLine();
            processHandler.ReplaceProcess(@"C:\Temp\1825786_angebot_NR1351.ifc");

            Console.ReadLine();
            processHandler.Kill();
        }
    }
}
