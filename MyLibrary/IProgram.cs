using System;

namespace MyLibrary_DotNETstd_2_1
{
    public interface IProgram
    {
        void Run();
        void Close()
        {
            Console.WriteLine("PRESS ENTER TO CLOSE PROGRAM");
            Console.ReadLine();
            Console.Clear();
        }
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
        public void Run(IProgram program)
        {
            CurrentProgram = program;

            try
            {
                Console.WriteLine(program.GetType().Name);
                program.Run();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
