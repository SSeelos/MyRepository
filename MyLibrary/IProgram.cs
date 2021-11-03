using System;

namespace MyLibrary
{
    public interface IProgram
    {
        void Run();
        void Close() => Console.Clear();
    }
}
