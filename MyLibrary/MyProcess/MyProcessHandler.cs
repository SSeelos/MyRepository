using MyLibrary.MyUtilities;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace MyLibrary.MyProcess
{
    public interface IProcessHandler
    {
        void Init(string fileName);
        void ReplaceProcess(string fileName);
        void Kill();
    }
    class MyProcessHandler : IProcessHandler
    {
        public static int? MyProcessId = null;
        public void Init(string fileName)
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            using (var myProcess = new Process())
            {
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = fileName;
                myProcess.EnableRaisingEvents = true;
                myProcess.Exited += new EventHandler(MyProcess_Exited);
                myProcess.Start();

                var machName = myProcess.MachineName;

                var name = myProcess.ProcessName;

                MyProcessId = myProcess.Id;

            }
        }
        private void MyProcess_Exited(object sender, EventArgs e)
        {
            Console.WriteLine("exited");
            Process.GetProcessById(MyProcessId.Value).Exited -= MyProcess_Exited;
        }

        public void ReplaceProcess(string fileName)
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod());

            this.Kill();

            this.StartProcess(fileName);

        }
        private void StartProcess(string fileName)
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod());

            if (!File.Exists(fileName))
            {
                return;
            }

            using (var process = new Process())
            {
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = fileName;
                process.Start();

                MyProcessId = process.Id;
            }

        }
        public void Kill()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod());

            if (MyProcessId == null)
                return;

            try
            {
                var process = Process.GetProcessById(MyProcessId.Value);

                process?.Kill();

            }
            catch
            {
                //nothing to kill, all good?
            }
        }
    }
}
