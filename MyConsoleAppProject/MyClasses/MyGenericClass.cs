using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleAppProject
{
    class MyGenericClass
    {

        public T[] CreateArray<T>(T first, T second)
        {
            return new T[] { first, second };
        }
    }
}
