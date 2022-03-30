namespace MyLibrary_DotNETstd_2_1.MyProcess
{
    public class MyProcessProgram : IProgram
    {
        //private Process myProcess;
        public void Run()
        {
            //RunProcess(new MyProcessHandler());

            RunProcess(new MyConsistentProcessHandler());
        }

        private void RunProcess(IProcessHandler processHandler)
        {
            processHandler.StartProcess(@"C:\Temp\12254_angebot_NR390.ifc");

            processHandler.ReplaceProcess(@"C:\Temp\1825786_angebot_NR1351.ifc");

        }
    }
}
