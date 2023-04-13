using System;

namespace MyConsoleAppProject
{
    public struct MyStruct
    {
        public MyStruct(string a, string b)
        {
            A = a;
            B = b;
        }

        public string A { get; }
        public string B { get; set; }

        public void ToConsole()
        {
            Console.WriteLine(this.A + " " + this.B);
        }
    }
}
