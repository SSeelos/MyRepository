using System;

namespace MyLibrary_DotNETstd_2_1
{
    public class MyException : Exception
    {
        public MyException(string msg) : base(msg) { }
        public MyException(string msg, Exception e) : base(msg, e) { }
    }
}
