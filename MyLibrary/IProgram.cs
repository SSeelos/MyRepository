using System;

namespace MyLibrary_DotNETstd_2_1
{
    public interface IProgram
    {
        void Run();
        void Close() => Console.Clear();
    }

    public class ProgramRunner
    {
        private IProgram _currentProgram;
        public IProgram CurrentProgram
        {
            get { return _currentProgram; }
            set
            {
                if (_currentProgram != null)
                    _currentProgram.Close();

                _currentProgram = value;
            }
        }
        public void RunProgram(IProgram program)
        {
            CurrentProgram = program;

            try
            {
                program.Run();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
