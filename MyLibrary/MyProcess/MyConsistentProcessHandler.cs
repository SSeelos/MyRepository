using MyLibrary.MyUtilities;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace MyLibrary.MyProcess
{
    class MyConsistentProcessHandler : IProcessHandler
    {
        private Process myProcess;
        private void MyProcess_Exited(object sender, EventArgs e)
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod());

            myProcess.Exited -= MyProcess_Exited;
        }

        public void ReplaceProcess(string fileName)
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod());

            this.Kill();

            this.StartProcess(fileName);

        }
        public void StartProcess(string fileName)
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod());

            if (!File.Exists(fileName))
            {
                return;
            }


            var info = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = fileName

            };
            myProcess = new Process()
            {
                StartInfo = info,
                EnableRaisingEvents = true,

            };
            myProcess.Start();

            myProcess.Exited += MyProcess_Exited;
        }
        public void Kill()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod());

            if (myProcess == null || myProcess.HasExited)
                return;

            myProcess.Exited -= MyProcess_Exited;

            if (myProcess.CloseMainWindow())
                return;


            myProcess.Kill();

        }
    }
}
